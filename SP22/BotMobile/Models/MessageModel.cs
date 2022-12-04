using System;
namespace BotMobile.Models;

public class MessageModel
{
    public MessageModel() { }
    public MessageModel(long botId, string botname, string message)
    {
        BotModelId = botId;
        Message = message;
        DateAdded = DateTime.Now;
    }
    public long Id { get; set; }
    public long BotModelId { get; set; }
    public string Message { get; set; }
    public DateTime DateAdded { get; set; }
}