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
        new ClassBaseStatModel { Id = new Guid("f1001-0000-0000-0000-000000000001"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.HealthId, Value = 20 },
        new ClassBaseStatModel { Id = new Guid("f1002-0000-0000-0000-000000000002"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.HealthMaxId, Value = 20 },
        new ClassBaseStatModel { Id = new Guid("f1003-0000-0000-0000-000000000003"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.StaminaId, Value = 7 },
        new ClassBaseStatModel { Id = new Guid("f1004-0000-0000-0000-000000000004"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.StrengthId, Value = 9 },
        new ClassBaseStatModel { Id = new Guid("f1005-0000-0000-0000-000000000005"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.IntelligenceId, Value = 2 },
        new ClassBaseStatModel { Id = new Guid("f1006-0000-0000-0000-000000000006"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.EducationId, Value = 2 },
        new ClassBaseStatModel { Id = new Guid("f1007-0000-0000-0000-000000000007"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.ManaId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("f1008-0000-0000-0000-000000000008"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.ManaMaxId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("f1009-0000-0000-0000-000000000009"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.MagicLevelId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("f1010-0000-0000-0000-000000000010"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.TechLevelId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("f1011-0000-0000-0000-000000000011"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.ExperienceId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("f1012-0000-0000-0000-000000000012"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.LevelId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("f1013-0000-0000-0000-000000000013"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.MoraleId, Value = 5 },
        new ClassBaseStatModel { Id = new Guid("f1014-0000-0000-0000-000000000014"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.SanityId, Value = 10 },
        new ClassBaseStatModel { Id = new Guid("f1015-0000-0000-0000-000000000015"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.ActionPointsId, Value = 1 },
        new ClassBaseStatModel { Id = new Guid("f1016-0000-0000-0000-000000000016"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.ActionPointsMaxId, Value = 1 },
        new ClassBaseStatModel { Id = new Guid("f1017-0000-0000-0000-000000000017"), ClassId = ClassModelSeed.FighterId, StatDefinitionId = StatsDefinitionSeed.CharismaId, Value = 3 },

        // Rougue
        new ClassBaseStatModel { Id = new Guid("r1018-0000-0000-0000-000000000018"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.HealthId, Value = 14 },
        new ClassBaseStatModel { Id = new Guid("r1019-0000-0000-0000-000000000019"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.HealthMaxId, Value = 14 },
        new ClassBaseStatModel { Id = new Guid("r1020-0000-0000-0000-000000000020"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.StaminaId, Value = 4 },
        new ClassBaseStatModel { Id = new Guid("r1021-0000-0000-0000-000000000021"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.StrengthId, Value = 5 },
        new ClassBaseStatModel { Id = new Guid("r1022-0000-0000-0000-000000000022"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.IntelligenceId, Value = 4 },
        new ClassBaseStatModel { Id = new Guid("r1023-0000-0000-0000-000000000023"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.EducationId, Value = 4 },
        new ClassBaseStatModel { Id = new Guid("r1024-0000-0000-0000-000000000024"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.ManaId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("r1025-0000-0000-0000-000000000025"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.ManaMaxId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("r1026-0000-0000-0000-000000000026"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.MagicLevelId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("r1027-0000-0000-0000-000000000027"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.TechLevelId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("r1028-0000-0000-0000-000000000028"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.ExperienceId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("r1029-0000-0000-0000-000000000029"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.LevelId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("r1030-0000-0000-0000-000000000030"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.MoraleId, Value = 5 },
        new ClassBaseStatModel { Id = new Guid("r1031-0000-0000-0000-000000000031"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.SanityId, Value = 10 },
        new ClassBaseStatModel { Id = new Guid("r1032-0000-0000-0000-000000000032"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.ActionPointsId, Value = 1 },
        new ClassBaseStatModel { Id = new Guid("r1033-0000-0000-0000-000000000033"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.ActionPointsMaxId, Value = 1 },
        new ClassBaseStatModel { Id = new Guid("r1034-0000-0000-0000-000000000034"), ClassId = ClassModelSeed.RougueId, StatDefinitionId = StatsDefinitionSeed.CharismaId, Value = 3 },

        // Sorcerer
        new ClassBaseStatModel { Id = new Guid("s1035-0000-0000-0000-000000000035"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.HealthId, Value = 8 },
        new ClassBaseStatModel { Id = new Guid("s1036-0000-0000-0000-000000000036"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.HealthMaxId, Value = 8 },
        new ClassBaseStatModel { Id = new Guid("s1037-0000-0000-0000-000000000037"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.StaminaId, Value = 3 },
        new ClassBaseStatModel { Id = new Guid("s1038-0000-0000-0000-000000000038"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.StrengthId, Value = 2 },
        new ClassBaseStatModel { Id = new Guid("s1039-0000-0000-0000-000000000039"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.IntelligenceId, Value = 8 },
        new ClassBaseStatModel { Id = new Guid("s1040-0000-0000-0000-000000000040"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.EducationId, Value = 6 },
        new ClassBaseStatModel { Id = new Guid("s1041-0000-0000-0000-000000000041"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.ManaId, Value = 3 },
        new ClassBaseStatModel { Id = new Guid("s1042-0000-0000-0000-000000000042"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.ManaMaxId, Value = 3 },
        new ClassBaseStatModel { Id = new Guid("s1043-0000-0000-0000-000000000043"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.MagicLevelId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("s1044-0000-0000-0000-000000000044"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.TechLevelId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("s1045-0000-0000-0000-000000000045"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.ExperienceId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("s1046-0000-0000-0000-000000000046"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.LevelId, Value = 0 },
        new ClassBaseStatModel { Id = new Guid("s1047-0000-0000-0000-000000000047"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.MoraleId, Value = 5 },
        new ClassBaseStatModel { Id = new Guid("s1048-0000-0000-0000-000000000048"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.SanityId, Value = 10 },
        new ClassBaseStatModel { Id = new Guid("s1049-0000-0000-0000-000000000049"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.ActionPointsId, Value = 1 },
        new ClassBaseStatModel { Id = new Guid("s1050-0000-0000-0000-000000000050"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.ActionPointsMaxId, Value = 1 },
        new ClassBaseStatModel { Id = new Guid("s1051-0000-0000-0000-000000000051"), ClassId = ClassModelSeed.SorcererId, StatDefinitionId = StatsDefinitionSeed.CharismaId, Value = 3 },
    ];
}