using System;

namespace BuruuHagane.Util
{
	public static class RiakMessageCodes
	{
		public static byte ErrorResp = 0;
		public static byte PingReq = 1;
		public static byte PingResp = 2;
		public static byte GetClientIdReq = 3;
		public static byte GetClientIdResp = 4;
		public static byte SetClientIdReq = 5;
		public static byte SetClientIdResp = 6;
		public static byte GetServerInfoReq = 7;
		public static byte GetServerInfoResp = 8;
		public static byte GetReq = 9;
		public static byte GetResp = 10;
		public static byte PutReq = 11;
		public static byte PutResp = 12;
		public static byte DelReq = 13;
		public static byte DelResp = 14;
		public static byte ListBucketsReq = 15;
		public static byte ListBucketsResp = 16;
		public static byte ListKeysReq = 17;
		public static byte ListKeysResp = 18;
		public static byte GetBucketReq = 19;
		public static byte GetBucketResp = 20;
		public static byte SetBucketReq = 21;
		public static byte SetBucketResp = 22;
		public static byte MapRedReq = 23;
		public static byte MapRedResp = 24;
		public static byte IndexReq = 25;
		public static byte IndexResp = 26;
		public static byte SearchQueryReq = 27;
		public static byte SearchQueryResp = 28;
		public static byte ResetBucketReq = 29;
		public static byte ResetBucketResp = 30;
		public static byte GetBucketTypeReq = 31;
		public static byte SetBucketTypeReq = 32;
		public static byte ResetBucketTypeReq = 33;
		public static byte UpdateCounterReq = 50;
		public static byte UpdateCounterResp = 51;
		public static byte GetCounterReq = 52;
		public static byte GetCounterResp = 53;
		public static byte GetYzIndexReq = 54;
		public static byte GetYzIndexResp = 55;
		public static byte PutYzIndexReq = 56;
		public static byte DelYzIndexReq = 57;
		public static byte GetYzSchemaReq = 58;
		public static byte GetYzSchemaResp = 59;
		public static byte PutYzSchemaReq = 60;
		public static byte DtFetchReq = 80;
		public static byte DtFetchResp = 81;
		public static byte DtUpdateReq = 82;
		public static byte DtUpdateResp = 83;
		public static byte AuthReq = 253;
		public static byte AuthResp = 254;
		public static byte StartTls = 255;
	}
}
