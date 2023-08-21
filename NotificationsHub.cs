using Microsoft.AspNetCore.SignalR;

namespace SignalR;

public sealed class NotificationsHub : Hub
{
    public async Task SendNotification(string content)
    {
        await Clients.All.SendAsync("ReceiveNotification", $"User sent: {content}");
    }
}