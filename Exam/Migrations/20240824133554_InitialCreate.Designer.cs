﻿// <auto-generated />
using System;
using Exam.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exam.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240824133554_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("ExamSequence");

            modelBuilder.HasSequence("QuestionSequence");

            modelBuilder.Entity("Exam.Entities.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [ExamSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("Id"));

                    b.Property<int>("NumberOfQuestions")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("Exam.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [QuestionSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FinalExamId")
                        .HasColumnType("int");

                    b.Property<int>("Mark")
                        .HasColumnType("int");

                    b.Property<int?>("PracticalExamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FinalExamId");

                    b.HasIndex("PracticalExamId");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("Exam.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Subjects", (string)null);
                });

            modelBuilder.Entity("Exam.Entities.FinalExam", b =>
                {
                    b.HasBaseType("Exam.Entities.Exam");

                    b.ToTable("FinalExams");
                });

            modelBuilder.Entity("Exam.Entities.PracticalExam", b =>
                {
                    b.HasBaseType("Exam.Entities.Exam");

                    b.ToTable("PracticalExams");
                });

            modelBuilder.Entity("Exam.Entities.MCQQuestion", b =>
                {
                    b.HasBaseType("Exam.Entities.Question");

                    b.ToTable("MCQQuestions");
                });

            modelBuilder.Entity("Exam.Entities.TFQuestion", b =>
                {
                    b.HasBaseType("Exam.Entities.Question");

                    b.ToTable("TFQuestions");
                });

            modelBuilder.Entity("Exam.Entities.Exam", b =>
                {
                    b.HasOne("Exam.Entities.Subject", "Subject")
                        .WithMany("Exams")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Exam.Entities.Question", b =>
                {
                    b.HasOne("Exam.Entities.FinalExam", "FinalExam")
                        .WithMany("Questions")
                        .HasForeignKey("FinalExamId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Exam.Entities.PracticalExam", "PracticalExam")
                        .WithMany("Questions")
                        .HasForeignKey("PracticalExamId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("FinalExam");

                    b.Navigation("PracticalExam");
                });

            modelBuilder.Entity("Exam.Entities.Subject", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("Exam.Entities.FinalExam", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Exam.Entities.PracticalExam", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
