using Microsoft.EntityFrameworkCore.Migrations;

namespace EmartProject2.Migrations.EmartItem
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Ino = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sname = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Desc = table.Column<string>(nullable: true),
                    Noi = table.Column<int>(nullable: false),
                    Scid = table.Column<int>(nullable: false),
                    Cid = table.Column<int>(nullable: false),
                    Cname = table.Column<string>(nullable: true),
                    Scname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Ino);
                });

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    Scid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cid = table.Column<int>(nullable: false),
                    Cname = table.Column<string>(nullable: true),
                    Scname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.Scid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "SubCategory");
        }
    }
}
