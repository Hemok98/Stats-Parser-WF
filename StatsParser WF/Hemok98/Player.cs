using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hemok98
{
    class Player
    {
        private string name = "";
        private string uuid = "";
        private string json = "";
        private long[] stats;

        public Player(string uuid,string json)
        {
            this.uuid = uuid;
            this.json = json;
        }

        private void LoadName()
        {
            string html = null;

            try
            {
                using (System.Net.WebClient web = new System.Net.WebClient())
                {
                    html = web.DownloadString("https://api.mojang.com/user/profiles/" + uuid + "/names");
                }
            }
            catch (System.Net.WebException ex)
            {
                System.Net.HttpWebResponse httpResp = (System.Net.HttpWebResponse)ex.Response;
                if (ex.Status == System.Net.WebExceptionStatus.ProtocolError && httpResp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    // Страница не найдена
                }
                else throw;
            }

            if (html != null)
            {
                html = html.Substring(html.LastIndexOf("name") + 7);
                //textbox1.text += html.lastindexof("name").tostring();
                html = html.Substring(0, html.IndexOf("\""));
            }
            this.name = html;

        }

        public void Parse(string[] statsNames)
        {
            this.stats = new long[statsNames.Length];
            for (int i = 0; i < statsNames.Length; i++)
            {
                string parsed = json;
                string statName = statsNames[i];

                if ( statsNames[i].IndexOf("/") != -1 )
                {
                    string statCategory = statName.Substring(0, statName.IndexOf("/"));
                    statName = statName.Substring(statName.IndexOf("/") + 1);
                    if (parsed.IndexOf(statCategory + "\"") != -1)
                    {
                        parsed = parsed.Substring(parsed.IndexOf(statCategory + "\"") + statCategory.Length + 2);
                        parsed = parsed.Substring(0, parsed.IndexOf("}") + 1);
                    }
                    else
                    {
                        parsed = "";
                    }

                }

                long statNum = 0;
                if (parsed.IndexOf(statName + "\"") != -1)
                {
                    parsed = parsed.Substring(parsed.IndexOf(statName + "\"") + statName.Length + 2);
                    int j = 0;
                    string numbers = "0123456789";
                    while (numbers.IndexOf(parsed[j]) != -1)
                    {
                        statNum = statNum * 10 + numbers.IndexOf(parsed[j]);
                        j++;
                    }
                }

                this.stats[i] = statNum;
            }
        }

        public long getStat(int number)
        {
            return this.stats[number];
        }

        public override string ToString()
        {
            return  this.name + " - " + this.uuid;
            //string final = "";
        }

        public string Name
        {
            get {
                if (this.name == "")
                {
                    this.LoadName();
                }
                return this.name;
            }
        }

        public string UUID
        {
            get { return this.uuid; }
        }
    }
}
