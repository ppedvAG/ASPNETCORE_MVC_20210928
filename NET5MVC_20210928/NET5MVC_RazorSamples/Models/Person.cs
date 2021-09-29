using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET5MVC_RazorSamples.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }
    }
}
