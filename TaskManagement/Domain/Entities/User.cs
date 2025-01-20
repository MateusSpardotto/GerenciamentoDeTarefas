using Domain.Enums;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserLevel UserLevel { get; set; }
    }
}
