using Microsoft.EntityFrameworkCore.Migrations;

namespace DocumentManagement.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PartyRelationships",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToParty_ID = table.Column<int>(nullable: false),
                    FromParty_ID = table.Column<int>(nullable: false),
                    ToPartyRole_ID = table.Column<int>(nullable: false),
                    FromPartyRole_ID = table.Column<int>(nullable: false),
                    CreatedByParty_ID = table.Column<int>(nullable: false),
                    Relation_Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyRelationships", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PartyRoles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyRoles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Parties",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartyRole_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parties", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Parties_PartyRoles_PartyRole_Id",
                        column: x => x.PartyRole_Id,
                        principalTable: "PartyRoles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Party_ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    PhoneNo = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Party_ID);
                    table.ForeignKey(
                        name: "FK_Companies_Parties_Party_ID",
                        column: x => x.Party_ID,
                        principalTable: "Parties",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Party_ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Company_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Party_ID);
                    table.ForeignKey(
                        name: "FK_Departments_Parties_Party_ID",
                        column: x => x.Party_ID,
                        principalTable: "Parties",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Party_ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Extension = table.Column<string>(nullable: false),
                    Path = table.Column<string>(nullable: false),
                    User_ID = table.Column<int>(nullable: false),
                    Department_ID = table.Column<int>(nullable: false),
                    Company_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Party_ID);
                    table.ForeignKey(
                        name: "FK_Documents_Parties_Party_ID",
                        column: x => x.Party_ID,
                        principalTable: "Parties",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Party_ID = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Department_ID = table.Column<int>(nullable: false),
                    Company_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Party_ID);
                    table.ForeignKey(
                        name: "FK_Users_Parties_Party_ID",
                        column: x => x.Party_ID,
                        principalTable: "Parties",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PartyRelationships",
                columns: new[] { "ID", "CreatedByParty_ID", "FromPartyRole_ID", "FromParty_ID", "Relation_Type", "ToPartyRole_ID", "ToParty_ID" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, "C", 2, 2 },
                    { 2, 1, 2, 2, "C", 3, 3 },
                    { 3, 1, 3, 3, "C", 4, 4 },
                    { 4, 1, 1, 1, "C", 7, 5 },
                    { 5, 1, 2, 2, "C", 6, 6 }
                });

            migrationBuilder.InsertData(
                table: "PartyRoles",
                columns: new[] { "ID", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "SuperAdmin", "SA" },
                    { 2, "CompanyAdmin", "CA" },
                    { 3, "DepartmentHead", "DH" },
                    { 4, "Employee", "EE" },
                    { 5, "User", "UR" },
                    { 6, "Department", "DT" },
                    { 7, "Company", "CO" },
                    { 8, "Document", "DO" }
                });

            migrationBuilder.InsertData(
                table: "Parties",
                columns: new[] { "ID", "PartyRole_Id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 6, 6 },
                    { 5, 7 }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Party_ID", "Address", "Email", "Name", "PhoneNo" },
                values: new object[] { 5, "E-11", "ba@tech.com", "BA Tech", "080088801" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Party_ID", "Company_ID", "Name" },
                values: new object[] { 6, 5, "HR" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Party_ID", "Company_ID", "Department_ID", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, 0, 0, "sa", "sa" },
                    { 2, 5, 0, "baadmin", "baadmin" },
                    { 3, 5, 6, "bahradmin", "bahradmin" },
                    { 4, 5, 6, "bahremp", "bahremp" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parties_PartyRole_Id",
                table: "Parties",
                column: "PartyRole_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "PartyRelationships");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Parties");

            migrationBuilder.DropTable(
                name: "PartyRoles");
        }
    }
}
