using System;
using System.Windows.Forms;

namespace MedAkinator
{
    public partial class AnswerForm : Form
    {
        public string Answer;

        public AnswerForm(string answer = "")
        {
            InitializeComponent();

            txtBoxAnswer.Text = answer;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Answer = txtBoxAnswer.Text;

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AnswerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
