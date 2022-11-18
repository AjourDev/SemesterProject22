using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace URBotAPI.Models;

[Table("MessageModel")]
public class MessageModel
{
    public MessageModel() { }

    [Key]
    public long Id { get; set; }

    public long BotModelId { get; set; }

    public string Message { get; set; }
    public DateTime DateAdded { get; set; }
}