﻿// <auto-generated />
using System;
using Consumption.EFCore.Orm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Consumption.EFCore.Migrations
{
    [DbContext(typeof(ConsumptionContext))]
    partial class ConsumptionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.4.20220.10");

            modelBuilder.Entity("Consumption.Core.Entity.AuthItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AuthName")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthValue")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AuthItems");
                });

            modelBuilder.Entity("Consumption.Core.Entity.Basic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreateBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("EnglishName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastUpdateBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("NativeName")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeCode")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Basics");
                });

            modelBuilder.Entity("Consumption.Core.Entity.BasicType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TypeCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BasicTypes");
                });

            modelBuilder.Entity("Consumption.Core.Entity.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GroupCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Consumption.Core.Entity.GroupFunc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Auth")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GroupCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("MenuCode")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("GroupFuncs");
                });

            modelBuilder.Entity("Consumption.Core.Entity.GroupUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Account")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupCode")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("GroupUsers");
                });

            modelBuilder.Entity("Consumption.Core.Entity.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MenuAuth")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MenuCaption")
                        .HasColumnType("TEXT");

                    b.Property<string>("MenuCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("MenuName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MenuNameSpace")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Consumption.Core.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Account")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FlagAdmin")
                        .HasColumnType("TEXT");

                    b.Property<string>("FlagOnline")
                        .HasColumnType("TEXT");

                    b.Property<int>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastLoginTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastLogouTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("LoginCounter")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tel")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Consumption.Core.Entity.UserLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
