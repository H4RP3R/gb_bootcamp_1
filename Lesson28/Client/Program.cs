using Newtonsoft.Json;

string url = "http://127.0.0.1:5000/worker/getworker/";
HttpClient hc = new();

string response = hc.GetStringAsync(url).Result;
Console.WriteLine(response);

string workerJson = hc.GetStringAsync($"{url}3").Result;
Worker w = JsonConvert.DeserializeObject<Worker>(workerJson);
Console.WriteLine(w);