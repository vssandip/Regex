﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Validation
    {
        public string FirstName = ("^[A-Z]{1}[A-Za-z]{3,}$");
        public void ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, FirstName))
                Console.WriteLine("First Name is Valid :" + firstName);
            else
                Console.WriteLine("First Name is Invalid");
        }
    }
}