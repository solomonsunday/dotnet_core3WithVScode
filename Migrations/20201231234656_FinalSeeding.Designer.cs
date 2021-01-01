﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using netCore3.Data;

namespace netCore3._1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201231234656_FinalSeeding")]
    partial class FinalSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("netCore3.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Class")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defeats")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defence")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fights")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hitpoint")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Strength")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Victories")
                        .HasColumnType("INTEGER");

                    b.Property<int>("intelligence")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Class = 1,
                            Defeats = 0,
                            Defence = 10,
                            Fights = 0,
                            Hitpoint = 100,
                            Name = "Frodo",
                            Strength = 15,
                            UserId = 1,
                            Victories = 0,
                            intelligence = 10
                        },
                        new
                        {
                            Id = 2,
                            Class = 2,
                            Defeats = 0,
                            Defence = 5,
                            Fights = 0,
                            Hitpoint = 100,
                            Name = "Raistlin",
                            Strength = 5,
                            UserId = 2,
                            Victories = 0,
                            intelligence = 20
                        });
                });

            modelBuilder.Entity("netCore3.Models.CharacterSkill", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SkillId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CharacterId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("CharacterSkills");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            SkillId = 2
                        },
                        new
                        {
                            CharacterId = 2,
                            SkillId = 1
                        },
                        new
                        {
                            CharacterId = 2,
                            SkillId = 3
                        });
                });

            modelBuilder.Entity("netCore3.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Damage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Damage = 30,
                            Name = "Fireball"
                        },
                        new
                        {
                            Id = 2,
                            Damage = 20,
                            Name = "Frenzy"
                        },
                        new
                        {
                            Id = 3,
                            Damage = 50,
                            Name = "Blizzard"
                        });
                });

            modelBuilder.Entity("netCore3.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("Role")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue("Player");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PasswordHash = new byte[] { 112, 37, 97, 238, 11, 73, 152, 3, 214, 64, 160, 71, 174, 60, 110, 69, 40, 193, 145, 239, 58, 179, 16, 215, 126, 151, 230, 54, 135, 102, 150, 147, 102, 149, 85, 199, 37, 166, 118, 141, 149, 26, 249, 116, 164, 250, 144, 173, 0, 227, 170, 185, 177, 64, 243, 222, 153, 2, 143, 224, 113, 154, 202, 134 },
                            PasswordSalt = new byte[] { 105, 96, 43, 237, 231, 253, 16, 86, 186, 119, 1, 206, 80, 238, 164, 73, 250, 115, 24, 213, 134, 66, 201, 21, 249, 48, 154, 41, 172, 193, 115, 190, 126, 255, 65, 167, 50, 220, 191, 17, 117, 60, 58, 25, 233, 32, 48, 215, 152, 236, 30, 80, 231, 207, 249, 17, 52, 116, 55, 74, 18, 149, 40, 89, 242, 163, 26, 69, 168, 214, 131, 101, 133, 239, 80, 84, 121, 142, 217, 70, 239, 81, 11, 36, 141, 166, 88, 50, 168, 47, 18, 25, 115, 67, 22, 149, 149, 116, 141, 209, 42, 68, 44, 1, 2, 144, 173, 60, 112, 130, 242, 210, 123, 23, 53, 155, 36, 14, 79, 84, 40, 108, 141, 55, 158, 119, 164, 213 },
                            Username = "User1"
                        },
                        new
                        {
                            Id = 2,
                            PasswordHash = new byte[] { 112, 37, 97, 238, 11, 73, 152, 3, 214, 64, 160, 71, 174, 60, 110, 69, 40, 193, 145, 239, 58, 179, 16, 215, 126, 151, 230, 54, 135, 102, 150, 147, 102, 149, 85, 199, 37, 166, 118, 141, 149, 26, 249, 116, 164, 250, 144, 173, 0, 227, 170, 185, 177, 64, 243, 222, 153, 2, 143, 224, 113, 154, 202, 134 },
                            PasswordSalt = new byte[] { 105, 96, 43, 237, 231, 253, 16, 86, 186, 119, 1, 206, 80, 238, 164, 73, 250, 115, 24, 213, 134, 66, 201, 21, 249, 48, 154, 41, 172, 193, 115, 190, 126, 255, 65, 167, 50, 220, 191, 17, 117, 60, 58, 25, 233, 32, 48, 215, 152, 236, 30, 80, 231, 207, 249, 17, 52, 116, 55, 74, 18, 149, 40, 89, 242, 163, 26, 69, 168, 214, 131, 101, 133, 239, 80, 84, 121, 142, 217, 70, 239, 81, 11, 36, 141, 166, 88, 50, 168, 47, 18, 25, 115, 67, 22, 149, 149, 116, 141, 209, 42, 68, 44, 1, 2, 144, 173, 60, 112, 130, 242, 210, 123, 23, 53, 155, 36, 14, 79, 84, 40, 108, 141, 55, 158, 119, 164, 213 },
                            Username = "User2"
                        });
                });

            modelBuilder.Entity("netCore3.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Damage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Weapons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CharacterId = 1,
                            Damage = 20,
                            Name = "The Master Sword"
                        },
                        new
                        {
                            Id = 2,
                            CharacterId = 2,
                            Damage = 20,
                            Name = "Crystal Wand"
                        });
                });

            modelBuilder.Entity("netCore3.Models.Character", b =>
                {
                    b.HasOne("netCore3.Models.User", "User")
                        .WithMany("Characters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("netCore3.Models.CharacterSkill", b =>
                {
                    b.HasOne("netCore3.Models.Character", "Character")
                        .WithMany("CharacterSkills")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("netCore3.Models.Skill", "Skill")
                        .WithMany("CharacterSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("netCore3.Models.Weapon", b =>
                {
                    b.HasOne("netCore3.Models.Character", "Character")
                        .WithOne("Weapon")
                        .HasForeignKey("netCore3.Models.Weapon", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("netCore3.Models.Character", b =>
                {
                    b.Navigation("CharacterSkills");

                    b.Navigation("Weapon");
                });

            modelBuilder.Entity("netCore3.Models.Skill", b =>
                {
                    b.Navigation("CharacterSkills");
                });

            modelBuilder.Entity("netCore3.Models.User", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
