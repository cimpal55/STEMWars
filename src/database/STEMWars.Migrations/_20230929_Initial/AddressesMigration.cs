using FluentMigrator;
using STEMWars.Data;
using STEMWars.Migrations.Interfaces;
using STEMWars.Migrations.Utils.Extensions;
using static STEMWars.Data.Columns;

namespace STEMWars.Migrations._20230929_Initial
{
    internal sealed class AddressesMigration : ISubMigration
    {
        private const string TableName = Tables.Addresses;
        public void Up(Migration migration)
        {
            migration.Create.Table(TableName)
                .WithColumn(Address.Id).AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn(Address.UserId).AsInt32().Nullable()
                .WithColumn(Address.FirstName).AsString(150).Nullable()
                .WithColumn(Address.LastName).AsString(150).Nullable()
                .WithColumn(Address.Street).AsString(250).Nullable()
                .WithColumn(Address.State).AsString(250).Nullable()
                .WithColumn(Address.Zip).AsString(250).Nullable()
                .WithColumn(Address.CountryId).AsInt32().Nullable().ForeignKey(Tables.Countries, Country.Id)
                .WithColumn(Address.Created).AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentDateTime);
        }

        public void Down(Migration migration)
        {
            migration.Delete.Table(TableName);
        }
    }
}
