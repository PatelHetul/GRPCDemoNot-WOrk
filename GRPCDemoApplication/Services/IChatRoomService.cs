﻿using Grpc.Core;
using GRPCDemoApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRPCDemoApplication.Services
{
    public interface IChatRoomService
    {
        Task BroadcastMessageAsync(ChatMessage message);
        Task<int> AddCustomerToChatRoomAsync(CustomerProtoModel customer);
        void ConnectCustomerToChatRoom(int roomId, Guid customerId, IAsyncStreamWriter<ChatMessage> asyncStreamWriter);
        void DisconnectCustomer(int roomId, Guid customerId);
    }
}
