using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using BooksServiceSample.Models;

namespace BookServiceAsyncSample.Migrations
{
    [DbContext(typeof(BooksContext))]
    partial class BooksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BooksServiceSample.Models.BookChapter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Relational:ColumnType", "UniqueIdentifier")
                        .HasAnnotation("Relational:GeneratedValueSql", "newid()");

                    b.Property<int>("Number");

                    b.Property<int>("Pages");

                    b.Property<string>("Title")
                        .HasAnnotation("MaxLength", 120);

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "Chapters");
                });
        }
    }
}
