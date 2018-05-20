﻿// <auto-generated />
using AlbumApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace AlbumApp.Migrations
{
    [DbContext(typeof(AlbumContext))]
    [Migration("20180520215707_AddPlayerToAlbumContext")]
    partial class AddPlayerToAlbumContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("AlbumApp.Models.Country", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("AlbumApp.Models.Player", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Position");

                    b.HasKey("ID");

                    b.ToTable("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
