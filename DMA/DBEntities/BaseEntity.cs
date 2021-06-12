using System;
using System.Collections.Generic;
using System.Text;

namespace DMA
{
    public class BaseEntity
    {
        public bool is_active { get; set; } = true;
        public bool is_deleted { get; set; } = false;
        public Guid created_by { get; set; }
        public DateTime created_at { get; set; } = DateTime.UtcNow;
        public Guid? updated_by { get; set; }
        public DateTime? updated_at { get; set; }
    }
}
