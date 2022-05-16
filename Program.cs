using Pre_Task;
using System.Linq;

Employee first_employee = new();
Employee second_employee = new();
Employee third_employee = new();

List<Employee> employees = new();
employees.Add(first_employee);
employees.Add(second_employee);
employees.Add(third_employee);

Action < List<Employee> > Print = employees => { foreach (Employee employee in employees) Console.WriteLine(employee); };

Print(employees);

Func<List<Employee>, List<Employee>> ToSortByAge = eployees => employees.OrderByDescending(employee => employee.Age).ToList();

Console.WriteLine("Sorting by age : ");
Print(ToSortByAge(employees));

Func < List<Employee>, List<Employee> > ToSortByName = eployees => employees.OrderBy(employee => employee.Name).ToList();

Console.WriteLine("Sorting by name : ");
Print(ToSortByName(employees));

