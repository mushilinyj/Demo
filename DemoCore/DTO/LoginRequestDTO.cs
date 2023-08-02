using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DemoCore.DTO
{
    public class LoginRequestDTO
    {
        [Required]
        [JsonProperty("userName")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="密码必填")]
        [JsonProperty("password")]
        public string PassWord { get; set; }
    }
}
