using System;
using Microsoft.EntityFrameworkCore;
using BotLog.API.Models;

namespace BotLog.API.Services;

public class DataContext : DbContext
{
    public DbSet<BotModel>? BotData { get; set; }
    public DbSet<MessageModel>? MessageData { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options) { Database.EnsureCreated(); }
}