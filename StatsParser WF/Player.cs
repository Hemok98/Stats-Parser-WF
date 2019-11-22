using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsParser_WF
{
    class Player
    {
        private string name,
                       uuid;
        private string[] statsCount;
        private static string[] statsNames;

        public static void SetStatsNames(string str)
        {
            str = str.Replace("\r\n", "\n");
            statsNames = str.Split('\n');
        }

        public Player(string name,string uuid)
        {
            this.name = name;
            this.uuid = uuid;
            statsCount = new string[statsNames.Length];
        }

        public void SetStatsCount(string stat,int statNum)
        {
            this.statsCount[statNum] = stat;
        }

        public bool СompareStats(Player other, int statNum)
        {
            //if (this.statsCount[statNum].Length > other.statsCount[statNum].Length) return true;
            //if (this.statsCount[statNum].Length < other.statsCount[statNum].Length) return false;
            //for (int i = 0; i < this.statsCount[statNum].Length; i++)
            //    if (this.statsCount[statNum][i] < other.statsCount[statNum][i]) return false;
            //if ( this.statsCount[statNum].CompareTo(other.statsCount[statNum]) >=0 ) return true;
            //return true;
            return int.Parse(this.statsCount[statNum]) > int.Parse(other.statsCount[statNum]);
        }

        public override string ToString()
        {
            string final = "\"" + this.name + "\" - " + this.uuid;
            //string final = "";
            for (int i = 0; i < this.statsCount.Length; i++)
                final += "\r\n" + statsNames[i] + " - " +  this.statsCount[i];
            return final + "\r\n\r\n";
        }

        public static int GetStatsCount
        {
            get { return statsNames.Length; }
        }

        public string Name
        {
            get { return this.name; }
        }


        public static string GetStatName(int num)
        {
            return statsNames[num];
        }

        public string GetStatCount(int num)
        {
            return this.statsCount[num];
        }
    }
}
