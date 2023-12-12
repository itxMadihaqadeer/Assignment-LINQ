using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbCwithLINKQ.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    Fid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deptid = table.Column<int>(type: "int", nullable: false),
                    Standing = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.Fid);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Sid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Major = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Standing = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Sid);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Cid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    Fid = table.Column<int>(type: "int", nullable: false),
                    FacultyFid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Cid);
                    table.ForeignKey(
                        name: "FK_Class_Faculty_FacultyFid",
                        column: x => x.FacultyFid,
                        principalTable: "Faculty",
                        principalColumn: "Fid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enrolled",
                columns: table => new
                {
                    Cid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sid = table.Column<int>(type: "int", nullable: false),
                    Ci = table.Column<int>(type: "int", nullable: false),
                    ClassCid = table.Column<int>(type: "int", nullable: false),
                    StudentSid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrolled", x => x.Cid);
                    table.ForeignKey(
                        name: "FK_Enrolled_Class_ClassCid",
                        column: x => x.ClassCid,
                        principalTable: "Class",
                        principalColumn: "Cid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrolled_Student_StudentSid",
                        column: x => x.StudentSid,
                        principalTable: "Student",
                        principalColumn: "Sid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Class_FacultyFid",
                table: "Class",
                column: "FacultyFid");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolled_ClassCid",
                table: "Enrolled",
                column: "ClassCid");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolled_StudentSid",
                table: "Enrolled",
                column: "StudentSid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrolled");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Faculty");
        }
    }
}
