using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace AutofacStartupSetup.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Code { get; set; }
        public string EmailAddress { get; set; }
        public byte[] Version { get; set; }
        public string GivenName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string VoiceTelephonNumber { get; set; }
        public string Summary { get; set; }
        public string UserGroupNames { get; set; }
        public int Lang { get; set; }
        public bool IsPublic { get; set; }
    }

    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserId);

            // Properties
            this.Property(t => t.Login)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Code)
                .HasMaxLength(50);

            this.Property(t => t.EmailAddress)
                .HasMaxLength(200);

            this.Property(t => t.Version)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            this.Property(t => t.GivenName)
                .HasMaxLength(200);

            this.Property(t => t.MiddleName)
                .HasMaxLength(200);

            this.Property(t => t.Surname)
                .HasMaxLength(200);

            this.Property(t => t.VoiceTelephonNumber)
                .HasMaxLength(50);

            this.Property(t => t.Summary)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Users");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Login).HasColumnName("Login");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.EmailAddress).HasColumnName("EmailAddress");
            this.Property(t => t.Version).HasColumnName("Version");
            this.Property(t => t.GivenName).HasColumnName("GivenName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.Surname).HasColumnName("Surname");
            this.Property(t => t.VoiceTelephonNumber).HasColumnName("VoiceTelephonNumber");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.UserGroupNames).HasColumnName("UserGroupNames");
            this.Property(t => t.Lang).HasColumnName("Lang");
            this.Property(t => t.IsPublic).HasColumnName("IsPublic");
        }
    }
}
