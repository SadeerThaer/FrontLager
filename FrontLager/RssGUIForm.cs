using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSSEntities;

namespace FrontLager
{
    public partial class RssGUIForm : Form
    {
        private RSSLogic.RssHandler _rssHandler = new RSSLogic.RssHandler();
        public RssGUIForm()
        {
            InitializeComponent();
            var listOfPods= _rssHandler.LoadFileXml();
            CreatesListFromXmlToPod(listOfPods);
            LoadKategori();


        }

        private void KnappGetData_Click(object sender, EventArgs e)
        {
            LoadPod(TxtRssUrl.Text);
        }
        private void LoadPod(string Url)
        {
            List<RSSLogic.Poddar> ListOfPods = _rssHandler.LoadRss(Url, CBFrekvens.Text);
            CreatesListFromXmlToPod(ListOfPods);
        }

        private void CreatesListFromXmlToPod(List<RSSLogic.Poddar> listOfPods)
        {
            foreach (var onePod in listOfPods)
            {
                ListViewItem item = new ListViewItem(onePod.Info.Name);
                item.SubItems.Add(onePod.Info.NumberOfPods.ToString());
                item.SubItems.Add(onePod.Info.UpdateInterval);
                item.SubItems.Add(onePod.Info.Categories);
                podLista.Items.Add(item);
            }
        }

        private void BtnAddKategori_Click(object sender, EventArgs e)
        {
            _rssHandler.AddToKategoriLista(TBKategori.Text);
            LoadKategori();
        }

        private void LoadKategori()
        {
            PublishListOfKategorier(_rssHandler.GetListOfKategori());
        }

        private void PublishListOfKategorier(List<Kategori> listOfKategorier)
        {
            LWKategori.Items.Clear();
            foreach (var item in listOfKategorier)
            {
                    LWKategori.Items.Add(item.Name);
            
            }
        }
    }
}