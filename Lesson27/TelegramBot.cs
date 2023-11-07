public class TelegramBot
{
    string token;
    public Action<TelegramMessageModel> action;
    HttpClient hc;
    Thread thread;

    public TelegramBot(string token)
    {
        this.token = token;
        hc = new HttpClient();
        hc.BaseAddress = new Uri($"https://api.telegram.org/bot{token}/");
        thread = new Thread(GetUpdates);
    }

    private void GetUpdates()
    {
        long offset = 0;
        while (true)
        {
            string content = hc.GetStringAsync($"getupdates?offset={offset}").Result;
            TelegramMessageModel[] ms = new JsonParser(content).GetMessage();
            if (ms.Length != 0)
            {
                foreach (var item in ms)
                {
                    Console.WriteLine(item);
                    action(item);
                }
                offset = ms[^1].updateId + 1;
            }
            Thread.Sleep(1200);
        }
    }

    public void SendMessage(long chatId, string text)
    {
        string answer = string.Empty;
        try
        {
            answer = hc.GetStringAsync($"sendMessage?chat_id={chatId}&text={text}").Result;
            dynamic ans = Newtonsoft.Json.JsonConvert.DeserializeObject(answer);
            Console.WriteLine($"Sent message status: {ans.ok}");
        }
        catch (Exception)
        {
            Console.WriteLine("An error occurred while sending the response");
        }
    }

    public void Start()
    {
        thread.Start();
    }
}