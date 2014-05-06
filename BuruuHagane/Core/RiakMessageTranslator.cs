using System;
using BuruuHagane.Util;

namespace BuruuHagane.Core
{
	public static class RiakMessageTranslator
	{
		public static byte[] Encode(RiakMessage message)
		{
			// Create array to hold encoded message
			byte[] encodedMessage = new byte[message.Data.Length + RiakPBIndices.MsgHeader_Length];

			// Convert Message Body Length to bytes, adding 1 for Message Code
			byte[] msgLength = BitConverter.GetBytes ((UInt32)message.Data.Length + 1);

			// Reverse messag elength array because we are assuming Little Endian here, Riak is expecting Big Endian encoding
			Array.Reverse(msgLength);

			// Copy Length, MsgCode, then Message
			Array.Copy(msgLength, encodedMessage, RiakPBIndices.MsgLength_Length);
			encodedMessage[RiakPBIndices.MsgCode_Index] = message.Code;
			Array.ConstrainedCopy (message.Data, 0, encodedMessage, RiakPBIndices.MsgBody_StartIndex, message.Data.Length);
			return encodedMessage;
		}

		public static RiakMessage Decode (byte[] response, int messageLength)
		{
			// Copy out the 4 bytes that tell us how long the message is.
			byte[] pbResponseLengthArr = new byte[RiakPBIndices.MsgLength_Length];
			Array.Copy (response, pbResponseLengthArr, 4);

			// Reverse because we assume Little Endian HW, and Big Endian message ordering
			Array.Reverse (pbResponseLengthArr);

			// Convert 4 bytes to UInt32, subtract 1 for Message Code byte
			UInt32 messageBodyLength = BitConverter.ToUInt32 (pbResponseLengthArr, 0) - 1;

			// Copy out message body
			byte[] messageBody = new byte[messageBodyLength];
			Array.ConstrainedCopy (response, RiakPBIndices.MsgBody_StartIndex, messageBody, 0, (int)messageBodyLength); // I hope we never had a 2GB message, casting to int

			// Create container object and return it
			var message = new RiakMessage(response[RiakPBIndices.MsgCode_Index], messageBody);
			return message;
		}
	}
}

