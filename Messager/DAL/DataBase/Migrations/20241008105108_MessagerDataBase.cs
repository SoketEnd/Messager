using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Messager.Migrations
{
    /// <inheritdoc />
    public partial class MessagerDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MessageDataBase",
                columns: table => new
                {
                    MessegeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageDataBase", x => x.MessegeID);
                });

            migrationBuilder.CreateTable(
                name: "UserDataBase",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDataBase", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserFriendsDataBase",
                columns: table => new
                {
                    FriendID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserDataBaseEntityUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFriendsDataBase", x => x.FriendID);
                    table.ForeignKey(
                        name: "FK_UserFriendsDataBase_UserDataBase_UserDataBaseEntityUserId",
                        column: x => x.UserDataBaseEntityUserId,
                        principalTable: "UserDataBase",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserFriendsDataBase_UserDataBaseEntityUserId",
                table: "UserFriendsDataBase",
                column: "UserDataBaseEntityUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageDataBase");

            migrationBuilder.DropTable(
                name: "UserFriendsDataBase");

            migrationBuilder.DropTable(
                name: "UserDataBase");
        }
    }
}
