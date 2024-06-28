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
    [Migration("20240628152402_FirstQuestionCheck")]
    partial class FirstQuestionCheck
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
                            Id = new Guid("482e7e4c-8f91-4673-8170-94508345329c"),
                            CorrectAnswerIndex = 1,
                            Explanation = "«Вынужденная остановка» - прекращение движения транспортного средства, связанное с его технической неисправностью, опасностью, создаваемой перевозимым грузом, состоянием водителя (пассажира) или появления препятствия на дороге. (Пункт 1.2 ПДД, термин «Вынужденная остановка»)",
                            Text = "В каком случае водитель совершит вынужденную остановку?"
                        },
                        new
                        {
                            Id = new Guid("1822492e-0f6a-46f1-b990-b5e14273b498"),
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
                            Id = new Guid("16d7b8d4-6632-47ad-bb74-4c99f2a4274f"),
                            QuestionId = new Guid("482e7e4c-8f91-4673-8170-94508345329c"),
                            Text = "Остановившись непосредственно перед пешеходным переходом, чтобы уступить дорогу пешеходу"
                        },
                        new
                        {
                            Id = new Guid("88e98d92-0990-4aef-b704-64147600dfff"),
                            QuestionId = new Guid("482e7e4c-8f91-4673-8170-94508345329c"),
                            Text = "Остановившись на проезжей части из-за технической неисправности транспортного средства"
                        },
                        new
                        {
                            Id = new Guid("ac11802b-6acc-4d97-b28b-4058cea47b2e"),
                            QuestionId = new Guid("482e7e4c-8f91-4673-8170-94508345329c"),
                            Text = "В обоих перечисленных случаях"
                        },
                        new
                        {
                            Id = new Guid("f1bcb6cf-d06e-4b0d-9af7-d08b81611908"),
                            QuestionId = new Guid("1822492e-0f6a-46f1-b990-b5e14273b498"),
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
