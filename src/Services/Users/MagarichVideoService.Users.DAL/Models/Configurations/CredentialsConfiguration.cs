using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MagarichVideoService.Users.DAL.Models.Configurations
{
    public class CredentialsConfiguration : IEntityTypeConfiguration<Credentials>
    {
        public void Configure(EntityTypeBuilder<Credentials> builder)
        {
            builder.HasKey(a => new { a.UserId, a.Email });

            builder.Property(p => p.UserId)
                .IsRequired();

            builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.Password)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
