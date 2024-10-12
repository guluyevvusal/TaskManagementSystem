using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Infrastructure
{
    public class JwtSettings
    {
        public string Key { get; set; }     // JWT açarı
        public string Issuer { get; set; }  // İs
    }
}
