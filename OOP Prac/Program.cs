using System;

namespace OOP_Prac
{
    public interface IEmployee
    {
        public int CalculateSalary();
        
    }
    public class Employee : IEmployee
    {
        public int baseSalary = 20;
        public int bonusSalary = 10;

        public int annualBonus = 100;

        public virtual int CalculateSalary()
        {
            return baseSalary / bonusSalary;
        }

    }

    public class Manager : Employee
    {
        
        public override int CalculateSalary()
        {
            return baseSalary + bonusSalary;
        }

        public int CalculateSalary(int extraSalary)
        {
            return baseSalary + bonusSalary + extraSalary;
        }

        
    } 

    public class Enginner : Employee
    {
        public override int CalculateSalary()
        {
            return baseSalary - bonusSalary;
        }

        public int CalculateAnnualBonus()
        {
            return annualBonus * 2;
        }
    }

    public class Worker : IEmployee
    {

        public int CalculateSalary()
        {
            return 2000;
        }
    }

    public class Outsider 
    {
        IEmployee employee1;
        public Outsider(IEmployee _employee1)
        {
            employee1 = _employee1;
        }
        public int CalculateSalary()
        {
            return employee1.CalculateSalary();
        }

        static void Main(string[] args)
        {

            // Polymorphism method overriding
            Employee employee = new Employee();
            int employeeSalary = employee.CalculateSalary();

            Manager manager = new Manager();
            int managerSalary = manager.CalculateSalary();


            Enginner enginner = new Enginner();
            int enginnerSalary = enginner.CalculateSalary();

            Console.WriteLine("Employee Salary" + employeeSalary);
            Console.WriteLine("Manager Salary:" + managerSalary);
            Console.WriteLine("Engineer Salary" + enginnerSalary);

            // Polymorphism method overloading

            int managerSalaryExtra = manager.CalculateSalary(15);
            Console.WriteLine("Manager Extra Salary:" + managerSalaryExtra);

            // normal Inheritance 
            int enginnerAnnualBonus = enginner.CalculateAnnualBonus();
            Console.WriteLine("Engineer Annual Bonus" + enginnerAnnualBonus);

            //abstraction
            Worker worker = new Worker();

            Outsider outsider = new Outsider(employee);
            Outsider outsiderw = new Outsider(worker);

            int outsiderSalary =  outsider.CalculateSalary();
            int outsiderSalaryw = outsiderw.CalculateSalary();


            Console.WriteLine("Outsider Salary Employee" + outsiderSalary);

            Console.WriteLine("Outsider Salary Worker" + outsiderSalaryw);





        }

    }
}
