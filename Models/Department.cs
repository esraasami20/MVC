using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"The Department ID is : {ID} \n The Department Name is : {Name}";
        }
    }
}