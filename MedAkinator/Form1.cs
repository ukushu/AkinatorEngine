using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedAkinator
{
    public partial class Form1 : Form
    {
        public Dictionary<string, float> QuestionAndEntropy = new Dictionary<string, float>();
        public Dictionary<string, float> AnswerAndEntropy = new Dictionary<string, float>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDicts();
            FillQuestions(txtBoxQuestionFilter.Text);
            FillAnswers(txtBoxAnswerFilter.Text);
        }

        private void FillDicts()
        {
            QuestionAndEntropy.Add("Він красивий?", 0.5f);
            QuestionAndEntropy.Add("Він п'є кров?", 0.4f);
            QuestionAndEntropy.Add("Він одружений?", 0.4f);
            QuestionAndEntropy.Add("Він старший 50?", 0.3f);
            QuestionAndEntropy.Add("Він старший 20?", 0.3f);
            QuestionAndEntropy.Add("Він п'є?", 0.3f);
            QuestionAndEntropy.Add("Він реальний?", 0.3f);
            QuestionAndEntropy.Add("Він з відеогри?", 0.3f);
            QuestionAndEntropy.Add("Він знімався в серіалах?", 0.3f);
            QuestionAndEntropy.Add("Він актор?", 0.3f);
            QuestionAndEntropy.Add("Він з Росії?", 0.3f);
            QuestionAndEntropy.Add("Він живий?", 0.3f);
            QuestionAndEntropy.Add("Він з реальності Final Fantasy?", 0.3f);
            QuestionAndEntropy.Add("Він з реальності Mortal Compbat?", 0.2f);
            QuestionAndEntropy.Add("Він аніме персонаж?", 0.2f);
            QuestionAndEntropy.Add("Він король?", 0.2f);
            QuestionAndEntropy.Add("Він багатий?", 0.2f);
            QuestionAndEntropy.Add("Він співак?", 0.2f);
            QuestionAndEntropy.Add("В нього є колеса?", 0.1f);
            QuestionAndEntropy.Add("В нього 2 колеса?", 0.1f);
            QuestionAndEntropy.Add("Це жінка?", 0.1f);

            AnswerAndEntropy.Add("Шварценеггер", 0.5f);
            AnswerAndEntropy.Add("Дональд Трамп", 0.1f);
            AnswerAndEntropy.Add("Бред Питт", 0.1f);
            AnswerAndEntropy.Add("Анджеліна Джоулі", 0.1f);
            AnswerAndEntropy.Add("Річард Гір", 0.1f);
            AnswerAndEntropy.Add("Валерій Пістольний", 0.6543f);
            AnswerAndEntropy.Add("Аліса з Країни Чудес", 0.1342f);
            AnswerAndEntropy.Add("Потяг", 0.1342f);
            AnswerAndEntropy.Add("Дункан МакЛауд", 0.1342f);
            AnswerAndEntropy.Add("Lilu(FFX)", 0.14342f);
            AnswerAndEntropy.Add("Tidus(FFX)", 0.14342f);
            AnswerAndEntropy.Add("Auron(FFX)", 0.14342f);
            AnswerAndEntropy.Add("Rikku(FFX)", 0.14342f);
            AnswerAndEntropy.Add("Yuna(FFX)", 0.14342f);
            AnswerAndEntropy.Add("Shiva(FFX)", 0.14342f);
            AnswerAndEntropy.Add("Ifrit(FFX)", 0.14342f);
            AnswerAndEntropy.Add("Kaktur(FFX)", 0.14342f);
            AnswerAndEntropy.Add("Odin(FFX)", 0.14342f);
        }

        private void FillQuestions(string filter = "")
        {
            FillListBox(filter, QuestionAndEntropy, lstBoxQuestions);
        }

        private void FillAnswers(string filter = "")
        {
            FillListBox(filter, AnswerAndEntropy, lstBoxAnswers);
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
        }

        private void txtBoxQuestionFilter_TextChanged(object sender, EventArgs e)
        {
            FillQuestions(txtBoxQuestionFilter.Text);
        }

        private void txtBoxAnswerFilter_TextChanged(object sender, EventArgs e)
        {
            FillAnswers(txtBoxAnswerFilter.Text);
        }
    }
}
