﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Slicesy.PizzaOrder.WebApi.Repositories;

namespace Slicesy.PizzaOrder.WebApi.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20200301163456_pizzeria")]
    partial class pizzeria
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Slicesy.PizzaOrder.WebApi.Repositories.Models.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("BuildingNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FlatNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Slicesy.PizzaOrder.WebApi.Repositories.Models.ContactData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AdditionalInfo")
                        .HasColumnType("text");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ContactData");
                });

            modelBuilder.Entity("Slicesy.PizzaOrder.WebApi.Repositories.Models.Ingredient", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long?>("CustomPizzaFreeIngredientsFK")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("PizzaIngredientsFK")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CustomPizzaFreeIngredientsFK");

                    b.HasIndex("PizzaIngredientsFK");

                    b.ToTable("Ingredient");
                });

            modelBuilder.Entity("Slicesy.PizzaOrder.WebApi.Repositories.Models.Pizza", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Available")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("PizzaPizzeriaFK")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<int>("PizzaType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PizzaPizzeriaFK");

                    b.ToTable("Pizza");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pizza");
                });

            modelBuilder.Entity("Slicesy.PizzaOrder.WebApi.Repositories.Models.Pizzeria", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("PizzeriaAddressFK")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<long?>("PizzeriaContactDataFK")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PizzeriaAddressFK");

                    b.HasIndex("PizzeriaContactDataFK");

                    b.ToTable("Pizzeria");
                });

            modelBuilder.Entity("Slicesy.PizzaOrder.WebApi.Repositories.Models.SizeAndPrice", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long?>("IngredientPricesFK")
                        .HasColumnType("bigint");

                    b.Property<long?>("PizzaPricesFK")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Size")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IngredientPricesFK");

                    b.HasIndex("PizzaPricesFK");

                    b.ToTable("SizeAndPrice");
                });

            modelBuilder.Entity("Slicesy.PizzaOrder.WebApi.Repositories.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("PermittedResourceId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("PizzaUser");
                });

            modelBuilder.Entity("Slicesy.PizzaOrder.WebApi.Repositories.Models.CustomPizza", b =>
                {
                    b.HasBaseType("Slicesy.PizzaOrder.WebApi.Repositories.Models.Pizza");

                    b.Property<int>("NumberOfFreeIngredients")
                        .HasColumnType("integer");

                    b.ToTable("CustomPizza");

                    b.HasDiscriminator().HasValue("CustomPizza");
                });

            modelBuilder.Entity("Slicesy.PizzaOrder.WebApi.Repositories.Models.Ingredient", b =>
                {
                    b.HasOne("Slicesy.PizzaOrder.WebApi.Repositories.Models.CustomPizza", null)
                        .WithMany("FreeIngredients")
                        .HasForeignKey("CustomPizzaFreeIngredientsFK");

                    b.HasOne("Slicesy.PizzaOrder.WebApi.Repositories.Models.Pizza", null)
                        .WithMany("AdditionalIngredients")
                        .HasForeignKey("PizzaIngredientsFK");
                });

            modelBuilder.Entity("Slicesy.PizzaOrder.WebApi.Repositories.Models.Pizza", b =>
                {
                    b.HasOne("Slicesy.PizzaOrder.WebApi.Repositories.Models.Pizzeria", "Pizzeria")
                        .WithMany()
                        .HasForeignKey("PizzaPizzeriaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Slicesy.PizzaOrder.WebApi.Repositories.Models.Pizzeria", b =>
                {
                    b.HasOne("Slicesy.PizzaOrder.WebApi.Repositories.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("PizzeriaAddressFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Slicesy.PizzaOrder.WebApi.Repositories.Models.ContactData", "ContactData")
                        .WithMany()
                        .HasForeignKey("PizzeriaContactDataFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Slicesy.PizzaOrder.WebApi.Repositories.Models.SizeAndPrice", b =>
                {
                    b.HasOne("Slicesy.PizzaOrder.WebApi.Repositories.Models.Ingredient", null)
                        .WithMany("Prices")
                        .HasForeignKey("IngredientPricesFK");

                    b.HasOne("Slicesy.PizzaOrder.WebApi.Repositories.Models.Pizza", null)
                        .WithMany("Prices")
                        .HasForeignKey("PizzaPricesFK");
                });
#pragma warning restore 612, 618
        }
    }
}
