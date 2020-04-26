using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemok98
{
    public class MinecraftStatsParser
    {
        private string[] statsNames;
        private int statsCount = 0;
        private Player[] players;

        private Player[] bestPlayers;
        
        public bool LoadStats(string directory)
        {
            if (!System.IO.Directory.Exists(directory)) return false;

            string[] files = System.IO.Directory.GetFiles(directory);

            this.players = new Player[files.Length];

            int filesIterator = 0;
            foreach (string fileName in files)
            {
                //Console.WriteLine(fileName);
                string uuid = fileName.Substring(directory.Length + 1);
                uuid = uuid.Substring(0, uuid.Length - 5);

                string uuidWeb = "";
                for (int i = 0; i < uuid.Length; i++)
                {
                    if (uuid[i] != '-') uuidWeb += uuid[i];
                }

                string textFromFile = "";
                using (System.IO.FileStream fstream = System.IO.File.OpenRead(fileName))
                {
                    byte[] array = new byte[fstream.Length];
                    fstream.Read(array, 0, array.Length);
                    textFromFile = System.Text.Encoding.Default.GetString(array); 
                }

                this.players[filesIterator] = new Player(uuidWeb, textFromFile);
                filesIterator++;
            }

            return true;
        }

        public string GetPlayersInfo()
        {
            string result = "";
            foreach(Player player in players)
            {
                result += "\r\n" + player.ToString();
            }
            result = result.Substring(2);
            return result;
        }

        public string CalculateStats(string statsNamesInStr)
        {
            string final = "";

            statsNamesInStr = statsNamesInStr.Replace("\r\n", "\n");
            statsNames = statsNamesInStr.Split('\n');
            bestPlayers = new Player[players.Length];
            foreach (Player player in players)
            {
                player.Parse(statsNames);
            }

            for (int statIter = 0; statIter < statsNames.Length; statIter++)
            {

                for (int i = 0; i < players.Length; i++)
                {
                    bestPlayers[i] = players[i];
                }

                for (int i = 0; i < players.Length; i++)
                {
                    for (int j = 0; j < players.Length-1; j++)
                    {
                        if (bestPlayers[j].getStat(statIter) < bestPlayers[j+1].getStat(statIter) )
                        {
                            Player sw = bestPlayers[j];
                            bestPlayers[j] = bestPlayers[j + 1];
                            bestPlayers[j + 1] = sw;
                        }
                    }
                }

                final += statsNames[statIter] + "\r\n";
                for (int i = 0; i < 3; i++)
                {
                    final += "- " + bestPlayers[i].Name + " " + bestPlayers[i].getStat(statIter) + "\r\n";
                }
            }

            return final;
        }
    }
}
