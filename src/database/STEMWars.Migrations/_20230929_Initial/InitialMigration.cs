using FluentMigrator;
using STEMWars.Migrations._20230929_Initial;
using STEMWars.Migrations.Interfaces;

namespace STEMWars.Migrations
{
    [TimestampedMigration(2022, 07, 27, 0, 0, "Initial migration")]
    public sealed class InitialMigration : CompositeMigration
    {
        public override ISubMigration[] GetMigrations() =>
            new ISubMigration[]
            {
                new CountriesMigration(),
                new AddressesMigration(),
                new UsersMigration(),
                new RoomsMigration(),
                new TopicsMigration(),
                new QuestionsMigration(),
                new AnswersMigration(),
                new QuestionOptionsMigration(),
                new UsersInRoomMigration(),
                new UserQuestionsHistoryMigration(),
            };
    }
}