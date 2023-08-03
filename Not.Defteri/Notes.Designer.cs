namespace Not.Defteri
{
    partial class Notes
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            txtNote = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dataStoreBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataStoreBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 0;
            label1.Text = "My Notes";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("MV Boli", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(278, 354);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(312, 41);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 0;
            label2.Text = "Note:";
            // 
            // txtNote
            // 
            txtNote.Font = new Font("MV Boli", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNote.Location = new Point(373, 43);
            txtNote.Name = "txtNote";
            txtNote.PlaceholderText = "Type Here";
            txtNote.Size = new Size(234, 28);
            txtNote.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(373, 93);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(235, 69);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(373, 187);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(235, 69);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(374, 282);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(235, 69);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataStoreBindingSource
            // 
            dataStoreBindingSource.DataSource = typeof(DataStore);
            // 
            // Notes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtNote);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Notes";
            Text = "Notes";
            Load += Notes_Load;
            ((System.ComponentModel.ISupportInitialize)dataStoreBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private TextBox txtNote;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private BindingSource dataStoreBindingSource;
    }
}