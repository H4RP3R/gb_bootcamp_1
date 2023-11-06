public class TelegramMessageModel
{
    public long updateId;
    public long chatId;
    public string text;
    public string firstName;

    public TelegramMessageModel(long chatId, string firstName, string text, long updateId)
    {
        this.chatId = chatId;
        this.firstName = firstName;
        this.text = text;
        this.updateId = updateId;
    }

    public override string ToString()
    {
        return $"{firstName} {text} {chatId} {updateId}";
    }
}