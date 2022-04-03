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
        static int _id;
        string _fullname;
        double _point;
        #endregion

        public Student(string fullname, double point)
        {
            Fullname = fullname;
            Point = point;
            _id++;
            Id = _id;
        }

        #region Property
        public int Id 
        {
            get;
        }
        public string Fullname { get; set; }
        public double Point
        {
            get
            {
                return _point;
            }
            set
            {
                try
                {
                    if (value > 100 || value < 0)
                    {
                    P1: Console.WriteLine("Point 0-100 aralığında olmalıdır");
                        Console.Write("Tələbənin balın daxil edin: ");
                        value = Convert.ToDouble(Console.ReadLine());
                        if (value > 100 || value < 0)
                        {
                            goto P1;
                        }
                        _point = value;
                    }
                    _point = value;
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
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
                $"Student point: {Point}\n" +
                $"--------------------------------";
        }
    }
}
