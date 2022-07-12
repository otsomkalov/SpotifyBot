﻿// <auto-generated />
namespace Bot.Migrations

open System
open Bot.Data
open Microsoft.EntityFrameworkCore
open Microsoft.EntityFrameworkCore.Infrastructure
open Microsoft.EntityFrameworkCore.Metadata
open Microsoft.EntityFrameworkCore.Migrations
open Microsoft.EntityFrameworkCore.Storage.ValueConversion
open Npgsql.EntityFrameworkCore.PostgreSQL.Metadata

[<DbContext(typeof<AppDbContext>)>]
type AppDbContextModelSnapshot() =
    inherit ModelSnapshot()

    override this.BuildModel(modelBuilder: ModelBuilder) =
        modelBuilder
            .HasAnnotation("ProductVersion", "6.0.6")
            .HasAnnotation("Relational:MaxIdentifierLength", 63) |> ignore

        modelBuilder.Entity("Bot.Data.User", (fun b ->

            b.Property<Int64>("Id")
                .IsRequired(true)
                .ValueGeneratedOnAdd()
                .HasColumnType("bigint")
                |> ignore

            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<Int64>("Id")) |> ignore

            b.Property<string>("SpotifyId")
                .IsRequired(true)
                .HasColumnType("text")
                |> ignore

            b.Property<string>("SpotifyRefreshToken")
                .IsRequired(true)
                .HasColumnType("text")
                |> ignore

            b.HasKey("Id")
                |> ignore


            b.ToTable("Users") |> ignore

        )) |> ignore

