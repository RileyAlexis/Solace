using Solace.Models.Class;

namespace Solace.Models.Seeds;

public static class ClassModelSeed
{
    public static readonly Guid FighterId = new Guid("11111111-2222-3333-4444-556677889900");
    public static readonly Guid RougueId = new Guid("22222222-3333-4444-5555-667788990011");
    public static readonly Guid SorcererId = new Guid("33333333-4444-5555-6666-778899001122");

    public static ClassModel[] Data => [
        new ClassModel { Id = FighterId, Name = "Fighter", Description = "A Fighter", MagicUser = false, UseTwoHandedWeapons = true },
        new ClassModel { Id = RougueId, Name = "Rougue", Description = "A Rougue", MagicUser = false, UseTwoHandedWeapons = false },
        new ClassModel { Id = SorcererId, Name = "Sorcerer", Description = "A Sorcerer", MagicUser = true, UseTwoHandedWeapons = false },
    ];
}

public static class ClassBaseStatSeed
{
    public static ClassBaseStatModel[] Data => [
        // Fighter
        new ClassBaseStatModel { Id = new Guid("f1001000-0000-0000-0000-000000000001"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.HealthId, Value = 20 },
        new ClassBaseStatModel { Id = new Guid("f1002000-0000-0000-0000-000000000002"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.HealthMaxId, Value = 20 },
        new ClassBaseStatModel { Id = new Guid("f1003000-0000-0000-0000-000000000003"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.StaminaId, Value = 7 },
        new ClassBaseStatModel { Id = new Guid("f1004000-0000-0000-0000-000000000004"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.StrengthId, Value = 9 },
        new ClassBaseStatModel { Id = new Guid("f1005000-0000-0000-0000-000000000005"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.IntelligenceId, Value = 2 },
        new ClassBaseStatModel { Id = new Guid("f1006000-0000-0000-0000-000000000006"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.EducationId, Value = 2 },
        new ClassBaseStatModel { Id = new Guid("f1007000-0000-0000-0000-000000000007"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.ManaId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("f1008000-0000-0000-0000-000000000008"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.ManaMaxId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("f1009000-0000-0000-0000-000000000009"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.MagicLevelId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("f1010000-0000-0000-0000-000000000010"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.TechLevelId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("f1011000-0000-0000-0000-000000000011"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.ExperienceId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("f1012000-0000-0000-0000-000000000012"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.LevelId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("f1013000-0000-0000-0000-000000000013"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.MoraleId, Value = 5 },
        new ClassBaseStatModel { Id = new Guid("f1014000-0000-0000-0000-000000000014"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.SanityId, Value = 10 },
        new ClassBaseStatModel { Id = new Guid("f1015000-0000-0000-0000-000000000015"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.ActionPointsId, Value = 1 },
        new ClassBaseStatModel { Id = new Guid("f1016000-0000-0000-0000-000000000016"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.ActionPointsMaxId, Value = 1 },
        new ClassBaseStatModel { Id = new Guid("f1017000-0000-0000-0000-000000000017"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.CharismaId, Value = 3 },

        // Rougue
        new ClassBaseStatModel { Id = new Guid("b1018000-0000-0000-0000-000000000018"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.HealthId, Value = 14 },
        new ClassBaseStatModel { Id = new Guid("b1019000-0000-0000-0000-000000000019"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.HealthMaxId, Value = 14 },
        new ClassBaseStatModel { Id = new Guid("b1020000-0000-0000-0000-000000000020"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.StaminaId, Value = 4 },
        new ClassBaseStatModel { Id = new Guid("b1021000-0000-0000-0000-000000000021"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.StrengthId, Value = 5 },
        new ClassBaseStatModel { Id = new Guid("b1022000-0000-0000-0000-000000000022"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.IntelligenceId, Value = 4 },
        new ClassBaseStatModel { Id = new Guid("b1023000-0000-0000-0000-000000000023"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.EducationId, Value = 4 },
        new ClassBaseStatModel { Id = new Guid("b1024000-0000-0000-0000-000000000024"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.ManaId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("b1025000-0000-0000-0000-000000000025"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.ManaMaxId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("b1026000-0000-0000-0000-000000000026"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.MagicLevelId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("b1027000-0000-0000-0000-000000000027"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.TechLevelId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("b1028000-0000-0000-0000-000000000028"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.ExperienceId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("b1029000-0000-0000-0000-000000000029"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.LevelId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("b1030000-0000-0000-0000-000000000030"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.MoraleId, Value = 5 },
        new ClassBaseStatModel { Id = new Guid("b1031000-0000-0000-0000-000000000031"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.SanityId, Value = 10 },
        new ClassBaseStatModel { Id = new Guid("b1032000-0000-0000-0000-000000000032"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.ActionPointsId, Value = 1 },
        new ClassBaseStatModel { Id = new Guid("b1033000-0000-0000-0000-000000000033"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.ActionPointsMaxId, Value = 1 },
        new ClassBaseStatModel { Id = new Guid("b1034000-0000-0000-0000-000000000034"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.CharismaId, Value = 3 },

        // Sorcerer
        new ClassBaseStatModel { Id = new Guid("c1035000-0000-0000-0000-000000000035"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.HealthId, Value = 8 },
        new ClassBaseStatModel { Id = new Guid("c1036000-0000-0000-0000-000000000036"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.HealthMaxId, Value = 8 },
        new ClassBaseStatModel { Id = new Guid("c1037000-0000-0000-0000-000000000037"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.StaminaId, Value = 3 },
        new ClassBaseStatModel { Id = new Guid("c1038000-0000-0000-0000-000000000038"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.StrengthId, Value = 2 },
        new ClassBaseStatModel { Id = new Guid("c1039000-0000-0000-0000-000000000039"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.IntelligenceId, Value = 8 },
        new ClassBaseStatModel { Id = new Guid("c1040000-0000-0000-0000-000000000040"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.EducationId, Value = 6 },
        new ClassBaseStatModel { Id = new Guid("c1041000-0000-0000-0000-000000000041"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.ManaId, Value = 3 },
        new ClassBaseStatModel { Id = new Guid("c1042000-0000-0000-0000-000000000042"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.ManaMaxId, Value = 3 },
        new ClassBaseStatModel { Id = new Guid("c1043000-0000-0000-0000-000000000043"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.MagicLevelId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("c1044000-0000-0000-0000-000000000044"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.TechLevelId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("c1045000-0000-0000-0000-000000000045"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.ExperienceId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("c1046000-0000-0000-0000-000000000046"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.LevelId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("c1047000-0000-0000-0000-000000000047"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.MoraleId, Value = 5 },
        new ClassBaseStatModel { Id = new Guid("c1048000-0000-0000-0000-000000000048"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.SanityId, Value = 10 },
        new ClassBaseStatModel { Id = new Guid("c1049000-0000-0000-0000-000000000049"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.ActionPointsId, Value = 1 },
        new ClassBaseStatModel { Id = new Guid("c1050000-0000-0000-0000-000000000050"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.ActionPointsMaxId, Value = 1 },
        new ClassBaseStatModel { Id = new Guid("c1051000-0000-0000-0000-000000000051"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.CharismaId, Value = 3 },
    ];
}