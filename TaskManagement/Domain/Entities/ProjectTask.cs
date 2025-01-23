using Domain.Enums;
using System;

namespace Domain.Entities
{
    public class ProjectTask : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public ChangeHistory ChangeHistory { get; set; }
        public string Comments { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
