using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPrjWinCsStudentInfo
{
    class ClsStudent
    {
        /// <summary>
        //============= Properties ============== //
        /// </summary>
        /// 
        private string vName;
        private Single vGrade;
        private DateTime vBirthdate;
        private int H = Convert.ToInt32(DateTime.Today.Year);
        private string vNumber;
        public string Name
        {
            set { vName = value; }
            get { return vName; }
        }

        public DateTime BirthDate
        {
            set { vBirthdate = value; }
            get { return vBirthdate; }
        }

        public Single Grade
        {
            // No set because its read only

            get { return vGrade; }
        }

        public int Age
        {

            //Read Only
            get { return H - BirthDate.Year; }
        }
        public string Number
        {
            get { return vNumber; }  //for reading of the field
            set { vNumber = value; } // for writing of the value
        }


        /// <summary>
        //============= Constructors ============== //
        /// </summary>

        public ClsStudent()
        {
            vName = "Not defined";
            vBirthdate = new DateTime();
            vGrade = -1;
            vBirthdate = DateTime.Now;
        }

        public ClsStudent(string aName, int aDay, int aMonth, int aYear, Single aGrade)
        {
            
            Name = aName;
            vBirthdate = new DateTime(aDay, aMonth, aYear);
            vGrade = aGrade;
        }

        public ClsStudent(string aName, DateTime aDate, Single aGrade)
        {
            Name = aName;
            vBirthdate = aDate;
            vGrade = aGrade;
        }


        /// <summary>
        //============= Methods ============== //
        /// </summary>

        public void Register(string Number ,string Fullname, DateTime Bdate, Single grade)
        {
            vNumber = Number;
            Name = Fullname;
            BirthDate = Bdate;
            vGrade = grade;
            

        }



        public bool ToGrade(Single aGrade)
        {
            if (aGrade >= 0 && aGrade <= 100)
            {
                vGrade = aGrade;
                return true;
            }
            else
            {
                return false;
            }

        }

        public string Display()
        {

            string op;

            op = "Number : " + vNumber;
            op += "Name : " + vName;
            op += "\nBirthDate : " + vBirthdate;
            op += "\nGrade : " + Grade + "/100";
            op += "\nAge : " + Age + " years";
            return op;
        }
    }
}
