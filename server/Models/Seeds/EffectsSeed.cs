using Solace.Enums;
using Solace.Models.Effects;
namespace Solace.Models.Seeds;

public static class EffectsSeed
{
    public static readonly Guid BluntDamaageId = new Guid("10111111-2222-3333-4444-556677889901");
    public static readonly Guid PiercingDamageId = new Guid("20222222-3333-4444-5555-667788990012");
    public static readonly Guid StunId = new Guid("30333333-4444-5555-6666-778899001123");
    public static readonly Guid HealId = new Guid("40444444-5555-6666-7777-889900112234");
    public static readonly Guid ModMaxHealthId = new Guid("50555555-6666-7777-8888-901122334456");
    public static readonly Guid ModStaminaId = new Guid("60666666-7777-8888-9999-012233445567");
    public static readonly Guid ModStrengthId = new Guid("70777777-8888-9999-0000-123344556678");
    public static readonly Guid ModIntelligenceId = new Guid("80888888-9999-0000-1111-234455667789");
    public static readonly Guid ModEducationId = new Guid("90999999-0000-1111-2222-345566778890");
    public static readonly Guid ModManaId = new Guid("10101010-2020-3030-4040-5060708090a0");
    public static readonly Guid ModMaxManaId = new Guid("20202020-3030-4040-5050-60708090a0b1");
    public static readonly Guid ModMagicLevelId = new Guid("30303030-4040-5050-6060-708090a0b0c1");
    public static readonly Guid ModTechLevelId = new Guid("40404040-5050-6060-7070-8090a0b0c0d1");
    public static readonly Guid ModExperienceId = new Guid("50505050-6060-7070-8080-90a0b0c0d0e1");
    public static readonly Guid ModLevelId = new Guid("60606060-7070-8080-9090-a0b0c0d0e0f1");
    public static readonly Guid ModMoraleId = new Guid("70707070-8080-9090-a0a0-b0c0d0e0f123");
    public static readonly Guid ModSanityId = new Guid("80808080-9090-a0a0-b0b0-c0d0e0f12345");
    public static readonly Guid ModActionPointsId = new Guid("90909090-a0a0-b0b0-c0c0-d0e0f1234567");
    public static readonly Guid ModActionPointsMaxId = new Guid("a0a0a0a0-b0b0-c0c0-d0d0-e0f123456789");
    public static readonly Guid ModCharismaId = new Guid("b0b0b0b0-c0c0-d0d0-e0e0-f1234567890a");

    public static EffectsModel[] Data => new[]
    {
        new EffectsModel { Id = BluntDamaageId, Name = "Blunt Damaage", IsInstant = true },
        new EffectsModel { Id = PiercingDamageId, Name = "Piercing Damage", IsInstant = true },
        new EffectsModel { Id = StunId, Name = "Stun", IsInstant = true },
        new EffectsModel { Id = HealId, Name = "Heal", IsInstant = true },
        new EffectsModel { Id = ModMaxHealthId, Name = "ModMaxHealth", IsInstant = true },
        new EffectsModel { Id = ModStaminaId, Name = "ModStamina", IsInstant = true },
        new EffectsModel { Id = ModStrengthId, Name = "ModStrength", IsInstant = true },
        new EffectsModel { Id = ModIntelligenceId, Name = "ModIntelligence", IsInstant = true },
        new EffectsModel { Id = ModEducationId, Name = "ModEducation", IsInstant = true },
        new EffectsModel { Id = ModManaId, Name = "ModMana", IsInstant = true },
        new EffectsModel { Id = ModMaxManaId, Name = "ModMaxMana", IsInstant = true },
        new EffectsModel { Id = ModMagicLevelId, Name = "ModMagicLevel", IsInstant = true },
        new EffectsModel { Id = ModTechLevelId, Name = "ModTechLevel", IsInstant = true },
        new EffectsModel { Id = ModExperienceId, Name = "ModExperience", IsInstant = true },
        new EffectsModel { Id = ModLevelId, Name = "ModLevel", IsInstant = true },
        new EffectsModel { Id = ModMoraleId, Name = "ModMorale", IsInstant = true },
        new EffectsModel { Id = ModSanityId, Name = "ModSanity", IsInstant = true },
        new EffectsModel { Id = ModActionPointsId, Name = "ModActionPoints", IsInstant = true },
        new EffectsModel { Id = ModActionPointsMaxId, Name = "ModActionPointsMax", IsInstant = true },
        new EffectsModel { Id = ModCharismaId, Name = "ModCharisma", IsInstant = true },
    };
}

public static class EffectsAffectedStatSeed
{
    public static EffectAffectedStat[] Data => new[]
    {
        new EffectAffectedStat { Id = new Guid("e1001000-0000-0000-0000-000000000001"), EffectId = EffectsSeed.BluntDamaageId, StatDefinitionId = StatsDefinitionSeed.HealthMaxId },
        new EffectAffectedStat { Id = new Guid("e1002000-0000-0000-0000-000000000002"), EffectId = EffectsSeed.PiercingDamageId, StatDefinitionId = StatsDefinitionSeed.StrengthId },

        new EffectAffectedStat { Id = new Guid("e1003000-0000-0000-0000-000000000003"), EffectId = EffectsSeed.HealId, StatDefinitionId = StatsDefinitionSeed.HealthId },
        new EffectAffectedStat { Id = new Guid("e1004000-0000-0000-0000-000000000004"), EffectId = EffectsSeed.ModMaxHealthId, StatDefinitionId = StatsDefinitionSeed.HealthMaxId },
        new EffectAffectedStat { Id = new Guid("e1005000-0000-0000-0000-000000000005"), EffectId = EffectsSeed.ModStaminaId, StatDefinitionId = StatsDefinitionSeed.StaminaId },
        new EffectAffectedStat { Id = new Guid("e1006000-0000-0000-0000-000000000006"), EffectId = EffectsSeed.ModStrengthId, StatDefinitionId = StatsDefinitionSeed.StrengthId },
        new EffectAffectedStat { Id = new Guid("e1007000-0000-0000-0000-000000000007"), EffectId = EffectsSeed.ModIntelligenceId, StatDefinitionId = StatsDefinitionSeed.IntelligenceId },
        new EffectAffectedStat { Id = new Guid("e1008000-0000-0000-0000-000000000008"), EffectId = EffectsSeed.ModEducationId, StatDefinitionId = StatsDefinitionSeed.EducationId },
        new EffectAffectedStat { Id = new Guid("e1009000-0000-0000-0000-000000000009"), EffectId = EffectsSeed.ModManaId, StatDefinitionId = StatsDefinitionSeed.ManaId },
        new EffectAffectedStat { Id = new Guid("e1010000-0000-0000-0000-000000000010"), EffectId = EffectsSeed.ModMaxManaId, StatDefinitionId = StatsDefinitionSeed.ManaMaxId },
        new EffectAffectedStat { Id = new Guid("e1011000-0000-0000-0000-000000000011"), EffectId = EffectsSeed.ModMagicLevelId, StatDefinitionId = StatsDefinitionSeed.MagicLevelId },
        new EffectAffectedStat { Id = new Guid("e1012000-0000-0000-0000-000000000012"), EffectId = EffectsSeed.ModTechLevelId, StatDefinitionId = StatsDefinitionSeed.TechLevelId },
        new EffectAffectedStat { Id = new Guid("e1013000-0000-0000-0000-000000000013"), EffectId = EffectsSeed.ModExperienceId, StatDefinitionId = StatsDefinitionSeed.ExperienceId },
        new EffectAffectedStat { Id = new Guid("e1014000-0000-0000-0000-000000000014"), EffectId = EffectsSeed.ModLevelId, StatDefinitionId = StatsDefinitionSeed.LevelId },
        new EffectAffectedStat { Id = new Guid("e1015000-0000-0000-0000-000000000015"), EffectId = EffectsSeed.ModMoraleId, StatDefinitionId = StatsDefinitionSeed.MoraleId },
        new EffectAffectedStat { Id = new Guid("e1016000-0000-0000-0000-000000000016"), EffectId = EffectsSeed.ModSanityId, StatDefinitionId = StatsDefinitionSeed.SanityId },
        new EffectAffectedStat { Id = new Guid("e1017000-0000-0000-0000-000000000017"), EffectId = EffectsSeed.ModActionPointsId, StatDefinitionId = StatsDefinitionSeed.ActionPointsId },
        new EffectAffectedStat { Id = new Guid("e1018000-0000-0000-0000-000000000018"), EffectId = EffectsSeed.ModActionPointsMaxId, StatDefinitionId = StatsDefinitionSeed.ActionPointsMaxId },
        new EffectAffectedStat { Id = new Guid("e1019000-0000-0000-0000-000000000019"), EffectId = EffectsSeed.ModCharismaId, StatDefinitionId = StatsDefinitionSeed.CharismaId },
    };
}

public static class EffectAffectedAbilitySeed
{
    public static EffectAffectedAbility[] Data => new[]
    {
        new EffectAffectedAbility { Id = new Guid("a0001000-0000-0000-0000-000000000001"), EffectId = EffectsSeed.StunId, ActionId = ActionDefinitionSeed.AttackId },
        new EffectAffectedAbility { Id = new Guid("a0003000-0000-0000-0000-000000000003"), EffectId = EffectsSeed.StunId, ActionId = ActionDefinitionSeed.DefendId },
        new EffectAffectedAbility { Id = new Guid("a0005000-0000-0000-0000-000000000005"), EffectId = EffectsSeed.StunId, ActionId = ActionDefinitionSeed.CastId },
        new EffectAffectedAbility { Id = new Guid("a0007000-0000-0000-0000-000000000007"), EffectId = EffectsSeed.StunId, ActionId = ActionDefinitionSeed.RunId },
        new EffectAffectedAbility { Id = new Guid("a0009000-0000-0000-0000-000000000009"), EffectId = EffectsSeed.StunId, ActionId = ActionDefinitionSeed.MoveId },
    };
}