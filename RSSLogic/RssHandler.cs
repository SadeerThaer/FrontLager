using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using RSSEntities;

namespace RSSLogic
{
    public class RssHandler
    {
        private RSSData.RssDataHandler _rssDataHandler = new RSSData.RssDataHandler();
        private List<Kategori> ListOfKategorier = new List<Kategori>();

        public RssHandler()
        {
            ListOfKategorier = _rssDataHandler.LoadKategoriFromDisc();
        }
        public void fetchRssFeed(string url)
        {
            SyndicationFeed feed = _rssDataHandler.FetchRssData(url);
            var kategoriFeed= feed.Categories;

        }
        //Metoden skapar poddar till listan från en URL.
        public List<Poddar> LoadRss(string choosenUrl, string Frekvens)
        {
            List<Poddar> listOfPods = new List<Poddar>();
            Poddar onePod = new Poddar();
            onePod.Info.UpdateInterval = Frekvens;
            onePod.PoddRSS = _rssDataHandler;
            onePod.Info.Url = choosenUrl;
            onePod.LoadPod();
            listOfPods.Add(onePod);
            return listOfPods;
        }

        public List<Poddar> LoadFileXml()
        {

            List<string> listOfPodsThatContainsXml = new List<string>();
            listOfPodsThatContainsXml = _rssDataHandler.GetFileNamesThatContainXml();
            List<Poddar> listOfPods = new List<Poddar>();
            foreach (var item in listOfPodsThatContainsXml)
            {
                Poddar onePod = new Poddar();
                onePod.PoddRSS = _rssDataHandler;
                onePod.LoadPodFromFile(item);
                listOfPods.Add(onePod);
            }
            return listOfPods;
        }

        public void AddToKategoriLista(string Kategori)
        {
            Kategori oneKategori = new Kategori();
            oneKategori.Name = Kategori;
            ListOfKategorier.Add(oneKategori);
            _rssDataHandler.SaveKategorierToATxtDocument(ListOfKategorier);
            
        }

        public List<Kategori> GetListOfKategori()
        {
            return ListOfKategorier;
        }

       
    }
}
