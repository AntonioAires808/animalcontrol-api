﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using animalcontrol_webapi.Data;

namespace animalcontrol_webapi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210810000050_updateLT")]
    partial class updateLT
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("animalcontrol_webapi.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChipNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nickname")
                        .HasColumnType("TEXT");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 3,
                            ChipNumber = 1204151,
                            Name = "Ciri",
                            Nickname = "Cirigatas"
                        },
                        new
                        {
                            Id = 2,
                            Age = 1,
                            ChipNumber = 1204151,
                            Name = "Bali",
                            Nickname = "BaliWally"
                        },
                        new
                        {
                            Id = 3,
                            Age = 5,
                            ChipNumber = 1204151,
                            Name = "Flake",
                            Nickname = "Flakinho"
                        },
                        new
                        {
                            Id = 4,
                            Age = 5,
                            ChipNumber = 1204151,
                            Name = "Diesel",
                            Nickname = "N/A"
                        });
                });

            modelBuilder.Entity("animalcontrol_webapi.Models.AnimalLearning", b =>
                {
                    b.Property<int>("AnimalId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LearningTopicId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AnimalId", "LearningTopicId");

                    b.HasIndex("LearningTopicId");

                    b.ToTable("AnimalLearningTopics");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            LearningTopicId = 1
                        },
                        new
                        {
                            AnimalId = 1,
                            LearningTopicId = 2
                        },
                        new
                        {
                            AnimalId = 1,
                            LearningTopicId = 3
                        },
                        new
                        {
                            AnimalId = 1,
                            LearningTopicId = 4
                        },
                        new
                        {
                            AnimalId = 2,
                            LearningTopicId = 1
                        },
                        new
                        {
                            AnimalId = 2,
                            LearningTopicId = 2
                        },
                        new
                        {
                            AnimalId = 2,
                            LearningTopicId = 3
                        },
                        new
                        {
                            AnimalId = 2,
                            LearningTopicId = 4
                        },
                        new
                        {
                            AnimalId = 3,
                            LearningTopicId = 1
                        },
                        new
                        {
                            AnimalId = 3,
                            LearningTopicId = 2
                        },
                        new
                        {
                            AnimalId = 3,
                            LearningTopicId = 3
                        },
                        new
                        {
                            AnimalId = 3,
                            LearningTopicId = 4
                        },
                        new
                        {
                            AnimalId = 4,
                            LearningTopicId = 1
                        },
                        new
                        {
                            AnimalId = 4,
                            LearningTopicId = 2
                        },
                        new
                        {
                            AnimalId = 4,
                            LearningTopicId = 3
                        },
                        new
                        {
                            AnimalId = 4,
                            LearningTopicId = 4
                        });
                });

            modelBuilder.Entity("animalcontrol_webapi.Models.AnimalOwner", b =>
                {
                    b.Property<int>("AnimalId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OwnerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AnimalId", "OwnerId");

                    b.HasIndex("OwnerId");

                    b.ToTable("AnimalOwners");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            OwnerId = 1
                        },
                        new
                        {
                            AnimalId = 2,
                            OwnerId = 1
                        },
                        new
                        {
                            AnimalId = 3,
                            OwnerId = 2
                        },
                        new
                        {
                            AnimalId = 4,
                            OwnerId = 2
                        });
                });

            modelBuilder.Entity("animalcontrol_webapi.Models.LearningTopic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("OwnerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("LearningTopics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Food",
                            OwnerId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Walk",
                            OwnerId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sit",
                            OwnerId = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "Tricks",
                            OwnerId = 4
                        });
                });

            modelBuilder.Entity("animalcontrol_webapi.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Schedule")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Rua Dr",
                            Name = "Antonio",
                            Schedule = "9-18h"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Praceta Iv",
                            Name = "Susana",
                            Schedule = "9-18h"
                        },
                        new
                        {
                            Id = 3,
                            Address = "N/A",
                            Name = "RandomPerson",
                            Schedule = "9-18h"
                        },
                        new
                        {
                            Id = 4,
                            Address = "N/A",
                            Name = "RandomPerson2",
                            Schedule = "9-18h"
                        });
                });

            modelBuilder.Entity("animalcontrol_webapi.Models.Animal", b =>
                {
                    b.HasOne("animalcontrol_webapi.Models.Owner", "Owner")
                        .WithMany("Animals")
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("animalcontrol_webapi.Models.AnimalLearning", b =>
                {
                    b.HasOne("animalcontrol_webapi.Models.Animal", "Animal")
                        .WithMany("AnimalLearnings")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("animalcontrol_webapi.Models.LearningTopic", "LearningTopic")
                        .WithMany()
                        .HasForeignKey("LearningTopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("LearningTopic");
                });

            modelBuilder.Entity("animalcontrol_webapi.Models.AnimalOwner", b =>
                {
                    b.HasOne("animalcontrol_webapi.Models.Animal", "Animal")
                        .WithMany("AnimalOwners")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("animalcontrol_webapi.Models.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("animalcontrol_webapi.Models.LearningTopic", b =>
                {
                    b.HasOne("animalcontrol_webapi.Models.Owner", "Owner")
                        .WithMany("LearningTopics")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("animalcontrol_webapi.Models.Animal", b =>
                {
                    b.Navigation("AnimalLearnings");

                    b.Navigation("AnimalOwners");
                });

            modelBuilder.Entity("animalcontrol_webapi.Models.Owner", b =>
                {
                    b.Navigation("Animals");

                    b.Navigation("LearningTopics");
                });
#pragma warning restore 612, 618
        }
    }
}
