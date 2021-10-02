﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TodoWebApp.DAL;

namespace TodoWebApp.DAL.Migrations
{
    [DbContext(typeof(TodoWebAppDbContext))]
    [Migration("20211001211733_NewTodoList")]
    partial class NewTodoList
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("TodoWebApp.CORE.TodoItem", b =>
                {
                    b.Property<int>("TodoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("IsComplete")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("TodoID");

                    b.ToTable("TodoItems");

                    b.HasData(
                        new
                        {
                            TodoID = 1,
                            IsComplete = false,
                            Name = "Go Running"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
