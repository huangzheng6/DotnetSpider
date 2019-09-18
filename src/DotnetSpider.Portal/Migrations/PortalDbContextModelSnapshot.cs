﻿// <auto-generated />
using System;
using DotnetSpider.Portal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotnetSpider.Portal.Migrations
{
    [DbContext(typeof(PortalDbContext))]
    partial class PortalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DotnetSpider.Portal.Entity.DockerRepository", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("CreationTime")
                        .HasColumnName("creation_time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(255);

                    b.Property<string>("Password")
                        .HasColumnName("password")
                        .HasMaxLength(255);

                    b.Property<string>("Registry")
                        .HasColumnName("registry")
                        .HasMaxLength(255);

                    b.Property<string>("Repository")
                        .IsRequired()
                        .HasColumnName("repository")
                        .HasMaxLength(255);

                    b.Property<string>("Schema")
                        .HasColumnName("schema")
                        .HasMaxLength(10);

                    b.Property<string>("UserName")
                        .HasColumnName("user_name")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CreationTime");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Repository", "Registry")
                        .IsUnique();

                    b.ToTable("docker_repository");
                });

            modelBuilder.Entity("DotnetSpider.Portal.Entity.Spider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("CreationTime")
                        .HasColumnName("creation_time");

                    b.Property<string>("Cron")
                        .IsRequired()
                        .HasColumnName("cron")
                        .HasMaxLength(255);

                    b.Property<bool>("Enable");

                    b.Property<string>("Environment")
                        .HasColumnName("environment")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset>("LastModificationTime")
                        .HasColumnName("last_modification_time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(255);

                    b.Property<string>("Registry")
                        .HasColumnName("registry")
                        .HasMaxLength(255);

                    b.Property<string>("Repository")
                        .IsRequired()
                        .HasColumnName("repository")
                        .HasMaxLength(255);

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnName("tag")
                        .HasMaxLength(255);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasMaxLength(400);

                    b.HasKey("Id");

                    b.HasIndex("CreationTime");

                    b.HasIndex("Name");

                    b.ToTable("spider");
                });

            modelBuilder.Entity("DotnetSpider.Portal.Entity.SpiderContainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Batch")
                        .HasColumnName("batch")
                        .HasMaxLength(100);

                    b.Property<string>("ContainerId")
                        .HasColumnName("container_id")
                        .HasMaxLength(100);

                    b.Property<DateTimeOffset>("CreationTime")
                        .HasColumnName("creation_time");

                    b.Property<int>("SpiderId")
                        .HasColumnName("spider_id");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnName("status")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("Batch");

                    b.HasIndex("CreationTime");

                    b.HasIndex("SpiderId");

                    b.ToTable("spider_container");
                });
#pragma warning restore 612, 618
        }
    }
}
