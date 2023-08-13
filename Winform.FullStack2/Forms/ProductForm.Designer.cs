namespace Winform.FullStack2.Forms
{
    partial class ProductForm
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
            lblUser = new Label();
            label2 = new Label();
            lblTest = new Label();
            btnRemove = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtProductName = new RichTextBox();
            listNote = new ListBox();
            txtStock = new TextBox();
            btnClear = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(630, 545);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(70, 22);
            lblUser.TabIndex = 13;
            lblUser.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 545);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(230, 22);
            label2.TabIndex = 12;
            label2.Text = "Giriş yapan kullanıcı:";
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Location = new Point(119, 618);
            lblTest.Margin = new Padding(4, 0, 4, 0);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(80, 22);
            lblTest.TabIndex = 11;
            lblTest.Text = "lblTest";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(425, 403);
            btnRemove.Margin = new Padding(4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(299, 53);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Sil";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(425, 342);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(299, 53);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(425, 280);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(299, 53);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(383, 44);
            txtProductName.Margin = new Padding(4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(375, 139);
            txtProductName.TabIndex = 7;
            txtProductName.Text = "";
            // 
            // listNote
            // 
            listNote.FormattingEnabled = true;
            listNote.ItemHeight = 22;
            listNote.Location = new Point(28, 44);
            listNote.Margin = new Padding(4);
            listNote.Name = "listNote";
            listNote.Size = new Size(333, 532);
            listNote.TabIndex = 6;
            listNote.SelectedIndexChanged += listNote_SelectedIndexChanged;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(383, 217);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(375, 30);
            txtStock.TabIndex = 14;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(425, 464);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(299, 53);
            btnClear.TabIndex = 8;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(530, 588);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 43);
            btnBack.TabIndex = 15;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 660);
            Controls.Add(btnBack);
            Controls.Add(txtStock);
            Controls.Add(lblUser);
            Controls.Add(label2);
            Controls.Add(lblTest);
            Controls.Add(btnClear);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtProductName);
            Controls.Add(listNote);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ProductForm";
            Text = "ProductForm";
            FormClosed += ProductForm_FormClosed;
            Load += ProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label label2;
        private Label lblTest;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnAdd;
        private RichTextBox txtProductName;
        private ListBox listNote;
        private TextBox txtStock;
        private Button btnClear;
        private Button btnBack;
    }
}