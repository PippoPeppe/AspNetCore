using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AspNetCore.Data;

namespace AspNetCore.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20161112132717_Company")]
    partial class Company
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNetCore.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Email");

                    b.Property<bool>("IsInternal");

                    b.Property<bool>("IsValid");

                    b.Property<string>("Name");

                    b.Property<string>("Note");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("VatNumber");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });
        }
    }
}
