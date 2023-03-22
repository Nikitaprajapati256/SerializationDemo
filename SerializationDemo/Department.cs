using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    [Serializable]
    public class Department
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Location { get; set; }
    }
}
