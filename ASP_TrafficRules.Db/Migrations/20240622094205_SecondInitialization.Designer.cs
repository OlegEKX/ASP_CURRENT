﻿// <auto-generated />
using System;
using ASP_TrafficRules.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP_TrafficRules.Db.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20240622094205_SecondInitialization")]
    partial class SecondInitialization
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASP_TrafficRules.Db.Models.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CorrectAnswerIndex")
                        .HasColumnType("int");

                    b.Property<string>("Explanation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0a8d907c-e384-4198-bcff-60a9265da009"),
                            CorrectAnswerIndex = 1,
                            Explanation = "Объяснение для вопроса 1",
                            Text = "Вопрос 1"
                        },
                        new
                        {
                            Id = new Guid("77ed9f93-7122-46e7-9807-e79b389463fe"),
                            CorrectAnswerIndex = 1,
                            Explanation = "Объяснение для вопроса 2",
                            Text = "Вопрос 2"
                        });
                });

            modelBuilder.Entity("ASP_TrafficRules.Db.Models.QuestionOptions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionOptions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f989844f-cc68-4bcb-b909-5d0569ae4d35"),
                            QuestionId = new Guid("0a8d907c-e384-4198-bcff-60a9265da009"),
                            Text = "Ответ 1 на вопрос 1"
                        },
                        new
                        {
                            Id = new Guid("9924494e-5640-431e-8b76-65c9b2cdb6b1"),
                            QuestionId = new Guid("0a8d907c-e384-4198-bcff-60a9265da009"),
                            Text = "Ответ 2 на вопрос 1"
                        },
                        new
                        {
                            Id = new Guid("e342eb94-bc80-4ce5-979d-f9a08ccd32f7"),
                            QuestionId = new Guid("77ed9f93-7122-46e7-9807-e79b389463fe"),
                            Text = "Ответ 1 на вопрос 2"
                        },
                        new
                        {
                            Id = new Guid("e0688308-a24a-4ea0-a0de-99dc9314899e"),
                            QuestionId = new Guid("77ed9f93-7122-46e7-9807-e79b389463fe"),
                            Text = "Ответ 2 на вопрос 2"
                        });
                });

            modelBuilder.Entity("ASP_TrafficRules.Db.Models.QuestionOptions", b =>
                {
                    b.HasOne("ASP_TrafficRules.Db.Models.Question", "Question")
                        .WithMany("QuestionOptions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("ASP_TrafficRules.Db.Models.Question", b =>
                {
                    b.Navigation("QuestionOptions");
                });
#pragma warning restore 612, 618
        }
    }
}
