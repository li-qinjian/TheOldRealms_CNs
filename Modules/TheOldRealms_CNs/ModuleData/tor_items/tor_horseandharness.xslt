<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

	<!--KEEP THIS HERE! Important! DO NOT MOVE IT TO OTHER XML-->
	<xsl:template match="Item[@id='campaign_banner_small']/@name">
		<xsl:attribute name="name">{=CGB4Qxkb}Campaign Banner Small</xsl:attribute>
	</xsl:template>

	<!--Generic Mount-->
	<xsl:template match="Item[@id='tor_generic_mount_horse_001']/@name">
		<xsl:attribute name="name">{=hfJejZ2H}Old Rob</xsl:attribute>
	</xsl:template>

	<!--Empire Mount-->
	<xsl:template match="Item[@id='tor_empire_mount_horse_001']/@name">
		<xsl:attribute name="name">{=aQi16W1y}Empire Horse Destrier</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_empire_mount_horse_002']/@name">
		<xsl:attribute name="name">{=PEErv97J}Empire Charger</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_empire_mount_horse_003']/@name">
		<xsl:attribute name="name">{=Q3WS7GAN}Empire Warhorse</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_empire_mount_demigryph_001']/@name">
		<xsl:attribute name="name">{=xgKhWiWQ}Demigryph</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_empire_mount_demigryph_002']/@name">
		<xsl:attribute name="name">{=xgKhWiWQ}Demigryph</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_empire_mount_demigryph_003']/@name">
		<xsl:attribute name="name">{=xgKhWiWQ}Demigryph</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_empire_mount_demigryph_004']/@name">
		<xsl:attribute name="name">{=xgKhWiWQ}Demigryph</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_empire_mount_demigryph_005']/@name">
		<xsl:attribute name="name">{=OtFRjw81}Snowlion-Demigryph</xsl:attribute>
	</xsl:template>

	<!--Vampire Count Mount-->
	<xsl:template match="Item[@id='tor_vc_mount_horse_zombie_horse_001']/@name">
		<xsl:attribute name="name">{=CQDnXrLU}Zombie Horse</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_vc_mount_horse_zombie_horse_002']/@name">
		<xsl:attribute name="name">{=CQDnXrLU}Zombie Horse</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_vc_mount_horse_skeleton_horse_001']/@name">
		<xsl:attribute name="name">{=g1Wk7hSk}Skeleton Horse</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_vc_mount_horse_skeleton_horse_002']/@name">
		<xsl:attribute name="name">{=g1Wk7hSk}Skeleton Horse</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_vc_mount_horse_ghost_horse_001']/@name">
		<xsl:attribute name="name">{=O19OJWJk}Ghost Horse</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_vc_mount_horse_ghost_horse_002']/@name">
		<xsl:attribute name="name">{=O19OJWJk}Ghost Horse</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_vc_mount_horse_ghost_horse_003']/@name">
		<xsl:attribute name="name">{=O19OJWJk}Ghost Horse</xsl:attribute>
	</xsl:template>

	<!--Chaos Mount-->
	<xsl:template match="Item[@id='tor_chs_mount_horse_chaos_horse_001']/@name">
		<xsl:attribute name="name">{=C4niv2fA}Chaos Horse</xsl:attribute>
	</xsl:template>

	<!--Wood Elves Mount-->
	<xsl:template match="Item[@id='tor_we_mount_great_stag_001']/@name">
		<xsl:attribute name="name">{=OTPL2EhV}Great Stag</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_we_mount_unicorn_001']/@name">
		<xsl:attribute name="name">{=etYyRACg}Unicorn</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_we_mountarmor_great_stag_saddle_001']/@name">
		<xsl:attribute name="name">{=ABQb3ESg}Great Stag Saddle</xsl:attribute>
	</xsl:template>

	<!--Bretonnian Mount-->
	<xsl:template match="Item[@id='tor_bretonnia_mount_horse_001']/@name">
		<xsl:attribute name="name">{=cjHuCxtU}Bretonnian Squire</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_bretonnia_mount_horse_002']/@name">
		<xsl:attribute name="name">{=VLOFQwVR}Bretonnian Pure-Bred</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_bretonnia_mount_horse_003']/@name">
		<xsl:attribute name="name">{=NJoK7rBz}Bretonnian War Horse</xsl:attribute>
	</xsl:template>

	<!--Vampire Count Mount Armor-->
	<xsl:template match="Item[@id='tor_vc_mountarmor_horsearmor_vampire_001']/@name">
		<xsl:attribute name="name">{=y9xyqwD0}Vampire Horse Harness</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_vc_mountarmor_horsearmor_vampire_002']/@name">
		<xsl:attribute name="name">{=y9xyqwD0}Vampire Horse Harness</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_vc_mountarmor_horsearmor_vampire_003']/@name">
		<xsl:attribute name="name">{=y9xyqwD0}Vampire Horse Harness</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_vc_mountarmor_horsearmor_black_knight_001']/@name">
		<xsl:attribute name="name">{=cuRtZrxa}Black Knight Horse Harness</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_vc_mountarmor_horsearmor_ghost_001']/@name">
		<xsl:attribute name="name">{=7owIFZXT}Ghost Horse Harness</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_vc_mountarmor_horsearmor_ghost_002']/@name">
		<xsl:attribute name="name">{=7owIFZXT}Ghost Horse Harness</xsl:attribute>
	</xsl:template>

	<!--Empire Mount Armor-->
	<xsl:template match="Item[@id='tor_empire_mountarmor_horsearmor_001']/@name">
		<xsl:attribute name="name">{=zNZ9jINX}Empire Horse Armor</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_empire_mountarmor_horsearmor_002']/@name">
		<xsl:attribute name="name">{=zNZ9jINX}Empire Horse Armor</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_empire_mountarmor_horsearmor_royal_001']/@name">
		<xsl:attribute name="name">{=4DvqD2Av}Empire Horse Royal Armor</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_empire_mountarmor_horsearmor_royal_002']/@name">
		<xsl:attribute name="name">{=PNfb0nNX}Empire Horse Royal Silver Armor</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_empire_mountarmor_demigryph_saddle_001']/@name">
		<xsl:attribute name="name">{=C975ihfd}Demigryph Saddle</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_empire_mountarmor_demigryph_armor_001']/@name">
		<xsl:attribute name="name">{=IU4XX3FD}Demigryph Armor</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_empire_mountarmor_demigryph_armor_002']/@name">
		<xsl:attribute name="name">{=IU4XX3FD}Demigryph Armor</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_empire_mountarmor_demigryph_armor_003']/@name">
		<xsl:attribute name="name">{=IU4XX3FD}Demigryph Armor</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_empire_mountarmor_demigryph_armor_004']/@name">
		<xsl:attribute name="name">{=IU4XX3FD}Demigryph Armor</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_empire_mountarmor_ror_demigryph_armor_001']/@name">
		<xsl:attribute name="name">{=hHnR8Tew}Knights Griffon Demigryph Armour</xsl:attribute>
	</xsl:template>

	<!--Bretonnia Mount Armor-->
	<xsl:template match="Item[@id='tor_bret_mountarmor_horsearmor_001']/@name">
		<xsl:attribute name="name">{=YiVINvHy}Bretonnian Horse Armor</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_bret_mountarmor_horsearmor_002']/@name">
		<xsl:attribute name="name">{=YiVINvHy}Bretonnian Horse Armor</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_bret_mountarmor_horsearmor_003']/@name">
		<xsl:attribute name="name">{=YiVINvHy}Bretonnian Horse Armor</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_bret_mountarmor_horsearmor_004']/@name">
		<xsl:attribute name="name">{=YiVINvHy}Bretonnian Horse Armor</xsl:attribute>
	</xsl:template>
	<xsl:template match="Item[@id='tor_bret_mountarmor_horsearmor_005']/@name">
		<xsl:attribute name="name">{=YiVINvHy}Bretonnian Horse Armor</xsl:attribute>
	</xsl:template>


</xsl:stylesheet>