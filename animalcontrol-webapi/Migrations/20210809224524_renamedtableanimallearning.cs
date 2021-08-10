using Microsoft.EntityFrameworkCore.Migrations;

namespace animalcontrol_webapi.Migrations
{
    public partial class renamedtableanimallearning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalsLearningTopics_Animals_AnimalId",
                table: "AnimalsLearningTopics");

            migrationBuilder.DropForeignKey(
                name: "FK_AnimalsLearningTopics_LearningTopics_LearningTopicId",
                table: "AnimalsLearningTopics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalsLearningTopics",
                table: "AnimalsLearningTopics");

            migrationBuilder.RenameTable(
                name: "AnimalsLearningTopics",
                newName: "AnimalLearningTopics");

            migrationBuilder.RenameIndex(
                name: "IX_AnimalsLearningTopics_LearningTopicId",
                table: "AnimalLearningTopics",
                newName: "IX_AnimalLearningTopics_LearningTopicId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalLearningTopics",
                table: "AnimalLearningTopics",
                columns: new[] { "AnimalId", "LearningTopicId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalLearningTopics_Animals_AnimalId",
                table: "AnimalLearningTopics",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalLearningTopics_LearningTopics_LearningTopicId",
                table: "AnimalLearningTopics",
                column: "LearningTopicId",
                principalTable: "LearningTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalLearningTopics_Animals_AnimalId",
                table: "AnimalLearningTopics");

            migrationBuilder.DropForeignKey(
                name: "FK_AnimalLearningTopics_LearningTopics_LearningTopicId",
                table: "AnimalLearningTopics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalLearningTopics",
                table: "AnimalLearningTopics");

            migrationBuilder.RenameTable(
                name: "AnimalLearningTopics",
                newName: "AnimalsLearningTopics");

            migrationBuilder.RenameIndex(
                name: "IX_AnimalLearningTopics_LearningTopicId",
                table: "AnimalsLearningTopics",
                newName: "IX_AnimalsLearningTopics_LearningTopicId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalsLearningTopics",
                table: "AnimalsLearningTopics",
                columns: new[] { "AnimalId", "LearningTopicId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalsLearningTopics_Animals_AnimalId",
                table: "AnimalsLearningTopics",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalsLearningTopics_LearningTopics_LearningTopicId",
                table: "AnimalsLearningTopics",
                column: "LearningTopicId",
                principalTable: "LearningTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
