using Labb6;
Employee employee1 = new Employee(id: 1, name: "Bert", gender: "Male", salary: 30000);
Employee employee2 = new Employee(id: 2, name: "Alice", gender: "Female", salary: 35000);
Employee employee3 = new Employee(id: 3, name: "John", gender: "Male", salary: 40000);
Employee employee4 = new Employee(id: 4, name: "Sara", gender: "Female", salary: 32000);
Employee employee5 = new Employee(id: 5, name: "Tom", gender: "Male", salary: 28000);
Employee[] employeesArray = [employee1, employee2, employee3, employee4, employee5];
Stack<Employee> employees = new Stack<Employee>();
employees.Push(employee1);
employees.Push(employee2);
employees.Push(employee3);
employees.Push(employee4);
employees.Push(employee5);
System.Console.WriteLine("-----------------");
foreach (Employee employee in employees)
{
    System.Console.WriteLine($"{employee.id} - {employee.name} - {employee.gender} - {employee.salary}");
    System.Console.WriteLine("Items left in stack: " + employees.Count());
}
System.Console.WriteLine("-----------------");

for (int i = 0; i < employeesArray.Length; i++)
{
    Employee currentEmployee = employees.Pop();
    System.Console.WriteLine($"{currentEmployee.id} - {currentEmployee.name} - {currentEmployee.gender} - {currentEmployee.salary}");
    System.Console.WriteLine("Items left in stack: " + employees.Count());
}
System.Console.WriteLine("-----------------");