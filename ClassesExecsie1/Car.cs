using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClasses
{
    public class Car
    {
        public Car()
        {

        }
        public Car(string makeInput, string modelInput, int yearInput)
        {
            Make = makeInput;
            Model = modelInput;
            Year = yearInput;
        }

        public string Make;
        public string Model;
        public int Year;
    }
}
