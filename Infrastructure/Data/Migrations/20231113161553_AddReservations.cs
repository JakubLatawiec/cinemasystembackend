using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddReservations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TicketTypes",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReservedSeats",
                columns: table => new
                {
                    SeatID = table.Column<long>(type: "bigint", nullable: false),
                    ReservationID = table.Column<long>(type: "bigint", nullable: false),
                    ScreeningID = table.Column<long>(type: "bigint", nullable: false),
                    TicketTypeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservedSeats", x => new { x.ScreeningID, x.SeatID, x.ReservationID, x.TicketTypeID });
                    table.ForeignKey(
                        name: "FK_ReservedSeats_Reservations_ReservationID",
                        column: x => x.ReservationID,
                        principalTable: "Reservations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservedSeats_Screenings_ScreeningID",
                        column: x => x.ScreeningID,
                        principalTable: "Screenings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservedSeats_Seats_SeatID",
                        column: x => x.SeatID,
                        principalTable: "Seats",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ReservedSeats_TicketTypes_TicketTypeID",
                        column: x => x.TicketTypeID,
                        principalTable: "TicketTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservedSeats_ReservationID",
                table: "ReservedSeats",
                column: "ReservationID");

            migrationBuilder.CreateIndex(
                name: "IX_ReservedSeats_SeatID",
                table: "ReservedSeats",
                column: "SeatID");

            migrationBuilder.CreateIndex(
                name: "IX_ReservedSeats_TicketTypeID",
                table: "ReservedSeats",
                column: "TicketTypeID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservedSeats");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "TicketTypes");
        }
    }
}
