using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPrjWinCsStudentInfo
{
    class clsListStudent
    {

        // Private or Hidden dictionary to uncapsulate our own list.
        private Dictionary<string, ClsStudent > mylist;



        public clsListStudent()
        {
            mylist = new Dictionary<string, ClsStudent>();
        }

        public int Quantity
        {
            get { return mylist.Count; }
            //Read only we cannot change the amount
        }

        public Dictionary<string, ClsStudent>.ValueCollection Element
        {
            get => mylist.Values;

        }

        public bool Add(ClsStudent Student)
        {
            if (Exist(Student.Number) == false)
            {
                mylist.Add(Student.Number, Student);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Delete(string number)
        {
            return mylist.Remove(number);
        }

        public ClsStudent Find(string number)
        {
            if (Exist(number) == true)
            {
                return mylist[number];
            }
            else
            {
                return null;
            }
        }

        public bool Exist(string number)
        {
            return mylist.ContainsKey(number);
        }

       /* public string MoveFirst()
        {
            KeyValuePair<int, string> firstPairOfDictionary = mylist.FirstOrDefault();

            return mylist.First();
            
        }*/


        public string Display()
        {
            string info = "";
            foreach (ClsStudent itm in mylist.Values)
            {
                info += itm.Display() + "\n";
            }
            return info;
        }
    }
}
