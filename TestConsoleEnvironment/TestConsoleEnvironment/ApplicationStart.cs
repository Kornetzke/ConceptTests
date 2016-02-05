using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TDD_FizzBuzz.AcceptanceTests;

namespace TestConsoleEnvironment.TDD_FizzBuzz
{
    class ApplicationStart
    {

        public static FizzBuzzAcceptanceTests acceptanceTests;


        static void Main(string[] args)
        {
            bool running = true;
            acceptanceTests = new FizzBuzzAcceptanceTests();
            Console.WriteLine("Hello");
            StringBuilder inputBuffer = new StringBuilder();
            StringBuilder outputBuffer = new StringBuilder();


            while (running)
            {
                var key = Console.ReadKey();
                outputBuffer.Clear();


                if (key.Key == ConsoleKey.Tab)
                {
                    List<string> commands = acceptanceTests.FindMatchingCommands(inputBuffer.ToString());
                    foreach(string command in commands)
                    {
                        outputBuffer.AppendLine(command);
                    }
                    inputBuffer.Clear();
                }else if( key.Key == ConsoleKey.Enter)
                {
                    outputBuffer.AppendLine(acceptanceTests.ExecuteStringCommand(inputBuffer.ToString()));
                    inputBuffer.Clear(); 
                }
                else
                {
                    if (key.KeyChar.ToString() == "\b")
                    {
                        if (inputBuffer.Length > 0)
                        {
                            //remove last character
                            inputBuffer.Remove(inputBuffer.Length - 1, 1);
                        }
                    }
                    else
                    {
                    inputBuffer.Append(key.KeyChar.ToString());

                    }
                    
                }
                if(outputBuffer.Length > 0)
                {
                    Console.WriteLine(outputBuffer.ToString());
                }
            }
        }


        

        
    }
}
