﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestEFAsyncWPF.Model.Countries;

#nullable disable

namespace TestEFAsyncWPF.Migrations
{
    [DbContext(typeof(CountryContext))]
    [Migration("20220506160142_InitialCountries")]
    partial class InitialCountries
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("CountryCountry", b =>
                {
                    b.Property<int>("ConflictsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OpenCountriesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ConflictsId", "OpenCountriesId");

                    b.HasIndex("OpenCountriesId");

                    b.ToTable("CountryCountry");
                });

            modelBuilder.Entity("CountryEconomicUnion", b =>
                {
                    b.Property<int>("CountriesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EconomicUnionsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CountriesId", "EconomicUnionsId");

                    b.HasIndex("EconomicUnionsId");

                    b.ToTable("CountryEconomicUnion");
                });

            modelBuilder.Entity("CountryMilitaryUnion", b =>
                {
                    b.Property<int>("CountriesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MilitaryUnionsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CountriesId", "MilitaryUnionsId");

                    b.HasIndex("MilitaryUnionsId");

                    b.ToTable("CountryMilitaryUnion");
                });

            modelBuilder.Entity("TestEFAsyncWPF.Model.Countries.Continent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Continents");
                });

            modelBuilder.Entity("TestEFAsyncWPF.Model.Countries.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Capital")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ContinentId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("FoundationDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MeetInteractionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ContinentId");

                    b.HasIndex("MeetInteractionId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("TestEFAsyncWPF.Model.Countries.EconomicUnion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EconomicUnions");
                });

            modelBuilder.Entity("TestEFAsyncWPF.Model.Countries.Interaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Interactions");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Interaction");
                });

            modelBuilder.Entity("TestEFAsyncWPF.Model.Countries.MilitaryUnion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MilitaryUnions");
                });

            modelBuilder.Entity("TestEFAsyncWPF.Model.Countries.EconomicInteraction", b =>
                {
                    b.HasBaseType("TestEFAsyncWPF.Model.Countries.Interaction");

                    b.Property<int>("CountryBuyerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountrySellerId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Product")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasIndex("CountryBuyerId");

                    b.HasIndex("CountrySellerId");

                    b.HasDiscriminator().HasValue("EconomicInteraction");
                });

            modelBuilder.Entity("TestEFAsyncWPF.Model.Countries.MeetInteraction", b =>
                {
                    b.HasBaseType("TestEFAsyncWPF.Model.Countries.Interaction");

                    b.Property<int>("MeetCountryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasIndex("MeetCountryId");

                    b.HasDiscriminator().HasValue("MeetInteraction");
                });

            modelBuilder.Entity("CountryCountry", b =>
                {
                    b.HasOne("TestEFAsyncWPF.Model.Countries.Country", null)
                        .WithMany()
                        .HasForeignKey("ConflictsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestEFAsyncWPF.Model.Countries.Country", null)
                        .WithMany()
                        .HasForeignKey("OpenCountriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CountryEconomicUnion", b =>
                {
                    b.HasOne("TestEFAsyncWPF.Model.Countries.Country", null)
                        .WithMany()
                        .HasForeignKey("CountriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestEFAsyncWPF.Model.Countries.EconomicUnion", null)
                        .WithMany()
                        .HasForeignKey("EconomicUnionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CountryMilitaryUnion", b =>
                {
                    b.HasOne("TestEFAsyncWPF.Model.Countries.Country", null)
                        .WithMany()
                        .HasForeignKey("CountriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestEFAsyncWPF.Model.Countries.MilitaryUnion", null)
                        .WithMany()
                        .HasForeignKey("MilitaryUnionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestEFAsyncWPF.Model.Countries.Country", b =>
                {
                    b.HasOne("TestEFAsyncWPF.Model.Countries.Continent", "Continent")
                        .WithMany("Countries")
                        .HasForeignKey("ContinentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestEFAsyncWPF.Model.Countries.MeetInteraction", null)
                        .WithMany("Countries")
                        .HasForeignKey("MeetInteractionId");

                    b.OwnsOne("TestEFAsyncWPF.Model.Countries.GDP", "GDP", b1 =>
                        {
                            b1.Property<int>("CountryId")
                                .HasColumnType("INTEGER");

                            b1.Property<double>("Value")
                                .HasColumnType("REAL");

                            b1.HasKey("CountryId");

                            b1.ToTable("GDPs");

                            b1.WithOwner()
                                .HasForeignKey("CountryId");
                        });

                    b.Navigation("Continent");

                    b.Navigation("GDP")
                        .IsRequired();
                });

            modelBuilder.Entity("TestEFAsyncWPF.Model.Countries.EconomicInteraction", b =>
                {
                    b.HasOne("TestEFAsyncWPF.Model.Countries.Country", "CountryBuyer")
                        .WithMany()
                        .HasForeignKey("CountryBuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestEFAsyncWPF.Model.Countries.Country", "CountrySeller")
                        .WithMany()
                        .HasForeignKey("CountrySellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CountryBuyer");

                    b.Navigation("CountrySeller");
                });

            modelBuilder.Entity("TestEFAsyncWPF.Model.Countries.MeetInteraction", b =>
                {
                    b.HasOne("TestEFAsyncWPF.Model.Countries.Country", "MeetCountry")
                        .WithMany()
                        .HasForeignKey("MeetCountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MeetCountry");
                });

            modelBuilder.Entity("TestEFAsyncWPF.Model.Countries.Continent", b =>
                {
                    b.Navigation("Countries");
                });

            modelBuilder.Entity("TestEFAsyncWPF.Model.Countries.MeetInteraction", b =>
                {
                    b.Navigation("Countries");
                });
#pragma warning restore 612, 618
        }
    }
}
