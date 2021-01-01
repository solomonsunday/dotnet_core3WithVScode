using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace netCore3._1.Migrations
{
    public partial class FinalSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, new byte[] { 112, 37, 97, 238, 11, 73, 152, 3, 214, 64, 160, 71, 174, 60, 110, 69, 40, 193, 145, 239, 58, 179, 16, 215, 126, 151, 230, 54, 135, 102, 150, 147, 102, 149, 85, 199, 37, 166, 118, 141, 149, 26, 249, 116, 164, 250, 144, 173, 0, 227, 170, 185, 177, 64, 243, 222, 153, 2, 143, 224, 113, 154, 202, 134 }, new byte[] { 105, 96, 43, 237, 231, 253, 16, 86, 186, 119, 1, 206, 80, 238, 164, 73, 250, 115, 24, 213, 134, 66, 201, 21, 249, 48, 154, 41, 172, 193, 115, 190, 126, 255, 65, 167, 50, 220, 191, 17, 117, 60, 58, 25, 233, 32, 48, 215, 152, 236, 30, 80, 231, 207, 249, 17, 52, 116, 55, 74, 18, 149, 40, 89, 242, 163, 26, 69, 168, 214, 131, 101, 133, 239, 80, 84, 121, 142, 217, 70, 239, 81, 11, 36, 141, 166, 88, 50, 168, 47, 18, 25, 115, 67, 22, 149, 149, 116, 141, 209, 42, 68, 44, 1, 2, 144, 173, 60, 112, 130, 242, 210, 123, 23, 53, 155, 36, 14, 79, 84, 40, 108, 141, 55, 158, 119, 164, 213 }, "User1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 2, new byte[] { 112, 37, 97, 238, 11, 73, 152, 3, 214, 64, 160, 71, 174, 60, 110, 69, 40, 193, 145, 239, 58, 179, 16, 215, 126, 151, 230, 54, 135, 102, 150, 147, 102, 149, 85, 199, 37, 166, 118, 141, 149, 26, 249, 116, 164, 250, 144, 173, 0, 227, 170, 185, 177, 64, 243, 222, 153, 2, 143, 224, 113, 154, 202, 134 }, new byte[] { 105, 96, 43, 237, 231, 253, 16, 86, 186, 119, 1, 206, 80, 238, 164, 73, 250, 115, 24, 213, 134, 66, 201, 21, 249, 48, 154, 41, 172, 193, 115, 190, 126, 255, 65, 167, 50, 220, 191, 17, 117, 60, 58, 25, 233, 32, 48, 215, 152, 236, 30, 80, 231, 207, 249, 17, 52, 116, 55, 74, 18, 149, 40, 89, 242, 163, 26, 69, 168, 214, 131, 101, 133, 239, 80, 84, 121, 142, 217, 70, 239, 81, 11, 36, 141, 166, 88, 50, 168, 47, 18, 25, 115, 67, 22, 149, 149, 116, 141, 209, 42, 68, 44, 1, 2, 144, 173, 60, 112, 130, 242, 210, 123, 23, 53, 155, 36, 14, 79, 84, 40, 108, 141, 55, 158, 119, 164, 213 }, "User2" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defence", "Fights", "Hitpoint", "Name", "Strength", "UserId", "Victories", "intelligence" },
                values: new object[] { 1, 1, 0, 10, 0, 100, "Frodo", 15, 1, 0, 10 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defence", "Fights", "Hitpoint", "Name", "Strength", "UserId", "Victories", "intelligence" },
                values: new object[] { 2, 2, 0, 5, 0, 100, "Raistlin", 5, 2, 0, 20 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 1, 1, 20, "The Master Sword" });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 2, 2, 20, "Crystal Wand" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
