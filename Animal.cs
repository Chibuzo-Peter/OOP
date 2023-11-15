using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
  public class Animal
  {
       public string? Color {get;set;}
      public int Legs { get;set;}

     public string Name { get;set;}

        public Animal(string Name, int Legs, string Color)
        {
            this.Name = Name;
            this.Legs = Legs;
            this.Color = Color;

        }

    }

   
}
