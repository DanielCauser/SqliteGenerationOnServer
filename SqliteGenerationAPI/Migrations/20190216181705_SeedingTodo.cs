using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SqliteGenerationAPI.Migrations
{
    public partial class SeedingTodo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("e3c24f99-dff9-4beb-ba7c-0403af5030f8"), "Gallegos Norris" },
                    { new Guid("05170285-393f-4ac6-a300-490f331c1fe4"), "Muriel Berg" },
                    { new Guid("7f87e8ae-646a-458d-a005-51a69e890c9c"), "Morgan Melendez" },
                    { new Guid("e8dd358e-24bc-4690-b9ff-8689fb0b8c59"), "Serena James" },
                    { new Guid("c365d2f4-6153-4590-b1e0-fbf9bd5a6414"), "Carney Love" },
                    { new Guid("3f1cd8a0-22a1-4464-b35d-3c7b54b44e68"), "Wooten Hardy" },
                    { new Guid("f477450d-8b0e-4422-b4e2-88c869dfbeaf"), "Esmeralda Huff" },
                    { new Guid("4543784e-1029-4deb-9201-31c0d6ecd0a6"), "Noble Henson" },
                    { new Guid("9daf0e41-d192-4d64-8d4e-8871bfa43d0f"), "Rosalyn Munoz" },
                    { new Guid("45c1e77f-ee38-408a-b0ff-f15d8d5d00d6"), "Hall Figueroa" },
                    { new Guid("19e0e505-084d-4a5e-a254-deb1dda86644"), "Adrienne Johnson" },
                    { new Guid("61a32fba-4df2-4d37-98aa-037a6d16d17b"), "Macias Sheppard" },
                    { new Guid("c8f92a1a-a85c-4f7f-8f89-7a68e1bc0cc0"), "Stacy Coffey" },
                    { new Guid("20613d5e-3918-4e79-8c3c-b66c5fb4dab6"), "Alejandra Brewer" },
                    { new Guid("238f7bbf-69f2-42bc-8a54-b6c5e1a17db6"), "Jenna Becker" },
                    { new Guid("2abab35d-0a5d-4fcf-a128-5bcadb81b8ba"), "Marsha Nguyen" },
                    { new Guid("3bfab04a-538c-4bce-bb58-465504761f9f"), "Tia Blackwell" },
                    { new Guid("6998624c-31f7-477f-be93-e39abe81efc0"), "Sloan Lopez" },
                    { new Guid("f3326200-0264-4943-92a6-5fa9935d6667"), "Kathie Rivers" },
                    { new Guid("5262ae5d-f7ce-4eb5-a0f4-4018dec17aff"), "Audrey Petersen" },
                    { new Guid("12126223-6dca-401e-9db9-c508cc494cfa"), "Callie Heath" },
                    { new Guid("6e08fb95-ce73-4aa0-98f2-1d685fd47824"), "Valencia Newton" },
                    { new Guid("3446f2ba-d66b-43e0-af88-1c8a0d1d1c67"), "Johanna Bryant" },
                    { new Guid("1de6ab7f-0dac-4951-9c1a-b4a09afb88c2"), "Teresa Stuart" },
                    { new Guid("6d80678e-6489-4c79-bc61-49d41f421cd7"), "Knox Malone" },
                    { new Guid("dde56be2-b8bc-49c9-b7b7-d4ad397ba2d5"), "Juliana Mosley" },
                    { new Guid("7e353322-bdcf-4f1b-acb5-b1424eac9948"), "Annmarie Bentley" },
                    { new Guid("2443b8e9-c9ac-49fb-a02d-ba7d62ba8f0b"), "Buchanan Owens" },
                    { new Guid("77aa91f6-5eaf-43db-a36e-b7d4f2cfb5fc"), "Yates Dominguez" },
                    { new Guid("72d3a744-9690-48ab-9785-61f1fe42383b"), "Minerva Roberson" },
                    { new Guid("4777683d-114c-48c3-84fb-6ef472b527fc"), "Stephenson Meyer" },
                    { new Guid("e735d90f-2428-4008-82d3-8b6fd76276f2"), "Michael Kelley" },
                    { new Guid("11032ec6-16ea-4cd4-807e-9cd06cbf7a43"), "Simpson Franco" },
                    { new Guid("c2384b26-db9c-4c33-9a9a-76a7190356f0"), "Leslie Osborne" },
                    { new Guid("809f5182-318f-462f-93f2-011279f73f92"), "Spencer Rodriguez" },
                    { new Guid("fa3cbd8c-0091-416f-8aaa-f43878b62d47"), "Wilkins Mills" },
                    { new Guid("a700fd18-a212-4d0e-87de-ba9fea18d0f2"), "Goldie Peterson" },
                    { new Guid("64e109a0-7fed-42ce-bf7e-b259ef861545"), "Blanchard Rowland" },
                    { new Guid("703e77a3-3fa1-4ce0-8da4-a3321d8c9c41"), "Florence Riddle" },
                    { new Guid("dd16904b-9549-44c0-bdef-426c47f87526"), "Stefanie Oconnor" },
                    { new Guid("c8dad318-a6fa-41b3-962f-838bd2516453"), "Alisha Spears" },
                    { new Guid("a7639694-779d-42de-9937-51e1050710ec"), "Winters Mcmahon" },
                    { new Guid("4e118340-c046-4d77-820a-9d1fe9413c81"), "Rush Mcconnell" },
                    { new Guid("6fc28855-e17d-479c-aa3f-574107e34a9c"), "Harrison Rodriquez" },
                    { new Guid("19332ab3-9b7d-46f0-b9dd-7935ea2390f2"), "Meredith Dillon" },
                    { new Guid("05edbb03-277a-4a00-978d-1adf83ec9d53"), "Head Hayes" },
                    { new Guid("0dd882c6-978c-4635-bbcc-6444fffb6b19"), "Belinda Flowers" },
                    { new Guid("a4cabaa8-2323-4490-95cf-ec7ae563aa50"), "Benita Keith" },
                    { new Guid("eaff15f5-9759-4b5f-a1f4-60e1a996ed85"), "Larson Mclaughlin" },
                    { new Guid("2fa95658-ec95-44a4-a4d4-992eeb78edcd"), "Ester Russo" },
                    { new Guid("f836b2b7-f1dd-4ab7-8de6-ffdbd7de8835"), "Celina Flores" },
                    { new Guid("77d148c1-b5f9-4738-b649-01059b40986a"), "Hurley Villarreal" },
                    { new Guid("fe7a1cc8-038b-4048-be09-0a26485afd45"), "Hardin Berger" },
                    { new Guid("d6bf009c-4953-48c0-8183-f7547bf1d5e5"), "Grace Tucker" },
                    { new Guid("775166cd-2ce3-4e6e-8e51-d315d919f098"), "Sofia Macdonald" },
                    { new Guid("c8a6d3b4-70b8-4a29-b7d6-6b5c66bf547c"), "Amber Simpson" },
                    { new Guid("cc18f34b-677e-4016-bc7c-0a95aee2950d"), "Tamera Guy" },
                    { new Guid("643d3ecb-aff7-4b73-8d4e-70e67e66d66c"), "Frank Francis" },
                    { new Guid("d72aa55f-6c5a-477a-ab5f-86d0cb8db7f0"), "Cindy Kelly" },
                    { new Guid("a4030eaa-c732-42d9-838a-d05ef95c6607"), "Bridges Lloyd" },
                    { new Guid("c22b4d11-a277-406e-94d6-1ee6bc0c57e7"), "Salas Hays" },
                    { new Guid("daf1c3f4-6d58-423b-8da7-a3922d02b8ab"), "Sykes Page" },
                    { new Guid("1db530af-77be-4504-ae52-f678f0888721"), "Alyce Lawrence" },
                    { new Guid("9a5a5b82-aeb2-4ced-b95b-e915dd17d778"), "Henry Potts" },
                    { new Guid("cc7ee913-5cd2-4c3b-9c39-1efd5abc24fb"), "Monroe Nixon" },
                    { new Guid("74ffda92-288b-41fa-8a18-63ebb3a51fb8"), "Chaney Leblanc" },
                    { new Guid("631dd0ed-46cf-45f3-a1da-c67669afad79"), "Carole Wallace" },
                    { new Guid("3373e0c2-84bf-4c0e-af31-02cad00068d9"), "Cantrell Ball" },
                    { new Guid("985285d5-8217-485e-ba72-ffac713f001c"), "Reyes Ortiz" },
                    { new Guid("2edcd56f-09b4-4d1b-a0ff-7d5837983821"), "Slater Rocha" },
                    { new Guid("8a114cc6-bb0a-4970-a853-52dbf2f00cc7"), "Johnnie Parker" },
                    { new Guid("328e1c8a-6dbc-429d-a77e-ac06a856927c"), "Brittany Ware" },
                    { new Guid("94574c5e-be79-4ae4-af2d-16c6cd29398d"), "Dolly Garrett" },
                    { new Guid("8446d65d-67ee-41c1-a212-4b748ba0faf3"), "Ballard Dalton" },
                    { new Guid("bc078a41-545a-4cf9-86df-3f3d098814be"), "Fuller Williams" },
                    { new Guid("25b3757d-fdf1-4f3b-88e9-220f636617b6"), "Love Sampson" },
                    { new Guid("f38ebea5-dd31-4410-8a00-38cb5f745c92"), "Mann Fox" },
                    { new Guid("adfbd5a9-7867-4afb-b1cf-cd122bbe71c5"), "Ryan Hyde" },
                    { new Guid("e9492aa0-e17b-4dcd-9422-03257133d785"), "Cunningham Key" },
                    { new Guid("494da0f3-65ab-4d56-93ba-8ff34552c281"), "Emilia Ferrell" },
                    { new Guid("522961f6-ba8f-4c55-8eb5-a3de6129f94a"), "Toni Rosario" },
                    { new Guid("aaa0e0ff-f800-4b04-bfc1-ffe631ba284c"), "Rowland Horton" },
                    { new Guid("00be4758-f431-4e6c-ae7d-5f69209d8588"), "Nell Warner" },
                    { new Guid("f5ceee14-74f9-4bf7-a132-3fc07f5562dd"), "Gentry Estrada" },
                    { new Guid("ec7c9de8-d7cf-4881-a2c8-60b4f55dfd73"), "Le Byers" },
                    { new Guid("a205612a-c40c-404d-8a19-44aea6088c08"), "Vonda Mathis" },
                    { new Guid("a7555264-32a6-46f9-a57d-b53d51046282"), "Bonita Camacho" },
                    { new Guid("97673b81-e260-4aa7-bb16-fa00b33e739e"), "Sherrie Manning" },
                    { new Guid("4696e565-731b-4f4e-a0f5-09413c913903"), "Mcfarland House" },
                    { new Guid("5235b3b2-d6a3-4331-b06b-38be7bd5a972"), "Alissa Witt" },
                    { new Guid("5c9262c8-2f40-4d6a-b88d-8488856c4ed6"), "Dixon Ayala" },
                    { new Guid("2da73933-c861-4ee4-929d-e6099926a8ea"), "Cleveland Galloway" },
                    { new Guid("099c071c-bb73-4f2b-8e99-6a0db273b4b0"), "Shirley Dale" },
                    { new Guid("4395cb5f-d143-4271-83c6-1d0934ddbb61"), "Dora Valentine" },
                    { new Guid("f89bf56c-f9d2-4c84-a5d4-b56ea1ad1a1a"), "Davis Reed" },
                    { new Guid("84481229-883d-4c0c-bbad-a47e2d773716"), "Christa Clark" },
                    { new Guid("44618e07-df5b-49f4-8ad3-f03a1d7a37da"), "Anna Glover" },
                    { new Guid("6144d8b0-61b7-4d58-ae62-0d30044d19b2"), "Mccullough Smith" },
                    { new Guid("9a0ff858-8b34-4173-8687-50425b487918"), "Jordan Farmer" },
                    { new Guid("2a1acb0d-c80e-4a1c-a88d-40b9870d61b1"), "Roxie Hensley" },
                    { new Guid("0bc11c43-b7ce-4e27-aeb2-7d4dd713fd90"), "Franks Alston" },
                    { new Guid("7824cf3c-4238-423f-9e80-a7fff58aeeb0"), "Mays Mathews" },
                    { new Guid("06bcbb7c-b38d-45fb-a264-34574aaad239"), "Doris Duncan" },
                    { new Guid("58d9437c-a058-40c0-a4e5-8fe68627236b"), "Dillard Burgess" },
                    { new Guid("ad48c9a4-e4c3-4851-912e-2c3081ebe54c"), "Lawrence Briggs" },
                    { new Guid("7ae7cd0e-f854-4983-9a1e-9fdd828585bf"), "Moody Hatfield" },
                    { new Guid("7749c094-e9d6-4cad-8fa3-76ebd1328105"), "Faith Logan" },
                    { new Guid("159ce043-81b6-4a1a-b98b-4bf5a1445c1b"), "Morin Hamilton" },
                    { new Guid("68a164b8-7193-4731-9021-18e8e94f1df8"), "Finley Walter" },
                    { new Guid("46c9ff48-4c96-4be9-b47d-2f4ee0dc96a6"), "Krista Browning" },
                    { new Guid("89df2622-515c-4a1f-a9a5-e846d2a38771"), "Leonor Chavez" },
                    { new Guid("b6d73bfa-d40d-48be-8b04-74293ae796f9"), "Mcpherson Conway" },
                    { new Guid("d7aceaac-6483-4bd9-b056-6ff63ae9ea61"), "Washington Holmes" },
                    { new Guid("6327a7e7-1748-444c-8179-7db21632b0ac"), "Manuela Santos" },
                    { new Guid("997ebe55-1caf-44ef-a10c-88924540c514"), "Fernandez Garner" },
                    { new Guid("a8f154cb-4d82-40c5-88bb-4fec011a25c3"), "Berg Eaton" },
                    { new Guid("a6e19f37-cc88-40d0-ac07-82927a7c7904"), "Rachelle Kaufman" },
                    { new Guid("df700e77-1a86-47a9-b7b2-07ac6baca9da"), "Elsie Cabrera" },
                    { new Guid("eb35e52d-e6cc-4a19-b848-f813db53102a"), "Bridget Cameron" },
                    { new Guid("c16a5e12-0a38-4db7-9634-51e8d0c65e8d"), "Morton Haynes" },
                    { new Guid("b66c3c03-d4e6-41c8-8a23-bee74abee65e"), "Jordan Gross" },
                    { new Guid("a5df9f04-abca-4cb3-83ff-50b2b0b461cc"), "Martina Wilcox" },
                    { new Guid("7a667033-d55b-4366-a1bb-ff56698b5847"), "Everett Meyers" },
                    { new Guid("655d9e99-8217-48a0-a106-bc90ca9cdeef"), "Mclaughlin Hess" },
                    { new Guid("4b76f2fb-fb29-4297-af1f-fe927b683fc3"), "Talley Moran" },
                    { new Guid("284f8c8d-282a-4ae3-9da9-55e337a23f8a"), "Hester Massey" },
                    { new Guid("1ddc71b6-e3bf-4dd2-af4e-b1b32f113c9c"), "Virginia Puckett" },
                    { new Guid("d68ebacd-c0bc-4f0a-9c4b-00755e7cd40e"), "Santiago Ortega" },
                    { new Guid("4774b99d-5712-4c0b-8d56-be82fc3100cb"), "Rosanne England" },
                    { new Guid("44a88ec9-0a02-400e-805e-cc666aa4988e"), "Leann Mack" },
                    { new Guid("d8c86c59-2a0e-4a54-a6af-3747bff0b8bb"), "Mcdonald Beck" },
                    { new Guid("07c2f2e7-ad1e-4257-b852-17030e93dbad"), "Frye Kirk" },
                    { new Guid("f7cc596d-227e-4b05-a81e-fceb26f47b88"), "Raquel Lucas" },
                    { new Guid("fbace607-7be6-4117-8d5e-3b4ab29759ff"), "Parks Mcfarland" },
                    { new Guid("88617282-316a-4c2e-8601-99d0044a9a3d"), "Joyner Cain" },
                    { new Guid("666fd9b0-1f52-4345-9f9d-6f7d20d11dc8"), "Bentley Carr" },
                    { new Guid("f6f798b4-64f9-4e83-bef8-02dc4b670886"), "Walls Cooke" },
                    { new Guid("9a4b4ad8-4790-419a-aa3b-3ebd916198df"), "Gina Burt" },
                    { new Guid("7703e075-e351-4e29-a3fe-9516c44c1e22"), "Johnston Leon" },
                    { new Guid("743a39d4-53d6-46cd-bc9d-df49256a90b4"), "Maricela Lindsay" },
                    { new Guid("8328e49f-7ffc-457a-b105-48dd364c751f"), "Gutierrez Downs" },
                    { new Guid("96762d05-c4a8-4670-88a5-5018da3db43e"), "Stanton Gray" },
                    { new Guid("c97986df-8cf7-42bf-911a-535742461f59"), "Carpenter Mccarty" },
                    { new Guid("3e6e9127-bfd4-449a-8fb2-d9ce22eb2969"), "Durham Burks" },
                    { new Guid("3c0add16-4ad3-4fab-afd8-5b8b0d4ad1bc"), "Bauer Small" },
                    { new Guid("ea7abf14-e5a4-4120-851f-4298374e13bb"), "Lowe Pierce" },
                    { new Guid("7d32706a-01c7-426a-9dae-9b4cd9e0d250"), "Haley Aguilar" },
                    { new Guid("9360fe17-f1ef-47b5-b2fe-af3c38d37820"), "Elena Mcgee" },
                    { new Guid("6b444d73-fe37-4fd9-b005-786c23338c1f"), "Stevenson Cooley" },
                    { new Guid("2df93a20-4baa-4de8-ac38-a7d0985a7106"), "Corrine Pate" },
                    { new Guid("6f8addc2-fe3d-4815-92eb-e5f44bf01b6c"), "Conner Dickson" },
                    { new Guid("6cb4314f-6e1a-413b-844b-e5a68d348d55"), "Luna Petty" },
                    { new Guid("82ecd529-c7dd-4a4f-9a15-5a822cf04ebb"), "Clara Curry" },
                    { new Guid("ceb0895d-51c2-486e-91ef-4d6a173ff71e"), "Fitzpatrick Prince" },
                    { new Guid("7c589217-39a7-4794-bdcf-e01ed7537189"), "Guadalupe Hobbs" },
                    { new Guid("de15aa6d-a320-42dc-b8c5-5c6f1dec8c99"), "Barr Boone" },
                    { new Guid("de1cc276-7679-4d97-b3bc-d5d8a658ec50"), "Wilder Daniel" },
                    { new Guid("3d48adf8-c2ce-4cc5-b451-961f48ec833e"), "Medina Hawkins" },
                    { new Guid("9f7f43c2-0b1e-4389-b8ae-ac1188b739c6"), "Schneider Rosa" },
                    { new Guid("b556f8cb-1062-4c3d-9d0c-e17ad558ba81"), "Trina Cherry" },
                    { new Guid("ce96af70-4bb2-446e-b6e4-bc2e9ef20c5a"), "Emma Sloan" },
                    { new Guid("5ca5c472-72ad-4bb2-8739-78c59946fb1a"), "Rosalie Mckinney" },
                    { new Guid("465ac419-00f1-48d4-ae01-e230f83e77bc"), "Glass Hoffman" },
                    { new Guid("36d134d9-036a-4e43-96a6-870ff89720d8"), "Lakisha Mason" },
                    { new Guid("32ced3dd-aa1f-49a0-b7fb-53d885a24e1c"), "Louisa Bush" },
                    { new Guid("4a5cc53f-9bb8-49b7-b754-a91d26e16115"), "Guerra Roy" },
                    { new Guid("2b73188a-688a-4613-b2e6-dcbe6e021bb4"), "Castaneda Kane" },
                    { new Guid("1a1614ae-05d6-49d5-9ebc-d57228e7c5b3"), "Weaver Baxter" },
                    { new Guid("5d762595-c24c-4956-8884-22d82355bd14"), "Laura Dunn" },
                    { new Guid("ad74b918-9e88-4896-8c69-4ada2e2ef545"), "Moses Boyd" },
                    { new Guid("ecbd8706-b74e-4248-8c5a-09a0c27faae9"), "Terry Vaughn" },
                    { new Guid("11a4f265-5286-49d8-9863-d1a81f4b8c56"), "Coleen Barron" },
                    { new Guid("10ffd9ca-4088-4394-b2ba-eeb7ef591299"), "Jeanne Riley" },
                    { new Guid("108cec1e-254e-4e4f-99d4-0c4daffb9c13"), "Solis Hancock" },
                    { new Guid("46b35499-525c-4407-b5e4-27da2dfe3abf"), "Bullock Sykes" },
                    { new Guid("a10952a4-2f6f-4e37-ae44-13a4118f9635"), "Blanca Dejesus" },
                    { new Guid("e81d84d7-7be6-4c3c-96fe-45b92e024915"), "Benjamin Frank" },
                    { new Guid("4cff2132-94dc-482a-86eb-cbccd5bb6fed"), "Gray Pope" },
                    { new Guid("f17ed061-1c09-4d5e-bf6a-3fbd0335ae8a"), "Janine Atkinson" },
                    { new Guid("b0b6f4e6-94ab-4fc2-9f46-19bb2efa3a89"), "Yvonne Booker" },
                    { new Guid("4d1ee3bc-ccbf-4985-b28f-047e3cc6ac64"), "Baird Alford" },
                    { new Guid("1bc0dd7b-ad98-485c-93fc-38a4b0f301fd"), "Mathews Rios" },
                    { new Guid("ac57c222-66e2-4ce4-8200-c8e69c77b39c"), "Janis Monroe" },
                    { new Guid("2ccecc6d-0fbc-44f2-82ca-6e2aa8623003"), "Blankenship Head" },
                    { new Guid("184c59ed-6184-4884-9651-d6f05229934a"), "Saunders Vazquez" },
                    { new Guid("535acff3-61b7-4da1-8131-64e4be6446c8"), "Turner Burnett" },
                    { new Guid("54bd7ea7-80fa-4751-843a-9893356aef64"), "Nannie Benton" },
                    { new Guid("585313a6-1def-4529-905d-a2bf6279a3b3"), "Magdalena Higgins" },
                    { new Guid("5b0fcca5-1aa4-42e4-bdb8-1eb2ac5147cc"), "Valerie Pacheco" },
                    { new Guid("cb6946a2-1c1f-4937-9a7f-9bcdefbf2014"), "Ruth Larsen" },
                    { new Guid("80945226-8fb4-493e-a7ce-89d8401a472f"), "Rosario Mitchell" },
                    { new Guid("142d8ce7-cacb-40b6-8efa-906cdefb299e"), "Ora Long" },
                    { new Guid("8731a8d0-aa0d-479d-ae87-52cdd420f781"), "Gracie Drake" },
                    { new Guid("ea0b9f78-0a82-4e2b-af8f-0be98ff3a08d"), "Atkins Shelton" },
                    { new Guid("37518099-4d8c-4d2f-8ffe-9250ffdb90c4"), "Ana Navarro" },
                    { new Guid("5004208d-eaf3-4d9f-9db6-d9d9a36b8b23"), "Scott Guthrie" },
                    { new Guid("a56cae9d-d137-4d19-bd26-074b4c2df0c6"), "Barton Phelps" },
                    { new Guid("371dbebd-4206-4f46-8436-3e125193e28f"), "Hoover Parrish" },
                    { new Guid("672b290e-ea71-4c7a-8b77-cc13a17f99a7"), "Fry Avila" },
                    { new Guid("59fb150d-63be-47f4-88bb-a974eedcf9d6"), "Etta Ferguson" },
                    { new Guid("a6cf9745-c4a9-45ed-beb8-457efd6510e5"), "Alexis Santana" },
                    { new Guid("12a0d19f-a698-43bd-a05b-3f314c00be10"), "Benson Walters" },
                    { new Guid("b94de15b-ddb5-4d54-89bc-085d9a3cf8c1"), "Aguilar Barker" },
                    { new Guid("635d64f0-fa4e-4898-a4e8-41b0adea2785"), "Mclean Fischer" },
                    { new Guid("cef23722-b1db-4833-84cb-8c6ad656d06c"), "Bond Donovan" },
                    { new Guid("67e24043-1809-4a9c-935e-148fe5116925"), "Sherman Savage" },
                    { new Guid("c8ed2537-796f-4224-ab2b-226f24033b85"), "Wanda Mcleod" },
                    { new Guid("a6d1cba3-9e5a-4d99-9803-61475f64c685"), "Jana Ruiz" },
                    { new Guid("4f4da900-7821-4464-b2c2-13e90228d41f"), "Caroline Shaw" },
                    { new Guid("83bdc455-503c-43b2-b7cd-2ea4bc54e286"), "Mercado Combs" },
                    { new Guid("c1ba28ec-0d24-44e9-87a8-b5e7671a76db"), "Bernadette Schroeder" },
                    { new Guid("f961c4b7-e25b-451e-bd8c-6d01349e8792"), "Hart Romero" },
                    { new Guid("8c26e9d1-9e01-4c3e-9a8a-6a88cdededd4"), "Hopper Walton" },
                    { new Guid("d6e2f37d-dc50-4e2c-80dd-dca5fb2cb319"), "Oneil Black" },
                    { new Guid("e930a274-5f26-45e2-95ff-6f226e6132bc"), "Knapp Shields" },
                    { new Guid("d80ef2b4-0ce1-41ae-a46d-afbbd6080c4b"), "Howard Ellis" },
                    { new Guid("387079f3-64d1-4f59-b148-edced2323acd"), "Tessa Gonzalez" },
                    { new Guid("26411e07-4e6a-4155-b9f8-6b1c78b50590"), "Sears Mooney" },
                    { new Guid("fdaa86cd-0244-48cb-8bdd-1284f82e594d"), "Lena Levy" },
                    { new Guid("bad33e22-1577-4802-9fa5-0a350ba40910"), "Barbara Dillard" },
                    { new Guid("a827da45-77e8-4951-b7a0-32ecec64932c"), "Cruz Maddox" },
                    { new Guid("e97a27b4-1b10-410c-8a22-fe9f0706e9c2"), "Harriet Dodson" },
                    { new Guid("26c52abe-562b-4b2b-8fcb-79d8ea4dd648"), "Mckee Collins" },
                    { new Guid("df0d2b5f-efd3-4407-bde3-47d7f0ac1aee"), "Randall Dunlap" },
                    { new Guid("c6506c67-42b0-404c-a4a3-46456ee54023"), "Allen Morin" },
                    { new Guid("c4f73f53-5491-4119-ab8d-48916cb33493"), "Juliet Barry" },
                    { new Guid("0c9e6dd9-7566-4be1-8080-365961b6ee1f"), "Gonzalez Vargas" },
                    { new Guid("28c56388-4539-4a7b-aee8-9f479d84cc1c"), "Watson Welch" },
                    { new Guid("28f8aa2c-866a-49d1-b471-7c3c3df42d46"), "Adeline Ingram" },
                    { new Guid("07c1db04-b47e-4c6d-9457-6442126f4c09"), "Shaw Townsend" },
                    { new Guid("58fdb625-4acb-4132-87a4-908c48eb99f1"), "Sandra Pruitt" },
                    { new Guid("5edacc6f-e942-4f0d-91e3-37cbd2ad8fe7"), "Willa Mccormick" },
                    { new Guid("aa581604-ea45-4188-a2de-92a46f3fbf04"), "Jannie Crane" },
                    { new Guid("dd71fd44-c5d9-4d1b-a988-e2c6a203344e"), "Autumn Jimenez" },
                    { new Guid("a5a09a9b-a8f5-4008-aaff-e5cec6b51c6b"), "Ivy Bird" },
                    { new Guid("112fe488-6a82-47a6-8c42-a1040848ba01"), "Blanche Edwards" },
                    { new Guid("c9d61437-aaf9-40c0-9a64-0f5dba9efddc"), "Jimenez Todd" },
                    { new Guid("ea21ebcc-940a-4687-ae43-9b535c6a4106"), "Fuentes Bartlett" },
                    { new Guid("e9f8096c-73fd-4fec-b90d-9e72ac7d0daa"), "Erin Fulton" },
                    { new Guid("80ab2acc-0291-42d0-8b3e-a6fc8a9486ff"), "Perez Hendricks" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("00be4758-f431-4e6c-ae7d-5f69209d8588"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("05170285-393f-4ac6-a300-490f331c1fe4"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("05edbb03-277a-4a00-978d-1adf83ec9d53"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("06bcbb7c-b38d-45fb-a264-34574aaad239"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("07c1db04-b47e-4c6d-9457-6442126f4c09"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("07c2f2e7-ad1e-4257-b852-17030e93dbad"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("099c071c-bb73-4f2b-8e99-6a0db273b4b0"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("0bc11c43-b7ce-4e27-aeb2-7d4dd713fd90"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("0c9e6dd9-7566-4be1-8080-365961b6ee1f"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("0dd882c6-978c-4635-bbcc-6444fffb6b19"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("108cec1e-254e-4e4f-99d4-0c4daffb9c13"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("10ffd9ca-4088-4394-b2ba-eeb7ef591299"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("11032ec6-16ea-4cd4-807e-9cd06cbf7a43"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("112fe488-6a82-47a6-8c42-a1040848ba01"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("11a4f265-5286-49d8-9863-d1a81f4b8c56"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("12126223-6dca-401e-9db9-c508cc494cfa"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("12a0d19f-a698-43bd-a05b-3f314c00be10"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("142d8ce7-cacb-40b6-8efa-906cdefb299e"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("159ce043-81b6-4a1a-b98b-4bf5a1445c1b"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("184c59ed-6184-4884-9651-d6f05229934a"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("19332ab3-9b7d-46f0-b9dd-7935ea2390f2"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("19e0e505-084d-4a5e-a254-deb1dda86644"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("1a1614ae-05d6-49d5-9ebc-d57228e7c5b3"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("1bc0dd7b-ad98-485c-93fc-38a4b0f301fd"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("1db530af-77be-4504-ae52-f678f0888721"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("1ddc71b6-e3bf-4dd2-af4e-b1b32f113c9c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("1de6ab7f-0dac-4951-9c1a-b4a09afb88c2"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("20613d5e-3918-4e79-8c3c-b66c5fb4dab6"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("238f7bbf-69f2-42bc-8a54-b6c5e1a17db6"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("2443b8e9-c9ac-49fb-a02d-ba7d62ba8f0b"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("25b3757d-fdf1-4f3b-88e9-220f636617b6"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("26411e07-4e6a-4155-b9f8-6b1c78b50590"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("26c52abe-562b-4b2b-8fcb-79d8ea4dd648"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("284f8c8d-282a-4ae3-9da9-55e337a23f8a"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("28c56388-4539-4a7b-aee8-9f479d84cc1c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("28f8aa2c-866a-49d1-b471-7c3c3df42d46"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("2a1acb0d-c80e-4a1c-a88d-40b9870d61b1"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("2abab35d-0a5d-4fcf-a128-5bcadb81b8ba"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("2b73188a-688a-4613-b2e6-dcbe6e021bb4"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("2ccecc6d-0fbc-44f2-82ca-6e2aa8623003"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("2da73933-c861-4ee4-929d-e6099926a8ea"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("2df93a20-4baa-4de8-ac38-a7d0985a7106"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("2edcd56f-09b4-4d1b-a0ff-7d5837983821"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("2fa95658-ec95-44a4-a4d4-992eeb78edcd"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("328e1c8a-6dbc-429d-a77e-ac06a856927c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("32ced3dd-aa1f-49a0-b7fb-53d885a24e1c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("3373e0c2-84bf-4c0e-af31-02cad00068d9"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("3446f2ba-d66b-43e0-af88-1c8a0d1d1c67"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("36d134d9-036a-4e43-96a6-870ff89720d8"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("371dbebd-4206-4f46-8436-3e125193e28f"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("37518099-4d8c-4d2f-8ffe-9250ffdb90c4"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("387079f3-64d1-4f59-b148-edced2323acd"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("3bfab04a-538c-4bce-bb58-465504761f9f"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("3c0add16-4ad3-4fab-afd8-5b8b0d4ad1bc"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("3d48adf8-c2ce-4cc5-b451-961f48ec833e"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("3e6e9127-bfd4-449a-8fb2-d9ce22eb2969"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("3f1cd8a0-22a1-4464-b35d-3c7b54b44e68"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("4395cb5f-d143-4271-83c6-1d0934ddbb61"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("44618e07-df5b-49f4-8ad3-f03a1d7a37da"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("44a88ec9-0a02-400e-805e-cc666aa4988e"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("4543784e-1029-4deb-9201-31c0d6ecd0a6"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("45c1e77f-ee38-408a-b0ff-f15d8d5d00d6"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("465ac419-00f1-48d4-ae01-e230f83e77bc"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("4696e565-731b-4f4e-a0f5-09413c913903"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("46b35499-525c-4407-b5e4-27da2dfe3abf"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("46c9ff48-4c96-4be9-b47d-2f4ee0dc96a6"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("4774b99d-5712-4c0b-8d56-be82fc3100cb"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("4777683d-114c-48c3-84fb-6ef472b527fc"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("494da0f3-65ab-4d56-93ba-8ff34552c281"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("4a5cc53f-9bb8-49b7-b754-a91d26e16115"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("4b76f2fb-fb29-4297-af1f-fe927b683fc3"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("4cff2132-94dc-482a-86eb-cbccd5bb6fed"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("4d1ee3bc-ccbf-4985-b28f-047e3cc6ac64"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("4e118340-c046-4d77-820a-9d1fe9413c81"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("4f4da900-7821-4464-b2c2-13e90228d41f"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("5004208d-eaf3-4d9f-9db6-d9d9a36b8b23"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("522961f6-ba8f-4c55-8eb5-a3de6129f94a"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("5235b3b2-d6a3-4331-b06b-38be7bd5a972"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("5262ae5d-f7ce-4eb5-a0f4-4018dec17aff"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("535acff3-61b7-4da1-8131-64e4be6446c8"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("54bd7ea7-80fa-4751-843a-9893356aef64"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("585313a6-1def-4529-905d-a2bf6279a3b3"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("58d9437c-a058-40c0-a4e5-8fe68627236b"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("58fdb625-4acb-4132-87a4-908c48eb99f1"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("59fb150d-63be-47f4-88bb-a974eedcf9d6"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("5b0fcca5-1aa4-42e4-bdb8-1eb2ac5147cc"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("5c9262c8-2f40-4d6a-b88d-8488856c4ed6"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("5ca5c472-72ad-4bb2-8739-78c59946fb1a"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("5d762595-c24c-4956-8884-22d82355bd14"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("5edacc6f-e942-4f0d-91e3-37cbd2ad8fe7"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("6144d8b0-61b7-4d58-ae62-0d30044d19b2"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("61a32fba-4df2-4d37-98aa-037a6d16d17b"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("631dd0ed-46cf-45f3-a1da-c67669afad79"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("6327a7e7-1748-444c-8179-7db21632b0ac"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("635d64f0-fa4e-4898-a4e8-41b0adea2785"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("643d3ecb-aff7-4b73-8d4e-70e67e66d66c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("64e109a0-7fed-42ce-bf7e-b259ef861545"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("655d9e99-8217-48a0-a106-bc90ca9cdeef"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("666fd9b0-1f52-4345-9f9d-6f7d20d11dc8"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("672b290e-ea71-4c7a-8b77-cc13a17f99a7"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("67e24043-1809-4a9c-935e-148fe5116925"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("68a164b8-7193-4731-9021-18e8e94f1df8"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("6998624c-31f7-477f-be93-e39abe81efc0"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("6b444d73-fe37-4fd9-b005-786c23338c1f"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("6cb4314f-6e1a-413b-844b-e5a68d348d55"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("6d80678e-6489-4c79-bc61-49d41f421cd7"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("6e08fb95-ce73-4aa0-98f2-1d685fd47824"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("6f8addc2-fe3d-4815-92eb-e5f44bf01b6c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("6fc28855-e17d-479c-aa3f-574107e34a9c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("703e77a3-3fa1-4ce0-8da4-a3321d8c9c41"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("72d3a744-9690-48ab-9785-61f1fe42383b"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("743a39d4-53d6-46cd-bc9d-df49256a90b4"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("74ffda92-288b-41fa-8a18-63ebb3a51fb8"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("7703e075-e351-4e29-a3fe-9516c44c1e22"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("7749c094-e9d6-4cad-8fa3-76ebd1328105"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("775166cd-2ce3-4e6e-8e51-d315d919f098"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("77aa91f6-5eaf-43db-a36e-b7d4f2cfb5fc"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("77d148c1-b5f9-4738-b649-01059b40986a"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("7824cf3c-4238-423f-9e80-a7fff58aeeb0"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("7a667033-d55b-4366-a1bb-ff56698b5847"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("7ae7cd0e-f854-4983-9a1e-9fdd828585bf"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("7c589217-39a7-4794-bdcf-e01ed7537189"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("7d32706a-01c7-426a-9dae-9b4cd9e0d250"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("7e353322-bdcf-4f1b-acb5-b1424eac9948"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("7f87e8ae-646a-458d-a005-51a69e890c9c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("80945226-8fb4-493e-a7ce-89d8401a472f"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("809f5182-318f-462f-93f2-011279f73f92"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("80ab2acc-0291-42d0-8b3e-a6fc8a9486ff"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("82ecd529-c7dd-4a4f-9a15-5a822cf04ebb"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("8328e49f-7ffc-457a-b105-48dd364c751f"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("83bdc455-503c-43b2-b7cd-2ea4bc54e286"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("8446d65d-67ee-41c1-a212-4b748ba0faf3"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("84481229-883d-4c0c-bbad-a47e2d773716"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("8731a8d0-aa0d-479d-ae87-52cdd420f781"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("88617282-316a-4c2e-8601-99d0044a9a3d"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("89df2622-515c-4a1f-a9a5-e846d2a38771"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("8a114cc6-bb0a-4970-a853-52dbf2f00cc7"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("8c26e9d1-9e01-4c3e-9a8a-6a88cdededd4"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("9360fe17-f1ef-47b5-b2fe-af3c38d37820"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("94574c5e-be79-4ae4-af2d-16c6cd29398d"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("96762d05-c4a8-4670-88a5-5018da3db43e"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("97673b81-e260-4aa7-bb16-fa00b33e739e"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("985285d5-8217-485e-ba72-ffac713f001c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("997ebe55-1caf-44ef-a10c-88924540c514"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("9a0ff858-8b34-4173-8687-50425b487918"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("9a4b4ad8-4790-419a-aa3b-3ebd916198df"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("9a5a5b82-aeb2-4ced-b95b-e915dd17d778"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("9daf0e41-d192-4d64-8d4e-8871bfa43d0f"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("9f7f43c2-0b1e-4389-b8ae-ac1188b739c6"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("a10952a4-2f6f-4e37-ae44-13a4118f9635"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("a205612a-c40c-404d-8a19-44aea6088c08"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("a4030eaa-c732-42d9-838a-d05ef95c6607"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("a4cabaa8-2323-4490-95cf-ec7ae563aa50"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("a56cae9d-d137-4d19-bd26-074b4c2df0c6"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("a5a09a9b-a8f5-4008-aaff-e5cec6b51c6b"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("a5df9f04-abca-4cb3-83ff-50b2b0b461cc"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("a6cf9745-c4a9-45ed-beb8-457efd6510e5"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("a6d1cba3-9e5a-4d99-9803-61475f64c685"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("a6e19f37-cc88-40d0-ac07-82927a7c7904"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("a700fd18-a212-4d0e-87de-ba9fea18d0f2"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("a7555264-32a6-46f9-a57d-b53d51046282"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("a7639694-779d-42de-9937-51e1050710ec"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("a827da45-77e8-4951-b7a0-32ecec64932c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("a8f154cb-4d82-40c5-88bb-4fec011a25c3"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("aa581604-ea45-4188-a2de-92a46f3fbf04"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("aaa0e0ff-f800-4b04-bfc1-ffe631ba284c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("ac57c222-66e2-4ce4-8200-c8e69c77b39c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("ad48c9a4-e4c3-4851-912e-2c3081ebe54c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("ad74b918-9e88-4896-8c69-4ada2e2ef545"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("adfbd5a9-7867-4afb-b1cf-cd122bbe71c5"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("b0b6f4e6-94ab-4fc2-9f46-19bb2efa3a89"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("b556f8cb-1062-4c3d-9d0c-e17ad558ba81"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("b66c3c03-d4e6-41c8-8a23-bee74abee65e"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("b6d73bfa-d40d-48be-8b04-74293ae796f9"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("b94de15b-ddb5-4d54-89bc-085d9a3cf8c1"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("bad33e22-1577-4802-9fa5-0a350ba40910"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("bc078a41-545a-4cf9-86df-3f3d098814be"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("c16a5e12-0a38-4db7-9634-51e8d0c65e8d"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("c1ba28ec-0d24-44e9-87a8-b5e7671a76db"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("c22b4d11-a277-406e-94d6-1ee6bc0c57e7"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("c2384b26-db9c-4c33-9a9a-76a7190356f0"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("c365d2f4-6153-4590-b1e0-fbf9bd5a6414"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("c4f73f53-5491-4119-ab8d-48916cb33493"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("c6506c67-42b0-404c-a4a3-46456ee54023"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("c8a6d3b4-70b8-4a29-b7d6-6b5c66bf547c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("c8dad318-a6fa-41b3-962f-838bd2516453"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("c8ed2537-796f-4224-ab2b-226f24033b85"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("c8f92a1a-a85c-4f7f-8f89-7a68e1bc0cc0"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("c97986df-8cf7-42bf-911a-535742461f59"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("c9d61437-aaf9-40c0-9a64-0f5dba9efddc"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("cb6946a2-1c1f-4937-9a7f-9bcdefbf2014"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("cc18f34b-677e-4016-bc7c-0a95aee2950d"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("cc7ee913-5cd2-4c3b-9c39-1efd5abc24fb"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("ce96af70-4bb2-446e-b6e4-bc2e9ef20c5a"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("ceb0895d-51c2-486e-91ef-4d6a173ff71e"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("cef23722-b1db-4833-84cb-8c6ad656d06c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("d68ebacd-c0bc-4f0a-9c4b-00755e7cd40e"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("d6bf009c-4953-48c0-8183-f7547bf1d5e5"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("d6e2f37d-dc50-4e2c-80dd-dca5fb2cb319"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("d72aa55f-6c5a-477a-ab5f-86d0cb8db7f0"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("d7aceaac-6483-4bd9-b056-6ff63ae9ea61"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("d80ef2b4-0ce1-41ae-a46d-afbbd6080c4b"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("d8c86c59-2a0e-4a54-a6af-3747bff0b8bb"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("daf1c3f4-6d58-423b-8da7-a3922d02b8ab"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("dd16904b-9549-44c0-bdef-426c47f87526"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("dd71fd44-c5d9-4d1b-a988-e2c6a203344e"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("dde56be2-b8bc-49c9-b7b7-d4ad397ba2d5"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("de15aa6d-a320-42dc-b8c5-5c6f1dec8c99"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("de1cc276-7679-4d97-b3bc-d5d8a658ec50"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("df0d2b5f-efd3-4407-bde3-47d7f0ac1aee"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("df700e77-1a86-47a9-b7b2-07ac6baca9da"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("e3c24f99-dff9-4beb-ba7c-0403af5030f8"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("e735d90f-2428-4008-82d3-8b6fd76276f2"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("e81d84d7-7be6-4c3c-96fe-45b92e024915"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("e8dd358e-24bc-4690-b9ff-8689fb0b8c59"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("e930a274-5f26-45e2-95ff-6f226e6132bc"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("e9492aa0-e17b-4dcd-9422-03257133d785"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("e97a27b4-1b10-410c-8a22-fe9f0706e9c2"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("e9f8096c-73fd-4fec-b90d-9e72ac7d0daa"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("ea0b9f78-0a82-4e2b-af8f-0be98ff3a08d"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("ea21ebcc-940a-4687-ae43-9b535c6a4106"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("ea7abf14-e5a4-4120-851f-4298374e13bb"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("eaff15f5-9759-4b5f-a1f4-60e1a996ed85"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("eb35e52d-e6cc-4a19-b848-f813db53102a"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("ec7c9de8-d7cf-4881-a2c8-60b4f55dfd73"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("ecbd8706-b74e-4248-8c5a-09a0c27faae9"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("f17ed061-1c09-4d5e-bf6a-3fbd0335ae8a"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("f3326200-0264-4943-92a6-5fa9935d6667"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("f38ebea5-dd31-4410-8a00-38cb5f745c92"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("f477450d-8b0e-4422-b4e2-88c869dfbeaf"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("f5ceee14-74f9-4bf7-a132-3fc07f5562dd"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("f6f798b4-64f9-4e83-bef8-02dc4b670886"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("f7cc596d-227e-4b05-a81e-fceb26f47b88"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("f836b2b7-f1dd-4ab7-8de6-ffdbd7de8835"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("f89bf56c-f9d2-4c84-a5d4-b56ea1ad1a1a"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("f961c4b7-e25b-451e-bd8c-6d01349e8792"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("fa3cbd8c-0091-416f-8aaa-f43878b62d47"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("fbace607-7be6-4117-8d5e-3b4ab29759ff"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("fdaa86cd-0244-48cb-8bdd-1284f82e594d"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("fe7a1cc8-038b-4048-be09-0a26485afd45"));
        }
    }
}
