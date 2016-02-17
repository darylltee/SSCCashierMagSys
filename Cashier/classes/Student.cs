using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cashier.classes;

namespace Cashier.classes
{
    class Student
    {

        public string[] studentData = new string[35];
        public int StudID;
        // constructor
        public Student(string StudID = null)
        {
            if (StudID != null)
            {
                this.StudID = int.Parse(StudID);
                new clsDB().Con().SelectData("SELECT * FROM student WHERE StudID = " + StudID, studentData);
            }
        }

        public string course()
        {
            string course = "";
            string[] obj = new string[1];

            new clsDB().Con().SelectData("SELECT ProgCode FROM StudentCourse as SC JOIN Student as S ON SC.StudID = S.StudID WHERE SC.StudID = " + StudID, obj);

            course = obj[0];

            return course;
        }

  



    }
}
