using Microsoft.EntityFrameworkCore.Migrations;

namespace SGC.Infrastructure.Migrations
{
    public partial class alteraNomeTabelaCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tab_Cliente",
                table: "Tab_Cliente");

            migrationBuilder.RenameTable(
                name: "Tab_Cliente",
                newName: "Cliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Tab_Cliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tab_Cliente",
                table: "Tab_Cliente",
                column: "ClienteId");
        }
    }
}
