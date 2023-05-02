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
    public partial class AddQuote : Form
    {
        
        Desk desk = new Desk();
        DeskQuote deskQuote = new DeskQuote();
       
        public AddQuote()
        {
            InitializeComponent();
            cbo_MaterialType.DataSource = Enum.GetValues(typeof(material));
            cbo_MaterialType.SelectedIndex = ((int)material.Pine); // set default value to pine
            cbo_DeliverySpeed.DataSource = Enum.GetValues(typeof(productionTime));
            cbo_DeliverySpeed.SelectedIndex = Array.IndexOf(Enum.GetValues(productionTime.normal.GetType()), productionTime.normal);
        }

         private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu MainMenuForm = (MainMenu)this.Tag;
            MainMenuForm.Show();
            this.Hide();
            this.Close();
        }

        public void updateQuote()
        {
            try
            {
                desk.depth = (int)this.num_Depth.Value;
                desk.width = (int)this.num_Width.Value;
                desk.drawer_count = (int)this.num_DrawerCount.Value;
                desk.material = (material)this.cbo_MaterialType.SelectedItem;
                deskQuote.desk = this.desk;
                deskQuote.customerName = (string)this.text_CustomerName.Text;
                deskQuote.Date = DateTime.Now;
                deskQuote.productionTime = (productionTime)this.cbo_DeliverySpeed.SelectedItem;
                deskQuote.calculatePrice();
                this.lbl_Price.Text = deskQuote.price.ToString();
            }
            catch (Exception e)
            {
                // unable to calculate price
                this.lbl_Price.Text = "Unable to Calculate";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateQuote();
        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu MainMenuForm = (MainMenu)this.Tag;
            MainMenuForm.Show();
            this.Hide();
        }
    }
}
