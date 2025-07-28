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
        <NPCCharacter id="tor_wanderer_empire_5" default_group="ranged" occupation="Wanderer" culture="Culture.empire" voice="curt" age="28" is_template="true" is_hero="false">
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
                <Trait id="HopliteFightingSkills" value="5" />
                <!-- <Trait id="Manager" value="6" /> -->
                <Trait id="EngineerSkills" value="9" />
                <Trait id="Blacksmith" value="4" />
                <Trait id="Calculating" value="1" />
                <Trait id="Mercy" value="1" />
                <Trait id="Valor" value="1" />
                <Trait id="Gunner" value="7" />
            </Traits>
            <Equipments>
                <EquipmentSet id="tor_engineer_companion_template" />
                <EquipmentSet id="tor_engineer_companion_template" civilian="true" />
            </Equipments>
        </NPCCharacter>
    </xsl:template>
    
    <xsl:template match="NPCCharacter[@id='tor_wanderer_empire_6']">
        <NPCCharacter id="tor_wanderer_empire_6" default_group="infantry" occupation="Wanderer" culture="Culture.empire" voice="curt" age="21" is_female="true" is_template="true" is_hero="false">
            <xsl:attribute name="name">
                <xsl:text>{=str_tor_wanderer_empire_6}{FIRSTNAME} the Priestess of Shallya</xsl:text>
            </xsl:attribute>
            <face>
                <BodyProperties version="4" age="22.24" weight="0.2002" build="0.1082"  key="0000EC03521430047E8994576364769494E588557BB77E117E774CB6879A116701B236130B47521000000000000000000000000000000000000000007F7C4003"  />
            </face>
            <skills>
                <skill
                    id="OneHanded"
                    value="100" />
            </skills>
            <Traits>
                <Trait id="ArcherFIghtingSkills" value="3" />
                <Trait id="Surgeon" value="8" />
                <Trait id="Calculating" value="1" />
                <Trait id="Mercy" value="5" />
                <Trait id="Valor" value="7" />
                <Trait id="ShallyaDevoted" value="7" />
            </Traits>
            <Equipments>
                <EquipmentSet id="tor_priestess_of_shallya_template" />
                <EquipmentSet id="tor_priestess_of_shallya_template" civilian="true" />
            </Equipments>
        </NPCCharacter>
    </xsl:template>
    
    <xsl:template match="NPCCharacter[@id='tor_wanderer_bretonnia_0']">
        <NPCCharacter id="tor_wanderer_bretonnia_0" default_group="infantry" occupation="Wanderer" culture="Culture.vlandia" voice="curt" age="30" is_template="true" is_hero="false">
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
        <NPCCharacter id="tor_wanderer_bretonnia_1" default_group="infantry" occupation="Wanderer" culture="Culture.vlandia" voice="curt" age="20" is_female="true" is_template="true" is_hero="false">
            <xsl:attribute name="name">
                <xsl:text>{=str_tor_wanderer_bretonnia_1}{FIRSTNAME} the Damsel of the Lady</xsl:text>
            </xsl:attribute>
            <face>
                <BodyProperties version="4" age="22.42" weight="0.0262" build="0.0386" key="0002140FD114200403877354C044644083F889B5A8AB52102E72593189E6060200A105030A420574000000000000000000000000000000000000000057581003" />
            </face>
            <skills>
                <skill
                    id="OneHanded"
                    value="100" />
            </skills>
            <Traits>
                <Trait id="ArcherFIghtingSkills" value="3" />
                <Trait id="Manager" value="5" />
                <Trait id="Surgeon" value="1" />
                <Trait id="Calculating" value="3" />
                <Trait id="Mercy" value="1" />
                <Trait id="Valor" value="1" />
                <Trait id="SpellCasterSkills" value="7" />
            </Traits>
            <Equipments>
                <EquipmentSet id="tor_prophetess_template" />
                <EquipmentSet id="tor_prophetess_template" civilian="true" />
            </Equipments>
        </NPCCharacter>
    </xsl:template>

    <xsl:template match="NPCCharacter[@id='tor_wanderer_eonir_0']">
        <NPCCharacter id="tor_wanderer_eonir_0" default_group="infantry" occupation="Wanderer" culture="Culture.eonir" voice="curt" age="22" race="elf" is_template="true" is_hero="false">
            <xsl:attribute name="name">
                <xsl:text>{=str_tor_wanderer_eonir_0}{FIRSTNAME} the Ghost Strider</xsl:text>
            </xsl:attribute>
            <face>
                <face_key_template value="BodyProperty.male_wood_elf" />
            </face>
            <skills>
                <skill
                    id="TwoHanded"
                    value="100" />
            </skills>
            <Traits>
                <Trait id="Calculating" value="5" />
                <Trait id="Valor" value="-1" />
                <Trait id="RogueSkills" value="-1" />
                <Trait id="ScoutSkills" value="15" />
                <Trait id="ArcherFIghtingSkills" value="7" />
            </Traits>
            <Equipments>
                <EquipmentSet id="tor_eo_ghoststrider_template" />
                <EquipmentSet id="tor_eo_ghoststrider_template" civilian="true" />
            </Equipments>
        </NPCCharacter>
    </xsl:template>
</xsl:stylesheet>