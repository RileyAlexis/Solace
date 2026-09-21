using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace solace.Migrations
{
    /// <inheritdoc />
    public partial class wut : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "building_definitions",
                keyColumn: "id",
                keyValue: 9,
                column: "name",
                value: "Training Hall");

            migrationBuilder.UpdateData(
                table: "building_definitions",
                keyColumn: "id",
                keyValue: 10,
                column: "name",
                value: "Service Provider");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "building_definitions",
                keyColumn: "id",
                keyValue: 9,
                column: "name",
                value: "TrainingHall");

            migrationBuilder.UpdateData(
                table: "building_definitions",
                keyColumn: "id",
                keyValue: 10,
                column: "name",
                value: "ServiceProvider");
        }
    }
}
