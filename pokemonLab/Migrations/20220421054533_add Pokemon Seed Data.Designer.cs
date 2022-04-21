﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pokemonLab.Models;

namespace pokemonLab.Migrations
{
    [DbContext(typeof(PokemonContext))]
    [Migration("20220421054533_add Pokemon Seed Data")]
    partial class addPokemonSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_BIN")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("pokemonLab.Models.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Attack")
                        .HasColumnType("decimal(18,0)");

                    b.Property<decimal>("Defanse")
                        .HasColumnType("decimal(18,0)");

                    b.Property<decimal>("Hp")
                        .HasColumnType("decimal(18,0)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NickName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("SpAttack")
                        .HasColumnType("decimal(18,0)");

                    b.Property<decimal>("SpDefense")
                        .HasColumnType("decimal(18,0)");

                    b.Property<decimal>("Speed")
                        .HasColumnType("decimal(18,0)");

                    b.Property<string>("Type")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Pokemon");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Attack = 49m,
                            Defanse = 49m,
                            Hp = 45m,
                            Image = "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/001.png",
                            Name = "妙蛙種子",
                            NickName = "哇草",
                            SpAttack = 65m,
                            SpDefense = 65m,
                            Speed = 45m,
                            Type = "種子寶可夢"
                        },
                        new
                        {
                            Id = 2,
                            Attack = 62m,
                            Defanse = 63m,
                            Hp = 60m,
                            Image = "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/002.png",
                            Name = "妙蛙草",
                            NickName = "哇草哇草",
                            SpAttack = 80m,
                            SpDefense = 80m,
                            Speed = 60m,
                            Type = "種子寶可夢"
                        },
                        new
                        {
                            Id = 8,
                            Attack = 55m,
                            Defanse = 40m,
                            Hp = 35m,
                            Image = "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/025.png",
                            Name = "皮卡丘",
                            NickName = "皮皮",
                            SpAttack = 55m,
                            SpDefense = 50m,
                            Speed = 90m,
                            Type = "鼠寶可夢"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
