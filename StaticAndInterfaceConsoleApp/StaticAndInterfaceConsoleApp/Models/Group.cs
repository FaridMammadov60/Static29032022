using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndInterfaceConsoleApp.Models
{
    internal class Group
    {
        #region Fields
        static int _groupNo;
        Student [] _students;
        #endregion

        #region Property

        public Student[] StudentLimit 
        { 
            get
            {
                return _students;
            }
            set
            {
                _students = value;
            }
        }
        #endregion
    }
}
