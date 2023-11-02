using Microsoft.AspNetCore.SignalR;

namespace InveonSignalR.Web.Hubs
{
    public class MessageHub : Hub
    {

        public override Task OnConnectedAsync()
        {

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
