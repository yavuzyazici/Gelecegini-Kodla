namespace BookAppForm
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            AddBook addBook = new AddBook();
            home.Hide();
            addBook.Show();
        }
        private void btnBookList_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            AddBook addBook = new AddBook();
            home.Hide();
            addBook.Show();
        }

        private void btnBookList_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            BookList booklist = new BookList();
            home.Hide();
            booklist.Show();
        }
    }
}
