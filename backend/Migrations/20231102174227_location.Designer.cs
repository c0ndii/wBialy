﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wBialy.Entities;

#nullable disable

namespace wBialy.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231102174227_location")]
    partial class location
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventPostEventTag", b =>
                {
                    b.Property<int>("PostsPostId")
                        .HasColumnType("int");

                    b.Property<int>("TagsTagId")
                        .HasColumnType("int");

                    b.HasKey("PostsPostId", "TagsTagId");

                    b.HasIndex("TagsTagId");

                    b.ToTable("EventPostEventTag");
                });

            modelBuilder.Entity("GastroPostGastroTag", b =>
                {
                    b.Property<int>("PostsPostId")
                        .HasColumnType("int");

                    b.Property<int>("TagsTagId")
                        .HasColumnType("int");

                    b.HasKey("PostsPostId", "TagsTagId");

                    b.HasIndex("TagsTagId");

                    b.ToTable("GastroPostGastroTag");
                });

            modelBuilder.Entity("LFPostLFTag", b =>
                {
                    b.Property<int>("PostsPostId")
                        .HasColumnType("int");

                    b.Property<int>("TagsTagId")
                        .HasColumnType("int");

                    b.HasKey("PostsPostId", "TagsTagId");

                    b.HasIndex("TagsTagId");

                    b.ToTable("LFPostLFTag");
                });

            modelBuilder.Entity("wBialy.Entities.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"));

                    b.Property<DateTime>("AddDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Confirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("wBialy.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("wBialy.Entities.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"));

                    b.HasKey("TagId");

                    b.ToTable("Tags");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("wBialy.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("wBialy.Entities.LFPost", b =>
                {
                    b.HasBaseType("wBialy.Entities.Post");

                    b.ToTable("LFPosts");
                });

            modelBuilder.Entity("wBialy.Entities.OnSitePost", b =>
                {
                    b.HasBaseType("wBialy.Entities.Post");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("OnSitePosts");
                });

            modelBuilder.Entity("wBialy.Entities.EventTag", b =>
                {
                    b.HasBaseType("wBialy.Entities.Tag");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.ToTable("EventTags");
                });

            modelBuilder.Entity("wBialy.Entities.GastroTag", b =>
                {
                    b.HasBaseType("wBialy.Entities.Tag");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.ToTable("GastroTags");
                });

            modelBuilder.Entity("wBialy.Entities.LFTag", b =>
                {
                    b.HasBaseType("wBialy.Entities.Tag");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.ToTable("LFTags");
                });

            modelBuilder.Entity("wBialy.Entities.EventPost", b =>
                {
                    b.HasBaseType("wBialy.Entities.OnSitePost");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.ToTable("EventPosts");
                });

            modelBuilder.Entity("wBialy.Entities.GastroPost", b =>
                {
                    b.HasBaseType("wBialy.Entities.OnSitePost");

                    b.Property<DateTime>("Day")
                        .HasColumnType("datetime2");

                    b.ToTable("GastroPosts");
                });

            modelBuilder.Entity("EventPostEventTag", b =>
                {
                    b.HasOne("wBialy.Entities.EventPost", null)
                        .WithMany()
                        .HasForeignKey("PostsPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wBialy.Entities.EventTag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GastroPostGastroTag", b =>
                {
                    b.HasOne("wBialy.Entities.GastroPost", null)
                        .WithMany()
                        .HasForeignKey("PostsPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wBialy.Entities.GastroTag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LFPostLFTag", b =>
                {
                    b.HasOne("wBialy.Entities.LFPost", null)
                        .WithMany()
                        .HasForeignKey("PostsPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wBialy.Entities.LFTag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("wBialy.Entities.Post", b =>
                {
                    b.HasOne("wBialy.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("wBialy.Entities.User", b =>
                {
                    b.HasOne("wBialy.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("wBialy.Entities.LFPost", b =>
                {
                    b.HasOne("wBialy.Entities.Post", null)
                        .WithOne()
                        .HasForeignKey("wBialy.Entities.LFPost", "PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("wBialy.Entities.OnSitePost", b =>
                {
                    b.HasOne("wBialy.Entities.Post", null)
                        .WithOne()
                        .HasForeignKey("wBialy.Entities.OnSitePost", "PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("wBialy.Entities.EventTag", b =>
                {
                    b.HasOne("wBialy.Entities.Tag", null)
                        .WithOne()
                        .HasForeignKey("wBialy.Entities.EventTag", "TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("wBialy.Entities.GastroTag", b =>
                {
                    b.HasOne("wBialy.Entities.Tag", null)
                        .WithOne()
                        .HasForeignKey("wBialy.Entities.GastroTag", "TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("wBialy.Entities.LFTag", b =>
                {
                    b.HasOne("wBialy.Entities.Tag", null)
                        .WithOne()
                        .HasForeignKey("wBialy.Entities.LFTag", "TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("wBialy.Entities.EventPost", b =>
                {
                    b.HasOne("wBialy.Entities.OnSitePost", null)
                        .WithOne()
                        .HasForeignKey("wBialy.Entities.EventPost", "PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("wBialy.Entities.GastroPost", b =>
                {
                    b.HasOne("wBialy.Entities.OnSitePost", null)
                        .WithOne()
                        .HasForeignKey("wBialy.Entities.GastroPost", "PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
