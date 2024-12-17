using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservedSeatsHistory_ReservationsHistory_ReservationID1",
                table: "ReservedSeatsHistory");

            migrationBuilder.DropIndex(
                name: "IX_ReservedSeatsHistory_ReservationID1",
                table: "ReservedSeatsHistory");

            migrationBuilder.DropColumn(
                name: "ReservationID1",
                table: "ReservedSeatsHistory");

            migrationBuilder.AlterColumn<int>(
                name: "ReservationID",
                table: "ReservedSeatsHistory",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "ReservationHistoryID",
                table: "ReservedSeatsHistory",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_ReservedSeatsHistory_ReservationID",
                table: "ReservedSeatsHistory",
                column: "ReservationID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservedSeatsHistory_ReservationsHistory_ReservationID",
                table: "ReservedSeatsHistory",
                column: "ReservationID",
                principalTable: "ReservationsHistory",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservedSeatsHistory_ReservationsHistory_ReservationID",
                table: "ReservedSeatsHistory");

            migrationBuilder.DropIndex(
                name: "IX_ReservedSeatsHistory_ReservationID",
                table: "ReservedSeatsHistory");

            migrationBuilder.DropColumn(
                name: "ReservationHistoryID",
                table: "ReservedSeatsHistory");

            migrationBuilder.AlterColumn<long>(
                name: "ReservationID",
                table: "ReservedSeatsHistory",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReservationID1",
                table: "ReservedSeatsHistory",
                type: "int",
                nullable: true);

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
    }
}
