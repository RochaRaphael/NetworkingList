using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetworkingList.Migrations
{
    /// <inheritdoc />
    public partial class FixTableContactSkills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractSkills_ContractId",
                table: "ContactSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractSkills_SkillId",
                table: "ContactSkills");

            migrationBuilder.RenameColumn(
                name: "ContactsId",
                table: "ContactSkills",
                newName: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractSkills_ContactId",
                table: "ContactSkills",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractSkills_SkillId",
                table: "ContactSkills",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractSkills_ContactId",
                table: "ContactSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractSkills_SkillId",
                table: "ContactSkills");

            migrationBuilder.RenameColumn(
                name: "ContactId",
                table: "ContactSkills",
                newName: "ContactsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractSkills_ContractId",
                table: "ContactSkills",
                column: "ContactsId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractSkills_SkillId",
                table: "ContactSkills",
                column: "SkillId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
