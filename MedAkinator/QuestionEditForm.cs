using System;
using System.Windows.Forms;

namespace MedAkinator
{
    public partial class QuestionEditForm : Form
    {
        public bool ShownOnlyForDoctors;
        public bool HiddenFromUi;
        public string Question;

        public QuestionEditForm(string question="", bool hiddenFromUi = false, bool shownOnlyForDoctors = false)
        {
            InitializeComponent();
            
            txtBoxQuestion.Text = question;
            cBoxHiddenFromUI.Checked = hiddenFromUi;
            cBoxShownOnlyForDoctors.Checked = shownOnlyForDoctors;
        }

        private void QuestionEditForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Question = txtBoxQuestion.Text;
            HiddenFromUi = cBoxHiddenFromUI.Checked;
            ShownOnlyForDoctors = cBoxShownOnlyForDoctors.Checked;

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
