using Common.Users;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Commons
{
    public static class AuditableShadowProperties
    {
        public static readonly Func<object, int?> EFPropertyCreatedByUserId =
                                        entity => EF.Property<int?>(entity, CreatedByUserId);
        public static readonly string CreatedByUserId = nameof(CreatedByUserId);

        public static readonly Func<object, int?> EFPropertyModifiedByUserId =
                                        entity => EF.Property<int?>(entity, ModifiedByUserId);
        public static readonly string ModifiedByUserId = nameof(ModifiedByUserId);

        public static readonly Func<object, DateTime?> EFPropertyCreatedDateTime =
                                        entity => EF.Property<DateTime?>(entity, CreatedDateTime);
        public static readonly string CreatedDateTime = nameof(CreatedDateTime);

        public static readonly Func<object, DateTime?> EFPropertyModifiedDateTime =
                                        entity => EF.Property<DateTime?>(entity, ModifiedDateTime);
        public static readonly string ModifiedDateTime = nameof(ModifiedDateTime);

        public static void AddAuditableShadowProperties(this ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model
                                                   .GetEntityTypes()
                                                   .Where(e => e.ClrType.IsAssignableTo(typeof(IEntity))))
                

            {
                modelBuilder.Entity(entityType.ClrType)
                            .Property<int?>(CreatedByUserId);
                modelBuilder.Entity(entityType.ClrType)
                            .Property<int?>(ModifiedByUserId);

                modelBuilder.Entity(entityType.ClrType)
                            .Property<DateTime?>(CreatedDateTime);
                modelBuilder.Entity(entityType.ClrType)
                            .Property<DateTime?>(ModifiedDateTime);

            }


        }
        

        public static void SetAuditableEntityPropertyValues(
            this ChangeTracker changeTracker,
            IUserInfoService userInfoService)
        {
            var now = DateTime.UtcNow;
            var userId = userInfoService.UserId();

            var modifiedEntries = changeTracker.Entries<IEntity>()
                                               .Where(x => x.State == EntityState.Modified);
            foreach (var modifiedEntry in modifiedEntries)
            {
                modifiedEntry.Property(ModifiedDateTime).CurrentValue = now;
                modifiedEntry.Property(ModifiedByUserId).CurrentValue = userId;
            }

            var addedEntries = changeTracker.Entries<IEntity>()
                                            .Where(x => x.State == EntityState.Added);
            foreach (var addedEntry in addedEntries)
            {
                addedEntry.Property(CreatedDateTime).CurrentValue = now;
                addedEntry.Property(CreatedByUserId).CurrentValue = userId;
            }
        }



        public static ModelBuilder UseValueConverterForType(this ModelBuilder modelBuilder, Type type, ValueConverter converter, int maxLength = 0)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var properties = entityType.ClrType.GetProperties().Where(p => p.PropertyType == type);

                foreach (var property in properties)
                {
                    modelBuilder.Entity(entityType.Name).Property(property.Name)
                        .HasConversion(converter);
                    if (maxLength > 0)
                        modelBuilder.Entity(entityType.Name).Property(property.Name).HasMaxLength(maxLength);

                }
            }

            return modelBuilder;
        }

    }
}
