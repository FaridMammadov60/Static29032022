using System;
using System.Text.RegularExpressions;

namespace StaticAndInterfaceConsoleApp.Models
{
    internal class Group
    {
        #region Fields
        string _groupNo;
        Student[] _students;
        #endregion

        #region Constructor
        public Group(int length, string groupno)
        {
            _students = new Student[length];
            this.GroupNo = groupno;
        }
        #endregion


        #region Property

        public Student this[int index]
        {
            get
            {
                if (index < _students.Length && index >= 0)
                {
                    return _students[index];
                }
                Console.WriteLine("sehv get");
                throw new Exception();
            }
            set
            {
                if (index < _students.Length && index >= 0)
                {
                    _students[index] = value;
                    return;
                }
                Console.WriteLine("sehv set");
                throw new Exception();

            }
        }
        public Student[] Students
        {
            get
            {
                return _students;
            }  
            private set
            {
                _students=value;
            }
            
        }

        public string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
                else
                {
                C1: Console.Write("Qrup nömrəsin əvvəldə 2 böyük hərf sonra 3 dənə rəqəm olaraq daxil edin: ");
                    value = Console.ReadLine();
                    if (CheckGroupNo(value))
                    {
                        _groupNo = value;
                        return;
                    }
                    goto C1;
                }

            }
        }
        #endregion

        #region Method
        /// <summary>
        /// Qrupda olacaq telebelerin say limitini teyin edir
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int StudentLimit(int num)
        {
            if (num < 5 || num > 18)
            {
            L1: Console.WriteLine("5-18 aralığında rəqəm daxil edin: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 5 || num > 18)
                {
                    goto L1;
                }
                return num;
            }
            return num;
        }

        //Pattern ilk 2 herf boyuk sonra 3 reqem
        public const string GroupNo_Pattern = @"^[A-Z]{2}[\d]{3}$";
        public bool CheckGroupNo(string groupno)
        {
            if (Regex.IsMatch(groupno, GroupNo_Pattern))
            {
                return true;
            }
            return false;

        }

        public void GetStudent(int? num)
        {
            int num2 = 0;
            num2 = Convert.ToInt32(num);            
            Console.WriteLine(Students[num2]);

        }

        public void GetAllStudent()
        {           
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine(Students[i]);
            }           

        }

        public  void AddStudent(Student student)
        {
            if (Students.Length>19)
            {
                Console.WriteLine("Massiv tam doludur");
                return;
            }
            Array.Resize(ref _students,Students.Length);           
            Students[Students.Length-1] = student;
        }

        #endregion

        public override string ToString()
        {
            return $"Student {_students}";
        }
    }
}
