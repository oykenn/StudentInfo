namespace studentInfoAplication
{
    public partial class FrmStudentInfo : Form
    {
        public FrmStudentInfo()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string studentID = textBoxStudID.Text;

            if (!string.IsNullOrEmpty(studentID))
            {
                listBoxStudID.Items.Add(studentID);

                textBoxStudID.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a student name.", "Input Required");
            }

            string studentFName = textBoxFName.Text;
            if (!string.IsNullOrEmpty(studentFName))
            {
                listBoxFirstNames.Items.Add(studentFName);

                textBoxFName.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a student name.", "Input Required");
            }

            string studentLName = textBoxLName.Text;

            if (!string.IsNullOrEmpty(studentLName))
            {
                listBoxLName.Items.Add(studentLName); 

                textBoxLName.Clear(); 
            }
            else
            {
                MessageBox.Show("Please enter a student last name.", "Input Required"); 
            }
        }
    }
}
