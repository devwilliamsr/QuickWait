using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("user");

            builder.HasKey(p => p.Id);

            builder.HasIndex(p => p.Cpf)
                   .IsUnique(); 

            builder.HasIndex(p => p.Email)
                   .IsUnique();

            builder.HasIndex(p => p.Username)
                   .IsUnique();         
        }
    }
}