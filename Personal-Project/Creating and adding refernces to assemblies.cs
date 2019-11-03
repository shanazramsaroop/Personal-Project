using System;
namespace Personal_Project
{
    public class Creating_and_adding_refernces_to_assemblies
    {
        public Creating_and_adding_refernces_to_assemblies()
        {

            public string ScrapeWebpage(string url)
            {
                return GetWebpage(url);
            }

            public string ScrapeWebpage(string url, string filepath)
            {

                string reply = GetWebpage(url);

                File.WriteAllText(filepath, reply);
                return reply;
            }

            private string GetWebpage(string url)
            {

                WebClient Client = new WebClient();
                string reply = Client.DownloadString(url);

            }
        }
}
