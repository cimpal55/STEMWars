using FluentMigrator;
using STEMWars.Data;
using STEMWars.Migrations.Interfaces;
using static STEMWars.Data.Columns;

namespace STEMWars.Migrations._20230929_Initial
{
    internal sealed class UsersMigration : ISubMigration
    {
        private const string TableName = Tables.Users;
        public void Up(Migration migration)
        {
            migration.Create.Table(TableName)
                .WithColumn(User.Id).AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn(User.Email).AsString(150).Nullable()
                .WithColumn(User.PasswordSalt).AsString(150).Nullable()
                .WithColumn(User.PasswordHash).AsString(100).Nullable()
                .WithColumn(User.Rating).AsInt32().Nullable()
                .WithColumn(User.Role).AsString(100).Nullable()
                .WithColumn(User.Created).AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentDateTime);
        }

        public void Down(Migration migration)
        {
            migration.Delete.Table(TableName);
        }
    }
}
