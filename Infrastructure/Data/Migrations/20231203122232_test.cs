using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReservationsHistory",
                columns: table => new
                {
                    ReservationID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    MovieTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationsHistory", x => x.ReservationID);
                });

            migrationBuilder.CreateTable(
                name: "ReserverSeatsHistory",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationID = table.Column<long>(type: "bigint", nullable: false),
                    SeatID = table.Column<long>(type: "bigint", nullable: false),
                    SeatNumber = table.Column<long>(type: "bigint", nullable: false),
                    SeatRow = table.Column<long>(type: "bigint", nullable: false),
                    TicketType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketPrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReserverSeatsHistory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReserverSeatsHistory_ReservationsHistory_ReservationID",
                        column: x => x.ReservationID,
                        principalTable: "ReservationsHistory",
                        principalColumn: "ReservationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReserverSeatsHistory_ReservationID",
                table: "ReserverSeatsHistory",
                column: "ReservationID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReserverSeatsHistory");

            migrationBuilder.DropTable(
                name: "ReservationsHistory");
        }
    }
}
