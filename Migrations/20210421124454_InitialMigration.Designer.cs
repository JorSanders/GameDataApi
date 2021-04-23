﻿// <auto-generated />
using System;
using Jorkol.GameDataApi.ApexLegends.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameDataApi.Migrations
{
    [DbContext(typeof(ApexDbContext))]
    [Migration("20210421124454_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Jorkol.GameDataApi.ApexLegends.Models.ApexAccount", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Platform")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ApexAccounts");
                });

            modelBuilder.Entity("Jorkol.GameDataApi.ApexLegends.Models.ApexCharacter", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long>("TrnId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("ApexCharacters");
                });

            modelBuilder.Entity("Jorkol.GameDataApi.ApexLegends.Models.ApexMatch", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("AccountId")
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("CharacterId")
                        .HasColumnType("varbinary(16)");

                    b.Property<long?>("Damage")
                        .HasColumnType("bigint");

                    b.Property<long?>("DomeDamageBlocked")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime");

                    b.Property<long?>("EyeEnemiesScanned")
                        .HasColumnType("bigint");

                    b.Property<long?>("Headshots")
                        .HasColumnType("bigint");

                    b.Property<long?>("Kills")
                        .HasColumnType("bigint");

                    b.Property<long?>("PlayerLevel")
                        .HasColumnType("bigint");

                    b.Property<long?>("RankScore")
                        .HasColumnType("bigint");

                    b.Property<long?>("RankScoreChange")
                        .HasColumnType("bigint");

                    b.Property<long?>("Revives")
                        .HasColumnType("bigint");

                    b.Property<long?>("RiftsSquadmatesPhased")
                        .HasColumnType("bigint");

                    b.Property<long?>("SmokeGrenadeEnemiesHit")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("TrnId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("CharacterId");

                    b.ToTable("ApexMatches");
                });

            modelBuilder.Entity("Jorkol.GameDataApi.ApexLegends.Models.ApexMatch", b =>
                {
                    b.HasOne("Jorkol.GameDataApi.ApexLegends.Models.ApexAccount", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("Jorkol.GameDataApi.ApexLegends.Models.ApexCharacter", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId");

                    b.Navigation("Account");

                    b.Navigation("Character");
                });
#pragma warning restore 612, 618
        }
    }
}