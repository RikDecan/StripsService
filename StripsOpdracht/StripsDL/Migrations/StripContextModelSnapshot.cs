﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StripsDL;

#nullable disable

namespace StripsDL.Migrations
{
    [DbContext(typeof(StripContext))]
    partial class StripContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuteurEFStripEF", b =>
                {
                    b.Property<int>("AuteursId")
                        .HasColumnType("int");

                    b.Property<int>("StripsId")
                        .HasColumnType("int");

                    b.HasKey("AuteursId", "StripsId");

                    b.HasIndex("StripsId");

                    b.ToTable("AuteurEFStripEF");
                });

            modelBuilder.Entity("StripsDL.Models.AuteurEF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailAdres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Auteurs");
                });

            modelBuilder.Entity("StripsDL.Models.ReeksEF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reeksen");
                });

            modelBuilder.Entity("StripsDL.Models.StripEF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ReeksId")
                        .HasColumnType("int");

                    b.Property<int>("ReeksNr")
                        .HasColumnType("int");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UitgeverijId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReeksId");

                    b.HasIndex("UitgeverijId");

                    b.ToTable("Strips");
                });

            modelBuilder.Entity("StripsDL.Models.UitgeverijEF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Uitgeverijen");
                });

            modelBuilder.Entity("AuteurEFStripEF", b =>
                {
                    b.HasOne("StripsDL.Models.AuteurEF", null)
                        .WithMany()
                        .HasForeignKey("AuteursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StripsDL.Models.StripEF", null)
                        .WithMany()
                        .HasForeignKey("StripsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StripsDL.Models.StripEF", b =>
                {
                    b.HasOne("StripsDL.Models.ReeksEF", "Reeks")
                        .WithMany("Strips")
                        .HasForeignKey("ReeksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StripsDL.Models.UitgeverijEF", "Uitgeverij")
                        .WithMany("Strips")
                        .HasForeignKey("UitgeverijId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reeks");

                    b.Navigation("Uitgeverij");
                });

            modelBuilder.Entity("StripsDL.Models.ReeksEF", b =>
                {
                    b.Navigation("Strips");
                });

            modelBuilder.Entity("StripsDL.Models.UitgeverijEF", b =>
                {
                    b.Navigation("Strips");
                });
#pragma warning restore 612, 618
        }
    }
}
