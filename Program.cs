using Labb6;

namespace Labb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new employee objects and an array with every employee
            Employee employee1 = new Employee(id: 1, name: "Bert", gender: "Male", salary: 30000);
            Employee employee2 = new Employee(id: 2, name: "Alice", gender: "Female", salary: 35000);
            Employee employee3 = new Employee(id: 3, name: "John", gender: "Male", salary: 40000);
            Employee employee4 = new Employee(id: 4, name: "Sara", gender: "Female", salary: 32000);
            Employee employee5 = new Employee(id: 5, name: "Tom", gender: "Male", salary: 28000);
            Employee[] employeesArray = [employee1, employee2, employee3, employee4, employee5];

            // Create a new stack and add all employees to stack
            Stack<Employee> employeesStack = new Stack<Employee>();
            foreach (Employee item in employeesArray)
            {
                employeesStack.Push(item);
            }
            Console.WriteLine("-----------------");
            // Print out every object inside stack
            foreach (Employee employee in employeesStack)
            {
                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
                Console.WriteLine("Items left in stack: " + employeesStack.Count);
            }
            Console.WriteLine("-----------------");
            // Get every object using pop method and print out that object
            Console.WriteLine("Retrieve using pop");
            for (int i = 0; i < employeesArray.Length; i++)
            {
                Employee currentEmployee = employeesStack.Pop();
                Console.WriteLine($"{currentEmployee.Id} - {currentEmployee.Name} - {currentEmployee.Gender} - {currentEmployee.Salary}");
                Console.WriteLine("Items left in stack: " + employeesStack.Count);
            }
            Console.WriteLine("-----------------");
            // Add back every employee using push
            foreach (Employee employee in employeesArray)
            {
                employeesStack.Push(employee);
            }
            Console.WriteLine("-----------------");
            // Get object without removing it, print out values.
            Console.WriteLine("Retrieve using Peek Method");
            for (int i = 0; i < 2; i++)
            {
                Employee currentEmployee = employeesStack.Peek();
                Console.WriteLine($"{currentEmployee.Id} - {currentEmployee.Name} - {currentEmployee.Gender} - {currentEmployee.Salary}");
                Console.WriteLine("Items left in stack: " + employeesStack.Count());
            }
            Console.WriteLine("-----------------");

            // Create a new empty List. Add all employees to it.
            var employeesList = new List<Employee>();
            employeesList.AddRange(employeesArray);

            // Check if employee2 exists inside list
            bool employeeExists = employeesList.Contains(employee2);
            if (employeeExists)
            {
                Console.WriteLine("Employee2 object exists in the list.");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list.");
            }

            // Use Find to check if employee is male.
            Employee? firstMale = employeesList.Find(employee => employee.Gender.Equals("Male"));
            // Check if firstMale returned an object, if it did print the values
            if (firstMale != null)
            {
                System.Console.WriteLine($"ID: {firstMale.Id}, Name: {firstMale.Name}, Gender: {firstMale.Gender}, Salary: {firstMale.Salary}\n");
            }
            else
            {
                System.Console.WriteLine("No male employee found.");
            }
            List<Employee> allMaleEmployees = employeesList.FindAll(employee => employee.Gender.Equals("Male"));
            foreach (Employee maleEmployee in allMaleEmployees)
            {
                System.Console.WriteLine($"ID: {maleEmployee.Id}, Name: {maleEmployee.Name}, Gender: {maleEmployee.Gender}, Salary: {maleEmployee.Salary}");
            }
        }
    }
}