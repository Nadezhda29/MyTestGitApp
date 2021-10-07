using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestGitApp
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public void Say()
        {
            Console.WriteLine("Привет!");
        }
    }
}
