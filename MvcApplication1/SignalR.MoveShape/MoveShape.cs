using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalR.Hubs;

namespace SignalRTest2.SignalR.MoveShapeTest
{
    [HubName("moveShape")]
    public class MoveShapeHub : Hub
    {
        public void MoveShape(int x, int y)
        {
            Clients.ShapeMoved(Context.ConnectionId, x, y);
        }
    }
}