using FluentMigrator;
using STEMWars.Data;
using STEMWars.Migrations.Interfaces;
using static STEMWars.Data.Columns;

namespace STEMWars.Migrations._20230929_Initial
{
    internal sealed class UserAnswersHistoryMigration : ISubMigration
    {
        private const string TableName = Tables.User_answers_history;
        public void Up(Migration migration)
        {
            migration.Create.Table(TableName)
                .WithColumn(User_answer_history.UserId).AsInt32().NotNullable().ForeignKey(Tables.User_questions_history, User_question_history.UserId)
                .WithColumn(User_answer_history.RoomId).AsInt32().NotNullable().ForeignKey(Tables.User_questions_history, User_question_history.RoomId)
                .WithColumn(User_answer_history.QuestionId).AsInt32().NotNullable().ForeignKey(Tables.User_questions_history, User_question_history.QuestionId)
                .WithColumn(User_answer_history.AnswerId).AsInt32().NotNullable().ForeignKey(Tables.Answers, Answer.Id);
        }

        public void Down(Migration migration)
        {
            migration.Delete.Table(TableName);
        }
    }
}
