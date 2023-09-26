using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSEnR.Migrations
{
    /// <inheritdoc />
    public partial class post_etp_queue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lab_members",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    school = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    facul = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    joined_prjs = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lab_members", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "posts_etp_queue",
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
                    table.PrimaryKey("PK_posts_etp_queue", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lab_members");

            migrationBuilder.DropTable(
                name: "posts_etp_queue");
        }
    }
}
