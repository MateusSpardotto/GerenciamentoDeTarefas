using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<Task> Tasks { get; set; }
    }
}
