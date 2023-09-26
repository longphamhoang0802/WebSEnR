using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSEnR.Migrations
{
    /// <inheritdoc />
    public partial class register_queue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "registerqueue",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    school = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    faculty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    desc_abtme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    desc_abt_wanna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cv_link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sdt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registerqueue", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "registerqueue");
        }
    }
}
