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
    public partial class UpdateBook : Form
    {
        public UpdateBook()
        {
            InitializeComponent();
        }

        public string a, b, c, d, e, f, g;
        private void UpdateBook_Load(object sender, EventArgs eventArgs)
        {
            txtBoxTitle.Text = a;
            txtBoxAuthor.Text = b;
            txtBoxISBN.Text = c;
            txtBoxLocation.Text = d;
            //checkBox.Checked = e;
            txtBoxPageCount.Text = f;
            txtBoxDesc.Text = g;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var item = ReadLines();
            Update(item);
            MessageBox.Show("Kitap başarıyla güncellendi!", "Kitap Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Update(BookItem element)
        {
            string output = FileOperation.ReadFile();
            var books = JsonConvert.DeserializeObject<List<BookItem>>(output);

            var item = books.Where(x => x.ISBN == element.ISBN).First();

            item.KitapAdi = txtBoxTitle.Text;
            item.Yazar = txtBoxAuthor.Text;
            item.PageCount = Convert.ToInt32(txtBoxPageCount.Text);
            item.Location = txtBoxLocation.Text;
            item.Status = checkBox.Checked;
            item.Description = txtBoxDesc.Text;
            item.ISBN = txtBoxISBN.Text;

            var jsonString = JsonConvert.SerializeObject(books);
            FileOperation.SaveFile(jsonString);
        }
        private BookItem ReadLines()
        {
            var json = FileOperation.ReadFile();

            var books = JsonConvert.DeserializeObject<List<BookItem>>(json);

            return books.Where(x => x.ISBN == txtBoxISBN.Text).FirstOrDefault();
        }
        bool CheckInput(string title, string author, string page, string description, string isbn)
        {
            title = txtBoxTitle.Text;
            author = txtBoxAuthor.Text;
            description = txtBoxDesc.Text;
            isbn = txtBoxISBN.Text;
            page = checkBox.Checked.ToString();
            if (string.IsNullOrEmpty(title) ||
                string.IsNullOrEmpty(author) ||
                string.IsNullOrEmpty(isbn) ||
                HasLetter(page) ||
                author.Length < 5 ||
                author.Length > 20 ||
                title.Length > 50 ||
                isbn.Length > 50)
            {
                return false;
            }
            return true;
        }
        bool HasLetter(string page)
        {
            foreach (char c in page)
            {
                if (Char.IsLetter(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
