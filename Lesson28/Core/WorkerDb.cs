public static class Repository
{
    static List<Worker> db;
    static Repository() => db = new();

    public static void Create(Worker w) => db.Add(w);
    public static Worker Read(int id) => db[id];
    public static Worker[] Read() => db.ToArray();
    public static bool Update(int id, Worker w) { db[id] = w; return true; }
    public static void Delete(int id) => db.RemoveAt(id);
}