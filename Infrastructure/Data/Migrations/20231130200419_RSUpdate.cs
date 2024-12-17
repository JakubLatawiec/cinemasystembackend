using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RSUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketTypes_ReservedSeats_ReservedSeatScreeningID_ReservedSeatSeatID_ReservedSeatReservationID_ReservedSeatTicketTypeID",
                table: "TicketTypes");

            migrationBuilder.DropIndex(
                name: "IX_TicketTypes_ReservedSeatScreeningID_ReservedSeatSeatID_ReservedSeatReservationID_ReservedSeatTicketTypeID",
                table: "TicketTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservedSeats",
                table: "ReservedSeats");

            migrationBuilder.DropColumn(
                name: "ReservedSeatTicketTypeID",
                table: "TicketTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservedSeats",
                table: "ReservedSeats",
                columns: new[] { "ScreeningID", "SeatID", "ReservationID" });

            migrationBuilder.CreateIndex(
                name: "IX_TicketTypes_ReservedSeatScreeningID_ReservedSeatSeatID_ReservedSeatReservationID",
                table: "TicketTypes",
                columns: new[] { "ReservedSeatScreeningID", "ReservedSeatSeatID", "ReservedSeatReservationID" });

            migrationBuilder.AddForeignKey(
                name: "FK_TicketTypes_ReservedSeats_ReservedSeatScreeningID_ReservedSeatSeatID_ReservedSeatReservationID",
                table: "TicketTypes",
                columns: new[] { "ReservedSeatScreeningID", "ReservedSeatSeatID", "ReservedSeatReservationID" },
                principalTable: "ReservedSeats",
                principalColumns: new[] { "ScreeningID", "SeatID", "ReservationID" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketTypes_ReservedSeats_ReservedSeatScreeningID_ReservedSeatSeatID_ReservedSeatReservationID",
                table: "TicketTypes");

            migrationBuilder.DropIndex(
                name: "IX_TicketTypes_ReservedSeatScreeningID_ReservedSeatSeatID_ReservedSeatReservationID",
                table: "TicketTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservedSeats",
                table: "ReservedSeats");

            migrationBuilder.AddColumn<long>(
                name: "ReservedSeatTicketTypeID",
                table: "TicketTypes",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservedSeats",
                table: "ReservedSeats",
                columns: new[] { "ScreeningID", "SeatID", "ReservationID", "TicketTypeID" });

            migrationBuilder.CreateIndex(
                name: "IX_TicketTypes_ReservedSeatScreeningID_ReservedSeatSeatID_ReservedSeatReservationID_ReservedSeatTicketTypeID",
                table: "TicketTypes",
                columns: new[] { "ReservedSeatScreeningID", "ReservedSeatSeatID", "ReservedSeatReservationID", "ReservedSeatTicketTypeID" });

            migrationBuilder.AddForeignKey(
                name: "FK_TicketTypes_ReservedSeats_ReservedSeatScreeningID_ReservedSeatSeatID_ReservedSeatReservationID_ReservedSeatTicketTypeID",
                table: "TicketTypes",
                columns: new[] { "ReservedSeatScreeningID", "ReservedSeatSeatID", "ReservedSeatReservationID", "ReservedSeatTicketTypeID" },
                principalTable: "ReservedSeats",
                principalColumns: new[] { "ScreeningID", "SeatID", "ReservationID", "TicketTypeID" });
        }
    }
}
