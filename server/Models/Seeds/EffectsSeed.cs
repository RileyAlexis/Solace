using Solace.Models.Effects;
namespace Solace.Models.Seeds;

public static class EffectsSeed
{
    public static EffectsModel[] Data => new[]
    {
        new EffectsModel { Id = 1, Name = "Blunt Damaage", IsInstant = true },
        new EffectsModel { Id = 2, Name = "Piercing Damage", IsInstant = true },
        new EffectsModel { Id = 3, Name = "Stun", IsInstant = true },
        new EffectsModel { Id = 4, Name = "Heal", IsInstant = true },
        new EffectsModel { Id = 5, Name = "ModMaxHealth", IsInstant = true },
        new EffectsModel { Id = 6, Name = "ModStamina", IsInstant = true },
        new EffectsModel { Id = 7, Name = "ModStrength", IsInstant = true },
        new EffectsModel { Id = 8, Name = "ModIntelligence", IsInstant = true },
        new EffectsModel { Id = 9, Name = "ModEducation", IsInstant = true },
        new EffectsModel { Id = 10, Name = "ModMana", IsInstant = true },
        new EffectsModel { Id = 11, Name = "ModMaxHealth", IsInstant = true },
        new EffectsModel { Id = 12, Name = "ModMagicLevel", IsInstant = true },
        new EffectsModel { Id = 13, Name = "ModTechLevel", IsInstant = true },
        new EffectsModel { Id = 14, Name = "ModExperience", IsInstant = true },
        new EffectsModel { Id = 15, Name = "ModLevel", IsInstant = true },
        new EffectsModel { Id = 16, Name = "ModMorale", IsInstant = true },
        new EffectsModel { Id = 17, Name = "ModSanity", IsInstant = true },
        new EffectsModel { Id = 18, Name = "ModActionPoints", IsInstant = true },
        new EffectsModel { Id = 19, Name = "ModActionPointsMax", IsInstant = true },
        new EffectsModel { Id = 20, Name = "ModCharisma", IsInstant = true },
    };
}

public static class EffectsAffectedStatSeed
{
    public static EffectAffectedStat[] Data => new[]
    {
        new EffectAffectedStat { Id = 1, EffectId = 1, StatDefinitionId = 1 },
        new EffectAffectedStat { Id = 2, EffectId = 2, StatDefinitionId = 1 },
        new EffectAffectedStat { Id = 3, EffectId = 4, StatDefinitionId = 1 },
        new EffectAffectedStat { Id = 4, EffectId = 5, StatDefinitionId = 2 },
        new EffectAffectedStat { Id = 5, EffectId = 6, StatDefinitionId = 3 },
        new EffectAffectedStat { Id = 6, EffectId = 7, StatDefinitionId = 4 },
        new EffectAffectedStat { Id = 7, EffectId = 8, StatDefinitionId = 5 },
        new EffectAffectedStat { Id = 8, EffectId = 9, StatDefinitionId = 6 },
        new EffectAffectedStat { Id = 9, EffectId = 10, StatDefinitionId = 7 },
        new EffectAffectedStat { Id = 10, EffectId = 11, StatDefinitionId = 8 },
        new EffectAffectedStat { Id = 11, EffectId = 12, StatDefinitionId = 9 },
        new EffectAffectedStat { Id = 12, EffectId = 13, StatDefinitionId = 10 },
        new EffectAffectedStat { Id = 13, EffectId = 14, StatDefinitionId = 11 },
        new EffectAffectedStat { Id = 14, EffectId = 15, StatDefinitionId = 12 },
        new EffectAffectedStat { Id = 15, EffectId = 16, StatDefinitionId = 13 },
        new EffectAffectedStat { Id = 16, EffectId = 17, StatDefinitionId = 14 },
        new EffectAffectedStat { Id = 17, EffectId = 18, StatDefinitionId = 15 },
        new EffectAffectedStat { Id = 18, EffectId = 19, StatDefinitionId = 16 },
        new EffectAffectedStat { Id = 19, EffectId = 20, StatDefinitionId = 17 },
    };
}

public static class EffectAffectedAbilitySeed
{
    public static EffectAffectedAbility[] Data => new[]
    {
        new EffectAffectedAbility { Id = 1, EffectId = 3, ActionId = 1 },
        new EffectAffectedAbility { Id = 2, EffectId = 3, ActionId = 2 },
        new EffectAffectedAbility { Id = 3, EffectId = 3, ActionId = 3 },
        new EffectAffectedAbility { Id = 4, EffectId = 3, ActionId = 4 },
        new EffectAffectedAbility { Id = 5, EffectId = 3, ActionId = 5 },
    };
}
