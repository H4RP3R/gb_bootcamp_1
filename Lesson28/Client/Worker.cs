public class Worker
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }

    public override string ToString()
    {
        return $"Id:{Id} FirstName:{FirstName} LastName:{LastName}";
    }
}