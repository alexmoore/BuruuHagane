using System;

namespace BuruuHagane.Util
{
	public static class RiakPBIndices
	{
		// Riak PB Message Code Byte Layout

		// [ Message Length | Message Code | Message Body ]
		// [  0 | 1 | 2 | 3 |        4     | 5 . . . . n  ]

		// Message Length is 4 bytes (Big Endian encoded Unsigned Int32)
		// Message Code is 1 byte
		// Message Length + Message Code = Message Header
		// Message Body is remainder, can be blank (0 length)

		public static int MsgLength_StartIndex = 0;
		public static int MsgCode_Index = 4;
		public static int MsgBody_StartIndex = 5;

		public static int MsgLength_Length = 4;
		public static int MsgHeader_Length = 5;


	}
}

