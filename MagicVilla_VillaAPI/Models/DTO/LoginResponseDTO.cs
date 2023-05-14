using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace MagicVilla_VillaAPI.Models.DTO
{
    public class LoginResponseDTO
    {
        public LocalUser? User { get; set; }
        public string? Token { get; set; }
    }
}
