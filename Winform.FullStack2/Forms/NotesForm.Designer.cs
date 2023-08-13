namespace Winform.FullStack2.Forms
{
    partial class NotesForm
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
            btnClear = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtDescription = new RichTextBox();
            listNote = new ListBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(615, 482);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(70, 22);
            lblUser.TabIndex = 23;
            lblUser.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 482);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(230, 22);
            label2.TabIndex = 22;
            label2.Text = "Giriş yapan kullanıcı:";
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Location = new Point(638, 589);
            lblTest.Margin = new Padding(4, 0, 4, 0);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(80, 22);
            lblTest.TabIndex = 21;
            lblTest.Text = "lblTest";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(415, 363);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(299, 53);
            btnClear.TabIndex = 17;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(415, 302);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(299, 53);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(415, 240);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(299, 53);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(373, 4);
            txtDescription.Margin = new Padding(4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(375, 139);
            txtDescription.TabIndex = 16;
            txtDescription.Text = "";
            // 
            // listNote
            // 
            listNote.FormattingEnabled = true;
            listNote.ItemHeight = 22;
            listNote.Location = new Point(13, 24);
            listNote.Margin = new Padding(4);
            listNote.Name = "listNote";
            listNote.Size = new Size(333, 554);
            listNote.TabIndex = 15;
            listNote.SelectedIndexChanged += listNote_SelectedIndexChanged_1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(488, 526);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(147, 34);
            btnBack.TabIndex = 25;
            btnBack.Text = "Geri";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // NotesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 585);
            Controls.Add(btnBack);
            Controls.Add(lblUser);
            Controls.Add(label2);
            Controls.Add(lblTest);
            Controls.Add(btnClear);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(listNote);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "NotesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NotesForm";
            FormClosed += NotesForm_FormClosed;
            Load += NotesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUser;
        private Label label2;
        private Label lblTest;
        private Button btnClear;
        private Button btnEdit;
        private Button btnAdd;
        private RichTextBox txtDescription;
        private ListBox listNote;
        private Button btnBack;
        private EventHandler listNote_SelectedIndexChanged;
    }
}