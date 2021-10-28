using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovieTARpe20_SergeiBubnov.Migrations
{
    public partial class Actor02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfOscars",
                table: "Actor",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfOscars",
                table: "Actor");
        }
    }
}
