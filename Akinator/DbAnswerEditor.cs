using System.Runtime.InteropServices;
using AkinatorEngine.Model;

namespace AkinatorEngine
{
    public class DbAnswerEditor
    {
        Db _db;

        public DbAnswerEditor(Db db)
        {
            _db = db;
        }

        public void Add(string answer)
        {
            _db.AnswerAdd(answer);
        }

        public void Remove(Answer ans)
        {
            _db.AnswerRemove(ans);
        }

        public void UpdateOnDbSide(Answer ans)
        {
            _db.AnswerUpdateOnDbSide(ans);
        }

    }
}
