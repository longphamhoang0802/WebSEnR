using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSEnR.Migrations
{
    /// <inheritdoc />
    public partial class post_lab : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "posts_etp",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    etp_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_i = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_f = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_t = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_r = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    desc_job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    desc_etp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact_sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    exp_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    post_date = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts_etp", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "posts_lab",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    datetime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts_lab", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "posts_etp");

            migrationBuilder.DropTable(
                name: "posts_lab");
        }
    }
}
