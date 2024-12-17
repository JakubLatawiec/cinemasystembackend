using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReservationsHistory",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    ReservationHistoryID = table.Column<long>(type: "bigint", nullable: false),
                    SeatID = table.Column<long>(type: "bigint", nullable: false),
                    SeatNumber = table.Column<long>(type: "bigint", nullable: false),
                    SeatRow = table.Column<long>(type: "bigint", nullable: false),
                    TicketType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservedSeatsHistory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReservedSeatsHistory_ReservationsHistory_ReservationHistoryID",
                        column: x => x.ReservationHistoryID,
                        principalTable: "ReservationsHistory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservedSeatsHistory_ReservationHistoryID",
                table: "ReservedSeatsHistory",
                column: "ReservationHistoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservedSeatsHistory");

            migrationBuilder.DropTable(
                name: "ReservationsHistory");
        }
    }
}
