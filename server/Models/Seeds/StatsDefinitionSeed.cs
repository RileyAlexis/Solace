using Solace.Models.Player;
namespace Solace.Models.Seeds;

public static class StatsDefinitionSeed
{
    public static readonly Guid HealthId = new Guid("735d046e-9b1c-4a24-8f7c-53d0db69b1e5");
    public static readonly Guid HealthMaxId = new Guid("2f76c1e3-9b84-4d5a-902c-79163e92b8f4");
    public static readonly Guid StaminaId = new Guid("e94b3d21-6c8a-4f09-bc7e-51382d94b6a1");
    public static readonly Guid StrengthId = new Guid("c82f9e3d-1a5b-476c-90ef-823456789abc");
    public static readonly Guid IntelligenceId = new Guid("d93e0f21-8b7a-456c-ad3e-1234567890ab");
    public static readonly Guid EducationId = new Guid("a1b2c3d4-e5f6-7890-abcd-ef1234567890");
    public static readonly Guid ManaId = new Guid("b2c3d4e5-f6a7-8901-bcde-234567890abc");
    public static readonly Guid ManaMaxId = new Guid("c3d4e5f6-a7b8-9012-cdef-34567890abcd");
    public static readonly Guid MagicLevelId = new Guid("d4e5f6a7-b8c9-0123-defg-4567890abcde");
    public static readonly Guid TechLevelId = new Guid("e5f6a7b8-c9d0-1234-efgh-567890abcdef");
    public static readonly Guid ExperienceId = new Guid("f6a7b8c9-d0e1-2345-fghi-67890abcdef1");
    public static readonly Guid LevelId = new Guid("a7b8c9d0-e1f2-3456-ghij-7890abcdef12");
    public static readonly Guid MoraleId = new Guid("b8c9d0e1-f2a3-4567-<image|>    ijkl-890abcdef123");
    public static readonly Guid SanityId = new Guid("c9d0e1f2-a3b4-5678-jklm-90abcdef1234");
    public static readonly Guid ActionPointsId = new Guid("d0e1f2a3-b4c5-6789-klmn-abcdef123456");
    public static readonly Guid ActionPointsMaxId = new Guid("e1f2a3b4-c5d6-7890-lmno-bcdef1234567");
    public static readonly Guid CharismaId = new Guid("f2a3b4c5-d6e7-8901-mnop-cdef12345678");

    public static StatDefinition[] Data =>
    [
        new StatDefinition { Id = HealthId, Name = "Health" },
        new StatDefinition { Id = HealthMaxId, Name = "HealthMax" },
        new StatDefinition { Id = StaminaId, Name = "Stamina" },
        new StatDefinition { Id = StrengthId, Name = "Strength" },
        new StatDefinition { Id = IntelligenceId, Name = "Intelligence" },
        new StatDefinition { Id = EducationId, Name = "Education" },
        new StatDefinition { Id = ManaId, Name = "Mana" },
        new StatDefinition { Id = ManaMaxId, Name = "ManaMax" },
        new StatDefinition { Id = MagicLevelId, Name = "MagicLevel" },
        new StatDefinition { Id = TechLevelId, Name = "TechLevel" },
        new StatDefinition { Id = ExperienceId, Name = "Experience" },
        new StatDefinition { Id = LevelId, Name = "Level" },
        new StatDefinition { Id = MoraleId, Name = "Morale" },
        new StatDefinition { Id = SanityId, Name = "Sanity" },
        new StatDefinition { Id = ActionPointsId, Name = "ActionPoints" },
        new StatDefinition { Id = ActionPointsMaxId, Name = "ActionPointsMax" },
        new StatDefinition { Id = CharismaId, Name = "Charisma" }
    ];
}