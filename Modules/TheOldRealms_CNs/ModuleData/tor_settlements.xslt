<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

	<!--Custom Settlements-->
	<xsl:template match="Settlements/Settlement[@id='oak_of_ages']/@name">
		<xsl:attribute name="name">{=ZoIo42dV}Oak of Ages</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='oak_of_ages']/@text">
		<xsl:attribute name="text">{=ZoIo42dV}Oak of Ages</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='worldroot_01']/@name">
		<xsl:attribute name="name">{=YX6Nxgc4}Arden Forest World Roots</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='worldroot_01']/@text">
		<xsl:attribute name="text">{=YX6Nxgc4}Arden Forest World Roots</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='worldroot_02']/@name">
		<xsl:attribute name="name">{=jrr9mYN5}Laurelorn World Roots</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='worldroot_02']/@text">
		<xsl:attribute name="text">{=jrr9mYN5}Laurelorn World Roots</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='worldroot_03']/@name">
		<xsl:attribute name="name">{=vQQiHxXP}Gryphenwood World Roots</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='worldroot_03']/@text">
		<xsl:attribute name="text">{=vQQiHxXP}Gryphenwood World Roots</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='worldroot_04']/@name">
		<xsl:attribute name="name">{=FvLU6ZlF}Maisontaal World Roots</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='worldroot_04']/@text">
		<xsl:attribute name="text">{=FvLU6ZlF}Maisontaal World Roots</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='chaos_portal_01']/@name">
		<xsl:attribute name="name">{=PowBix35}Chaos Portal</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='chaos_portal_01']/@text">
		<xsl:attribute name="text">{=PowBix35}Chaos Portal</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='sigmar_shrine_01']/@name">
		<xsl:attribute name="name">{=3aghuuCn}Shrine of Sigmar</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='sigmar_shrine_01']/@text">
		<xsl:attribute name="text">{=3aghuuCn}Shrine of Sigmar</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='sigmar_shrine_02']/@name">
		<xsl:attribute name="name">{=3aghuuCn}Shrine of Sigmar</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='sigmar_shrine_02']/@text">
		<xsl:attribute name="text">{=3aghuuCn}Shrine of Sigmar</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='sigmar_shrine_03']/@name">
		<xsl:attribute name="name">{=3aghuuCn}Shrine of Sigmar</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='sigmar_shrine_03']/@text">
		<xsl:attribute name="text">{=3aghuuCn}Shrine of Sigmar</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='sigmar_shrine_04']/@name">
		<xsl:attribute name="name">{=3aghuuCn}Shrine of Sigmar</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='sigmar_shrine_04']/@text">
		<xsl:attribute name="text">{=3aghuuCn}Shrine of Sigmar</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='sigmar_shrine_05']/@name">
		<xsl:attribute name="name">{=3aghuuCn}Shrine of Sigmar</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='sigmar_shrine_05']/@text">
		<xsl:attribute name="text">{=3aghuuCn}Shrine of Sigmar</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='sigmar_shrine_06']/@name">
		<xsl:attribute name="name">{=3aghuuCn}Shrine of Sigmar</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='sigmar_shrine_06']/@text">
		<xsl:attribute name="text">{=3aghuuCn}Shrine of Sigmar</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='sigmar_shrine_07']/@name">
		<xsl:attribute name="name">{=YvIm5FlD}Abandoned Shrine of Sigmar</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='sigmar_shrine_07']/@text">
		<xsl:attribute name="text">{=3aghuuCn}Shrine of Sigmar</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='taal_shrine_01']/@name">
		<xsl:attribute name="name">{=U0zZATV0}Shrine of Taal</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='taal_shrine_01']/@text">
		<xsl:attribute name="text">{=U0zZATV0}Shrine of Taal</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='taal_shrine_02']/@name">
		<xsl:attribute name="name">{=U0zZATV0}Shrine of Taal</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='taal_shrine_02']/@text">
		<xsl:attribute name="text">{=U0zZATV0}Shrine of Taal</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='taal_shrine_03']/@name">
		<xsl:attribute name="name">{=U0zZATV0}Shrine of Taal</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='taal_shrine_03']/@text">
		<xsl:attribute name="text">{=U0zZATV0}Shrine of Taal</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='taal_shrine_04']/@name">
		<xsl:attribute name="name">{=7ZjRjgEL}Guarec Circle</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='taal_shrine_04']/@text">
		<xsl:attribute name="text">{=7ZjRjgEL}Guarec Circle</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='taal_shrine_05']/@name">
		<xsl:attribute name="name">{=U0zZATV0}Shrine of Taal</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='taal_shrine_05']/@text">
		<xsl:attribute name="text">{=U0zZATV0}Shrine of Taal</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='grove_of_the_lady_01']/@name">
		<xsl:attribute name="name">{=wmmRbQTl}Grove of the Lady</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='grove_of_the_lady_01']/@text">
		<xsl:attribute name="text">{=wmmRbQTl}Grove of the Lady</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='grove_of_the_lady_02']/@name">
		<xsl:attribute name="name">{=wmmRbQTl}Grove of the Lady</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='grove_of_the_lady_02']/@text">
		<xsl:attribute name="text">{=wmmRbQTl}Grove of the Lady</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='grove_of_the_lady_03']/@name">
		<xsl:attribute name="name">{=wmmRbQTl}Grove of the Lady</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='grove_of_the_lady_03']/@text">
		<xsl:attribute name="text">{=wmmRbQTl}Grove of the Lady</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='grove_of_the_lady_04']/@name">
		<xsl:attribute name="name">{=wmmRbQTl}Grove of the Lady</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='grove_of_the_lady_04']/@text">
		<xsl:attribute name="text">{=wmmRbQTl}Grove of the Lady</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='grove_of_the_lady_05']/@name">
		<xsl:attribute name="name">{=wmmRbQTl}Grove of the Lady</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='grove_of_the_lady_05']/@text">
		<xsl:attribute name="text">{=wmmRbQTl}Grove of the Lady</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='herdstone_01']/@name">
		<xsl:attribute name="name">{=hmdbc659}Beastmen Herdstone</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='herdstone_01']/@text">
		<xsl:attribute name="text">{=hmdbc659}Beastmen Herdstone</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='herdstone_02']/@name">
		<xsl:attribute name="name">{=hmdbc659}Beastmen Herdstone</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='herdstone_02']/@text">
		<xsl:attribute name="text">{=hmdbc659}Beastmen Herdstone</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='herdstone_03']/@name">
		<xsl:attribute name="name">{=hmdbc659}Beastmen Herdstone</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='herdstone_03']/@text">
		<xsl:attribute name="text">{=hmdbc659}Beastmen Herdstone</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='herdstone_04']/@name">
		<xsl:attribute name="name">{=hmdbc659}Beastmen Herdstone</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='herdstone_04']/@text">
		<xsl:attribute name="text">{=hmdbc659}Beastmen Herdstone</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='herdstone_05']/@name">
		<xsl:attribute name="name">{=hmdbc659}Beastmen Herdstone</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='herdstone_05']/@text">
		<xsl:attribute name="text">{=hmdbc659}Beastmen Herdstone</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='darkelf_camp_01']/@name">
		<xsl:attribute name="name">{=SWK0qouo}Druchii Slaver Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='darkelf_camp_01']/@text">
		<xsl:attribute name="text">{=SWK0qouo}Druchii Slaver Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='manaan_shrine_01']/@name">
		<xsl:attribute name="name">{=D3GuXD2U}Shrine of Manaan</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='manaan_shrine_01']/@text">
		<xsl:attribute name="text">{=D3GuXD2U}Shrine of Manaan</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='manaan_shrine_02']/@name">
		<xsl:attribute name="name">{=ynSjTWwi}Manaan's Teeth</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='manaan_shrine_02']/@text">
		<xsl:attribute name="text">{=ynSjTWwi}Manaan's Teeth</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='manaan_shrine_03']/@name">
		<xsl:attribute name="name">{=D3GuXD2U}Shrine of Manaan</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='manaan_shrine_03']/@text">
		<xsl:attribute name="text">{=D3GuXD2U}Shrine of Manaan</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='manaan_shrine_04']/@name">
		<xsl:attribute name="name">{=D3GuXD2U}Shrine of Manaan</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='manaan_shrine_04']/@text">
		<xsl:attribute name="text">{=D3GuXD2U}Shrine of Manaan</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='manaan_shrine_05']/@name">
		<xsl:attribute name="name">{=D3GuXD2U}Shrine of Manaan</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='manaan_shrine_05']/@text">
		<xsl:attribute name="text">{=D3GuXD2U}Shrine of Manaan</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='manaan_shrine_06']/@name">
		<xsl:attribute name="name">{=D3GuXD2U}Shrine of Manaan</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='manaan_shrine_06']/@text">
		<xsl:attribute name="text">{=D3GuXD2U}Shrine of Manaan</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='asuryan_shrine_01']/@name">
		<xsl:attribute name="name">{=CGZwdmnr}Shrine of Asuryan</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='asuryan_shrine_01']/@text">
		<xsl:attribute name="text">{=CGZwdmnr}Shrine of Asuryan</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='ulric_shrine_01']/@name">
		<xsl:attribute name="name">{=e6xyJypP}Shrine of Ulric</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='ulric_shrine_01']/@text">
		<xsl:attribute name="text">{=e6xyJypP}Shrine of Ulric</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='ulric_shrine_02']/@name">
		<xsl:attribute name="name">{=e6xyJypP}Shrine of Ulric</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='ulric_shrine_02']/@text">
		<xsl:attribute name="text">{=e6xyJypP}Shrine of Ulric</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='ulric_shrine_03']/@name">
		<xsl:attribute name="name">{=e6xyJypP}Shrine of Ulric</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='ulric_shrine_03']/@text">
		<xsl:attribute name="text">{=e6xyJypP}Shrine of Ulric</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='ulric_shrine_04']/@name">
		<xsl:attribute name="name">{=e6xyJypP}Shrine of Ulric</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='ulric_shrine_04']/@text">
		<xsl:attribute name="text">{=e6xyJypP}Shrine of Ulric</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='ulric_shrine_05']/@name">
		<xsl:attribute name="name">{=e6xyJypP}Shrine of Ulric</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='ulric_shrine_05']/@text">
		<xsl:attribute name="text">{=e6xyJypP}Shrine of Ulric</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='shallya_shrine_01']/@name">
		<xsl:attribute name="name">{=HO9O9bxV}Shrine of Shallya</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='shallya_shrine_01']/@text">
		<xsl:attribute name="text">{=HO9O9bxV}Shrine of Shallya</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='shallya_shrine_02']/@name">
		<xsl:attribute name="name">{=HO9O9bxV}Shrine of Shallya</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='shallya_shrine_02']/@text">
		<xsl:attribute name="text">{=HO9O9bxV}Shrine of Shallya</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='shallya_shrine_03']/@name">
		<xsl:attribute name="name">{=HO9O9bxV}Shrine of Shallya</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='shallya_shrine_03']/@text">
		<xsl:attribute name="text">{=HO9O9bxV}Shrine of Shallya</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='shallya_shrine_04']/@name">
		<xsl:attribute name="name">{=HO9O9bxV}Shrine of Shallya</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='shallya_shrine_04']/@text">
		<xsl:attribute name="text">{=HO9O9bxV}Shrine of Shallya</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='shallya_shrine_05']/@name">
		<xsl:attribute name="name">{=HO9O9bxV}Shrine of Shallya</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='shallya_shrine_05']/@text">
		<xsl:attribute name="text">{=HO9O9bxV}Shrine of Shallya</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='loec_shrine_01']/@name">
		<xsl:attribute name="name">{=h55iYaTm}Shrine of Loec</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='loec_shrine_01']/@text">
		<xsl:attribute name="text">{=h55iYaTm}Shrine of Loec</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='anath_shrine_01']/@name">
		<xsl:attribute name="name">{=k1hrhNGC}Shrine of Anath Raema</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='anath_shrine_01']/@text">
		<xsl:attribute name="text">{=k1hrhNGC}Shrine of Anath Raema</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='vaul_shrine_01']/@name">
		<xsl:attribute name="name">{=QwlqhJhp}Shrine of Vaul</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='vaul_shrine_01']/@text">
		<xsl:attribute name="text">{=QwlqhJhp}Shrine of Vaul</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='kurnous_shrine_01']/@name">
		<xsl:attribute name="name">{=XAieKYgw}Shrine of Kurnous</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='kurnous_shrine_01']/@text">
		<xsl:attribute name="text">{=XAieKYgw}Shrine of Kurnous</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='isha_shrine_01']/@name">
		<xsl:attribute name="name">{=eqTl4aGZ}Shrine of Isha</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='isha_shrine_01']/@text">
		<xsl:attribute name="text">{=eqTl4aGZ}Shrine of Isha</xsl:attribute>
	</xsl:template>
	
	<!--haunted sites-->
	<xsl:template match="Settlements/Settlement[@id='haunted_site_01']/@name">
		<xsl:attribute name="name">{=WQKOmvrx}Hunger Woods</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='haunted_site_01']/@text">
		<xsl:attribute name="text">{=7iF0t2EK}Called Verhungern by local Slyvanians, this dispersed land is a ghoul, and likely spirit, infested maze of briars and bogs. Only the insane or desperate would venture into its boughs.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='haunted_site_02']/@name">
		<xsl:attribute name="name">{=3oLjCU7m}Hel Fenn</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='haunted_site_02']/@text">
		<xsl:attribute name="text">{=wmjPS5Sy}Destroyed by unholy fire that rained from the skies eons ago, Hel Fenn is likely the most cursed area in the whole Reik Basin. Molded buildings, rotting trees and tar covered corpses dot the desolate landscape. This was also the site of Mannfred von Carsteins defeat and the end of the Vampire Wars.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='haunted_site_03']/@name">
		<xsl:attribute name="name">{=5ntb8Tmf}The Barren Hills</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='haunted_site_03']/@text">
		<xsl:attribute name="text">{=uyalMZ27}Long have the hills southeast of Talabheim been cursed. Strangeness and tragedy are no stranger to that land. Despite this, no one knows what the cause of the miasma is; though not for lack of trying.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='haunted_site_04']/@name">
		<xsl:attribute name="name">{=KsutDlZ4}The Charnel Hills</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='haunted_site_04']/@text">
		<xsl:attribute name="text">{=Z6DvmovU}Centuries ago, the hills outside of Mousillon were used as a mass grave to bury the thousands who died of Red Pox. So many victims were there that to this day the soil covering their pits is visible from the city walls. The air here is sometimes poisonous and like the rest of the cursed land the long dead rest uneasily.</xsl:attribute>
	</xsl:template>

	<!-- Averland 2 Towns 11 villages 2 castles -->
	<xsl:template match="Settlements/Settlement[@id='town_AV1']/@text">
		<xsl:attribute name="text">{=3wNDgI1Z}Averheim, the capital of the Grand Province of Averland, is one of the oldest cities in the Empire. The site upon which the modern city now lies has been occupied since before the time of Sigmar when the Averlanders were still called Brigrundians. The dockyards here are particularly bustling due to the Aver serving as the primary trade route for the Halfling goods from the Moot into the wider empire. The bluff that the city sits upon protects the inhabitants from occasional flooding and has always served as an ideal crossing point across the Aver River; making the Griffin bridge one of the only places for many miles which provides access across the river for merchants and travellers heading north into Stirland or south into Averland. The skyline of the city is dominated by the Averburg Palace, a formidable fortress originally built around the founding of the Empire; views of the surrounding lands from the palace go for several miles all around the city. The city is famous for its cattle stockyards, the final destination of thousands of Averland cattle, the Plenzerplatz and of course its lord; Marious Lietdorf, the mad count of Averland.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_AV2']/@text">
		<xsl:attribute name="text">{=wPwhZjbD}Wuppertal is a picturesque Averlandish town, some might even say frozen in its cherished past. The city is known for carpentry, fine beer and ale (by human standards) and its tradition abiding Averlander inhabitants. The town also hosts many pilgrims and zealots, serving as one of the southern strongholds for the cult of Sigmar whose shrine here is dedicated to Joseph the Reverent. The town also hosts a large temple of Verena and a Garden of Morr. As with many settlements along the Upper Reik, a ferry operates to bring goods and people across the river into Averland or out to Wissenland.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_AV3']/@text">
		<xsl:attribute name="text">{=rzehxUwm}The fortress town of Grenzstadt guards the approaches to and from the infamous Black Fire Pass. The Old Dwarf Road also passes through it on its northern route. As a result of its geography the town is in the perfect position to both facilitate trade with the Dwarfen Karaks and to guard against invasion by Greenskins and similar ilk coming through the Black Fire Pass. Tall and formidable walls and towers, and the size of its merchant quarter, enlarge the true size of the town. On any given day there are typically more visitors in the town than permanent inhabitants. Of these inhabitants, 1/10th of them are Dwarfs, here to serve as agents for their clans and to watch for human thieves seeking to sell stolen dwarf artefacts in the Empire. It is also known for Grenzstadter wine, high quality wine known for causing little to no hangover effects.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_AV4']/@text">
		<xsl:attribute name="text">{=8zpZ9yIa}On the eastern border of Averland stands Pfungzig, a fortress and seat of power belonging to von Heine. Pfungzig commands a view of many miles around it, allowing one to watch over a large stretch of the Blue Reach, the southern Wailing Woods and Southern Stirland. While no bridge stands here to cross the nearby river, the fortress maintains a ferry for those with crowns who wish to cross.</xsl:attribute>
	</xsl:template>

	<!--Stirland 4 towns 23 villages 5 castles-->
	<xsl:template match="Settlements/Settlement[@id='town_ST1']/@text">
		<xsl:attribute name="text">{=2Mbj4zwa}Wurtbad rests on the banks of the river Stir and it´s the capital of the province. By far the most densely populated town in Stirland, it is also home to the crumbling Temple of Myrmida. The nobility and people of Wurtbad are famous for its suspiciousness and sombreness, as the lost province of Sylvania is too close for comfort. It is one of the few places where goods can be carried over the river, making it an excellent strategic checkpoint for anyone wishing to push onwards into the land.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_ST2']/@text">
		<xsl:attribute name="text">{=njEX3woL}Amongst the Haunted Hills by the source of the Black Run River, lies the small town of Leicheberg. The people here live in constant fear of its neighbour to the east, Sylvania. Its ruler, Count Petr von Stolpe, has faced the Undead many times in his life and takes many measures to prepare for their return. Many witch hunters and vampire hunters have taken up residence here as a result. The town is notable for hosting a far larger temple and Garden of Morr than the number of inhabitants would otherwise require, for Count von Stolpe feels it is his obligation to ensure proper burials for all who die in his demesne.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_ST3']/@text">
		<xsl:attribute name="text">{=NJJUFzHi}On the border of traditional Sylvania lies the town of Siegfriedhof. Nestled between the Hunger Wood’s fringes and the Svarsee, it has historically commanded a strategic position in the Eschenstir basin. The town is overseen by the High and Chivalric Order of Deserved Rest, better known as the Raven Knights, whose Grandmaster personally sees to the protection of the people here. Stewardship over Siegfriedhof was granted to the Morrian templars by the Elector Count of Stirland, in gratitude for the Order's contribution in the Battle of Hel Fenn, 400 years prior. The town is also the site of the Abbey of Blessed Aethelbert the Vigilant. Due to the significant cult presence of the Morrians, Siegfriedhof is often used as a staging area for agents to keep watch over Sylvania. The people of Siegfriedhof are quite suspicious of strangers, and preemptive lynchings of unknown travellers have been known to occur.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_ST4']/@text">
		<xsl:attribute name="text">{=2LJIv90c}Mittlenburg sits at the foot of the black mountains, not far from the fallen Karak Varn and lake Black Water. The town is a modest one, the people here are very aware of their precarious position between Black Fire Pass and Sylvania, as such the town is decently fortified in preparation for these threats. The temples of Sigmar and Taal are well consecrated, and the Garden of Morr has a protective curtain wall around it. Many pilgrims on their way to take the trek up to the final temple of Skaranorak stop in Mittlenburg to purchase supplies.&#xD;&#xA;Special Scenes: no special scenes, besides maybe the temples, would be nice if one of the temples of Skaranorak was visible from a vantage point somewhere in the town.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_ST4']/@text">
		<xsl:attribute name="text">{=ApiV4i5Y}Wördern is a small town hidden between mountains and valleys. The rough terrain makes expansion near impossible, but the intersection of the Old Dwarf Road and the Prager strasse makes passing along viable; not that it matters, as no outsider finds kindness in Wörden. The odd mootlander can occasionally be seen purchasing supplies for the road, but its main attraction is the Wörden Meat and Cattle auction house. It’s the only town in Stirland that can be smelled before it is seen.</xsl:attribute>
	</xsl:template>
	
	<!-- Mootland 1 town 4 villages -->
	<xsl:template match="Settlements/Settlement[@id='town_MT1']/@text">
		<xsl:attribute name="text">{=lCSH2KMk}Home of the Halflings and the Elder of the Mootland, which is the title preferred by Halflings as “Grand Count” sounds “too posh,” Eicheschatten is a collection of winding lanes along the banks of the Aver Reach at the end of the road from Wördern and Halstedt.</xsl:attribute>
	</xsl:template>

	<!-- Sylvania 2 towns 19 villages 7 castles-->
	<xsl:template match="Settlements/Settlement[@id='town_SY1']/@text">
		<xsl:attribute name="text">{=7YwfVfxY}The former Imperial capital of Sylvania has endured much upheaval through the ages. Formerly the home of the Imperial Elector Count Otto von Drak. After the establishment of the Von Carstein bloodline it became the seat of vampiric power in the Old World. Stained with the blood of all Von Carstein patriarchs who fought to become the castle’s next ruler. It is where Manfred Von Carstein resides. It is a dark lair to the terrible and occult. Adventurers often raid the castle seeking to plunder it’s secrets. Most meet a gruesome end within it’s cursed halls.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_SY2']/@text">
		<xsl:attribute name="text">{=AalOZAvu}According to many Vampire Counts, Waldenhof is the true seat of power for Sylvania. It is where many of the Vampires dwell. And where Vlad kept his seat of power. But times change. Manfred resides in Drakenhof. Waldenhof whilst still important and thick with undead is lesser compared to Drakenhof. The town is covered in a persistent, soupy gloom. A miserable, desolate atmosphere hangs over the land. And all mortals inside the town simply live day to day. Waiting for death.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_SY2_3']/@text">
		<xsl:attribute name="text">{=gdPxhU2j}When Sylvannia first fell to the Vampire Counts, the residents of Eschen built tall walls around their village. Digging in and fortifying against the cursed undead battering against their walls. Though they survived for a time, the Darkness is patient while flesh rots away. Eventually Eschen was overrun, it’s walls still standing but it’s people made to serve their new masters in death. Now the tall and impregnable walls of Eschen protect the vampires residing inside it.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_SY2_4']/@text">
		<xsl:attribute name="text">{=SSBh7CC4}Stephansdorp’s claim to fame is being the final resting place of an ancient vampire. Slain by the villagers long before Sylvania was covered in darkness. It is said that several vampires have tried to resurrect this mysterious vampire. Who’s name has been lost to mortal minds for many centuries, was said to possess great treasures now locked in his hidden tomb. Adventurers and dark forces alike have searched for this tomb to no avail.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_SY2_1']/@name">
		<xsl:attribute name="name">{=DxXXcm1g}Murieste</xsl:attribute>
	</xsl:template>

	<!--Wissenland 6 towns 6 castles 35 villages -->
	<xsl:template match="Settlements/Settlement[@id='town_WI1']/@text">
		<xsl:attribute name="text">{=0AI7UYxb}Nuln is the greatest industrial city of the Empire, producing the vast majority of the gunpowder weapons and artillery pieces used by the military, as well as the arms and armaments of the Imperial armies. Nuln is a centre for trade, as the trade from Southern Wissenland and Solland, Averland, as well as trade that comes through Blackfire pass or the Grey and Black Mountains must first pass through Nuln before reaching the rest of the Empire.. Nuln has served as the capital of the Empire for long periods of time and has historically received the support needed to truly become a metropolis. It is also the religious capital in the south for the Sigmarite Church, overseeing Wissenland, Stirland and Averland. The Elector-Countess of all of Wissenland makes her court here, while the provincial capitol remains in Wissenberg, she much prefers the comfort of Nuln to the ‘Po-faced Boughers’ of the Assembly of Wissenland.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_WI2']/@text">
		<xsl:attribute name="text">{=KxVne8A1}Pfeildorf, meaning 'arrow town' in Menogothic Reikspiel is the former capital of the destroyed Grand Province of Solland. The city has had a long and troubled history, and as such a visitor can feel the burden of time on the shoulders of its inhabitants. Once Pfeildorf was as grand a city as Wissenburg and Solland as rich a province as Averland or Stirland. After an Orc invasion in the early 18th century killed off most of the nobility and sent the majority of its population into flight, Pfeildorf and the former province was informally split between Wissenland and Averland. Emperor Magnus the Pious in the 24th century attempted to restore Solland, defining its borders with Averland and Wissenland and reconstituting it as the Grand Barony of Solland. However, Solland still remains heavily intertwined with Wissenland and despite several legal agreements is in reality a part of Wissenland. Today Pfeildorf is the centre for the Sudenland wool trade, founded along the waters where the upper Reik and the River Soll meet enables the city to be a natural place for local wool and dwarf trade from the southern grey mountains to be loaded onto ships destined for Nuln and farther.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_WI3']/@text">
		<xsl:attribute name="text">{=p1xjq5FF}Kreutzhofen is a small town that lies on the crossroads of three major routes of travel. To the west heading into Bretonnia is the Montdidier Pass, to the East is the Winter’s Teeth Pass, which leads through the mountains and down into the central Border Princes. Heading southwest under the Vaults is the Alimento Tunnel; a three hundred mile long underground waterway that connects Kreutzhofen with the Miraglianese town of Campogrotta, and serves as the source for both the River Soll in Wissenland and the River Cristallo in Tilea. Kreutzhofen is a quaint town and a wealthy one thanks to the flow of trade. The town’s ruler is Count Bruno Pfeifraucher, the latest Pfeifrauchers in a long line of them to have ruled over Kreutzhofen.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_WI4']/@text">
		<xsl:attribute name="text">{=xdUqALpt}Meissen is a small but incredibly wealthy town situated in Old Solland, at the end of the Granite pass and on the shores of the river Soll. Meissen is famous for its silverware including goblets, tableware and jewellery. Thanks to its ties to Karak Norn, the city has a near unlimited supply of silver ore and some of the best Silversmiths in the southern empire and many Grey Mountain Craft-Dwarfs are found here. Its river port is the largest port on the length of the river Soll, and it serves as the focal point of all trade heading north from a large region south of the city. As a result, the Silversmiths’ Guild here is extremely wealthy and influential. The Guild does most of their business out of the dwarf constructed and fortified Guildhaus, which is said to be where the guild stores most of its silver ingots for later use by its members. Meissenburger silverwork is notable enough that occasionally the town plays host to Elector-Countess Emmanuelle von Liebwitz, who never fails to purchase the best of what is on offer at the time.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_WI5']/@text">
		<xsl:attribute name="text">{=2spngsqH}Geschburg is a small town on the banks of the River Soll. The Toppenheimer family maintains a garrison here, as its central location in Wissenland and the presence of the ferry across the Soll makes it an important site to hold in the region. Nearby lies the site of Old Solland’s defeat, for it was in the hills east of Geschburg that eight hundred years ago an invading Orc Warboss put the Elector-Count of Solland and most of his immediate family to the sword.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_WI6']/@text">
		<xsl:attribute name="text">{=8f54JOBX}The small town of Erbshauen was established by Wissenlanders after the fall of Old Solland, or Sudenland as the people of Erbshauen call it. The lands outside the town are tilled for crops and are irrigated by the River Oggel. While not in the Oggelland, Erbshauen participates in fairly extensive trade with the communities there.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_WI1']/@text">
		<xsl:attribute name="text">{=4PCaGZ7q}Within sight of the Black Mountains, where the waters of the Soll, Sonne, Aulen and Hornberg meet, is the town of Wusterburg. Wursterburg caters to the many Black Dwarfs from Karak Hirn that pass through, on their way to Nuln and further. Wursterburg actually possesses a rather large community of Black and Imperial Dwarfs, This may be in part due to the site of the famous Bugman’s Brewery which sits just outside of Wusterburg. While this famous beer company was destroyed by a goblin horde, its memory goes on in the minds of those who can remember its taste. Wursterburg mourns this disgrace to the art of Brewery, yet the town remains important as a centre of trade and as one of the only ferries across the River Soll. Baron Manfred von Eigenhof is the ruler of Wusterburg, and is known to be decently wealthy by nobleman’s standards thanks to the flow of trade.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_WI2']/@text">
		<xsl:attribute name="text">{=qVfTbtjY}Nehren is a small fort established to guard the upper River Soll and the fertile pasture lands near the Wild Pass leading into the forest of Athel Loren.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_WI3']/@text">
		<xsl:attribute name="text">{=1BY1KAy2}Sonnefurt lies at the point where the River Sonne meets the River Soll. The castle here was built at some point after Magnus the Pious attempted to restore Old Solland, since then it has served as an invaluable defensive point to guard against Greenskins entering the Empire from the Icy Wind or Winter’s Teeth Passes.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_WI4']/@text">
		<xsl:attribute name="text">{=9agCUdRK}Mendelhof used to be a small Sollander village in the Oggelland, today a fort stands in place of the former settlement. Built on the east shores of the River Oggel, the fort was constructed in order to watch over the Oggelland Pass as well as the disputed land between Wissenland and Averland, which lies between the Oggel and the upper River Reik.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_WI5']/@text">
		<xsl:attribute name="text">{=Gb8YkZ3D}Kolbhugel was established a stopover between Wusterburg and Waldbach, eventually a former Elector-Count of Wissenland saw fit to establish a permanent garrison here, both to help combat highwaymen and to use the site to send reinforcements to either Mendelhof to Sonnefurt should they require assistance.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_WI6']/@text">
		<xsl:attribute name="text">{=E9xaQBDr}Staig is a small fort established to watch over the upper Reik. Over the years the garrison here has stopped many goblin river pirates from travelling deeper into the empire.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_WI1_4']/@name">
		<xsl:attribute name="name">{=0cJib5M5}Dotternbach</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_WI4_3']/@name">
		<xsl:attribute name="name">{=JUdrv4gA}Osterzell</xsl:attribute>
	</xsl:template>

	<!--Talabecland-->
	<xsl:template match="Settlements/Settlement[@id='town_TB1']/@text">
		<xsl:attribute name="text">{=Jbtowctk}Talabheim, known in ancient times as Taalheim, which means Taal's Victory, is the capital city of the Grand Duchy of Talabecland. Talabheim lies deep within the Great Forest of the Empire, and as such earned its name as the Eye of the Forest, like the eye of a mighty storm, the crater being an island of calm amidst the surrounding danger. The city itself is built within a huge shallow crater called the Taalbaston, which is many miles across, whose outer edge formed a large rocky rim and a natural wall. This wall has been built up and fortified with many tall gun towers and effectively marks the boundary of the city itself. The land inside is extensive and includes fertile farmlands, a lake filled with fresh water as well as the grand city itself, ensuring that should a mighty enemy be able to breach through Talabecland's armies, so long as the enemy is held back by the great crater walls, the city and its proud people can withstand the onslaught of siege almost indefinitely. The River Talabec flows around the outside of the crater, and where it flows past the north-eastern edge of the wall, there is a fortified Imperial town known as Taalagrad and a deep harbour from which lies the river fleets. The largest of Talabheim’s temples is dedicated to Taal and to a lesser extent Rhya. Even though the primary place of Taal’s worship continues to be the Sacred Forest, worshippers who live within the confines of the city value an opportunity to seek spiritual enlightenment without making a trip to the other end of the crater.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_TB2']/@text">
		<xsl:attribute name="text">{=V0Vwb2wp}Chief town of the province ruled by Count Josef von Behring, Bek is normally a quiet trading town that exports lumber from the Great Forest and dried fish, and collects tolls for the use of its quays. Since the war began, the town and surrounding area has been flooded with over a thousand immigrants from Ostland, so many that they outnumber the townsfolk themselves. This has greatly strained resources and fights between locals and refugees are common and increasing in size. Count von Behring was an early supporter of Elector Count Feuerbach, and now he expects help in return. Feuerbach has sent a troop of his personal guard to Bek to maintain order, but rumours say that there will soon be a larger force arriving with instructions to invade Ostland “to restore order and allow the refugees to return home.” Order under whose rule is the open question.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_TB3']/@text">
		<xsl:attribute name="text">{=SvQ2Jds5}Along the river stir lies Krugenheim, a town that has bred many decent generals of the empire here today. The peasantry of Krugenheim provide the town with fish and crops while the barracks house many regiments of well trained state troops.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_TB4']/@text">
		<xsl:attribute name="text">{=AgUNKyCB}A moderately wealthy town south of the river Talabec, its villages don’t suffer too much from poverty and it collects healthy taxes from them. Its inhabitants are well fed and work hard to keep it that way.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_TB1']/@text">
		<xsl:attribute name="text">{=X6W6jd01}Between the River Stir and a part of the Great forest lies the minor fortification of Gostahof. Gostahof processes most of the timber that gets chopped from the great forest and that comes in from the east due to its fancy watermill of dwarfen make.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_TB1_1']/@text">
		<xsl:attribute name="text">{=fEfbPfiL}Bordering the river Stir and being at the centre of a crossroads, Missen sees alot of traffic from the surrounding villages. Missen has bits of forest a few ways away and the local populace earns a decent living trading timber.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_TB2']/@text">
		<xsl:attribute name="text">{=U04ar3H7}The southernmost settlement on the Old Forest Road is a small logging town with nearly 400 inhabitants. Hermsdorf is built near the crest of a low hill, overlooking the Wurtbad valley that extends 15 miles to the south. The local ruler, Baron Waldemar von Züten, spends most of his time carousing in Wurtbad and leaves routine administrative duties to his bailiff. Hermsdorf is situated at the junction of two major roads along the River Stir and receives a great deal of traffic.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_TB3']/@text">
		<xsl:attribute name="text">{=FPMLHxZa}One of the few stops along the Old Forest Road, Obelhem relies on its surrounding villages to provide it food. Most of the imported wheat and barley gets turned into beer for its inn.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_TB4']/@text">
		<xsl:attribute name="text">{=ZazgufBL}Castle Ravenstein stands a proud vigil looking over its northern neighbours. Surrounded by the river Talabec and the River Lug the Castle is well defended. Combined with its walls it is indeed a tough place to siege. Its inhabitants work hard to provide food for the castle.</xsl:attribute>
	</xsl:template>
	
	<!--Reikland-->
	<xsl:template match="Settlements/Settlement[@id='town_RL1']/@text">
		<xsl:attribute name="text">{=5A1SXzA6}Altdorf is at once perhaps the greatest city of the Empire and perhaps the entire known world, only rivaled in its size and importance by the likes of Marienburg, Nuln and Erengrad. Emperor Karl Franz rules both the Grand Principality of the Reikland and the Empire of Sigmar from this sprawling city, and what better a capital than the city founded by Sigmar himself two and a half millennia ago? Besides for its history, Altdorf is geographically the focal point of trade for three quarters of the Empire; for here all of the goods and travel from the states of Ostermark, Talabecland, Hochland, Stirland, Wissenland and Averland must go before they can move down the Reik to Marienburg and beyond. The city also hosts numerous knightly orders, the center of the Sigmarite church and the eight Imperial colleges of magic. Despite this prosperity and importance, Altdorf is a restless city: overpopulated and ripe for political violence, much of the fair city and its services have been pushed to their limits.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_RL2']/@text">
		<xsl:attribute name="text">{=w9dPkEcW}At the Confluence of the River Reik and the River Schilder sits the town of Schilderheim. Ruled by Graf Robert von Uhland, Schilderheim is an important river market down river from altdorf, being one of the last places that trade on the River Reik can stop before reaching Marienburg.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_RL3']/@text">
		<xsl:attribute name="text">{=H2jp3Yk0}At the head of the Axe Bite pass sits the town of Helmgart. Ruled by Margrave Reinhardt von Mackensen, the fortress town serves as both the economic and military border between Bretonnia and the Empire. Axe Bite is one of three mountain passes through the Grey mountains; as such the safety of passage through it is a primary concern. Helmgart itself is a market town, surrounded by several curtain walls. One of these walls traverses the entire width of the pass itself, meaning all travel must pass through its single gate or be stuck on either the Bretonnian or Imperial side of the border.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_RL4']/@text">
		<xsl:attribute name="text">{=qqWlOYkX}Bögenhafen is a prominent market town that sits on either side of the River Bögen. It is midway between Altdorf and Montfort allowing the town to maintain its economic importance through nearly any hardship. The northside of the town, known as the Pit, is the smallest and poorest section of Bögenhafen. The Southside of the town is where most of the wealth and all of the town’s important institutions reside, including its religious temples and town hall. A town council rules in the name of Graf Wilhelm von Saponatheim.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_RL5']/@text">
		<xsl:attribute name="text">{=7iTM7KaM}Ubersreik is one of the most important trade centers in Reikland. It sits astride and important bridge on the road from from Bögenhafen to Dunkelburg. Trade flows along the road as well as downriver to Auerswald, Grünburg, Kemperbad, and Altdorf. In addition, because it is located near Grey Lady Pass, Ubersreik is the ideal location for merchants travelling over the Grey Mountains to move their wares from the river to overland transportation, and vice versa.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_RL5_2']/@text">
		<xsl:attribute name="text">{=K3Z64kae}Tallerhof is a small village that sits where the Grey Lady Road meets the Dwarf Road. It astrides the river Teufel and marks the highest place where the river is still navigable by barge. If it were not for the dwarf trade passing through from Karak Azgaraz for Ubersreik, the village would have long been abandoned.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_RL6']/@text">
		<xsl:attribute name="text">{=NZRGrT43}On the northern bank of the River Grissen is the market town of Dunkelburg. Dunkelburg benefits from being along the Stimmigen canal, which allows access to many of the market towns in Reikland’s southern region. The town is known for its rustic feel which seems to be preserved in the town despite its continued increase in size. Unfortunately, Dunkelburg’s proximity to the Grey Mountains has doomed it to be plagued by Goblins, who regularly raid the town. One of the results of these raids is that the town has a much higher population of Orphans than many other parts of the Empire. These orphans are provided for by the von Wallensteins however, as long as they work in the town’s several Bleachfields that is.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_RL1']/@text">
		<xsl:attribute name="text">{=uwQASXxv}In the Suden Vorbergland of Reikland sits the market town of Stimmigen. Stimmigen sits on the river Ober, where the Stimmigen and Grey Lady canals meet. The town is especially famous for Ernwald, a variety of apples known for its sweet, yet tart taste, that the people of Stimmigen put into pies, pastries, crumbles and cider, as well as the infamous local dish ‘rat-apple stew.’ Stimmigen has a large population of Halflings, who specialise in the Ernwald cultivation as well as its derivative goods.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_RL2']/@text">
		<xsl:attribute name="text">{=GaxtQ8ch}The Grand Freistadt of Kemperbad is a major trade city that sits at the confluences of the rivers Riek and Stir. The city holds a commanding position over this portion of the river trade and is crucial to ensuring the southern empires continued economic prosperity. The city purchased its charter from Emperor Boris the Incompetent in 1066 IC, from then on being ruled directly by the Council of Thirteen which represents the largest merchants in town plus representatives from the local temples of Sigmar and Shallya.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_RL3']/@text">
		<xsl:attribute name="text">{=g2cQpbQP}Castle Reikguard is the fortress of the Grand Order of the Reiksguard Knights. It sits on the confluence of the rivers Teufel and Reik. In the time of Emperor Sigismund, while the Reikland was under threat of Gorbad Ironclaw, it was refortified and increased in size by dwarfen architects. It remains a powerful citadel capable of holding hundreds of soldiers and staff and serves as Karl-Franz’s summer home.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_RL4']/@text">
		<xsl:attribute name="text">{=ku9pC5id}Castle Grauenburg is the seat of Graf Wilhelm von Saponatheim’s rule over the central Reikland and his barony. It is a fortress along the river Bogen that protects Bogenhafen and other nearby locations from attack.</xsl:attribute>
	</xsl:template>

	<!--Middenland-->
	<xsl:template match="Settlements/Settlement[@id='town_ML1']/@text">
		<xsl:attribute name="text">{=q33cmYR6}The grand city of Middenheim, rumoured to have been founded by the god of war Ulric himself, is amongst the greatest and most heavily fortified cities within the Empire. Owing to it’s alleged origins the cities is also oft known simply as Ulricsburg, the Fauchslag or the City of the White wolf. It sits upon a giant mountain and houses both the seat of the Elector Count of Middenland and the Cult of Ulric. Since it’s founding it has never been conquered, it is the bastion of the Northern Empire.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_ML1_4']/@text">
		<xsl:attribute name="text">{=mAgVqoXw}Deep within the forests just north of Middenheim, these hardy folk toil endlessly to give themselves a semblance of a life. Many succumb to the various threats to be found deep within the trees, yet still the common folk stand defiant.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_ML2']/@text">
		<xsl:attribute name="text">{=rxQufRw7}One of the larger towns to be found within Middenland, Ahlenhof is one of the ferry stops on the famous Hindelin luxury line route from Altdorf to Talabheim, bringing with it a sizeable amount of trade and travellers from across the Empire. Much of the timber and agricultural trade from within Middenland passes through this town, to be sent onward to wherever it is needed most.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_ML2_3']/@text">
		<xsl:attribute name="text">{=0XGDfeML}Nestled nicely against one of the many tendrils that flow northwards from the river Talabec, this village is home to a hardy folk of cattle rearers, dutifully sending their beasts, or simply their meat, to the trade town Ahlenhof.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_ML3']/@text">
		<xsl:attribute name="text">{=Stz0eY6G}The former capital city of Middenland, when it was separate from Middenheim and known as the province of Drakwald, it is now a trade hub with a focus on glass-making. It is a place wreathed in history, as it was also once the seat of the Teutogen King, and capital of the Empire under the Drakwald Emperors. It is home to the great Carroburg greatswords and has a chapter house dedicated to the Order of the Blazing sun, as such it remains an imperious fortress within the Empire.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_ML3_3']/@text">
		<xsl:attribute name="text">{=FFw8aG0T}Far closer to the Midden Moors and nestled quite nicely against the edge of the Drakwald, lies the humble village of Dunkelbild. There is very little to remark from this place, but that itself is a blessing given the manner of beasts that prowl the forests.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_ML3_3']/@text">
		<xsl:attribute name="text">{=3QBvbU8k}Placed comfortably along one of the most used roads between Altdorf and Middenheim, this village has seen all manner of passers by. It is also one of the few villages to grow and offer it’s own wines, a welcome sight to any weary traveller.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_ML4']/@text">
		<xsl:attribute name="text">{=OHFGHFM7}Much of the timber that is harvested across the Northern Empire ends up within Grimminhagen, one of it’s primary industries is it’s woodcraft and it’s craftsmen have pride. Sitting on the border of Hochland and not far south from Middenheim, the handcrafted woodwork often makes it’s way to markets across both places.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_ML4_3']/@text">
		<xsl:attribute name="text">{=GJv6G0eG}Sandwiched neatly between the village of Tolzbeck and the city of Grimminhagen, Rosche is amongst the village timber suppliers that move goods directly to the craftsman who in turn provide handcrafted goods. It is also a village that helps to feed the hard working citizens of the town, while being protected in return.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_ML4_4']/@text">
		<xsl:attribute name="text">{=Hlp7OsAi}Not far from the town of Grimminhagen and on a commonly used path to the city, and onward to Middenheim, this village has had a relatively safe existence. Daily of life mostly consists of a subsistence farming and lumber felling, a similar story to be found amongst many such villages within the Northern Empire.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_ML5']/@text">
		<xsl:attribute name="text">{=5etWJ77v}An important town within Middenland for its placement, as a port town along the Altdorf-Middenheim road. While it trades in wine from local suppliers, traders from across the Empire pass through here on their way further into the Northern Empire and as such it is rarely a quiet town. Much of the timber trade from within Middenland takes places here, as it is then transported across the rest of the imperial provinces.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_ML5_2']/@text">
		<xsl:attribute name="text">{=E6Q7YhRX}Just north of the trade town Delberz, this village is amongst a handful responsible for providing agricultural products and directly feeding the citizens and various travellers who pass through the town on their way to or from Middenheim, along the Altdorf-Middenheim road</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_ML6']/@text">
		<xsl:attribute name="text">{=yVRNuROx}Not far from this town, a mere two miles to the east, lies sacred ground of a blessed monastery to the goddess Shallya. While the town itself is busy in trade, the majority of which is agricultural or fish, a larger portion of those who visit here do so to pray to the Lady in White or to seek the aid of her priestesses.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_ML1']/@text">
		<xsl:attribute name="text">{=GXqf5KCv}Not too far outside of Middenheim, this caste-fort stands watch over some of the more open lands of the Northern Empire, keeping a wary eye and a ready garrison for signs of any beast or raider who would trespass too close to the nearby city or its villages.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_ML1_3']/@text">
		<xsl:attribute name="text">{=vXhuVKIO}One of the trio of villages just shy of the capital city, and attached to the fort of Leichlinberg, this particular village is responsible for providing food to the hungry garrison of the fort who in turn keep a watchful eye over the surrounding lands.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_ML1_4']/@text">
		<xsl:attribute name="text">{=r6hivVvf}Lying just shy of the Great North Road and nestled against the murky waters of the Schadensumpf, this village sees a range of travellers passing by on their way to or from the wasteland and the free city of Marienburg.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_ML2']/@text">
		<xsl:attribute name="text">{=nr6KhCnc}A key garrison that is home to the Knighs Panther, this foreboding castle rises up out of the Drakwald along the Hochland border. Those who reside within its walls are held responsible for the defence of the primary route from Hochland to Delberz and who patrol the Howling Hills, an area infamous for its dangers.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_ML3']/@text">
		<xsl:attribute name="text">{=3sGcXmny}This castle stands vigil along the Great Northern Road to and from the Wastelands, the garrison that patrols its walls often watch a wide range of traders, travellers. Pilgrims and more pass by on their way to and from the Capital. More importantly it safeguards against a tribe of forest goblins that have made the surrounding Drakwald their home.</xsl:attribute>
	</xsl:template>

	<!-- Ostermark -->
	<xsl:template match="Settlements/Settlement[@id='town_OM1']/@text">
		<xsl:attribute name="text">{=K2etWc1J}Ever since the destruction of Mordheim, Bechafen has served as the provincial capital of Ostermark. Its buildings are tall and thin and are made of dark wood from the Great Forest, particularly the Gryphon Wood, which gives the buildings an eerie look to them. Although the wood from the Great Forest is unsavoury in colour, it’s hardy and makes a perfect material for many industries. Bechafen is particularly known for its exceptional boatyards and the well-crafted river vessels hailing from here. The dwarf king of Karak-Kadrin gifted Bechafen a pair of water-powered sawmills, allowing for the logs that are shipped downriver to the city to be turned into more easily transportable, and readily used, planks.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_OM2']/@text">
		<xsl:attribute name="text">{=yVp6hbLt}Eisental acts as an important trading hub between Ostermark and the dwarfs of Karak Kadrin. Due to its position along the River Blut and being the first stop for dwarfen traders, its waterways and nearby roads are typically well guarded, all but a large orc horde being easily handled by Eisental’s troops.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_OM3']/@text">
		<xsl:attribute name="text">{=1z6XHDKL}Along the Kadrin road lies Nagenhof, an imposing fortress city which guards the eastern foothills of Ostermark from Greenskin incursions. Nagenhof rarely sees any real threat of invasion however, this is accredited to the many slayer throngs which pass through the town, heading east to find their doom.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_OM4']/@text">
		<xsl:attribute name="text">{=siVf6Sqf}On one hand an imposing city, where tradesmen ply their craft and the markets are bustling with people, the sounds of hammers and the murmuring of people filling the streets. On the other, near the river, the banks are lined with docks and fishing boats, fishermen from all across Ostermark come here to provide for their families. Remer exports vast quantities of fish to various towns and villages within the league.</xsl:attribute>
	</xsl:template>

	<!-- Hochland -->
	<xsl:template match="Settlements/Settlement[@id='town_HL1']/@text">
		<xsl:attribute name="text">{=HRR5t3m0}As the provincial capital of Hochland, Hergig is a bustling hub nestled in the dense Drakwald Forest. Known for its masterful woodcraft and the iconic Hochland College of Sorcery, the city is a blend of sturdy woodland architecture and sophisticated fortifications. The streets are often filled with the sounds of craftsmen at work and the occasional marching of soldiers, reflecting Hergig's strategic importance and cultural richness. The town's architecture, traditionally of stone and brick, reflects its more modern aspirations, partly driven by the skillful contributions of its Dwarf Quarter. The Gate of the East bridge, a site of historical battles between Ostland and Hochland, marks its strategic importance to the city. Despite suffering greatly in the war, including a devastating siege that led to the fall of the great keep, Hergig is in a phase of rebirth.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_HL1_4']/@text">
		<xsl:attribute name="text">{=jrj9R8JA}Vodf is a remote settlement located in the thick forests of Hochland. It is primarily known for its hardy lumberjacks who bravely venture deeper into the forest than most other Hochlander, given its more central position in the Drakwald Forest. The village has a rustic charm, with study wooden structures and a close-knit community.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_HL2']/@text">
		<xsl:attribute name="text">{=7vc4CRz6}Breder is a significant Hochlander city located along the foothills of the Middle Mountains. Known for much of the city being built underground, in the foothills of the Middle Mountains. Known for its well-maintained walls, it serves as a key trading post for goods coming from the Middle Mountains and the Drakwald Forest. The city has a diverse population, a melting pot of dwarfs and native Hochlanders.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_HL3']/@text">
		<xsl:attribute name="text">{=INsjIEGw}As the second-largest settlement in Hochland, Krudenwald is a city marked by its history of resilience and hospitality. It's a hub for adventurers and mercenaries, offering a mix of rugged wilderness and urban amenities. The city's population is diverse, including a significant number of Dwarf Slayers, sellswords and other transient warriors.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_HL3_3']/@text">
		<xsl:attribute name="text">{=wLtgiwYo}This village is but one of many in the surrounding area that are placed along the border, and one of the primary pathways, into Middenland. It’s inhabitants often see patrols from both provinces pass through or along the border, as much of the trade from Hochland passes along its very road.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_HL1']/@text">
		<xsl:attribute name="text">{=urWipLyD}Just to the west of this castle stands the mighty Talabheim, just across the River Talabec. Much of the trade ships that sail the river can be seen from the castle walls, and the garrison is often called to patrol it’s shores.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_HL2']/@text">
		<xsl:attribute name="text">{=WdBwyFte}A lonely bastion overlooking the treacherous fens and hill country known as the Weiss Hills, it’s walls have seen and survived various sieges but stand resolute nontheless. It’s garrison numbers have lessened over the years but it’s no less able to safeguard its surroundings.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_HL3']/@text">
		<xsl:attribute name="text">{=PVWbM5Ht}Resting against the river Drakwasser and bordering Middenland, this fort oversees a myriad of surrounding villages in the hopes of safeguarding them, as there are many threats lurking within the forests and hills of Hochland.</xsl:attribute>
	</xsl:template>

	<!-- Nordland -->
	<xsl:template match="Settlements/Settlement[@id='town_NL1']/@text">
		<xsl:attribute name="text">{=ZfEtoLDZ}Salzenmund, the capital city of the Imperial Electoral Province of Nordland and a principality of the Empire in its own right, rests among hills from which flow the tributaries that join to form the River Salz, from which the city gets its name. The Elector Counts built tall castles at the top of these hills overlooking the growing city, once the meeting place for the western scions of the Was Jutone tribe. So narrow is the approach to the keep named the Jutone's Nest that it needs no surrounding curtain wall: the great keep just sits there, watching over the region. It is said by the locals that the Elector Counts can see the whole of his province from the window of his throne room, which faces west so he can keep an eye on the Elves of Laurelorn Forest.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_NL1_4']/@text">
		<xsl:attribute name="text">{=ZdCt3hOx}Oldenlitz is a small mining town in Nordland in the Empire. It is located south-west of Salzenmund on an island in Lake Damenlaub with a causeway stretching from the lake shore to the gatehouse which is wide enough for two wagons to pass.  It arose as a settlement at the centre of a cluster of salt mines.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_NL2']/@text">
		<xsl:attribute name="text">{=s2ksdu29}Dietershafen is a coastal city in Nordland and current seat of the Second Fleet of the Imperial Navy. Dietershafen is the Empire's most important coastal seaport. Its shipyards bustle with activity as shipwrights build new vessels for the Second Fleet. The celebrated Dietershafen Harbour Guard patrol and drill on the waterfront. Victuallers haggle for mountains of salt-dried stockfish, vast quantities of small beer, and crates of ship's biscuits. Overseeing all of this is Baron Ludolf Köhler, who hopes to build a fleet surpassing that of Bretonnia or Marienburg. The town is thriving. A steady stream of timber flows into the city and merchants make fat profits from free-spending sailors. Dwarf artisans work at considerable expense to improve the town walls -- historically a weak point in the port's defences. If you can use a hammer, sail a boat, or fight, you can find work in Dietershafen.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_NL3']/@text">
		<xsl:attribute name="text">{=QLGs0y9x}Neues Emskrank was the first port in Nordland to open in 2460 IC as a scheme to siphon off business from Marienburg. Failed miserably. Originally a small fishing village called Pugsblatter, the rights to the town were bought by an investment group headed by a charlatan named Jens-Pieter Riemanns, and which numbered among its backers three Elector Counts and several lesser but still wealthy and powerful nobles and Imperial merchant houses. Their plan was to create two ports that would siphon off traffic from Marienburg, thus cutting out the middlemen there and creating more profits for themselves. To this end, Pugsblatter was bought in 2460 and renamed Neues Emskrank. The local residents were forced out and resettled in the area of Wilhelmskoog, and colonists were brought in to reinvigorate the place. The cartel built houses and shops to give the city a fresh look, they invested in warehouses to handle the traffic surely coming their way, and they built new trading caravels that would be the vanguard of their fleet. Naturally, it was a total disaster.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_NL4']/@text">
		<xsl:attribute name="text">{=e0BcV25k}Located at the eastern extreme of the Drosselspule Bay, Nordland, in truth Norden is secretly being developed as base of operations for exploration and conquest of Lustria. It is also used in transporting prisoners to Leopoldheim in the Southlands. Norden has an advantage over other ports, in that it’s located close to the Middenheim-Erengrad road, a major thoroughfare for trade and other travel. Until recently, it was an open town where merchants from Middenheim, Nordland, and western Ostland traded goods with ports around the Sea of Claws using large flat vessels suited to the shallow sandy channels around Norden. But the town is no longer open to outsiders. Carts and wagons are turned away several miles from Norden by halberdiers from the State Army. A trading post at the Manann’s Crown coaching inn in Salzmorast allows merchants to trade without getting close to the town.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_NL5']/@text">
		<xsl:attribute name="text">{=PnQ2TyCr}Hargendorf is a sizable fishing town of Nordland in the Empire, located west of the port city of Dietershafen. It is the home of the Imperial Navy's Second Fleet. It also has the dubious honour of being the birth village of Archaon in 2390 IC.Hargendorf is some distance from the main settlements of Nordland, located on the east bank of the River Demst. It's a busy port, where ships stop for provisions and trade vessels buy salt, fish, sheep, and wool. Given its remote location, not much trade offloads at Hargendorf, which makes it ideal for more illicit business.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_NL5_1']/@text">
		<xsl:attribute name="text">{=Gh4n9WiR}Beilen is a lumberjack village next to the river Demst. Beilen has a good relationship with the Eonir. They have a contract with the elves that make it possible to get wood in certain parts of Laurelorn forest at its edges in exchange for grain. Their quick connection to Dietershafen en Hargendorf, two cities who are both in need of large amounts of wood for their ships, makes it possible to sell their timber at a quick rate.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_NL5_2']/@text">
		<xsl:attribute name="text">{=EcT7d8Eq}Almost forty kilometres south of Hargendorf, on the west bank of the Demst, is the abandoned village of Schlaghügel. Founded in the time of the grandfather of Baron von Hargenfels, the village was intended to gradually colonize the land west of the Demst. One of the attractions of the village was the presence of an ancient stone circle, of the type that was erected by the followers of the Old Faith a long time ago. The baron, himself a member of the cult of Mother Rhya, saw it as a sacred site and sought to preserve it and restore it to its full dimension. Forty families were sent there to rebuild their lives. Initially, a garrison protected the villagers, but after a few years of calm, it became apparent that the elves of Laurelorn tolerated the small community.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_NL5_3']/@text">
		<xsl:attribute name="text">{=4cXnZk3m}Ueblingen lies east of Hargendorf. Ueblingen is famous for its training in hunting dogs. many nobles form Nordland have a Ueblingen hunting dog. The dogs are good at tracking norscan invaders giving the local lords a great guide in tracking raiding parties and eliminating the threat.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_NL1']/@text">
		<xsl:attribute name="text">{=9FIHe1Sw}Manannsheim is an Imperial fort situated on a small island in the Drosselspule Bay of Nordland. It is also home to the Monastery of the Order of the Triton. The fort is heavily armed with canons and trained Nordland mariners.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_NL1_2']/@text">
		<xsl:attribute name="text">{=ZVAgUSiY}Ockholm is a community that has their roots in Norsca, 4 generations back longboats arrived from Norsca. It contained not a raiding party but a whole Norscan clan that fled Norsca. They were not chaos worshippers and came to seek a better live in the south. Suspicious at first the Northlanders kept their distance from them. But after a few years that showed how willing the Norscans were to intergrate the Northlanders accepted them. The Northlanders even had marriage's with the Norscans together they found the village of Ockholm. In times of need the descendants of the Norscan's are always willing to take up arms and defend their home country against invaders. Because of the rough conditions the Norscans lived in they were al trained in hunting. Hunting still runs in the veins of its current population even after 4 generations.</xsl:attribute>
	</xsl:template>

	<!-- Ostland -->
	<xsl:template match="Settlements/Settlement[@id='town_OL1']/@text">
		<xsl:attribute name="text">{=vftWtpEV}Wolfenburg is the capital of the Grand Principality of Ostland, and Ostland's largest settlement. Nestled in the foothills of the Middle Mountains, it is a beautiful city, and lies at the crossroads of trade moving overland between Kislev and the Empire. Its great walls provide protection from the evil things that lurk within the Forest of Shadows. The von Raukovs, who rule Ostland from Wolfenburg, have brought order and stability to the province after a succession of inept and suspect rulers.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_OL1_4']/@text">
		<xsl:attribute name="text">{=JXZqZcoA}The isolated village of Smallhof lies deep within the Forest of Shadows. It has the misfortune of being a frequent target of raids by beastmen under the terrible and feared Ragush of the Bloody Horn.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_OL2']/@text">
		<xsl:attribute name="text">{=9VNvWTPf}Wurzen is a town (sizeable, by Ostland standards) on the north bank of the Talabec River. It is a key riverport for the province, and profits from the lively trade along the Talabec's eastern stretches. It is also one of the major ferry crossings between Ostland and Talabecland to the south.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_OL2_3']/@text">
		<xsl:attribute name="text">{=BsupjbKz}Zundap is a small village that is a logging centre of North Talabec. It is also home to the hereditary country estates of the Barons Gauss.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_OL2_4']/@text">
		<xsl:attribute name="text">{=KOfFPh5D}Boven is a large village that lies in the western reaches of the ore-rich Sellonian Hills. As a fief, it has been contested by various minor noble families over the centuries.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_OL3']/@text">
		<xsl:attribute name="text">{=xAokYvwl}Ferlangen is an important market town in central Ostland, and a staging post on the route between Wolfenburg in the south and the northern coastal port of Salkalten. Its hereditary rulers are the Beckburg family. It is known nationwide as the home of its famous regiment of handgunners, the Fireloques of Ferlangen.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_OL3_3']/@text">
		<xsl:attribute name="text">{=UhO2XE05}Fleckeby is a farming village that sits at the junction between Ferlangen to the south, Bohsenfels to the east, and Salkalten to the north.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_OL3_4']/@text">
		<xsl:attribute name="text">{=r5YVebDa}Hasselhund is a temple-village between Ferlangen and Wolfenburg. It is the seat of the Morrite Lectors of Hasselhund.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_OL4']/@text">
		<xsl:attribute name="text">{=1WBOmgO5}Salkalten is one of two towns founded in a failed attempt to draw trade away from Marienburg (the other being Neues Emskrank in Nordland). Grand Prince Ivan von Königswald poured money into expanding Salkalten’s harbour and beautifying the buildings in 2455 IC. When the promised influx of trade failed to appear, Salkalten returned to its previous indolence and the town’s people, with typical Ostlander thriftiness, tore up much of the decorative façade and statues to repurpose. Salkalten maintains logging camps in the Forest of Shadows, and most of its industry today is in lumber and fishing, though it remains Ostland's key seaport. It is noteworthy as the home of the Sons of Manann knightly order.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_OL1']/@text">
		<xsl:attribute name="text">{=V7pFVqRS}Bohsenfels, also known as Little Middenheim, is a fortress-city located in the outer march of Ostland. It is built upon large rocks with caves and tunnels dug underneath, forming a subterranean labyrinth that allows the fortress to maintain enough supplies to hold out against a long siege.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_OL1_2']/@text">
		<xsl:attribute name="text">{=NjMVstmR}Birkewiese is a small town that benefits from trade along the Erengrad-Middenheim road. It is the hereditary seat of the Otterbein barons.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_OL2']/@text">
		<xsl:attribute name="text">{=SmgXI3mT}Castle Lenkster is a fort overlooking a border crossing that leads through the Middle Mountains to Hochland. It is said that the mountains where it stands were once cursed by the last Dwarf priests of Karaz Ghumzul. It maintains a permanent garrison of Ostlander border guards.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_OL2_1']/@name">
		<xsl:attribute name="name">{=UQSPJUF7}Eichewaldchen</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_OL2_1']/@text">
		<xsl:attribute name="text">{=9cgkyq5p}Eichewaldchen is a small village on the banks of the River Lachtbech. Much of its economy is in servicing Castle Lenkster just to its north.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_OL3']/@text">
		<xsl:attribute name="text">{=zymtQyD1}The castle-town of Grenzburg is the monastic home of the Sigmarite cult of the Purging Hammer. It guards one of Ostland’s main southern roads into Kislev.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_OL3_1']/@text">
		<xsl:attribute name="text">{=Q4zw3ORw}Vandengart is a small town west of Grenzburg, along the Wolfenburg Road. Its primary industries are trade and swine farming. It is the hereditary seat of the von Seeckt family.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_OL3_2']/@text">
		<xsl:attribute name="text">{=POhw8ZBI}Kurst is a village within the Forest of Shadows, north of the Wolfenburg-Grenzburg Road.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_OL3_3']/@text">
		<xsl:attribute name="text">{=JQLicdTj}Hereditary seat of the Barons von Pirkheimer, Levudaldorf is a centre of hemp warehousing in southern Ostland.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_OL4']/@name">
		<xsl:attribute name="name">{=LQJm4EbA}Roezfels</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_OL4']/@text">
		<xsl:attribute name="text">{=S8h5KG3l}The castle-town of Roezfels guards the western passes from Ostland through the Middle Mountains to Hochland. It has long been ruled by the staunchly traditionalist Margraves of the von Döbreiner noble house.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_OL4_1']/@text">
		<xsl:attribute name="text">{=Iii6Qaxa}Hereditary seat of House von Öbelstein, Öbelstein is primarily a centre of lumber milling. It lies between Roezfels to the west and Ferlangen to the northeast.</xsl:attribute>
	</xsl:template>
	
	<!-- Brass Keep-->
	<xsl:template match="Settlements/Settlement[@id='castle_BK2']/@text">
		<xsl:attribute name="text">{=Msd6uG8m}The Brass Keep is a very old fortress, indeed it's older than Sigmar himself. No one knows who built it, only that it has changed owners many times, until recently. During the Great War Against Chaos, the fortress was besieged by many Chaos warlords, many pledging their loyalty to Khorne, Slaanesh, Tzeentch, and Nurgle. While it was under siege, the followers of Nurgle corrupted the foundations, fermenting a plague within the fortress. The chaos forces would eventually succeed in taking the fortress, but were then cut off from reinforcements, sealing their doom within. The only survivors of such a glorious plague were the Nurgle devotees themselves, who now bask in the repugnant citadel.</xsl:attribute>
	</xsl:template>

	<!-- Tower of Shadows -->
	<xsl:template match="Settlements/Settlement[@id='castle_MT1']/@text">
		<xsl:attribute name="text">{=Ppnni4Mt}Hidden in the forest of Shadows lies the tower of the Necrach Melkhior the Ancient, After loosing the battle with his former student Zacharias the Everliving the tower was destoyed. After claiming the tower for himself Zacharias decided to rebuild the tower and use it for his study of the Grimoire Necronium.</xsl:attribute>
	</xsl:template>

	<!-- Laurelorn -->
	<xsl:template match="Settlements/Settlement[@id='castle_LL1']/@text">
		<xsl:attribute name="text">{=PpbAx87m}The tower of Se-Athil is an Eonir watchtower located atop a cliff above the Sea of Claws. This construction is a proud symbol of the Asur culture, the ancestors of the Eonir. Its formidable height allowing it to scry weather patterns as far away as Albion, and also monitors the Sunken Woods to the south, a refuge for mutant Humans. When Morrslieb waxes, the coastal forest is flooded by high tides, leaving behind brackish swamps and petrified trees that provide suitable habitat for Swamp Daemons. The tower it also serves as a reference point for imperial sailors sailing cabotage between Marienburg and Nordland. Se-Athil is the home of Kaia Fanmaris, the Warden of Storms and a Vicarius on the High Council of Laurelorn and called the Stormwitch by people of the Wasteland.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_LL1_2']/@text">
		<xsl:attribute name="text">{=r4rul3SW}Farisar's Rock is a fishing village on the rugged coast of the Claw Sea. It is the first stop among the imperial caravans that cross the road north of Laurelorn Forest. The Eonir who live here obtain an endless supply of fish from the sea, leaving the forest intact and unaltered. There are a series of caves in the north coast that can only be entered at low tide. The Eonir leave offerings to Mathlann in the caves. Occasionally, Norscan raiders use the caves to hide their loot in bad weather.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_LL2']/@text">
		<xsl:attribute name="text">{=eYoGCrxk}The Wardens of the Frost live nomadically so they can manage the shared forests and ensure that no Imperials settle east of the Demst River. Despite their wandering nature, it is common to see them in the vicinity of Aroth Loren. This Eonir fortress is their bastion against Nordland's constant efforts to claim this territory for their nation. And also against occasional hordes of Greenskins and Beastmen.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_LL3']/@name">
		<xsl:attribute name="name">{=SfKNumgV}Aroth Hanor</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_LL3']/@text">
		<xsl:attribute name="text">{=BqoEkOpy}The south of the Laurelorn is perpetually wet due to the Misty Hills and the adjacent Schadensumpf swamp. Lord Galenstra's kiths vigilantly patrol the Rain Protectorate from their stronghold on Aroth Hanor, often venturing beyond the Great Northern Road to fight Greenskins and Beastmen in the forest of Drakwald. The Eonir warriors of the Warden of the Rains emerge like ghosts from the mist and protect weary travelers. The most superstitious of the swamp dwellers pay tribute to the Wardens of the Rains, and some even revere them as magical beings."</xsl:attribute>
	</xsl:template>

	<!-- Wasteland -->
	<xsl:template match="Settlements/Settlement[@id='town_WA1']/@text">
		<xsl:attribute name="text">{=spaRBcyx}Marienburg is one of the greatest human cities in the Old World, and possibly the wealthiest, rivalled only by Altdorf, Erengrad, Miragliano, and the richest cities of Araby. Situated at the point where the River Reik enters the Sea of Claws, Marienburg is the only route for maritime trade to efficiently leave or enter the Empire. The city itself sits on a series of islands connected together by bridges and boat travel. To the north and south, the Vloedmuur wall sits just off the coast to defend the city from flooding and attacks by land. The wall is an ancient one, originally built by elves. The modern wall has been built and rebuilt several times atop the old elven foundations and the Directorate - Marienburg’s executive council - has spent a great fortune modernising its gates and redoubts. The defence of the city from attacks along the Reik, or from the Manaanspoort Sea, falls on Marienburg’s substantial navy. Just a century ago, the Wasteland was one of the jewels of Sigmar's empire, but after generations of benign neglect by a series of successive emperors, the merchants and burghers of Marienburg declared their independence. Emperor Wilhelm III launched several unsuccessful expeditions against the separatist province, all of which failed, culminating in independence being granted by treaty in 2429. Today, Marienburg is ruled by its legislature, the Stadsraad, and its executive council, the Directorate. Under this ‘republican’ rule, trade has continued to flow through Marienburg and many consider the city to be in a golden age. It is protected by its reputation of being nearly ungovernable and its varied mercenary forces, as well as by the River Reik and the marshes and swamps around. Nevertheless, the new Emperor, Karl Franz, may want to accomplish what his great-great-grandfather was unable to do. At the same time, Bretonnian dukes have made attempts in the past to incorporate Marienburg into their domains; who knows if King Louen will make an attempt of his own to expand the Marches of Couronne?"</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_WA1_4']/@text">
		<xsl:attribute name="text">{=msvHGKWr}Klessen is a small village that sits on the road between Marienburg and Giseroaux. The people here raise sheep for their wool and earn some income on the side providing a safe place to stay to travellers on their way to and from Marienburg.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_WA2']/@text">
		<xsl:attribute name="text">{=1beQzNau}At the end of the Old North road, on the coast of the sea of claws and the Wasteland’s border with Nordland and Middenland, is the Barony van Buurens, the last noble house of old Westerland. Baron van Buurens will tell anyone that Aarnau and its people are the guardians of the Wasteland, though for many decades no one has been quite sure what exactly they are defending against. The city itself is well fortified, and has seen off many Norscan warbands over the years. The State Troops of Aarnau are well drilled, professional men drawn from soldiers for hire and the local militia. While derisively referred to as the ‘Peacocks’ due to their resplendent uniforms provided by the Baron, they are fine warriors who have faced down highwaymen, outlaws and worse in the nearby Tumble Downs.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_WA2_3']/@text">
		<xsl:attribute name="text">{=3oZjjO24}Oostwold is a small town on the border between the Barony of Aarnau and Freistadt Marienburg. There is nothing particularly notable about this area besides for that truly. Travellers will find that Oostwold helpfully demarcates the friendly wastelanders from the unfriendly ones. Northern Wastelanders have too many past experiences with foul raiders from the north and tricksters from the south and east to trust strangers.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_WA1']/@text">
		<xsl:attribute name="text">{=Cb3ycQO3}Fort Solace is a fortified lighthouse across the Manaanspoort sea from Reaver’s point. It is owned and operated by the Wasteland Import-Export exchange in Marienburg, who maintain a governor and private garrison here. Fort Solace is a relatively new settlement, constructed in response to Almshoven’s abandonment and the destruction of its lighthouse. Most ships will stop here if arriving too late in the evening to make it into Marienburg, few will stop here with the intention of bypassing Marienburg all together on their way to Norsca or Kislev.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_WA1_2']/@text">
		<xsl:attribute name="text">{=qXdyuODl}The tollhouse here at the edge of the Laurelorn forest is owned by the Wasteland Import-Export Exchange. Its purpose is to tax goods coming into and out of the Wasteland, as such there is typically a line of merchants here during the day waiting in queues. Its well known that the Wasteland’s ‘Chang uses the toll collected here to discourage merchants from bypassing Marienburg.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_WA2']/@text">
		<xsl:attribute name="text">{=2TxUmfoK}Fort Bergbres demarcates the border between the Wasteland and Bretonnia. As part of a deal between the Duke of Gisoreux and Marienburg’s Directorate, the tolling station is operated by both the excise men of the Wasteland and Gisereux's roadwardens. Both the excise men and the roadwardens are tasked with seeing to the safe flow of trade through the Gisoreux gap and along the Bitter Moors, but they are notorious for inaction unless suitably ‘paid’ up-front, giving credence to the nickname ‘Fort Beg-Bribe.’ While the tolling station is neutral ground, the fort itself is just over the border in Marienburg’s favour, as such the wealthy city-state has maintained a formidable garrison here.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_WA2_1']/@text">
		<xsl:attribute name="text">{=rBCBAyiS}Halsdorph was once a major farming town, surrounded by fertile lands and blessed by Taal with good weather. One night however, the land shook and the swamp swallowed much of the town and nearly all of its farmland. Today, Halsdorph is a forgotten community of hollowed-eyed peasants, forgotten even by the meticulous tax men of the Wasteland.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_WA2_2']/@text">
		<xsl:attribute name="text">{=3nxkMBMf}At the foot of the northern grey mountains, south of Gisoreux gap is the mining settlement of Erlach. It is the only community that travels by land from the Reikland to Marienburg could potentially stop at, however the village is off of the road some ways and built around its mine tunnels and pits.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_WA2_3']/@text">
		<xsl:attribute name="text">{=4C1tHiPh}Merxheim is a forgotten corner of the Reik basin situated within the edge of the Reikwald Forest. Its out of the way nature is likely why it has not been contested for control by the Empire, as such the people here make what living they can in the isolated region, with only occasional visits from the Excise men to remind them their overlords sit in Marienburg.</xsl:attribute>
	</xsl:template>

	<!-- Bretonnia -->
  	<!-- Couronne -->
	<xsl:template match="Settlements/Settlement[@id='town_CO3']/@text">
		<xsl:attribute name="text">{=PrutPtzV}Hendaye is a big castle bordering the sea of chaos to the west. Hendaye is build on a high cliff giving them a nice view on the sea. Its high position gives it a defensive advantage for attackers from the sea side which is almost impossible. They have focused their main defences on their eastern side a narrow path leading towards the castle. making it a killing zone for any invading army. Their beaches have a small shipbuilding wharf creating fishing ships. Hendaye has a lot of fertile ground surrounding it, Giving the city a high storage of crops. Due to its large fishing fleet its also rich in fish.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_CO3_1']/@name">
		<xsl:attribute name="name">{=47sdMrSk}Alencon</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_CO3_1']/@text">
		<xsl:attribute name="text">{=bqiF1ea4}Alecon is a small village inbetween the river Sannez and the sea of chaos. They supply most the wood for the shipbuilding wharf in Hendaye.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_CO3_2']/@name">
		<xsl:attribute name="name">{=fRfWHORI}Caen</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_CO3_2']/@text">
		<xsl:attribute name="text">{=p2MXNudZ}Caen is a village south of hendaye and north of beauchamps. Most villagers of Caen en Beauchamps work in the same mine inbetween their village.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_CO3_3']/@text">
		<xsl:attribute name="text">{=vJSiVOnW}Beauchamps is a village south of Caen and north east of L'anguille. They mostly produce iron ores. They share the mine with the villagers of Caen who they see as lesser miners.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_CO1']/@text">
		<xsl:attribute name="text">{=vh6xzBUC}The castle of Brillionne was founded by Baron Lucus of Brilloinne. He was a sacred Grail Knight of Bretonnia. Lucus earned great renown as a pious Questing Knight. Travelling across the length and breadth of the Old World, he recovered many cursed items, trinkets and dark artefacts of sorcerous power. Lucus secured these unholy weapons within a sacred Grail Chapel near the shores of Couronne, about which he built a great Castle. For preventing the evil-hearted from wielding these powerful relics, Lucus was found worthy to sup from the Grail, joining the ranks of the Grail Knights and becoming a living saint. Meanwhile, his deeds as a mighty warrior had become legendary as far away as the Empire. Even after the Baron's death, an entire army of Battle Pilgrims attended his chapel night and day.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_CO2_1']/@name">
		<xsl:attribute name="name">{=sbiNufWr}Bruleaux</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_CO3']/@name">
		<xsl:attribute name="name">{=Tfu3gdlx}Castle Tancred</xsl:attribute>
	</xsl:template>

	<!-- L' Anguille -->
	<xsl:template match="Settlements/Settlement[@id='castle_LA3']/@text">
		<xsl:attribute name="text">{=puNtqKy9}Huddled on the border of Couronne along the Sannez River, Castle Sannez protects the eastern border of the dukedom of L’Anguille from any threats that would come from the east. However it is not really needed, due to the Dukedom of Couronne being very protective of its own border.</xsl:attribute>
	</xsl:template>

	<!-- Lyonesse -->
	<xsl:template match="Settlements/Settlement[@id='town_LY1']/@text">
		<xsl:attribute name="text">{=qDtjIUL3}The ducal seat of Lyonesse is situated on an island off the northwest coast. The castle's ancient walls, bathed by the sea at high tide, allow small boats to sail right into the outer courtyard. The inner courtyard, elevated and perpetually dry, leads to the Great Keep perched at the island's peak, offering a commanding view of the bay. Duke Adalhard’s grand feasts can be heard across the island, adding to the castle's lively atmosphere. As the tide recedes, the island's silhouette resembles a motte. A causeway from the main gate vanishes into the sea, embodying the legend that Lyonesse was once the heart of a grand city sunk by Manann's wrath, sparing only the virtuous Duke's citadel. Ruins are said to lie beneath the waves, guarded by strange creatures. The castle's formidable walls have withstood assaults from the undead of cursed Mousillon and the Dark Elves, resisting catapults, battering rams, and even the Empire navy's cannons.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_LY2']/@text">
		<xsl:attribute name="text">{=ponKhuXK}Originally a High Elven port city and trading enclave, Martel is situated on the southernmost coast of Lyonesse. The city's architecture is a testament to its Elven origins, with elegant spires, intricate carvings, and ethereal beauty that stands in stark contrast to traditional Lyonessan architecture. The section of old Tor Martel remains a bustling hub of trade and culture, attracting merchants and adventurers from across Bretonnia. The Elven influence is evident in the city's meticulous design and the enduring grace of its structures. Meanwhile, the city's marketplaces are vibrant with activity, offering exotic goods and crafts that reflect its rich heritage.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_LY3']/@text">
		<xsl:attribute name="text">{=WgdAl7hq}Soreil is a bustling city in Lyonesse's far northwest, known for its grand architecture and defensive position. Despite suffering from constant pirates, Soreil is a hub for both artisans and Lyonen marines, with a lively central square that hosts markets, festivals, and performances throughout the year.</xsl:attribute>
	</xsl:template>

	<!-- Gisoreux -->
	<xsl:template match="Settlements/Settlement[@id='castle_village_GX2_2']/@name">
		<xsl:attribute name="name">{=bxYIoUGd}Betton</xsl:attribute>
	</xsl:template>

	<!-- Artois -->

	<!-- Montfort -->

	<!-- Parravon -->
	<xsl:template match="Settlements/Settlement[@id='castle_PA1']/@text">
		<xsl:attribute name="text">{=rgEJufPO}Located on the border of Montfort, Castle Vingtiennes holds the northern province of Parravon from attack, and overlooks the river Grismerie and Massif Orcal.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_PA2']/@name">
		<xsl:attribute name="name">{=6xHv2u0Q}Castle Chambonnay</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_PA2']/@text">
		<xsl:attribute name="text">{=S8MfBBW7}Located on the border of Montfort, Castle Vingtiennes holds the northern province of Parravon from attack, and overlooks the river Grismerie and Massif Orcal.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_PA2_1']/@name">
		<xsl:attribute name="name">{=WVfqLu1f}Lesevre</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_PA2_1']/@text">
		<xsl:attribute name="text">{=8QiNc09t}Just south west of Castle Paravon lies the village of Lesevre, which hosts large deposits of Wood. Lesevre is very rich in wealth due to Castle Paravon needing coal to fuel the smithies for production of weapons and armour.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_PA2_2']/@text">
		<xsl:attribute name="text">{=udlKniy3}Directly in Castle Parravon’s sights sits the hamlet of Emilion directly alongside the Grismerie river. Emilion is a very small knit community that stays afloat from trading fish and food to other villages and Castle Parravon.</xsl:attribute>
	</xsl:template>

	<!-- Bastonne 巴斯托涅公国-->
	<xsl:template match="Settlements/Settlement[@id='castle_village_BA1_1']/@text">
		<xsl:attribute name="text">{=4unV6y1q}Ambert in the past has been raided, pillaged, and razed many times over in the past by Greenskin raiders from Massif Orcal. Calard of Garamont has sent many families to re-inhabit Ambert again, in a vain hope that the village will continue its production of timber from the Chalons Forest.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_BA3']/@text">
		<xsl:attribute name="text">{=m8UzI8Ck}n the Grismerie river, right across from the cursed city of Mousillon, Castle Riom stand firm directly in sight of the undead that many dread to plague Bretonnia. Many of the militia stationed in Castle Riom have heard dreadful noises coming from just across the river.</xsl:attribute>
	</xsl:template>

	<!-- Bordeleaux -->
	<xsl:template match="Settlements/Settlement[@id='village_BL1_3']/@name">
		<xsl:attribute name="name">{=Pkryzytr}Niort</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_BL1']/@text">
		<xsl:attribute name="text">{=w3cspBAU}De Turris Vigilans, the vigilant tower, is a centre of Verenan worship in Bretonnia. In addition to a large temple, the cult maintains a great lighthouse which is widely considered to be the most reliable in the world. The Priests of Verena here will often offer advice to those that seek their counsel, and are reputable for its benefits. The Cult and the Dukedom of Bordeleaux have the shared interest in watching the cursed land to their north, as a result; the Duke has established a garrison here and the fortifications are always maintained.</xsl:attribute>
	</xsl:template>

	<!-- Brionne -->
	<xsl:template match="Settlements/Settlement[@id='town_BE2']/@name">
		<xsl:attribute name="name">{=CC7h0Mhq}Chateau Frontière</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_BE2']/@text">
		<xsl:attribute name="text">{=pCJHBnIN}A site of many sieges from Norsca in ages past, ever since Alaron the Intrepid aided in the defence against Bjorn Irongrim and his army of mercenaries, the frequency of raids on Brionne have died down significantly. Due to its strategic location, Chateau Frontière holds many relics from the crusades.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_BE2_2']/@name">
		<xsl:attribute name="name">{=AFCQroOU}Gaillac</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_BE2_3']/@name">
		<xsl:attribute name="name">{=xqL0glyi}Vauvert</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_BE2_3']/@text">
		<xsl:attribute name="text">{=DJOI1X5R}A site of many sieges from Norsca in ages past, ever since Alaron the Intrepid aided in the defence against Bjorn Irongrim and his army of mercenaries, the frequency of raids on Brionne have died down significantly. Due to its strategic location, Chateau Frontière holds many relics from the crusades.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_BE1']/@name">
		<xsl:attribute name="name">{=X3u9dF3t}Castle Gransette</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_BE2_3']/@text">
		<xsl:attribute name="text">{=Tw7CJ4AD}Castle Gransette, the site of a great tragedy in ages past, a tragedy worthy of any song. The lady Isolde took the knight Sir Gaseric as her lover, but unfortunately her husband was not keen on becoming a superfluous husband. He locked Lady Isolde in her tower and challenged Sir Gaseric to a duel. He agreed, on the condition that it was held in the court so Lady Isolde could watch. The duel never happened, as the two knights were about to clash their steel a horde of zombies befell them. It is said that the zombies were defeated by a group of adventurers, but they never returned, and neither did any group that was sent to investigate. The local duke, the only living relative of Lord Gransette, has taken up residence after a substantial cleansing of the castle, despite this, the castle staff reports that the castle is still haunted, hearing footsteps and moans around corners. It was even reported by the groundskeeper, that on one fateful night, he saw the apparitions of Sir Gaseric and Lord Gransette duelling each other, still fighting for their long lost love.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_BE2']/@name">
		<xsl:attribute name="name">{=DavxCpzt}Castle Hossegor</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_BE2']/@text">
		<xsl:attribute name="text">{=s5mHCCHf}Castle Hossegor is more of a giant hospital than a mere fortress. Inside, nobles receive the finest treatments from priestesses of Shallya; while outside peasants beseech the many wisemen and healers that flock to the area. Some complain about receiving their treatment in the open air, but many of the practitioners believe this separation protects their noble clients and disperses the more vile miasmas brought here by the peasants.</xsl:attribute>
	</xsl:template>

	<!-- Aquitaine -->
	<xsl:template match="Settlements/Settlement[@id='castle_village_AQ2_1']/@name">
		<xsl:attribute name="name">{=gpsDJCJW}Biarritz</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_AQ2_1']/@text">
		<xsl:attribute name="text">{=JMCgKrJj}Biarritz is a town south of Aquitaine Castle, near the border with Brionne.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_AQ3']/@text">
		<xsl:attribute name="text">{=P6dZwg2i}Castle Curemonte stands proudly as one of Aquitaine's oldest strongholds. Adorned with ancient Aquitainian tapestries that trace back to the dukedom's founding, this captivating castle combines Aquitaine's typical grandeur with breathtaking views of the surrounding landscape.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_AQ3_1']/@name">
		<xsl:attribute name="name">{=Z4EO0fr4}Gradignan</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_AQ3_2']/@name">
		<xsl:attribute name="name">{=jutmL82g}Bergerac</xsl:attribute>
	</xsl:template>

	<!-- Carcassonne -->
	<xsl:template match="Settlements/Settlement[@id='castle_village_CC1_1']/@name">
		<xsl:attribute name="name">{=Y0F0Dmaj}Condom</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_CC1_1']/@text">
		<xsl:attribute name="text">{=xFw6rwO7}Nestled in the western Irana Mountains, Muret is a mining town that has become a fierce recruiting ground for Carcassonne Knights. The peasants are avid blacksmiths and miners, and will not shy away from a fight with Greenskins.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_CC2_3']/@name">
		<xsl:attribute name="name">{=TGJoUGE3}Escalquens</xsl:attribute>
	</xsl:template>

	<!-- Quenelles -->
	<xsl:template match="Settlements/Settlement[@id='town_QU1']/@text">
		<xsl:attribute name="text">{=bILMPcE9}Right on the border between the Land of Chivalry and the Forest of Loren, is Ducal Capital and Fortress-City of Quenelles. The city is so close to the Forest in fact, that the fey have demanded of the Quenellians to tear down the wall on the eastern side. Where the wall ends is met with a broad road and then immediately the fringes of the fey forest.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_QU1_3']/@name">
		<xsl:attribute name="name">{=dVoxbTMu}Bézier</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_QU2']/@text">
		<xsl:attribute name="text">{=C9FEOwRS}Nestled in the hills bordering Massif Orcal, sits the fortress town of Viefin. Viefin was established originally as a garrison to protect Quenelles from Greenskins that come down out of the mountains, as well as a position to launch attempts at founding new villages in the region.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_QU1_1']/@name">
		<xsl:attribute name="name">{=91FEsE3c}Merceaux Descloux</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_QU2_1']/@name">
		<xsl:attribute name="name">{=NAny2IBf}Nice</xsl:attribute>
	</xsl:template>

	<!--- Mousillon-->
	<xsl:template match="Settlements/Settlement[@id='village_MS1_3']/@name">
		<xsl:attribute name="name">{=VDdQzoJU}La Grange</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_MS1_1']/@name">
		<xsl:attribute name="name">{=2WyS8jLN}Le Rosier Noir</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_QU1']/@text">
		<xsl:attribute name="text">{=lvkbGVeu}Castle Hane is a tall hexagonal tower that stands near the Grismerie river, on a small island in the swamps. Lorded over by Aucassin, a long reigning noble of bretonnia, the surrounding villages are surprisingly livable by Mousillon standards. Surrounding the tower are many stables for Aucassin’s Vampiric Knights, and any who would visit the tower.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_MS2_1']/@name">
		<xsl:attribute name="name">{=ajSPfwUT}Yremy</xsl:attribute>
	</xsl:template>
	
	<!-- Blood Keep -->

	<!-- Athel Loren -->
	<xsl:template match="Settlements/Settlement[@id='town_AL1']/@text">
		<xsl:attribute name="text">{=Yu84qPBu}It is from the King's Glade that Ariel and Orion preside over the realm of Athel Loren. They do not rule alone, but with the aid of a council. There are currently fifteen lords and ladies upon this council, drawn from the hidden realms that blossom beneath the trees. The King's Glade is a vast and awesome clearing, surrounded by great oak trees of immense girth and antiquity.Although vast, this city is virtually invisible to the untrained eye. It merges into the forest and is easily missed by idle traveller and foe alike. Over the centuries, Spellweavers created a city among the trees around the King's Glade. The branches of the great oaks were induced to entwine into walkways and canopies, galleries and vaults. Thus are the buildings and chambers made entirely of living trees, branches and foliage. Beneath the earth, the same methods have been used to create great hollows between the interwoven roots of the trees.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_AL1_4']/@text">
		<xsl:attribute name="text">{=N1SkZIaO}Tal Merion is one of the smaller halls of The King's glade. Tal Merion lies on a important road between the Oak of ages and the Crag halls of Findol. Tal Merion is often visited by spellsingers who perform rituals in the vacinity.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_AL2']/@text">
		<xsl:attribute name="text">{=ZyGzlry0}Wydrioth, the Pine Crags, is a High Realm of Athel Loren, ruled by the Glade Lord Findol and Lady Evelyne. It is an embattled region, ever beset by the Dwarfs and Greenskins of the Grey Mountains. the Pine Crags are in fact a sprawling fortress. Here, the Elves have shaped citadels and strongholds from skycrown oaks, and endless leagues of gnarled and tangled walls from rockbriar. A maze of walkways and root-braced tunnels bind the various outposts together into a single living defence-work capable of repelling a full-blown Attack.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_AL3']/@text">
		<xsl:attribute name="text">{=SBLduKrO}Atylwyth is eternally in winter, and it is rumored that its inhabitant's hearts are made of ice. The Forest Spirits of the Winterheart are always sluggish or asleep, so the safety of the realm has always depended heavily on the elves. There are more Eternal Guard in Atylwyth than any other realm. It is a realm locked in the icy embrace of winter; its boughs are ever covered in a thick rime of frost, its glades always heavy with snow. Pale statues line every path, and mark the entrance to every hall. Some of these works are exquisite ice sculptures, shaped by an artisan's patient touch. Others are frost-caged mischievous naiads or spiteful kelpies, imprisoned by Elven magics in punishment for past misdeeds or to prevent future ones. These statues flow and reform when the eye does not rest upon them, the creatures inside ever seeking to escape.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_AL3_3']/@text">
		<xsl:attribute name="text">{=6ke2ktXZ}Inbetween the hall of Equos and the Hall of Coeth Mara lies the trade outpost hall of Tal mora. It contains great amounts of imported food to keep the Asrai of Atylwyth fed for there lands are not fertile and covered with ice.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_AL4']/@text">
		<xsl:attribute name="text">{=HSi5371k}Constructed by lord Anaereth during the Season of Rebirth, the Halls of Aneareth are the seat of Lady Tevaril and Lady Delynna’s power. Mighty halls constructed under a great tree in the center of the Witherhold, the Halls have been fortified over the passage of time, especially since the corruption of Addaivoch.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='village_AL4_4']/@name">
		<xsl:attribute name="name">{=k6vcnuwG}Tal Rond</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_AL5']/@text">
		<xsl:attribute name="text">{=D7KCg1a3}Fyr Darric, the Trickster's Wood, is a High Realm of Athel Loren, ruled by Lady Heggria of the Masque. Fyr Darric is the Elven god Loec the Trickster's holy ground within Athel Loren, the site of many shrines to his anarchic glory. Here too can be found the Feast Halls of the Wardance, the closest thing that the nomadic Wardancers of Athel Loren have to a home. As a result, the glades of Fyr Darric always resound to the sound of laughter.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='town_AL6']/@text">
		<xsl:attribute name="text">{=peSArcMN}Modryn, the Night Glens is one of the twelve kingdoms of Athel Loren. It is ruled by Lady Morlanna and Lord Arlas. The thing that sets Modryn apart from all other realms of Athel Loren is the fact that it is eternally night there. When the Morathi poisoned Ariel's soul, the darkness spread through the forest. However, the rest of the forest recovered with Ariel, but Modryn has remained dark ever since. The elves of Modryn are as dark as their surroundings. They practice dark magic there that would be forbidden in other parts of the Athel Loren.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_AL1']/@text">
		<xsl:attribute name="text">{=BNh7oaW4}Torgovann, also known as the Forge of Starlight is a realm in the Forest of Loren ruled by Lord Daith. Torgovann is the only area within Athel Loren where fire is a sacred symbol. Both a temple and a forge, Vaul's Anvil is used every night to forge weapons. The local Forest Spirits are drawn to the raging fire, but keep their distance, for they know it to be extremely dangerous.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_AL2']/@text">
		<xsl:attribute name="text">{=CzoBTKiD}Cavaroc, the Skymark Reaches, is a High Realm of Athel Loren, ruled by Lord Edrael of Equos. It is the land of the meadow glades, the sparsely-wooded grassland plains that lie on Athel Loren's south border. The Elves of Cavaroc are horsemasters as fine as any in the world, and the first to march when the war-horns are sounded. They are swift to act, and swift to anger as well. it is all but a certainty that the Glade Riders of the Skymark Reaches will be found at the head of that mad charge.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_AL3']/@text">
		<xsl:attribute name="text">{=pp2sbjnK}Argwylon, or The Moonspring Glades is one of the twelve kingdoms of Athel Loren. It is ruled by Lord Thalandor Doomstar.The amount of magic in Argwylon far surpasses that of any other of the Forest's realms. Here, miracles and wonders are performed daily. This is one rare place in Athel Loren where records of history are kept, similar to those in Ulthuan. The elves here are also the only ones in Athel Loren that know the ancient tongue of the Eagles. However, Argwylon's elves are notoriously arrogant, and consider themselves superior to all other elves. It is a rare occurrence when an elf of another realm talks to an elf of Argwylon.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_AL4']/@text">
		<xsl:attribute name="text">{=0h0lXOnj}Arranoc, also known as The Summerstrand is one of the twelve realms of Athel Loren. It is always summer in Arranoc, and in some parts night rarely falls. This causes the Forest Spirits in the Summerstrand to be especially strong. Arranoc is ruled by Amadri Ironbark, a former Wood Elf noble who later became a Tree Kin. Arranoc is under constant threat, because on its borders are the Vaults of Winter.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_AL5']/@text">
		<xsl:attribute name="text">{=d6pidF15}Anmyr, the Witherhold, is a High Realm of Athel Loren, ruled by Lady Tevaril and Lady Delynna. It is a realm in desperate decline. Many years ago, the foul Beastlord Morghur was slain in the heart of the region, and his blood corrupted the land for many leagues around. Ever since those days, the Wood Elves of Anmyr have been fighting a losing battle against Morghur's taint. Each year, the Beastmen warherds grow larger, increasing numbers of forest spirits are lost to madness and whole groves of trees wither and perish. In Athel Loren, the loss of even a single tree is a tragedy, so the ongoing legacy of Morghur's blood is cause for sorrow beyond words.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_AL5_1']/@text">
		<xsl:attribute name="text">{=mcRggZ8V}Under the perennially auburn leaves of this mighty guardian, the forest grows and grows eternally. This Tree is home to the elves of anmyr. Surrounded by the taint of Morghurs blood the acient tree Delliandra stands firm and protects those who live near it against corruption.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_AL6']/@text">
		<xsl:attribute name="text">{=w8hpYLxH}Cythral, the Wildwood, is a High Realm of Athel Loren, ruled by Lady Draya the Nighthawk. Not all the spirits of Athel Loren dwell in harmony with the Elves. Even now, thousands of years after the first great council, there are those beings who actively seek the Elves' destruction. Some revel in malevolence purely for its own sake, others would war against the Elves with all the cunning and might at their command, were they free to do so. It was to guard against this threat that the first Wood Elves planted a fence of waystones in the southeast of Athel Loren, creating the Wildwood — a prison for the most malevolent of forest spirits. Tyr Vanna serves as the main stronghold of the Wildwood hosting a strong security and many look outs.</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='castle_village_AL6_1']/@text">
		<xsl:attribute name="text">{=kwIrbTsF}Tyr Edrell serves as a lookout for escaped spirits and keeping a watch on Athel Lorens southern border. The Wildwood server as a prison and the Halls of Tyr Edrell will do everything to keep those spirits sealed.</xsl:attribute>
	</xsl:template>

	<!-- Hideouts -->
  	<!-- hideout forest -->
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_1']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_2']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_3']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_4']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_5']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_6']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_7']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_8']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_9']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_10']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_11']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_12']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_13']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_14']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_15']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_16']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_17']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_18']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_19']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_20']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_21']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_22']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_23']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_24']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_25']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_26']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_27']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_28']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_29']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_30']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_31']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_32']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_33']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_34']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_35']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_forest_36']/@name">
		<xsl:attribute name="name">{=3kDHrPPm}Cultist Hideout</xsl:attribute>
	</xsl:template>

	<!-- Mountain Bandit  Hideouts -->
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_1']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_2']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_3']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_4']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_5']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_6']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_7']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_8']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_9']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_10']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_11']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_12']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_13']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_14']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_15']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_16']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_17']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_18']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_19']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_20']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_21']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_22']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_23']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_24']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_25']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_26']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_27']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_28']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_29']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_mountain_30']/@name">
		<xsl:attribute name="name">{=MHKrMUuj}Deserter Hideout</xsl:attribute>
	</xsl:template>

	<!-- Beastmen  Hideouts -->
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_1']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_2']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_3']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_4']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_5']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_6']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_7']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_8']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_9']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_10']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_11']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_12']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_13']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_14']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_15']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_16']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_17']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_18']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_19']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_20']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_21']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_22']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_23']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_24']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_25']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_26']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_27']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_28']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_29']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_30']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_31']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_32']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_33']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_34']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_35']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_36']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_37']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_38']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_39']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_40']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_41']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_42']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_43']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_44']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_45']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_46']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_47']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_48']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_49']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_50']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_51']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_52']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_beastmen_53']/@name">
		<xsl:attribute name="name">{=2mHLKJFj}Ungor Camp</xsl:attribute>
	</xsl:template>

	<!-- bretonnia Bandit Hideouts -->

	<!-- Norscan Raider Hideouts -->
	<xsl:template match="Settlements/Settlement[@id='hideout_norscan_1']/@name">
		<xsl:attribute name="name">{=a19yqrxs}Norscan Raider Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_norscan_2']/@name">
		<xsl:attribute name="name">{=a19yqrxs}Norscan Raider Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_norscan_3']/@name">
		<xsl:attribute name="name">{=a19yqrxs}Norscan Raider Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_norscan_4']/@name">
		<xsl:attribute name="name">{=a19yqrxs}Norscan Raider Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_norscan_5']/@name">
		<xsl:attribute name="name">{=a19yqrxs}Norscan Raider Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_norscan_6']/@name">
		<xsl:attribute name="name">{=a19yqrxs}Norscan Raider Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_norscan_7']/@name">
		<xsl:attribute name="name">{=a19yqrxs}Norscan Raider Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_norscan_8']/@name">
		<xsl:attribute name="name">{=a19yqrxs}Norscan Raider Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_norscan_9']/@name">
		<xsl:attribute name="name">{=a19yqrxs}Norscan Raider Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_norscan_10']/@name">
		<xsl:attribute name="name">{=a19yqrxs}Norscan Raider Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_norscan_11']/@name">
		<xsl:attribute name="name">{=a19yqrxs}Norscan Raider Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_norscan_12']/@name">
		<xsl:attribute name="name">{=a19yqrxs}Norscan Raider Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_norscan_13']/@name">
		<xsl:attribute name="name">{=a19yqrxs}Norscan Raider Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_norscan_14']/@name">
		<xsl:attribute name="name">{=a19yqrxs}Norscan Raider Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_norscan_15']/@name">
		<xsl:attribute name="name">{=a19yqrxs}Norscan Raider Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_norscan_16']/@name">
		<xsl:attribute name="name">{=a19yqrxs}Norscan Raider Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_norscan_17']/@name">
		<xsl:attribute name="name">{=a19yqrxs}Norscan Raider Hideout</xsl:attribute>
	</xsl:template>
	<xsl:template match="Settlements/Settlement[@id='hideout_norscan_18']/@name">
		<xsl:attribute name="name">{=a19yqrxs}Norscan Raider Hideout</xsl:attribute>
	</xsl:template>
	
</xsl:stylesheet>