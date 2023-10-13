﻿// <auto-generated />
using System;
using Catalog.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Catalog.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20231013205653_Change1")]
    partial class Change1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Catalog.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("10e05e71-1f28-468d-bf4a-56665f6c27cc"),
                            Name = "Product-1"
                        },
                        new
                        {
                            Id = new Guid("0d0be146-5c5e-447f-ba31-aefbc1032063"),
                            Name = "Product-2"
                        },
                        new
                        {
                            Id = new Guid("9fee39c0-ae6d-4b38-a468-c55555cee76a"),
                            Name = "Product-3"
                        },
                        new
                        {
                            Id = new Guid("cbe401f1-dc36-4d14-817e-9a044f7bd7c1"),
                            Name = "Product-4"
                        },
                        new
                        {
                            Id = new Guid("c370a39b-ce76-43be-b05b-93c880e4e2e6"),
                            Name = "Product-5"
                        },
                        new
                        {
                            Id = new Guid("5ea1c7e0-1cd0-4e0c-8fdf-332178c18bdb"),
                            Name = "Product-6"
                        },
                        new
                        {
                            Id = new Guid("a43f7a4b-b90d-4147-9e6e-f88e0d646a5d"),
                            Name = "Product-7"
                        },
                        new
                        {
                            Id = new Guid("6db0ff8c-9c9d-4b56-bb0d-6bcc9595ce94"),
                            Name = "Product-8"
                        },
                        new
                        {
                            Id = new Guid("37832df5-f4b9-42a1-92ad-c60f9ef3b8b4"),
                            Name = "Product-9"
                        },
                        new
                        {
                            Id = new Guid("00f5153c-e89e-4ac2-b7f2-6937a860d184"),
                            Name = "Product-10"
                        },
                        new
                        {
                            Id = new Guid("2020d956-11d9-4886-9225-ce0a8069a312"),
                            Name = "Product-11"
                        },
                        new
                        {
                            Id = new Guid("3eaa3db7-ccfb-4f98-8e95-47350d519d44"),
                            Name = "Product-12"
                        },
                        new
                        {
                            Id = new Guid("58689a39-0539-4589-9999-5d603d835f8b"),
                            Name = "Product-13"
                        },
                        new
                        {
                            Id = new Guid("bb538160-285c-4028-bc68-a17b578ee487"),
                            Name = "Product-14"
                        },
                        new
                        {
                            Id = new Guid("b000365d-2913-4870-a9e9-c337b75e75f0"),
                            Name = "Product-15"
                        },
                        new
                        {
                            Id = new Guid("244ca99b-03f6-42ab-a0e6-e486ac1639b3"),
                            Name = "Product-16"
                        },
                        new
                        {
                            Id = new Guid("3fb24659-bf12-4fd0-91b7-f683e58071f7"),
                            Name = "Product-17"
                        },
                        new
                        {
                            Id = new Guid("57fe338f-6a89-4bbe-a1c5-c84f65a27117"),
                            Name = "Product-18"
                        },
                        new
                        {
                            Id = new Guid("7b7d5886-52f1-4dfc-902b-8f440972d46a"),
                            Name = "Product-19"
                        },
                        new
                        {
                            Id = new Guid("706130da-4670-4df1-bb63-94f435412bd6"),
                            Name = "Product-20"
                        },
                        new
                        {
                            Id = new Guid("c22d459f-19ce-4167-9d76-77146db134fd"),
                            Name = "Product-21"
                        },
                        new
                        {
                            Id = new Guid("0d877593-03fe-4e7f-9b37-1463f73958f2"),
                            Name = "Product-22"
                        },
                        new
                        {
                            Id = new Guid("94f855d1-b564-4fe7-82aa-d5c94b57ea2a"),
                            Name = "Product-23"
                        },
                        new
                        {
                            Id = new Guid("21dd82c8-f67d-40b8-859a-ed8a90d214e6"),
                            Name = "Product-24"
                        },
                        new
                        {
                            Id = new Guid("c29dd1e8-cf79-4740-9aff-446907deac5c"),
                            Name = "Product-25"
                        },
                        new
                        {
                            Id = new Guid("ccaf65c8-809a-4566-b69d-9aaea3850f8f"),
                            Name = "Product-26"
                        },
                        new
                        {
                            Id = new Guid("b081e67b-b2bb-45d9-9fe7-40e55a716b09"),
                            Name = "Product-27"
                        },
                        new
                        {
                            Id = new Guid("804f5e97-43a2-429e-8aab-979021616ccb"),
                            Name = "Product-28"
                        },
                        new
                        {
                            Id = new Guid("e8e25a93-78b3-40bd-9aca-eb5348983f05"),
                            Name = "Product-29"
                        },
                        new
                        {
                            Id = new Guid("cf7334bf-242f-41db-ac56-6cdfcdae1e4c"),
                            Name = "Product-30"
                        },
                        new
                        {
                            Id = new Guid("80d53a23-231a-4778-b85a-719641f559ae"),
                            Name = "Product-31"
                        },
                        new
                        {
                            Id = new Guid("4ddfd99d-1749-4143-8dd1-1bf419976cd4"),
                            Name = "Product-32"
                        },
                        new
                        {
                            Id = new Guid("c3f97db1-3909-428d-af31-6ab0835ec0ce"),
                            Name = "Product-33"
                        },
                        new
                        {
                            Id = new Guid("3be5a631-d98c-4ff8-a093-002fe25df7b4"),
                            Name = "Product-34"
                        },
                        new
                        {
                            Id = new Guid("93bac72b-ce6f-4c29-af47-9b3c34f556b4"),
                            Name = "Product-35"
                        },
                        new
                        {
                            Id = new Guid("db46bf1a-71b5-4de6-996a-95448d72cea3"),
                            Name = "Product-36"
                        },
                        new
                        {
                            Id = new Guid("2be3638f-9efe-43f7-a4e9-49693bce1f76"),
                            Name = "Product-37"
                        },
                        new
                        {
                            Id = new Guid("c8304a2e-cc29-4b3b-8b07-5e7553e785fa"),
                            Name = "Product-38"
                        },
                        new
                        {
                            Id = new Guid("b9c87485-4dd8-4064-af62-1b162914306e"),
                            Name = "Product-39"
                        },
                        new
                        {
                            Id = new Guid("336be911-a43d-4a65-b9fe-44cbfc59000e"),
                            Name = "Product-40"
                        },
                        new
                        {
                            Id = new Guid("e0441c48-55d5-4a4a-877d-3a17796d3372"),
                            Name = "Product-41"
                        },
                        new
                        {
                            Id = new Guid("a1ef5f8b-7dc7-4eeb-b04d-c8f1ce884e78"),
                            Name = "Product-42"
                        },
                        new
                        {
                            Id = new Guid("7f953ef1-c072-4e67-b950-86b8bbff9813"),
                            Name = "Product-43"
                        },
                        new
                        {
                            Id = new Guid("560d9b13-600b-4ce8-a69d-2c026930124e"),
                            Name = "Product-44"
                        },
                        new
                        {
                            Id = new Guid("3c509752-e5c8-42c6-9a22-bfa76c0ba737"),
                            Name = "Product-45"
                        },
                        new
                        {
                            Id = new Guid("d1e175ce-e823-44a3-8b79-95d2af03c5fe"),
                            Name = "Product-46"
                        },
                        new
                        {
                            Id = new Guid("f42553ed-c4e8-4293-8cba-b8899910846e"),
                            Name = "Product-47"
                        },
                        new
                        {
                            Id = new Guid("dfaf9321-7d67-4c50-8015-197652ad5968"),
                            Name = "Product-48"
                        },
                        new
                        {
                            Id = new Guid("d3eeb3c7-c88e-4f14-b3d8-bf2401b01765"),
                            Name = "Product-49"
                        },
                        new
                        {
                            Id = new Guid("eddd7d73-47ee-4eb5-8d60-6f5ebe41e1bb"),
                            Name = "Product-50"
                        },
                        new
                        {
                            Id = new Guid("a080810e-aba8-4b85-9d62-f041dddb02e7"),
                            Name = "Product-51"
                        },
                        new
                        {
                            Id = new Guid("f2501490-9bff-4eed-b458-eee268199d21"),
                            Name = "Product-52"
                        },
                        new
                        {
                            Id = new Guid("f06b0093-70b9-4a34-bc52-66dc57f3078f"),
                            Name = "Product-53"
                        },
                        new
                        {
                            Id = new Guid("04c789d7-280e-445b-b6e4-00c2f195abeb"),
                            Name = "Product-54"
                        },
                        new
                        {
                            Id = new Guid("ce3b8497-6a34-432a-acb6-e04df066bd8f"),
                            Name = "Product-55"
                        },
                        new
                        {
                            Id = new Guid("12d2f374-ab63-4b91-9652-08e03edf8cf9"),
                            Name = "Product-56"
                        },
                        new
                        {
                            Id = new Guid("7de6580c-6332-4edd-b445-bbfbdbdfdba7"),
                            Name = "Product-57"
                        },
                        new
                        {
                            Id = new Guid("4e9687cf-59f2-4424-a9b5-cf6fc3419a06"),
                            Name = "Product-58"
                        },
                        new
                        {
                            Id = new Guid("e2acd73b-c658-44d1-a9af-98fcd92f83cd"),
                            Name = "Product-59"
                        },
                        new
                        {
                            Id = new Guid("52915c80-ddea-4205-b315-4f410763d958"),
                            Name = "Product-60"
                        },
                        new
                        {
                            Id = new Guid("a8e8d231-48cb-4201-a32d-caf241b69348"),
                            Name = "Product-61"
                        },
                        new
                        {
                            Id = new Guid("f1445ec0-3843-4e53-9521-8dc79397dfb6"),
                            Name = "Product-62"
                        },
                        new
                        {
                            Id = new Guid("68b0c1e3-c866-450e-9380-5ea1fd53cbcb"),
                            Name = "Product-63"
                        },
                        new
                        {
                            Id = new Guid("3846f243-c1d2-4720-bbdf-b74ff8a6f8f6"),
                            Name = "Product-64"
                        },
                        new
                        {
                            Id = new Guid("0b606ac6-bdb4-48cc-bbcd-024a6ad6cacb"),
                            Name = "Product-65"
                        },
                        new
                        {
                            Id = new Guid("68eaa48d-1c8c-4a4f-951a-911ad7d60498"),
                            Name = "Product-66"
                        },
                        new
                        {
                            Id = new Guid("f0d7e9e3-7f1c-4948-8a0c-24705840007e"),
                            Name = "Product-67"
                        },
                        new
                        {
                            Id = new Guid("3bcd0cfe-7daf-41db-b46e-2fb4bfcf592c"),
                            Name = "Product-68"
                        },
                        new
                        {
                            Id = new Guid("b6b98fbd-d835-4947-b3f0-c30fe19f2106"),
                            Name = "Product-69"
                        },
                        new
                        {
                            Id = new Guid("d0f1eb78-3fc2-4b85-a6ce-014ccaf3cf2d"),
                            Name = "Product-70"
                        },
                        new
                        {
                            Id = new Guid("feef64c1-28ca-4aa2-8159-6d23e5977cd2"),
                            Name = "Product-71"
                        },
                        new
                        {
                            Id = new Guid("5a00051d-ccc7-40a0-a8cf-9c57691b6d54"),
                            Name = "Product-72"
                        },
                        new
                        {
                            Id = new Guid("cf7d6bca-751c-4d7c-88f4-be81a91ed6dd"),
                            Name = "Product-73"
                        },
                        new
                        {
                            Id = new Guid("57bc288d-6c14-467c-87c8-0c4d2e88e29a"),
                            Name = "Product-74"
                        },
                        new
                        {
                            Id = new Guid("ceab3751-67ea-4707-a8b5-15d85725f074"),
                            Name = "Product-75"
                        },
                        new
                        {
                            Id = new Guid("d2a5404c-24c4-4445-a0a0-031e6c25eff0"),
                            Name = "Product-76"
                        },
                        new
                        {
                            Id = new Guid("1e4c3f87-8afa-435f-b199-2fb42b752976"),
                            Name = "Product-77"
                        },
                        new
                        {
                            Id = new Guid("4a5a83c3-e1fd-4260-bf6b-ad7a3cd7a6bb"),
                            Name = "Product-78"
                        },
                        new
                        {
                            Id = new Guid("931180d5-6736-4980-a5fd-28d2f5edbe18"),
                            Name = "Product-79"
                        },
                        new
                        {
                            Id = new Guid("5bb22b7b-f332-47d1-9ed8-fb703d0fcf3e"),
                            Name = "Product-80"
                        },
                        new
                        {
                            Id = new Guid("60aeab65-f64f-43e4-829e-4ccf6e783d6f"),
                            Name = "Product-81"
                        },
                        new
                        {
                            Id = new Guid("46f6c235-9963-42a5-a542-7eb8a60bb5ad"),
                            Name = "Product-82"
                        },
                        new
                        {
                            Id = new Guid("5d797884-be3d-471a-8643-b86b53e97093"),
                            Name = "Product-83"
                        },
                        new
                        {
                            Id = new Guid("a2f747e5-fbc0-4b6b-8689-c43354d6200e"),
                            Name = "Product-84"
                        },
                        new
                        {
                            Id = new Guid("3a8a2e0d-8c16-4969-a6c7-f0bffb77f0a3"),
                            Name = "Product-85"
                        },
                        new
                        {
                            Id = new Guid("09588804-9fbb-4358-b6fe-0c742526f3f4"),
                            Name = "Product-86"
                        },
                        new
                        {
                            Id = new Guid("21524656-7e2e-4fb3-8ff4-da5695639096"),
                            Name = "Product-87"
                        },
                        new
                        {
                            Id = new Guid("e1364af4-9ac8-400f-bf04-217bffdc52a1"),
                            Name = "Product-88"
                        },
                        new
                        {
                            Id = new Guid("3ec80524-db6c-4b96-b5e6-2bb8fa8a6c9b"),
                            Name = "Product-89"
                        },
                        new
                        {
                            Id = new Guid("a0189d3a-5529-41d6-a484-6ed878b9016a"),
                            Name = "Product-90"
                        },
                        new
                        {
                            Id = new Guid("c2b3c6ec-1ad3-4dec-aab2-7e044f4cc6f5"),
                            Name = "Product-91"
                        },
                        new
                        {
                            Id = new Guid("81e4a92a-93d4-4ce4-9ade-0f5251bab1f5"),
                            Name = "Product-92"
                        },
                        new
                        {
                            Id = new Guid("5cae4bfd-6e04-4749-b094-ebbe80af5840"),
                            Name = "Product-93"
                        },
                        new
                        {
                            Id = new Guid("4fbf93b6-e7dd-4d71-aa7b-09e3b1865433"),
                            Name = "Product-94"
                        },
                        new
                        {
                            Id = new Guid("69488f09-46e2-43dc-b112-9bbc9630a0e8"),
                            Name = "Product-95"
                        },
                        new
                        {
                            Id = new Guid("e4ad10ad-54f8-42e2-9545-01c8e27e6d0c"),
                            Name = "Product-96"
                        },
                        new
                        {
                            Id = new Guid("ce031a7f-3641-4d78-92ee-03bf03ee1815"),
                            Name = "Product-97"
                        },
                        new
                        {
                            Id = new Guid("ebee3fa6-2f02-435e-b81b-cef9ec4b4423"),
                            Name = "Product-98"
                        },
                        new
                        {
                            Id = new Guid("e9c65576-25ec-4b6a-bb5d-9d55d4a6ccc4"),
                            Name = "Product-99"
                        },
                        new
                        {
                            Id = new Guid("aef7db7a-6e51-487e-9e98-a94ec30291ce"),
                            Name = "Product-100"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
