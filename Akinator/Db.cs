using System.Collections.Generic;
using System.Linq;
using AkinatorEngine.Model;
using AkinatorEngine.Models.DB;


using Answer = AkinatorEngine.Models.DB.Answer;
using Question = AkinatorEngine.Models.DB.Question;

namespace AkinatorEngine
{
    public class Db
    {
        private PetaPoco.Database _db;
        private string _tblA = "answers";
        private string _tblQ = "questions";
        private string _tblUsrs = "users";
        private string _tblGdetails = "gameDetails";
        private string _tblGhistory = "gameHistory";

        public Db(string connection = @"data source=AkinatorDB.sqlite; Version=3;")
        {
            var a = new System.Data.SQLite.SQLiteConnection(connection);
            a.Open();

            _db = new PetaPoco.Database(a);
        }

        public void QuestionAdd(ref Model.Question q)
        {
            q.Id = QuestionAdd(q.Text, q.ShownOnlyForDoctors, q.HiddenFromUi);
        }

        public int QuestionAdd(string question, bool shownOnlyForDoctors = false, bool hiddenFromUi = false)
        {
            var a = new Question();

            a.text = question;
            a.shown_only_for_doctors = shownOnlyForDoctors;
            a.hidden_from_ui = hiddenFromUi;

            _db.Insert(a);

            return a.question_id;
        }

        public void AnswerAdd(ref Model.Answer a)
        {
            a.Id = AnswerAdd(a.Text);
        }

        public int AnswerAdd(string answer)
        {
            var a = new Answer();

            a.text = answer;

            _db.Insert(a);

            return a.answer_id;
        }

        public void QuestionRemove(Model.Question q)
        {
            QuestionRemove(q.Id);
        }

        public void QuestionRemove(int id)
        {
            _db.Execute($"DELETE FROM {_tblQ} WHERE question_id=" + id);
            _db.Execute($"DELETE FROM {_tblGdetails} WHERE question_id=" + id);
        }

        public void QuestionUpdateOnDbSide(Model.Question q)
        {
            var a = _db.SingleOrDefault<Question>($"SELECT * FROM {_tblQ} WHERE question_id={q.Id}");

            a.hidden_from_ui = q.HiddenFromUi;
            a.shown_only_for_doctors = q.ShownOnlyForDoctors;
            a.text = q.Text;

            _db.Update(a);
        }

        public void AnswerUpdateOnDbSide(Model.Answer ans)
        {
            var a = _db.SingleOrDefault<Answer>($"SELECT * FROM {_tblA} WHERE answer_id={ans.Id}");
            
            a.text = ans.Text;

            _db.Update(a);
        }

        public void AnswerRemove(Model.Answer ans)
        {
            AnswerRemove(ans.Id);
        }

        public void AnswerRemove(int id)
        {
            _db.Execute($"DELETE FROM {_tblA} WHERE answer_id=" + id);
            _db.Execute($"DELETE FROM {_tblGhistory} WHERE answer_id=" + id);

            _db.Execute($"");
        }
        
        public List<Model.Question> QuestionsGetAll()
        {
            List < Model.Question > questions = new List<Model.Question>();

            foreach (var a in _db.Query<Question>("SELECT * FROM questions"))
            {
                questions.Add(new Model.Question()
                {
                    HiddenFromUi = a.hidden_from_ui,
                    Id = a.question_id,
                    ShownOnlyForDoctors = a.shown_only_for_doctors,
                    Text = a.text
                });
            }

            return questions;
        }

        public List<Model.Answer> AnswersGetAll()
        {
            List<Model.Answer> answers = new List<Model.Answer>();

            foreach (var a in _db.Query<Answer>("SELECT * FROM answers"))
            {
                int countOfGamesWhenWasAsTarget = _db.Query<int>($"SELECT Count(*) FROM {_tblGhistory} WHERE answer_id = '{a.answer_id}'").ToArray()[0];
                
                answers.Add(new Model.Answer()
                {
                    Id = a.answer_id,
                    Text = a.text,
                    CountOfGamesWhenWasAsTarget = countOfGamesWhenWasAsTarget
                });
            }

            return answers;
        }

        public long CountOfGames()
        {
            return _db.ExecuteScalar<long>($"SELECT Count(*) FROM {_tblGhistory}");
        }

        public void GameAdd(User user, Model.Answer answ, Dictionary<Model.Question,Reaction> gameHistory )
        {
            GameHistory gh = new GameHistory();

            gh.answer_id = answ.Id;

            gh.approved_by_moderator = false;

            gh.user_id = user.user_id;
            
            _db.Insert(gh);

            foreach (var keyPair in gameHistory)
            {
                GameDetails grh = new GameDetails();
                
                grh.game_id = gh.game_id;
                grh.question_id = keyPair.Key.Id;
                grh.reaction_id = (int) keyPair.Value;

                _db.Insert(grh);
            }
        }

        public int UserAdd(string login, bool isDoctor)
        {
            User user = new User();

            user.login = login;
            user.is_doctor = isDoctor;

            _db.Insert(user);

            return user.user_id;
        }

        public User GetFirstUser()
        {
            foreach (var a in _db.Query<User>($"SELECT * FROM {_tblUsrs}"))
            {
                return a;
            }

            return new User();
        }

        public int QuestionAskedWhenThinkAboutAnswer(Model.Question q ,Model.Answer ans)
        {
            return QuestionAskedWhenThinkAboutAnswer(q.Id, ans.Id);
        }

        public int QuestionReactionCountWhenThinkAboutAnswer(Model.Question q, Reaction react, Model.Answer ans)
        {
            var query =
                $"SELECT Count(*) FROM {_tblGdetails} INNER JOIN {_tblGhistory} ON ({_tblGdetails}.game_id = {_tblGhistory}.game_id) WHERE question_id = {q.Id} AND reaction_id = {(int) react} AND answer_id={ans.Id}";

            return _db.SingleOrDefault<int>(query);
        }

        public int QuestionAskedWhenThinkAboutAnswer(int questionId, int answerId)
        {
            return _db.SingleOrDefault<int>($"SELECT Count(*) FROM {_tblGdetails} INNER JOIN {_tblGhistory} ON ({_tblGdetails}.game_id = {_tblGhistory}.game_id) WHERE answer_id = {answerId}  AND question_id = {questionId}");
        }

        public int GeneralReactionCountForExactQuestion(Reaction react, Model.Question q)
        {
            return _db.SingleOrDefault<int>($"SELECT Count(*) FROM {_tblGdetails} WHERE question_id = {q.Id} AND reaction_id = {(int)react}");
        }

        public void asdf()
        {
            
        }
    }
}
