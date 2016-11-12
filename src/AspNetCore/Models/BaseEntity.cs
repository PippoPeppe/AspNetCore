using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Models
{
    public abstract class BaseEntity
    {
        [Key, Column(Order = 1)]
        public virtual Guid Id { get; set; } = Guid.NewGuid();
        public bool IsValid { get; set; } = true;
        public virtual string Note { get; set; }
    }
}
