using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BotLog.API.Models;

public enum BotStatus
{
    Running = 0,
    Info,
    Warning,
    Danger,
    Offline,
    Done
}
[Table("BotModel")]
public class BotModel
{
    public BotModel() { }

    public long Id { get; set; }
    public string? CompanyPrefix { get; set; }
    public string? Name { get; set; }
    public List<MessageModel>? Messages { get; set; }
    public DateTime DateAdded { get; set; }
    public int Status { get; set; }
}