using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirplaneSoundBites.Service;

namespace AirplaneSoundBites
{
    public class ConsoleRunner
    {
        private AirplanePlayer player;
        private StringBuilder command;

        public ConsoleRunner()
        {
            player = new AirplanePlayer(@"C:\Users\Kyle\Desktop\Airplane");
            command = new StringBuilder();
        }

        public void Run()
        {
            bool endInput = true;
            do
            {
                char key = Console.ReadKey().KeyChar;
                if(key == '\u001b')
                {
                    endInput = false;
                }
                ExecuteCharacter(key);
            } while (endInput);
        }

        public void ExecuteCharacter(char c)
        {
            switch (c)
            {
                case '\t':
                    FinishOrListCommand();
                    break;
                case '\r':
                    ExecuteCommand();
                    break;
                default:
                    AddToCommand(c);
                    break;
            }
        }

        public void FinishOrListCommand()
        {

        }

        public void ExecuteCommand()
        {
            Console.Clear();
            string[] split = command.ToString().Split(' ');
            switch (split[0].ToLower())
            {
                case "play":
                    if(split.Length < 2)
                    {
                        Console.WriteLine("missing clip name");
                        break;
                    }
                    string fileName = player.AudioTitles.Where(t => t.Contains(split[1])).FirstOrDefault();
                    Console.WriteLine("Playing {0}", fileName);
                    player.SoundLocation = fileName;
                    player.Play();
                    break;
                case "list":
                    Console.WriteLine("Printing List");
                    foreach(string s in player.AudioTitles){
                        Console.WriteLine(s);
                    }
                    break;

                case "random":
                    player.PlayerRandomClip();
                    break;
                case "setfolder":
                    player.FolderPath = split[1];
                    break;
                case "defaultfolder":
                    player.FolderPath = @"C: \Users\Kyle\Desktop\Airplane";
                    break;
                default:
                    Console.WriteLine("Unable to read command,");
                    Console.WriteLine(split[0]);
                    break;
            }
            Console.WriteLine(command.ToString());
            command.Clear();
        }

        public void AddToCommand(char s)
        {
            command.Append(s);
        }
    }
}
