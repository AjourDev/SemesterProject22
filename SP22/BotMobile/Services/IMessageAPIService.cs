using System;
using BotMobile.Models;

namespace BotMobile.Services;

public interface IMessageAPIService
{
    Task<List<BotModel>> GetBots();
}

