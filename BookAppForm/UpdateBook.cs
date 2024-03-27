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

        public string a, b, c, d, f;
        public bool e;
        private void UpdateBook_Load(object sender, EventArgs eventArgs)
        {
            txtBoxTitle.Text = a;
            txtBoxAuthor.Text = b;
            txtBoxISBN.Text = c;
            txtBoxLocation.Text = d;
            checkBox.Checked = e;
            txtBoxDesc.Text = f;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var item = ReadLines();
            if (CheckInput(item.Title, item.Author, item.Description, item.Author))
            {
                Update(item);
                MessageBox.Show("Kitap başarıyla güncellendi!", "Kitap Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kitap bilgileri geçersiz.", "Kitap Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string output = FileOperation.ReadFile();
            Home.dG.DataSource = JsonConvert.DeserializeObject<List<BookItem>>(output);
        }
        public void Update(BookItem element)
        {
            string output = FileOperation.ReadFile();
            var books = JsonConvert.DeserializeObject<List<BookItem>>(output);

            var item = books.Where(x => x.ISBN == element.ISBN).First();

            item.Title = txtBoxTitle.Text;
            item.Author = txtBoxAuthor.Text;
            item.ISBN = txtBoxISBN.Text;
            item.Location = txtBoxLocation.Text;
            item.Status = checkBox.Checked;
            item.Description = txtBoxDesc.Text;

            var jsonString = JsonConvert.SerializeObject(books);
            FileOperation.SaveFile(jsonString);
        }
        private BookItem ReadLines()
        {
            var json = FileOperation.ReadFile();

            var books = JsonConvert.DeserializeObject<List<BookItem>>(json);

            return books.Where(x => x.ISBN == txtBoxISBN.Text).FirstOrDefault();
        }
        bool CheckInput(string title, string author, string description, string isbn)
        {
            title = txtBoxTitle.Text;
            author = txtBoxAuthor.Text;
            description = txtBoxDesc.Text;
            isbn = txtBoxISBN.Text;
            if (string.IsNullOrEmpty(title) ||
                string.IsNullOrEmpty(author) ||
                string.IsNullOrEmpty(isbn) ||
                author.Length < 5 ||
                author.Length > 20 ||
                title.Length > 50 ||
                isbn.Length > 50)
            {
                return false;
            }
            return true;
        }
    }
}
