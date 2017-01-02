using System;
using AkinatorEngine.Models.DB;

namespace AkinatorEngine
{
    public class Db
    {
        PetaPoco.Database _db;

        public Db(string connection = @"data source=AkinatorDB.sqlite; Version=3;")
        {
            var a = new System.Data.SQLite.SQLiteConnection(connection);
            a.Open();

            _db = new PetaPoco.Database(a);
        }

        public void ShowAllAnswers()
        {
            foreach (var a in _db.Query<Answer>("SELECT * FROM Answer"))
            {
                Console.WriteLine("{0} - {1}", a.answer_id, a.text);
            }
        }

        public void AddQuestion(string question, bool shownOnlyForDoctors = false, bool hiddenFromUi = false)
        {
            var a = new Question();
            a.text = question;
            a.shown_only_for_doctors = shownOnlyForDoctors;
            a.hidden_from_ui = hiddenFromUi;

            _db.Insert(a);
        }
    }
}
