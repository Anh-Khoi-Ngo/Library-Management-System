namespace Project
{
    partial class AddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            chIsAvailable = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 73);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(153, 140);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 1;
            label2.Text = "Author:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(263, 73);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(236, 27);
            txtTitle.TabIndex = 2;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(263, 141);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(236, 27);
            txtAuthor.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(201, 222);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 62);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(422, 222);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 62);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // chIsAvailable
            // 
            chIsAvailable.AutoSize = true;
            chIsAvailable.Location = new Point(610, 107);
            chIsAvailable.Name = "chIsAvailable";
            chIsAvailable.Size = new Size(103, 24);
            chIsAvailable.TabIndex = 6;
            chIsAvailable.Text = "IsAvailable";
            chIsAvailable.UseVisualStyleBackColor = true;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 308);
            Controls.Add(chIsAvailable);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddBook";
            Text = "AddBook";
            Load += AddBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Button btnAdd;
        private Button btnCancel;
        private CheckBox chIsAvailable;
    }
}