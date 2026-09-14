
using Solace.Models.Items;
namespace Solace.Models.Seeds;


public static class ItemTypeSeedData
{
    public static ItemTypeModel[] Data => new[]
    {
        // ====================================================
        // 1. HEAD & FACE ACCESSORIES (Jewelry/Cosmetic) - IDs 1-5
        // ====================================================
        new ItemTypeModel { Id = 1, Name = "Headwear", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.Head } },
        new ItemTypeModel { Id = 2, Name = "FacialMask", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.Face } },
        new ItemTypeModel { Id = 3, Name = "Necklace", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.Throat } },
        new ItemTypeModel { Id = 4, Name = "Earrings", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.Hair } },
        new ItemTypeModel { Id = 5, Name = "HairAccessory", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.Head } },
        new ItemTypeModel { Id = 27, Name = "Bracelet", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftWrist, BodyPlacement.RightWrist }},
        new ItemTypeModel { Id = 31, Name = "Anklet", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftAnkle, BodyPlacement.RightAnkle }},


        // ====================================================
        // 2. CORE BODY ARMOR & CLOTHING - IDs 6-10
        // ====================================================
        new ItemTypeModel { Id = 6, Name = "Chestplate", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.Torso } },
        new ItemTypeModel { Id = 7, Name = "Tunic", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.Torso } },
        new ItemTypeModel { Id = 8, Name = "Skirt", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.Torso } },
        new ItemTypeModel { Id = 9, Name = "Overwear", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.Overwear } },
        new ItemTypeModel { Id = 10, Name = "Undergarment", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.Torso } },

        // ====================================================
        // 3. WAIST & BELT ACCESSORIES - IDs 11-12
        // ====================================================
        new ItemTypeModel { Id = 11, Name = "Belt", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.Belt } },
        new ItemTypeModel { Id = 12, Name = "WaistPouch", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.Belt } },

        // ====================================================
        // 4. LIMB ARMOR & CLOTHING - IDs 13-25
        // ====================================================
        new ItemTypeModel { Id = 13, Name = "ShoulderPads", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftShoulder, BodyPlacement.RightShoulder } },
        new ItemTypeModel { Id = 14, Name = "ArmGuard", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftArm, BodyPlacement.RightArm } },
        new ItemTypeModel { Id = 15, Name = "WristBand", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftWrist, BodyPlacement.RightWrist } },
        new ItemTypeModel { Id = 16, Name = "Gauntlets", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftHand, BodyPlacement.RightHand } },
        new ItemTypeModel { Id = 17, Name = "Gloves", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftHand, BodyPlacement.RightHand } },
        new ItemTypeModel { Id = 18, Name = "ThighArmor", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftThigh, BodyPlacement.RightThigh } },
        new ItemTypeModel { Id = 19, Name = "Pants", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftThigh, BodyPlacement.RightThigh } },

        // Legs/Shins
        new ItemTypeModel { Id = 20, Name = "Greaves", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftShin, BodyPlacement.RightShin } },
        new ItemTypeModel { Id = 21, Name = "Boots", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftFoot, BodyPlacement.RightFoot } },

        // Ankles/Feet
        new ItemTypeModel { Id = 22, Name = "AnkleCuffs", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftAnkle, BodyPlacement.RightAnkle } },
        new ItemTypeModel { Id = 23, Name = "ToeRings", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftToe1, BodyPlacement.RightToe1 } },

        // ====================================================
        // 5. TOOLS & CONSUMABLES - IDs 24-27
        // ====================================================
        new ItemTypeModel { Id = 24, Name = "Potion", PlayerEquippable = false, IsLimitedUse = true, ElligiblePlacement = null },
        new ItemTypeModel { Id = 25, Name = "ToolKit", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.Torso } },
        new ItemTypeModel { Id = 26, Name = "Paper", PlayerEquippable = false, ElligiblePlacement = null },
        new ItemTypeModel { Id = 43, Name = "Book", PlayerEquippable = false, ElligiblePlacement = null },


        // ====================================================
        // 6. WEAPONS & COMBAT ITEMS - IDs 28-31
        // ====================================================
        new ItemTypeModel { Id = 28, Name = "OneHandedWeapon", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftHand } },
        new ItemTypeModel { Id = 29, Name = "TwoHandedWeapon", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftHand, BodyPlacement.RightHand } },
        new ItemTypeModel { Id = 30, Name = "SmallWeapon", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftHand } },

    // ====================================================
    // 7. SHIELDS & OFF-HAND ITEMS - IDs 40-45
    // ====================================================
    new ItemTypeModel { Id = 40, Name = "Shield", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftHand, BodyPlacement.RightHand } },

    // ====================================================
    // 8. RANGED WEAPONS & AMMUNITION - IDs 50-56
    // ====================================================
    new ItemTypeModel { Id = 50, Name = "Two-Handled Ranged", PlayerEquippable = true, SlotsRequired = 2, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftHand, BodyPlacement.RightHand } },
    new ItemTypeModel { Id = 51, Name = "One-Handled Ranged", PlayerEquippable = true, SlotsRequired = 1, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftHand, BodyPlacement.RightHand } },
    new ItemTypeModel { Id = 52, Name = "ThrownWeapon", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.LeftHand, BodyPlacement.RightHand } },
    new ItemTypeModel { Id = 53, Name = "Ammunition", PlayerEquippable = false, ElligiblePlacement = null },


    // ====================================================
    // 9. CONTAINERS & CARRY ITEMS - IDs 60-64
    // ====================================================
    new ItemTypeModel { Id = 60, Name = "Backpack", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.Torso } },
    new ItemTypeModel { Id = 61, Name = "Satchel", PlayerEquippable = true, ElligiblePlacement = new List<BodyPlacement> { BodyPlacement.Torso, BodyPlacement.LeftShoulder, BodyPlacement.RightShoulder } },

    // ====================================================
    // 10. CRAFTING MATERIALS - IDs 70-75
    // ====================================================
    new ItemTypeModel { Id = 71, Name = "Ingredient", PlayerEquippable = false, ElligiblePlacement = null },

    // ====================================================
    // 12. LIGHT SOURCES & UTILITY TOOLS - IDs 90-94
    // ====================================================
    new ItemTypeModel { Id = 90, Name = "Tool", PlayerEquippable = false },

    // ====================================================
    // 13. CURRENCY & VALUABLES - IDs 100-102
    // ====================================================
    new ItemTypeModel { Id = 100, Name = "Currency", PlayerEquippable = false, ElligiblePlacement = null },
    new ItemTypeModel { Id = 101, Name = "Valuable", PlayerEquippable = false, ElligiblePlacement = null },
    new ItemTypeModel { Id = 102, Name = "TradeGood", PlayerEquippable = false, ElligiblePlacement = null },

    // ====================================================
    // 14. KEY ITEMS - IDs 110-113
    // ====================================================
    new ItemTypeModel { Id = 111, Name = "Key", PlayerEquippable = false, ElligiblePlacement = null },

    // ====================================================
    // 15. FOOD & DRINK - IDs 120-123
    // ====================================================
    new ItemTypeModel { Id = 120, Name = "Food", PlayerEquippable = false, IsLimitedUse = true, ElligiblePlacement = null },
    };
}