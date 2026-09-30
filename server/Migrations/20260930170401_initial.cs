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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    ability_affected_id = table.Column<Guid>(type: "uuid", nullable: false),
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
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
                    building_definition_id = table.Column<Guid>(type: "uuid", nullable: false),
                    action_definition_id = table.Column<Guid>(type: "uuid", nullable: false)
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    effect_id = table.Column<Guid>(type: "uuid", nullable: false),
                    action_id = table.Column<Guid>(type: "uuid", nullable: false)
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    item_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_enchanted = table.Column<bool>(type: "boolean", nullable: false),
                    is_cursed = table.Column<bool>(type: "boolean", nullable: false),
                    is_removable = table.Column<bool>(type: "boolean", nullable: false),
                    is_ephemeral = table.Column<bool>(type: "boolean", nullable: false),
                    level = table.Column<int>(type: "integer", nullable: false),
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    class_id = table.Column<Guid>(type: "uuid", nullable: false),
                    stat_definition_id = table.Column<Guid>(type: "uuid", nullable: false),
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    effect_id = table.Column<Guid>(type: "uuid", nullable: false),
                    stat_definition_id = table.Column<Guid>(type: "uuid", nullable: false)
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    item_id = table.Column<Guid>(type: "uuid", nullable: false),
                    effect_id = table.Column<Guid>(type: "uuid", nullable: false)
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    building_id = table.Column<Guid>(type: "uuid", nullable: false),
                    item_id = table.Column<Guid>(type: "uuid", nullable: false),
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    settlement_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    building_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    settlement_model_id = table.Column<Guid>(type: "uuid", nullable: true)
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    map_id = table.Column<Guid>(type: "uuid", nullable: false),
                    q = table.Column<int>(type: "integer", nullable: false),
                    r = table.Column<int>(type: "integer", nullable: false),
                    s = table.Column<int>(type: "integer", nullable: false),
                    level = table.Column<int>(type: "integer", nullable: false),
                    hex_tile_type = table.Column<int>(type: "integer", nullable: false),
                    terrain_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    settlement_id = table.Column<Guid>(type: "uuid", nullable: true)
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_npc = table.Column<bool>(type: "boolean", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    species_id = table.Column<Guid>(type: "uuid", nullable: false),
                    settlement_location_id = table.Column<Guid>(type: "uuid", nullable: false),
                    class_id = table.Column<Guid>(type: "uuid", nullable: false)
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    player_id = table.Column<Guid>(type: "uuid", nullable: false),
                    item_id = table.Column<Guid>(type: "uuid", nullable: false),
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    player_id = table.Column<Guid>(type: "uuid", nullable: false),
                    item_id = table.Column<Guid>(type: "uuid", nullable: false),
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    player_id = table.Column<Guid>(type: "uuid", nullable: false),
                    stat_definition_id = table.Column<Guid>(type: "uuid", nullable: false),
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
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    leader_id = table.Column<Guid>(type: "uuid", nullable: true)
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
                    { new Guid("a1111111-2020-3030-4040-5060708090a1"), 1, true, false, "Attack" },
                    { new Guid("a1111111-2020-3030-4040-5060708090a2"), 1, true, false, "Defend" },
                    { new Guid("a1111111-2020-3030-4040-5060708090a3"), 2, true, false, "Cast" },
                    { new Guid("a1111111-2020-3030-4040-5060708090a4"), 2, true, false, "Equip" },
                    { new Guid("a1111111-2020-3030-4040-5060708090a5"), 1, true, true, "Use Item" },
                    { new Guid("a1111111-2020-3030-4040-5060708090a6"), 1, true, false, "Run" },
                    { new Guid("a1111111-2020-3030-4040-5060708090a7"), 0, false, false, "Talk" },
                    { new Guid("a1111111-2020-3030-4040-5060708090a8"), 0, false, true, "Use Item" },
                    { new Guid("a1111111-2020-3030-4040-5060708090a9"), 0, false, false, "Move" },
                    { new Guid("a1111111-2020-3030-4040-5060708090aa"), 0, false, false, "Buy" },
                    { new Guid("a1111111-2020-3030-4040-5060708090ab"), 0, false, false, "Sell" },
                    { new Guid("a1111111-2020-3030-4040-5060708090ac"), 0, false, false, "Trade" },
                    { new Guid("a1111111-2020-3030-4040-5060708090ad"), 0, false, false, "Train" },
                    { new Guid("a1111111-2020-3030-4040-5060708090ae"), 0, false, false, "Deposit" },
                    { new Guid("a1111111-2020-3030-4040-5060708090af"), 0, false, false, "Withdraw" },
                    { new Guid("a1111111-2020-3030-4040-5060708090b0"), 0, false, false, "Rest" },
                    { new Guid("a1111111-2020-3030-4040-5060708090b1"), 0, false, false, "Hire" },
                    { new Guid("a1111111-2020-3030-4040-5060708090b2"), 0, false, false, "Fire" },
                    { new Guid("a1111111-2020-3030-4040-5060708090b3"), 0, false, false, "InitiateCombat" },
                    { new Guid("a1111111-2020-3030-4040-5060708090b4"), 0, false, false, "Eat" }
                });

            migrationBuilder.InsertData(
                table: "building_definitions",
                columns: new[] { "id", "allows_combat", "has_inventory", "name" },
                values: new object[,]
                {
                    { new Guid("b1111111-2020-3030-4040-5060708090a1"), false, true, "Store" },
                    { new Guid("b1111111-2020-3030-4040-5060708090a2"), true, true, "Guild" },
                    { new Guid("b1111111-2020-3030-4040-5060708090a3"), false, true, "Inn" },
                    { new Guid("b1111111-2020-3030-4040-5060708090a4"), false, true, "Tavern" },
                    { new Guid("b1111111-2020-3030-4040-5060708090a5"), false, true, "Bank" },
                    { new Guid("b1111111-2020-3030-4040-5060708090a6"), false, true, "Storage" },
                    { new Guid("b1111111-2020-3030-4040-5060708090a7"), true, false, "Arena" },
                    { new Guid("b1111111-2020-3030-4040-5060708090a8"), false, true, "House" },
                    { new Guid("b1111111-2020-3030-4040-5060708090a9"), true, true, "Training Hall" },
                    { new Guid("b1111111-2020-3030-4040-5060708090aa"), false, false, "Service Provider" }
                });

            migrationBuilder.InsertData(
                table: "class_model",
                columns: new[] { "id", "description", "magic_user", "name", "use_two_handed_weapons" },
                values: new object[,]
                {
                    { new Guid("11111111-2222-3333-4444-556677889900"), "A Fighter", false, "Fighter", true },
                    { new Guid("22222222-3333-4444-5555-667788990011"), "A Rougue", false, "Rougue", false },
                    { new Guid("33333333-4444-5555-6666-778899001122"), "A Sorcerer", true, "Sorcerer", false }
                });

            migrationBuilder.InsertData(
                table: "effects",
                columns: new[] { "id", "ability_affected_id", "affected_body_part", "is_instant", "name" },
                values: new object[,]
                {
                    { new Guid("10101010-2020-3030-4040-5060708090a0"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "ModMana" },
                    { new Guid("10111111-2222-3333-4444-556677889901"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "Blunt Damaage" },
                    { new Guid("20202020-3030-4040-5050-60708090a0b1"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "ModMaxMana" },
                    { new Guid("20222222-3333-4444-5555-667788990012"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "Piercing Damage" },
                    { new Guid("30303030-4040-5050-6060-708090a0b0c1"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "ModMagicLevel" },
                    { new Guid("30333333-4444-5555-6666-778899001123"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "Stun" },
                    { new Guid("40404040-5050-6060-7070-8090a0b0c0d1"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "ModTechLevel" },
                    { new Guid("40444444-5555-6666-7777-889900112234"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "Heal" },
                    { new Guid("50505050-6060-7070-8080-90a0b0c0d0e1"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "ModExperience" },
                    { new Guid("50555555-6666-7777-8888-901122334456"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "ModMaxHealth" },
                    { new Guid("60606060-7070-8080-9090-a0b0c0d0e0f1"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "ModLevel" },
                    { new Guid("60666666-7777-8888-9999-012233445567"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "ModStamina" },
                    { new Guid("70707070-8080-9090-a0a0-b0c0d0e0f123"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "ModMorale" },
                    { new Guid("70777777-8888-9999-0000-123344556678"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "ModStrength" },
                    { new Guid("80808080-9090-a0a0-b0b0-c0d0e0f12345"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "ModSanity" },
                    { new Guid("80888888-9999-0000-1111-234455667789"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "ModIntelligence" },
                    { new Guid("90909090-a0a0-b0b0-c0c0-d0e0f1234567"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "ModActionPoints" },
                    { new Guid("90999999-0000-1111-2222-345566778890"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "ModEducation" },
                    { new Guid("a0a0a0a0-b0b0-c0c0-d0d0-e0f123456789"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "ModActionPointsMax" },
                    { new Guid("b0b0b0b0-c0c0-d0d0-e0e0-f1234567890a"), new Guid("00000000-0000-0000-0000-000000000000"), null, true, "ModCharisma" }
                });

            migrationBuilder.InsertData(
                table: "item_types",
                columns: new[] { "id", "elligible_placement", "is_limited_use", "name", "player_equippable", "slots_required" },
                values: new object[,]
                {
                    { new Guid("10101010-2020-3030-4040-5060708090a1"), new[] { 0 }, false, "Headwear", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090a2"), new[] { 2 }, false, "FacialMask", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090a3"), new[] { 5 }, false, "Necklace", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090a4"), new[] { 1 }, false, "Earrings", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090a5"), new[] { 0 }, false, "HairAccessory", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090a6"), new[] { 13, 14 }, false, "Bracelet", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090a7"), new[] { 23, 24 }, false, "Anklet", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090a8"), new[] { 15 }, false, "Chestplate", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090a9"), new[] { 15 }, false, "Tunic", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090aa"), new[] { 15 }, false, "Skirt", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090ab"), new[] { 6 }, false, "Overwear", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090ac"), new[] { 15 }, false, "Undergarment", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090ad"), new[] { 16 }, false, "Belt", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090ae"), new[] { 16 }, false, "WaistPouch", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090af"), new[] { 7, 8 }, false, "ShoulderPads", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090b0"), new[] { 9, 10 }, false, "ArmGuard", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090b1"), new[] { 13, 14 }, false, "WristBand", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090b2"), new[] { 11, 12 }, false, "Gauntlets", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090b3"), new[] { 11, 12 }, false, "Gloves", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090b4"), new[] { 17, 18 }, false, "ThighArmor", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090b5"), new[] { 17, 18 }, false, "Pants", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090b6"), new[] { 19, 20 }, false, "Greaves", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090b7"), new[] { 21, 22 }, false, "Boots", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090b8"), new[] { 23, 24 }, false, "AnkleCuffs", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090b9"), new[] { 35, 40 }, false, "ToeRings", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090ba"), null, true, "Potion", false, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090bb"), new[] { 15 }, false, "ToolKit", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090bc"), null, false, "Paper", false, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090bd"), null, false, "Book", false, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090be"), new[] { 11 }, false, "OneHandedWeapon", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090bf"), new[] { 11, 12 }, false, "TwoHandedWeapon", true, 2 },
                    { new Guid("10101010-2020-3030-4040-5060708090c0"), new[] { 11 }, false, "SmallWeapon", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090c1"), new[] { 11, 12 }, false, "Shield", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090c2"), new[] { 11, 12 }, false, "Two-Handled Ranged", true, 2 },
                    { new Guid("10101010-2020-3030-4040-5060708090c3"), new[] { 11, 12 }, false, "One-Handled Ranged", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090c4"), new[] { 11, 12 }, false, "ThrownWeapon", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090c5"), null, false, "Ammunition", false, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090c6"), new[] { 15 }, false, "Backpack", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090c7"), new[] { 15, 7, 8 }, false, "Satchel", true, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090c8"), null, false, "Ingredient", false, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090c9"), null, false, "Tool", false, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090da"), null, false, "Currency", false, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090db"), null, false, "Valuable", false, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090dc"), null, false, "TradeGood", false, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090dd"), null, false, "Key", false, 1 },
                    { new Guid("10101010-2020-3030-4040-5060708090de"), null, true, "Food", false, 1 }
                });

            migrationBuilder.InsertData(
                table: "stat_definitions",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("2f76c1e3-9b84-4d5a-902c-79163e92b8f4"), "HealthMax" },
                    { new Guid("735d046e-9b1c-4a24-8f7c-53d0db69b1e5"), "Health" },
                    { new Guid("a1b2c3d4-e5f6-7890-abcd-ef1234567890"), "Education" },
                    { new Guid("a7b8c9d0-e1f2-3456-abc4-7890abcdef12"), "Level" },
                    { new Guid("b2c3d4e5-f6a7-8901-bcde-234567890abc"), "Mana" },
                    { new Guid("b8c9d0e1-f2a3-4567-abc5-890abcdef123"), "Morale" },
                    { new Guid("c3d4e5f6-a7b8-9012-cdef-34567890abcd"), "ManaMax" },
                    { new Guid("c82f9e3d-1a5b-476c-90ef-823456789abc"), "Strength" },
                    { new Guid("c9d0e1f2-a3b4-5678-abc6-90abcdef1234"), "Sanity" },
                    { new Guid("d0e1f2a3-b4c5-6789-abc7-abcdef123456"), "ActionPoints" },
                    { new Guid("d4e5f6a7-b8c9-0123-abc1-4567890abcde"), "MagicLevel" },
                    { new Guid("d93e0f21-8b7a-456c-ad3e-1234567890ab"), "Intelligence" },
                    { new Guid("e1f2a3b4-c5d6-7890-abc8-bcdef1234567"), "ActionPointsMax" },
                    { new Guid("e5f6a7b8-c9d0-1234-abc2-567890abcdef"), "TechLevel" },
                    { new Guid("e94b3d21-6c8a-4f09-bc7e-51382d94b6a1"), "Stamina" },
                    { new Guid("f2a3b4c5-d6e7-8901-abc9-cdef12345678"), "Charisma" },
                    { new Guid("f6a7b8c9-d0e1-2345-abc3-67890abcdef1"), "Experience" }
                });

            migrationBuilder.InsertData(
                table: "terrain_types",
                columns: new[] { "id", "encounter_modifier", "event_modifier", "is_passable", "name", "travel_modifier" },
                values: new object[,]
                {
                    { new Guid("f01e5872-3b9c-4d6a-9f8e-1029384756af"), 0.5f, 0.1f, true, "Forest", 0.2f },
                    { new Guid("f02e5872-3b9c-4d6a-9f8e-1029384756b1"), 0.5f, 0.1f, true, "Plains", 0.1f },
                    { new Guid("f03e5872-3b9c-4d6a-9f8e-1029384756c2"), 0.5f, 0.1f, true, "Desert", 0.3f },
                    { new Guid("f04e5872-3b9c-4d6a-9f8e-1029384756d3"), 0.5f, 0.1f, true, "Mountain", 1f },
                    { new Guid("f05e5872-3b9c-4d6a-9f8e-1029384756e4"), 0f, 0f, false, "Water", 0f },
                    { new Guid("f06e5872-3b9c-4d6a-9f8e-1029384756f5"), 0.5f, 0.1f, true, "Hills", 0.5f },
                    { new Guid("f07e5872-3b9c-4d6a-9f8e-1029384756a6"), 1.5f, 0.4f, true, "DangerousForest", 0.2f },
                    { new Guid("f08e5872-3b9c-4d6a-9f8e-1029384756b7"), 1.5f, 0.4f, true, "DangerousPlains", 0.1f },
                    { new Guid("f09e5872-3b9c-4d6a-9f8e-1029384756c8"), 1.5f, 0.4f, true, "DangerousDesert", 0.3f },
                    { new Guid("f10e5872-3b9c-4d6a-9f8e-1029384756d9"), 1.5f, 0.4f, true, "DangerousMountain", 1f },
                    { new Guid("f11e5872-3b9c-4d6a-9f8e-1029384756e0"), 1f, 0.4f, false, "DangerousWater", 0f },
                    { new Guid("f12e5872-3b9c-4d6a-9f8e-1029384756f1"), 1.5f, 0.4f, true, "DangerousHills", 0.5f }
                });

            migrationBuilder.InsertData(
                table: "building_definition_actions",
                columns: new[] { "action_definition_id", "building_definition_id" },
                values: new object[,]
                {
                    { new Guid("a1111111-2020-3030-4040-5060708090a7"), new Guid("b1111111-2020-3030-4040-5060708090a1") },
                    { new Guid("a1111111-2020-3030-4040-5060708090aa"), new Guid("b1111111-2020-3030-4040-5060708090a1") },
                    { new Guid("a1111111-2020-3030-4040-5060708090ab"), new Guid("b1111111-2020-3030-4040-5060708090a1") },
                    { new Guid("a1111111-2020-3030-4040-5060708090ac"), new Guid("b1111111-2020-3030-4040-5060708090a1") },
                    { new Guid("a1111111-2020-3030-4040-5060708090ad"), new Guid("b1111111-2020-3030-4040-5060708090a2") },
                    { new Guid("a1111111-2020-3030-4040-5060708090b1"), new Guid("b1111111-2020-3030-4040-5060708090a2") },
                    { new Guid("a1111111-2020-3030-4040-5060708090b2"), new Guid("b1111111-2020-3030-4040-5060708090a2") },
                    { new Guid("a1111111-2020-3030-4040-5060708090a7"), new Guid("b1111111-2020-3030-4040-5060708090a3") },
                    { new Guid("a1111111-2020-3030-4040-5060708090b0"), new Guid("b1111111-2020-3030-4040-5060708090a3") },
                    { new Guid("a1111111-2020-3030-4040-5060708090b4"), new Guid("b1111111-2020-3030-4040-5060708090a3") },
                    { new Guid("a1111111-2020-3030-4040-5060708090a5"), new Guid("b1111111-2020-3030-4040-5060708090a4") },
                    { new Guid("a1111111-2020-3030-4040-5060708090a7"), new Guid("b1111111-2020-3030-4040-5060708090a4") },
                    { new Guid("a1111111-2020-3030-4040-5060708090aa"), new Guid("b1111111-2020-3030-4040-5060708090a4") },
                    { new Guid("a1111111-2020-3030-4040-5060708090b4"), new Guid("b1111111-2020-3030-4040-5060708090a4") },
                    { new Guid("a1111111-2020-3030-4040-5060708090ae"), new Guid("b1111111-2020-3030-4040-5060708090a5") },
                    { new Guid("a1111111-2020-3030-4040-5060708090af"), new Guid("b1111111-2020-3030-4040-5060708090a5") },
                    { new Guid("a1111111-2020-3030-4040-5060708090a9"), new Guid("b1111111-2020-3030-4040-5060708090a6") },
                    { new Guid("a1111111-2020-3030-4040-5060708090ae"), new Guid("b1111111-2020-3030-4040-5060708090a6") },
                    { new Guid("a1111111-2020-3030-4040-5060708090af"), new Guid("b1111111-2020-3030-4040-5060708090a6") },
                    { new Guid("a1111111-2020-3030-4040-5060708090b3"), new Guid("b1111111-2020-3030-4040-5060708090a7") },
                    { new Guid("a1111111-2020-3030-4040-5060708090a7"), new Guid("b1111111-2020-3030-4040-5060708090a8") },
                    { new Guid("a1111111-2020-3030-4040-5060708090b0"), new Guid("b1111111-2020-3030-4040-5060708090a8") },
                    { new Guid("a1111111-2020-3030-4040-5060708090b4"), new Guid("b1111111-2020-3030-4040-5060708090a8") },
                    { new Guid("a1111111-2020-3030-4040-5060708090ad"), new Guid("b1111111-2020-3030-4040-5060708090a9") },
                    { new Guid("a1111111-2020-3030-4040-5060708090a7"), new Guid("b1111111-2020-3030-4040-5060708090aa") },
                    { new Guid("a1111111-2020-3030-4040-5060708090aa"), new Guid("b1111111-2020-3030-4040-5060708090aa") }
                });

            migrationBuilder.InsertData(
                table: "class_base_stat_model",
                columns: new[] { "id", "class_id", "stat_definition_id", "value" },
                values: new object[,]
                {
                    { new Guid("b1018000-0000-0000-0000-000000000018"), new Guid("22222222-3333-4444-5555-667788990011"), new Guid("735d046e-9b1c-4a24-8f7c-53d0db69b1e5"), 14 },
                    { new Guid("b1019000-0000-0000-0000-000000000019"), new Guid("22222222-3333-4444-5555-667788990011"), new Guid("2f76c1e3-9b84-4d5a-902c-79163e92b8f4"), 14 },
                    { new Guid("b1020000-0000-0000-0000-000000000020"), new Guid("22222222-3333-4444-5555-667788990011"), new Guid("e94b3d21-6c8a-4f09-bc7e-51382d94b6a1"), 4 },
                    { new Guid("b1021000-0000-0000-0000-000000000021"), new Guid("22222222-3333-4444-5555-667788990011"), new Guid("c82f9e3d-1a5b-476c-90ef-823456789abc"), 5 },
                    { new Guid("b1022000-0000-0000-0000-000000000022"), new Guid("22222222-3333-4444-5555-667788990011"), new Guid("d93e0f21-8b7a-456c-ad3e-1234567890ab"), 4 },
                    { new Guid("b1023000-0000-0000-0000-000000000023"), new Guid("22222222-3333-4444-5555-667788990011"), new Guid("a1b2c3d4-e5f6-7890-abcd-ef1234567890"), 4 },
                    { new Guid("b1024000-0000-0000-0000-000000000024"), new Guid("22222222-3333-4444-5555-667788990011"), new Guid("b2c3d4e5-f6a7-8901-bcde-234567890abc"), 0 },
                    { new Guid("b1025000-0000-0000-0000-000000000025"), new Guid("22222222-3333-4444-5555-667788990011"), new Guid("c3d4e5f6-a7b8-9012-cdef-34567890abcd"), 0 },
                    { new Guid("b1026000-0000-0000-0000-000000000026"), new Guid("22222222-3333-4444-5555-667788990011"), new Guid("d4e5f6a7-b8c9-0123-abc1-4567890abcde"), 0 },
                    { new Guid("b1027000-0000-0000-0000-000000000027"), new Guid("22222222-3333-4444-5555-667788990011"), new Guid("e5f6a7b8-c9d0-1234-abc2-567890abcdef"), 0 },
                    { new Guid("b1028000-0000-0000-0000-000000000028"), new Guid("22222222-3333-4444-5555-667788990011"), new Guid("f6a7b8c9-d0e1-2345-abc3-67890abcdef1"), 0 },
                    { new Guid("b1029000-0000-0000-0000-000000000029"), new Guid("22222222-3333-4444-5555-667788990011"), new Guid("a7b8c9d0-e1f2-3456-abc4-7890abcdef12"), 0 },
                    { new Guid("b1030000-0000-0000-0000-000000000030"), new Guid("22222222-3333-4444-5555-667788990011"), new Guid("b8c9d0e1-f2a3-4567-abc5-890abcdef123"), 5 },
                    { new Guid("b1031000-0000-0000-0000-000000000031"), new Guid("22222222-3333-4444-5555-667788990011"), new Guid("c9d0e1f2-a3b4-5678-abc6-90abcdef1234"), 10 },
                    { new Guid("b1032000-0000-0000-0000-000000000032"), new Guid("22222222-3333-4444-5555-667788990011"), new Guid("d0e1f2a3-b4c5-6789-abc7-abcdef123456"), 1 },
                    { new Guid("b1033000-0000-0000-0000-000000000033"), new Guid("22222222-3333-4444-5555-667788990011"), new Guid("e1f2a3b4-c5d6-7890-abc8-bcdef1234567"), 1 },
                    { new Guid("b1034000-0000-0000-0000-000000000034"), new Guid("22222222-3333-4444-5555-667788990011"), new Guid("f2a3b4c5-d6e7-8901-abc9-cdef12345678"), 3 },
                    { new Guid("c1035000-0000-0000-0000-000000000035"), new Guid("33333333-4444-5555-6666-778899001122"), new Guid("735d046e-9b1c-4a24-8f7c-53d0db69b1e5"), 8 },
                    { new Guid("c1036000-0000-0000-0000-000000000036"), new Guid("33333333-4444-5555-6666-778899001122"), new Guid("2f76c1e3-9b84-4d5a-902c-79163e92b8f4"), 8 },
                    { new Guid("c1037000-0000-0000-0000-000000000037"), new Guid("33333333-4444-5555-6666-778899001122"), new Guid("e94b3d21-6c8a-4f09-bc7e-51382d94b6a1"), 3 },
                    { new Guid("c1038000-0000-0000-0000-000000000038"), new Guid("33333333-4444-5555-6666-778899001122"), new Guid("c82f9e3d-1a5b-476c-90ef-823456789abc"), 2 },
                    { new Guid("c1039000-0000-0000-0000-000000000039"), new Guid("33333333-4444-5555-6666-778899001122"), new Guid("d93e0f21-8b7a-456c-ad3e-1234567890ab"), 8 },
                    { new Guid("c1040000-0000-0000-0000-000000000040"), new Guid("33333333-4444-5555-6666-778899001122"), new Guid("a1b2c3d4-e5f6-7890-abcd-ef1234567890"), 6 },
                    { new Guid("c1041000-0000-0000-0000-000000000041"), new Guid("33333333-4444-5555-6666-778899001122"), new Guid("b2c3d4e5-f6a7-8901-bcde-234567890abc"), 3 },
                    { new Guid("c1042000-0000-0000-0000-000000000042"), new Guid("33333333-4444-5555-6666-778899001122"), new Guid("c3d4e5f6-a7b8-9012-cdef-34567890abcd"), 3 },
                    { new Guid("c1043000-0000-0000-0000-000000000043"), new Guid("33333333-4444-5555-6666-778899001122"), new Guid("d4e5f6a7-b8c9-0123-abc1-4567890abcde"), 0 },
                    { new Guid("c1044000-0000-0000-0000-000000000044"), new Guid("33333333-4444-5555-6666-778899001122"), new Guid("e5f6a7b8-c9d0-1234-abc2-567890abcdef"), 0 },
                    { new Guid("c1045000-0000-0000-0000-000000000045"), new Guid("33333333-4444-5555-6666-778899001122"), new Guid("f6a7b8c9-d0e1-2345-abc3-67890abcdef1"), 0 },
                    { new Guid("c1046000-0000-0000-0000-000000000046"), new Guid("33333333-4444-5555-6666-778899001122"), new Guid("a7b8c9d0-e1f2-3456-abc4-7890abcdef12"), 0 },
                    { new Guid("c1047000-0000-0000-0000-000000000047"), new Guid("33333333-4444-5555-6666-778899001122"), new Guid("b8c9d0e1-f2a3-4567-abc5-890abcdef123"), 5 },
                    { new Guid("c1048000-0000-0000-0000-000000000048"), new Guid("33333333-4444-5555-6666-778899001122"), new Guid("c9d0e1f2-a3b4-5678-abc6-90abcdef1234"), 10 },
                    { new Guid("c1049000-0000-0000-0000-000000000049"), new Guid("33333333-4444-5555-6666-778899001122"), new Guid("d0e1f2a3-b4c5-6789-abc7-abcdef123456"), 1 },
                    { new Guid("c1050000-0000-0000-0000-000000000050"), new Guid("33333333-4444-5555-6666-778899001122"), new Guid("e1f2a3b4-c5d6-7890-abc8-bcdef1234567"), 1 },
                    { new Guid("c1051000-0000-0000-0000-000000000051"), new Guid("33333333-4444-5555-6666-778899001122"), new Guid("f2a3b4c5-d6e7-8901-abc9-cdef12345678"), 3 },
                    { new Guid("f1001000-0000-0000-0000-000000000001"), new Guid("11111111-2222-3333-4444-556677889900"), new Guid("735d046e-9b1c-4a24-8f7c-53d0db69b1e5"), 20 },
                    { new Guid("f1002000-0000-0000-0000-000000000002"), new Guid("11111111-2222-3333-4444-556677889900"), new Guid("2f76c1e3-9b84-4d5a-902c-79163e92b8f4"), 20 },
                    { new Guid("f1003000-0000-0000-0000-000000000003"), new Guid("11111111-2222-3333-4444-556677889900"), new Guid("e94b3d21-6c8a-4f09-bc7e-51382d94b6a1"), 7 },
                    { new Guid("f1004000-0000-0000-0000-000000000004"), new Guid("11111111-2222-3333-4444-556677889900"), new Guid("c82f9e3d-1a5b-476c-90ef-823456789abc"), 9 },
                    { new Guid("f1005000-0000-0000-0000-000000000005"), new Guid("11111111-2222-3333-4444-556677889900"), new Guid("d93e0f21-8b7a-456c-ad3e-1234567890ab"), 2 },
                    { new Guid("f1006000-0000-0000-0000-000000000006"), new Guid("11111111-2222-3333-4444-556677889900"), new Guid("a1b2c3d4-e5f6-7890-abcd-ef1234567890"), 2 },
                    { new Guid("f1007000-0000-0000-0000-000000000007"), new Guid("11111111-2222-3333-4444-556677889900"), new Guid("b2c3d4e5-f6a7-8901-bcde-234567890abc"), 0 },
                    { new Guid("f1008000-0000-0000-0000-000000000008"), new Guid("11111111-2222-3333-4444-556677889900"), new Guid("c3d4e5f6-a7b8-9012-cdef-34567890abcd"), 0 },
                    { new Guid("f1009000-0000-0000-0000-000000000009"), new Guid("11111111-2222-3333-4444-556677889900"), new Guid("d4e5f6a7-b8c9-0123-abc1-4567890abcde"), 0 },
                    { new Guid("f1010000-0000-0000-0000-000000000010"), new Guid("11111111-2222-3333-4444-556677889900"), new Guid("e5f6a7b8-c9d0-1234-abc2-567890abcdef"), 0 },
                    { new Guid("f1011000-0000-0000-0000-000000000011"), new Guid("11111111-2222-3333-4444-556677889900"), new Guid("f6a7b8c9-d0e1-2345-abc3-67890abcdef1"), 0 },
                    { new Guid("f1012000-0000-0000-0000-000000000012"), new Guid("11111111-2222-3333-4444-556677889900"), new Guid("a7b8c9d0-e1f2-3456-abc4-7890abcdef12"), 0 },
                    { new Guid("f1013000-0000-0000-0000-000000000013"), new Guid("11111111-2222-3333-4444-556677889900"), new Guid("b8c9d0e1-f2a3-4567-abc5-890abcdef123"), 5 },
                    { new Guid("f1014000-0000-0000-0000-000000000014"), new Guid("11111111-2222-3333-4444-556677889900"), new Guid("c9d0e1f2-a3b4-5678-abc6-90abcdef1234"), 10 },
                    { new Guid("f1015000-0000-0000-0000-000000000015"), new Guid("11111111-2222-3333-4444-556677889900"), new Guid("d0e1f2a3-b4c5-6789-abc7-abcdef123456"), 1 },
                    { new Guid("f1016000-0000-0000-0000-000000000016"), new Guid("11111111-2222-3333-4444-556677889900"), new Guid("e1f2a3b4-c5d6-7890-abc8-bcdef1234567"), 1 },
                    { new Guid("f1017000-0000-0000-0000-000000000017"), new Guid("11111111-2222-3333-4444-556677889900"), new Guid("f2a3b4c5-d6e7-8901-abc9-cdef12345678"), 3 }
                });

            migrationBuilder.InsertData(
                table: "effect_affected_abilities",
                columns: new[] { "id", "action_id", "effect_id" },
                values: new object[,]
                {
                    { new Guid("a0001000-0000-0000-0000-000000000001"), new Guid("a1111111-2020-3030-4040-5060708090a1"), new Guid("30333333-4444-5555-6666-778899001123") },
                    { new Guid("a0003000-0000-0000-0000-000000000003"), new Guid("a1111111-2020-3030-4040-5060708090a2"), new Guid("30333333-4444-5555-6666-778899001123") },
                    { new Guid("a0005000-0000-0000-0000-000000000005"), new Guid("a1111111-2020-3030-4040-5060708090a3"), new Guid("30333333-4444-5555-6666-778899001123") },
                    { new Guid("a0007000-0000-0000-0000-000000000007"), new Guid("a1111111-2020-3030-4040-5060708090a6"), new Guid("30333333-4444-5555-6666-778899001123") },
                    { new Guid("a0009000-0000-0000-0000-000000000009"), new Guid("a1111111-2020-3030-4040-5060708090a9"), new Guid("30333333-4444-5555-6666-778899001123") }
                });

            migrationBuilder.InsertData(
                table: "effect_affected_stats",
                columns: new[] { "id", "effect_id", "stat_definition_id" },
                values: new object[,]
                {
                    { new Guid("e1001000-0000-0000-0000-000000000001"), new Guid("10111111-2222-3333-4444-556677889901"), new Guid("2f76c1e3-9b84-4d5a-902c-79163e92b8f4") },
                    { new Guid("e1002000-0000-0000-0000-000000000002"), new Guid("20222222-3333-4444-5555-667788990012"), new Guid("c82f9e3d-1a5b-476c-90ef-823456789abc") },
                    { new Guid("e1003000-0000-0000-0000-000000000003"), new Guid("40444444-5555-6666-7777-889900112234"), new Guid("735d046e-9b1c-4a24-8f7c-53d0db69b1e5") },
                    { new Guid("e1004000-0000-0000-0000-000000000004"), new Guid("50555555-6666-7777-8888-901122334456"), new Guid("2f76c1e3-9b84-4d5a-902c-79163e92b8f4") },
                    { new Guid("e1005000-0000-0000-0000-000000000005"), new Guid("60666666-7777-8888-9999-012233445567"), new Guid("e94b3d21-6c8a-4f09-bc7e-51382d94b6a1") },
                    { new Guid("e1006000-0000-0000-0000-000000000006"), new Guid("70777777-8888-9999-0000-123344556678"), new Guid("c82f9e3d-1a5b-476c-90ef-823456789abc") },
                    { new Guid("e1007000-0000-0000-0000-000000000007"), new Guid("80888888-9999-0000-1111-234455667789"), new Guid("d93e0f21-8b7a-456c-ad3e-1234567890ab") },
                    { new Guid("e1008000-0000-0000-0000-000000000008"), new Guid("90999999-0000-1111-2222-345566778890"), new Guid("a1b2c3d4-e5f6-7890-abcd-ef1234567890") },
                    { new Guid("e1009000-0000-0000-0000-000000000009"), new Guid("10101010-2020-3030-4040-5060708090a0"), new Guid("b2c3d4e5-f6a7-8901-bcde-234567890abc") },
                    { new Guid("e1010000-0000-0000-0000-000000000010"), new Guid("20202020-3030-4040-5050-60708090a0b1"), new Guid("c3d4e5f6-a7b8-9012-cdef-34567890abcd") },
                    { new Guid("e1011000-0000-0000-0000-000000000011"), new Guid("30303030-4040-5050-6060-708090a0b0c1"), new Guid("d4e5f6a7-b8c9-0123-abc1-4567890abcde") },
                    { new Guid("e1012000-0000-0000-0000-000000000012"), new Guid("40404040-5050-6060-7070-8090a0b0c0d1"), new Guid("e5f6a7b8-c9d0-1234-abc2-567890abcdef") },
                    { new Guid("e1013000-0000-0000-0000-000000000013"), new Guid("50505050-6060-7070-8080-90a0b0c0d0e1"), new Guid("f6a7b8c9-d0e1-2345-abc3-67890abcdef1") },
                    { new Guid("e1014000-0000-0000-0000-000000000014"), new Guid("60606060-7070-8080-9090-a0b0c0d0e0f1"), new Guid("a7b8c9d0-e1f2-3456-abc4-7890abcdef12") },
                    { new Guid("e1015000-0000-0000-0000-000000000015"), new Guid("70707070-8080-9090-a0a0-b0c0d0e0f123"), new Guid("b8c9d0e1-f2a3-4567-abc5-890abcdef123") },
                    { new Guid("e1016000-0000-0000-0000-000000000016"), new Guid("80808080-9090-a0a0-b0b0-c0d0e0f12345"), new Guid("c9d0e1f2-a3b4-5678-abc6-90abcdef1234") },
                    { new Guid("e1017000-0000-0000-0000-000000000017"), new Guid("90909090-a0a0-b0b0-c0c0-d0e0f1234567"), new Guid("d0e1f2a3-b4c5-6789-abc7-abcdef123456") },
                    { new Guid("e1018000-0000-0000-0000-000000000018"), new Guid("a0a0a0a0-b0b0-c0c0-d0d0-e0f123456789"), new Guid("e1f2a3b4-c5d6-7890-abc8-bcdef1234567") },
                    { new Guid("e1019000-0000-0000-0000-000000000019"), new Guid("b0b0b0b0-c0c0-d0d0-e0e0-f1234567890a"), new Guid("f2a3b4c5-d6e7-8901-abc9-cdef12345678") }
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
