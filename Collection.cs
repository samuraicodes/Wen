using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Wen
{
    class Collection
    {
        public long CollectionId { private set; get; }
        public string CollectionName { private set; get; }

        static readonly private List<Collection> collections = new List<Collection>();

        private Collection(long collectionId, string collectionName)
        {
            this.CollectionId = collectionId;
            this.CollectionName = collectionName;
        }

        static public void GetCollectionsFromDatabase(ComboBox addLinksCb, ComboBox searchCb, ComboBox videosCb, ComboBox delete)
        {
            MySqlDataReader reader = DBconnection.ExecuteReader("SELECT * FROM collection ORDER BY collectionId ASC;");
            collections.Clear();

            while (reader.Read())
            {
                Collection collection = new Collection(reader.GetInt64(0), reader.GetString(1));
                collections.Add(collection);
            }

            reader.Close();

            AddCollectionToBoxes(addLinksCb, searchCb, videosCb,delete);
        }

        static public void CreateCollection(string name, ComboBox addLinksCb, ComboBox searchCb, ComboBox videosCb, ComboBox delete)
        {

            Collection collection = new Collection(InsertCollectionInDb(name), name);

            collections.Add(collection);
            AddCollectionToBoxes(addLinksCb, searchCb, videosCb, delete);

        }

        static public List<Collection> GetCollections()
        {
            return collections;
        }

        public override string ToString()
        {
            return CollectionName; 
        }
        static public void CollectionCount(TextBox collectionText)
        {
            collectionText.Text = "Collections: " + collections.Count;
        }

        static private long InsertCollectionInDb(string name)
        {
            string sql = "INSERT IGNORE INTO "
                         + "collection(collectionName)"
                         + "VALUES(@one)";

            long id = DBconnection.ExecuteInsertReturnId(sql, name);

            return id;
        }

        static private void AddCollectionToBoxes(ComboBox addLinksCb, ComboBox searchCb, ComboBox videosCb,ComboBox delete)
        {
            addLinksCb.Items.Clear();
            searchCb.Items.Clear();
            videosCb.Items.Clear();
            delete.Items.Clear();

            foreach (Collection collection in collections)
            {
                addLinksCb.Items.Add(collection);
                searchCb.Items.Add(collection);
                videosCb.Items.Add(collection);
                delete.Items.Add(collection);
            }
        }
    }
}
