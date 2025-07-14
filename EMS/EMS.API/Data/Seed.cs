using EMS.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EMS.API.Data
{
    public static class Seed
    {
        public static void GenerateSeed(this ModelBuilder modelBuilder)
        {
            var departments = new[] { "Engineering", "Marketing", "Human Resources", "Finance", "IT", "Sales", "Operations" };
            var firstNames = new[] { "James", "Mary", "John", "Patricia", "Robert", "Jennifer", "Michael", "Linda", "William", "Elizabeth",
                                     "David", "Barbara", "Richard", "Susan", "Joseph", "Jessica", "Thomas", "Sarah", "Charles", "Karen" };
            var lastNames = new[] { "Smith", "Johnson", "Brown", "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin" };

            var employees = new List<Employee>();
            var random = new Random();

            for (int i = 1; i <= 300; i++)
            {
                var firstName = firstNames[random.Next(firstNames.Length)];
                var lastName = lastNames[random.Next(lastNames.Length)];
                var name = $"{firstName} {lastName}";

                var dob = RandomDateOfBirth(random);
                var age = DateTime.Now.Year - dob.Year;
                if (DateTime.Now.Date < dob.AddYears(age)) age--; // correct if birthday hasn't occurred yet this year

                employees.Add(new Employee
                {
                    Id = i,
                    Name = name,
                    Department = departments[random.Next(departments.Length)],
                    DateOfBirth = dob,
                    Age = age,
                    PhoneNumber = $"07{random.Next(100000000, 999999999)}"
                });
            }

            modelBuilder.Entity<Employee>().HasData(employees);
        }

        private static DateTime RandomDateOfBirth(Random random)
        {
            int year = random.Next(1965, 2005);
            int month = random.Next(1, 13);
            int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1);
            return new DateTime(year, month, day);
        }
    }
}
