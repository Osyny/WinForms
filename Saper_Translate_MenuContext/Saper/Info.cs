using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{

    [Serializable]
    class Info 
    {
        private string time;
        private string name;
        private string level;

        public Info() { }

        public Info(string name, string level)
        {
            this.name = name;
            this.level = level;
            time = "00:00";
        }


        public string Time { get { return time; } set { time = value; } }
        public string Name { get { return name; } }
        public string Level { get { return level; } }
    }
 }
