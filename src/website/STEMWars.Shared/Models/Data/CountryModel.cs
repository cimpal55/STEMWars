using STEMWars.Data;
using System.ComponentModel.DataAnnotations.Schema;
using static STEMWars.Data.Columns;

namespace STEMWars.Shared.Models.Data
{
    [Table(Tables.Countries)]
    public class CountryModel
    {
        //public int Id { get; set; }

        [Column(Columns.Country.Name)]
        public string Name { get; set; } = string.Empty;

        [Column(Columns.Country.Code)]
        public string Code { get; set; } = string.Empty;

    }
}
