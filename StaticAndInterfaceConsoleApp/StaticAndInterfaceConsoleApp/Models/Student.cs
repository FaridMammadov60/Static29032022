using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndInterfaceConsoleApp.Models
{
    public class Student
    {
        #region Fields
        int _id;
        string _fullname;
        double _point;
        #endregion

        public Student(string fullname, double point)
        {
            Fullname = fullname;
            Point = point;
            _id++;
        }

        #region Property
        public int Id 
        {
            get
            {
                return _id;
            }
        }
        public string Fullname { get; set; }
        public double Point { get; set; }
        #endregion

        #region Method
        public static void StudentInfo(int Id, string Fullname, double Point)
        {
            Console.WriteLine($"Studentid: {Id}\n" +
                $"Student fullname: {Fullname}\n" +
                $"Student point: {Point}");
        }
        #endregion

        public override string ToString()
        {
            return $"Student id: {Id}\n" +
                $"Student fullname: {Fullname}\n" +
                $"Student point: {Point}";
        }
    }
}
