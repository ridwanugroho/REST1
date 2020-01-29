using System;
using System.Collections.Generic;


namespace ACTOBJ
{
    public class Activity
    {
        public int id{get; set;}
        public string Name{get; set;}
        public string Desc{get; set;}
        public bool status{get; set;}
        public string getStatus()
        {
            if(status)
                return "done";

            else
                return "un-done";
        }
    }
}