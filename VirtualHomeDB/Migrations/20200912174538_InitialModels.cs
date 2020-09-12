using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualHomeDAL.Migrations
{
    public partial class InitialModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DoorLock",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsPowered = table.Column<bool>(nullable: false),
                    LocationId = table.Column<Guid>(nullable: true),
                    Lock = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorLock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoorLock_Room_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Light",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsPowered = table.Column<bool>(nullable: false),
                    LocationId = table.Column<Guid>(nullable: true),
                    Color = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Light", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Light_Room_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Resident",
                columns: table => new
                {
                    ResidentId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LocalizationId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resident", x => x.ResidentId);
                    table.ForeignKey(
                        name: "FK_Resident_Room_LocalizationId",
                        column: x => x.LocalizationId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TV",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsPowered = table.Column<bool>(nullable: false),
                    LocationId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TV", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TV_Room_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoorLock_LocationId",
                table: "DoorLock",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Light_LocationId",
                table: "Light",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Resident_LocalizationId",
                table: "Resident",
                column: "LocalizationId");

            migrationBuilder.CreateIndex(
                name: "IX_TV_LocationId",
                table: "TV",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoorLock");

            migrationBuilder.DropTable(
                name: "Light");

            migrationBuilder.DropTable(
                name: "Resident");

            migrationBuilder.DropTable(
                name: "TV");

            migrationBuilder.DropTable(
                name: "Room");
        }
    }
}
