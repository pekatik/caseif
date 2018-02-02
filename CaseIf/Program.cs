using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using CaseIf.Services;

namespace CaseIf
{
    class Program
    {
        private static readonly List<Developer> DeveloperList = StaticData.DeveloperList;
        private static EmployeeService _employeeService;

        private static void Main()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<AuthService>();
            builder.RegisterType<EmployeeService>();
            builder.RegisterType<WageService>();

            var container = builder.Build();
            _employeeService = container.Resolve<EmployeeService>();

            Run();
        }

        private static void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Select a developer to see detail");

                DeveloperList.ForEach(x => Console.WriteLine($"{x.Id}) {x.Name} {x.Surname}"));

                var selection = Console.ReadLine();

                var selectedDeveloper = DeveloperList.FirstOrDefault(x => x.Id == selection);

                if (selectedDeveloper == null)
                {
                    Console.WriteLine("Wrong developer id. Press any key to continue.");
                    Console.ReadKey();
                    continue;
                }

                SetSelected(selectedDeveloper);

                break;
            }
        }

        private static void SetSelected(Developer developer)
        {
            //I think here is problem #1
            //TODO: There must be something wrong. How can I change this assignee that employee service understand?

            var wage = string.Empty;

            switch (developer.Title)
            {
                case DeveloperType.Senior:
                    wage = _employeeService.GetWage(new EmpSeniorService());
                    break;
                case DeveloperType.Junior:
                    wage = _employeeService.GetWage(new EmpJuniorService());
                    break;
                case DeveloperType.Master:
                    wage = _employeeService.GetWage(new EmpMasterService());
                    break;
                case DeveloperType.Specialist:
                    wage = _employeeService.GetWage(new EmpSpecialistService());
                    break;
            }

            Console.WriteLine($"Type {developer.Title}, Wage {wage}");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Run();
        }
    }
}
