using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatsParser_WF
{
    public partial class MainForm : Form
    {
        Hemok98.MinecraftStatsParser parser;


        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm( Hemok98.MinecraftStatsParser statsParser )
        {
            parser = statsParser;
            InitializeComponent();
        }

        private Hemok98.Player[] players;
        private string[] bestPlayer;
        string[] statsNames;

        private void button1_Click(object sender, EventArgs e)
        {
            string dirName = directoryTextbox.Text;
            parser.LoadStats(dirName);
            //OutputTextBox.Text = parser.GetPlayersInfo();

            //OutputTextBox.Text = "";

            //if (!System.IO.Directory.Exists(dirName)) return;


            ////OutputTextBox.Text += statsCount.ToString();
            //string str = statsTextbox.Text;
            //Properties.Settings.Default.statsSaves = statsTextbox.Text;
            //Properties.Settings.Default.Save();

            //Hemok98.Player.SetStatsNames(str);

            //str = str.Replace("\r\n", "\n");
            //statsNames = str.Split('\n');

            ////string statsMass[statsTextbox.Text.]

            //string[] files = System.IO.Directory.GetFiles(dirName);

            //this.players = new Hemok98.Player[files.Length];
            //this.bestPlayer = new string[statsNames.Length];

            //int filesCounter = 0;
            //foreach (string fileName in files)
            //{
            //    //Console.WriteLine(fileName);
            //    string uuid = fileName.Substring(dirName.Length + 1);
            //    uuid = uuid.Substring(0, uuid.Length - 5);

            //    string uuidWeb = "";
            //    for (int i = 0; i < uuid.Length; i++)
            //    {
            //        if (uuid[i] != '-') uuidWeb += uuid[i];
            //    }


            //    string html = null;

            //    try
            //    {
            //        using (System.Net.WebClient web = new System.Net.WebClient())
            //        {
            //            html = web.DownloadString("https://api.mojang.com/user/profiles/" + uuidWeb + "/names");
            //        }
            //    }
            //    catch (System.Net.WebException ex)
            //    {
            //        System.Net.HttpWebResponse httpResp = (System.Net.HttpWebResponse)ex.Response;
            //        if (ex.Status == System.Net.WebExceptionStatus.ProtocolError && httpResp.StatusCode == System.Net.HttpStatusCode.NotFound)
            //        {
            //            // Страница не найдена
            //        }
            //        else throw;
            //    }

            //    if (html != null)
            //    {
            //        html = html.Substring(html.LastIndexOf("name") + 7);
            //        //textBox1.Text += html.LastIndexOf("name").ToString();
            //        html = html.Substring(0, html.IndexOf("\""));
            //    }

            //    this.players[filesCounter] = new Hemok98.Player(html, uuid);
            //    //в итоге в html хранится имя игрока
            //    //OutputTextBox.Text += "\"" + html + "\"" + "\r\n";

            //    // чтение из файла
            //    using (System.IO.FileStream fstream = System.IO.File.OpenRead(fileName))
            //    {
            //        // преобразуем строку в байты
            //        byte[] array = new byte[fstream.Length];
            //        // считываем данные
            //        fstream.Read(array, 0, array.Length);
            //        // декодируем байты в строку
            //        string textFromFile = System.Text.Encoding.Default.GetString(array);

            //        for (int statsCounter = 0; statsCounter < statsNames.Length; statsCounter++)
            //        {
            //            //OutputTextBox.Text += statsNames[statsCounter] + " - "  + FindStat(textFromFile, statsNames[statsCounter])  +  "\r\n";
            //            this.players[filesCounter].SetStatsCount(FindStat(textFromFile, statsNames[statsCounter]), statsCounter);
            //        }
            //        //OutputTextBox.Text += "sneak - " + sneak + "\r\n";
            //    }

            //    //OutputTextBox.Text +="\r\n";
            //    filesCounter++;
            //}
            ////D:\stats

            //int k = 0;
            //for (int statsCount = 0; statsCount < Hemok98.Player.GetStatsCount; statsCount++)
            //{
            //    for (int i = 0; i < this.players.Length; i++)
            //        for (int j = 0; j < this.players.Length - 1; j++)
            //            if (!this.players[j].СompareStats(this.players[j + 1], statsCount))
            //            {
            //                Hemok98.Player sw = this.players[j];
            //                this.players[j] = this.players[j + 1];
            //                this.players[j + 1] = sw;
            //                k++;
            //            }
            //    //foreach (Player playerOut in players)
            //    //    this.OutputTextBox.Text += playerOut.ToString();
            //    //break;
            //    this.bestPlayer[statsCount] = this.players[0].Name + " - " + this.players[0].GetStatCount(statsCount);
            //    this.OutputTextBox.Text += statsNames[statsCount] + "\r\n" + this.players[0].Name + " - " + this.players[0].GetStatCount(statsCount) + "\r\n";
            //}


            //this.OutputTextBox.Text += "\r\n\r\n";
            ////this.OutputTextBox.Text += " " + Hemok98.Player.GetStatsCount.ToString();
            //foreach (Hemok98.Player playerOut in players)
            //    this.OutputTextBox.Text += playerOut.Name + "\r\n";
        }

        private string FindStat(string json, string statName)
        {
            string stat = "0";
            if ( statName.IndexOf("/") != -1)
            {
                string statParam = statName.Substring(0, statName.IndexOf("/"));
                statName = statName.Substring(statName.IndexOf("/") + 1);
                //this.OutputTextBox.Text += statParam + "-" + statName + "\r\n";
                if (json.IndexOf(statParam) == -1) return stat;
                json = json.Substring(json.IndexOf(statParam) + 3);
                json = json.Substring(0, json.IndexOf("}"));
            }

            //if (statName == "minecraft:bow")
            //{
            //    json = json.Substring(json.IndexOf("minecraft:used")+3);
            //    json = json.Substring(0,json.IndexOf("}"));
            //}

            if (json.IndexOf(statName) != -1)
            {
                json = json.Substring(json.IndexOf(statName) + statName.Length + 2);
                string numbers = " 0123456789";
                int i = 0;
                stat = "";
                while ((i < json.Length) && (numbers.IndexOf(json[i]) !=-1))
                {                   
                    if (json[i]!=' ') stat += json[i];
                    i++;
                }
                //textBox1.Text += "!";
            }
            return stat;
        }

        private void RadioClick(object sender, MouseEventArgs e)
        {
            this.flag = !this.flag;
            CalculateChoiseRadiobutton.Checked = flag;
        }
        private bool flag = true;

        private void ChangeShownTextbox(object sender, EventArgs e)
        {
            bool flag = true;
            if (this.ChangeTextboxTrackbar.Value == 0)
                flag = true;
            else flag = false;
            this.statsTextbox.Visible = flag;
            this.embedTextbox.Visible = !flag;
        }

        private void GetEmbedButton_Click(object sender, EventArgs e)
        {
            if (players == null) return;
            Properties.Settings.Default.embedAssociations = embedTextbox.Text;
            Properties.Settings.Default.Save();
            string final = "/embed { \"color\": 712122, \"fields\": [{\"name\": \"Статистика прошедшего ивента Quartz Defenders\",\"value\": \":green_square:Победила зелёная команда: `jjshade2`, `_BrawlStars_`, `LinusHandboll`, `GoldenGuppies`, `Fon4uk` \\nНаибольшее число:\\n\" }";

            for (int i = 0; i < bestPlayer.Length; i++)
            {
                final += ",{\"name\": \"" + statsNames[i] + "\",\"value\": \"`" + bestPlayer[i] + "`\",\"inline\": true}";
            }
            final += "]}";
            //string test = "dfsd";
            //int n = test.Count;
            string associations = this.embedTextbox.Text;
            if (!associations.EndsWith("\r\n")) associations += "\r\n";
            this.OutputTextBox.Text = "";

            while (associations.IndexOf(';') != -1)
            {
                string statName = associations.Substring(0, associations.IndexOf('|')),
                 discordDisplay = associations.Substring(associations.IndexOf('|') + 1, associations.IndexOf(';') - associations.IndexOf('|')-1);
                //this.OutputTextBox.Text += statName  + discordDisplay + "\r\n";
                //final += final.IndexOf(statName).ToString();
                final = final.Replace(statName, discordDisplay);
                associations = associations.Substring(associations.IndexOf(';') + 3);
            }

            this.OutputTextBox.Text = final;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.OutputTextBox.Text = parser.CalculateStats(statsTextbox.Text);
        }
    }
}
