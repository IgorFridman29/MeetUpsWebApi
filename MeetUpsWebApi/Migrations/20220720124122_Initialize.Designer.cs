﻿// <auto-generated />
using System;
using MeetUpsWebApi.DataMembers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MeetUpsWebApi.Migrations
{
    [DbContext(typeof(MeetUpDbContext))]
    [Migration("20220720124122_Initialize")]
    partial class Initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MeetUpsWebApi.DTOs.LessonDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.Property<int>("MeetUpId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LecturerId")
                        .IsUnique();

                    b.HasIndex("MeetUpId");

                    b.ToTable("LessonDTO");
                });

            modelBuilder.Entity("MeetUpsWebApi.DTOs.MeetUpDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MeetUpDTO");
                });

            modelBuilder.Entity("MeetUpsWebApi.DataMembers.Lecturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Lecturer");
                });

            modelBuilder.Entity("MeetUpsWebApi.DataMembers.LecturerDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("MeetUpsWebApi.DataMembers.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.Property<int>("MeetUpId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Topic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LecturerId")
                        .IsUnique();

                    b.HasIndex("MeetUpId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("MeetUpsWebApi.DataMembers.MeetUp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MeetUps");
                });

            modelBuilder.Entity("MeetUpsWebApi.DTOs.LessonDTO", b =>
                {
                    b.HasOne("MeetUpsWebApi.DataMembers.LecturerDTO", "Lecturer")
                        .WithOne("Lesson")
                        .HasForeignKey("MeetUpsWebApi.DTOs.LessonDTO", "LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeetUpsWebApi.DTOs.MeetUpDTO", "MeetUp")
                        .WithMany("Lessons")
                        .HasForeignKey("MeetUpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lecturer");

                    b.Navigation("MeetUp");
                });

            modelBuilder.Entity("MeetUpsWebApi.DataMembers.Lesson", b =>
                {
                    b.HasOne("MeetUpsWebApi.DataMembers.Lecturer", "Lecturer")
                        .WithOne("Lesson")
                        .HasForeignKey("MeetUpsWebApi.DataMembers.Lesson", "LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeetUpsWebApi.DataMembers.MeetUp", "MeetUp")
                        .WithMany("Lessons")
                        .HasForeignKey("MeetUpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lecturer");

                    b.Navigation("MeetUp");
                });

            modelBuilder.Entity("MeetUpsWebApi.DTOs.MeetUpDTO", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("MeetUpsWebApi.DataMembers.Lecturer", b =>
                {
                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("MeetUpsWebApi.DataMembers.LecturerDTO", b =>
                {
                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("MeetUpsWebApi.DataMembers.MeetUp", b =>
                {
                    b.Navigation("Lessons");
                });
#pragma warning restore 612, 618
        }
    }
}
