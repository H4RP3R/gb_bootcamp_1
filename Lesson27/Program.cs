string token = File.ReadAllText("token.config");

TelegramBot bot = new TelegramBot(token);

void Updates(TelegramMessageModel msg)
{
    bot.SendMessage(msg.chatId, $"{msg.text}: received");
}

bot.action = Updates;
bot.Start();
Console.WriteLine("Bot started!");