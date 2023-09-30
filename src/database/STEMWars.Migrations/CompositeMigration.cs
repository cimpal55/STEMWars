using FluentMigrator;
using STEMWars.Migrations.Interfaces;
using STEMWars.Migrations.Utils.Extensions;

namespace STEMWars.Migrations
{
    public abstract class CompositeMigration : Migration, ICompositeMigration
    {
        public sealed override void Up() =>
            this.RunUp(this);
        public sealed override void Down() =>
            this.RunDown(this);
        public abstract ISubMigration[] GetMigrations();
    }
}