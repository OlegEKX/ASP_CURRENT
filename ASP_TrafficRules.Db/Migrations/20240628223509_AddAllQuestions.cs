using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_TrafficRules.Db.Migrations
{
    public partial class AddAllQuestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { new Guid("4e198722-6327-49d2-86a3-fd3ab4900c6c"), 1, "«Вынужденная остановка» - прекращение движения транспортного средства, связанное с его технической неисправностью, опасностью, создаваемой перевозимым грузом, состоянием водителя (пассажира) или появления препятствия на дороге. (Пункт 1.2 ПДД, термин «Вынужденная остановка»)", "В каком случае водитель совершит вынужденную остановку?" },
                    { new Guid("e3bb811d-a01f-4826-9941-bf0569d7e662"), 2, "Наиболее полная информация позволяет службе «Скорой медицинской помощи» определиться с количеством высылаемых бригад медицинских специалистов, их специализацией, упрощает выбор пути и сокращает время приезда автомобиля «Скорой медицинской помощи» и других служб.", "Какие сведения необходимо сообщить диспетчеру для вызова «Скорой медицинской помощи» при ДТП?" },
                    { new Guid("246bebd7-aabf-4a00-9b1e-c18a0b61a475"), 2, "Переднеприводные автомобили значительно отличаются своим поведением от заднеприводных. Это обстоятельство следует учитывать во время управления. Учитывайте обстоятельство, что при движении по прямой переднеприводный автомобиль не склонен к заносу на значительно более высоких скоростях по сравнению с заднеприводным. Он хорошо держит дорогу. Но на поворотах, особенно мокрых, обледенелых, если не использовать «технику прохождения поворотов», его может не только занести, а снести, при этом происходит одновременная потеря сцепления колёс обеих осей с дорогой. Это явление, как правило, заканчивается ДТП. Случай заноса задней оси - это «полбеды». В такой ситуации плавно увеличивайте подачу топлива. Сцепление задних колес возрастёт. Рулевым колесом корректируйте направление движения. («Техника управления автомобилем»).", "На повороте возник занос задней оси переднеприводного автомобиля. Ваши действия?" },
                    { new Guid("4b7d95e5-d541-4e3a-8293-5b221b0c4f09"), 3, "Правильный ответ – все перечисленное оборудование, согласно Пункта 21.5 ПДД и Пункта 5 Основных", "Какое оборудование должно иметь механическое транспортное средство, используемое для обучения вождению?" },
                    { new Guid("910299c0-7b1a-4992-9c01-7fb8c8cd002f"), 2, "Выполняя «классический» обгон, Вы должны учитывать три обязательных условия, при выполнении которых, при обгоне не создаёте никаких помех: 1) встречному, 2) едущим позади, 3) обгоняемому. (Пункты 11.1, 11.2 ПДД, «Техника управления автомобилем»)", "В каком случае водитель может начать обгон, если такой маневр на данном участке дороги не запрещен?" },
                    { new Guid("2b3cf2d0-68a6-4494-b90f-765b2f6031c2"), 1, "Подача сигнала указателями поворота должна производиться заблаговременно до начала выполнения маневра и прекращаться немедленно после его завершения. При этом сигнал не должен вводить в заблуждение других участников движения. (Пункт 8.2 ПДД)", "В каких случаях водитель не должен подавать сигнал указателями поворота?" },
                    { new Guid("f1f54467-36db-40b3-874b-07c59d28c2cc"), 2, "В комментариях ответов по медицинским вопросам для лучшего запоминания правильного ответа используется прием «ключевых слов», которые выделены в тексте шрифтом. Обратите на это внимание. Правильный ответ - при отсутствии у пострадавшего сознания, дыхания и кровообращения.", "В каких случаях следует начинать сердечно-легочную реанимацию пострадавшего?" },
                    { new Guid("a3df1a9a-a539-465f-9f8a-99d659a17a35"), 2, "Антиблокировочные системы (АБС) автомобилей представляют собой системы, оснащённые устройствами управления тормозами с обратной связью, которые предотвращают блокировку колёс во время торможения, тем самым сохраняя управляемость и курсовую устойчивость. Эта система имеет «большой плюс», но имеет и «минус». При ускоренном (не экстренном) нажатии на педаль тормоза на разнородном, даже твёрдом дорожном покрытии она может сработать. В момент ее срабатывания (от 1 до 2 сек.) водитель не может повлиять на процесс торможения. Чтобы появился навык управления автомобилем при срабатывании АБС, произведите несколько «контрольных» торможений на абсолютно свободном участке дороги или территории. При прохождении поворота на автомобиль действует центробежная сила. Антиблокировочная система в таких ситуациях не может повлиять на возможность возникновения сноса или заноса.", "Исключает ли антиблокировочная тормозная система возможность возникновения заноса или сноса при прохождении поворота?" },
                    { new Guid("d2a9f931-18f8-4170-8234-f43b69bf9a69"), 0, "Для мототранспортных средств, относящихся к ТС категорий L, остаточная глубина рисунка протектора шин (при отсутствии индикаторов износа), должна быть не более 0,8 мм («Перечень неисправностей» п. 5.4)", "Запрещается эксплуатация мототранспортных средств (категории L), если остаточная глубина рисунка протектора шин (при отсутствии индикаторов износа) составляет не более:" },
                    { new Guid("a8ec6c20-89e2-4c82-8cc6-950391cf6d93"), 1, "Запомните этот ответ. На экзамене часто отвечают, что только на горных дорогах. Видимо, ассоциируется опасность, связанная с высотой. Правилами запрещается буксировка на гибкой сцепке только в гололедицу. (Пункт 20.4 ПДД).", "В каких из перечисленных случаев запрещена буксировка на гибкой сцепке?" },
                    { new Guid("85c3035f-be77-48fb-98c8-cccb780d57fb"), 2, "Наезжать на прерывистые линии разметки разрешается лишь при перестроении. (Пункт 9.7 ПДД)", "В каких случаях разрешается наезжать на прерывистые линии разметки, разделяющие проезжую часть на полосы движения?" },
                    { new Guid("8874804c-0feb-406d-8e61-baba30ed3e27"), 2, "Такая ситуация опасна вследствие возникновения момента сил, стремящегося развернуть автомобиль. Старайтесь плавно вернуть автомобиль на проезжую часть не меняя скорости.", "В случае, когда правые колёса автомобиля наезжают на неукреплённую влажную обочину, рекомендуется:" },
                    { new Guid("94c0f1cf-3c19-44e8-9804-66c6c128bcf7"), 3, "Перечисленные в ответах неисправности, за исключением неработающего стеклоподъёмника, указаны в «Перечне неисправностей». Неработающий стеклоподъемник в данном перечне не указан. Следовательно, это не может быть причиной запрещения эксплуатации транспортного средства. («Перечень неисправностей» п. 8.3, 9.2)", "При какой неисправности разрешается эксплуатация транспортного средства?" },
                    { new Guid("0df65ca7-a619-40c1-87a2-3a958cda16f7"), 3, "Перед началом движения, перестроением, поворотом (разворотом) и остановкой водитель обязан подавать сигналы световыми указателями поворота соответствующего направления, а если они отсутствуют или неисправны – рукой. При выполнении манёвра не должны создаваться опасность для движения, а также помехи другим участникам дорожного движения. (Пункт 8.1 ПДД)", "Водитель обязан подавать сигналы световыми указателями поворота (рукой):" },
                    { new Guid("35adb7d5-9727-430c-a351-3e67d20d2171"), 1, "Длительность мигания зелёного сигнала светофора обычно составляет 3-4 с. Это позволяет водителю заблаговременно, в зависимости от конкретных условий, принять решение: 1) продолжить движение с прежней скоростью; 2) несколько увеличить скорость; 3) начать снижение скорости вплоть до остановки. (Пункт 6.2 ПДД)", "Что означает мигание зелёного сигнала светофора?" },
                    { new Guid("143f4334-af57-4668-bb1c-9b21e090708e"), 1, "Под временем реакции водителя понимается время с момента обнаружения водителем опасности до начала принятия мер по её избежанию. Время реакции водителя - величина непостоянная. В основном зависит от возраста, самочувствия в данный момент. Компенсировать недостаток реакции можно снижением скорости. («Техника управления автомобилем»)", "Что понимается под временем реакции водителя?" },
                    { new Guid("296dd4cb-f26e-4ab1-94fc-df82121ff28f"), 1, "Пункт 9.8 «Перечня неисправностей» запрещает эксплуатацию ТС категории L (мотоциклов), если имеется люфт в соединениях рамы ТС с рамой бокового прицепа.", "В каких случаях запрещается эксплуатация мотоцикла?" },
                    { new Guid("574da1e7-5674-4e07-bb8e-3cad51b2159d"), 2, "Перевозка людей на мотоцикле должна осуществляться водителем, имеющим водительское удостоверение на право управления ТС категории «A» или подкатегории «A1» в течение 2 и более лет.", "Для перевозки людей на мотоцикле водитель должен иметь водительское удостоверение на право управления транспортными средствами:" },
                    { new Guid("92571696-5d42-4ee0-ae39-fa7d1f05c63a"), 1, "Разметка 1.21 (надпись «СТОП») предупреждает о приближении к стоп-линии (разметке 1.12), когда она применяется в сочетании со знаком 2.5 «Движение без остановки запрещено». («Горизонтальная разметка»)", "Что означает разметка в виде надписи «СТОП» на проезжей части?" },
                    { new Guid("3cc72f54-7f11-43c0-9bf0-ae717e0ed992"), 0, "Транспортные средства, скорость которых не должна превышать 40 км/ч или которые по техническим причинам не могут развивать такую скорость, должны двигаться по крайней правой полосе вне зависимости от того, где и по какой дороге происходит движение. Исключением являются случаи объезда, обгона или перестроения перед поворотом или разворотом. (Пункт 9.5 ПДД)", "По какой полосе проезжей части разрешено движение в населённом пункте, если по техническим причинам транспортное средство не может развивать скорость более 40 км/ч?" }
                });

            migrationBuilder.InsertData(
                table: "QuestionOptions",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("247605f2-40bd-4c78-87a9-a6c0c50c7b7e"), new Guid("4e198722-6327-49d2-86a3-fd3ab4900c6c"), "Остановившись непосредственно перед пешеходным переходом, чтобы уступить дорогу пешеходу" },
                    { new Guid("dcc93546-4977-454b-a8d2-8553096b1eba"), new Guid("d2a9f931-18f8-4170-8234-f43b69bf9a69"), "1,0 мм" },
                    { new Guid("313bfcb1-1435-48e7-8a94-fda81619122c"), new Guid("d2a9f931-18f8-4170-8234-f43b69bf9a69"), "1,6 мм" },
                    { new Guid("c173cd9c-338f-49c3-afc0-7a544d511899"), new Guid("d2a9f931-18f8-4170-8234-f43b69bf9a69"), "2,0 мм" },
                    { new Guid("b3503d0b-c925-487c-864d-19e6f8cd7aa3"), new Guid("a3df1a9a-a539-465f-9f8a-99d659a17a35"), "Полностью исключает возможность возникновения только заноса" },
                    { new Guid("5645b0fc-730b-4106-be47-a9acfac1a8aa"), new Guid("a3df1a9a-a539-465f-9f8a-99d659a17a35"), "Полностью исключает возможность возникновения только сноса" },
                    { new Guid("4687606d-4d3a-4ace-b466-4f82c6d0a74c"), new Guid("a3df1a9a-a539-465f-9f8a-99d659a17a35"), "Не исключает возможность возникновения сноса или заноса" },
                    { new Guid("f861712b-88d6-4e33-b6d6-2e1cca467354"), new Guid("f1f54467-36db-40b3-874b-07c59d28c2cc"), "При наличии болей в области сердца и затрудненного дыхания" },
                    { new Guid("ba79b14f-dbf6-4fb1-9532-700203e231b2"), new Guid("f1f54467-36db-40b3-874b-07c59d28c2cc"), "При отсутствии у пострадавшего сознания, независимо от наличия дыхания" },
                    { new Guid("a964a856-989e-4899-b033-d067920f0201"), new Guid("f1f54467-36db-40b3-874b-07c59d28c2cc"), "При отсутствии у пострадавшего сознания, дыхания и кровообращения" },
                    { new Guid("d48fba43-282e-41c0-99c6-0bedaa539e74"), new Guid("2b3cf2d0-68a6-4494-b90f-765b2f6031c2"), "Только при отсутствии на дороге других участников движения" },
                    { new Guid("7561acbe-3992-48bb-a7cc-47b8c14fb57b"), new Guid("2b3cf2d0-68a6-4494-b90f-765b2f6031c2"), "Только если сигнал может ввести в заблуждение других участников движения" },
                    { new Guid("38fb13ab-668e-4bb8-8d44-ba65286c2aee"), new Guid("2b3cf2d0-68a6-4494-b90f-765b2f6031c2"), "В обоих перечисленных случаях" },
                    { new Guid("febb6df2-e920-4195-a382-dab56bc212d6"), new Guid("910299c0-7b1a-4992-9c01-7fb8c8cd002f"), "Только если полоса, предназначенная для встречного движения, свободна на достаточном для обгона расстоянии" },
                    { new Guid("4ae47151-eca6-4456-97cc-7e98b708d0a7"), new Guid("910299c0-7b1a-4992-9c01-7fb8c8cd002f"), "Только если его транспортное средство никто не обгоняет" },
                    { new Guid("207819d5-7884-4abf-ba1e-ea3d06f804fe"), new Guid("d2a9f931-18f8-4170-8234-f43b69bf9a69"), "0,8 мм" },
                    { new Guid("cb98fb14-ae92-44f7-be76-361db24e2bf3"), new Guid("910299c0-7b1a-4992-9c01-7fb8c8cd002f"), "В случае, если выполнены оба условия" },
                    { new Guid("8ac6342f-c909-4ac5-b381-d789c4ac363c"), new Guid("4b7d95e5-d541-4e3a-8293-5b221b0c4f09"), "Зеркало заднего вида для обучающего вождению" },
                    { new Guid("6384305f-9f67-4839-99cf-95b637862e37"), new Guid("4b7d95e5-d541-4e3a-8293-5b221b0c4f09"), "Опознавательные знаки «Учебное транспортное средство»" },
                    { new Guid("5bb56686-3b83-4510-98be-e424f5da9ed2"), new Guid("4b7d95e5-d541-4e3a-8293-5b221b0c4f09"), "Все перечисленное оборудование" },
                    { new Guid("3f1dad28-9554-46c7-bf55-e0d8f2467c05"), new Guid("246bebd7-aabf-4a00-9b1e-c18a0b61a475"), "Уменьшите подачу топлива, рулевым колесом стабилизируете движение" },
                    { new Guid("c0889d78-ca3b-4fda-9fa9-61be1423cdf6"), new Guid("246bebd7-aabf-4a00-9b1e-c18a0b61a475"), "Притормозите и повернёте рулевое колесо в сторону заноса" },
                    { new Guid("e794815c-2083-440a-b9d3-150d928d0253"), new Guid("246bebd7-aabf-4a00-9b1e-c18a0b61a475"), "Слегка увеличите подачу топлива, корректируя направление движения рулевым колесом" },
                    { new Guid("95efb839-08b4-4099-83da-cc7a73162556"), new Guid("246bebd7-aabf-4a00-9b1e-c18a0b61a475"), "Значительно увеличите подачу топлива, не меняя положения рулевого колеса" },
                    { new Guid("44de1ea5-aee0-44e7-b5d8-e5ac6258f76f"), new Guid("e3bb811d-a01f-4826-9941-bf0569d7e662"), "Указать общеизвестные ориентиры, ближайшие к месту ДТП. Сообщить о количестве пострадавших, указать их пол и возраст" },
                    { new Guid("f7150b82-c681-4d26-b229-059dba1dd72b"), new Guid("e3bb811d-a01f-4826-9941-bf0569d7e662"), "Указать улицу и номер дома, ближайшего к месту ДТП. Сообщить, кто пострадал в ДТП (пешеход, водитель автомобиля или пассажиры), и описать травмы, которые они получили." },
                    { new Guid("f94499c7-0c6d-4b04-964f-63bb0ebce50b"), new Guid("e3bb811d-a01f-4826-9941-bf0569d7e662"), "Указать место ДТП (назвать улицу, номер дома и общеизвестные ориентиры, ближайшие к месту ДТП). Сообщить: количество пострадавших, их пол, примерный возраст, наличие у них сознания, дыхания, кровообращения, а также сильного кровотечения, переломов и других травм. Дождаться сообщения диспетчера о том, что вызов принят." },
                    { new Guid("3d2d8aea-8a0f-474a-a2ce-695fd6ec254d"), new Guid("92571696-5d42-4ee0-ae39-fa7d1f05c63a"), "Предупреждает о приближении к стоп-линии перед регулируемым перекрёстком" },
                    { new Guid("7b9fa249-5486-4a94-ae3f-b8f08fb95c55"), new Guid("92571696-5d42-4ee0-ae39-fa7d1f05c63a"), "Предупреждает о приближении к стоп-линии и знаку «Движение без остановки запрещено»" },
                    { new Guid("ec17e09c-7ec8-41be-8a77-3bf4fa851b76"), new Guid("92571696-5d42-4ee0-ae39-fa7d1f05c63a"), "Предупреждает о приближении к знаку «Уступите дорогу»" },
                    { new Guid("d23bb439-1db9-4ce5-ac32-9e4e358dedd0"), new Guid("3cc72f54-7f11-43c0-9bf0-ae717e0ed992"), "Только по крайней правой" },
                    { new Guid("d4e8972e-5281-4597-837e-50fdac533a7f"), new Guid("4b7d95e5-d541-4e3a-8293-5b221b0c4f09"), "Дополнительные педали привода сцепления (кроме транспортных средств с автоматической трансмиссией) и тормоза" },
                    { new Guid("b13cc460-722b-4032-94a4-5b6ac719c224"), new Guid("3cc72f54-7f11-43c0-9bf0-ae717e0ed992"), "Не далее второй полосы" },
                    { new Guid("36a89979-3c4a-4d4d-9b80-f8b50e811f43"), new Guid("a8ec6c20-89e2-4c82-8cc6-950391cf6d93"), "Во всех перечисленных случаях" },
                    { new Guid("62617e7f-f002-4405-8d8c-81ef6d0c1429"), new Guid("a8ec6c20-89e2-4c82-8cc6-950391cf6d93"), "Только в гололедицу" },
                    { new Guid("7cab5f68-aa78-4d60-a945-bc17be20ee2a"), new Guid("4e198722-6327-49d2-86a3-fd3ab4900c6c"), "Остановившись на проезжей части из-за технической неисправности транспортного средства" },
                    { new Guid("2fb1b625-c999-4f0e-90d2-ff83a265ef30"), new Guid("4e198722-6327-49d2-86a3-fd3ab4900c6c"), "В обоих перечисленных случаях" },
                    { new Guid("fa6d2aad-4fc1-4f76-9290-5a2a73ebff71"), new Guid("574da1e7-5674-4e07-bb8e-3cad51b2159d"), "Категории «A» или подкатегории «A1»" },
                    { new Guid("d2386f99-e53a-4895-bc1f-527776dca827"), new Guid("574da1e7-5674-4e07-bb8e-3cad51b2159d"), "Любой категории или подкатегории в течение 2 и более лет" },
                    { new Guid("f32578ce-ec35-4649-bb36-91ae5befc4c4"), new Guid("574da1e7-5674-4e07-bb8e-3cad51b2159d"), "Только категории «A» или подкатегории «A1» в течение 2 и более лет" },
                    { new Guid("ceca68f5-1164-4af0-ad92-f7b2b430a1db"), new Guid("296dd4cb-f26e-4ab1-94fc-df82121ff28f"), "Подножки или рукоятки пассажиров на седле не имеют прорезиненного покрытия" },
                    { new Guid("c46a3e29-d948-4d4f-a366-c2f44f50362c"), new Guid("296dd4cb-f26e-4ab1-94fc-df82121ff28f"), "Имеется люфт в соединениях рамы мотоцикла с рамой бокового прицепа" }
                });

            migrationBuilder.InsertData(
                table: "QuestionOptions",
                columns: new[] { "Id", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("0daf4b70-4f13-4475-8a0a-8883bf11d1f3"), new Guid("296dd4cb-f26e-4ab1-94fc-df82121ff28f"), "Отсутствует огнетушитель" },
                    { new Guid("d0dc0141-fb4b-4fd9-8999-b49339f1f168"), new Guid("143f4334-af57-4668-bb1c-9b21e090708e"), "Время с момента обнаружения водителем опасности до полной остановки транспортного средства" },
                    { new Guid("c8205fcc-61c6-4852-8d68-d6ae5e875bf2"), new Guid("143f4334-af57-4668-bb1c-9b21e090708e"), "Время с момента обнаружения водителем опасности до начала принятия мер по её избежанию" },
                    { new Guid("a892868a-9cc9-4cb5-ad2e-a3b404d6e891"), new Guid("143f4334-af57-4668-bb1c-9b21e090708e"), "Время, необходимое для переноса ноги с педали управления подачи топлива на педаль тормоза" },
                    { new Guid("d75ffc76-d8cb-41bc-a48d-791300478a6b"), new Guid("35adb7d5-9727-430c-a351-3e67d20d2171"), "Предупреждает о неисправности светофора" },
                    { new Guid("813d082d-4d18-4e1d-bfe6-82835a14dceb"), new Guid("35adb7d5-9727-430c-a351-3e67d20d2171"), "Разрешает движение и информирует о том, что вскоре будет включен запрещающий сигнал" },
                    { new Guid("759422c6-7833-499b-a371-a703f7a1506b"), new Guid("35adb7d5-9727-430c-a351-3e67d20d2171"), "Запрещает дальнейшее движение" },
                    { new Guid("e22613cc-dad3-4d1a-8946-56bf9c4a56a4"), new Guid("a8ec6c20-89e2-4c82-8cc6-950391cf6d93"), "Только в тёмное время суток и в условиях недостаточной видимости" },
                    { new Guid("81688a94-459d-47d8-a6ec-a16861e15eb7"), new Guid("0df65ca7-a619-40c1-87a2-3a958cda16f7"), "Перед началом движения или перестроением" },
                    { new Guid("15a24251-6e95-48da-a9f2-8cb96d29f0a5"), new Guid("0df65ca7-a619-40c1-87a2-3a958cda16f7"), "Перед остановкой" },
                    { new Guid("9949c3b4-f42b-4579-a6f5-32c4fc5105a5"), new Guid("0df65ca7-a619-40c1-87a2-3a958cda16f7"), "Во всех перечисленных случаях" },
                    { new Guid("9397776e-6334-4f0e-9091-4617ed04a04f"), new Guid("94c0f1cf-3c19-44e8-9804-66c6c128bcf7"), "Не работают запорные устройства топливных баков" },
                    { new Guid("4565dbcf-51b5-4111-83a2-447a45b2521f"), new Guid("94c0f1cf-3c19-44e8-9804-66c6c128bcf7"), "Не работают механизм регулировки и фиксирующее устройство сиденья водителя" },
                    { new Guid("d3eed6d0-09ff-4254-a050-8ddac946dee5"), new Guid("94c0f1cf-3c19-44e8-9804-66c6c128bcf7"), "Не работает устройство обдува ветрового стекла" },
                    { new Guid("f730c342-277b-4266-a223-926f8e78f897"), new Guid("94c0f1cf-3c19-44e8-9804-66c6c128bcf7"), "Не работает стеклоподъемник" },
                    { new Guid("98c0a376-cfe2-45ba-a8d6-48bd5b1a1f3a"), new Guid("8874804c-0feb-406d-8e61-baba30ed3e27"), "Затормозить и полностью остановиться" },
                    { new Guid("3318de00-00c8-451d-9e9c-3a3d75b99e72"), new Guid("8874804c-0feb-406d-8e61-baba30ed3e27"), "Затормозить и плавно направить автомобиль на проезжую часть" },
                    { new Guid("3f65b564-34a8-4c49-a91e-e1892990e344"), new Guid("8874804c-0feb-406d-8e61-baba30ed3e27"), "Не прибегая к торможению, плавно направить автомобиль на проезжую часть" },
                    { new Guid("432269e0-14ff-4658-938f-11501bf82bab"), new Guid("85c3035f-be77-48fb-98c8-cccb780d57fb"), "Только если на дороге нет других транспортных средств" },
                    { new Guid("a5ae03a5-4199-4da3-83ed-66c67a2e6f29"), new Guid("85c3035f-be77-48fb-98c8-cccb780d57fb"), "Только при движении в темное время суток" },
                    { new Guid("22a3bf34-97f4-4dc0-be5f-f032077ecef6"), new Guid("85c3035f-be77-48fb-98c8-cccb780d57fb"), "Только при перестроении" },
                    { new Guid("0310318d-4d09-4224-a543-b988bb9d710c"), new Guid("85c3035f-be77-48fb-98c8-cccb780d57fb"), "Во всех перечисленных случаях" },
                    { new Guid("493508e4-b69c-4e09-8d5e-c8de0fe561b5"), new Guid("a8ec6c20-89e2-4c82-8cc6-950391cf6d93"), "Только на горных дорогах" },
                    { new Guid("a782f0eb-3ecd-4058-b58b-969464329e3f"), new Guid("0df65ca7-a619-40c1-87a2-3a958cda16f7"), "Перед поворотом или разворотом" },
                    { new Guid("96dde224-a51d-4155-a26e-9be750c4dccf"), new Guid("3cc72f54-7f11-43c0-9bf0-ae717e0ed992"), "По любой, кроме крайней левой" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("0310318d-4d09-4224-a543-b988bb9d710c"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("0daf4b70-4f13-4475-8a0a-8883bf11d1f3"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("15a24251-6e95-48da-a9f2-8cb96d29f0a5"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("207819d5-7884-4abf-ba1e-ea3d06f804fe"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("22a3bf34-97f4-4dc0-be5f-f032077ecef6"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("247605f2-40bd-4c78-87a9-a6c0c50c7b7e"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("2fb1b625-c999-4f0e-90d2-ff83a265ef30"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("313bfcb1-1435-48e7-8a94-fda81619122c"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("3318de00-00c8-451d-9e9c-3a3d75b99e72"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("36a89979-3c4a-4d4d-9b80-f8b50e811f43"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("38fb13ab-668e-4bb8-8d44-ba65286c2aee"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("3d2d8aea-8a0f-474a-a2ce-695fd6ec254d"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("3f1dad28-9554-46c7-bf55-e0d8f2467c05"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("3f65b564-34a8-4c49-a91e-e1892990e344"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("432269e0-14ff-4658-938f-11501bf82bab"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("44de1ea5-aee0-44e7-b5d8-e5ac6258f76f"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("4565dbcf-51b5-4111-83a2-447a45b2521f"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("4687606d-4d3a-4ace-b466-4f82c6d0a74c"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("493508e4-b69c-4e09-8d5e-c8de0fe561b5"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("4ae47151-eca6-4456-97cc-7e98b708d0a7"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("5645b0fc-730b-4106-be47-a9acfac1a8aa"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("5bb56686-3b83-4510-98be-e424f5da9ed2"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("62617e7f-f002-4405-8d8c-81ef6d0c1429"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("6384305f-9f67-4839-99cf-95b637862e37"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("7561acbe-3992-48bb-a7cc-47b8c14fb57b"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("759422c6-7833-499b-a371-a703f7a1506b"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("7b9fa249-5486-4a94-ae3f-b8f08fb95c55"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("7cab5f68-aa78-4d60-a945-bc17be20ee2a"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("813d082d-4d18-4e1d-bfe6-82835a14dceb"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("81688a94-459d-47d8-a6ec-a16861e15eb7"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("8ac6342f-c909-4ac5-b381-d789c4ac363c"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("9397776e-6334-4f0e-9091-4617ed04a04f"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("95efb839-08b4-4099-83da-cc7a73162556"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("96dde224-a51d-4155-a26e-9be750c4dccf"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("98c0a376-cfe2-45ba-a8d6-48bd5b1a1f3a"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("9949c3b4-f42b-4579-a6f5-32c4fc5105a5"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("a5ae03a5-4199-4da3-83ed-66c67a2e6f29"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("a782f0eb-3ecd-4058-b58b-969464329e3f"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("a892868a-9cc9-4cb5-ad2e-a3b404d6e891"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("a964a856-989e-4899-b033-d067920f0201"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("b13cc460-722b-4032-94a4-5b6ac719c224"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("b3503d0b-c925-487c-864d-19e6f8cd7aa3"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("ba79b14f-dbf6-4fb1-9532-700203e231b2"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("c0889d78-ca3b-4fda-9fa9-61be1423cdf6"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("c173cd9c-338f-49c3-afc0-7a544d511899"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("c46a3e29-d948-4d4f-a366-c2f44f50362c"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("c8205fcc-61c6-4852-8d68-d6ae5e875bf2"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("cb98fb14-ae92-44f7-be76-361db24e2bf3"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("ceca68f5-1164-4af0-ad92-f7b2b430a1db"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("d0dc0141-fb4b-4fd9-8999-b49339f1f168"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("d2386f99-e53a-4895-bc1f-527776dca827"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("d23bb439-1db9-4ce5-ac32-9e4e358dedd0"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("d3eed6d0-09ff-4254-a050-8ddac946dee5"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("d48fba43-282e-41c0-99c6-0bedaa539e74"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("d4e8972e-5281-4597-837e-50fdac533a7f"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("d75ffc76-d8cb-41bc-a48d-791300478a6b"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("dcc93546-4977-454b-a8d2-8553096b1eba"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("e22613cc-dad3-4d1a-8946-56bf9c4a56a4"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("e794815c-2083-440a-b9d3-150d928d0253"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("ec17e09c-7ec8-41be-8a77-3bf4fa851b76"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("f32578ce-ec35-4649-bb36-91ae5befc4c4"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("f7150b82-c681-4d26-b229-059dba1dd72b"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("f730c342-277b-4266-a223-926f8e78f897"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("f861712b-88d6-4e33-b6d6-2e1cca467354"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("f94499c7-0c6d-4b04-964f-63bb0ebce50b"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("fa6d2aad-4fc1-4f76-9290-5a2a73ebff71"));

            migrationBuilder.DeleteData(
                table: "QuestionOptions",
                keyColumn: "Id",
                keyValue: new Guid("febb6df2-e920-4195-a382-dab56bc212d6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0df65ca7-a619-40c1-87a2-3a958cda16f7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("143f4334-af57-4668-bb1c-9b21e090708e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("246bebd7-aabf-4a00-9b1e-c18a0b61a475"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("296dd4cb-f26e-4ab1-94fc-df82121ff28f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2b3cf2d0-68a6-4494-b90f-765b2f6031c2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("35adb7d5-9727-430c-a351-3e67d20d2171"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3cc72f54-7f11-43c0-9bf0-ae717e0ed992"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4b7d95e5-d541-4e3a-8293-5b221b0c4f09"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4e198722-6327-49d2-86a3-fd3ab4900c6c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("574da1e7-5674-4e07-bb8e-3cad51b2159d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("85c3035f-be77-48fb-98c8-cccb780d57fb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8874804c-0feb-406d-8e61-baba30ed3e27"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("910299c0-7b1a-4992-9c01-7fb8c8cd002f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("92571696-5d42-4ee0-ae39-fa7d1f05c63a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("94c0f1cf-3c19-44e8-9804-66c6c128bcf7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a3df1a9a-a539-465f-9f8a-99d659a17a35"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a8ec6c20-89e2-4c82-8cc6-950391cf6d93"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d2a9f931-18f8-4170-8234-f43b69bf9a69"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e3bb811d-a01f-4826-9941-bf0569d7e662"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f1f54467-36db-40b3-874b-07c59d28c2cc"));

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
    }
}
