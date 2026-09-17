using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace solace.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "action_definitions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    action_points = table.Column<int>(type: "integer", nullable: false),
                    is_combat_action = table.Column<bool>(type: "boolean", nullable: false),
                    is_item_action = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_action_definitions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    normalized_name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    concurrency_stamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    user_name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    normalized_user_name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    normalized_email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    email_confirmed = table.Column<bool>(type: "boolean", nullable: false),
                    password_hash = table.Column<string>(type: "text", nullable: true),
                    security_stamp = table.Column<string>(type: "text", nullable: true),
                    concurrency_stamp = table.Column<string>(type: "text", nullable: true),
                    phone_number = table.Column<string>(type: "text", nullable: true),
                    phone_number_confirmed = table.Column<bool>(type: "boolean", nullable: false),
                    two_factor_enabled = table.Column<bool>(type: "boolean", nullable: false),
                    lockout_end = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    lockout_enabled = table.Column<bool>(type: "boolean", nullable: false),
                    access_failed_count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "building_definitions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    has_inventory = table.Column<bool>(type: "boolean", nullable: false),
                    allows_combat = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_building_definitions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "class_model",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    magic_user = table.Column<bool>(type: "boolean", nullable: false),
                    use_two_handed_weapons = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_model", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "effects",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    ability_affected_id = table.Column<int>(type: "integer", nullable: false),
                    affected_body_part = table.Column<int[]>(type: "integer[]", nullable: true),
                    is_instant = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_effects", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "item_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    elligible_placement = table.Column<int[]>(type: "integer[]", nullable: true),
                    slots_required = table.Column<int>(type: "integer", nullable: false),
                    player_equippable = table.Column<bool>(type: "boolean", nullable: false),
                    is_limited_use = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_item_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "refresh_tokens",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    hashed_token = table.Column<string>(type: "text", nullable: false),
                    user_id = table.Column<string>(type: "text", nullable: false),
                    expires = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    revoked = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    replaced_by_hash = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_refresh_tokens", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "solace_map",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    map_width = table.Column<int>(type: "integer", nullable: false),
                    map_height = table.Column<int>(type: "integer", nullable: false),
                    map_levels = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_solace_map", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "solace_server",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    server_id = table.Column<string>(type: "text", nullable: false),
                    server_title = table.Column<string>(type: "text", nullable: true),
                    map_name = table.Column<string>(type: "text", nullable: true),
                    default_map_height = table.Column<int>(type: "integer", nullable: false),
                    default_map_width = table.Column<int>(type: "integer", nullable: false),
                    code_of_conduct = table.Column<string>(type: "text", nullable: false),
                    concurrent_user_limit = table.Column<int>(type: "integer", nullable: false),
                    allow_new_users = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_solace_server", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "stat_definitions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_stat_definitions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "terrain_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    is_passable = table.Column<bool>(type: "boolean", nullable: false),
                    travel_modifier = table.Column<float>(type: "real", nullable: false),
                    encounter_modifier = table.Column<float>(type: "real", nullable: false),
                    event_modifier = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_terrain_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    role_id = table.Column<string>(type: "text", nullable: false),
                    claim_type = table.Column<string>(type: "text", nullable: true),
                    claim_value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_role_claims", x => x.id);
                    table.ForeignKey(
                        name: "fk_asp_net_role_claims_asp_net_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "AspNetRoles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<string>(type: "text", nullable: false),
                    claim_type = table.Column<string>(type: "text", nullable: true),
                    claim_value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_user_claims", x => x.id);
                    table.ForeignKey(
                        name: "fk_asp_net_user_claims_asp_net_users_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    login_provider = table.Column<string>(type: "text", nullable: false),
                    provider_key = table.Column<string>(type: "text", nullable: false),
                    provider_display_name = table.Column<string>(type: "text", nullable: true),
                    user_id = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_user_logins", x => new { x.login_provider, x.provider_key });
                    table.ForeignKey(
                        name: "fk_asp_net_user_logins_asp_net_users_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "text", nullable: false),
                    role_id = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_user_roles", x => new { x.user_id, x.role_id });
                    table.ForeignKey(
                        name: "fk_asp_net_user_roles_asp_net_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "AspNetRoles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_asp_net_user_roles_asp_net_users_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "text", nullable: false),
                    login_provider = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_asp_net_user_tokens", x => new { x.user_id, x.login_provider, x.name });
                    table.ForeignKey(
                        name: "fk_asp_net_user_tokens_asp_net_users_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "building_definition_actions",
                columns: table => new
                {
                    building_definition_id = table.Column<int>(type: "integer", nullable: false),
                    action_definition_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_building_definition_actions", x => new { x.building_definition_id, x.action_definition_id });
                    table.ForeignKey(
                        name: "fk_building_definition_actions_action_definitions_action_defin",
                        column: x => x.action_definition_id,
                        principalTable: "action_definitions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_building_definition_actions_building_definitions_building_d",
                        column: x => x.building_definition_id,
                        principalTable: "building_definitions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "effect_affected_abilities",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    effect_id = table.Column<int>(type: "integer", nullable: false),
                    action_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_effect_affected_abilities", x => x.id);
                    table.ForeignKey(
                        name: "fk_effect_affected_abilities_action_definitions_action_id",
                        column: x => x.action_id,
                        principalTable: "action_definitions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_effect_affected_abilities_effects_effect_id",
                        column: x => x.effect_id,
                        principalTable: "effects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    item_type_id = table.Column<int>(type: "integer", nullable: false),
                    is_enchanted = table.Column<bool>(type: "boolean", nullable: false),
                    is_cursed = table.Column<bool>(type: "boolean", nullable: false),
                    is_removable = table.Column<bool>(type: "boolean", nullable: false),
                    is_ephemeral = table.Column<bool>(type: "boolean", nullable: false),
                    min_damage = table.Column<int>(type: "integer", nullable: false),
                    max_damage = table.Column<int>(type: "integer", nullable: false),
                    damage_bonus = table.Column<int>(type: "integer", nullable: false),
                    uses = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_items", x => x.id);
                    table.ForeignKey(
                        name: "fk_items_item_types_item_type_id",
                        column: x => x.item_type_id,
                        principalTable: "item_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "class_base_stat_model",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    class_id = table.Column<int>(type: "integer", nullable: false),
                    stat_definition_id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_base_stat_model", x => x.id);
                    table.ForeignKey(
                        name: "fk_class_base_stat_model_class_model_class_id",
                        column: x => x.class_id,
                        principalTable: "class_model",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_base_stat_model_stat_definitions_stat_definition_id",
                        column: x => x.stat_definition_id,
                        principalTable: "stat_definitions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "effect_affected_stats",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    effect_id = table.Column<int>(type: "integer", nullable: false),
                    stat_definition_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_effect_affected_stats", x => x.id);
                    table.ForeignKey(
                        name: "fk_effect_affected_stats_effects_effect_id",
                        column: x => x.effect_id,
                        principalTable: "effects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_effect_affected_stats_stat_definitions_stat_definition_id",
                        column: x => x.stat_definition_id,
                        principalTable: "stat_definitions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "item_effects",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    item_id = table.Column<int>(type: "integer", nullable: false),
                    effect_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_item_effects", x => x.id);
                    table.ForeignKey(
                        name: "fk_item_effects_effects_effect_id",
                        column: x => x.effect_id,
                        principalTable: "effects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_item_effects_items_item_id",
                        column: x => x.item_id,
                        principalTable: "items",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "building_inventory",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    building_id = table.Column<int>(type: "integer", nullable: false),
                    item_id = table.Column<int>(type: "integer", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_building_inventory", x => x.id);
                    table.ForeignKey(
                        name: "fk_building_inventory_items_item_id",
                        column: x => x.item_id,
                        principalTable: "items",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "buildings",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    settlement_id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    building_type_id = table.Column<int>(type: "integer", nullable: false),
                    settlement_model_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_buildings", x => x.id);
                    table.ForeignKey(
                        name: "fk_buildings_building_definitions_building_type_id",
                        column: x => x.building_type_id,
                        principalTable: "building_definitions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hex_tiles",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    map_id = table.Column<int>(type: "integer", nullable: false),
                    q = table.Column<int>(type: "integer", nullable: false),
                    r = table.Column<int>(type: "integer", nullable: false),
                    s = table.Column<int>(type: "integer", nullable: false),
                    level = table.Column<int>(type: "integer", nullable: false),
                    hex_tile_type = table.Column<int>(type: "integer", nullable: false),
                    terrain_type_id = table.Column<int>(type: "integer", nullable: false),
                    settlement_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_hex_tiles", x => x.id);
                    table.CheckConstraint("CK_HexTile_CubeSum", "q + r + s = 0");
                    table.ForeignKey(
                        name: "fk_hex_tiles_solace_map_map_id",
                        column: x => x.map_id,
                        principalTable: "solace_map",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hex_tiles_terrain_types_terrain_type_id",
                        column: x => x.terrain_type_id,
                        principalTable: "terrain_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "player",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    is_npc = table.Column<bool>(type: "boolean", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    species_id = table.Column<int>(type: "integer", nullable: false),
                    settlement_location_id = table.Column<int>(type: "integer", nullable: false),
                    class_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_player", x => x.id);
                    table.ForeignKey(
                        name: "fk_player_class_model_class_id",
                        column: x => x.class_id,
                        principalTable: "class_model",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "player_equipment",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    player_id = table.Column<int>(type: "integer", nullable: false),
                    item_id = table.Column<int>(type: "integer", nullable: false),
                    placement = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_player_equipment", x => x.id);
                    table.ForeignKey(
                        name: "fk_player_equipment_items_item_id",
                        column: x => x.item_id,
                        principalTable: "items",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_player_equipment_player_player_id",
                        column: x => x.player_id,
                        principalTable: "player",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "player_inventories",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    player_id = table.Column<int>(type: "integer", nullable: false),
                    item_id = table.Column<int>(type: "integer", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_player_inventories", x => x.id);
                    table.ForeignKey(
                        name: "fk_player_inventories_items_item_id",
                        column: x => x.item_id,
                        principalTable: "items",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_player_inventories_player_player_id",
                        column: x => x.player_id,
                        principalTable: "player",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "player_stat_values",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    player_id = table.Column<int>(type: "integer", nullable: false),
                    stat_definition_id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_player_stat_values", x => x.id);
                    table.ForeignKey(
                        name: "fk_player_stat_values_player_player_id",
                        column: x => x.player_id,
                        principalTable: "player",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_player_stat_values_stat_definitions_stat_definition_id",
                        column: x => x.stat_definition_id,
                        principalTable: "stat_definitions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "settlements",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    leader_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_settlements", x => x.id);
                    table.ForeignKey(
                        name: "fk_settlements_player_leader_id",
                        column: x => x.leader_id,
                        principalTable: "player",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "action_definitions",
                columns: new[] { "id", "action_points", "is_combat_action", "is_item_action", "name" },
                values: new object[,]
                {
                    { 1, 1, true, false, "Attack" },
                    { 2, 1, true, false, "Defend" },
                    { 3, 2, true, false, "Cast" },
                    { 4, 2, true, false, "Equip" },
                    { 5, 1, true, true, "Use Item" },
                    { 6, 1, true, false, "Run" },
                    { 7, 0, false, false, "Talk" },
                    { 8, 0, false, true, "Use Item" },
                    { 9, 0, false, false, "Move" },
                    { 10, 0, false, false, "Buy" },
                    { 11, 0, false, false, "Sell" },
                    { 13, 0, false, false, "Trade" },
                    { 14, 0, false, false, "Train" },
                    { 15, 0, false, false, "Deposit" },
                    { 16, 0, false, false, "Withdraw" },
                    { 17, 0, false, false, "Rest" },
                    { 18, 0, false, false, "Hire" },
                    { 19, 0, false, false, "Fire" },
                    { 20, 0, false, false, "InitiateCombat" },
                    { 21, 0, false, false, "Eat" }
                });

            migrationBuilder.InsertData(
                table: "building_definitions",
                columns: new[] { "id", "allows_combat", "has_inventory", "name" },
                values: new object[,]
                {
                    { 1, false, true, "Store" },
                    { 2, true, true, "Guild" },
                    { 3, false, true, "Inn" },
                    { 4, false, true, "Tavern" },
                    { 5, false, true, "Bank" },
                    { 6, false, true, "Storage" },
                    { 7, true, false, "Arena" },
                    { 8, false, true, "House" },
                    { 9, true, true, "TrainingHall" },
                    { 10, false, false, "ServiceProvider" }
                });

            migrationBuilder.InsertData(
                table: "class_model",
                columns: new[] { "id", "description", "magic_user", "name", "use_two_handed_weapons" },
                values: new object[,]
                {
                    { 1, "A Fighter", false, "Fighter", true },
                    { 2, "A Rougue", false, "Rougue", false },
                    { 3, "A Sorcerer", true, "Sorcerer", false }
                });

            migrationBuilder.InsertData(
                table: "effects",
                columns: new[] { "id", "ability_affected_id", "affected_body_part", "is_instant", "name" },
                values: new object[,]
                {
                    { 1, 0, null, true, "Blunt Damaage" },
                    { 2, 0, null, true, "Piercing Damage" },
                    { 3, 0, null, true, "Stun" },
                    { 4, 0, null, true, "Heal" },
                    { 5, 0, null, true, "ModMaxHealth" },
                    { 6, 0, null, true, "ModStamina" },
                    { 7, 0, null, true, "ModStrength" },
                    { 8, 0, null, true, "ModIntelligence" },
                    { 9, 0, null, true, "ModEducation" },
                    { 10, 0, null, true, "ModMana" },
                    { 11, 0, null, true, "ModMaxHealth" },
                    { 12, 0, null, true, "ModMagicLevel" },
                    { 13, 0, null, true, "ModTechLevel" },
                    { 14, 0, null, true, "ModExperience" },
                    { 15, 0, null, true, "ModLevel" },
                    { 16, 0, null, true, "ModMorale" },
                    { 17, 0, null, true, "ModSanity" },
                    { 18, 0, null, true, "ModActionPoints" },
                    { 19, 0, null, true, "ModActionPointsMax" },
                    { 20, 0, null, true, "ModCharisma" }
                });

            migrationBuilder.InsertData(
                table: "item_types",
                columns: new[] { "id", "elligible_placement", "is_limited_use", "name", "player_equippable", "slots_required" },
                values: new object[,]
                {
                    { 1, new[] { 0 }, false, "Headwear", true, 1 },
                    { 2, new[] { 2 }, false, "FacialMask", true, 1 },
                    { 3, new[] { 5 }, false, "Necklace", true, 1 },
                    { 4, new[] { 1 }, false, "Earrings", true, 1 },
                    { 5, new[] { 0 }, false, "HairAccessory", true, 1 },
                    { 6, new[] { 15 }, false, "Chestplate", true, 1 },
                    { 7, new[] { 15 }, false, "Tunic", true, 1 },
                    { 8, new[] { 15 }, false, "Skirt", true, 1 },
                    { 9, new[] { 6 }, false, "Overwear", true, 1 },
                    { 10, new[] { 15 }, false, "Undergarment", true, 1 },
                    { 11, new[] { 16 }, false, "Belt", true, 1 },
                    { 12, new[] { 16 }, false, "WaistPouch", true, 1 },
                    { 13, new[] { 7, 8 }, false, "ShoulderPads", true, 1 },
                    { 14, new[] { 9, 10 }, false, "ArmGuard", true, 1 },
                    { 15, new[] { 13, 14 }, false, "WristBand", true, 1 },
                    { 16, new[] { 11, 12 }, false, "Gauntlets", true, 1 },
                    { 17, new[] { 11, 12 }, false, "Gloves", true, 1 },
                    { 18, new[] { 17, 18 }, false, "ThighArmor", true, 1 },
                    { 19, new[] { 17, 18 }, false, "Pants", true, 1 },
                    { 20, new[] { 19, 20 }, false, "Greaves", true, 1 },
                    { 21, new[] { 21, 22 }, false, "Boots", true, 1 },
                    { 22, new[] { 23, 24 }, false, "AnkleCuffs", true, 1 },
                    { 23, new[] { 35, 40 }, false, "ToeRings", true, 1 },
                    { 24, null, true, "Potion", false, 1 },
                    { 25, new[] { 15 }, false, "ToolKit", true, 1 },
                    { 26, null, false, "Paper", false, 1 },
                    { 27, new[] { 13, 14 }, false, "Bracelet", true, 1 },
                    { 28, new[] { 11 }, false, "OneHandedWeapon", true, 1 },
                    { 29, new[] { 11, 12 }, false, "TwoHandedWeapon", true, 2 },
                    { 30, new[] { 11 }, false, "SmallWeapon", true, 1 },
                    { 31, new[] { 23, 24 }, false, "Anklet", true, 1 },
                    { 40, new[] { 11, 12 }, false, "Shield", true, 1 },
                    { 43, null, false, "Book", false, 1 },
                    { 50, new[] { 11, 12 }, false, "Two-Handled Ranged", true, 2 },
                    { 51, new[] { 11, 12 }, false, "One-Handled Ranged", true, 1 },
                    { 52, new[] { 11, 12 }, false, "ThrownWeapon", true, 1 },
                    { 53, null, false, "Ammunition", false, 1 },
                    { 60, new[] { 15 }, false, "Backpack", true, 1 },
                    { 61, new[] { 15, 7, 8 }, false, "Satchel", true, 1 },
                    { 71, null, false, "Ingredient", false, 1 },
                    { 90, null, false, "Tool", false, 1 },
                    { 100, null, false, "Currency", false, 1 },
                    { 101, null, false, "Valuable", false, 1 },
                    { 102, null, false, "TradeGood", false, 1 },
                    { 111, null, false, "Key", false, 1 },
                    { 120, null, true, "Food", false, 1 }
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
                    { 12, "Level" },
                    { 13, "Morale" },
                    { 14, "Sanity" },
                    { 15, "ActionPoints" },
                    { 16, "ActionPointsMax" },
                    { 17, "Charisma" }
                });

            migrationBuilder.InsertData(
                table: "terrain_types",
                columns: new[] { "id", "encounter_modifier", "event_modifier", "is_passable", "name", "travel_modifier" },
                values: new object[,]
                {
                    { 1, 0.5f, 0.1f, true, "Forest", 0.2f },
                    { 2, 0.5f, 0.1f, true, "Plains", 0.1f },
                    { 3, 0.5f, 0.1f, true, "Desert", 0.3f },
                    { 4, 0.5f, 0.1f, true, "Mountain", 1f },
                    { 5, 0f, 0f, false, "Water", 0f },
                    { 6, 0.5f, 0.1f, true, "Hills", 0.5f },
                    { 7, 1.5f, 0.4f, true, "DangerousForest", 0.2f },
                    { 8, 1.5f, 0.4f, true, "DangerousPlains", 0.1f },
                    { 9, 1.5f, 0.4f, true, "DangerousDesert", 0.3f },
                    { 10, 1.5f, 0.4f, true, "DangerousMountain", 1f },
                    { 11, 1f, 0.4f, false, "DangerousWater", 0f },
                    { 12, 1.5f, 0.4f, true, "DangerousHills", 0.5f }
                });

            migrationBuilder.InsertData(
                table: "building_definition_actions",
                columns: new[] { "action_definition_id", "building_definition_id" },
                values: new object[,]
                {
                    { 7, 1 },
                    { 10, 1 },
                    { 11, 1 },
                    { 13, 1 },
                    { 14, 2 },
                    { 18, 2 },
                    { 19, 2 },
                    { 7, 3 },
                    { 17, 3 },
                    { 21, 3 },
                    { 5, 4 },
                    { 7, 4 },
                    { 10, 4 },
                    { 21, 4 },
                    { 15, 5 },
                    { 16, 5 },
                    { 9, 6 },
                    { 15, 6 },
                    { 16, 6 },
                    { 20, 7 },
                    { 7, 8 },
                    { 17, 8 },
                    { 21, 8 },
                    { 14, 9 },
                    { 7, 10 },
                    { 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "class_base_stat_model",
                columns: new[] { "id", "class_id", "stat_definition_id", "value" },
                values: new object[,]
                {
                    { 1, 1, 1, 20 },
                    { 2, 1, 2, 20 },
                    { 3, 1, 3, 7 },
                    { 4, 1, 4, 9 },
                    { 5, 1, 5, 2 },
                    { 6, 1, 6, 2 },
                    { 7, 1, 7, 0 },
                    { 8, 1, 8, 0 },
                    { 9, 1, 9, 0 },
                    { 10, 1, 10, 0 },
                    { 11, 1, 11, 0 },
                    { 12, 1, 12, 0 },
                    { 13, 1, 13, 5 },
                    { 14, 1, 14, 10 },
                    { 15, 1, 15, 1 },
                    { 16, 1, 16, 1 },
                    { 17, 1, 17, 3 },
                    { 18, 2, 1, 14 },
                    { 19, 2, 2, 14 },
                    { 20, 2, 3, 4 },
                    { 21, 2, 4, 5 },
                    { 22, 2, 5, 4 },
                    { 23, 2, 6, 4 },
                    { 24, 2, 7, 0 },
                    { 25, 2, 8, 0 },
                    { 26, 2, 9, 0 },
                    { 27, 2, 10, 0 },
                    { 28, 2, 11, 0 },
                    { 29, 2, 12, 0 },
                    { 30, 2, 13, 5 },
                    { 31, 2, 14, 10 },
                    { 32, 2, 15, 1 },
                    { 33, 2, 16, 1 },
                    { 34, 2, 17, 3 },
                    { 35, 3, 1, 8 },
                    { 36, 3, 2, 8 },
                    { 37, 3, 3, 3 },
                    { 38, 3, 4, 2 },
                    { 39, 3, 5, 8 },
                    { 40, 3, 6, 6 },
                    { 41, 3, 7, 3 },
                    { 42, 3, 8, 3 },
                    { 43, 3, 9, 0 },
                    { 44, 3, 10, 0 },
                    { 45, 3, 11, 0 },
                    { 46, 3, 12, 0 },
                    { 47, 3, 13, 5 },
                    { 48, 3, 14, 10 },
                    { 49, 3, 15, 1 },
                    { 50, 3, 16, 1 },
                    { 51, 3, 17, 3 }
                });

            migrationBuilder.InsertData(
                table: "effect_affected_abilities",
                columns: new[] { "id", "action_id", "effect_id" },
                values: new object[,]
                {
                    { 1, 1, 3 },
                    { 2, 2, 3 },
                    { 3, 3, 3 },
                    { 4, 4, 3 },
                    { 5, 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "effect_affected_stats",
                columns: new[] { "id", "effect_id", "stat_definition_id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 4, 1 },
                    { 4, 5, 2 },
                    { 5, 6, 3 },
                    { 6, 7, 4 },
                    { 7, 8, 5 },
                    { 8, 9, 6 },
                    { 9, 10, 7 },
                    { 10, 11, 8 },
                    { 11, 12, 9 },
                    { 12, 13, 10 },
                    { 13, 14, 11 },
                    { 14, 15, 12 },
                    { 15, 16, 13 },
                    { 16, 17, 14 },
                    { 17, 18, 15 },
                    { 18, 19, 16 },
                    { 19, 20, 17 }
                });

            migrationBuilder.CreateIndex(
                name: "ix_asp_net_role_claims_role_id",
                table: "AspNetRoleClaims",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "normalized_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_asp_net_user_claims_user_id",
                table: "AspNetUserClaims",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_asp_net_user_logins_user_id",
                table: "AspNetUserLogins",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_asp_net_user_roles_role_id",
                table: "AspNetUserRoles",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "normalized_email");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "normalized_user_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_building_definition_actions_action_definition_id",
                table: "building_definition_actions",
                column: "action_definition_id");

            migrationBuilder.CreateIndex(
                name: "ix_building_inventory_building_id",
                table: "building_inventory",
                column: "building_id");

            migrationBuilder.CreateIndex(
                name: "ix_building_inventory_item_id",
                table: "building_inventory",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "ix_buildings_building_type_id",
                table: "buildings",
                column: "building_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_buildings_settlement_id",
                table: "buildings",
                column: "settlement_id");

            migrationBuilder.CreateIndex(
                name: "ix_buildings_settlement_model_id",
                table: "buildings",
                column: "settlement_model_id");

            migrationBuilder.CreateIndex(
                name: "ix_class_base_stat_model_class_id",
                table: "class_base_stat_model",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "ix_class_base_stat_model_stat_definition_id",
                table: "class_base_stat_model",
                column: "stat_definition_id");

            migrationBuilder.CreateIndex(
                name: "ix_effect_affected_abilities_action_id",
                table: "effect_affected_abilities",
                column: "action_id");

            migrationBuilder.CreateIndex(
                name: "ix_effect_affected_abilities_effect_id",
                table: "effect_affected_abilities",
                column: "effect_id");

            migrationBuilder.CreateIndex(
                name: "ix_effect_affected_stats_effect_id",
                table: "effect_affected_stats",
                column: "effect_id");

            migrationBuilder.CreateIndex(
                name: "ix_effect_affected_stats_stat_definition_id",
                table: "effect_affected_stats",
                column: "stat_definition_id");

            migrationBuilder.CreateIndex(
                name: "ix_hex_tiles_map_id_q_r_s_level",
                table: "hex_tiles",
                columns: new[] { "map_id", "q", "r", "s", "level" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_hex_tiles_settlement_id",
                table: "hex_tiles",
                column: "settlement_id");

            migrationBuilder.CreateIndex(
                name: "ix_hex_tiles_terrain_type_id",
                table: "hex_tiles",
                column: "terrain_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_item_effects_effect_id",
                table: "item_effects",
                column: "effect_id");

            migrationBuilder.CreateIndex(
                name: "ix_item_effects_item_id_effect_id",
                table: "item_effects",
                columns: new[] { "item_id", "effect_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_items_item_type_id",
                table: "items",
                column: "item_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_player_class_id",
                table: "player",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "ix_player_settlement_location_id",
                table: "player",
                column: "settlement_location_id");

            migrationBuilder.CreateIndex(
                name: "ix_player_equipment_item_id",
                table: "player_equipment",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "ix_player_equipment_player_id_placement",
                table: "player_equipment",
                columns: new[] { "player_id", "placement" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_player_inventories_item_id",
                table: "player_inventories",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "ix_player_inventories_player_id",
                table: "player_inventories",
                column: "player_id");

            migrationBuilder.CreateIndex(
                name: "ix_player_stat_values_player_id_stat_definition_id",
                table: "player_stat_values",
                columns: new[] { "player_id", "stat_definition_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_player_stat_values_stat_definition_id",
                table: "player_stat_values",
                column: "stat_definition_id");

            migrationBuilder.CreateIndex(
                name: "ix_settlements_leader_id",
                table: "settlements",
                column: "leader_id");

            migrationBuilder.AddForeignKey(
                name: "fk_building_inventory_buildings_building_id",
                table: "building_inventory",
                column: "building_id",
                principalTable: "buildings",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_buildings_settlements_settlement_id",
                table: "buildings",
                column: "settlement_id",
                principalTable: "settlements",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_buildings_settlements_settlement_model_id",
                table: "buildings",
                column: "settlement_model_id",
                principalTable: "settlements",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_hex_tiles_settlements_settlement_id",
                table: "hex_tiles",
                column: "settlement_id",
                principalTable: "settlements",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_player_settlements_settlement_location_id",
                table: "player",
                column: "settlement_location_id",
                principalTable: "settlements",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_player_settlements_settlement_location_id",
                table: "player");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "building_definition_actions");

            migrationBuilder.DropTable(
                name: "building_inventory");

            migrationBuilder.DropTable(
                name: "class_base_stat_model");

            migrationBuilder.DropTable(
                name: "effect_affected_abilities");

            migrationBuilder.DropTable(
                name: "effect_affected_stats");

            migrationBuilder.DropTable(
                name: "hex_tiles");

            migrationBuilder.DropTable(
                name: "item_effects");

            migrationBuilder.DropTable(
                name: "player_equipment");

            migrationBuilder.DropTable(
                name: "player_inventories");

            migrationBuilder.DropTable(
                name: "player_stat_values");

            migrationBuilder.DropTable(
                name: "refresh_tokens");

            migrationBuilder.DropTable(
                name: "solace_server");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "buildings");

            migrationBuilder.DropTable(
                name: "action_definitions");

            migrationBuilder.DropTable(
                name: "solace_map");

            migrationBuilder.DropTable(
                name: "terrain_types");

            migrationBuilder.DropTable(
                name: "effects");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "stat_definitions");

            migrationBuilder.DropTable(
                name: "building_definitions");

            migrationBuilder.DropTable(
                name: "item_types");

            migrationBuilder.DropTable(
                name: "settlements");

            migrationBuilder.DropTable(
                name: "player");

            migrationBuilder.DropTable(
                name: "class_model");
        }
    }
}
