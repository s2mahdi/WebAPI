using Common.Users;
using Common.Utilities;
using Data.Commons;
using Entities;
using Entities.Abouts;
using Entities.Assets;
using Entities.Companies;
using Entities.Contacts;
using Entities.Courses;
using Entities.Newses;
using Entities.SamplingOperations;
using Entities.Statuses;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, int>
    {

        #region DBSets
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetPart> AssetParts { get; set; }
        public DbSet<DeviceModel> DeviceModels { get; set; }
        public DbSet<DeviceName> DeviceNames { get; set; }
        public DbSet<DeviceProducer> DeviceProducers { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseRequest> CourseRequests { get; set; }
        public DbSet<CourseRequestStatus> CourseRequestStatuses { get; set; }
        public DbSet<CourseRequestStatusHistory> CourseRequestStatusHistories { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Post> Posts{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DeviceType> DeviceTypes{ get; set; }
        public DbSet<SamplingOperation> SamplingOperations{ get; set; }
        public DbSet<SamplingExpert> SamplingExperts{ get; set; }
        public DbSet<SamplingExpertStatusHistory> SamplingExpertStatusHistories { get; set; }
        public DbSet<SampleType> SampleTypes{ get; set; }
        public DbSet<SmsLoginEvent> SmsLoginEvents { get; set; }
        public DbSet<Status> Statuses{ get; set; }
        public DbSet<Ticket> Tickets{ get; set; }
        public DbSet<Section> Sections{ get; set; }
        public DbSet<User> Users{ get; set; }
        #endregion
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MyApiDb;Integrated Security=true");
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var entitiesAssembly = typeof(IEntity).Assembly;
            modelBuilder.AddAuditableShadowProperties();
            modelBuilder.RegisterAllEntities<IEntity>(entitiesAssembly);
            modelBuilder.RegisterEntityTypeConfiguration(entitiesAssembly);
            modelBuilder.AddRestrictDeleteBehaviorConvention();
            modelBuilder.AddSequentialGuidForIdConvention();
            modelBuilder.AddPluralizingTableNameConvention();
        }

        #region SaveChanges
        public override int SaveChanges()
        {
            _cleanString();
            setShadowProperties();
            return base.SaveChanges();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            _cleanString();
            setShadowProperties();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            _cleanString();
            setShadowProperties();

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            _cleanString();
            setShadowProperties();
            return base.SaveChangesAsync(cancellationToken);
        }

        #endregion
        private void _cleanString()
        {
            var changedEntities = ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Added || x.State == EntityState.Modified);
            foreach (var item in changedEntities)
            {
                if (item.Entity == null)
                    continue;

                var properties = item.Entity.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.CanRead && p.CanWrite && p.PropertyType == typeof(string));

                foreach (var property in properties)
                {
                    var propName = property.Name;
                    var val = (string)property.GetValue(item.Entity, null);

                    if (val.HasValue())
                    {
                        var newVal = val.Fa2En().FixPersianChars();
                        if (newVal == val)
                            continue;
                        property.SetValue(item.Entity, newVal, null);
                    }
                }
            }
        }


        private void setShadowProperties()
        {
            var userInfoService = this.GetService<IUserInfoService>();
            ChangeTracker.SetAuditableEntityPropertyValues(userInfoService);
        }
    }
}
