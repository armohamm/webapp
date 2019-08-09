using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppUsingReact.Entities.Core;

namespace WebAppUsingReact.Helpers.Configuration
{
    internal abstract class DbEntityConfiguration<TEntity> where TEntity : Entity
    {
        public abstract void Configure(EntityTypeBuilder<TEntity> entity);
        public virtual void EntityConfigure(EntityTypeBuilder<TEntity> entity, string tableName)
        {

            entity.ToTable(tableName);

            #region default configuration for entity
            entity.Property(e => e.Id)
              .HasColumnName("id")
              .ValueGeneratedOnAdd();

            entity.Property(e => e.CreatedAt)
                .HasColumnName("create_date")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

            entity.Property(e => e.LastEditedAt)
                .HasColumnName("last_edit_at")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
            #endregion
        }
    }
}
