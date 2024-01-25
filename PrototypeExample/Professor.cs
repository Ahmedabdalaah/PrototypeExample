using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExample 
{
    internal class Professor : Person
    {
        public override Person DeepCopy()
        {
            Professor prof = new Professor();
            prof = (Professor)this.MemberwiseClone();
            prof.Id = this.Id;
            prof.Name = this.Name;
            prof.PersonAddress = new Address
            {
                Building = PersonAddress.Building,
                Street = PersonAddress.Street,
                City = PersonAddress.City
            };
            return prof;
        }

        public override Person ShallowCopy()
        {
            return (Professor)this.MemberwiseClone();

        }
    }
}
