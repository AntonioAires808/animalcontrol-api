using Microsoft.EntityFrameworkCore.Migrations;

namespace animalcontrol_webapi.Migrations
{
    public partial class animalowneradded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Animals",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AnimalOwners",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "INTEGER", nullable: false),
                    OwnerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalOwners", x => new { x.AnimalId, x.OwnerId });
                    table.ForeignKey(
                        name: "FK_AnimalOwners_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalOwners_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AnimalOwners",
                columns: new[] { "AnimalId", "OwnerId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "AnimalOwners",
                columns: new[] { "AnimalId", "OwnerId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "AnimalOwners",
                columns: new[] { "AnimalId", "OwnerId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "AnimalOwners",
                columns: new[] { "AnimalId", "OwnerId" },
                values: new object[] { 4, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_OwnerId",
                table: "Animals",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalOwners_OwnerId",
                table: "AnimalOwners",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Owners_OwnerId",
                table: "Animals",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Owners_OwnerId",
                table: "Animals");

            migrationBuilder.DropTable(
                name: "AnimalOwners");

            migrationBuilder.DropIndex(
                name: "IX_Animals_OwnerId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Animals");
        }
    }
}
