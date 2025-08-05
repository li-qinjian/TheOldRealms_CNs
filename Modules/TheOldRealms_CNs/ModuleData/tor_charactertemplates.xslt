﻿<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <!-- 配置输出格式 -->
    <xsl:output method="xml" indent="yes" encoding="UTF-8"/>
    <xsl:strip-space elements="*"/>
    <!-- 移除源文档中的多余空白 -->

    <!-- 身份转换模板 -->
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

    <!-- 替换特定ID的NPCCharacter节点 -->
    <xsl:template match="NPCCharacter[@id='tor_wanderer_empire_5']">
        <NPCCharacter id="tor_wanderer_empire_5" default_group="cavalry" occupation="Wanderer" culture="Culture.empire" voice="curt" age="28" is_template="true" is_hero="false">
            <xsl:attribute name="name">
                <xsl:text>{=str_tor_wanderer_empire_5}{FIRSTNAME} the Engineer</xsl:text>
            </xsl:attribute>
            <face>
                <face_key_template value="BodyProperty.fighter_empire" />
                <hair_tags>
                    <hair_tag name="ShortAndThin" />
                </hair_tags>
                <beard_tags>
                    <beard_tag name="LongScragglyBeard" />
                </beard_tags>
            </face>
            <Traits>
                <Trait id="HopliteFightingSkills" value="2" />
                <!-- <Trait id="Manager" value="6" /> -->
                <Trait id="EngineerSkills" value="12" />
                <Trait id="Blacksmith" value="1" />
                <Trait id="Calculating" value="1" />
                <Trait id="Mercy" value="1" />
                <Trait id="Valor" value="1" />
                <Trait id="Gunner" value="5" />
            </Traits>
            <Equipments>
                <EquipmentSet id="tor_engineer_companion_template" />
                <EquipmentSet id="tor_engineer_companion_template" civilian="true" />
            </Equipments>
        </NPCCharacter>
    </xsl:template>
    
    <xsl:template match="NPCCharacter[@id='tor_wanderer_empire_6']">
        <NPCCharacter id="tor_wanderer_empire_6" default_group="cavalry" occupation="Wanderer" culture="Culture.empire" voice="curt" age="21" is_female="true" is_template="true" is_hero="false">
            <xsl:attribute name="name">
                <xsl:text>{=str_tor_wanderer_empire_6}{FIRSTNAME} the Priestess of Shallya</xsl:text>
            </xsl:attribute>
            <face>
                <BodyProperties version="4" age="22.24" weight="0.2002" build="0.1082"  key="0000EC03521430047E8994576364769494E588557BB77E117E774CB6879A116701B236130B47521000000000000000000000000000000000000000007F7C4003"  />
            </face>
            <skills>
                <skill
                    id="OneHanded"
                    value="50" />
            </skills>
            <Traits>
                <Trait id="ArcherFIghtingSkills" value="2" />
                <Trait id="Surgeon" value="12" />
                <Trait id="Calculating" value="1" />
                <Trait id="Mercy" value="5" />
                <Trait id="Valor" value="7" />
                <Trait id="ShallyaDevoted" value="1" />
            </Traits>
            <Equipments>
                <EquipmentSet id="tor_priestess_of_shallya_template" />
                <EquipmentSet id="tor_priestess_of_shallya_template" civilian="true" />
            </Equipments>
        </NPCCharacter>
    </xsl:template>
    
    <xsl:template match="NPCCharacter[@id='tor_wanderer_bretonnia_0']">
        <NPCCharacter id="tor_wanderer_bretonnia_0" default_group="cavalry" occupation="Wanderer" culture="Culture.vlandia" voice="curt" age="30" is_template="true" is_hero="false">
            <xsl:attribute name="name">
                <xsl:text>{=str_tor_wanderer_bretonnia_0}{FIRSTNAME} the Bretonnian Knight</xsl:text>
            </xsl:attribute>
            <face>
                <face_key_template value="BodyProperty.fighter_vlandia" />
                <hair_tags>
                    <hair_tag name="ShortAndThin" />
                </hair_tags>
                <beard_tags>
                    <beard_tag name="Cleanshaven" />
                </beard_tags>
            </face>
            <Traits>
                <Trait id="KnightFightingSkills" value="8" />
                <Trait id="Commander" value="5" />
                <Trait id="Calculating" value="5" />
                <Trait id="Mercy" value="1" />
                <Trait id="Valor" value="1" />
            </Traits>
            <Equipments>
                <EquipmentSet id="tor_bretonnian_knight_template" />
                <EquipmentSet id="npc_companion_equipment_template_vlandia" civilian="true" />
            </Equipments>
        </NPCCharacter>
    </xsl:template>

    <xsl:template match="NPCCharacter[@id='tor_wanderer_bretonnia_1']">
        <NPCCharacter id="tor_wanderer_bretonnia_1" default_group="cavalry" occupation="Wanderer" culture="Culture.vlandia" voice="curt" age="20" is_female="true" is_template="true" is_hero="false">
            <xsl:attribute name="name">
                <xsl:text>{=str_tor_wanderer_bretonnia_1}{FIRSTNAME} the Damsel of the Lady</xsl:text>
            </xsl:attribute>
            <face>
                <BodyProperties version="4" age="22.42" weight="0.0262" build="0.0386" key="00006807104410036436583353C5743893B76C7627786754569AB47979575AE801E776130E7A225F00000000000000000000000000000000000000001DDC1083" />
            </face>
            <skills>
                <skill
                    id="OneHanded"
                    value="75" />
                <skill
                    id="Trade"
                    value="25" />
                <skill
                    id="Steward"
                    value="125" />
            </skills>
            <Traits>
                <Trait id="ArcherFIghtingSkills" value="2" />
                <Trait id="Surgeon" value="1" />
                <Trait id="Calculating" value="3" />
                <Trait id="Mercy" value="1" />
                <Trait id="Valor" value="1" />
                <Trait id="SpellCasterSkills" value="3" />
            </Traits>
            <Equipments>
                <EquipmentSet id="tor_prophetess_template" />
                <EquipmentSet id="tor_prophetess_template" civilian="true" />
            </Equipments>
        </NPCCharacter>
    </xsl:template>

    <xsl:template match="NPCCharacter[@id='tor_wanderer_eonir_0']">
        <NPCCharacter id="tor_wanderer_eonir_0" default_group="cavalry" occupation="Wanderer" culture="Culture.eonir" voice="curt" age="22" race="elf" is_template="true" is_hero="false">
            <xsl:attribute name="name">
                <xsl:text>{=str_tor_wanderer_eonir_0}{FIRSTNAME} the Ghost Strider</xsl:text>
            </xsl:attribute>
            <face>
                <face_key_template value="BodyProperty.male_wood_elf" />
            </face>
            <skills>
                <skill
                    id="TwoHanded"
                    value="75" />
            </skills>
            <Traits>
                <Trait id="Calculating" value="5" />
                <Trait id="Valor" value="-1" />
                <Trait id="RogueSkills" value="-1" />
                <Trait id="ScoutSkills" value="15" />
                <Trait id="ArcherFIghtingSkills" value="3" />
            </Traits>
            <Equipments>
                <EquipmentSet id="tor_eo_ghoststrider_template" />
                <EquipmentSet id="tor_eo_ghoststrider_template" civilian="true" />
            </Equipments>
        </NPCCharacter>
    </xsl:template>

    <xsl:template match="NPCCharacter[@id='tor_wanderer_woodelf_0']">
        <NPCCharacter id="tor_wanderer_woodelf_0" default_group="cavalry" occupation="Wanderer" culture="Culture.battania" voice="softspoken" age="19" race="elf" is_female="true" is_template="true" is_hero="false">
            <xsl:attribute name="name">
                <xsl:text>{=str_tor_wanderer_woodelf_0}{FIRSTNAME} the Spellsinger</xsl:text>
            </xsl:attribute>
            <face>
                <BodyProperties version="4" age="22" weight="0" build="0.2749" key="0015500B8758300866885396977479B85B26577487A3463A886475B28A788B17DBE416030CA4364C904C94B469A87884000000000000000C0000000035A44003" />
            </face>
            <Traits>
                <Trait id="HorseArcherFightingSkills" value="3" />
                <Trait id="Surgeon" value="1" />
                <Trait id="Calculating" value="3" />
                <Trait id="Mercy" value="1" />
                <Trait id="Valor" value="1" />
                <Trait id="SpellCasterSkills" value="7" />
            </Traits>
            <Equipments>
                <EquipmentSet id="tor_we_spellsinger_template" />
                <EquipmentSet id="tor_we_spellsinger_template" civilian="true" />
            </Equipments>
        </NPCCharacter>
    </xsl:template>

    <xsl:template match="NPCCharacter[@id='tor_wanderer_chaos_0']">
        <NPCCharacter id="tor_wanderer_chaos_0" default_group="cavalry" occupation="Wanderer" culture="Culture.chaos_culture" voice="curt" age="30" race="marauder" is_template="true" is_hero="false">
            <xsl:attribute name="name">
                <xsl:text>{=str_tor_wanderer_chaos_0}{FIRSTNAME} the Chosen of Chaos</xsl:text>
            </xsl:attribute>
            <face>
                <BodyProperties version="4" age="22" weight="0.02" build="0.9"  key="00205008C7000AC23F766AFFF3506CB1CCB0866E90D6E01971040518537A395AFF0076030EBA67A9D0C9BA304300006F000000000000000E0000000001D43002"  />
            </face>
            <Traits>
                <Trait id="KnightFightingSkills" value="9" />
                <Trait id="Commander" value="4" />
                <Trait id="Calculating" value="5" />
                <Trait id="Mercy" value="-1" />
                <Trait id="Valor" value="-1" />
            </Traits>
            <Equipments>
                <EquipmentSet id="tor_archaon_template" />
                <EquipmentSet id="tor_cult_fsf_archbacillus_template" civilian="true" />
            </Equipments>
        </NPCCharacter>
    </xsl:template>

    <xsl:template match="NPCCharacter[@id='tor_wanderer_mousillon_0']">
        <NPCCharacter id="tor_wanderer_mousillon_0" default_group="cavalry" occupation="Wanderer" culture="Culture.mousillon" voice="curt" age="38" is_template="true" is_hero="false">
        <xsl:attribute name="name">
            <xsl:text>{=str_tor_wanderer_mousillon_0}{FIRSTNAME} the Fallen Knight</xsl:text>
        </xsl:attribute>
        <face>
            <face_key_template value="BodyProperty.fighter_vlandia" />
            <hair_tags>
                <hair_tag name="ShortAndThin" />
            </hair_tags>
            <beard_tags>
                <beard_tag name="Cleanshaven" />
            </beard_tags>
        </face>
        <Traits>
            <Trait id="BalancedFightingSkills" value="8" />
            <Trait id="Commander" value="5" />
            <Trait id="Calculating" value="5" />
            <Trait id="Mercy" value="-1" />
            <Trait id="Valor" value="1" />
            <Trait id="NagashCorrupted" value="7" />
        </Traits>
        <Equipments>
            <EquipmentSet id="tor_fallen_knight" />
            <EquipmentSet id="tor_fallen_knight" civilian="true" />
        </Equipments>
        </NPCCharacter>
    </xsl:template>
</xsl:stylesheet>
