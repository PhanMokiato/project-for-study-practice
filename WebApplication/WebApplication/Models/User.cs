using System.ComponentModel.DataAnnotations;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure.Internal;

namespace WebApplication.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; } // имя пользователя
        public int PhoneNumber { get; set; } // возраст пользователя
        public string Password { get; set; }
        public string Status { get; set; } = "user";
        public bool In_Out { get; set; } = false;
    }
}