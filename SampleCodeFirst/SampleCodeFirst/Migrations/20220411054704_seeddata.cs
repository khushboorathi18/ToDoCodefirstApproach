using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleCodeFirst.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ToDoItem",
                columns: new[] { "Id", "Description", "IsComplete", "name" },
                values: new object[] { 1L, "In meeting need to discuss some point", true, "Meeting with management" });

            migrationBuilder.InsertData(
                table: "ToDoItem",
                columns: new[] { "Id", "Description", "IsComplete", "name" },
                values: new object[] { 2L, "List of items to buy", false, "Go For Shopping" });

            migrationBuilder.InsertData(
                table: "ToDoItem",
                columns: new[] { "Id", "Description", "IsComplete", "name" },
                values: new object[] { 3L, "Here is task to do on a call", true, "Call someone to do task" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ToDoItem",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
