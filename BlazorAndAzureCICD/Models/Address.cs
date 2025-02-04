using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Data;

namespace BlazorAndAzureCICD.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int PersonId { get; set; }

        public string StreetAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;

    }
}
