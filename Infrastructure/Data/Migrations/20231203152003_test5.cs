using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DropTable(
                name: "ReservedSeatsHistory");

            migrationBuilder.DropTable(
                name: "ReservationsHistory");*/
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReservationsHistory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationsHistory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReservedSeatsHistory",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationID = table.Column<int>(type: "int", nullable: true),
                    ReservationHistoryID = table.Column<long>(type: "bigint", nullable: false),
                    SeatID = table.Column<long>(type: "bigint", nullable: false),
                    SeatNumber = table.Column<long>(type: "bigint", nullable: false),
                    SeatRow = table.Column<long>(type: "bigint", nullable: false),
                    TicketPrice = table.Column<float>(type: "real", nullable: false),
                    TicketType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservedSeatsHistory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReservedSeatsHistory_ReservationsHistory_ReservationID",
                        column: x => x.ReservationID,
                        principalTable: "ReservationsHistory",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservedSeatsHistory_ReservationID",
                table: "ReservedSeatsHistory",
                column: "ReservationID");
        }
    }
}
