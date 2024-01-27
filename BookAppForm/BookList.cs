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
    public partial class BookList : Form
    {
        public BookList()
        {
            InitializeComponent();
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            string output = FileOperation.ReadFile();
            dG.DataSource = JsonConvert.DeserializeObject<List<BookItem>>(output);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = FileOperation.ReadFile();
            dG.DataSource = JsonConvert.DeserializeObject<List<BookItem>>(output);
        }
    }
}
