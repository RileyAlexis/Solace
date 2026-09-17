using Solace.Models.Class;

namespace Solace.Models.Seeds;

public static class ClassModelSeed
{
    public static ClassModel[] Data => [
        new ClassModel { Id = 1, Name = "Fighter", Description = "A Fighter", MagicUser = false, UseTwoHandedWeapons = true },
        new ClassModel { Id = 2, Name = "Rougue", Description = "A Rougue", MagicUser = false, UseTwoHandedWeapons = false },
        new ClassModel { Id = 3, Name = "Sorcerer", Description = "A Sorcerer", MagicUser = true, UseTwoHandedWeapons = false },
    ];
}

public static class ClassBaseStatSeed
{
    public static ClassBaseStatModel[] Data => [
        // Fighter
        new ClassBaseStatModel { Id = 1, ClassId = 1, StatDefinitionId = 1, Value = 20 },
        new ClassBaseStatModel { Id = 2, ClassId = 1, StatDefinitionId = 2, Value = 20 },
        new ClassBaseStatModel { Id = 3, ClassId = 1, StatDefinitionId = 3, Value = 7 },
        new ClassBaseStatModel { Id = 4, ClassId = 1, StatDefinitionId = 4, Value = 9 },
        new ClassBaseStatModel { Id = 5, ClassId = 1, StatDefinitionId = 5, Value = 2 },
        new ClassBaseStatModel { Id = 6, ClassId = 1, StatDefinitionId = 6, Value = 2 },
        new ClassBaseStatModel { Id = 7, ClassId = 1, StatDefinitionId = 7, Value = 0 },
        new ClassBaseStatModel { Id = 8, ClassId = 1, StatDefinitionId = 8, Value = 0 },
        new ClassBaseStatModel { Id = 9, ClassId = 1, StatDefinitionId = 9, Value = 0 },
        new ClassBaseStatModel { Id = 10, ClassId = 1, StatDefinitionId = 10, Value = 0 },
        new ClassBaseStatModel { Id = 11, ClassId = 1, StatDefinitionId = 11, Value = 0 },
        new ClassBaseStatModel { Id = 12, ClassId = 1, StatDefinitionId = 12, Value = 0 },
        new ClassBaseStatModel { Id = 13, ClassId = 1, StatDefinitionId = 13, Value = 5 },
        new ClassBaseStatModel { Id = 14, ClassId = 1, StatDefinitionId = 14, Value = 10 },
        new ClassBaseStatModel { Id = 15, ClassId = 1, StatDefinitionId = 15, Value = 1 },
        new ClassBaseStatModel { Id = 16, ClassId = 1, StatDefinitionId = 16, Value = 1 },
        new ClassBaseStatModel { Id = 17, ClassId = 1, StatDefinitionId = 17, Value = 3 },

        // Rougue
        new ClassBaseStatModel { Id = 18, ClassId = 2, StatDefinitionId = 1, Value = 14 },
        new ClassBaseStatModel { Id = 19, ClassId = 2, StatDefinitionId = 2, Value = 14 },
        new ClassBaseStatModel { Id = 20, ClassId = 2, StatDefinitionId = 3, Value = 4 },
        new ClassBaseStatModel { Id = 21, ClassId = 2, StatDefinitionId = 4, Value = 5 },
        new ClassBaseStatModel { Id = 22, ClassId = 2, StatDefinitionId = 5, Value = 4 },
        new ClassBaseStatModel { Id = 23, ClassId = 2, StatDefinitionId = 6, Value = 4 },
        new ClassBaseStatModel { Id = 24, ClassId = 2, StatDefinitionId = 7, Value = 0 },
        new ClassBaseStatModel { Id = 25, ClassId = 2, StatDefinitionId = 8, Value = 0 },
        new ClassBaseStatModel { Id = 26, ClassId = 2, StatDefinitionId = 9, Value = 0 },
        new ClassBaseStatModel { Id = 27, ClassId = 2, StatDefinitionId = 10, Value = 0 },
        new ClassBaseStatModel { Id = 28, ClassId = 2, StatDefinitionId = 11, Value = 0 },
        new ClassBaseStatModel { Id = 29, ClassId = 2, StatDefinitionId = 12, Value = 0 },
        new ClassBaseStatModel { Id = 30, ClassId = 2, StatDefinitionId = 13, Value = 5 },
        new ClassBaseStatModel { Id = 31, ClassId = 2, StatDefinitionId = 14, Value = 10 },
        new ClassBaseStatModel { Id = 32, ClassId = 2, StatDefinitionId = 15, Value = 1 },
        new ClassBaseStatModel { Id = 33, ClassId = 2, StatDefinitionId = 16, Value = 1 },
        new ClassBaseStatModel { Id = 34, ClassId = 2, StatDefinitionId = 17, Value = 3 },

        // Sorcerer
        new ClassBaseStatModel { Id = 35, ClassId = 3, StatDefinitionId = 1, Value = 8 },
        new ClassBaseStatModel { Id = 36, ClassId = 3, StatDefinitionId = 2, Value = 8 },
        new ClassBaseStatModel { Id = 37, ClassId = 3, StatDefinitionId = 3, Value = 3 },
        new ClassBaseStatModel { Id = 38, ClassId = 3, StatDefinitionId = 4, Value = 2 },
        new ClassBaseStatModel { Id = 39, ClassId = 3, StatDefinitionId = 5, Value = 8 },
        new ClassBaseStatModel { Id = 40, ClassId = 3, StatDefinitionId = 6, Value = 6 },
        new ClassBaseStatModel { Id = 41, ClassId = 3, StatDefinitionId = 7, Value = 3 },
        new ClassBaseStatModel { Id = 42, ClassId = 3, StatDefinitionId = 8, Value = 3 },
        new ClassBaseStatModel { Id = 43, ClassId = 3, StatDefinitionId = 9, Value = 0 },
        new ClassBaseStatModel { Id = 44, ClassId = 3, StatDefinitionId = 10, Value = 0 },
        new ClassBaseStatModel { Id = 45, ClassId = 3, StatDefinitionId = 11, Value = 0 },
        new ClassBaseStatModel { Id = 46, ClassId = 3, StatDefinitionId = 12, Value = 0 },
        new ClassBaseStatModel { Id = 47, ClassId = 3, StatDefinitionId = 13, Value = 5 },
        new ClassBaseStatModel { Id = 48, ClassId = 3, StatDefinitionId = 14, Value = 10 },
        new ClassBaseStatModel { Id = 49, ClassId = 3, StatDefinitionId = 15, Value = 1 },
        new ClassBaseStatModel { Id = 50, ClassId = 3, StatDefinitionId = 16, Value = 1 },
        new ClassBaseStatModel { Id = 51, ClassId = 3, StatDefinitionId = 17, Value = 3 },
    ];
}