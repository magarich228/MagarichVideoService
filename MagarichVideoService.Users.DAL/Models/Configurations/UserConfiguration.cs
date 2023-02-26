using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagarichVideoService.Users.DAL.Models.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(p => p.Id)
                .IsRequired();

            builder.Property(p => p.NickName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.CreatedUtc)
                .IsRequired();
        }
    }
}
