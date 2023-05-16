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
            cbo_MaterialType.DataSource = Enum.GetValues(typeof(material)).Cast<material>().ToList();
            cbo_MaterialType.SelectedIndex = ((int)material.Pine); // set default value to pine
            cbo_DeliverySpeed.DataSource = Enum.GetValues(typeof(productionTime)).Cast<productionTime>().ToList();
            cbo_DeliverySpeed.SelectedIndex = Array.IndexOf(Enum.GetValues(productionTime.normal.GetType()), productionTime.normal);
        }

         private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu MainMenuForm = (MainMenu)this.Tag;
            MainMenuForm.Show();
            this.Hide();
            this.Close();
        }

        public bool updateQuote()
        {
            try
            {
                desk.depth = (int)this.num_Depth.Value;
                desk.width = (int)this.num_Width.Value;
                desk.drawer_count = (int)this.num_DrawerCount.Value;
                desk.material = (material)this.cbo_MaterialType.SelectedItem;
                deskQuote.desk = this.desk;
                deskQuote.customerName = (string)this.text_CustomerName.Text;
                deskQuote.date = DateTime.Now;
                deskQuote.productionTime = (productionTime)this.cbo_DeliverySpeed.SelectedItem;
                deskQuote.calculatePrice();
                this.lbl_Price.Text = deskQuote.price.ToString();
                
                if(deskQuote.customerName.Length < 1)
                {
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                // unable to calculate price
                this.lbl_Price.Text = "Unable to Calculate";
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(updateQuote())
            {
                JsonPersistence jp = new JsonPersistence();
                jp.AddQuoteToFile(deskQuote);

                MainMenu MainMenuForm = (MainMenu)this.Tag;
                MainMenuForm.Show();
                this.Hide();
            }
        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu MainMenuForm = (MainMenu)this.Tag;
            MainMenuForm.Show();
            this.Hide();
        }

        private void text_CustomerName_Enter(object sender, EventArgs e)
        {
            setFocusTextBox(sender, e);
        }

        private void num_DrawerCount_Enter(object sender, EventArgs e)
        {
            setFocusNumericUpDown(sender, e);
        }

        private void num_Width_Enter(object sender, EventArgs e)
        {
            setFocusNumericUpDown(sender, e);
        }

        private void num_Depth_Enter(object sender, EventArgs e)
        {
            setFocusNumericUpDown(sender, e);
        }
        private void setFocusNumericUpDown(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
        private void setFocusTextBox(object sender, EventArgs e)
        {
            TextBox TextField = sender as TextBox;

            if (TextField != null)
            {
                int lengthOfAnswer = TextField.Text.Length;
                TextField.Select(0, lengthOfAnswer);
            }
        }
    }
}
