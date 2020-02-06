using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopPhone.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    categoryName = table.Column<string>(nullable: true),
                    categoryDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotherboardCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    categoryName = table.Column<string>(nullable: true),
                    categoryDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotherboardCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcesorCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    categoryName = table.Column<string>(nullable: true),
                    categoryDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcesorCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RamCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    categoryName = table.Column<string>(nullable: true),
                    categoryDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RamCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SsdCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    categoryName = table.Column<string>(nullable: true),
                    categoryDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SsdCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoCardCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    categoryName = table.Column<string>(nullable: true),
                    categoryDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoCardCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    img = table.Column<string>(nullable: true),
                    price = table.Column<long>(nullable: false),
                    CategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phone_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    img = table.Column<string>(nullable: true),
                    price = table.Column<long>(nullable: false),
                    MotherboardCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motherboards_MotherboardCategories_MotherboardCategoryId",
                        column: x => x.MotherboardCategoryId,
                        principalTable: "MotherboardCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Procesors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    img = table.Column<string>(nullable: true),
                    price = table.Column<long>(nullable: false),
                    ProcesorCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procesors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Procesors_ProcesorCategories_ProcesorCategoryId",
                        column: x => x.ProcesorCategoryId,
                        principalTable: "ProcesorCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    img = table.Column<string>(nullable: true),
                    price = table.Column<long>(nullable: false),
                    RamCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rams_RamCategories_RamCategoryId",
                        column: x => x.RamCategoryId,
                        principalTable: "RamCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ssds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    img = table.Column<string>(nullable: true),
                    price = table.Column<long>(nullable: false),
                    SsdCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ssds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ssds_SsdCategories_SsdCategoryId",
                        column: x => x.SsdCategoryId,
                        principalTable: "SsdCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VideoCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    img = table.Column<string>(nullable: true),
                    price = table.Column<long>(nullable: false),
                    VideoCardCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoCards_VideoCardCategories_VideoCardCategoryId",
                        column: x => x.VideoCardCategoryId,
                        principalTable: "VideoCardCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Motherboards_MotherboardCategoryId",
                table: "Motherboards",
                column: "MotherboardCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_CategoryId",
                table: "Phone",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Procesors_ProcesorCategoryId",
                table: "Procesors",
                column: "ProcesorCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Rams_RamCategoryId",
                table: "Rams",
                column: "RamCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ssds_SsdCategoryId",
                table: "Ssds",
                column: "SsdCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoCards_VideoCardCategoryId",
                table: "VideoCards",
                column: "VideoCardCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motherboards");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "Procesors");

            migrationBuilder.DropTable(
                name: "Rams");

            migrationBuilder.DropTable(
                name: "Ssds");

            migrationBuilder.DropTable(
                name: "VideoCards");

            migrationBuilder.DropTable(
                name: "MotherboardCategories");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "ProcesorCategories");

            migrationBuilder.DropTable(
                name: "RamCategories");

            migrationBuilder.DropTable(
                name: "SsdCategories");

            migrationBuilder.DropTable(
                name: "VideoCardCategories");
        }
    }
}
