using Microsoft.EntityFrameworkCore.Migrations;

namespace yektaApi.Migrations
{
    public partial class addDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_categories_categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CFamily = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCodemeli = table.Column<long>(type: "bigint", nullable: false),
                    CCodeTax = table.Column<long>(type: "bigint", nullable: false),
                    CCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ctel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cmobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAddress = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Cpostalcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CContext = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ctype = table.Column<bool>(type: "bit", nullable: false),
                    UId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CId);
                });

            migrationBuilder.CreateTable(
                name: "ProCategory",
                columns: table => new
                {
                    CPId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CPInfo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProCategory", x => x.CPId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPId = table.Column<int>(type: "int", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PInfo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Pqhotr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Psize = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Pzekhamat = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Pvazn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Pestandard = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PPrice = table.Column<int>(type: "int", nullable: false),
                    PPic = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.PId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_categories_ParentId",
                table: "categories",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "ProCategory");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
