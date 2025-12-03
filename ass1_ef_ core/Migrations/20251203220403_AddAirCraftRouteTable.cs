using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ass1_ef__core.Migrations
{
    /// <inheritdoc />
    public partial class AddAirCraftRouteTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AirCraftRoute_AirCrafts_airCraftsId",
                table: "AirCraftRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_AirCraftRoute_Route_routesid",
                table: "AirCraftRoute");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AirCraftRoute",
                table: "AirCraftRoute");

            migrationBuilder.DropIndex(
                name: "IX_AirCraftRoute_routesid",
                table: "AirCraftRoute");

            migrationBuilder.RenameColumn(
                name: "routesid",
                table: "AirCraftRoute",
                newName: "Duration");

            migrationBuilder.RenameColumn(
                name: "airCraftsId",
                table: "AirCraftRoute",
                newName: "RouteId");

            migrationBuilder.AddColumn<int>(
                name: "AirCraftId",
                table: "AirCraftRoute",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "AirCraftRoute",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AirCraftRoute",
                table: "AirCraftRoute",
                columns: new[] { "AirCraftId", "RouteId" });

            migrationBuilder.CreateIndex(
                name: "IX_AirCraftRoute_RouteId",
                table: "AirCraftRoute",
                column: "RouteId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_AirCraftRoute_RouteId",
                table: "AirCraftRoute");

            migrationBuilder.DropColumn(
                name: "AirCraftId",
                table: "AirCraftRoute");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "AirCraftRoute");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "AirCraftRoute",
                newName: "routesid");

            migrationBuilder.RenameColumn(
                name: "RouteId",
                table: "AirCraftRoute",
                newName: "airCraftsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AirCraftRoute",
                table: "AirCraftRoute",
                columns: new[] { "airCraftsId", "routesid" });

            migrationBuilder.CreateIndex(
                name: "IX_AirCraftRoute_routesid",
                table: "AirCraftRoute",
                column: "routesid");

            migrationBuilder.AddForeignKey(
                name: "FK_AirCraftRoute_AirCrafts_airCraftsId",
                table: "AirCraftRoute",
                column: "airCraftsId",
                principalTable: "AirCrafts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AirCraftRoute_Route_routesid",
                table: "AirCraftRoute",
                column: "routesid",
                principalTable: "Route",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
