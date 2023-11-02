using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Talentotrack.Dao.Migrations
{
    /// <inheritdoc />
    public partial class logindetailstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_User",
            //    table: "User");
             
            //migrationBuilder.RenameTable(
            //    name: "User",
            //    newName: "tbl_user");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_tbl_user",
            //    table: "tbl_user",
            //    column: "Id");

            migrationBuilder.CreateTable(
                name: "tbl_login_details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userid = table.Column<int>(type: "int", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isblocked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_login_details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_login_details_tbl_user_userid",
                        column: x => x.userid,
                        principalTable: "tbl_user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_login_details_userid",
                table: "tbl_login_details",
                column: "userid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_login_details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_user",
                table: "tbl_user");

            migrationBuilder.RenameTable(
                name: "tbl_user",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");
        }
    }
}
