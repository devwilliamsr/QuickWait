using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        private DateTime? _createAt;
        [Column("create_at")]
        public DateTime? CreateAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }
        [Column("update_at")]
        public DateTime? UpdateAt { get; set; }
    }
}