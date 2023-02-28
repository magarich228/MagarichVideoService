using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagarichVideoService.Users.DAL.Migrations
{
    /// Миграция инициализации БД
    public partial class InitialCreate : Migration
    {
        /// Создание таблицы пользователя и учетных данных пользователя
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NickName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    CreatedUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsersCredentials",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Password = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersCredentials", x => new { x.UserId, x.Email });
                    table.ForeignKey(
                        name: "FK_UsersCredentials_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersCredentials_UserId",
                table: "UsersCredentials",
                column: "UserId",
                unique: true);
        }

        /// Удаление таблицы пользователя и учетных данных пользователя
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersCredentials");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
