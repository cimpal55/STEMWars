using FluentMigrator;
using STEMWars.Data;
using STEMWars.Migrations.Interfaces;
using static STEMWars.Data.Columns;

namespace STEMWars.Migrations._20230929_Initial
{
    internal sealed class TopicsMigration : ISubMigration
    {
        private const string TableName = Tables.Topics;
        public void Up(Migration migration)
        {
            migration.Create.Table(TableName)
                .WithColumn(Topic.Id).AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn(Topic.Name).AsString(250).Nullable();
        }

        public void Down(Migration migration)
        {
            migration.Delete.Table(TableName);
        }
    }
}
