namespace LTPTranslations.Data
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;

    using LTPTranslations.Data.Common.Models;
    using LTPTranslations.Data.Models;
    using LTPTranslations.Data.Models.Clients;
    using LTPTranslations.Data.Models.CompanyInformation;
    using LTPTranslations.Data.Models.Invoices;
    using LTPTranslations.Data.Models.Legalizations;
    using LTPTranslations.Data.Models.ModelRelationships;
    using LTPTranslations.Data.Models.Moderators;
    using LTPTranslations.Data.Models.Orders;
    using LTPTranslations.Data.Models.Translations;
    using LTPTranslations.Data.Models.Translator;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private static readonly MethodInfo SetIsDeletedQueryFilterMethod =
            typeof(ApplicationDbContext).GetMethod(
                nameof(SetIsDeletedQueryFilter),
                BindingFlags.NonPublic | BindingFlags.Static);

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Offer> Offers { get; set; }

        public DbSet<OrderType> OrderTypes { get; set; }

        public DbSet<TimeForFullfillment> TimeForFullfillments { get; set; }

        public DbSet<FullfillmentType> FullfillmentTypes { get; set; }

        public DbSet<LanguageFrom> LanguagesFrom { get; set; }

        public DbSet<LanguageTo> LanguagesTo { get; set; }

        public DbSet<DeliveryType> DeliveryTypes { get; set; }

        public DbSet<DocumentForTranslation> DocumentForTranslations { get; set; }

        public DbSet<AddressInformation> AddressesInformation { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<PersonalInformation> PersonalInformation { get; set; }

        public DbSet<PostalCode> PostalCodes { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Office> Offices { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<InvoiceStatus> InvoiceStatuses { get; set; }

        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        public DbSet<Courier> Couriers { get; set; }

        public DbSet<DocumentForLegalization> DocumentForLegalizations { get; set; }

        public DbSet<DocumentType> DocumentTypes { get; set; }

        public DbSet<Legalization> Legalizations { get; set; }

        public DbSet<LegalizationProcess> LegalizationProcesses { get; set; }

        public DbSet<LegalizingAuthority> LegalizingAuthorities { get; set; }

        public DbSet<TranslationTranslator> TranslationTranslators { get; set; }

        public DbSet<Moderator> Moderators { get; set; }

        public DbSet<LanguagePair> LanguagePairs { get; set; }

        public DbSet<Translation> Translations { get; set; }

        public DbSet<ConsularCertification> ConsularCertifications { get; set; }

        public DbSet<PreferedTopic> PreferedTopics { get; set; }

        public DbSet<Translator> Translators { get; set; }

        public DbSet<UniversityDiploma> UniversityDiplomas { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<ContactFormEntry> ContactFormEntries { get; set; }

        public override int SaveChanges() => this.SaveChanges(true);

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
            this.SaveChangesAsync(true, cancellationToken);

        public override Task<int> SaveChangesAsync(
            bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TranslationTranslator>().HasKey(key => new { key.TranslationId, key.TranslatorId });

            // Needed for Identity models configuration
            base.OnModelCreating(builder);

            this.ConfigureUserIdentityRelations(builder);

            EntityIndexesConfiguration.Configure(builder);

            var entityTypes = builder.Model.GetEntityTypes().ToList();

            // Set global query filter for not deleted entities only
            var deletableEntityTypes = entityTypes
                .Where(et => et.ClrType != null && typeof(IDeletableEntity).IsAssignableFrom(et.ClrType));
            foreach (var deletableEntityType in deletableEntityTypes)
            {
                var method = SetIsDeletedQueryFilterMethod.MakeGenericMethod(deletableEntityType.ClrType);
                method.Invoke(null, new object[] { builder });
            }

            // Disable cascade delete
            var foreignKeys = entityTypes
                .SelectMany(e => e.GetForeignKeys().Where(f => f.DeleteBehavior == DeleteBehavior.Cascade));
            foreach (var foreignKey in foreignKeys)
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        private static void SetIsDeletedQueryFilter<T>(ModelBuilder builder)
            where T : class, IDeletableEntity
        {
            builder.Entity<T>().HasQueryFilter(e => !e.IsDeleted);
        }

        // Applies configurations
        private void ConfigureUserIdentityRelations(ModelBuilder builder)
             => builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

        private void ApplyAuditInfoRules()
        {
            var changedEntries = this.ChangeTracker
                .Entries()
                .Where(e =>
                    e.Entity is IAuditInfo &&
                    (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in changedEntries)
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default)
                {
                    entity.CreatedOn = DateTime.UtcNow;
                }
                else
                {
                    entity.ModifiedOn = DateTime.UtcNow;
                }
            }
        }
    }
}
