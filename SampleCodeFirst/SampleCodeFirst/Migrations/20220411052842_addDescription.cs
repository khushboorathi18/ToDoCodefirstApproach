using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleCodeFirst.Migrations
{
    public partial class addDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ToDoItem",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ToDoItem");
        }
    }
}
