Department dep1 = new(0, "Информационные технологии");
Department dep2 = new(1, "Отдел кадров");
Department dep3 = new(2, "Бухгалтерия");

Console.WriteLine(dep1);
Console.WriteLine(dep2);
Console.WriteLine(dep3);
Console.WriteLine("__________\n");

Worker worker1 = new(id: 0, fullName: "Мария Ивановна", age: 23, salary: 7734, depId: 2);
Worker worker2 = new(id: 1, fullName: "Мария Степановна", age: 26, salary: 3456, depId: 0);
Worker worker3 = new(id: 2, fullName: "Василий Петрович", age: 33, salary: 5432, depId: 2);
Worker worker4 = new(id: 3, fullName: "Игнат Петрович", age: 23, salary: 1432, depId: 0);

Console.WriteLine(worker1);
Console.WriteLine(worker2);
Console.WriteLine(worker3);
Console.WriteLine(worker4);
Console.WriteLine("__________\n");

Database db = new();

db.AppendDep(dep1);
db.AppendDep(dep2);
db.AppendDep(dep3);

db.AppendWorker(worker1);
db.AppendWorker(worker2);
db.AppendWorker(worker3);
db.AppendWorker(worker4);

Console.WriteLine(db.SelectAllDep());
Console.WriteLine("__________\n");
Console.WriteLine(db.SelectAllWorker());