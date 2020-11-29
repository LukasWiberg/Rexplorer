using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Rexplorer.Classes {
    class ReScrape {
        HtmlWeb web;

        public ReScrape() {
            web = new HtmlWeb();
        }

        public string[] Scrape(string uri, string configPath) {
            if(File.Exists(configPath)) {
                ReScrapeConfig config = JsonConvert.DeserializeObject<ReScrapeConfig>(File.ReadAllText(configPath));
                return ScrapeSite(uri, config);
            } else {
                throw new Exception("File on path \"" + configPath + "\" does not exist");
            }
        }

        public string[] ScrapeSite(string uri, ReScrapeConfig config, int page = 1) {
            List<string> ret = new List<string>();
            string fullUri = uri + (uri.IndexOf('?') > -1 ? "&"+ config.page +"=" + page : "?"+config.page+"=" + page);
            Debug.WriteLine("Scraping: " + fullUri);
            HtmlNode doc = web.Load(fullUri).DocumentNode;
            var nextPageButton = doc.QuerySelectorAll(config.nextButtonQuery);
            string baseUri = config.useBaseUri ? uri : "";
            if(baseUri != "") {
                baseUri = baseUri.LastIndexOf('/')>8 ? baseUri.Split('/')[0]+"//"+baseUri.Split('/')[2] : baseUri.Contains('?') ? baseUri.Split('?')[0] : baseUri;
            }

            ret.AddRange(GetVideoLinks(doc, baseUri, config));

            Debug.WriteLine("Links in " + uri + ": " + ret.Count);

            if(nextPageButton.ToArray().Length > 0) {
                ret.AddRange(ScrapeSite(uri, config, page+1));
            }

            return ret.ToArray();
        }

        public List<string> GetVideoLinks(HtmlNode doc, string baseUrl, ReScrapeConfig config) {
            List<string> ret = new List<string>();
            List<HtmlNode> videoLinks = doc.QuerySelectorAll(config.videoQuery).ToList();
            for(int i = 0; i<videoLinks.Count(); i++) {
                ret.Add(baseUrl + videoLinks[i].Descendants("a").First().Attributes["href"].Value);
            }
            return ret;
        }
    }


    public class ReScrapeConfig {
        public string page;
        public string nextButtonQuery;
        public string videoQuery;
        public bool useBaseUri;
    }
}
