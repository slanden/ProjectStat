using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ProjectStat
{
    class Project
    {
        public string name { get; set;}
        public int editDate { get; set; }
        public int time { get; set; }

        //parameterless constructor needed for xmlSerializer
        public Project() { }
        public Project(string projectName)
        {
            name = projectName;
            editDate = 0;
            time = 0;
        }
    }
}