using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FileReader
{
    class HtppRequest
    {

        public static void Main(string [] args)
        {

            // Create a request for the URL. 
            WebRequest request = WebRequest.Create(
              "http://www.ncdc.noaa.gov/cdo-web/api/v2/datasets");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Headers.Add("Token:PFnuzFsokUgKgcUaKzTUUvqhcFoumuta");

            // Get the response.             
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Clean up the streams and the response.

            RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(responseFromServer);
            
            foreach (Result result in rootObject?.results)
            {
                Console.WriteLine(result.name);
            }

            reader.Close();
            response.Close();
            

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
