using FluentMigrator;
using STEMWars.Data;
using STEMWars.Migrations.Interfaces;
using static STEMWars.Data.Columns;

namespace STEMWars.Migrations._20230929_Initial
{
    internal sealed class UsersInRoomMigration : ISubMigration
    {
        private const string TableName = Tables.Users_in_room;
        public void Up(Migration migration)
        {
            migration.Create.Table(TableName)
                .WithColumn(User_in_room.UserId).AsInt32().NotNullable().ForeignKey(Tables.Users, User.Id)
                .WithColumn(User_in_room.RoomId).AsInt32().NotNullable().ForeignKey(Tables.Rooms, Room.Id)
                .WithColumn(User_in_room.Score).AsInt32().Nullable();
        }

        public void Down(Migration migration)
        {
            migration.Delete.Table(TableName);
        }
    }
}
