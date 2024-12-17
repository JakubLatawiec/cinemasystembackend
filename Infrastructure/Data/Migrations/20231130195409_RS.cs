using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservedSeats_TicketTypes_TicketTypeID",
                table: "ReservedSeats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservedSeats",
                table: "ReservedSeats");

            migrationBuilder.DropIndex(
                name: "IX_ReservedSeats_ScreeningID",
                table: "ReservedSeats");

            migrationBuilder.DropIndex(
                name: "IX_ReservedSeats_TicketTypeID",
                table: "ReservedSeats");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "ReservedSeats");

            migrationBuilder.AddColumn<long>(
                name: "ReservedSeatReservationID",
                table: "TicketTypes",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ReservedSeatScreeningID",
                table: "TicketTypes",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ReservedSeatSeatID",
                table: "TicketTypes",
                type: "bigint",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "ReservedSeatReservationID",
                table: "TicketTypes");

            migrationBuilder.DropColumn(
                name: "ReservedSeatScreeningID",
                table: "TicketTypes");

            migrationBuilder.DropColumn(
                name: "ReservedSeatSeatID",
                table: "TicketTypes");

            migrationBuilder.DropColumn(
                name: "ReservedSeatTicketTypeID",
                table: "TicketTypes");

            migrationBuilder.AddColumn<long>(
                name: "ID",
                table: "ReservedSeats",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservedSeats",
                table: "ReservedSeats",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_ReservedSeats_ScreeningID",
                table: "ReservedSeats",
                column: "ScreeningID");

            migrationBuilder.CreateIndex(
                name: "IX_ReservedSeats_TicketTypeID",
                table: "ReservedSeats",
                column: "TicketTypeID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservedSeats_TicketTypes_TicketTypeID",
                table: "ReservedSeats",
                column: "TicketTypeID",
                principalTable: "TicketTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
