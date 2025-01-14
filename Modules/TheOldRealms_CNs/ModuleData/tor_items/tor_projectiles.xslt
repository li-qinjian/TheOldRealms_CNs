<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

	<!-- Grenades -->
	<xsl:template match="Item[@id='tor_dwarf_weapon_grenade_dwarf_hand_grenade']/@name">
		<xsl:attribute name="name">{=ffEzMQMp}Dwarf Hand Grenade</xsl:attribute>
	</xsl:template>

	<!-- Factionless Weapons -->
  	<!-- RANGE -->
  	<!-- AMMO -->
	<xsl:template match="Item[@id='tor_neutral_weapon_ammo_musket_ball']/@name">
		<xsl:attribute name="name">{=Mzl6vNdU}Musket Ball</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_neutral_weapon_ammo_silver_bullet']/@name">
		<xsl:attribute name="name">{=Hzta7mME}Silver Bullet</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_neutral_weapon_ammo_musket_ball_scatter']/@name">
		<xsl:attribute name="name">{=M9BJ6Bon}Buck Shots</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_neutral_weapon_ammo_cannonball']/@name">
		<xsl:attribute name="name">{=DxeYtPLm}Cannonball</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_neutral_weapon_ammo_broken_weapon']/@name">
		<xsl:attribute name="name">{=jLVswoqJ}Broken Weapon</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_empire_weapon_ammo_grenade']/@name">
		<xsl:attribute name="name">{=DtYdsemZ}Grenades</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='AmberSpear']/@name">
		<xsl:attribute name="name">{=Fg3VM1Y9}Amber Spear</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='TheGreenEye']/@name">
		<xsl:attribute name="name">{=VrQUO4UW}The Green Eye</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_we_tournament_arrows']/@name">
		<xsl:attribute name="name">{=HXFx8xkK}Wood Elven Tournament Arrows</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_we_arrows_ofpotency']/@name">
		<xsl:attribute name="name">{=9qKHLcRe}Arrows Of Potency</xsl:attribute>
	</xsl:template>
	
</xsl:stylesheet>