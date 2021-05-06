using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC1.Models;

namespace MVC1.Models
{
    public class studentMoc
    {
        static List<student> students = new List<student>()
        {
            new student(){ID=1,Name="Esraa",Age=24},
            new student(){ID=2,Name="Aya",Age=22},
            new student(){ID=3,Name="Abrar",Age=24},
            new student(){ID=4,Name="Zahraa",Age=23},
            new student(){ID=5,Name="Nada",Age=23},
        };
        public static List<student> getStudent()
        {
            return students;
        }
        public static student studentDetails(int id)
        {
            student stdDetails = students.FirstOrDefault(a => a.ID == id);
            return stdDetails;
        }
        public static student addStudent(student newStd)
        {
            student Exist = students.FirstOrDefault(a => a.ID == newStd.ID);
            if (Exist==null)
            {
                students.Add(newStd);
            }

            return newStd;
        }
        public static void removeStd(int id)
        {
            student stdRemove = students.FirstOrDefault(a => a.ID == id);
            students.Remove(stdRemove);
        }
        public static void Edit(student std)
        {
            student editStd = students.FirstOrDefault(a => a.ID == std.ID);
            editStd.Name = std.Name;
            editStd.Age = std.Age;

        }
    }
}