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
    [Migration("20240824140732_MakeOneToManyAnswerQuestion")]
    partial class MakeOneToManyAnswerQuestion
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

            modelBuilder.Entity("Exam.Entities.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MCQQuestionId")
                        .HasColumnType("int");

                    b.Property<int?>("TFQuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("MCQQuestionId");

                    b.HasIndex("TFQuestionId");

                    b.ToTable("Answers", (string)null);
                });

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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "C# Basics"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Advanced C#"
                        },
                        new
                        {
                            Id = 3,
                            Name = "JavaScript Essentials"
                        },
                        new
                        {
                            Id = 4,
                            Name = "React Fundamentals"
                        },
                        new
                        {
                            Id = 5,
                            Name = "TypeScript for Beginners"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Python Programming"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Java Programming"
                        },
                        new
                        {
                            Id = 8,
                            Name = "SQL Basics"
                        },
                        new
                        {
                            Id = 9,
                            Name = "NoSQL Databases"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Data Structures"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Algorithms"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Web Development"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Mobile App Development"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Cloud Computing"
                        },
                        new
                        {
                            Id = 15,
                            Name = "DevOps Practices"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Cybersecurity Basics"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Machine Learning"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Artificial Intelligence"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Blockchain Technology"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Internet of Things (IoT)"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Kotlin for Android Development"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Swift Programming"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Ruby on Rails"
                        },
                        new
                        {
                            Id = 24,
                            Name = "PHP for Web Development"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Angular Development"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Vue.js Fundamentals"
                        });
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

            modelBuilder.Entity("Exam.Entities.Answer", b =>
                {
                    b.HasOne("Exam.Entities.MCQQuestion", "MCQQuestion")
                        .WithMany("Answers")
                        .HasForeignKey("MCQQuestionId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Exam.Entities.TFQuestion", "TFQuestion")
                        .WithMany("Answers")
                        .HasForeignKey("TFQuestionId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("MCQQuestion");

                    b.Navigation("TFQuestion");
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

            modelBuilder.Entity("Exam.Entities.MCQQuestion", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("Exam.Entities.TFQuestion", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
