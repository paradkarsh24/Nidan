


namespace Nidan.Data.Models
{
    using System.Data.Entity;
    using Entity;

    public partial class NidanDatabase : OrganisationDbContext
    {
        public NidanDatabase() : base("name=NidanDatabase")
        {
        }

        public virtual DbSet<AbsenceType> AbsenceTypes { get; set; }
        public virtual DbSet<Alert> Alerts { get; set; }
        public virtual DbSet<AspNetUsersAlertSchedule> AspNetUsersAlertSchedules { get; set; }
        public virtual DbSet<Colour> Colours { get; set; }
        public virtual DbSet<Host> Hosts { get; set; }
        public virtual DbSet<Organisation> Organisations { get; set; }
        public virtual DbSet<Personnel> Personnels { get; set; }
        public virtual DbSet<UserAuthorisationFilter> UserAuthorisationFilters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           

          
            modelBuilder.Entity<Alert>()
                .HasMany(e => e.AspNetUsersAlertSchedules)
                .WithRequired(e => e.Alert)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Colour>()
                .Property(e => e.Hex)
                .IsUnicode(false);

            //modelBuilder.Entity<Colour>()
            //    .HasMany(e => e.Divisions)
            //    .WithRequired(e => e.Colour)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Company>()
            //    .HasMany(e => e.Divisions)
            //    .WithRequired(e => e.Company)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Country>()
            //    .HasMany(e => e.CountryAbsenceTypes)
            //    .WithRequired(e => e.Country)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Country>()
            //    .HasMany(e => e.CountryPublicHolidays)
            //    .WithRequired(e => e.Country)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Country>()
            //    .HasMany(e => e.DivisionCountryAbsencePeriods)
            //    .WithRequired(e => e.Country)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Country>()
            //    .HasMany(e => e.DivisionCountryWorkingPatterns)
            //    .WithRequired(e => e.Country)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Country>()
            //    .HasMany(e => e.Personnels)
            //    .WithRequired(e => e.Country)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Country>()
            //    .HasMany(e => e.Sites)
            //    .WithRequired(e => e.Country)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<CountryAbsenceType>()
            //    .HasMany(e => e.DivisionCountryAbsenceTypeEntitlements)
            //    .WithRequired(e => e.CountryAbsenceType)
            //    .WillCascadeOnDelete(false);

          
            //modelBuilder.Entity<Division>()
            //    .HasMany(e => e.DivisionCountryAbsencePeriods)
            //    .WithRequired(e => e.Division)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Division>()
            //    .HasMany(e => e.DivisionCountryAbsenceTypeEntitlements)
            //    .WithRequired(e => e.Division)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Division>()
            //    .HasMany(e => e.DivisionCountryWorkingPatterns)
            //    .WithRequired(e => e.Division)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Division>()
            //    .HasMany(e => e.DivisionSites)
            //    .WithRequired(e => e.Division)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Division>()
            //    .HasMany(e => e.Employments)
            //    .WithRequired(e => e.Division)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<DivisionCountryAbsencePeriod>()
            //    .HasMany(e => e.PersonnelAbsenceEntitlements)
            //    .WithRequired(e => e.DivisionCountryAbsencePeriod)
            //    .WillCascadeOnDelete(false);

           

            //modelBuilder.Entity<Frequency>()
            //    .HasMany(e => e.DivisionCountryAbsenceTypeEntitlements)
            //    .WithRequired(e => e.Frequency)
            //    .WillCascadeOnDelete(false);

       

            modelBuilder.Entity<Organisation>()
                .HasMany(e => e.Alerts)
                .WithRequired(e => e.Organisation)
                .WillCascadeOnDelete(false);

        
            //modelBuilder.Entity<Organisation>()
            //    .HasMany(e => e.CountryAbsenceTypes)
            //    .WithRequired(e => e.Organisation)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Organisation>()
            //    .HasMany(e => e.CountryPublicHolidays)
            //    .WithRequired(e => e.Organisation)
            //    .WillCascadeOnDelete(false);


            //modelBuilder.Entity<Organisation>()
            //    .HasMany(e => e.Divisions)
            //    .WithRequired(e => e.Organisation)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Organisation>()
            //    .HasMany(e => e.DivisionCountryAbsencePeriods)
            //    .WithRequired(e => e.Organisation)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Organisation>()
            //    .HasMany(e => e.DivisionCountryAbsenceTypeEntitlements)
            //    .WithRequired(e => e.Organisation)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Organisation>()
            //    .HasMany(e => e.DivisionCountryWorkingPatterns)
            //    .WithRequired(e => e.Organisation)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Organisation>()
            //    .HasMany(e => e.DivisionSites)
            //    .WithRequired(e => e.Organisation)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organisation>()
                .HasMany(e => e.Hosts)
                .WithRequired(e => e.Organisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organisation>()
                .HasMany(e => e.Personnels)
                .WithRequired(e => e.Organisation)
                .WillCascadeOnDelete(false);

          

            modelBuilder.Entity<Personnel>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Personnel>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Personnel>()
                .Property(e => e.NINumber)
                .IsUnicode(false);

            modelBuilder.Entity<Personnel>()
                .Property(e => e.BankAccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Personnel>()
                .Property(e => e.BankSortCode)
                .IsUnicode(false);

            modelBuilder.Entity<Personnel>()
                .Property(e => e.BankTelephone)
                .IsUnicode(false);

       

            //modelBuilder.Entity<PublicHoliday>()
            //    .HasMany(e => e.CountryPublicHolidays)
            //    .WithRequired(e => e.PublicHoliday)
            //    .WillCascadeOnDelete(false);


            //modelBuilder.Entity<Site>()
            //    .HasMany(e => e.DivisionSites)
            //    .WithRequired(e => e.Site)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<WorkingPattern>()
            //    .HasMany(e => e.DivisionCountryWorkingPatterns)
            //    .WithRequired(e => e.WorkingPattern)
            //    .WillCascadeOnDelete(false);

       

            //modelBuilder.Entity<CompanyBuilding>()
            //.HasMany(e => e.Buildings)
            //.WithRequired(e => e.CompanyBuilding)
            //.WillCascadeOnDelete(false);

          

            base.OnModelCreating(modelBuilder);
        }
    }
}
