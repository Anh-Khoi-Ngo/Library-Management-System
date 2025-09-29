using Library;
using System.ComponentModel;

namespace Project
{
    public partial class Form1 : Form
    {
        private BindingList<Book> booksList = new BindingList<Book>();
        private int borrowedBooksCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboUser.Items.Add("Student");
            cboUser.Items.Add("Teacher");
            cboUser.Items.Add("Librarian");
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
            BooksGridView.AllowUserToAddRows = false;
            SetupDataGridView();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                if (BooksGridView.SelectedRows.Count > 0)
                {
                    int selectedIndex = BooksGridView.SelectedRows[0].Index;
                    if (selectedIndex >= 0 && selectedIndex < booksList.Count)
                    {
                        var selectedBook = booksList[selectedIndex];
                        if (!selectedBook.IsAvailable)
                        {
                            MessageBox.Show("This book is already borrowed.");
                            return;
                        }
                        var selectedUser = cboUser.SelectedItem as string;
                        int borrowingLimit = selectedUser switch
                        {
                            "Student" => 5,
                            "Teacher" => 10,
                            "Librarian" => int.MaxValue, 
                            _ => 0
                        };
                        if (borrowedBooksCount >= borrowingLimit)
                        {
                            MessageBox.Show($"You have reached your borrowing limit ({borrowingLimit} books).");
                            return;
                        }
                        selectedBook.IsAvailable = false;
                        borrowedBooksCount++;
                        RefreshDataGrid();
                        MessageBox.Show($"You have successfully borrowed '{selectedBook.Title}'");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a book to borrow.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while borrowing the book: {ex.Message}");
            }

        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BooksGridView.SelectedRows.Count > 0)
                {
                    int selectedIndex = BooksGridView.SelectedRows[0].Index;
                    if (selectedIndex >= 0 && selectedIndex < booksList.Count)
                    {
                        var selectedBook = booksList[selectedIndex];
                        if (selectedBook.IsAvailable)
                        {
                            MessageBox.Show("This book is already available.");
                            return;
                        }
                        selectedBook.IsAvailable = true;
                        RefreshDataGrid();
                        MessageBox.Show($"You have successfully returned '{selectedBook.Title}'.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a book to return.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while returning the book: {ex.Message}");
            }

        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            DialogResult result = addBook.ShowDialog();
            if (result == DialogResult.OK)
            {
                var newBook = new Book
                {
                    Title = addBook.Title,
                    Author = addBook.Author,
                    IsAvailable = addBook.IsAvailable
                };
                booksList.Add(newBook);
                RefreshDataGrid();
            }
        }
        private void cboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedUser = cboUser.SelectedItem as string;
            btnAdd.Enabled = selectedUser == "Librarian";
            btnRemove.Enabled = selectedUser == "Librarian";
        }
        private void RefreshDataGrid()
        {
            BooksGridView.DataSource = null;
            BooksGridView.DataSource = booksList;
        }
        private void SetupDataGridView()
        {
            BooksGridView.AutoGenerateColumns = false;

            BooksGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Title",
                DataPropertyName = "Title"
            });

            BooksGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Author",
                DataPropertyName = "Author"
            });

            BooksGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "IsAvailable",
                DataPropertyName = "IsAvailable"
            });

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (BooksGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = BooksGridView.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < booksList.Count)
                {
                    booksList.RemoveAt(selectedIndex);
                    RefreshDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to remove.");
            }

        }
    }
}
