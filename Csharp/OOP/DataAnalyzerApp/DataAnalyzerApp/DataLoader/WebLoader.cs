using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Authentication;
using System.Security.Policy;

namespace DataAnalyzerApp.DataLoader
{
    class WebLoader : Loader
    {
        private const string PATH = "https://swabhav-tech.firebaseapp.com/emp.txt";

        public string[] load()
        {
            string fulltext = "";
            const SslProtocols _Tls12 = (SslProtocols)0x00000C00;
            const SecurityProtocolType Tls12 = (SecurityProtocolType)_Tls12;
            ServicePointManager.SecurityProtocol = Tls12;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(PATH);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                fulltext = reader.ReadToEnd();
            }

            string[] lines=fulltext.Split('\n');
            return lines;
        }


        /* public string[] load()
         {
             StreamReader reader = new StreamReader(WebRequest.Create(PATH).GetResponse().GetResponseStream());
             string line;
             while ((line = reader.ReadLine()) != null)
             {
                 Console.WriteLine(line);
             }
             return null;
         }*/


    }
}
