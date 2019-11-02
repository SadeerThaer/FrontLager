using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using RSSEntities;

namespace RSSLogic
{
    public class Poddar
    {
        public PoddInfo Info { get; set; } = new PoddInfo();
        //public string Name { get; set; }
        //public int NumberOfPods { get; set; }

        //public string UpdateInterval  { get; set; }
        //public string Categories { get; set; }

        //public string PodDescription { get; set; }

        //public string Url { get; set; }

        public RSSData.RssDataHandler PoddRSS { get; set; }

        private SyndicationFeed PodFeed;

        public void LoadPod()
        {
            string allKategorier = ""; 
            PodFeed = PoddRSS.FetchRssData(Info.Url);
            if (PodFeed.Categories.Count() == 0)
            {
                allKategorier = "Okänd kategori";
            }
            else
            {   
                foreach (var oneKategori in PodFeed.Categories)
                {
                    allKategorier += oneKategori.Name;
                }
            }
            this.Info.Categories = allKategorier;
            this.Info.Name = PodFeed.Title.Text;
            this.Info.NumberOfPods = PodFeed.Items.Count();
            SavePod();


        }
        public void LoadPodFromFile(string fileName)
        {
            string allKategori = "";
            PodFeed = PoddRSS.LoadRssDataFromFile(fileName);
            if (PodFeed.Categories.Count() == 0)
            {
                allKategori = "Okänd kategori";
            }
            else
            {
                foreach (var oneKategori in PodFeed.Categories)
                {
                    allKategori += oneKategori.Name;
                }
            }
            this.Info.Categories = allKategori;
            this.Info.Name = PodFeed.Title.Text;
            this.Info.NumberOfPods = PodFeed.Items.Count();
        }
        private void SavePod()
        {
            PoddRSS.SaveRssDataToFile(PodFeed, Info.Name +".XML");
        }
    }
}
