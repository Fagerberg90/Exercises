using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Regestry
    {
        List<Employee> employeeList = new List<Employee>();
        Logger logbook = new Logger();
        public int hourlyWage;
      

        public void AddEmployee()
        {
            Console.WriteLine("Write in your firstname: ");
            string fName = Console.ReadLine();
            Console.WriteLine("Write in your lastname: ");
            string lName = Console.ReadLine();
            Console.WriteLine("Write in your Social security number: ");
            string socialSN = Console.ReadLine();
            Console.WriteLine("Write in your hourly wage: ");
            int.TryParse(Console.ReadLine(), out hourlyWage);



            Employee newEmployee = new Employee(fName, lName, socialSN, hourlyWage);
            employeeList.Add(newEmployee);

            logbook.Log("employee added " + newEmployee.fullName);
        

        }

        public void RemoveEmployee()
        {
            
            Console.WriteLine("Write in the name of the person you want to remove");
            var control = Console.ReadLine();

            for (int i = 0; i < employeeList.Count; i++)
            {
                if (control == employeeList[i].fName)
                {

                    employeeList.Remove(employeeList[i]);
                    Console.WriteLine("you removed " + control);
                }
            }
        }

        public void ShowEmployees()
        {
            foreach (var item in employeeList)
            {
                Console.WriteLine($"Employee: {item.fullName}");
            }
        }
        public void workers()
        {
            Employee workers = new Employee("Emil", "Fagerberg", "9002150525", 210);
            Employee workers2 = new Employee("Tomas", "Beckström", "8704103663", 200);
            employeeList.Add(workers);

        }
        public void meny()
        {
            bool go = true;
            while (go)
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?");

                Console.WriteLine("1. Add employee ");
                Console.WriteLine("2. Remove employee");
                Console.WriteLine("3. Show all employees ");
                Console.WriteLine("4. Logbook ");
                Console.WriteLine("5. Exit");
                Console.WriteLine();
                Console.WriteLine("Enter choice:");
                Console.WriteLine();

                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("please fill the following");
                        Console.WriteLine("--------------------------");
                        AddEmployee();
                        break;
                    case "2":
                        RemoveEmployee();
                        break;
                    case "3":
                        ShowEmployees();
                        break;
                    case "4":
                        logbook.readLogBook();
                        break;
                    case "5":
                        go = false;
                        break;

                    default:
                        Console.WriteLine("--------------");
                        break;
                }

                Console.WriteLine("\nDone, press enter to select a new number ");
                Console.ReadKey();

            }
        }
    }
}

