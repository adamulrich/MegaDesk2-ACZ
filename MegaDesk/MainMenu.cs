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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_addQuote_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            AddQuote AddQuoteForm = new AddQuote();
            AddQuoteForm.Tag = this;
            AddQuoteForm.Show();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_searchQuotes_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            SearchQuotes searchQuotesForm = new SearchQuotes();
            searchQuotesForm.Tag = this;
            searchQuotesForm.Show();
        }

        private void btn_viewQuote_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            ViewAllQuotes ViewAllQuotesForm = new ViewAllQuotes();
            ViewAllQuotesForm.Tag = this;
            ViewAllQuotesForm.Show();
        }
    }
}
