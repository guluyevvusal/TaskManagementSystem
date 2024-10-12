using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }

        // Əlavə sahələr
        public string Email { get; set; } // İstifadəçinin e-poçtu
        public DateTime CreatedAt { get; set; } // İstifadəçinin yaradılma tarixi
        public string Role { get; set; } // İstifadəçi rolu, məsələn: Admin, User
    }
}
