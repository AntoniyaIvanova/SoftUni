﻿namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public decimal Salary { get; private set; }

        public decimal IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                return this.Salary += this.Salary * percentage / 100;
            }
            else
            {
                return this.Salary += this.Salary * percentage / 200;
            }

        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }
    }
}
