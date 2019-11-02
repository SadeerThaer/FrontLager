using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using RSSEntities;

namespace RSSData
{
    public class RssDataHandler
    {

        public SyndicationFeed FetchRssData(string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            return feed;
        }

        public void SaveRssDataToFile(SyndicationFeed feed, string fileNamePod)
        {
            using (XmlTextWriter writer = new XmlTextWriter(fileNamePod, null))
            {
                writer.Formatting = Formatting.Indented;
                feed.SaveAsRss20(writer);
            }
        }
        public SyndicationFeed LoadRssDataFromFile(string fileName)
        {
            StreamReader fileReader = new StreamReader(fileName);
            XmlReader reader = XmlReader.Create(fileName);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            return feed;

        }
        public List<string> GetFileNamesThatContainXml()
        {
            DirectoryInfo myFileList = new DirectoryInfo(Directory.GetCurrentDirectory());
            FileInfo[] filer = myFileList.GetFiles();
            List<string> fileName = new List<string>();
            bool endsWithXml = false;

            foreach (FileInfo item in filer)
            {
                endsWithXml = item.Name.EndsWith(".XML".ToUpper());
                if (endsWithXml)
                {
                    fileName.Add(item.Name);
                }
            }
            return fileName;

        }

        public void SaveKategorierToATxtDocument(List<Kategori> ListOfKategorier)
        {
            using (StreamWriter writeText = new StreamWriter(Directory.GetCurrentDirectory() + "\\Kategorier.txt"))
            {
                string textInDocument = "";
                foreach (var item in ListOfKategorier)
                    {
                    textInDocument += item.Name + ";";
                    }
                writeText.WriteLine(textInDocument);
            }
        }
        public List<Kategori> LoadKategoriFromDisc()
        {
            List<Kategori> listaOfKategorier = new List<Kategori>();
            string fileName = Directory.GetCurrentDirectory() + "\\Kategorier.txt";
            if (File.Exists(fileName))
            {
                using (StreamReader getTextKategori = new StreamReader(fileName))
                {
                    string txtFromDocument = getTextKategori.ReadToEnd();
                    var kategoriLista = txtFromDocument.Split(';');
                    foreach (var item in kategoriLista)
                    {
                        listaOfKategorier.Add(new Kategori { Name = item });
                    }

                }
            }
            return listaOfKategorier;
        }

    }
}
