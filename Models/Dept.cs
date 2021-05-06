using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class Dept
    {
        static List<Department> depts = new List<Department>()
        {
            new Department(){ID=1,Name="SD"},
            new Department(){ID=2,Name="OS"},
            new Department(){ID=3,Name="CEI"},
            
        };
        public static List<Department> getDept()
        {
            return depts;
        }
        public static Department deptDetails(int id)
        {
            Department deptdetails = depts.FirstOrDefault(a => a.ID == id);
            return deptdetails;
        }
        public static Department addDept(Department newDept)
        {
            Department Exist = depts.FirstOrDefault(a => a.ID == newDept.ID);
            if (Exist == null)
            {
                depts.Add(newDept);
            }

            return newDept;
        }
        public static void removeDept(int id)
        {
            Department deptRemove = depts.FirstOrDefault(a => a.ID == id);
            depts.Remove(deptRemove);
        }
        public static void Edit(Department dept)
        {
            Department editDept = depts.FirstOrDefault(a => a.ID == dept.ID);
            editDept.Name = dept.Name;
        }
    }

}