using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalR.Hubs;

namespace SignalRTest2.SignalR.WebChatTest
{
    public class WebChat : Hub
    {
        public void AddChatLine(string name, string str)
        {
            Clients.chatLineAdded(Context.ConnectionId, name, str);
        }
    }
}