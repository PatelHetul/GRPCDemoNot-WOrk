using GRPCDemoApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRPCDemoApplication.Providers
{
	public class IChatRoomProvider
	{
		ChatRoom GetFreeChatRoom();
		ChatRoom GetChatRoomById(int roomId);
		ChatRoom AddChatRoom();
	}
}
