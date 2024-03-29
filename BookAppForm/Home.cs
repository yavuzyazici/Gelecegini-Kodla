﻿using Book;
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
            if (dG.CurrentRow != null)
            {
                UpdateBook updateBook = new UpdateBook();
                string output = FileOperation.ReadFile();

                var bookList = JsonConvert.DeserializeObject<List<BookItem>>(output);

                var selectedBook = bookList.Where(x => x.Id.ToString() == dG.CurrentRow.Index.ToString()).FirstOrDefault();

                updateBook.a = selectedBook.Title;
                updateBook.b = selectedBook.Author;
                updateBook.c = selectedBook.SayfaSayisi.ToString();
                updateBook.d = selectedBook.Tur;
                updateBook.e = selectedBook.Durum;
                updateBook.f = selectedBook.OkunmaTarihi;
                updateBook.g = selectedBook.ISBN;
                updateBook.Show();
            }
            else
            {
                MessageBox.Show("Hiçbir satır seçili değil.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            AddBook addBook = new AddBook();
            home.Hide();
            addBook.Show();
        }

        private void btnGive_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            GiveBook giveBook = new GiveBook();

            string output = FileOperation.ReadFile();

            var bookList = JsonConvert.DeserializeObject<List<BookItem>>(output);

            var selectedBook = bookList.Where(x => x.Id.ToString() == dG.CurrentRow.Index.ToString()).FirstOrDefault();

            giveBook.GiveBookSearchBox = selectedBook.Title;

            home.Hide();
            giveBook.Show();


        }
    }
}
