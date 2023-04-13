using Microsoft.AspNetCore.SignalR;
using Project_LagaltBackend.Models.Main;

namespace Project_LagaltBackend.Hubs
{
    public class ChatHub: Hub
    {
        private readonly string _botService;

        public ChatHub()
        {
            _botService = "MyChat botService";
        }
        public async Task JoinRoom(ChatMessage chatMessage)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, chatMessage.Room);

            await Clients.Group(chatMessage.Room).SendAsync("RecieveMessage", _botService,
                $"{chatMessage.User} has joined the room{chatMessage.Room}");
        }
    }
}
