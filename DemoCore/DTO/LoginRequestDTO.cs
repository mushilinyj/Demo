using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DemoCore.DTO
{
    public class LoginRequestDTO
    {
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }
        [Required]
        [JsonProperty("passWord")]
        public string PassWord { get; set; }
    }
}
