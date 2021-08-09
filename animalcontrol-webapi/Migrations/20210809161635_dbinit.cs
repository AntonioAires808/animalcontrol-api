using Microsoft.EntityFrameworkCore.Migrations;

namespace animalcontrol_webapi.Migrations
{
    public partial class dbinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Nickname = table.Column<string>(type: "TEXT", nullable: true),
                    ChipNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    Schedule = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LearningTopics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    OwnerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningTopics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LearningTopics_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalsLearningTopics",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "INTEGER", nullable: false),
                    LearningTopicId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalsLearningTopics", x => new { x.AnimalId, x.LearningTopicId });
                    table.ForeignKey(
                        name: "FK_AnimalsLearningTopics_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalsLearningTopics_LearningTopics_LearningTopicId",
                        column: x => x.LearningTopicId,
                        principalTable: "LearningTopics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "ChipNumber", "Name", "Nickname" },
                values: new object[] { 1, 3, 1204151, "Ciri", "Cirigatas" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "ChipNumber", "Name", "Nickname" },
                values: new object[] { 2, 1, 1204151, "Bali", "BaliWally" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "ChipNumber", "Name", "Nickname" },
                values: new object[] { 3, 5, 1204151, "Flake", "Flakinho" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "ChipNumber", "Name", "Nickname" },
                values: new object[] { 4, 5, 1204151, "Diesel", "N/A" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name", "Schedule" },
                values: new object[] { 1, "Rua Dr", "Antonio", "9-18h" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name", "Schedule" },
                values: new object[] { 2, "Praceta Iv", "Susana", "9-18h" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name", "Schedule" },
                values: new object[] { 3, "N/A", "RandomPerson", "9-18h" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name", "Schedule" },
                values: new object[] { 4, "N/A", "RandomPerson2", "9-18h" });

            migrationBuilder.InsertData(
                table: "LearningTopics",
                columns: new[] { "Id", "Name", "OwnerId" },
                values: new object[] { 1, "Food", 1 });

            migrationBuilder.InsertData(
                table: "LearningTopics",
                columns: new[] { "Id", "Name", "OwnerId" },
                values: new object[] { 2, "Walk", 2 });

            migrationBuilder.InsertData(
                table: "LearningTopics",
                columns: new[] { "Id", "Name", "OwnerId" },
                values: new object[] { 3, "Sit", 3 });

            migrationBuilder.InsertData(
                table: "LearningTopics",
                columns: new[] { "Id", "Name", "OwnerId" },
                values: new object[] { 4, "Tricks", 4 });

            migrationBuilder.InsertData(
                table: "AnimalsLearningTopics",
                columns: new[] { "AnimalId", "LearningTopicId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "AnimalsLearningTopics",
                columns: new[] { "AnimalId", "LearningTopicId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "AnimalsLearningTopics",
                columns: new[] { "AnimalId", "LearningTopicId" },
                values: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "AnimalsLearningTopics",
                columns: new[] { "AnimalId", "LearningTopicId" },
                values: new object[] { 4, 1 });

            migrationBuilder.InsertData(
                table: "AnimalsLearningTopics",
                columns: new[] { "AnimalId", "LearningTopicId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "AnimalsLearningTopics",
                columns: new[] { "AnimalId", "LearningTopicId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "AnimalsLearningTopics",
                columns: new[] { "AnimalId", "LearningTopicId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "AnimalsLearningTopics",
                columns: new[] { "AnimalId", "LearningTopicId" },
                values: new object[] { 4, 2 });

            migrationBuilder.InsertData(
                table: "AnimalsLearningTopics",
                columns: new[] { "AnimalId", "LearningTopicId" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "AnimalsLearningTopics",
                columns: new[] { "AnimalId", "LearningTopicId" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "AnimalsLearningTopics",
                columns: new[] { "AnimalId", "LearningTopicId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "AnimalsLearningTopics",
                columns: new[] { "AnimalId", "LearningTopicId" },
                values: new object[] { 4, 3 });

            migrationBuilder.InsertData(
                table: "AnimalsLearningTopics",
                columns: new[] { "AnimalId", "LearningTopicId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "AnimalsLearningTopics",
                columns: new[] { "AnimalId", "LearningTopicId" },
                values: new object[] { 2, 4 });

            migrationBuilder.InsertData(
                table: "AnimalsLearningTopics",
                columns: new[] { "AnimalId", "LearningTopicId" },
                values: new object[] { 3, 4 });

            migrationBuilder.InsertData(
                table: "AnimalsLearningTopics",
                columns: new[] { "AnimalId", "LearningTopicId" },
                values: new object[] { 4, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalsLearningTopics_LearningTopicId",
                table: "AnimalsLearningTopics",
                column: "LearningTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_LearningTopics_OwnerId",
                table: "LearningTopics",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalsLearningTopics");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "LearningTopics");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
