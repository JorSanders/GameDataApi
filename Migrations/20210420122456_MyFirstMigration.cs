using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameDataApi.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApexCharacter",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    ApexId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApexCharacter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApexMatches",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    ApexMatchId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CharacterId = table.Column<byte[]>(type: "varbinary(16)", nullable: true),
                    PlayerLevel = table.Column<long>(type: "bigint", nullable: true),
                    Kills = table.Column<long>(type: "bigint", nullable: true),
                    Damage = table.Column<long>(type: "bigint", nullable: true),
                    Headshots = table.Column<long>(type: "bigint", nullable: true),
                    Revives = table.Column<long>(type: "bigint", nullable: true),
                    RankScore = table.Column<long>(type: "bigint", nullable: true),
                    RankScoreChange = table.Column<long>(type: "bigint", nullable: true),
                    EyeEnemiesScanned = table.Column<long>(type: "bigint", nullable: true),
                    SmokeGrenadeEnemiesHit = table.Column<long>(type: "bigint", nullable: true),
                    DomeDamageBlocked = table.Column<long>(type: "bigint", nullable: true),
                    RiftsSquadmatesPhased = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApexMatches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApexMatches_ApexCharacter_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "ApexCharacter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApexMatches_CharacterId",
                table: "ApexMatches",
                column: "CharacterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApexMatches");

            migrationBuilder.DropTable(
                name: "ApexCharacter");
        }
    }
}
