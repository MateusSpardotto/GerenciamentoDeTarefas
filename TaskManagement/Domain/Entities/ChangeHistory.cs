using Domain.Enums;
using System;

namespace Domain.Entities
{
    public class ChangeHistory
    {
        public Guid TaskId { get; set; }
        public Guid UserId { get; set; }
        public string Comments { get; set; }
        public Status Status { get; set; }
        public string Description { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
