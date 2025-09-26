using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using Telegram.Bot;
using WeddingServer.Models.Requests;
using WeddingServer.DbContext;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace WeddingServer.Services.TelegramService
{
    public class TelegramServiceSingleton
    {
        private static string id = String.Empty;

        private static TelegramBotClient _botClient = new("8118291036:AAE6IoXjVVDxNgf6To5ImrapAL2HG7EYuf0");
        private static PostgreDBContext _dbContext;
        public TelegramServiceSingleton(PostgreDBContext dbContext)
        {
            id = "481227813";
            _dbContext = dbContext;
        }

        public async Task SendFormMessage(WeddingForm data)
        {
            string msg = $"Новая заявка!\n\n{data}";
            await _botClient.SendMessage(id, msg);
        }
    }
}
