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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
        }

        private BookItem ReadLines()
        {
            var item = new BookItem();
            string output = FileOperation.ReadFile();
            var books = JsonConvert.DeserializeObject<List<BookItem>>(output);
            item.Id = books.Last().Id + 1;
            item.Title = txtBoxTitle.Text;
            item.Author = txtBoxAuthor.Text;
            item.Description = txtBoxDesc.Text;
            item.ISBN = txtBoxISBN.Text;
            item.Location = txtBoxLocation.Text;
            item.Status = checkBox.Checked;
            return item;
        }

        bool CheckInput(string title, string author, string page, string description, string isbn)
        {
            title = txtBoxTitle.Text;
            author = txtBoxAuthor.Text;
            description = txtBoxDesc.Text;
            isbn = txtBoxISBN.Text;
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

        public void Add(BookItem item)
        {
            string output = FileOperation.ReadFile();
            var books = JsonConvert.DeserializeObject<List<BookItem>>(output);

            // Checking if there is a book with the same ISBN number in the list
            if (books.Any(x => x.ISBN == item.ISBN))
            {
                MessageBox.Show("Aynı kitap zaten var. ISBN numarasını kontrol edin", "Kitap Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // We included it in the list
            books.Add(item);

            var jsonString = JsonConvert.SerializeObject(books);
            File.WriteAllText("books.json", jsonString, Encoding.UTF8);

            MessageBox.Show("Kitap başarıyla eklendi!", "Kitap Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<BookItem> GetBooks()
        {
            string output = FileOperation.ReadFile();
            var books = JsonConvert.DeserializeObject<List<BookItem>>(output);
            return books;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var item = ReadLines();
            if (CheckInput(item.Title, item.Author, item.PageCount.ToString(), item.Description, item.ISBN))
            {
                Add(item);
            }
            else
            {
                MessageBox.Show("Kitap bilgileri geçersiz.", "Kitap Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddBook_Load_1(object sender, EventArgs e)
        {

        }
    }
}
