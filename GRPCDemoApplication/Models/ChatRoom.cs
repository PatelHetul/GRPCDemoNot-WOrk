
using System.Collections.Generic;


namespace GRPCDemoApplication.Models
{
	public class ChatRoom
	{
		public int Id { get; }
		public List<CustomersMd> CustomersInRoom { get; }
		public ChatRoom(int id)
		{
			Id = id;
			CustomersInRoom = new List<CustomersMd>();
		}
	}
}
