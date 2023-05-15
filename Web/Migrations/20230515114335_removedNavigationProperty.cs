using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    /// <inheritdoc />
    public partial class removedNavigationProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Outputs_InputUrlId",
                table: "Outputs");

            migrationBuilder.CreateIndex(
                name: "IX_Outputs_InputUrlId",
                table: "Outputs",
                column: "InputUrlId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Outputs_InputUrlId",
                table: "Outputs");

            migrationBuilder.CreateIndex(
                name: "IX_Outputs_InputUrlId",
                table: "Outputs",
                column: "InputUrlId",
                unique: true);
        }
    }
}
