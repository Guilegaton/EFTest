using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EFTest.Migrations
{
    public partial class AddTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomName = table.Column<string>(nullable: false),
                    RoomPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomName);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    RoomName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUsers_Rooms_RoomName",
                        column: x => x.RoomName,
                        principalTable: "Rooms",
                        principalColumn: "RoomName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Traks",
                columns: table => new
                {
                    TrackName = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Album = table.Column<string>(nullable: true),
                    AudioChanels = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Bitrate = table.Column<string>(nullable: true),
                    Bits = table.Column<string>(nullable: true),
                    FileSize = table.Column<int>(nullable: false),
                    Genre = table.Column<string>(nullable: true),
                    Group = table.Column<string>(nullable: true),
                    Length = table.Column<string>(nullable: true),
                    RoomName = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traks", x => x.TrackName);
                    table.ForeignKey(
                        name: "FK_Traks_Rooms_RoomName",
                        column: x => x.RoomName,
                        principalTable: "Rooms",
                        principalColumn: "RoomName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_RoomName",
                table: "ApplicationUsers",
                column: "RoomName");

            migrationBuilder.CreateIndex(
                name: "IX_Traks_RoomName",
                table: "Traks",
                column: "RoomName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "Traks");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
