using Catel.Data;

namespace WPF.PRC.PBF
{
    using System;
    using System.Data.Entity;

    public class PBFDataContext : DbContext
    {
        // Your context has been configured to use a 'PBFDataContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WPF.PRC.PBF.PBFDataContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PBFDataContext' 
        // connection string in the application configuration file.
        public PBFDataContext()
            : base("name=PBFDataContext")
        {
        }

        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<BankDetails> BankDetailses { get; set; }
        public virtual DbSet<Citizenship> Citizenships { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<DateTime>().Configure(property => property.HasColumnType("datetime2"));
            modelBuilder.Properties<DateTime?>().Configure(property => property.HasColumnType("datetime2"));

            modelBuilder.Entity<Unit>().IgnoreCatelProperties();
            modelBuilder.Entity<Address>().IgnoreCatelProperties();
            modelBuilder.Entity<BankDetails>().IgnoreCatelProperties();
            modelBuilder.Entity<Citizenship>().IgnoreCatelProperties();
            modelBuilder.Entity<Email>().IgnoreCatelProperties();
            modelBuilder.Entity<PhoneNumber>().IgnoreCatelProperties();

            modelBuilder.Entity<CardID>().IgnoreCatelProperties();
            modelBuilder.Entity<CardIDIssuer>().IgnoreCatelProperties();
            modelBuilder.Entity<CardIDType>().IgnoreCatelProperties();
            modelBuilder.Entity<PlaceOfBirth>().IgnoreCatelProperties();

            modelBuilder.Entity<RegistrationCertificate>().IgnoreCatelProperties();
            modelBuilder.Entity<RegistrationCertificateIssuer>().IgnoreCatelProperties();
            modelBuilder.Entity<FormOfIncorporation>().IgnoreCatelProperties();

            modelBuilder.Entity<ShareholderAccount>().IgnoreCatelProperties();
            modelBuilder.Entity<IssueOfSecurities>().IgnoreCatelProperties();

            //modelBuilder.Entity<Document>().IgnoreCatelProperties();
            //modelBuilder.Entity<AuthorizesDocumentType>().IgnoreCatelProperties();
            //modelBuilder.Entity<DocumentPackage>().IgnoreCatelProperties();

            //modelBuilder.Entity<TransferReasonDocument>().IgnoreCatelProperties();
            //modelBuilder.Entity<TransferReasonType>().IgnoreCatelProperties();

        }
    }

}