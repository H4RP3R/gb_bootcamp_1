using Newtonsoft.Json;


public class WorkerConverter
{
    public string ToJson(Worker w) => JsonConvert.SerializeObject(w);
}