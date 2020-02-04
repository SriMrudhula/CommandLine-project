using Microsoft.EntityFrameworkCore.Migrations;

namespace EmartProject2.Migrations.EmartBuyer
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buyer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Phno = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Pwd = table.Column<string>(nullable: false),
                    Cpwd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buyer");
        }
    }
}
