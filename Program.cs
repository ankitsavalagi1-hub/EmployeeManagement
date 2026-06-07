using EmployeeManagement.Models;
using EmployeeManagement.Services;

EmployeeService service =
    new EmployeeService();

bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine(
        "===== EMPLOYEE MENU ====="
    );

    Console.WriteLine(
        "1. Add Employee"
    );

    Console.WriteLine(
        "2. View Employees"
    );

    Console.WriteLine(
        "3. Exit"
    );

    Console.Write(
        "Choose Option: "
    );

    string choice =
        Console.ReadLine();

    switch (choice)
    {
        case "1":

            Employee emp =
                new Employee();

            Console.Write(
                "Enter Id: "
            );

            emp.Id =
                Convert.ToInt32(
                    Console.ReadLine()
                );

            Console.Write(
                "Enter Name: "
            );

            emp.Name =
                Console.ReadLine();

            Console.Write(
                "Enter Age: "
            );

            emp.Age =
                Convert.ToInt32(
                    Console.ReadLine()
                );

            service.AddEmployee(emp);

            Console.WriteLine(
                "Employee Added"
            );

            break;

        case "2":

            List<Employee> employees =
                service.GetEmployees();

            foreach (Employee e
                in employees)
            {
                Console.WriteLine(
                    $"{e.Id} - " +
                    $"{e.Name} - " +
                    $"{e.Age}"
                );
            }

            break;

        case "3":

            running = false;

            break;

        default:

            Console.WriteLine(
                "Invalid Option"
            );

            break;
    }
}