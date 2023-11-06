string token = File.ReadAllText("token.config");

TelegramBot bot = new TelegramBot(token);

void Updates(TelegramMessageModel msg)
{

}

bot.action = Updates;
bot.Start();
Console.WriteLine("Bot started!");