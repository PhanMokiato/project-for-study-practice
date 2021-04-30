using Npgsql;

namespace WebApplication.Models
{
    public class User
    {
        private int Id { get; set; }
        public string Name { get; set; } // имя пользователя
        public int PhoneNumber { get; set; } // возраст пользователя
        public string Password { get; set; } 
    }
}