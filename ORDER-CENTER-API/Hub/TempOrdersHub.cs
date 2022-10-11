using Microsoft.AspNetCore.SignalR;
using ORDER_CENTER_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ORDER_CENTER_API
{
    public class TempOrdersHub : Hub
    {
        public void NewOrder()
        {
            Clients.All.SendAsync("newOrder");
        }
    }
}
