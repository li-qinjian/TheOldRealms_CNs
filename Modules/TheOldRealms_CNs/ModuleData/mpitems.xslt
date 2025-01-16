<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

	<xsl:template match="Items/Item[@id='battania_noble_bracers']/@name">
		<xsl:attribute name="name">游侠腕甲</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='empire_warrior_padded_armor_f']/@name">
		<xsl:attribute name="name">提利尔古典轻甲</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='empire_warrior_padded_armor_g']/@name">
		<xsl:attribute name="name">提利尔肩带古典轻甲</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='khuzait_battle_crown']/@name">
		<xsl:attribute name="name">草原战场王冠</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='sturgian_battle_crown']/@name">
		<xsl:attribute name="name">装饰盔</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='empire_lord_helmet']/@name">
		<xsl:attribute name="name">提利尔古典官吏头盔</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='battania_horse_tournament']/@name">
		<xsl:attribute name="name">巴托尼亚矮种马</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='battania_horse']/@name">
		<xsl:attribute name="name">巴托尼亚马驹</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='t2_empire_horse']/@name">
		<xsl:attribute name="name">帝国军马</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='t3_sturgia_horse']/@name">
		<xsl:attribute name="name">诺斯卡快马</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='noble_horse_battania']/@name">
		<xsl:attribute name="name">巴托尼亚纯血马</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='desert_cloth_harness']/@name">
		<xsl:attribute name="name">北方荒原布制马鞍</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='aseran_village_harness']/@name">
		<xsl:attribute name="name">北方荒原普通马鞍</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='battania_horse_harness']/@name">
		<xsl:attribute name="name">装饰过的马具</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='viking_round_shield']/@name">
		<xsl:attribute name="name">诺斯卡圆盾</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='empire_sword_1_t2_blunt']/@name">
		<xsl:attribute name="name">提利尔古典短剑(训练用)</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='nordic_shortbow']/@name">
		<xsl:attribute name="name">基斯里夫短弓</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='aserai_axe_2_t2']/@name">
		<xsl:attribute name="name">简易竹柄单手斧</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='battania_axe_1_t2']/@name">
		<xsl:attribute name="name">诺斯卡短柄斧</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='sturgia_axe_3_t3']/@name">
		<xsl:attribute name="name">普通的北方斧</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='southern_spear_3_t4']/@name">
		<xsl:attribute name="name">精炼陨铁长矛</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='thamaskene_pike_t4']/@name">
		<xsl:attribute name="name">陨铁长枪</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='vlandia_lance_1_t3']/@name">
		<xsl:attribute name="name">轻型短矛</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='empire_lance_1_t3']/@name">
		<xsl:attribute name="name">轻骑兵短矛</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='aserai_lance_1_t5']/@name">
		<xsl:attribute name="name">马穆鲁克短矛</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='vlandia_lance_2_t4']/@name">
		<xsl:attribute name="name">骑士次等枪</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='sturgia_lance_1_t4']/@name">
		<xsl:attribute name="name">亲卫骑兵短矛</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='vlandia_lance_3_t5']/@name">
		<xsl:attribute name="name">重骑士次等枪</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='sturgia_lance_2_t5']/@name">
		<xsl:attribute name="name">重亲卫骑兵短矛</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='empire_sword_1_t2']/@name">
		<xsl:attribute name="name">提利尔古典铁制短剑</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='simple_back_sword_t2']/@name">
		<xsl:attribute name="name">简易基斯里夫弯刀</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='iron_spatha_sword_t2']/@name">
		<xsl:attribute name="name">提利尔古典铁制短剑</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='empire_sword_2_t3']/@name">
		<xsl:attribute name="name">提利尔古典短槽短剑</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='empire_sword_3_t3']/@name">
		<xsl:attribute name="name">提利尔古典短剑</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='empire_sword_4_t4']/@name">
		<xsl:attribute name="name">提利尔古典优质钢剑</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='empire_sword_6_t5']/@name">
		<xsl:attribute name="name">陨铁佩剑</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='empire_noble_sword_1_t5']/@name">
		<xsl:attribute name="name">提利尔古典装饰短剑</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='empire_noble_sword_2_t5']/@name">
		<xsl:attribute name="name">提利尔古典陨铁短剑</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='empire_noble_sword_3_t5']/@name">
		<xsl:attribute name="name">提利尔古典环首短剑</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='sturgia_noble_sword_1_t5']/@name">
		<xsl:attribute name="name">陨铁战剑</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='battania_2hsword_3_t3']/@name">
		<xsl:attribute name="name">基斯里夫宽槽巨剑</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='battania_2hsword_5_t5']/@name">
		<xsl:attribute name="name">巴托尼亚山地剑</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='vlandia_2hsword_2_t5']/@name">
		<xsl:attribute name="name">陨铁双手剑</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items/Item[@id='empire_mace_3_t4']/@name">
		<xsl:attribute name="name">镶边单手锤</xsl:attribute>
	</xsl:template>
	
</xsl:stylesheet>