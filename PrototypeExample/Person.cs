using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExample
{
    internal abstract class Person
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public Address PersonAddress { get; set; }
        public abstract Person ShallowCopy();
        public abstract Person DeepCopy();
        public override string ToString()
        {
            return
                $@" 
         Id : {this.Id},
         Name : {this.Name},
         Address : {this.PersonAddress.Building},{this.PersonAddress.Street},{this.PersonAddress.City}
                 ";
        }
    }
}
