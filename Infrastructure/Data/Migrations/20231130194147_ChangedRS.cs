using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangedRS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservedSeats",
                table: "ReservedSeats");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservedSeats",
                table: "ReservedSeats");

            migrationBuilder.DropIndex(
                name: "IX_ReservedSeats_ScreeningID",
                table: "ReservedSeats");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "ReservedSeats");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservedSeats",
                table: "ReservedSeats",
                columns: new[] { "ScreeningID", "SeatID", "ReservationID", "TicketTypeID" });
        }
    }
}
