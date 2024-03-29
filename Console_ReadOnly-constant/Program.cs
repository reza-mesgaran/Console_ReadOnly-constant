﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_ReadOnly_constant
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class person
    {
        const double PI = 3.14;
        readonly int myReadonlyField = 10;

        //-------------------- First Difference

        // const myConstField;  ERROR -> constant field must be initialized when it is declare
        public readonly int myReadonlyField2;    // readonly field can be declared without initialization


        public person()   //constructor
        {
            //-------------------- Second Difference

            myReadonlyField = 10 + 10;  // readonly fields's value can change ONLY in Constructor
                                        // PI = 100;   ERROR -> Const fields's value can not be change anymore
        }

        //-------------------- Third Difference  

        const double myConstField2 = Math.Sqrt(4);  // Const field can NOT be assigned a value that is a result of a calculation
        readonly double myReadonlyField3 = Math.Sqrt(4);  // readonly field can be assigned a value that is a result of a calculation



    }
}
