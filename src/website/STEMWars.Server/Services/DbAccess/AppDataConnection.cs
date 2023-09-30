namespace STEMWars.Server.Services.DbAccess
{
    public class AppDataConnection : DataConnection
    {
        public AppDataConnection(DataOptions<AppDataConnection> options)
            : base(options.Options)
        { }
        public ITable<UserModel> Users => this.GetTable<UserModel>();
        public ITable<AddressModel> Addresses => this.GetTable<AddressModel>();
        public ITable<CountryModel> Countries => this.GetTable<CountryModel>();

    }
}
