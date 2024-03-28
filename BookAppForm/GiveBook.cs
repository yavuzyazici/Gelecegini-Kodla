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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BookAppForm
{
    public partial class GiveBook : Form
    {
        public GiveBook()
        {
            InitializeComponent();
        }

        public string GiveBookSearchBox;
        private void GiveBook_Load(object sender, EventArgs e)
        {
            txtSearch.Text = GiveBookSearchBox;

            string output = FileOperation.ReadFile();
            var books = JsonConvert.DeserializeObject<List<BookItem>>(output);

            dG.DataSource = books.Where(x => x.Title.ToLower().Contains(txtSearch.Text.ToLower()) ||
                                                                                        x.Author.ToLower().Contains(txtSearch.Text.ToLower()) ||
                                                                                        x.ISBN.Contains(txtSearch.Text)).ToList();
        }

        private void btnEmanet_Click(object sender, EventArgs e)
        {
            EmanetEt();
            string output = FileOperation.ReadFile();
            var books = JsonConvert.DeserializeObject<List<BookItem>>(output);

            dG.DataSource = books.Where(x => x.Title.ToLower().Contains(txtSearch.Text.ToLower()) ||
                                                                                        x.Author.ToLower().Contains(txtSearch.Text.ToLower()) ||
                                                                                        x.ISBN.Contains(txtSearch.Text)).ToList();
        }

        public void EmanetEt()
        {
            if (Check())
            {
                string output = FileOperation.ReadFile();
                var books = JsonConvert.DeserializeObject<List<BookItem>>(output);

                var item = books.Where(x => x.Id.ToString() == dG.CurrentRow.Index.ToString()).FirstOrDefault();

                item.Location = txtEmanetTo.Text;

                var jsonString = JsonConvert.SerializeObject(books);
                FileOperation.SaveFile(jsonString);
                MessageBox.Show($"{item.Title} kitabı {item.Location} kişisine emanet edildi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Emanet edilecek kişiyi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public bool Check()
        {
            if (string.IsNullOrEmpty(txtEmanetTo.Text))
            {
                return false;
            }
            return true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string output = FileOperation.ReadFile();
            dG.DataSource = JsonConvert.DeserializeObject<List<BookItem>>(output).Where(x => x.Title.ToLower().Contains(txtSearch.Text.ToLower()) ||
                                                                                        x.Author.ToLower().Contains(txtSearch.Text.ToLower()) ||
                                                                                        x.ISBN.Contains(txtSearch.Text)).ToList();
        }
    }
}
