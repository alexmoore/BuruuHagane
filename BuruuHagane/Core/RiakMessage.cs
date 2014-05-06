using System;

namespace BuruuHagane.Core
{
	public class RiakMessage
	{
		public RiakMessage (byte code, byte[] data)
		{
			Code = code;
			Data = data;
		}

		public byte Code { get; private set; }
		public byte[] Data { get; private set; }
	}
}

