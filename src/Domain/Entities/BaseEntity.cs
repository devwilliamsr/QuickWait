using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        [JsonIgnore]
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        private DateTime? _createAt;
        [JsonIgnore]
        [Column("create_at")]
        public DateTime? CreateAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }
        [JsonIgnore]
        [Column("update_at")]
        public DateTime? UpdateAt { get; set; }
    }
}