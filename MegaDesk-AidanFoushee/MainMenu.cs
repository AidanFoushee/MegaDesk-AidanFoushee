using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_AidanFoushee
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addQuoteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddQuote addQuote = new AddQuote();
            addQuote.Show();
        }

        private void viewQuotesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllQuotes viewQutoes = new ViewAllQuotes();
            viewQutoes.Show();
        }

        private void searchQuotesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
