namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BooksGridView = new DataGridView();
            btnBorrow = new Button();
            btnReturn = new Button();
            btnAdd = new Button();
            cboUser = new ComboBox();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)BooksGridView).BeginInit();
            SuspendLayout();
            // 
            // BooksGridView
            // 
            BooksGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BooksGridView.BackgroundColor = SystemColors.ControlLightLight;
            BooksGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BooksGridView.Location = new Point(12, 23);
            BooksGridView.Name = "BooksGridView";
            BooksGridView.RowHeadersWidth = 51;
            BooksGridView.Size = new Size(416, 398);
            BooksGridView.TabIndex = 0;
            BooksGridView.CellContentClick += dataGridViewBooks_CellContentClick;
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = SystemColors.ButtonHighlight;
            btnBorrow.Location = new Point(640, 23);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(148, 53);
            btnBorrow.TabIndex = 1;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = SystemColors.ButtonHighlight;
            btnReturn.Location = new Point(640, 133);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(148, 53);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(640, 245);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(148, 53);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cboUser
            // 
            cboUser.FormattingEnabled = true;
            cboUser.Location = new Point(462, 23);
            cboUser.Name = "cboUser";
            cboUser.Size = new Size(151, 28);
            cboUser.TabIndex = 4;
            cboUser.SelectedIndexChanged += cboUser_SelectedIndexChanged;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = SystemColors.ButtonHighlight;
            btnRemove.Location = new Point(640, 350);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(148, 53);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemove);
            Controls.Add(cboUser);
            Controls.Add(btnAdd);
            Controls.Add(btnReturn);
            Controls.Add(btnBorrow);
            Controls.Add(BooksGridView);
            Name = "Form1";
            Text = "Library Management System ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)BooksGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView BooksGridView;
        private Button btnBorrow;
        private Button btnReturn;
        private Button btnAdd;
        private ComboBox cboUser;
        private Button btnRemove;
    }
}
