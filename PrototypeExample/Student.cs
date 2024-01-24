using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExample
{
    internal class Student : Person
    {
        public override Person DeepCopy()
        {
            Student student = new Student();
            student = (Student)this.MemberwiseClone();
            student.Id = this.Id;
            student.Name = this.Name;
            student.PersonAddress = new Address
            {
                Building=PersonAddress.Building,
                Street=PersonAddress.Street,
                City=PersonAddress.City
            };
            return student;
        }

        public override Person ShallowCopy()
        {
            return (Student) this.MemberwiseClone();

        }
    }
}
