using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{

    public partial class SearchQuotes : Form
    {
        
        public SearchQuotes()
        {
            InitializeComponent();

        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            
            this.cbo_MaterialType.DataSource = Enum.GetValues(typeof(filterByMaterial));
            this.cbo_MaterialType.SelectedIndex = ((int)filterByMaterial.None); // set default value to None

        }

        private void SearchQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu MainMenuForm = (MainMenu)this.Tag; 
            this.Hide();
            MainMenuForm.Show();
        }

        private void cbo_MaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get selected index
            filterByMaterial selectedMaterial = (filterByMaterial)this.cbo_MaterialType.SelectedItem;

            // load data
            JsonPersistence jp = new JsonPersistence();
            List<DeskQuote> quotes = jp.LoadQuotes(filterMaterial: selectedMaterial);

            // translate Quote Object to flatter object
            List<FlatQuote> flatQuotes = new List<FlatQuote> { };

            foreach (DeskQuote quote in quotes)
            {
                FlatQuote q = new FlatQuote();
                q.price = quote.price;
                q.customerName = quote.customerName;
                q.material = quote.desk.material;
                q.date = quote.date;
                q.drawer_count = quote.desk.drawer_count;
                q.width = quote.desk.width;
                q.depth = quote.desk.depth;
                q.productionTime = quote.productionTime;

                flatQuotes.Add(q);
            }

            // show
            datagrid_quotes.DataSource = flatQuotes.ToList();
            datagrid_quotes.AutoResizeColumns();
            

        }
    }
}
