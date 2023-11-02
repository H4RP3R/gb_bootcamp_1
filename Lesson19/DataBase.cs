class Database
{
    List<Department> depTable;
    List<Worker> workerTable;

    public Database()
    {
        depTable = new();
        workerTable = new();
    }

    public void AppendWorker(Worker worker)
    {
        workerTable.Add(worker);
    }

    public void AppendDep(Department dep)
    {
        depTable.Add(dep);
    }

    public string SelectAllDep()
    {
        string output = string.Empty;
        foreach (var dep in this.depTable)
        {
            output += $"{dep.title}\n";
        }
        return output;
    }

    public string SelectAllWorker()
    {
        string output = string.Empty;
        foreach (var worker in this.workerTable)
        {
            output += $"{worker.fullName}  {worker.age}\n";
        }
        return output;
    }

    public List<(string, int, string)> Report()
    {
        List<(string, int, string)> rep = new();
        foreach (var worker in this.workerTable)
        {
            rep.Add((worker.fullName, worker.age, this.depTable[worker.depId].title));
        }
        return rep;
    }
}