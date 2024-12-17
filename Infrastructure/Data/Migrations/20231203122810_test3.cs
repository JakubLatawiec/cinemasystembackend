using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservedSeatsHistory_ReservationsHistory_ReservationID",
                table: "ReservedSeatsHistory");

            migrationBuilder.DropIndex(
                name: "IX_ReservedSeatsHistory_ReservationID",
                table: "ReservedSeatsHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationsHistory",
                table: "ReservationsHistory");

            migrationBuilder.DropColumn(
                name: "ReservationID",
                table: "ReservationsHistory");

            migrationBuilder.AddColumn<int>(
                name: "ReservationID1",
                table: "ReservedSeatsHistory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "ReservationsHistory",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationsHistory",
                table: "ReservationsHistory",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_ReservedSeatsHistory_ReservationID1",
                table: "ReservedSeatsHistory",
                column: "ReservationID1");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservedSeatsHistory_ReservationsHistory_ReservationID1",
                table: "ReservedSeatsHistory",
                column: "ReservationID1",
                principalTable: "ReservationsHistory",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservedSeatsHistory_ReservationsHistory_ReservationID1",
                table: "ReservedSeatsHistory");

            migrationBuilder.DropIndex(
                name: "IX_ReservedSeatsHistory_ReservationID1",
                table: "ReservedSeatsHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationsHistory",
                table: "ReservationsHistory");

            migrationBuilder.DropColumn(
                name: "ReservationID1",
                table: "ReservedSeatsHistory");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "ReservationsHistory");

            migrationBuilder.AddColumn<long>(
                name: "ReservationID",
                table: "ReservationsHistory",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationsHistory",
                table: "ReservationsHistory",
                column: "ReservationID");

            migrationBuilder.CreateIndex(
                name: "IX_ReservedSeatsHistory_ReservationID",
                table: "ReservedSeatsHistory",
                column: "ReservationID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservedSeatsHistory_ReservationsHistory_ReservationID",
                table: "ReservedSeatsHistory",
                column: "ReservationID",
                principalTable: "ReservationsHistory",
                principalColumn: "ReservationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
