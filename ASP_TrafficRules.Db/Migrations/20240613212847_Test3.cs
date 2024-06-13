using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_TrafficRules.Db.Migrations
{
    public partial class Test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswerIndex", "Explanation", "Text" },
                values: new object[] { new Guid("bd2f9cc1-b0ff-4af5-9e65-8a7b9faab576"), 1, "Объяснение для вопроса 1", "Вопрос 1" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswerIndex", "Explanation", "Text" },
                values: new object[] { new Guid("d4fe0285-36bf-4609-b002-fcca23ba576b"), 2, "Объяснение для вопроса 2", "Вопрос 2" });

            migrationBuilder.InsertData(
                table: "QuestionOptions",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("7dbd7dc9-ac00-4cfb-950f-846422c94d5a"), new Guid("bd2f9cc1-b0ff-4af5-9e65-8a7b9faab576"), "Ответ 1 на вопрос 1" },
                    { new Guid("126a3f06-e786-4579-849a-92931dea5039"), new Guid("bd2f9cc1-b0ff-4af5-9e65-8a7b9faab576"), "Ответ 1 на вопрос 1" },
                    { new Guid("6cc97476-67de-4b8c-ba7b-f44de1d8a621"), new Guid("bd2f9cc1-b0ff-4af5-9e65-8a7b9faab576"), "Ответ 1 на вопрос 1" },
                    { new Guid("ab908e12-bbe0-4703-9b39-8aca024a2545"), new Guid("bd2f9cc1-b0ff-4af5-9e65-8a7b9faab576"), "Ответ 1 на вопрос 1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("126a3f06-e786-4579-849a-92931dea5039"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("6cc97476-67de-4b8c-ba7b-f44de1d8a621"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("7dbd7dc9-ac00-4cfb-950f-846422c94d5a"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("ab908e12-bbe0-4703-9b39-8aca024a2545"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d4fe0285-36bf-4609-b002-fcca23ba576b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bd2f9cc1-b0ff-4af5-9e65-8a7b9faab576"));
        }
    }
}
