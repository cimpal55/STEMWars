using LinqToDB.Mapping;
using STEMWars.Data;
using System.Net;
using static STEMWars.Data.Columns;

namespace STEMWars.Shared.Models.Data
{
    [Table(Tables.Users)]
    public class UserModel
    {
        public int Id { get; set; }

        [Column(User.Email, CanBeNull = false)]
        public string Email { get; set; } = string.Empty;
        
        [Column(User.PasswordHash, CanBeNull = false)]
        public byte[] PasswordHash { get; set; }

        [Column(User.PasswordSalt, CanBeNull = false)]
        public byte[] PasswordSalt { get; set; }

        [Column(User.Role, CanBeNull = false)]
        public string Role { get; set; } = "Customer";
        public AddressModel Address { get; set; } = new();

        [Column(User.Created, CanBeNull = false)]
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
