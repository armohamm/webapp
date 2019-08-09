using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppUsingReact.Models;

namespace WebAppUsingReact.Helpers.Configuration
{
    internal class TestConfiguration : DbEntityConfiguration<Test>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Test> entity)
        {
            base.EntityConfigure(entity, "test");


            #region default configuration for test
            entity.Property(x => x.Value)
                .HasColumnName("val")
                .IsRequired();

            #endregion

        }
    }
}
