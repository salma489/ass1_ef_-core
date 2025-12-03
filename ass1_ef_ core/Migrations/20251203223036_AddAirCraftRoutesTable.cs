using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ass1_ef__core.Migrations
{
    /// <inheritdoc />
    public partial class AddAirCraftRoutesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AirCraftRoute_AirCrafts_AirCraftId",
                table: "AirCraftRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_AirCraftRoute_Route_RouteId",
                table: "AirCraftRoute");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AirCraftRoute",
                table: "AirCraftRoute");

            migrationBuilder.RenameTable(
                name: "AirCraftRoute",
                newName: "AirCraftRoutes");

            migrationBuilder.RenameIndex(
                name: "IX_AirCraftRoute_RouteId",
                table: "AirCraftRoutes",
                newName: "IX_AirCraftRoutes_RouteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AirCraftRoutes",
                table: "AirCraftRoutes",
                columns: new[] { "AirCraftId", "RouteId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AirCraftRoutes_AirCrafts_AirCraftId",
                table: "AirCraftRoutes",
                column: "AirCraftId",
                principalTable: "AirCrafts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AirCraftRoutes_Route_RouteId",
                table: "AirCraftRoutes",
                column: "RouteId",
                principalTable: "Route",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AirCraftRoutes_AirCrafts_AirCraftId",
                table: "AirCraftRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_AirCraftRoutes_Route_RouteId",
                table: "AirCraftRoutes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AirCraftRoutes",
                table: "AirCraftRoutes");

            migrationBuilder.RenameTable(
                name: "AirCraftRoutes",
                newName: "AirCraftRoute");

            migrationBuilder.RenameIndex(
                name: "IX_AirCraftRoutes_RouteId",
                table: "AirCraftRoute",
                newName: "IX_AirCraftRoute_RouteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AirCraftRoute",
                table: "AirCraftRoute",
                columns: new[] { "AirCraftId", "RouteId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AirCraftRoute_AirCrafts_AirCraftId",
                table: "AirCraftRoute",
                column: "AirCraftId",
                principalTable: "AirCrafts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AirCraftRoute_Route_RouteId",
                table: "AirCraftRoute",
                column: "RouteId",
                principalTable: "Route",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
