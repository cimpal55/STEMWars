namespace STEMWars.Migrations.Interfaces
{
    public interface ICompositeMigration
    {
        ISubMigration[] GetMigrations();
    }
}
