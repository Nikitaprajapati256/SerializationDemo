using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    [Serializable]
    public class Student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }

    }
}
