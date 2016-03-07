using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirplaneSoundBites.Service;
using AirplaneSoundBites.ConsoleInterface.Command;

namespace AirplaneSoundBites.ConsoleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IClipRepository repo = new LocalClipDirectory(@"C:\Users\Kyle\Desktop\Airplane");
            ClipPlayer player = new ClipPlayer(repo);
            AbstractCommand random = new PlayRandomCommand(player);
            AbstractCommand list = new ListCommand(player);
            AbstractCommand play = new PlayCommand(player);
            

            ConsoleRunner app = new ConsoleRunner(player);
            app.AddCommand(list);
            app.AddCommand(play);
            app.AddCommand(random);
            app.Run();
            
        }
    }
}
