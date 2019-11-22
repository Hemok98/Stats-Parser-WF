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
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dirName = directoryTextbox.Text;
            OutputTextBox.Text = "";

            if (System.IO.Directory.Exists(dirName))
            {

                //OutputTextBox.Text += statsCount.ToString();
                string str = statsTextbox.Text;
                Properties.Settings.Default.statsSaves = statsTextbox.Text;
                Properties.Settings.Default.Save();
                str = str.Replace("\r\n", "\n");
                string[] statsNames = str.Split('\n');
                
                //string statsMass[statsTextbox.Text.]

                string[] files = System.IO.Directory.GetFiles(dirName);
                int filesCounter = 0;
                foreach (string fileName in files)
                {
                    //Console.WriteLine(fileName);
                    string uuid = fileName.Substring(dirName.Length+1);
                    uuid = uuid.Substring(0, uuid.Length - 5);

                    string uuidWeb = "";
                    for (int i = 0; i < uuid.Length; i++)
                    {
                        if (uuid[i] != '-') uuidWeb += uuid[i];
                    }


                    string html = null;

                    try
                    {
                        using (System.Net.WebClient web = new System.Net.WebClient())
                        {
                            html = web.DownloadString("https://api.mojang.com/user/profiles/" + uuidWeb + "/names");
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
                        html = html.Substring(html.LastIndexOf("name" )+7);
                        //textBox1.Text += html.LastIndexOf("name").ToString();
                        html = html.Substring(0, html.IndexOf("\""));
                    }
                    //в итоге в html хранится имя игрока
                    OutputTextBox.Text += "\"" + html + "\"" + "\r\n";

                    // чтение из файла
                    using (System.IO.FileStream fstream = System.IO.File.OpenRead(fileName))
                    {
                        // преобразуем строку в байты
                        byte[] array = new byte[fstream.Length];
                        // считываем данные
                        fstream.Read(array, 0, array.Length);
                        // декодируем байты в строку
                        string textFromFile = System.Text.Encoding.Default.GetString(array);

                        for (int statsCounter = 0; statsCounter < statsNames.Length; statsCounter++)
                        {
                            OutputTextBox.Text += statsNames[statsCounter] + " - "  + findStat(textFromFile, statsNames[statsCounter])  +  "\r\n";
                        }
                        //OutputTextBox.Text += "sneak - " + sneak + "\r\n";
                    }

                    OutputTextBox.Text +="\r\n";
                    filesCounter++;
                }
                // D:\stats

            }
        }

        private string findStat(string file, string statName)
        {
            string stat = "0";
            if (file.IndexOf(statName) != -1)
            {
                file = file.Substring(file.IndexOf(statName) + statName.Length + 2);
                string numbers = " 0123456789";
                int i = 0;
                stat = "";
                while ( numbers.IndexOf(file[i]) !=-1)
                {                   
                    if (file[i]!=' ') stat += file[i];
                    i++;
                }
                //textBox1.Text += "!";
            }
            return stat;
        }
    }
}
