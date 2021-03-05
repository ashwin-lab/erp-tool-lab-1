﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebERP.Data;

namespace WebERP.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210226094546_newcolumn")]
    partial class newcolumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebERP.Models.Account_Master", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ACC_TYPE");

                    b.Property<string>("ACTIVE_TAG");

                    b.Property<string>("ADD1")
                        .IsRequired();

                    b.Property<string>("ADD2");

                    b.Property<string>("CITY_CODE");

                    b.Property<string>("CR_DAYS");

                    b.Property<string>("CR_LIMIT");

                    b.Property<string>("Country_Code")
                        .IsRequired();

                    b.Property<string>("EMAIL_ID")
                        .IsRequired();

                    b.Property<string>("GST_NO")
                        .IsRequired();

                    b.Property<string>("GST_REGD_TAG");

                    b.Property<DateTime?>("INS_DATE");

                    b.Property<string>("INS_UID");

                    b.Property<string>("MOBILE_NO")
                        .IsRequired();

                    b.Property<string>("NAME")
                        .IsRequired();

                    b.Property<string>("OP_BAL");

                    b.Property<string>("OP_BAL_TAG");

                    b.Property<string>("PH_NO");

                    b.Property<string>("PIN_CODE")
                        .IsRequired();

                    b.Property<string>("REMARKS");

                    b.Property<string>("State_Code");

                    b.Property<DateTime?>("UDT_DATE");

                    b.Property<string>("UDT_UID");

                    b.HasKey("ID");

                    b.ToTable("Account_Masters");
                });

            modelBuilder.Entity("WebERP.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("WebERP.Models.Artical_Master", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BRAND_CODE");

                    b.Property<DateTime?>("INS_DATE");

                    b.Property<string>("INS_UID");

                    b.Property<string>("NAME")
                        .IsRequired();

                    b.Property<DateTime?>("UDT_DATE");

                    b.Property<string>("UDT_UID");

                    b.HasKey("ID");

                    b.ToTable("Artical_Master");
                });

            modelBuilder.Entity("WebERP.Models.Brand_Master", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ABV")
                        .IsRequired();

                    b.Property<DateTime?>("INS_DATE");

                    b.Property<string>("INS_UID");

                    b.Property<string>("NAME")
                        .IsRequired();

                    b.Property<DateTime?>("UDT_DATE");

                    b.Property<string>("UDT_UID");

                    b.HasKey("ID");

                    b.ToTable("Brand_Master");
                });

            modelBuilder.Entity("WebERP.Models.Company", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ABV")
                        .IsRequired();

                    b.Property<string>("ACTIVE_TAG");

                    b.Property<string>("ADD1")
                        .IsRequired();

                    b.Property<string>("ADD2");

                    b.Property<string>("BANK_ACC_NO");

                    b.Property<string>("BANK_BRANCH");

                    b.Property<string>("BANK_NAME");

                    b.Property<string>("CITY_CODE");

                    b.Property<DateTime?>("CST_DAT");

                    b.Property<string>("CST_NO");

                    b.Property<string>("ECC_NO");

                    b.Property<string>("EMAIL_ID")
                        .IsRequired();

                    b.Property<string>("ESI_NO");

                    b.Property<string>("FAX_NO");

                    b.Property<string>("GST_NO")
                        .IsRequired();

                    b.Property<string>("IFSC_CODE");

                    b.Property<DateTime>("INS_DATE");

                    b.Property<string>("INS_UID");

                    b.Property<string>("LOGO_NAME");

                    b.Property<DateTime?>("LST_DATE");

                    b.Property<string>("LST_NO");

                    b.Property<string>("MOBILE_NO")
                        .IsRequired();

                    b.Property<string>("MSME_NO");

                    b.Property<string>("NAME")
                        .IsRequired();

                    b.Property<string>("PAN_NO")
                        .IsRequired();

                    b.Property<string>("PF_NO");

                    b.Property<string>("PH_NO");

                    b.Property<string>("PIN_CODE")
                        .IsRequired();

                    b.Property<string>("REMARKS");

                    b.Property<string>("SERVICE_TAX_NO");

                    b.Property<string>("TDS_NO");

                    b.Property<string>("TIN_NO");

                    b.Property<DateTime>("UDT_DATE");

                    b.Property<string>("UDT_UID");

                    b.Property<string>("URL");

                    b.HasKey("ID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("WebERP.Models.Godown_Master", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ABV");

                    b.Property<DateTime?>("INS_DATE");

                    b.Property<string>("INS_UID");

                    b.Property<string>("NAME")
                        .IsRequired();

                    b.Property<DateTime?>("UDT_DATE");

                    b.Property<string>("UDT_UID");

                    b.HasKey("ID");

                    b.ToTable("Godown_Master");
                });

            modelBuilder.Entity("WebERP.Models.Item_Master", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ACTIVE_TAG");

                    b.Property<int>("HSN_CODE");

                    b.Property<DateTime?>("INS_DATE");

                    b.Property<string>("INS_UID");

                    b.Property<int>("MAX_STOCK");

                    b.Property<int>("MIN_STOCK");

                    b.Property<string>("NAME")
                        .IsRequired();

                    b.Property<string>("REMARKS");

                    b.Property<DateTime?>("UDT_DATE");

                    b.Property<string>("UDT_UID");

                    b.Property<int>("UOM_CODE");

                    b.HasKey("ID");

                    b.ToTable("Item_Master");
                });

            modelBuilder.Entity("WebERP.Models.Location.CityModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityCode");

                    b.Property<DateTime?>("Ins_Date");

                    b.Property<string>("Ins_Uid");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("StateId");

                    b.Property<DateTime?>("Upd_Date");

                    b.Property<string>("Upd_Uid");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("WebERP.Models.Location.CountryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryCode")
                        .IsRequired();

                    b.Property<DateTime?>("Ins_Date");

                    b.Property<string>("Ins_Uid");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime?>("Upd_Date");

                    b.Property<string>("Upd_Uid");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("WebERP.Models.Location.StateModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryCode");

                    b.Property<int>("CountryId");

                    b.Property<DateTime?>("Ins_Date");

                    b.Property<string>("Ins_Uid");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("StateCode")
                        .IsRequired();

                    b.Property<DateTime?>("Upd_Date");

                    b.Property<string>("Upd_Uid");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("WebERP.Models.ProcessRate_Master", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("From_DATE");

                    b.Property<DateTime?>("INS_DATE");

                    b.Property<string>("INS_UID");

                    b.Property<string>("Proc_Code")
                        .IsRequired();

                    b.Property<string>("Rate")
                        .IsRequired();

                    b.Property<DateTime?>("To_DATE");

                    b.Property<DateTime?>("UDT_DATE");

                    b.Property<string>("UDT_UID");

                    b.Property<string>("UOM_Code")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("ProcessRate_Master");
                });

            modelBuilder.Entity("WebERP.Models.Process_Master", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("INS_DATE");

                    b.Property<string>("INS_UID");

                    b.Property<string>("NAME")
                        .IsRequired();

                    b.Property<DateTime?>("UDT_DATE");

                    b.Property<string>("UDT_UID");

                    b.HasKey("ID");

                    b.ToTable("Process_Master");
                });

            modelBuilder.Entity("WebERP.Models.Size_Master", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("INS_DATE");

                    b.Property<string>("INS_UID");

                    b.Property<string>("NAME")
                        .IsRequired();

                    b.Property<DateTime?>("UDT_DATE");

                    b.Property<string>("UDT_UID");

                    b.HasKey("ID");

                    b.ToTable("Size_Master");
                });

            modelBuilder.Entity("WebERP.Models.Term_Master", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ACTIVE_TAG");

                    b.Property<DateTime?>("INS_DATE");

                    b.Property<string>("INS_UID");

                    b.Property<string>("NAME")
                        .IsRequired();

                    b.Property<string>("PO");

                    b.Property<string>("SAL_Order");

                    b.Property<DateTime?>("UDT_DATE");

                    b.Property<string>("UDT_UID");

                    b.HasKey("ID");

                    b.ToTable("Term_Master");
                });

            modelBuilder.Entity("WebERP.Models.UOM_MASTER", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ABV")
                        .IsRequired();

                    b.Property<DateTime?>("INS_DATE");

                    b.Property<string>("INS_UID");

                    b.Property<string>("NAME")
                        .IsRequired();

                    b.Property<DateTime?>("UDT_DATE");

                    b.Property<string>("UDT_UID");

                    b.HasKey("ID");

                    b.ToTable("UOM_MASTER");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebERP.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebERP.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebERP.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebERP.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
