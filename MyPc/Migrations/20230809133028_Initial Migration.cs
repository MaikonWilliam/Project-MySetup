using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPc.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Setup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Motherboard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gpu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSD_or_HD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PowerSupply = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cabinet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPrice = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setup", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Setup");
        }
    }
}
