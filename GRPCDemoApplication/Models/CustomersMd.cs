using Grpc.Core;
using System;

namespace GRPCDemoApplication.Models
{
	public class CustomersMd
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string ColorInConsole { get; set; }
		public IAsyncStreamWriter<ChatRoom> Stream { get; set; }
	}
}
