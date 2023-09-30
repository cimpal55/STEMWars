using FluentMigrator;
using STEMWars.Data;
using STEMWars.Migrations.Interfaces;
using static STEMWars.Data.Columns;

namespace STEMWars.Migrations._20230929_Initial
{
    internal sealed class UserQuestionsHistoryMigration : ISubMigration
    {
        private const string TableName = Tables.User_questions_history;
        public void Up(Migration migration)
        {
            migration.Create.Table(TableName)
                .WithColumn(User_question_history.UserId).AsInt32().NotNullable().ForeignKey(Tables.Users, User.Id)
                .WithColumn(User_question_history.RoomId).AsInt32().NotNullable().ForeignKey(Tables.Rooms, Room.Id)
                .WithColumn(User_question_history.QuestionId).AsInt32().NotNullable().ForeignKey(Tables.Questions, Question.Id)
                .WithColumn(User_question_history.Score).AsInt32().Nullable();
        }

        public void Down(Migration migration)
        {
            migration.Delete.Table(TableName);
        }
    }
}
