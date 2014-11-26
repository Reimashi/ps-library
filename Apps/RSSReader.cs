using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Threading;
using System.Xml.XPath;
using PSLibrary.G11N;

namespace PSLibrary.Apps
{
    public partial class RSSReader : UserControl
    {
        private List<RSSItems.Rss> rss = new List<RSSItems.Rss>();
        private Boolean isSearch = false;

        private BackgroundWorker bgwUpdate;

        private TreeNode lastNode;

        public RSSReader()
        {
            InitializeComponent();

            bgwUpdate = new BackgroundWorker();
            bgwUpdate.WorkerReportsProgress = true;
            bgwUpdate.WorkerSupportsCancellation = true;
            bgwUpdate.DoWork += bgwUpdate_DoWork;
            bgwUpdate.ProgressChanged += bgwUpdate_ProgressChanged;
            bgwUpdate.RunWorkerCompleted += bgwUpdate_RunWorkerCompleted;
        }

        public List<RSSItems.Rss> Items
        {
            get { return rss; }
        }

        public void UpdateInfo()
        {
            this.bUpdate.BackgroundImage = Properties.Resources.cancelIcon32;
            ProgressBar = 0;
            bgwUpdate.RunWorkerAsync();
        }

        public void bgwUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            isSearch = true;
            Int32 progreso = 0;

            foreach (RSSItems.Rss it in this.rss)
            {
                try
                {
                    // Cargamos el XML
                    XmlDocument doc = new XmlDocument();
                    doc.Load(it.Url.ToString());
                    XPathNavigator navigator = doc.CreateNavigator();

                    try
                    {
                        XPathNodeIterator nodesTitle = navigator.Select("//rss/channel/title");
                        while (nodesTitle.MoveNext())
                        {
                            // clean up the text for display
                            XPathNavigator node = nodesTitle.Current;
                            string tmp = node.Value.Trim();
                            tmp = tmp.Replace("\n", "");
                            tmp = tmp.Replace("\r", "");

                            it.Name = tmp;
                        }
                    }
                    catch
                    {
                        it.Name = "delete";
                        break;
                    }

                    List<String> newTitles = new List<String>();
                    List<Uri> newUris = new List<Uri>();

                    try
                    {
                        XPathNodeIterator nodes = navigator.Select("//rss/channel/item/title");
                        while (nodes.MoveNext())
                        {
                            // clean up the text for display
                            XPathNavigator node = nodes.Current;
                            string tmp = node.Value.Trim();
                            tmp = tmp.Replace("\n", "");
                            tmp = tmp.Replace("\r", "");

                            newTitles.Add(tmp);
                        }

                        XPathNodeIterator nodesLink = navigator.Select("//rss/channel/item/link");
                        while (nodesLink.MoveNext())
                        {
                            // clean up the link
                            XPathNavigator node = nodesLink.Current;
                            string tmp = node.Value.Trim();
                            tmp = tmp.Replace("\n", "");
                            tmp = tmp.Replace("\r", "");

                            Uri tmpUri = null;

                            try 
                            {
                                tmpUri = new Uri(tmp);
                            }
                            catch
                            {
                                it.Name = "delete";
                                break;
                            }

                            newUris.Add(tmpUri);
                        }

                        if (bgwUpdate.CancellationPending)
                        {
                            e.Cancel = true;
                            break;
                        }
                    }
                    catch
                    {
                        it.Name = "delete";
                        break;
                    }

                    for (Int32 j = 0; j < newTitles.Count; j++)
                    {
                        it.Items.Add(new RSSItems.News(newTitles[j], newUris[j]));
                    }
                }
                catch
                {
                    it.Name = "delete";
                    break;
                }

                progreso++;
                bgwUpdate.ReportProgress(this.Items.Count / (progreso * 100));
                ProgressBar = this.Items.Count / (progreso * 100);
                isSearch = false;
            }

            // Borrar los que no son RSS
            List<RSSItems.Rss> auxi = new List<RSSItems.Rss>();

            for (Int32 f = 0; f < this.Items.Count; f++)
            {
                if (this.Items[f].Name != "delete")
                {
                    auxi.Add(this.Items[f]);
                }
            }
            this.rss = auxi;
        }

        private void bgwUpdate_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UpdateTreeView();
            ProgressBar = e.ProgressPercentage;
        }

        private void bgwUpdate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UpdateTreeView();
            this.bUpdate.BackgroundImage = Properties.Resources.updateIcon32;
            ProgressBar = 100;
            isSearch = false;
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            if (isSearch)
            {
                bgwUpdate.CancelAsync();
            }
            else
            {
                UpdateInfo();
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (RSSItems.Rss rssp in this.Items)
                {
                    if (this.tbURL.Text == rssp.Url.ToString())
                    {
                        this.tbURL.Text = String.Empty;
                        return;
                    }
                }

                Uri newUri = new Uri(this.tbURL.Text);
                String newName = this.tbURL.Text;
  
                this.Items.Add(new RSSItems.Rss(newName, newUri));

                this.tbURL.Text = String.Empty;

                UpdateTreeView();
            }
            catch 
            {
                if (tbURL.Text != String.Empty)
                {
                    MessageBox.Show(g11n.getTranslateString("The URL is incorrect."), g11n.getTranslateString("Add RSS."), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.tbURL.Text = String.Empty;
                }
            }
        }

        public void UpdateTreeView()
        {
            this.tvRss.Nodes.Clear();

            foreach (RSSItems.Rss rx in this.Items)
            {
                Int32 index = 0;
                TreeNode[] arrayTN = new TreeNode[rx.Items.Count];

                foreach (RSSItems.News nws in rx.Items)
                {
                    arrayTN[index] = new TreeNode(nws.Title);
                    index++;
                }

                TreeNode treeNode = new TreeNode(rx.Name, arrayTN);
                this.tvRss.Nodes.Add(treeNode);
            }
        }

        private void tvRss_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = tvRss.SelectedNode;

            try
            {
                foreach (RSSItems.Rss rx in this.Items)
                {
                    foreach (RSSItems.News rn in rx.Items)
                    {
                        if (String.Format("{0}", node.Text) == rn.Title)
                        {
                            try
                            {
                                System.Diagnostics.Process.Start(rn.Url.ToString());
                            }
                            catch { }
                        }
                    }
                }
            }
            catch { }
        }

        public Int32 ProgressBar
        {
            get
            {
                return this.pbUpdate.Value;
            }
            set
            {
                if (value > 100)
                    this.pbUpdate.Value = 100;
                else if (value < 0)
                    this.pbUpdate.Value = 0;
                else
                    this.pbUpdate.Value = value;
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (RSSItems.Rss rx in this.Items)
                {
                    if (String.Format("{0}", this.lastNode.Text) == rx.Name)
                    {
                        rx.Name = "delete";
                    }
                }
            }
            catch 
            {}

            // Borrar los que no son RSS
            List<RSSItems.Rss> auxi = new List<RSSItems.Rss>();

            for (Int32 f = 0; f < this.Items.Count; f++)
            {
                if (this.Items[f].Name != "delete")
                {
                    auxi.Add(this.Items[f]);
                }
            }
            this.rss = auxi;

            UpdateTreeView();
        }

        private void tvRss_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.lastNode = tvRss.SelectedNode;
        }
    }
}
