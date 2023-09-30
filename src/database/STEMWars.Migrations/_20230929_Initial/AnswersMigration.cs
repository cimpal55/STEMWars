using FluentMigrator;
using STEMWars.Data;
using STEMWars.Migrations.Interfaces;
using static STEMWars.Data.Columns;

namespace STEMWars.Migrations._20230929_Initial
{
    internal sealed class AnswersMigration : ISubMigration
    {
        private const string TableName = Tables.Answers;
        public void Up(Migration migration)
        {
            migration.Create.Table(TableName)
                .WithColumn(Answer.Id).AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn(Answer.QuestionId).AsInt32().NotNullable().ForeignKey(Tables.Questions, Question.Id)
                .WithColumn(Answer.Text).AsString(250).Nullable()
                .WithColumn(Answer.IsCorrect).AsBoolean().Nullable();
        }

        public void Down(Migration migration)
        {
            migration.Delete.Table(TableName);
        }
    }
}
