using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Wen
{
    class Link
    {
        public long LinkId {private set;get;}
        public string LinkName { private set; get; }
        public string LinkUrl  { private set; get; }
        public string LinkDescription { private set; get; }
        public int LinkCollectionFk { private set; get; }
        public int LinkCategorieFk { private set; get; }
        static public int AmountLinks { set; get; } 
        static public int AmountVideos { set; get;}

        readonly static List<Link> links = new List<Link>();

        readonly private List<Categorie> categorie = Categorie.GetCategories();

        private Link(long id, string name, string url, string description, int collectionFk, int categorieFk)
        {
            this.LinkId = id;
            this.LinkName = name;
            this.LinkUrl = url;
            this.LinkDescription = description;
            this.LinkCollectionFk = collectionFk;
            this.LinkCategorieFk = categorieFk;
        }

        static public void GetLinksFromDatabase(ListBox listbox)
        {
            MySqlDataReader reader = DBconnection.ExecuteReader("SELECT * FROM link");
            links.Clear();

            while (reader.Read())
            {
                Link link = new Link(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt16(4), reader.GetInt16(5));
                links.Add(link);
            }

            reader.Close();
            AddLinksToListBox(listbox);
        }

        static public void CreateLink(string name, string url, string description, int collection, int categorie, ListBox listbox, TextBox videosText, TextBox linksText)
        {
            Link link = new Link(InsertLinkInDb(name, url, description, collection, categorie), name, url, description, collection, categorie);

            links.Add(link);
            listbox.Items.Add(link);
            LinksCount(videosText, linksText);
        }

        static public List<Link> GetLinks()
        {
            return links;
        }

        static public bool CheckLinkConnection(string link, TextBox textBox, PictureBox errorPicture, PictureBox donePicture,TextBox name, TextBox descriptionBox)
        {
            bool linkWorks;
            try
            {
                WebRequest request = WebRequest.Create(link);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    linkWorks = true;
                    textBox.Text = response.StatusCode.ToString();
                    textBox.Visible = true;
                    errorPicture.Visible = false;
                    donePicture.Visible = true;

                    var webGet = new HtmlWeb();
                    var web = webGet.Load(link);
                    string title = web.DocumentNode.SelectSingleNode("html/head/title").InnerText;
                    string description = web.DocumentNode.SelectSingleNode("html/head/meta[@name='description']") != null 
                                         ? web.DocumentNode.SelectSingleNode("html/head/meta[@name='description']").InnerText 
                                         : web.DocumentNode.SelectSingleNode("//p[1]") != null
                                         ? web.DocumentNode.SelectSingleNode("//p[1]").InnerText
                                         : " ";
                    name.Text = title;
                    descriptionBox.Text = description;
                }
                else
                {
                    linkWorks = false;
                    textBox.Text = response.StatusCode.ToString();
                    textBox.Visible = true;
                    errorPicture.Visible = true;
                    donePicture.Visible = false;
                }
                response.Close();
            }
            catch (WebException)
            {
                linkWorks = false;
                textBox.Text = "I can't reach the URL!";
                textBox.Visible = true;
                errorPicture.Visible = true;
                donePicture.Visible = false;
            }

            return linkWorks;
        }

        public override string ToString()
        {
            return LinkName + " - " + categorie[LinkCategorieFk - 1].CategorieName;
        }

        static private long InsertLinkInDb(string name, string url, string description, int collection, int categorie)
        {
            string sql = "INSERT IGNORE INTO "
                         + "link(linkName, linkUrl, linkDescription, linkCollectionFk, linkCategorieFk)"
                         + "VALUES(@one, @two, @three, @four, @five)";

            long id = DBconnection.ExecuteInsertReturnId(sql, name, url, description, collection, categorie);

            return id;
        }

        static private void AddLinksToListBox(ListBox listbox)
        {
            listbox.Items.Clear();

            foreach(Link link in links)
            {
                listbox.Items.Add(link);
            }
        }

        static public void LinksCount(TextBox videosText, TextBox linksText)
        {
            AmountLinks = 0;
            AmountVideos = 0;

            foreach (Link link in links)
            {
                if(link.LinkCategorieFk == 1)
                {   
                    AmountLinks += 1;
                }
                else if (link.LinkCategorieFk == 2)
                {
                    AmountVideos += 1;
                }
            }

            videosText.Text = "Videos: " + AmountVideos;
            linksText.Text = "Links: " + AmountLinks;
        }

    }
}
