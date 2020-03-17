﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Data;

namespace Questionnaire.Migrations {
    [DbContext(typeof(QuestionsContext))]
    [Migration("20200316170528_InitialCreate")]
    partial class InitialCreate {
        protected override void BuildTargetModel(ModelBuilder modelBuilder) {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("models.Questions", b => {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<string>("FirstName")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<string>("LasteName")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.HasKey("ID");

                b.ToTable("Questions");
            });
#pragma warning restore 612, 618
        }
    }
}