using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPuJAP_15._03
{
    class DogClass
    {
        public string Name;
        public string Breed;
        public double Age;
        public DogClass()
        {

        }
        public DogClass(string name, string breed, double age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }
        public void setName(string name)
        {
            Name = name;
        }
        public string getName()
        {
            return Name;
        }
        public void setBreed(string breed)
        {

            Breed = breed;
        }
        public string getBreed()
        {
            return Breed;
        }
        public void setAge(double age)
        {
            Age = Convert.ToDouble(age);
        }
        public double getAge()
        {
            return Age;
        }
    }
}
