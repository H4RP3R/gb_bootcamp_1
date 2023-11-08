Worker w1 = new()
{
    Id = 0,
    Age = 22,
    Salary = 2000,
    FirstName = "John",
    LastName = "Smith",
};

Worker w2 = new()
{
    Id = 1,
    Age = 36,
    Salary = 2800,
    FirstName = "Tom",
    LastName = "Johnson",
};

Worker w3 = new()
{
    Id = 2,
    Age = 24,
    Salary = 3500,
    FirstName = "Mike",
    LastName = "Sharp",
};

Worker w4 = new()
{
    Id = 3,
    Age = 20,
    Salary = 2400,
    FirstName = "Lisa",
    LastName = "Hamilton",
};

Repository.Create(w1);
Repository.Create(w2);
Repository.Create(w3);
Repository.Create(w4);

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();

// TODO: add client 00:59:30
