using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetworkingList.Migrations
{
    /// <inheritdoc />
    public partial class AddedYourScoreSkill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Skill",
                newName: "SkillName");

            migrationBuilder.AddColumn<string>(
                name: "YourSkillScore",
                table: "Skill",
                type: "NVARCHAR(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YourSkillScore",
                table: "Skill");

            migrationBuilder.RenameColumn(
                name: "SkillName",
                table: "Skill",
                newName: "Name");
        }
    }
}
