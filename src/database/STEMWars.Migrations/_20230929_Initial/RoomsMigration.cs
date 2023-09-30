using FluentMigrator;
using STEMWars.Data;
using STEMWars.Migrations.Interfaces;
using static STEMWars.Data.Columns;

namespace STEMWars.Migrations._20230929_Initial
{
    internal sealed class RoomsMigration : ISubMigration
    {
        private const string TableName = Tables.Rooms;
        public void Up(Migration migration)
        {
            migration.Create.Table(TableName)
                .WithColumn(Room.Id).AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn(Room.Name).AsString(350).Nullable()
                .WithColumn(Room.Capacity).AsInt32().Nullable()
                .WithColumn(Room.IsActive).AsBoolean().Nullable()
                .WithColumn(Room.Created).AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentDateTime);
        }

        public void Down(Migration migration)
        {
            migration.Delete.Table(TableName);
        }
    }
}
