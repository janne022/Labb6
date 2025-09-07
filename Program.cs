using Labb6;
internal class Program
{
    private static void Main(string[] args)
    {
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
        Console.WriteLine("-----------------");
        foreach (Employee employee in employees)
        {
            Console.WriteLine($"{employee.id} - {employee.name} - {employee.gender} - {employee.salary}");
            Console.WriteLine("Items left in stack: " + employees.Count());
        }
        Console.WriteLine("-----------------");
        Console.WriteLine("Retrieve using pop");
        for (int i = 0; i < employeesArray.Length; i++)
        {
            Employee currentEmployee = employees.Pop();
            Console.WriteLine($"{currentEmployee.id} - {currentEmployee.name} - {currentEmployee.gender} - {currentEmployee.salary}");
            Console.WriteLine("Items left in stack: " + employees.Count());
        }
        Console.WriteLine("-----------------");
        foreach (Employee employee in employeesArray)
        {
            employees.Push(employee);
        }
        Console.WriteLine("-----------------");
        Console.WriteLine("Retrieve using Peek Method");
        for (int i = 0; i < 2; i++)
        {
            Employee currentEmployee = employees.Peek();
            Console.WriteLine($"{currentEmployee.id} - {currentEmployee.name} - {currentEmployee.gender} - {currentEmployee.salary}");
            Console.WriteLine("Items left in stack: " + employees.Count());
        }
        Console.WriteLine("-----------------");
        List<Employee> employeesList = new List<Employee>();
        employeesList.Add(employee1);
        employeesList.Add(employee2);
        employeesList.Add(employee3);
        employeesList.Add(employee4);
        employeesList.Add(employee5);

        bool employeeExists = employeesList.Contains(employee2);
        if (employeeExists)
        {
            Console.WriteLine("Employee2 object exists in the list.");
        }
        else
        {
            Console.WriteLine("Employee2 object does not exist in the list.");
        }
        Employee? firstMale = employeesList.Find(x => x.gender == "Male");
        if (firstMale != null)
        {
            System.Console.WriteLine($"ID: {firstMale.id}, Name: {firstMale.name}, Gender: {firstMale.gender}, Salary: {firstMale.salary}\n");
        }
        else
        {
            System.Console.WriteLine("No male employee found.");
        }
        List<Employee> allMaleEmployees = employeesList.FindAll(x => x.gender == "Male");
        foreach (Employee maleEmployee in allMaleEmployees)
        {
            System.Console.WriteLine($"ID: {maleEmployee.id}, Name: {maleEmployee.name}, Gender: {maleEmployee.gender}, Salary: {maleEmployee.salary}");
        }
    }
}