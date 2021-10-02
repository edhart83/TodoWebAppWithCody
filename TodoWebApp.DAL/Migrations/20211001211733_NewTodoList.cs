using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoWebApp.DAL.Migrations
{
    public partial class NewTodoList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "TodoID", "IsComplete", "Name" },
                values: new object[] { 1, false, "Go Running" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "TodoID",
                keyValue: 1);
        }
    }
}
