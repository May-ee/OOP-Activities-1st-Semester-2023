using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Details
    {
        private string[] FName;
        private string[] MidN = { };
        private string[] LastN = { };
        private string[] Age = { };

        public Details()
        {
            FName = new string[] { };
            MidN = new string[] { };
            LastN = new string[] { };
            Age = new string[] { };
        }

        public string[] getF()  //twice refered to Form1 UpdateDataGridView() Method
        {
            return (string[])FName.Clone();
         
        }

        public string[] getM()
        {
            return (string[])MidN.Clone();
        }

        public string[] getL()
        {
            return (string[])LastN.Clone();
        }

        public string[] getA()
        {
            return (string[])Age.Clone();
        }



        public void AddData(string newItem, string newItem2, string newItem3, string newItem4)
        {
            Array.Resize(ref FName, FName.Length + 1);
            FName[FName.Length - 1] = newItem;

            Array.Resize(ref MidN, MidN.Length + 1);
             MidN[MidN.Length - 1] = newItem2;

            Array.Resize(ref LastN, LastN.Length + 1);
             LastN[LastN.Length - 1] = newItem3;

            Array.Resize(ref Age, Age.Length + 1);
            Age[Age.Length - 1] = newItem4;
        }

    }

}
