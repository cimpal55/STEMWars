using FluentMigrator;
using STEMWars.Data;
using STEMWars.Migrations.Interfaces;
using static STEMWars.Data.Columns;

namespace STEMWars.Migrations._20230929_Initial
{
    internal sealed class QuestionOptionsMigration : ISubMigration
    {
        private const string TableName = Tables.QuestionOptions;
        public void Up(Migration migration)
        {
            migration.Create.Table(TableName)
                .WithColumn(QuestionOptions.QuestionId).AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn(QuestionOptions.Option).AsString(250).Nullable()
                .WithColumn(QuestionOptions.IsAnswer).AsBoolean().Nullable();
        }

        public void Down(Migration migration)
        {
            migration.Delete.Table(TableName);
        }
    }
}
