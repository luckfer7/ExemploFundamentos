using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa //PascalCase
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public decimal Height {get; set;}

        public void ToShow()
        {
            Console.WriteLine($"Hi, everyone. My name is {Name} and I am {Age} years old. And I am {Height}");
        }
    }

        
}