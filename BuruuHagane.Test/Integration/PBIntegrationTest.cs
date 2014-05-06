using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using BuruuHagane.Core;
using BuruuHagane.Core.Protobuff;
using BuruuHagane.Util;
using NUnit.Framework;
using ProtoBuf;
using System.Xml;

namespace BuruuHagane.Test.Integration
{
	[TestFixture ()]
	public class PBIntegrationTest
	{
		[Test ()]
		public void PingTest ()
		{
			var server = "127.0.0.1";
			var port = 10017;
			using (TcpClient client = new TcpClient (server, port))
			using (NetworkStream ns = client.GetStream ()) 
			{
				var pingMessage = new RiakMessage(RiakMessageCodes.PingReq, new byte[0]);
				var ping = RiakMessageTranslator.Encode(pingMessage);
				ns.Write (ping, 0, ping.Length);
				ns.Flush ();

				var pingResponse = new byte[1500];

				int read = ns.Read (pingResponse, 0, pingResponse.Length);

				var responseMesssage = RiakMessageTranslator.Decode (pingResponse, read);

				Assert.AreEqual (5, read);
				Assert.AreEqual (RiakMessageCodes.PingResp, responseMesssage.Code);
				Assert.IsEmpty (responseMesssage.Data);

				ns.Close ();
				client.Close ();
			}
		}
	}
}
