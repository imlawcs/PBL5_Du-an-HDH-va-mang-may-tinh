﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace StreamingApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StreamingApp.Models.Entities.Blocked", b =>
                {
                    b.Property<int>("BlockerId")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("BlockedId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.HasKey("BlockerId", "BlockedId");

                    b.HasIndex("BlockedId");

                    b.ToTable("Blockeds");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryDesc")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.Following", b =>
                {
                    b.Property<int>("FollowerId")
                        .HasColumnType("int");

                    b.Property<int>("FolloweeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsMuted")
                        .HasColumnType("bit");

                    b.HasKey("FollowerId", "FolloweeId");

                    b.HasIndex("FolloweeId");

                    b.ToTable("Followings");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.Moderator", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("UserIdModerator")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.HasKey("UserId", "UserIdModerator");

                    b.HasIndex("UserIdModerator");

                    b.ToTable("Moderators");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("NotiDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NotiDesc")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("StreamId")
                        .HasColumnType("int");

                    b.Property<int?>("StreamerUserId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StreamerUserId");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleDesc")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.Stream", b =>
                {
                    b.Property<int>("StreamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StreamId"));

                    b.Property<bool>("IsLive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StreamDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StreamDesc")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("StreamTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("StreamId");

                    b.HasIndex("UserId");

                    b.ToTable("Streams");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.StreamCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("StreamId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "StreamId");

                    b.HasIndex("StreamId");

                    b.ToTable("StreamCategories");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.StreamTag", b =>
                {
                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<int>("StreamId")
                        .HasColumnType("int");

                    b.HasKey("TagId", "StreamId");

                    b.HasIndex("StreamId");

                    b.ToTable("StreamTags");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"));

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("TagId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsEmailNoti")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProfilePic")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("UserStatus")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.Blocked", b =>
                {
                    b.HasOne("StreamingApp.Models.Entities.User", "BlockedUser")
                        .WithMany("BlockedByUsers")
                        .HasForeignKey("BlockedId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StreamingApp.Models.Entities.User", "Blocker")
                        .WithMany("BlockedUsers")
                        .HasForeignKey("BlockerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BlockedUser");

                    b.Navigation("Blocker");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.Following", b =>
                {
                    b.HasOne("StreamingApp.Models.Entities.User", "Followee")
                        .WithMany("Followers")
                        .HasForeignKey("FolloweeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StreamingApp.Models.Entities.User", "Follower")
                        .WithMany("Followings")
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Followee");

                    b.Navigation("Follower");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.Moderator", b =>
                {
                    b.HasOne("StreamingApp.Models.Entities.User", "User")
                        .WithMany("ModeratorOf")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StreamingApp.Models.Entities.User", "ModeratorUser")
                        .WithMany("Moderators")
                        .HasForeignKey("UserIdModerator")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ModeratorUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.Notification", b =>
                {
                    b.HasOne("StreamingApp.Models.Entities.User", "Streamer")
                        .WithMany()
                        .HasForeignKey("StreamerUserId");

                    b.HasOne("StreamingApp.Models.Entities.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Streamer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.Stream", b =>
                {
                    b.HasOne("StreamingApp.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.StreamCategory", b =>
                {
                    b.HasOne("StreamingApp.Models.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StreamingApp.Models.Entities.Stream", "Stream")
                        .WithMany()
                        .HasForeignKey("StreamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Stream");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.StreamTag", b =>
                {
                    b.HasOne("StreamingApp.Models.Entities.Stream", "Stream")
                        .WithMany()
                        .HasForeignKey("StreamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StreamingApp.Models.Entities.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stream");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.User", b =>
                {
                    b.HasOne("StreamingApp.Models.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.User", b =>
                {
                    b.Navigation("BlockedByUsers");

                    b.Navigation("BlockedUsers");

                    b.Navigation("Followers");

                    b.Navigation("Followings");

                    b.Navigation("ModeratorOf");

                    b.Navigation("Moderators");

                    b.Navigation("Notifications");
                });
#pragma warning restore 612, 618
        }
    }
}
