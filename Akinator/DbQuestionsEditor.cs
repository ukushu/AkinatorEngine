using AkinatorEngine.Model;

namespace AkinatorEngine
{
    public class DbQuestionsEditor
    {
        Db _db;

        public DbQuestionsEditor(Db db)
        {
            _db = db;
        }

        public void Add(string qStr, bool hiddenFromUi, bool shownOnlyForDoctors)
        {
            Question q = new Question();
            q.Text = qStr;
            q.HiddenFromUi = hiddenFromUi;
            q.ShownOnlyForDoctors = shownOnlyForDoctors;

            _db.QuestionAdd(ref q);
        }

        public void Remove(Question q)
        {
            _db.QuestionRemove(q);
        }

        public void UpdateOnDbSide(Question q)
        {
            _db.QuestionUpdateOnDbSide(q);
        }
    }
}
