using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace solace.Migrations
{
    /// <inheritdoc />
    public partial class SeedItemTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "item_type_model",
                columns: new[] { "id", "elligible_placement", "is_limited_use", "name", "player_equippable" },
                values: new object[,]
                {
                    { 1, new[] { 0 }, false, "Headwear", true },
                    { 2, new[] { 2 }, false, "FacialMask", true },
                    { 3, new[] { 5 }, false, "Necklace", true },
                    { 4, new[] { 1 }, false, "Earrings", true },
                    { 5, new[] { 0 }, false, "HairAccessory", true },
                    { 6, new[] { 15 }, false, "Chestplate", true },
                    { 7, new[] { 15 }, false, "Tunic", true },
                    { 8, new[] { 15 }, false, "Skirt", true },
                    { 9, new[] { 6 }, false, "Overwear", true },
                    { 10, new[] { 15 }, false, "Undergarment", true },
                    { 11, new[] { 16 }, false, "Belt", true },
                    { 12, new[] { 16 }, false, "WaistPouch", true },
                    { 13, new[] { 7, 8 }, false, "ShoulderPads", true },
                    { 14, new[] { 9, 10 }, false, "ArmGuard", true },
                    { 15, new[] { 13, 14 }, false, "WristBand", true },
                    { 16, new[] { 11, 12 }, false, "Gauntlets", true },
                    { 17, new[] { 11, 12 }, false, "Gloves", true },
                    { 18, new[] { 17, 18 }, false, "ThighArmor", true },
                    { 19, new[] { 17, 18 }, false, "Pants", true },
                    { 20, new[] { 19, 20 }, false, "Greaves", true },
                    { 21, new[] { 21, 22 }, false, "Boots", true },
                    { 22, new[] { 23, 24 }, false, "AnkleCuffs", true },
                    { 23, new[] { 35, 40 }, false, "ToeRings", true },
                    { 24, null, true, "Potion", false },
                    { 25, new[] { 15 }, false, "ToolKit", true },
                    { 26, null, false, "Paper", false },
                    { 27, new[] { 13, 14 }, false, "Bracelet", true },
                    { 28, new[] { 11 }, false, "OneHandedWeapon", true },
                    { 29, new[] { 11, 12 }, false, "TwoHandedWeapon", true },
                    { 30, new[] { 11 }, false, "SmallWeapon", true },
                    { 31, new[] { 23, 24 }, false, "Anklet", true },
                    { 40, new[] { 11, 12 }, false, "Shield", true },
                    { 43, null, false, "Book", false },
                    { 50, new[] { 11, 12 }, false, "Two-Handled Ranged", true },
                    { 51, new[] { 11, 12 }, false, "One-Handled Ranged", true },
                    { 52, new[] { 11, 12 }, false, "ThrownWeapon", true },
                    { 53, null, false, "Ammunition", false },
                    { 60, new[] { 15 }, false, "Backpack", true },
                    { 61, new[] { 15, 7, 8 }, false, "Satchel", true },
                    { 71, null, false, "Ingredient", false },
                    { 90, null, false, "Tool", false },
                    { 100, null, false, "Currency", false },
                    { 101, null, false, "Valuable", false },
                    { 102, null, false, "TradeGood", false },
                    { 111, null, false, "Key", false },
                    { 120, null, true, "Food", false }
                });

            migrationBuilder.InsertData(
                table: "stat_definitions",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Health" },
                    { 2, "HealthMax" },
                    { 3, "Stamina" },
                    { 4, "Strength" },
                    { 5, "Intelligence" },
                    { 6, "Education" },
                    { 7, "Mana" },
                    { 8, "ManaMax" },
                    { 9, "MagicLevel" },
                    { 10, "TechLevel" },
                    { 11, "Experience" },
                    { 12, "Level" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "item_type_model",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "stat_definitions",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "stat_definitions",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "stat_definitions",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "stat_definitions",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "stat_definitions",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "stat_definitions",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "stat_definitions",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "stat_definitions",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "stat_definitions",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "stat_definitions",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "stat_definitions",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "stat_definitions",
                keyColumn: "id",
                keyValue: 12);
        }
    }
}
