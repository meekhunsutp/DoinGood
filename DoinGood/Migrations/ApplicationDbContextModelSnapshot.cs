﻿// <auto-generated />
using System;
using DoinGood.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoinGood.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DoinGood.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("DoinGood.Models.Catalyst", b =>
                {
                    b.Property<int>("CatalystId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccountBalance")
                        .HasColumnType("int");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("ChallengedCount")
                        .HasColumnType("int");

                    b.Property<int>("DeedCount")
                        .HasColumnType("int");

                    b.Property<int>("DonationCount")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Lat")
                        .HasColumnType("float");

                    b.Property<double>("Lng")
                        .HasColumnType("float");

                    b.Property<int>("TaskCompletedCount")
                        .HasColumnType("int");

                    b.Property<int>("TotalContribution")
                        .HasColumnType("int");

                    b.HasKey("CatalystId");

                    b.HasIndex("AddressId");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("Catalysts");
                });

            modelBuilder.Entity("DoinGood.Models.Challenge", b =>
                {
                    b.Property<int>("ChallengeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ChallengeCatalystId")
                        .HasColumnType("int");

                    b.Property<int>("ChallengeCount")
                        .HasColumnType("int");

                    b.Property<int?>("DeedCatalystId")
                        .HasColumnType("int");

                    b.Property<int>("DonateAmount")
                        .HasColumnType("int");

                    b.Property<int>("FundId")
                        .HasColumnType("int");

                    b.Property<string>("Impact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxAmount")
                        .HasColumnType("int");

                    b.HasKey("ChallengeId");

                    b.HasIndex("ChallengeCatalystId");

                    b.HasIndex("DeedCatalystId");

                    b.HasIndex("FundId");

                    b.ToTable("Challenges");
                });

            modelBuilder.Entity("DoinGood.Models.Deed", b =>
                {
                    b.Property<int>("DeedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Beneficence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CatalystId")
                        .HasColumnType("int");

                    b.Property<int>("ChallengeCount")
                        .HasColumnType("int");

                    b.Property<int>("DonateAmount")
                        .HasColumnType("int");

                    b.Property<int>("FundId")
                        .HasColumnType("int");

                    b.Property<string>("Impact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InspireCount")
                        .HasColumnType("int");

                    b.Property<int>("MaxAmount")
                        .HasColumnType("int");

                    b.HasKey("DeedId");

                    b.HasIndex("CatalystId");

                    b.HasIndex("FundId");

                    b.ToTable("Deeds");
                });

            modelBuilder.Entity("DoinGood.Models.Donate", b =>
                {
                    b.Property<int>("DonationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("DonorCatalystId")
                        .HasColumnType("int");

                    b.Property<int>("FundId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PosterCatalystId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("DonationId");

                    b.HasIndex("DonorCatalystId");

                    b.HasIndex("FundId");

                    b.HasIndex("PosterCatalystId");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("DoinGood.Models.Fund", b =>
                {
                    b.Property<int>("FundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CurrentFunds")
                        .HasColumnType("int");

                    b.Property<string>("FundName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfDonations")
                        .HasColumnType("int");

                    b.HasKey("FundId");

                    b.ToTable("Fund");

                    b.HasData(
                        new
                        {
                            FundId = 1,
                            CurrentFunds = 0,
                            FundName = "Inspired Fund",
                            Mission = "TBD",
                            NumberOfDonations = 0
                        },
                        new
                        {
                            FundId = 2,
                            CurrentFunds = 0,
                            FundName = "American Humane",
                            Mission = "To ensure the safety, welfare and well-being of animals; to serve in promoting and nurturing the bonds between animals and humans.",
                            NumberOfDonations = 0
                        },
                        new
                        {
                            FundId = 3,
                            CurrentFunds = 0,
                            FundName = "American Red Cross",
                            Mission = "Prevents and alleviates human suffering in the face of emergencies by mobilizing the power of volunteers and the generosity of donors.",
                            NumberOfDonations = 0
                        },
                        new
                        {
                            FundId = 4,
                            CurrentFunds = 0,
                            FundName = "Astraea Lesbian Foundation for Justice",
                            Mission = "Funds LGBTQI activism globally, serving as a feminist social justice hub and working side-by-side with grantee and donor partners to achieve rural, economic, social and gender justice worldwide.",
                            NumberOfDonations = 0
                        },
                        new
                        {
                            FundId = 5,
                            CurrentFunds = 0,
                            FundName = "Cancer Research Institute",
                            Mission = "To save more lives by fueling the discovery and development of powerful immunotherapies for all types of cancer.",
                            NumberOfDonations = 0
                        },
                        new
                        {
                            FundId = 6,
                            CurrentFunds = 0,
                            FundName = "Equal Justice Initiative",
                            Mission = "To end mass incarceration & excessive punishment in the U.S.; to challenge racial & economic injustice; and to protect basic human rights for the most vulnerable people in American society.",
                            NumberOfDonations = 0
                        },
                        new
                        {
                            FundId = 7,
                            CurrentFunds = 0,
                            FundName = "Feeding America",
                            Mission = "To feed America's hungry through a nationwide network of food banks and engage our country in the fight to end hunger.",
                            NumberOfDonations = 0
                        },
                        new
                        {
                            FundId = 8,
                            CurrentFunds = 0,
                            FundName = "Homes For Our Troops",
                            Mission = "To build and donate specially adapted custom homes nationwide for the most severely injured post-9/11 veterans, to enable them to rebuild their lives.",
                            NumberOfDonations = 0
                        },
                        new
                        {
                            FundId = 9,
                            CurrentFunds = 0,
                            FundName = "National Wildlife Federation",
                            Mission = "To unite all Americans to ensure wildlife thrives in a rapidly changing world.",
                            NumberOfDonations = 0
                        },
                        new
                        {
                            FundId = 10,
                            CurrentFunds = 0,
                            FundName = "Scholarship America",
                            Mission = "To mobilize America through scholarships and educational support to make post-secondary education possible for all students.",
                            NumberOfDonations = 0
                        });
                });

            modelBuilder.Entity("DoinGood.Models.Tasks", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("FundId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PosterCatalystId")
                        .HasColumnType("int");

                    b.Property<bool>("PosterComplete")
                        .HasColumnType("bit");

                    b.Property<int>("PosterValue")
                        .HasColumnType("int");

                    b.Property<string>("TaskDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TaskerCatalystId")
                        .HasColumnType("int");

                    b.Property<bool>("TaskerComplete")
                        .HasColumnType("bit");

                    b.Property<int?>("TaskerFundId")
                        .HasColumnType("int");

                    b.Property<int>("TaskerValue")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("TaskId");

                    b.HasIndex("FundId");

                    b.HasIndex("PosterCatalystId");

                    b.HasIndex("TaskerCatalystId");

                    b.HasIndex("TaskerFundId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "527225dc-db30-41ff-8b72-008aea72e009",
                            ConcurrencyStamp = "55c0dbf5-a0a7-4028-9709-de659d3c5b31",
                            Name = "Benefactor",
                            NormalizedName = "BENEFACTOR"
                        },
                        new
                        {
                            Id = "7c933095-5e65-4193-8c47-132f90898acc",
                            ConcurrencyStamp = "ce6c4fe3-a3de-49eb-a68e-e525ed34f882",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DoinGood.Models.Catalyst", b =>
                {
                    b.HasOne("DoinGood.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");

                    b.Navigation("Address");

                    b.Navigation("IdentityUser");
                });

            modelBuilder.Entity("DoinGood.Models.Challenge", b =>
                {
                    b.HasOne("DoinGood.Models.Catalyst", "ChallengeCatalyst")
                        .WithMany()
                        .HasForeignKey("ChallengeCatalystId");

                    b.HasOne("DoinGood.Models.Catalyst", "DeedCatalyst")
                        .WithMany()
                        .HasForeignKey("DeedCatalystId");

                    b.HasOne("DoinGood.Models.Fund", "Fund")
                        .WithMany()
                        .HasForeignKey("FundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChallengeCatalyst");

                    b.Navigation("DeedCatalyst");

                    b.Navigation("Fund");
                });

            modelBuilder.Entity("DoinGood.Models.Deed", b =>
                {
                    b.HasOne("DoinGood.Models.Catalyst", "Catalyst")
                        .WithMany()
                        .HasForeignKey("CatalystId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoinGood.Models.Fund", "Fund")
                        .WithMany()
                        .HasForeignKey("FundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Catalyst");

                    b.Navigation("Fund");
                });

            modelBuilder.Entity("DoinGood.Models.Donate", b =>
                {
                    b.HasOne("DoinGood.Models.Catalyst", "DonorCatalyst")
                        .WithMany()
                        .HasForeignKey("DonorCatalystId");

                    b.HasOne("DoinGood.Models.Fund", "Fund")
                        .WithMany()
                        .HasForeignKey("FundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoinGood.Models.Catalyst", "PosterCatalyst")
                        .WithMany()
                        .HasForeignKey("PosterCatalystId");

                    b.Navigation("DonorCatalyst");

                    b.Navigation("Fund");

                    b.Navigation("PosterCatalyst");
                });

            modelBuilder.Entity("DoinGood.Models.Tasks", b =>
                {
                    b.HasOne("DoinGood.Models.Fund", "Fund")
                        .WithMany()
                        .HasForeignKey("FundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoinGood.Models.Catalyst", "PosterCatalyst")
                        .WithMany()
                        .HasForeignKey("PosterCatalystId");

                    b.HasOne("DoinGood.Models.Catalyst", "TaskerCatalyst")
                        .WithMany()
                        .HasForeignKey("TaskerCatalystId");

                    b.HasOne("DoinGood.Models.Fund", "TaskerFund")
                        .WithMany()
                        .HasForeignKey("TaskerFundId");

                    b.Navigation("Fund");

                    b.Navigation("PosterCatalyst");

                    b.Navigation("TaskerCatalyst");

                    b.Navigation("TaskerFund");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
