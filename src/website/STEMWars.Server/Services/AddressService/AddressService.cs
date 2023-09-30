using STEMWars.Server.Services.AddressService;
using STEMWars.Server.Services.AuthService;

namespace ShopWebsite.Server.Services.AddressService
{
    public class AddressService : IAddressService
    {
        private readonly AppDataConnection _conn;
        private readonly IAuthService _authService;

        public AddressService(AppDataConnection conn, IAuthService authService)
        {
            _conn = conn;
            _authService = authService;
        }
        public async Task<ServiceResponse<AddressModel>> AddOrUpdateAddress(AddressModel address)
        {
            var response = new ServiceResponse<AddressModel>();
            var dbAddress = (await GetAddress()).Data;
            if (dbAddress == null)
            {
                address.UserId = _authService.GetUserId();
                _conn.Insert(address);
                response.Data = address;
            }
            else
            {
                dbAddress.FirstName = address.FirstName;
                dbAddress.LastName = address.LastName;
                dbAddress.Street = address.Street;
                dbAddress.Country = address.Country;
                dbAddress.City = address.City;
                dbAddress.State = address.State;
                dbAddress.Zip = address.Zip;
                response.Data = dbAddress;
            }

            await _conn.UpdateAsync(dbAddress);

            return response;
        }

        public async Task<ServiceResponse<AddressModel>> GetAddress()
        {
            int userId = _authService.GetUserId();
            var address = await _conn.Addresses
                .FirstOrDefaultAsync(a => a.UserId == userId);
            return new ServiceResponse<AddressModel>
            {
                Data = address
            };
        }
    }
}
