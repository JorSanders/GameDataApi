using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

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
                    ApexId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApexCharacter", x => x.ApexId);
                });

            migrationBuilder.CreateTable(
                name: "ApexMatches",
                columns: table => new
                {
                    ApexMatchId = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CharacterApexId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ApexMatches", x => x.ApexMatchId);
                    table.ForeignKey(
                        name: "FK_ApexMatches_ApexCharacter_CharacterApexId",
                        column: x => x.CharacterApexId,
                        principalTable: "ApexCharacter",
                        principalColumn: "ApexId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApexMatches_CharacterApexId",
                table: "ApexMatches",
                column: "CharacterApexId");
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
