﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_ColeCannon
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void ViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes addViewAllQuotesForm = new ViewAllQuotes();
            addViewAllQuotesForm.Tag = this;
            addViewAllQuotesForm.Show(this);
            Hide();
        }

        private void AddNewQuote_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes searchAllQuotesForm = new SearchQuotes();
            searchAllQuotesForm.Tag = this;
            searchAllQuotesForm.Show(this);
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
