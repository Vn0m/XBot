﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Magic;

namespace GLib
{
    public class Descriptors
    {
        private BlackMagic wow { get; set; }

        public Descriptors(BlackMagic _mem)
        {
            this.wow = _mem;
        }

        public T GetKnownField<T>(Descriptors.WoWContainerFields field, uint obj) where T : struct
        {
            return (T)wow.ReadObject(wow.ReadUInt(obj + 0x08) + (uint)field * 4, typeof(T));
        }

        public T GetKnownField<T>(Descriptors.WoWCorpseFields field, uint obj) where T : struct
        {
            return (T)wow.ReadObject(wow.ReadUInt(obj + 0x08) + (uint)field * 4, typeof(T));
        }

        public T GetKnownField<T>(Descriptors.WoWDynamicObjectFields field, uint obj) where T : struct
        {
            return (T)wow.ReadObject(wow.ReadUInt(obj + 0x08) + (uint)field * 4, typeof(T));
        }

        public T GetKnownField<T>(Descriptors.WoWGameObjectFields field, uint obj) where T : struct
        {
            return (T)wow.ReadObject(wow.ReadUInt(obj + 0x08) + (uint)field * 4, typeof(T));
        }

        public T GetKnownField<T>(Descriptors.WoWItemFields field, uint obj) where T : struct
        {
            return (T)wow.ReadObject(wow.ReadUInt(obj + 0x08) + (uint)field * 4, typeof(T));
        }

        public T GetKnownField<T>(Descriptors.WoWPlayerFields field, uint obj) where T : struct
        {
            return (T)wow.ReadObject(wow.ReadUInt(obj + 0x08) + (uint)field * 4, typeof(T));
        }

        public T GetKnownField<T>(Descriptors.WoWUnitFields field, uint obj) where T : struct
        {
            return (T)wow.ReadObject(wow.ReadUInt(obj + 0x08) + (uint)field * 4, typeof(T));
        }

        public void setKnownField(Descriptors.WoWUnitFields field,uint obj,uint value) 
        {
            wow.WriteUInt(wow.ReadUInt(obj + 0x08) + (uint)field * 4,value);
        }

        // Descriptors: 0x00AD9F58
       public enum WoWObjectFields
        {
            OBJECT_FIELD_GUID = 0x0,
            OBJECT_FIELD_TYPE = 0x2,
            OBJECT_FIELD_ENTRY = 0x3,
            OBJECT_FIELD_SCALE_X = 0x4,
            OBJECT_FIELD_PADDING = 0x5,
            //TOTAL_OBJECT_FIELDS = 0x5
        };
        // Descriptors: 0x00AD9FF8
        public enum WoWItemFields
        {
            ITEM_FIELD_OWNER = 0x6,
            ITEM_FIELD_CONTAINED = 0x8,
            ITEM_FIELD_CREATOR = 0xA,
            ITEM_FIELD_GIFTCREATOR = 0xC,
            ITEM_FIELD_STACK_COUNT = 0xE,
            ITEM_FIELD_DURATION = 0xF,
            ITEM_FIELD_SPELL_CHARGES = 0x10,
            ITEM_FIELD_FLAGS = 0x15,
            ITEM_FIELD_ENCHANTMENT_1_1 = 0x16,
            ITEM_FIELD_ENCHANTMENT_1_3 = 0x18,
            ITEM_FIELD_ENCHANTMENT_2_1 = 0x19,
            ITEM_FIELD_ENCHANTMENT_2_3 = 0x1B,
            ITEM_FIELD_ENCHANTMENT_3_1 = 0x1C,
            ITEM_FIELD_ENCHANTMENT_3_3 = 0x1E,
            ITEM_FIELD_ENCHANTMENT_4_1 = 0x1F,
            ITEM_FIELD_ENCHANTMENT_4_3 = 0x21,
            ITEM_FIELD_ENCHANTMENT_5_1 = 0x22,
            ITEM_FIELD_ENCHANTMENT_5_3 = 0x24,
            ITEM_FIELD_ENCHANTMENT_6_1 = 0x25,
            ITEM_FIELD_ENCHANTMENT_6_3 = 0x27,
            ITEM_FIELD_ENCHANTMENT_7_1 = 0x28,
            ITEM_FIELD_ENCHANTMENT_7_3 = 0x2A,
            ITEM_FIELD_ENCHANTMENT_8_1 = 0x2B,
            ITEM_FIELD_ENCHANTMENT_8_3 = 0x2D,
            ITEM_FIELD_ENCHANTMENT_9_1 = 0x2E,
            ITEM_FIELD_ENCHANTMENT_9_3 = 0x30,
            ITEM_FIELD_ENCHANTMENT_10_1 = 0x31,
            ITEM_FIELD_ENCHANTMENT_10_3 = 0x33,
            ITEM_FIELD_ENCHANTMENT_11_1 = 0x34,
            ITEM_FIELD_ENCHANTMENT_11_3 = 0x36,
            ITEM_FIELD_ENCHANTMENT_12_1 = 0x37,
            ITEM_FIELD_ENCHANTMENT_12_3 = 0x39,
            ITEM_FIELD_PROPERTY_SEED = 0x3A,
            ITEM_FIELD_RANDOM_PROPERTIES_ID = 0x3B,
            ITEM_FIELD_DURABILITY = 0x3C,
            ITEM_FIELD_MAXDURABILITY = 0x3D,
            ITEM_FIELD_CREATE_PLAYED_TIME = 0x3E,
            ITEM_FIELD_PAD = 0x3F,
            //TOTAL_ITEM_FIELDS = 0x26
        };
        // Descriptors: 0x00AD9FBC
       public  enum WoWContainerFields
        {
            CONTAINER_FIELD_NUM_SLOTS = 0x6,
            CONTAINER_ALIGN_PAD = 0x7,
            CONTAINER_FIELD_SLOT_1 = 0x8,
            //TOTAL_CONTAINER_FIELDS = 0x3
        };
        // Descriptors: 0x00ADBAB8
        public enum WoWGameObjectFields
        {
            OBJECT_FIELD_CREATED_BY = 0x6,
            GAMEOBJECT_DISPLAYID = 0x8,
            GAMEOBJECT_FLAGS = 0x9,
            GAMEOBJECT_PARENTROTATION = 0xA,
            GAMEOBJECT_DYNAMIC = 0xE,
            GAMEOBJECT_FACTION = 0xF,
            GAMEOBJECT_LEVEL = 0x10,
            GAMEOBJECT_BYTES_1 = 0x11,
            //TOTAL_GAMEOBJECT_FIELDS = 0x8
        };
        // Descriptors: 0x00ADBB58
        public enum WoWDynamicObjectFields
        {
            DYNAMICOBJECT_CASTER = 0x6,
            DYNAMICOBJECT_BYTES = 0x8,
            DYNAMICOBJECT_SPELLID = 0x9,
            DYNAMICOBJECT_RADIUS = 0xA,
            DYNAMICOBJECT_CASTTIME = 0xB,
            //TOTAL_DYNAMICOBJECT_FIELDS = 0x5
        };
        // Descriptors: 0x00ADBBC0
        public enum WoWCorpseFields
        {
            CORPSE_FIELD_OWNER = 0x6,
            CORPSE_FIELD_PARTY = 0x8,
            CORPSE_FIELD_DISPLAY_ID = 0xA,
            CORPSE_FIELD_ITEM = 0xB,
            CORPSE_FIELD_BYTES_1 = 0x1E,
            CORPSE_FIELD_BYTES_2 = 0x1F,
            CORPSE_FIELD_GUILD = 0x20,
            CORPSE_FIELD_FLAGS = 0x21,
            CORPSE_FIELD_DYNAMIC_FLAGS = 0x22,
            CORPSE_FIELD_PAD = 0x23,
            //TOTAL_CORPSE_FIELDS = 0xA
        };
        // Descriptors: 0x00ADA2F0
        public enum WoWUnitFields
        {
            UNIT_FIELD_CHARM = 0x6,
            UNIT_FIELD_SUMMON = 0x8,
            UNIT_FIELD_CRITTER = 0xA,
            UNIT_FIELD_CHARMEDBY = 0xC,
            UNIT_FIELD_SUMMONEDBY = 0xE,
            UNIT_FIELD_CREATEDBY = 0x10,
            UNIT_FIELD_TARGET = 0x12,
            UNIT_FIELD_CHANNEL_OBJECT = 0x14,
            UNIT_CHANNEL_SPELL = 0x16,
            UNIT_FIELD_BYTES_0 = 0x17,
            UNIT_FIELD_HEALTH = 0x18,
            UNIT_FIELD_POWER1 = 0x19,
            UNIT_FIELD_POWER2 = 0x1A,
            UNIT_FIELD_POWER3 = 0x1B,
            UNIT_FIELD_POWER4 = 0x1C,
            UNIT_FIELD_POWER5 = 0x1D,
            UNIT_FIELD_POWER6 = 0x1E,
            UNIT_FIELD_POWER7 = 0x1F,
            UNIT_FIELD_MAXHEALTH = 0x20,
            UNIT_FIELD_MAXPOWER1 = 0x21,
            UNIT_FIELD_MAXPOWER2 = 0x22,
            UNIT_FIELD_MAXPOWER3 = 0x23,
            UNIT_FIELD_MAXPOWER4 = 0x24,
            UNIT_FIELD_MAXPOWER5 = 0x25,
            UNIT_FIELD_MAXPOWER6 = 0x26,
            UNIT_FIELD_MAXPOWER7 = 0x27,
            UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER = 0x28,
            UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER = 0x2F,
            UNIT_FIELD_LEVEL = 0x36,
            UNIT_FIELD_FACTIONTEMPLATE = 0x37,
            UNIT_VIRTUAL_ITEM_SLOT_ID = 0x38,
            UNIT_FIELD_FLAGS = 0x3B,
            UNIT_FIELD_FLAGS_2 = 0x3C,
            UNIT_FIELD_AURASTATE = 0x3D,
            UNIT_FIELD_BASEATTACKTIME = 0x3E,
            UNIT_FIELD_RANGEDATTACKTIME = 0x40,
            UNIT_FIELD_BOUNDINGRADIUS = 0x41,
            UNIT_FIELD_COMBATREACH = 0x42,
            UNIT_FIELD_DISPLAYID = 0x43,
            UNIT_FIELD_NATIVEDISPLAYID = 0x44,
            UNIT_FIELD_MOUNTDISPLAYID = 0x45,
            UNIT_FIELD_MINDAMAGE = 0x46,
            UNIT_FIELD_MAXDAMAGE = 0x47,
            UNIT_FIELD_MINOFFHANDDAMAGE = 0x48,
            UNIT_FIELD_MAXOFFHANDDAMAGE = 0x49,
            UNIT_FIELD_BYTES_1 = 0x4A,
            UNIT_FIELD_PETNUMBER = 0x4B,
            UNIT_FIELD_PET_NAME_TIMESTAMP = 0x4C,
            UNIT_FIELD_PETEXPERIENCE = 0x4D,
            UNIT_FIELD_PETNEXTLEVELEXP = 0x4E,
            UNIT_DYNAMIC_FLAGS = 0x4F,
            UNIT_MOD_CAST_SPEED = 0x50,
            UNIT_CREATED_BY_SPELL = 0x51,
            UNIT_NPC_FLAGS = 0x52,
            UNIT_NPC_EMOTESTATE = 0x53,
            UNIT_FIELD_STAT0 = 0x54,
            UNIT_FIELD_STAT1 = 0x55,
            UNIT_FIELD_STAT2 = 0x56,
            UNIT_FIELD_STAT3 = 0x57,
            UNIT_FIELD_STAT4 = 0x58,
            UNIT_FIELD_POSSTAT0 = 0x59,
            UNIT_FIELD_POSSTAT1 = 0x5A,
            UNIT_FIELD_POSSTAT2 = 0x5B,
            UNIT_FIELD_POSSTAT3 = 0x5C,
            UNIT_FIELD_POSSTAT4 = 0x5D,
            UNIT_FIELD_NEGSTAT0 = 0x5E,
            UNIT_FIELD_NEGSTAT1 = 0x5F,
            UNIT_FIELD_NEGSTAT2 = 0x60,
            UNIT_FIELD_NEGSTAT3 = 0x61,
            UNIT_FIELD_NEGSTAT4 = 0x62,
            UNIT_FIELD_RESISTANCES = 0x63,
            UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE = 0x6A,
            UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE = 0x71,
            UNIT_FIELD_BASE_MANA = 0x78,
            UNIT_FIELD_BASE_HEALTH = 0x79,
            UNIT_FIELD_BYTES_2 = 0x7A,
            UNIT_FIELD_ATTACK_POWER = 0x7B,
            UNIT_FIELD_ATTACK_POWER_MODS = 0x7C,
            UNIT_FIELD_ATTACK_POWER_MULTIPLIER = 0x7D,
            UNIT_FIELD_RANGED_ATTACK_POWER = 0x7E,
            UNIT_FIELD_RANGED_ATTACK_POWER_MODS = 0x7F,
            UNIT_FIELD_RANGED_ATTACK_POWER_MULTIPLIER = 0x80,
            UNIT_FIELD_MINRANGEDDAMAGE = 0x81,
            UNIT_FIELD_MAXRANGEDDAMAGE = 0x82,
            UNIT_FIELD_POWER_COST_MODIFIER = 0x83,
            UNIT_FIELD_POWER_COST_MULTIPLIER = 0x8A,
            UNIT_FIELD_MAXHEALTHMODIFIER = 0x91,
            UNIT_FIELD_HOVERHEIGHT = 0x92,
            UNIT_FIELD_PADDING = 0x93,
            //TOTAL_UNIT_FIELDS = 0x59
        };
        // Descriptors: 0x00ADA9E8
        public enum WoWPlayerFields
        {
            PLAYER_DUEL_ARBITER = 0x94,
            PLAYER_FLAGS = 0x96,
            PLAYER_GUILDID = 0x97,
            PLAYER_GUILDRANK = 0x98,
            PLAYER_BYTES = 0x99,
            PLAYER_BYTES_2 = 0x9A,
            PLAYER_BYTES_3 = 0x9B,
            PLAYER_DUEL_TEAM = 0x9C,
            PLAYER_GUILD_TIMESTAMP = 0x9D,
            PLAYER_QUEST_LOG_1_1 = 0x9E,
            PLAYER_QUEST_LOG_1_2 = 0x9F,
            PLAYER_QUEST_LOG_1_3 = 0xA0,
            PLAYER_QUEST_LOG_1_4 = 0xA2,
            PLAYER_QUEST_LOG_2_1 = 0xA3,
            PLAYER_QUEST_LOG_2_2 = 0xA4,
            PLAYER_QUEST_LOG_2_3 = 0xA5,
            PLAYER_QUEST_LOG_2_5 = 0xA7,
            PLAYER_QUEST_LOG_3_1 = 0xA8,
            PLAYER_QUEST_LOG_3_2 = 0xA9,
            PLAYER_QUEST_LOG_3_3 = 0xAA,
            PLAYER_QUEST_LOG_3_5 = 0xAC,
            PLAYER_QUEST_LOG_4_1 = 0xAD,
            PLAYER_QUEST_LOG_4_2 = 0xAE,
            PLAYER_QUEST_LOG_4_3 = 0xAF,
            PLAYER_QUEST_LOG_4_5 = 0xB1,
            PLAYER_QUEST_LOG_5_1 = 0xB2,
            PLAYER_QUEST_LOG_5_2 = 0xB3,
            PLAYER_QUEST_LOG_5_3 = 0xB4,
            PLAYER_QUEST_LOG_5_5 = 0xB6,
            PLAYER_QUEST_LOG_6_1 = 0xB7,
            PLAYER_QUEST_LOG_6_2 = 0xB8,
            PLAYER_QUEST_LOG_6_3 = 0xB9,
            PLAYER_QUEST_LOG_6_5 = 0xBB,
            PLAYER_QUEST_LOG_7_1 = 0xBC,
            PLAYER_QUEST_LOG_7_2 = 0xBD,
            PLAYER_QUEST_LOG_7_3 = 0xBE,
            PLAYER_QUEST_LOG_7_5 = 0xC0,
            PLAYER_QUEST_LOG_8_1 = 0xC1,
            PLAYER_QUEST_LOG_8_2 = 0xC2,
            PLAYER_QUEST_LOG_8_3 = 0xC3,
            PLAYER_QUEST_LOG_8_5 = 0xC5,
            PLAYER_QUEST_LOG_9_1 = 0xC6,
            PLAYER_QUEST_LOG_9_2 = 0xC7,
            PLAYER_QUEST_LOG_9_3 = 0xC8,
            PLAYER_QUEST_LOG_9_5 = 0xCA,
            PLAYER_QUEST_LOG_10_1 = 0xCB,
            PLAYER_QUEST_LOG_10_2 = 0xCC,
            PLAYER_QUEST_LOG_10_3 = 0xCD,
            PLAYER_QUEST_LOG_10_5 = 0xCF,
            PLAYER_QUEST_LOG_11_1 = 0xD0,
            PLAYER_QUEST_LOG_11_2 = 0xD1,
            PLAYER_QUEST_LOG_11_3 = 0xD2,
            PLAYER_QUEST_LOG_11_5 = 0xD4,
            PLAYER_QUEST_LOG_12_1 = 0xD5,
            PLAYER_QUEST_LOG_12_2 = 0xD6,
            PLAYER_QUEST_LOG_12_3 = 0xD7,
            PLAYER_QUEST_LOG_12_5 = 0xD9,
            PLAYER_QUEST_LOG_13_1 = 0xDA,
            PLAYER_QUEST_LOG_13_2 = 0xDB,
            PLAYER_QUEST_LOG_13_3 = 0xDC,
            PLAYER_QUEST_LOG_13_5 = 0xDE,
            PLAYER_QUEST_LOG_14_1 = 0xDF,
            PLAYER_QUEST_LOG_14_2 = 0xE0,
            PLAYER_QUEST_LOG_14_3 = 0xE1,
            PLAYER_QUEST_LOG_14_5 = 0xE3,
            PLAYER_QUEST_LOG_15_1 = 0xE4,
            PLAYER_QUEST_LOG_15_2 = 0xE5,
            PLAYER_QUEST_LOG_15_3 = 0xE6,
            PLAYER_QUEST_LOG_15_5 = 0xE8,
            PLAYER_QUEST_LOG_16_1 = 0xE9,
            PLAYER_QUEST_LOG_16_2 = 0xEA,
            PLAYER_QUEST_LOG_16_3 = 0xEB,
            PLAYER_QUEST_LOG_16_5 = 0xED,
            PLAYER_QUEST_LOG_17_1 = 0xEE,
            PLAYER_QUEST_LOG_17_2 = 0xEF,
            PLAYER_QUEST_LOG_17_3 = 0xF0,
            PLAYER_QUEST_LOG_17_5 = 0xF2,
            PLAYER_QUEST_LOG_18_1 = 0xF3,
            PLAYER_QUEST_LOG_18_2 = 0xF4,
            PLAYER_QUEST_LOG_18_3 = 0xF5,
            PLAYER_QUEST_LOG_18_5 = 0xF7,
            PLAYER_QUEST_LOG_19_1 = 0xF8,
            PLAYER_QUEST_LOG_19_2 = 0xF9,
            PLAYER_QUEST_LOG_19_3 = 0xFA,
            PLAYER_QUEST_LOG_19_5 = 0xFC,
            PLAYER_QUEST_LOG_20_1 = 0xFD,
            PLAYER_QUEST_LOG_20_2 = 0xFE,
            PLAYER_QUEST_LOG_20_3 = 0xFF,
            PLAYER_QUEST_LOG_20_5 = 0x101,
            PLAYER_QUEST_LOG_21_1 = 0x102,
            PLAYER_QUEST_LOG_21_2 = 0x103,
            PLAYER_QUEST_LOG_21_3 = 0x104,
            PLAYER_QUEST_LOG_21_5 = 0x106,
            PLAYER_QUEST_LOG_22_1 = 0x107,
            PLAYER_QUEST_LOG_22_2 = 0x108,
            PLAYER_QUEST_LOG_22_3 = 0x109,
            PLAYER_QUEST_LOG_22_5 = 0x10B,
            PLAYER_QUEST_LOG_23_1 = 0x10C,
            PLAYER_QUEST_LOG_23_2 = 0x10D,
            PLAYER_QUEST_LOG_23_3 = 0x10E,
            PLAYER_QUEST_LOG_23_5 = 0x110,
            PLAYER_QUEST_LOG_24_1 = 0x111,
            PLAYER_QUEST_LOG_24_2 = 0x112,
            PLAYER_QUEST_LOG_24_3 = 0x113,
            PLAYER_QUEST_LOG_24_5 = 0x115,
            PLAYER_QUEST_LOG_25_1 = 0x116,
            PLAYER_QUEST_LOG_25_2 = 0x117,
            PLAYER_QUEST_LOG_25_3 = 0x118,
            PLAYER_QUEST_LOG_25_5 = 0x11A,
            PLAYER_VISIBLE_ITEM_1_ENTRYID = 0x11B,
            PLAYER_VISIBLE_ITEM_1_ENCHANTMENT = 0x11C,
            PLAYER_VISIBLE_ITEM_2_ENTRYID = 0x11D,
            PLAYER_VISIBLE_ITEM_2_ENCHANTMENT = 0x11E,
            PLAYER_VISIBLE_ITEM_3_ENTRYID = 0x11F,
            PLAYER_VISIBLE_ITEM_3_ENCHANTMENT = 0x120,
            PLAYER_VISIBLE_ITEM_4_ENTRYID = 0x121,
            PLAYER_VISIBLE_ITEM_4_ENCHANTMENT = 0x122,
            PLAYER_VISIBLE_ITEM_5_ENTRYID = 0x123,
            PLAYER_VISIBLE_ITEM_5_ENCHANTMENT = 0x124,
            PLAYER_VISIBLE_ITEM_6_ENTRYID = 0x125,
            PLAYER_VISIBLE_ITEM_6_ENCHANTMENT = 0x126,
            PLAYER_VISIBLE_ITEM_7_ENTRYID = 0x127,
            PLAYER_VISIBLE_ITEM_7_ENCHANTMENT = 0x128,
            PLAYER_VISIBLE_ITEM_8_ENTRYID = 0x129,
            PLAYER_VISIBLE_ITEM_8_ENCHANTMENT = 0x12A,
            PLAYER_VISIBLE_ITEM_9_ENTRYID = 0x12B,
            PLAYER_VISIBLE_ITEM_9_ENCHANTMENT = 0x12C,
            PLAYER_VISIBLE_ITEM_10_ENTRYID = 0x12D,
            PLAYER_VISIBLE_ITEM_10_ENCHANTMENT = 0x12E,
            PLAYER_VISIBLE_ITEM_11_ENTRYID = 0x12F,
            PLAYER_VISIBLE_ITEM_11_ENCHANTMENT = 0x130,
            PLAYER_VISIBLE_ITEM_12_ENTRYID = 0x131,
            PLAYER_VISIBLE_ITEM_12_ENCHANTMENT = 0x132,
            PLAYER_VISIBLE_ITEM_13_ENTRYID = 0x133,
            PLAYER_VISIBLE_ITEM_13_ENCHANTMENT = 0x134,
            PLAYER_VISIBLE_ITEM_14_ENTRYID = 0x135,
            PLAYER_VISIBLE_ITEM_14_ENCHANTMENT = 0x136,
            PLAYER_VISIBLE_ITEM_15_ENTRYID = 0x137,
            PLAYER_VISIBLE_ITEM_15_ENCHANTMENT = 0x138,
            PLAYER_VISIBLE_ITEM_16_ENTRYID = 0x139,
            PLAYER_VISIBLE_ITEM_16_ENCHANTMENT = 0x13A,
            PLAYER_VISIBLE_ITEM_17_ENTRYID = 0x13B,
            PLAYER_VISIBLE_ITEM_17_ENCHANTMENT = 0x13C,
            PLAYER_VISIBLE_ITEM_18_ENTRYID = 0x13D,
            PLAYER_VISIBLE_ITEM_18_ENCHANTMENT = 0x13E,
            PLAYER_VISIBLE_ITEM_19_ENTRYID = 0x13F,
            PLAYER_VISIBLE_ITEM_19_ENCHANTMENT = 0x140,
            PLAYER_CHOSEN_TITLE = 0x141,
            PLAYER_FAKE_INEBRIATION = 0x142,
            PLAYER_FIELD_PAD_0 = 0x143,
            PLAYER_FIELD_INV_SLOT_HEAD = 0x144,
            PLAYER_FIELD_PACK_SLOT_1 = 0x172,
            PLAYER_FIELD_BANK_SLOT_1 = 0x192,
            PLAYER_FIELD_BANKBAG_SLOT_1 = 0x1CA,
            PLAYER_FIELD_VENDORBUYBACK_SLOT_1 = 0x1D8,
            PLAYER_FIELD_KEYRING_SLOT_1 = 0x1F0,
            PLAYER_FIELD_CURRENCYTOKEN_SLOT_1 = 0x230,
            PLAYER_FARSIGHT = 0x270,
            PLAYER__FIELD_KNOWN_TITLES = 0x272,
            PLAYER__FIELD_KNOWN_TITLES1 = 0x274,
            PLAYER__FIELD_KNOWN_TITLES2 = 0x276,
            PLAYER_FIELD_KNOWN_CURRENCIES = 0x278,
            PLAYER_XP = 0x27A,
            PLAYER_NEXT_LEVEL_XP = 0x27B,
            PLAYER_SKILL_INFO_1_1 = 0x27C,
            PLAYER_CHARACTER_POINTS1 = 0x3FC,
            PLAYER_CHARACTER_POINTS2 = 0x3FD,
            PLAYER_TRACK_CREATURES = 0x3FE,
            PLAYER_TRACK_RESOURCES = 0x3FF,
            PLAYER_BLOCK_PERCENTAGE = 0x400,
            PLAYER_DODGE_PERCENTAGE = 0x401,
            PLAYER_PARRY_PERCENTAGE = 0x402,
            PLAYER_EXPERTISE = 0x403,
            PLAYER_OFFHAND_EXPERTISE = 0x404,
            PLAYER_CRIT_PERCENTAGE = 0x405,
            PLAYER_RANGED_CRIT_PERCENTAGE = 0x406,
            PLAYER_OFFHAND_CRIT_PERCENTAGE = 0x407,
            PLAYER_SPELL_CRIT_PERCENTAGE1 = 0x408,
            PLAYER_SHIELD_BLOCK = 0x40F,
            PLAYER_SHIELD_BLOCK_CRIT_PERCENTAGE = 0x410,
            PLAYER_EXPLORED_ZONES_1 = 0x411,
            PLAYER_REST_STATE_EXPERIENCE = 0x491,
            PLAYER_FIELD_COINAGE = 0x492,
            PLAYER_FIELD_MOD_DAMAGE_DONE_POS = 0x493,
            PLAYER_FIELD_MOD_DAMAGE_DONE_NEG = 0x49A,
            PLAYER_FIELD_MOD_DAMAGE_DONE_PCT = 0x4A1,
            PLAYER_FIELD_MOD_HEALING_DONE_POS = 0x4A8,
            PLAYER_FIELD_MOD_HEALING_PCT = 0x4A9,
            PLAYER_FIELD_MOD_HEALING_DONE_PCT = 0x4AA,
            PLAYER_FIELD_MOD_TARGET_RESISTANCE = 0x4AB,
            PLAYER_FIELD_MOD_TARGET_PHYSICAL_RESISTANCE = 0x4AC,
            PLAYER_FIELD_BYTES = 0x4AD,
            PLAYER_AMMO_ID = 0x4AE,
            PLAYER_SELF_RES_SPELL = 0x4AF,
            PLAYER_FIELD_PVP_MEDALS = 0x4B0,
            PLAYER_FIELD_BUYBACK_PRICE_1 = 0x4B1,
            PLAYER_FIELD_BUYBACK_TIMESTAMP_1 = 0x4BD,
            PLAYER_FIELD_KILLS = 0x4C9,
            PLAYER_FIELD_TODAY_CONTRIBUTION = 0x4CA,
            PLAYER_FIELD_YESTERDAY_CONTRIBUTION = 0x4CB,
            PLAYER_FIELD_LIFETIME_HONORBALE_KILLS = 0x4CC,
            PLAYER_FIELD_BYTES2 = 0x4CD,
            PLAYER_FIELD_WATCHED_FACTION_INDEX = 0x4CE,
            PLAYER_FIELD_COMBAT_RATING_1 = 0x4CF,
            PLAYER_FIELD_ARENA_TEAM_INFO_1_1 = 0x4E8,
            PLAYER_FIELD_HONOR_CURRENCY = 0x4FD,
            PLAYER_FIELD_ARENA_CURRENCY = 0x4FE,
            PLAYER_FIELD_MAX_LEVEL = 0x4FF,
            PLAYER_FIELD_DAILY_QUESTS_1 = 0x500,
            PLAYER_RUNE_REGEN_1 = 0x519,
            PLAYER_NO_REAGENT_COST_1 = 0x51D,
            PLAYER_FIELD_GLYPH_SLOTS_1 = 0x520,
            PLAYER_FIELD_GLYPHS_1 = 0x526,
            PLAYER_GLYPHS_ENABLED = 0x52C,
            PLAYER_PET_SPELL_POWER = 0x52D,
            //TOTAL_PLAYER_FIELDS = 0xD7
        };


    }

}
