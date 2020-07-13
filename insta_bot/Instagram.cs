using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace insta_bot
{
    class Instagram
    {
        public static Profile GetProfileByUser(string username ,string senha)
        {
            var profile = new Profile(username,senha);
            string urlInstagram = @"https://instagram.com/" + username + "/";
            string markup;

            using (WebClient c = new WebClient())
            {
                markup = c.DownloadString(urlInstagram);
            }

            HtmlAgilityPack.HtmlDocument html = new HtmlAgilityPack.HtmlDocument();
            html.LoadHtml(markup);

            var list = html.DocumentNode.SelectNodes("//meta");

            foreach (var node in list)
            {
                string property = node.GetAttributeValue("property", "");

                if (property == "og:description")
                {
                    profile.Descricao = node.GetAttributeValue("content", "");

                }
    

            }

            return profile;

        }
    }
}
