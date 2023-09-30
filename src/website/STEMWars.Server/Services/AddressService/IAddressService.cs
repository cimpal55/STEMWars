namespace STEMWars.Server.Services.AddressService
{
    public interface IAddressService
    {
        Task<ServiceResponse<AddressModel>> AddOrUpdateAddress(AddressModel address);
        Task<ServiceResponse<AddressModel>> GetAddress();
    }
}
