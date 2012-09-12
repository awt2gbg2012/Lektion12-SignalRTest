using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalR.Hubs;

namespace MvcApplication1
{
    [HubName("chatHub")]
    public class ChatHub : Hub
    {
        public void AddChatLine(string username, string chatline)
        {
            Clients.chatLineAdded(Context.ConnectionId, username, chatline);
        }
    }
}