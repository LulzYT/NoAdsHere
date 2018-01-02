﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using NoAdsHere.Common;
using NoAdsHere.Database;
using System;

namespace NoAdsHere.Migrations
{
    [DbContext(typeof(NoAdsHereContext))]
    [Migration("20170901134522_Add_Guild_Settings")]
    partial class Add_Guild_Settings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-preview2-25794");

            modelBuilder.Entity("NoAdsHere.Database.Entities.Global.Master", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<ulong>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Masters");
                });

            modelBuilder.Entity("NoAdsHere.Database.Entities.Guild.Block", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlockType");

                    b.Property<ulong>("GuildId");

                    b.HasKey("Id");

                    b.ToTable("Blocks");
                });

            modelBuilder.Entity("NoAdsHere.Database.Entities.Guild.Faq", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<ulong>("CreatorId");

                    b.Property<ulong>("GuildId");

                    b.Property<DateTime>("LastUsed");

                    b.Property<string>("Name");

                    b.Property<uint>("UseCount");

                    b.HasKey("Id");

                    b.ToTable("Faqs");
                });

            modelBuilder.Entity("NoAdsHere.Database.Entities.Guild.Ignore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlockType");

                    b.Property<ulong>("GuildId");

                    b.Property<int>("IgnoreType");

                    b.Property<ulong>("IgnoredId");

                    b.Property<string>("IgnoredString");

                    b.HasKey("Id");

                    b.ToTable("Ignores");
                });

            modelBuilder.Entity("NoAdsHere.Database.Entities.Guild.Penalty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AutoDelete");

                    b.Property<ulong>("GuildId");

                    b.Property<string>("Message");

                    b.Property<int>("PenaltyType");

                    b.Property<int>("RequiredPoints");

                    b.HasKey("Id");

                    b.ToTable("Penalties");
                });

            modelBuilder.Entity("NoAdsHere.Database.Entities.Guild.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GithubRepo");

                    b.Property<ulong>("GuildId");

                    b.Property<string>("Prefix");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("NoAdsHere.Database.Entities.Guild.Statistic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<uint>("Bans");

                    b.Property<uint>("Blocks");

                    b.Property<ulong>("GuildId");

                    b.Property<uint>("Kicks");

                    b.Property<uint>("Warns");

                    b.HasKey("Id");

                    b.ToTable("Statistics");
                });

            modelBuilder.Entity("NoAdsHere.Database.Entities.Guild.Violator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<ulong>("GuildId");

                    b.Property<DateTime>("LatestViolation");

                    b.Property<int>("Points");

                    b.Property<ulong>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Violators");
                });
#pragma warning restore 612, 618
        }
    }
}
