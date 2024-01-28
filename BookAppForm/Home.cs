using Book;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookAppForm
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string output = FileOperation.ReadFile();
            dG.DataSource = JsonConvert.DeserializeObject<List<BookItem>>(output);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string output = FileOperation.ReadFile();
            dG.DataSource = JsonConvert.DeserializeObject<List<BookItem>>(output);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string output = FileOperation.ReadFile();
            dG.DataSource = JsonConvert.DeserializeObject<List<BookItem>>(output).Where(x => x.Title.ToLower().Contains(txtSearch.Text.ToLower()) ||
                                                                                        x.Author.ToLower().Contains(txtSearch.Text.ToLower()) ||
                                                                                        x.ISBN.Contains(txtSearch.Text)).ToList();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            UpdateBook updateBook = new UpdateBook();
            updateBook.a = dG.CurrentRow.Cells[0].Value.ToString();
            updateBook.b = dG.CurrentRow.Cells[1].Value.ToString();
            updateBook.c = dG.CurrentRow.Cells[2].Value.ToString();
            updateBook.d = dG.CurrentRow.Cells[3].Value.ToString();
            home.Hide();
            updateBook.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            AddBook addBook = new AddBook();
            home.Hide();
            addBook.Show();
        }
    }
}
