using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BotMobile.Models;

public enum Status
{
    Running = 0,
    Info,
    Warning,
    Danger,
    Offline,
    Done
}
public class BotModel
{
    public BotModel() { Messages = new(); }

    public long Id { get; set; }
    public string CompanyPrefix { get; set; }
    public string Name { get; set; }
    public List<MessageModel> Messages { get; set; }
    public DateTime DateAdded { get; set; }
    public Status Status { get; set; }

    [NotMapped]
    public bool NewNotification { get; set; }
}