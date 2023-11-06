using System.Dynamic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

public class JsonParser
{
    string content;

    public JsonParser(string content)
    {
        this.content = content;
    }

    public TelegramMessageModel[] GetMessage()
    {
        List<TelegramMessageModel> msgs = new();
        JToken[] data = JObject.Parse(this.content)["result"].ToArray();

        foreach (dynamic item in data)
        {
            if (item.message != null)
            {
                long id = item.message.from.id;
                string text = item.message.text;
                long updateId = item.update_id;
                string firstName = item.message.from.first_name;
                msgs.Add(new(id, firstName, text, updateId));
            }
        }
        return msgs.ToArray();
    }
}
