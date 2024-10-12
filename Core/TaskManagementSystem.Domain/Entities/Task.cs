using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Domain.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? CompletedAt { get; set; }

        // UserId sahəsi əlavə olunur
        public int UserId { get; set; } // Hər tapşırığın bir istifadəçiyə aid olduğunu göstərir
        public User User { get; set; } // User ilə olan əlaqə
    }
}
