using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Not.Defteri.DataStore;


namespace Not.Defteri
{
    public partial class Notes : Form
    {
        public Note selectedNote = null;

        public void Refresh()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = DataStore.Notes;
            listBox1.DisplayMember = "Description";
            listBox1.ValueMember = "Id";
        }

        public Notes()
        {
            InitializeComponent();
            Refresh();

        }


        private void Notes_Load(object sender, EventArgs e)
        {
            Refresh();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                selectedNote = (Note)listBox1.SelectedItem;
                //  txtNote.Text = selectedNote.Description;
                // txtNote.Text = "Type Here";
            }



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addedNote = new Note();
            addedNote.Description = txtNote.Text;
            addedNote.Id = DataStore.Notes.Count + 1;
            DataStore.Notes.Add(addedNote);
            Refresh();
            txtNote.Text = "";

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNote.Text))
            {
                selectedNote.Description = txtNote.Text;
                Refresh();
            }
            else { MessageBox.Show("Please fill the field"); }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataStore.Notes.Remove(selectedNote);
            selectedNote = null;
            txtNote.Text = string.Empty;
            MessageBox.Show("Note is deleted");
            Refresh();

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
