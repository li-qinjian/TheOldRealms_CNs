<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

	<!--<xsl:template match="name[@name='{=empire_generic_clan_name}von {ORIGIN_SETTLEMENT}']/@name">
		<xsl:attribute name="name">{=empire_generic_clan_name} {=9ERi7tpW} {ORIGIN_SETTLEMENT}</xsl:attribute>
	</xsl:template>-->
	<xsl:template match="Culture[@id='empire']/@name">
		<xsl:attribute name="name">{=VeyKKsHW}Empire of Men</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='khuzait']/@name">
		<xsl:attribute name="name">{=HGvMs61e}Vampire Counts</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='blooddragons']/@name">
		<xsl:attribute name="name">{=rv436IIV}Blood Dragons</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='vlandia']/@name">
		<xsl:attribute name="name">{=vAOEc52h}Bretonnia</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='mousillon']/@name">
		<xsl:attribute name="name">{=C3fw10fS}Mousillon</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='eonir']/@name">
		<xsl:attribute name="name">{=PoDpwRZy}Eonir</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='looters']/@name">
		<xsl:attribute name="name">{=UeGPvST8}Outlaws</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='mountain_bandits']/@name">
		<xsl:attribute name="name">{=ESArpu73}Empire Deserters</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='forest_bandits']/@name">
		<xsl:attribute name="name">{=ZyKBCzVK}Chaos Cultists</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='steppe_bandits']/@name">
		<xsl:attribute name="name">{=bEOzfadU}Beastmen Warband</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='sea_raiders']/@name">
		<xsl:attribute name="name">{=V1EDW0di}Norscan Raiders</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='desert_bandits']/@name">
		<xsl:attribute name="name">{=2e7gGdBs}Herrimaults</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='neutral_culture']/@name">
		<xsl:attribute name="name">{=TUVfjcMY}Neutral</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='exotic']/@name">
		<xsl:attribute name="name">{=3izw6TTe}Exotic</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='druchii']/@name">
		<xsl:attribute name="name">{=sMLiFgkX}Druchii</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='asur']/@name">
		<xsl:attribute name="name">{=CwVOLm8u}Asur</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='aserai']/@name">
		<xsl:attribute name="name">{=ISdDVQyf}Greenskins</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='battania']/@name">
		<xsl:attribute name="name">{=qyGiaTgJ}Wood Elves</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='sturgia']/@name">
		<xsl:attribute name="name">{=MQ1v0M1I}Dwarves</xsl:attribute>
	</xsl:template>
	<xsl:template match="Culture[@id='chaos_culture']/@name">
		<xsl:attribute name="name">{=vJobnSuk}Chaos</xsl:attribute>
	</xsl:template>
	
</xsl:stylesheet>