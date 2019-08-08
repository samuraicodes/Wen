using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Wen
{
    class Categorie
    {
        public long CategorieId { private set; get; }
        public string CategorieName { private set; get; }

        static readonly List<Categorie> categories = new List<Categorie>();

        private Categorie(long categorieId, string categorieName)
        {
            this.CategorieId = categorieId;
            this.CategorieName = categorieName;
        }

        static public void GetCategoriessFromDatabase(ComboBox addLinksCb, ComboBox searchCb)
        {
            MySqlDataReader reader = DBconnection.ExecuteReader("SELECT * FROM categorie");

            while (reader.Read())
            {
                Categorie sort = new Categorie(reader.GetInt64(0), reader.GetString(1));
                categories.Add(sort);
            }

            reader.Close();

            AddSortToBoxes(addLinksCb, searchCb);
        }

        static public List<Categorie> GetCategories()
        {
            return categories;
        }

        public override string ToString()
        {
            return CategorieName;
        }

        static private void AddSortToBoxes(ComboBox addLinksCb, ComboBox searchCb)
        {
            addLinksCb.Items.Clear();
            searchCb.Items.Clear();

            foreach (Categorie sort in categories)
            {
                addLinksCb.Items.Add(sort);
                searchCb.Items.Add(sort);
            }
        }
    }
}
