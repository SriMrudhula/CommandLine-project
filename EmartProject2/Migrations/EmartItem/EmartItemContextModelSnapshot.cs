﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmartProject2.Migrations.EmartItem
{
    [DbContext(typeof(EmartItemContext))]
    partial class EmartItemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmartProject2.Models.Item", b =>
                {
                    b.Property<int>("Ino")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cid")
                        .HasColumnType("int");

                    b.Property<string>("Cname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Noi")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Scid")
                        .HasColumnType("int");

                    b.Property<string>("Scname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ino");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("EmartProject2.Models.SubCategory", b =>
                {
                    b.Property<int>("Scid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cid")
                        .HasColumnType("int");

                    b.Property<string>("Cname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Scname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Scid");

                    b.ToTable("SubCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
