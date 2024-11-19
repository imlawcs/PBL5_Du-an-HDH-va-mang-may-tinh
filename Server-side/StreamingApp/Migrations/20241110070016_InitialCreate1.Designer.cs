﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace StreamingApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241110070016_InitialCreate1")]
    partial class InitialCreate1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleDesc = "Admin",
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleDesc = "User",
                            RoleName = "User"
                        },
                        new
                        {
                            RoleId = 3,
                            RoleDesc = "Moderator",
                            RoleName = "Moderator"
                        });
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

                    b.Property<bool?>("IsEmailNoti")
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
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("UserStatus")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            DisplayName = "admin",
                            Email = "admin@gmail.com",
                            Password = "$2a$11$bJofIH.GvuqUrG9M/4P97OUTajXVLtWAu0rrJzp5/8bIwNCdY4yw.",
                            PhoneNumber = "1111111111",
                            RegisterDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "Admin Placeholder"
                        },
                        new
                        {
                            UserId = 2,
                            DisplayName = "Dao Le Hanh Nguyen",
                            Email = "daolehanhnguyen@gmail.com",
                            Password = "$2a$11$.tN.DuN2./elqSMRchtWZeCt93ovfJQgSRrqHEPzqkLD9KpjMwp22",
                            PhoneNumber = "0333414094",
                            RegisterDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "admin1"
                        },
                        new
                        {
                            UserId = 3,
                            DisplayName = "Huynh Thuy Minh Nguyet",
                            Email = "minhnguyetdn2004@gmail.com",
                            Password = "$2a$11$o5Wdw9jor0d2URi7JGRtF.EFv7owQUTrdKv/GE5oJiArUZBvHPzOK",
                            PhoneNumber = "0775500744",
                            RegisterDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "admin2"
                        },
                        new
                        {
                            UserId = 4,
                            DisplayName = "Nguyen Huu Khoa",
                            Email = "huukhoa04@gmail.com",
                            Password = "$2a$11$D16xD3Ut6AB2XSKB9E30F.VJHzsmLZcLyCxeaCDKUSK6SCGmEYRIC",
                            PhoneNumber = "0333414094",
                            RegisterDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "admin3"
                        });
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.User_Role", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("ChannelOwnerId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.HasKey("UserId", "RoleId", "ChannelOwnerId");

                    b.HasIndex("ChannelOwnerId");

                    b.HasIndex("RoleId");

                    b.ToTable("User_Roles");

                    b.HasData(
                        new
                        {
                            UserId = 2,
                            RoleId = 1,
                            ChannelOwnerId = 1
                        },
                        new
                        {
                            UserId = 3,
                            RoleId = 1,
                            ChannelOwnerId = 1
                        },
                        new
                        {
                            UserId = 4,
                            RoleId = 1,
                            ChannelOwnerId = 1
                        });
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

            modelBuilder.Entity("StreamingApp.Models.Entities.User_Role", b =>
                {
                    b.HasOne("StreamingApp.Models.Entities.User", "ChannelOwner")
                        .WithMany()
                        .HasForeignKey("ChannelOwnerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StreamingApp.Models.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StreamingApp.Models.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ChannelOwner");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("StreamingApp.Models.Entities.User", b =>
                {
                    b.Navigation("BlockedByUsers");

                    b.Navigation("BlockedUsers");

                    b.Navigation("Followers");

                    b.Navigation("Followings");

                    b.Navigation("Notifications");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
