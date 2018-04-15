﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using QAData;
using System;

namespace QAManagement.Migrations
{
    [DbContext(typeof(QADataContext))]
    [Migration("20180413203214_Add  intital entity models")]
    partial class Addintitalentitymodels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QAData.Models.CheckoutHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssetId");

                    b.Property<DateTime?>("InUse");

                    b.Property<DateTime>("NoUse");

                    b.Property<int>("QACardId");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("QACardId");

                    b.ToTable("CheckoutHistories");
                });

            modelBuilder.Entity("QAData.Models.Checkouts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssetId");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<int?>("QACardId");

                    b.Property<DateTime>("RecentUse");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("QACardId");

                    b.ToTable("Checkout");
                });

            modelBuilder.Entity("QAData.Models.Holds", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssetId");

                    b.Property<DateTime>("HoldPlaced");

                    b.Property<int?>("QACardId");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("QACardId");

                    b.ToTable("Hold");
                });

            modelBuilder.Entity("QAData.Models.Patron", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<int?>("QACardId");

                    b.Property<int?>("QAHomeId");

                    b.HasKey("id");

                    b.HasIndex("QACardId");

                    b.HasIndex("QAHomeId");

                    b.ToTable("Patrons");
                });

            modelBuilder.Entity("QAData.Models.QAAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssetId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DbName")
                        .IsRequired();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("LocUrl");

                    b.Property<int>("NumberOfDataSets");

                    b.Property<int?>("QABranchId");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("TcId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("QABranchId");

                    b.ToTable("QAAssets");

                    b.HasDiscriminator<string>("Discriminator").HasValue("QAAsset");
                });

            modelBuilder.Entity("QAData.Models.QABranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Description");

                    b.Property<string>("GoogleUrl");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime>("OpenDate");

                    b.Property<string>("Telephone")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("QABranch");
                });

            modelBuilder.Entity("QAData.Models.QACard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<int>("Qty");

                    b.HasKey("Id");

                    b.ToTable("QACard");
                });

            modelBuilder.Entity("QAData.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("QAData.Models.DataSets", b =>
                {
                    b.HasBaseType("QAData.Models.QAAsset");

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<string>("DataLoc")
                        .IsRequired();

                    b.Property<string>("QATCI")
                        .IsRequired();

                    b.ToTable("DataSets");

                    b.HasDiscriminator().HasValue("DataSets");
                });

            modelBuilder.Entity("QAData.Models.Video", b =>
                {
                    b.HasBaseType("QAData.Models.QAAsset");

                    b.Property<string>("Director")
                        .IsRequired();

                    b.ToTable("Video");

                    b.HasDiscriminator().HasValue("Video");
                });

            modelBuilder.Entity("QAData.Models.CheckoutHistory", b =>
                {
                    b.HasOne("QAData.Models.QAAsset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QAData.Models.QACard", "QACard")
                        .WithMany()
                        .HasForeignKey("QACardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QAData.Models.Checkouts", b =>
                {
                    b.HasOne("QAData.Models.QAAsset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QAData.Models.QACard", "QACard")
                        .WithMany("Checkout")
                        .HasForeignKey("QACardId");
                });

            modelBuilder.Entity("QAData.Models.Holds", b =>
                {
                    b.HasOne("QAData.Models.QAAsset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId");

                    b.HasOne("QAData.Models.QACard", "QACard")
                        .WithMany()
                        .HasForeignKey("QACardId");
                });

            modelBuilder.Entity("QAData.Models.Patron", b =>
                {
                    b.HasOne("QAData.Models.QACard", "QACard")
                        .WithMany()
                        .HasForeignKey("QACardId");

                    b.HasOne("QAData.Models.QABranch", "QAHome")
                        .WithMany("Patrons")
                        .HasForeignKey("QAHomeId");
                });

            modelBuilder.Entity("QAData.Models.QAAsset", b =>
                {
                    b.HasOne("QAData.Models.QAAsset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId");

                    b.HasOne("QAData.Models.QABranch")
                        .WithMany("QAAssets")
                        .HasForeignKey("QABranchId");
                });
#pragma warning restore 612, 618
        }
    }
}
