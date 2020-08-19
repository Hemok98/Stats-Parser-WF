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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.OutputTextBox.Text = parser.CalculateStats(statsTextbox.Text);
            global::StatsParser_WF.Properties.Settings.Default.statsSaves = statsTextbox.Text;
            global::StatsParser_WF.Properties.Settings.Default.Save();
        }

        private void embedButton_Click(object sender, EventArgs e)
        {
            //this.OutputTextBox.Text = this.parser.getEmbed();
            string embed = this.parser.getEmbed();

            string replacements = this.embedTextbox.Text;
            replacements = replacements.Replace("\r\n", "");
            replacements = replacements.Replace("|", ";");
            replacements = replacements.Substring(0, replacements.Length - 1);
            string[] repls = replacements.Split(';');
            for (int i = 0; i < repls.Length/2; i++)
            {
                embed = embed.Replace(repls[i * 2], repls[i * 2 + 1]);
            }
            this.OutputTextBox.Text = embed;
            global::StatsParser_WF.Properties.Settings.Default.embedAssociations = this.embedTextbox.Text;
            global::StatsParser_WF.Properties.Settings.Default.Save();
        }
    }
}
