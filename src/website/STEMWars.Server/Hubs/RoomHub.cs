using Microsoft.AspNetCore.SignalR;

namespace STEMWars.Server.Hubs
{
    public class ChatHub : Hub
    {
        private static Dictionary<string, string> RoomUsers = new Dictionary<string, string>();

        public override async Task OnConnectedAsync()
        {
            string username = Context.GetHttpContext().Request.Query["username"];
            RoomUsers.Add(Context.ConnectionId, username);
            await AddMessageToChat(string.Empty, $"{username} joined the party!");
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            string username = RoomUsers.FirstOrDefault(u => u.Key == Context.ConnectionId).Value;
            await AddMessageToChat(string.Empty, $"{username} left!");
        }

        public async Task AddMessageToChat(string user, string message)
        {
            await Clients.All.SendAsync("GetThatMessageDude", user, message);
        }
    }
}