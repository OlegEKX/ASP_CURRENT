using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_TrafficRules.Db.Migrations
{
    public partial class FirstQuestionCheck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("9924494e-5640-431e-8b76-65c9b2cdb6b1"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("e0688308-a24a-4ea0-a0de-99dc9314899e"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("e342eb94-bc80-4ce5-979d-f9a08ccd32f7"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("f989844f-cc68-4bcb-b909-5d0569ae4d35"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0a8d907c-e384-4198-bcff-60a9265da009"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("77ed9f93-7122-46e7-9807-e79b389463fe"));

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswerIndex", "Explanation", "Text" },
                values: new object[] { new Guid("482e7e4c-8f91-4673-8170-94508345329c"), 1, "«Вынужденная остановка» - прекращение движения транспортного средства, связанное с его технической неисправностью, опасностью, создаваемой перевозимым грузом, состоянием водителя (пассажира) или появления препятствия на дороге. (Пункт 1.2 ПДД, термин «Вынужденная остановка»)", "В каком случае водитель совершит вынужденную остановку?" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswerIndex", "Explanation", "Text" },
                values: new object[] { new Guid("1822492e-0f6a-46f1-b990-b5e14273b498"), 1, "Объяснение для вопроса 2", "Вопрос 2" });

            migrationBuilder.InsertData(
                table: "QuestionOptions",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("16d7b8d4-6632-47ad-bb74-4c99f2a4274f"), new Guid("482e7e4c-8f91-4673-8170-94508345329c"), "Остановившись непосредственно перед пешеходным переходом, чтобы уступить дорогу пешеходу" },
                    { new Guid("88e98d92-0990-4aef-b704-64147600dfff"), new Guid("482e7e4c-8f91-4673-8170-94508345329c"), "Остановившись на проезжей части из-за технической неисправности транспортного средства" },
                    { new Guid("ac11802b-6acc-4d97-b28b-4058cea47b2e"), new Guid("482e7e4c-8f91-4673-8170-94508345329c"), "В обоих перечисленных случаях" },
                    { new Guid("f1bcb6cf-d06e-4b0d-9af7-d08b81611908"), new Guid("1822492e-0f6a-46f1-b990-b5e14273b498"), "Ответ 2 на вопрос 2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("16d7b8d4-6632-47ad-bb74-4c99f2a4274f"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("88e98d92-0990-4aef-b704-64147600dfff"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("ac11802b-6acc-4d97-b28b-4058cea47b2e"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("f1bcb6cf-d06e-4b0d-9af7-d08b81611908"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1822492e-0f6a-46f1-b990-b5e14273b498"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("482e7e4c-8f91-4673-8170-94508345329c"));

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswerIndex", "Explanation", "Text" },
                values: new object[] { new Guid("0a8d907c-e384-4198-bcff-60a9265da009"), 1, "Объяснение для вопроса 1", "Вопрос 1" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswerIndex", "Explanation", "Text" },
                values: new object[] { new Guid("77ed9f93-7122-46e7-9807-e79b389463fe"), 1, "Объяснение для вопроса 2", "Вопрос 2" });

            migrationBuilder.InsertData(
                table: "QuestionOptions",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("f989844f-cc68-4bcb-b909-5d0569ae4d35"), new Guid("0a8d907c-e384-4198-bcff-60a9265da009"), "Ответ 1 на вопрос 1" },
                    { new Guid("9924494e-5640-431e-8b76-65c9b2cdb6b1"), new Guid("0a8d907c-e384-4198-bcff-60a9265da009"), "Ответ 2 на вопрос 1" },
                    { new Guid("e342eb94-bc80-4ce5-979d-f9a08ccd32f7"), new Guid("77ed9f93-7122-46e7-9807-e79b389463fe"), "Ответ 1 на вопрос 2" },
                    { new Guid("e0688308-a24a-4ea0-a0de-99dc9314899e"), new Guid("77ed9f93-7122-46e7-9807-e79b389463fe"), "Ответ 2 на вопрос 2" }
                });
        }
    }
}
