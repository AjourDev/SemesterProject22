using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BotLog.API.Services;
using BotLog.API.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BotLog.API.Controllers;

[Produces("application/json")]
[ApiController]
public class BotController : Controller
{
    private readonly DataContext _db;

    public BotController(DataContext db) { _db = db; }

    // GET: /<controller>/
    [HttpGet, Route("bot/api")]
    public async Task<IActionResult> Get([FromHeader] string? itemId = "")
    {
        await Task.Delay(1);
        if (!Int64.TryParse(itemId, out _) || string.IsNullOrWhiteSpace(itemId)
            || _db.BotData == null || _db.MessageData == null)
            return StatusCode(404, null);

        if (itemId == "0")
            return Ok(_db.BotData);

        else if (itemId != "0" && Int64.TryParse(itemId, out _))
        {
            var botId = Convert.ToInt64(itemId);
            var outputItem = _db.BotData.FirstOrDefault(x => x.Id == botId);
            if (outputItem == null)
                return StatusCode(404, null);
            outputItem.Messages = _db.MessageData.Where(x => x.BotModelId == botId).Take(10).ToList();
            return Ok(outputItem);
        }

        return StatusCode(404, null);
    }

    [HttpPost, Route("bot/api")]
    public async Task<IActionResult> Post(BotModel item)
    {
        await Task.Delay(1);
        if (_db.BotData == null || _db.MessageData == null)
            return StatusCode(404, null);
        var bdId = _db.BotData.Add(item);
        _db.SaveChanges();
        if (bdId != null)
            return Ok();
        else
            return StatusCode(404, null);
    }

    [HttpPut, Route("bot/api")]
    public async Task<IActionResult> Put(BotModel item)
    {
        await Task.Delay(1);
        if (_db.BotData == null || _db.MessageData == null)
            return StatusCode(404, null);
        try
        {
            _db.BotData.Update(item);
            _db.SaveChanges();
        }
        catch
        {
            return StatusCode(404, null);
        }
        return Ok();
    }

    [HttpDelete, Route("bot/api")]
    public async Task<IActionResult> Delete([FromHeader] string itemId)
    {
        await Task.Delay(1);
        if (!Int64.TryParse(itemId, out _) || string.IsNullOrWhiteSpace(itemId)
            || _db.BotData == null || _db.MessageData == null)
            return StatusCode(404, null);

        var data = _db.BotData.FirstOrDefault(x => x.Id == Convert.ToInt64(itemId));

        if (data == null)
            return StatusCode(404, null);

        _db.BotData.Remove(data);
        _db.SaveChanges();
        return Ok();
    }
}