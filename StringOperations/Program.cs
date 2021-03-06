﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "James Bond ";
            Console.WriteLine("Trim: '{0}'" , fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            var newName = fullName.Replace("James", "Jean");
            Console.WriteLine(newName);

            if (string.IsNullOrWhiteSpace(""))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);

            float price = 29.29f;
            Console.WriteLine(price.ToString("C1")); 
        }
    }
}
