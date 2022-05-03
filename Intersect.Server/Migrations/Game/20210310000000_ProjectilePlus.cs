using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations.Game
{
    public partial class ProjectilePlus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OneCollide2KillSpawns",
                table: "Projectiles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "StaticProjectile",
                table: "Projectiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "StaticProjectileAnim",
                table: "Projectiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "OnlyRenderEnabled",
                table: "Projectiles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "OnlyRenderX",
                table: "Projectiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OnlyRenderY",
                table: "Projectiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OnlyRenderD",
                table: "Projectiles",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OneCollide2KillSpawns",
                table: "Projectiles");

            migrationBuilder.DropColumn(
                name: "StaticProjectile",
                table: "Projectiles");

            migrationBuilder.DropColumn(
                name: "StaticProjectileAnim",
                table: "Projectiles");

            migrationBuilder.DropColumn(
                name: "OnlyRenderEnabled",
                table: "Projectiles");

            migrationBuilder.DropColumn(
                name: "OnlyRenderX",
                table: "Projectiles");

            migrationBuilder.DropColumn(
                name: "OnlyRenderY",
                table: "Projectiles");

            migrationBuilder.DropColumn(
                name: "OnlyRenderD",
                table: "Projectiles");
        }
    }
}
