using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AkinatorEngine;
using AkinatorEngine.Model;

namespace MedAkinator
{
    public partial class Form1 : Form
    {
        GameLogic _gameLogic = new GameLogic();

        public List<Question> QuestionAndEntropy = new List<Question>();
        public List<Answer> AnswerAndEntropy = new List<Answer>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateAllLists();
        }

        private void UpdateAllLists()
        {
            FillQuestions(txtBoxQuestionFilter.Text);
            FillAnswers(txtBoxAnswerFilter.Text);
        }

        private void FillQuestions(string filter = "")
        {
            Dictionary<string, float> tmp = new Dictionary<string, float>();

            foreach (var q in _gameLogic.QuestionsNotAsked)
            {
                tmp.Add(q.Text, (float)Math.Round(q.PossibilityOfThisIsNext, 5));
            }

            FillListBox(filter, tmp, lstBoxQuestions);
        }

        private void FillAnswers(string filter = "")
        {
            Dictionary<string, float> tmp = new Dictionary<string, float>();

            foreach (var ans in _gameLogic.AnswersAll)
            {
                tmp.Add(ans.Text, (float) Math.Round(ans.Possibility, 5) );
            }

            FillListBox(filter, tmp, lstBoxAnswers);
        }
        
        private void FillListBox(string filter, Dictionary<string, float> dataSource, ListBox lstBox)
        {
            lstBox.Items.Clear();

            string[] items = { };

            if (filter == "")
            {
                items = dataSource.Select(a => $"[{a.Value}] {a.Key}").ToArray();
            }
            else
            {
                items = dataSource.Where(a => a.Key.ToLower().Contains(filter.ToLower()))
                    .Select(a => $"[{a.Value}] {a.Key}").ToArray();
            }

            lstBox.Items.AddRange(items);

            if (lstBox.Items.Count > 0)
            {
                lstBox.SelectedIndex = 0;
            }
        }

        private void txtBoxQuestionFilter_TextChanged(object sender, EventArgs e)
        {
            FillQuestions(txtBoxQuestionFilter.Text);
        }

        private void txtBoxAnswerFilter_TextChanged(object sender, EventArgs e)
        {
            FillAnswers(txtBoxAnswerFilter.Text);
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            QuestionEditForm qef = new QuestionEditForm();
            qef.ShowDialog();

            if (qef.DialogResult == DialogResult.OK)
            {
                _gameLogic.Questions.Add(qef.Question, qef.HiddenFromUi, qef.ShownOnlyForDoctors);
            }

            _gameLogic.UpdateQandA();
            UpdateAllLists();
        }

        private void btnRemoveQuestion_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure you want to delete selected QUESTION?", "Sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var selectedIndex = lstBoxQuestions.SelectedIndex;

                var itemToDelete = _gameLogic.QuestionsNotAsked[selectedIndex];

                _gameLogic.Questions.Remove(itemToDelete);
                
                _gameLogic.UpdateQandA();
                UpdateAllLists();
            }
        }

        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            var selectedIndex = lstBoxQuestions.SelectedIndex;

            var itemToEdit = _gameLogic.QuestionsNotAsked[selectedIndex];

            QuestionEditForm qef = new QuestionEditForm(itemToEdit.Text, itemToEdit.HiddenFromUi, itemToEdit.ShownOnlyForDoctors);
            qef.ShowDialog();

            if (qef.DialogResult == DialogResult.OK)
            {
                itemToEdit.Text = qef.Question;
                itemToEdit.HiddenFromUi = qef.HiddenFromUi;
                itemToEdit.ShownOnlyForDoctors = qef.ShownOnlyForDoctors;

                _gameLogic.Questions.UpdateOnDbSide(itemToEdit);

                _gameLogic.UpdateQandA();
                UpdateAllLists();
            }
        }

        private void lstBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxQuestions.SelectedIndex > -1)
            {
                txtBoxCurrQuestion.Text = _gameLogic.QuestionsNotAsked[lstBoxQuestions.SelectedIndex].Text;
            }
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            AnswerForm af = new AnswerForm();
            af.ShowDialog();

            if (af.DialogResult == DialogResult.OK)
            {
                _gameLogic.Answers.Add(af.Answer);
            }

            _gameLogic.UpdateQandA();
            UpdateAllLists();
        }

        private void btnEditAnswer_Click(object sender, EventArgs e)
        {
            var selectedIndex = lstBoxAnswers.SelectedIndex;

            var itemToEdit = _gameLogic.AnswersAll[selectedIndex];

            AnswerForm ans = new AnswerForm(itemToEdit.Text);
            ans.ShowDialog();

            if (ans.DialogResult == DialogResult.OK)
            {
                itemToEdit.Text = ans.Answer;

                _gameLogic.Answers.UpdateOnDbSide(itemToEdit);

                _gameLogic.UpdateQandA();
                UpdateAllLists();
            }
        }

        private void btnRemoveAnswer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure you want to delete selected ANSWER?", "Sure?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                var selectedIndex = lstBoxAnswers.SelectedIndex;

                var itemToDelete = _gameLogic.AnswersAll[selectedIndex];

                _gameLogic.Answers.Remove(itemToDelete);

                _gameLogic.UpdateQandA();
                UpdateAllLists();
            }
        }

        public void AnswerOnQuestion(Reaction react)
        {
            if (_gameLogic.QuestionsNotAsked.Count == 0)
            {
                return;
            }

            var selectedIndex = lstBoxQuestions.SelectedIndex;

            var question = _gameLogic.QuestionsNotAsked[selectedIndex];

            _gameLogic.AnswerOnQuestion(question, react);

            _gameLogic.UpdateQandA();

            UpdateAllLists();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            AnswerOnQuestion(Reaction.Yes);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {

            AnswerOnQuestion(Reaction.No);
        }

        private void btnCloserYesThanNo_Click(object sender, EventArgs e)
        {

            AnswerOnQuestion(Reaction.CloserYesThanNo);
        }

        private void btnCloserNoThanYes_Click(object sender, EventArgs e)
        {
            AnswerOnQuestion(Reaction.CloserNoThanYes);
        }

        private void btnDoesNotMakeSence_Click(object sender, EventArgs e)
        {
            AnswerOnQuestion(Reaction.DoesNotMakeSence);
        }

        private void btnMarkAsAnswer_Click(object sender, EventArgs e)
        {
            var selectedIndex = lstBoxAnswers.SelectedIndex;

            var selectedAnswer = _gameLogic.AnswersAll[selectedIndex];

            using (var sqaf = new SubmitAnswerForm(_gameLogic, selectedAnswer))
            {
                sqaf.ShowDialog();
            }

            UpdateAllLists();
        }
    }
}
