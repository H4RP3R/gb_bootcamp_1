using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;


public class WorkerConverter
{
    public string ToJson(Worker w) => JsonConvert.SerializeObject(w);
}