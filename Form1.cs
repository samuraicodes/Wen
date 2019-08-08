using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Wen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DBconnection.InitConnection();
            Collection.GetCollectionsFromDatabase(linkCollectionBox,searchCollection,videoCollection,deleteNameBox);
            Categorie.GetCategoriessFromDatabase(linkCategoriesBox, searchCategoriesBox);
            Link.GetLinksFromDatabase(linksList);
            Link.LinksCount(videosCount, linksCount);
            Collection.CollectionCount(collectionCount);
        }

        readonly List<Collection>  collectionList = Collection.GetCollections();

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DBconnection.EndConnection();
        }

        private void AddCollection(object sender, EventArgs e)
        {
            if(addNameTextBox.Text != "Name")
            {
                Collection.CreateCollection(addNameTextBox.Text, linkCollectionBox, searchCollection, videoCollection, deleteNameBox);
                Collection.CollectionCount(collectionCount);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(deleteNameBox.SelectedIndex >= 0)
            {
                Collection collection = collectionList[deleteNameBox.SelectedIndex];
                string conditionCollection = "collectionName = '" + collection.CollectionName + "'";
                string conditionLink = "linkCollectionFk = '" + collection.CollectionId + "'";
                DBconnection.ExecuteDelete("link", conditionLink);
                DBconnection.ExecuteDelete("collection", conditionCollection);
                Collection.GetCollectionsFromDatabase(linkCollectionBox, searchCollection, videoCollection, deleteNameBox);
                Link.GetLinksFromDatabase(linksList);
                Link.LinksCount(videosCount, linksCount);
                Collection.CollectionCount(collectionCount);
            }
            
        }

        private void CollectionDeleteButton_Leave(object sender, EventArgs e)
        {
            deleteNameBox.Items.Clear();
        }

        private void DeleteCollection(object sender, EventArgs e)
        {
            deleteNameBox.Items.Clear();

            foreach (Collection collection in collectionList)
            {
                deleteNameBox.Items.Add(collection);
            }

        }

        private void AddLink(object sender, EventArgs e)
        {
            if ((linkUrlBox.Text != "URL") && (linkCollectionBox.Text != "Select Collection")
                && linkCategoriesBox.Text != "Select Categorie")
            {
                if(Link.CheckLinkConnection(linkUrlBox.Text, linkStatusBox, linkErrorPicture, linkDonePicture, linkNameBox, linkDescriptionBox) == true)
                {
                    if (linkDescriptionBox.Text != "Description")
                    {
                        Link.CreateLink(linkNameBox.Text, linkUrlBox.Text, linkDescriptionBox.Text, linkCollectionBox.SelectedIndex + 1
                                        , linkCategoriesBox.SelectedIndex + 1, linksList, videosCount,linksCount);
                    }
                    else
                    {
                        Link.CreateLink(linkNameBox.Text, linkUrlBox.Text, "", linkCollectionBox.SelectedIndex + 1
                                        , linkCategoriesBox.SelectedIndex + 1, linksList, videosCount, linksCount);
                    }
                }
            }
        }

        readonly List<Link> notSortedLinks = Link.GetLinks();
        readonly List<Link> sortedLinks = new List<Link>();
        private void SortLinksBy(object sender, EventArgs e)
        {
            if((searchCollection.SelectedIndex >= 0) && (searchCategoriesBox.SelectedIndex >=0))
            {
                linksList.Items.Clear();
                sortedLinks.Clear();

                foreach(Link link in notSortedLinks)
                {
                    if((link.LinkCollectionFk == searchCollection.SelectedIndex + 1) && (link.LinkCategorieFk == searchCategoriesBox.SelectedIndex + 1))
                    {
                        sortedLinks.Add(link);
                        linksList.Items.Add(link);
                    }
                    
                }
            }
        }

        private void OpenLinkInBrowser(object sender, EventArgs e)
        {
            int index = linksList.SelectedIndex;
            int indexCollection = searchCollection.SelectedIndex;
            int indexCategorie = searchCategoriesBox.SelectedIndex;
            Link link; 

            if (index >= 0 && indexCollection >=0 && indexCategorie >= 0)
            {
                link = sortedLinks[index];
                System.Diagnostics.Process.Start(link.LinkUrl);
            }
            else
            {
                link = notSortedLinks[index];
                System.Diagnostics.Process.Start(link.LinkUrl);
            }
        }

        private void ResetSortedLinks(object sender, EventArgs e)
        {
            linksList.Items.Clear();
            searchCollection.SelectedIndex = - 1;
            searchCategoriesBox.SelectedIndex = -1;
            searchCollection.Text = "Select Collection";
            searchCategoriesBox.Text = "Select Categorie";


            foreach (Link link in notSortedLinks)
            {
                linksList.Items.Add(link);
            }
        }

        readonly List<Link> videoLinks = new List<Link>();
        private void VideoCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            videoSelectComboBox.Items.Clear();
            videoLinks.Clear();

            foreach(Link link in notSortedLinks)
            {
                if(link.LinkCollectionFk == videoCollection.SelectedIndex + 1 && link.LinkCategorieFk == 2)
                {
                    videoSelectComboBox.Items.Add(link);

                    if(videoLinks != null)
                    {
                        videoLinks.Add(link);
                    }
                } 
            }
        }

        private void PlayVideo(object sender, EventArgs e)
        {
            if(videoCollection.SelectedIndex >= 0 && videoSelectComboBox.SelectedIndex >= 0)
            {
                int index = videoSelectComboBox.SelectedIndex;
                var url = videoLinks[index].LinkUrl;
                var embed = "<html><head>" +
                            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                            "</head><body>" +
                            "<iframe width = \"510\" height = \"305\" " +
                            "src=" + url +
                            " frameborder = \"0\" " +
                            "allow= \"accelerometer; " +
                            "autoplay; encrypted-media; " +
                            "gyroscope; " +
                            "picture-in-picture\" allowfullscreen></ iframe>" +
                            "</body></html>";


                this.videoBrowser.DocumentText = string.Format(embed);
            }
            
        }

        private void ResetAddLink_Click(object sender, EventArgs e)
        {
            linkUrlBox.Text = "URL";
            linkCollectionBox.SelectedIndex = -1;
            linkCollectionBox.Text = "Select Collection";
            linkCategoriesBox.SelectedIndex = -1;
            linkCategoriesBox.Text = "Select Categorie";
            linkNameBox.Text = "";
            linkDescriptionBox.Text = "";
            linkStatusBox.Visible = false;
            linkErrorPicture.Visible = false;
            linkDonePicture.Visible = false;
        }

        private void AddOthersReset_Click(object sender, EventArgs e)
        {
            addNameTextBox.Text = "Name"; 
        }

        private void DeleteOthersReset_Click(object sender, EventArgs e)
        {
            deleteNameBox.Text = "Select Name";
        }

        private void LinkUrlBox_Enter(object sender, EventArgs e)
        {
            linkUrlBox.Text = "";
        }

        private void LinkUrlBox_Leave(object sender, EventArgs e)
        {
            if(linkUrlBox.Text == "")
            {
                linkUrlBox.Text = "URL";
            }
        }

        private void AddNameTextBox_Enter(object sender, EventArgs e)
        {
            addNameTextBox.Text = "";
        }

        private void AddNameTextBox_Leave(object sender, EventArgs e)
        {
            if(addNameTextBox.Text == "")
            {
                addNameTextBox.Text = "Name";
            }
        }

        private void LinkCollectionBox_Leave(object sender, EventArgs e)
        {
            if(linkCollectionBox.Text == "")
            {
                linkCollectionBox.Text = "Select Collection";
            }
        }

        private void LinkCategorieBox_Leave(object sender, EventArgs e)
        {
            if (linkCategoriesBox.Text == "")
            {
                linkCategoriesBox.Text = "Select Categorie";
            }
        }

        private void DeleteNameBox_Leave(object sender, EventArgs e)
        {
            if (deleteNameBox.Text == "")
            {
                deleteNameBox.Text = "Select Name";
            }
        }

        private void SearchCollection_Leave(object sender, EventArgs e)
        {
            if (searchCollection.Text == "")
            {
                searchCollection.Text = "Select Collection";
            }
        }

        private void SearchCategorieBox_Leave(object sender, EventArgs e)
        {
            if (searchCategoriesBox.Text == "")
            {
                searchCategoriesBox.Text = "Select Categorie";
            }
        }

        private void VideoCollection_Leave(object sender, EventArgs e)
        {
            if (videoCollection.Text == "")
            {
                videoCollection.Text = "Select Collection";
            }
        }

        private void VideoSelectComboBox_Leave(object sender, EventArgs e)
        {
            if (videoSelectComboBox.Text == "")
            {
                videoSelectComboBox.Text = "Select Video";
            }
        }

        private void DeleteLink_Click(object sender, EventArgs e)
        {
            Link link = notSortedLinks[linksList.SelectedIndex];
            string conditionLink = "linkId = '" + link.LinkId + "'";
            DBconnection.ExecuteDelete("link", conditionLink);
            Link.GetLinksFromDatabase(linksList);
            Link.LinksCount(videosCount, linksCount);

        }
    }
}
