﻿using System;
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
    public partial class ViewAllQuotes : Form
    {
        List<DeskQuote> data;
        public ViewAllQuotes()
        {
            InitializeComponent();
            
            JsonPersistence jp = new JsonPersistence();
            data = jp.LoadQuotes();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data;
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu MainMenuForm = (MainMenu)this.Tag;
            MainMenuForm.Show();
            this.Hide();

        }
    }
}
