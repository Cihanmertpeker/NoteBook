namespace Not.Defteri
{
    public partial class Notebook : Form
    {
        public Notebook()
        {
            InitializeComponent();
        }


        private void Notebook_Load(object sender, EventArgs e)
        {
            var notes = DataStore.Notes;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtUsername.Text))
            {
                if (DataStore.appUser.UserName == txtUsername.Text && DataStore.appUser.Password == txtPassword.Text)
                {
                    Notes notes = new Notes();
                    notes.Show();
                    this.Hide();
                }
                else { MessageBox.Show("Wrong username or password"); }

            }/*if1*/
            else MessageBox.Show("Please fill username and password areas");
        }//btnlogin
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}