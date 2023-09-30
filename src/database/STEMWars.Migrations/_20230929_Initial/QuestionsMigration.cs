using FluentMigrator;
using STEMWars.Data;
using STEMWars.Migrations.Interfaces;
using static STEMWars.Data.Columns;

namespace STEMWars.Migrations._20230929_Initial
{
    internal sealed class QuestionsMigration : ISubMigration
    {
        private const string TableName = Tables.Questions;
        public void Up(Migration migration)
        {
            migration.Create.Table(TableName)
                .WithColumn(Question.Id).AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn(Question.TopicId).AsInt32().Nullable().ForeignKey(Tables.Topics, Topic.Id)
                .WithColumn(Question.Type).AsString(250).Nullable()
                .WithColumn(Question.Difficulty).AsString(250).NotNullable();
        }

        public void Down(Migration migration)
        {
            migration.Delete.Table(TableName);
        }
    }
}
