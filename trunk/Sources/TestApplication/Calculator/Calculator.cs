﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApplication.Calculator
{

    class  Calculator : Object
    {
        //[AsContract(PreCondition="bieda", Invariant="", PostCondition="")] // named args
        [AsContract("t == true.baba && ^a == 2", "biedactwo.baba > 4 && adam.go == 2 && @returnValue == 2", null)] // fixed args\
        public int Div(bool t, int divided, int divisor, string val)
        {
            return 0;// divided / divisor;
        }

    }


    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class AsContractAttribute : Attribute
    {

        public AsContractAttribute()
        {
        }

        public AsContractAttribute(string preCondition, string invariant, string postCondition)
        {

        }

        public string PostCondition
        {
            get;
            set;
        }

        public string Invariant
        {
            get;
            set;
        }

        public string PreCondition
        {
            get;
            set;

        }
    }

  
}
