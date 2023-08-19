﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using back_end.Contexts;

#nullable disable

namespace back_end.Migrations
{
    [DbContext(typeof(ChatApplicationDb))]
    partial class ChatApplicationDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("back_end.Entities.Account", b =>
                {
                    b.Property<int>("account_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("account_id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("firstname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("account_id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("back_end.Entities.Friend", b =>
                {
                    b.Property<int>("friend_list_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("friend_list_id"));

                    b.Property<int?>("account_id")
                        .HasColumnType("integer");

                    b.Property<int>("friend_id")
                        .HasColumnType("integer");

                    b.HasKey("friend_list_id");

                    b.HasIndex("account_id");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("back_end.Entities.Friend", b =>
                {
                    b.HasOne("back_end.Entities.Account", "account")
                        .WithMany()
                        .HasForeignKey("account_id");

                    b.Navigation("account");
                });
#pragma warning restore 612, 618
        }
    }
}
