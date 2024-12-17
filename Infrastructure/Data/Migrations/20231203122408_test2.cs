using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReserverSeatsHistory_ReservationsHistory_ReservationID",
                table: "ReserverSeatsHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReserverSeatsHistory",
                table: "ReserverSeatsHistory");

            migrationBuilder.RenameTable(
                name: "ReserverSeatsHistory",
                newName: "ReservedSeatsHistory");

            migrationBuilder.RenameIndex(
                name: "IX_ReserverSeatsHistory_ReservationID",
                table: "ReservedSeatsHistory",
                newName: "IX_ReservedSeatsHistory_ReservationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservedSeatsHistory",
                table: "ReservedSeatsHistory",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservedSeatsHistory_ReservationsHistory_ReservationID",
                table: "ReservedSeatsHistory",
                column: "ReservationID",
                principalTable: "ReservationsHistory",
                principalColumn: "ReservationID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservedSeatsHistory_ReservationsHistory_ReservationID",
                table: "ReservedSeatsHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservedSeatsHistory",
                table: "ReservedSeatsHistory");

            migrationBuilder.RenameTable(
                name: "ReservedSeatsHistory",
                newName: "ReserverSeatsHistory");

            migrationBuilder.RenameIndex(
                name: "IX_ReservedSeatsHistory_ReservationID",
                table: "ReserverSeatsHistory",
                newName: "IX_ReserverSeatsHistory_ReservationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReserverSeatsHistory",
                table: "ReserverSeatsHistory",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReserverSeatsHistory_ReservationsHistory_ReservationID",
                table: "ReserverSeatsHistory",
                column: "ReservationID",
                principalTable: "ReservationsHistory",
                principalColumn: "ReservationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
