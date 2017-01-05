using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AkinatorEngine;
using AkinatorEngine.Model;

namespace MedAkinator
{
    public partial class SubmitAnswerForm : Form
    {
        readonly GameLogic _gameLogic;
        readonly Answer _answer;
        readonly List<Question> _questionsHist = new List<Question>();
        readonly bool _readyForChanges;
        
        public SubmitAnswerForm(GameLogic gameLogic, Answer answer)
        {
            InitializeComponent();

            _gameLogic = gameLogic;
            _answer = answer;

            label2.Text = _answer.Text;
            UpdateDgv();
            _readyForChanges = true;
        }

        private void UpdateDgv()
        {
            dataGridView1.Rows.Clear();

            foreach (var qrHistItem in _gameLogic.QuestionAndReactionHistory)
            {
                var reacts = new[] {false, false, false, false, false};

                switch (qrHistItem.Value)
                {
                    case (Reaction.Yes):
                        reacts[0] = true;
                        break;
                    case (Reaction.No):
                        reacts[1] = true;
                        break;
                    case (Reaction.CloserYesThanNo):
                        reacts[2] = true;
                        break;
                    case (Reaction.CloserNoThanYes):
                        reacts[3] = true;
                        break;
                    default:
                        reacts[4] = true;
                        break;
                }

                dataGridView1.Rows.Add(qrHistItem.Key.Text, reacts[0], reacts[1], reacts[2], reacts[3], reacts[4]);
                _questionsHist.Add(qrHistItem.Key);
            }
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            _gameLogic.ForceGameFinishWithAnswer(_answer);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_readyForChanges == false)
                return;

            var colI = e.ColumnIndex;
            var rowI = e.RowIndex;

            Reaction newReact = (Reaction)colI - 1;

            _gameLogic.QuestionAndReactionHistory[_questionsHist[rowI]] = newReact;
            
            UpdateDgv();
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            var dgw = (DataGridView) sender;
            dgw.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}
