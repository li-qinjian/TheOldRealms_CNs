<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

	<xsl:template match="CraftingPiece[@id='default_weapon_guard']/@name">
		<xsl:attribute name="name">{=LkoTtfwo}None</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='default_weapon_pommel']/@name">
		<xsl:attribute name="name">{=LkoTtfwo}None</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='runefang_001_blade']/@name">
		<xsl:attribute name="name">{=Nj7Jeo01}Runefang Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='runefang_001_handle']/@name">
		<xsl:attribute name="name">{=F5w5kSap}Runefang  Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='runefang_001_guard']/@name">
		<xsl:attribute name="name">{=f1qkHBYc}Runefang Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='runefang_001_pommel']/@name">
		<xsl:attribute name="name">{=1iWNRqvN}Runefang Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='runefang_002_guard']/@name">
		<xsl:attribute name="name">{=0ihXoJtQ}Runefang Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='runefang_003_guard']/@name">
		<xsl:attribute name="name">{=0ihXoJtQ}Runefang Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='runefang_004_guard']/@name">
		<xsl:attribute name="name">{=0ihXoJtQ}Runefang Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='runefang_005_guard']/@name">
		<xsl:attribute name="name">{=0ihXoJtQ}Runefang Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='runefang_006_guard']/@name">
		<xsl:attribute name="name">{=0ihXoJtQ}Runefang Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='runefang_007_guard']/@name">
		<xsl:attribute name="name">{=0ihXoJtQ}Runefang Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='runefang_008_guard']/@name">
		<xsl:attribute name="name">{=0ihXoJtQ}Runefang Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='runefang_009_guard']/@name">
		<xsl:attribute name="name">{=0ihXoJtQ}Runefang Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='runefang_010_guard']/@name">
		<xsl:attribute name="name">{=0ihXoJtQ}Runefang Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='runefang_011_guard']/@name">
		<xsl:attribute name="name">{=0ihXoJtQ}Runefang Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='runefang_012_guard']/@name">
		<xsl:attribute name="name">{=0ihXoJtQ}Runefang Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_sword_001_blade']/@name">
		<xsl:attribute name="name">{=4sk0Yw8o}Reiksguard Knight Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_sword_001_handle']/@name">
		<xsl:attribute name="name">{=DCxPSm3C}Reiksguard Knight Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_sword_001_guard']/@name">
		<xsl:attribute name="name">{=fHhY8ueI}Reiksguard Knight Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_sword_001_pommel']/@name">
		<xsl:attribute name="name">{=hXqT5wyJ}Reiksguard Knight Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_sword_002_blade']/@name">
		<xsl:attribute name="name">{=4sk0Yw8o}Reiksguard Knight Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_sword_002_handle']/@name">
		<xsl:attribute name="name">{=DCxPSm3C}Reiksguard Knight Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_sword_002_guard']/@name">
		<xsl:attribute name="name">{=fHhY8ueI}Reiksguard Knight Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_sword_002_pommel']/@name">
		<xsl:attribute name="name">{=hXqT5wyJ}Reiksguard Knight Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_sword_003_blade']/@name">
		<xsl:attribute name="name">{=4sk0Yw8o}Reiksguard Knight Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_sword_003_handle']/@name">
		<xsl:attribute name="name">{=DCxPSm3C}Reiksguard Knight Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_sword_003_guard']/@name">
		<xsl:attribute name="name">{=fHhY8ueI}Reiksguard Knight Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_sword_003_pommel']/@name">
		<xsl:attribute name="name">{=hXqT5wyJ}Reiksguard Knight Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_circle_sword_001_blade']/@name">
		<xsl:attribute name="name">{=nWqjnAEa}Reiksguard Inner Circle Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_circle_sword_001_handle']/@name">
		<xsl:attribute name="name">{=C562NKxf}Reiksguard Inner Circle Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_circle_sword_001_guard']/@name">
		<xsl:attribute name="name">{=2RJW1f1G}Reiksguard Inner Circle Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_circle_sword_001_pommel']/@name">
		<xsl:attribute name="name">{=NwRJ7hEB}Reiksguard Inner Circle Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_circle_sword_002_blade']/@name">
		<xsl:attribute name="name">{=nWqjnAEa}Reiksguard Inner Circle Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_circle_sword_002_guard']/@name">
		<xsl:attribute name="name">{=2RJW1f1G}Reiksguard Inner Circle Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_circle_sword_002_pommel']/@name">
		<xsl:attribute name="name">{=NwRJ7hEB}Reiksguard Inner Circle Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_circle_sword_003_blade']/@name">
		<xsl:attribute name="name">{=nWqjnAEa}Reiksguard Inner Circle Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_circle_sword_003_guard']/@name">
		<xsl:attribute name="name">{=2RJW1f1G}Reiksguard Inner Circle Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_circle_sword_003_pommel']/@name">
		<xsl:attribute name="name">{=NwRJ7hEB}Reiksguard Inner Circle Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vc_khopesh_001_blade']/@name">
		<xsl:attribute name="name">{=Rq3gxYqn}hopesh Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vc_khopesh_001_handle']/@name">
		<xsl:attribute name="name">{=sK2y8ELp}Khopesh Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vc_khopesh_001_guard']/@name">
		<xsl:attribute name="name">{=8Sao85CM}Khopesh Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_warrior_sword_001_blade']/@name">
		<xsl:attribute name="name">{=WKm9DcLd}Skeleton Warrior Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_warrior_sword_001_hilt']/@name">
		<xsl:attribute name="name">{=PgRe9I96}Skeleton Warrior Sword Hilt</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_warrior_sword_001_guard']/@name">
		<xsl:attribute name="name">{=HSBm9QXK}Skeleton Warrior Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_warrior_sword_001_pommel']/@name">
		<xsl:attribute name="name">{=Old3OKJ1}Skeleton Warrior Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_warrior_sword_002_blade']/@name">
		<xsl:attribute name="name">{=WKm9DcLd}Skeleton Warrior Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_warrior_sword_002_hilt']/@name">
		<xsl:attribute name="name">{=PgRe9I96}Skeleton Warrior Sword Hilt</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_warrior_sword_002_guard']/@name">
		<xsl:attribute name="name">{=HSBm9QXK}Skeleton Warrior Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_warrior_sword_002_pommel']/@name">
		<xsl:attribute name="name">{=Old3OKJ1}Skeleton Warrior Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_warrior_sword_003_blade']/@name">
		<xsl:attribute name="name">{=WKm9DcLd}Skeleton Warrior Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_warrior_sword_003_hilt']/@name">
		<xsl:attribute name="name">{=PgRe9I96}Skeleton Warrior Sword Hilt</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_warrior_sword_003_guard']/@name">
		<xsl:attribute name="name">{=HSBm9QXK}Skeleton Warrior Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_warrior_sword_003_pommel']/@name">
		<xsl:attribute name="name">{=Old3OKJ1}Skeleton Warrior Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_warrior_sword_004_blade']/@name">
		<xsl:attribute name="name">{=WKm9DcLd}Skeleton Warrior Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_warrior_sword_004_hilt']/@name">
		<xsl:attribute name="name">{=PgRe9I96}Skeleton Warrior Sword Hilt</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_warrior_sword_004_guard']/@name">
		<xsl:attribute name="name">{=HSBm9QXK}Skeleton Warrior Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_warrior_sword_004_pommel']/@name">
		<xsl:attribute name="name">{=Old3OKJ1}Skeleton Warrior Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_warrior_sword_005_blade']/@name">
		<xsl:attribute name="name">{=WKm9DcLd}Skeleton Warrior Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_warrior_sword_005_hilt']/@name">
		<xsl:attribute name="name">{=PgRe9I96}Skeleton Warrior Sword Hilt</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='grave_guard_sword_001_blade']/@name">
		<xsl:attribute name="name">{=KUYIsK8e}Grave Guard Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='grave_guard_sword_001_hilt']/@name">
		<xsl:attribute name="name">{=wWYglgp6}Grave Guard Hilt</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='grave_guard_sword_001_guard']/@name">
		<xsl:attribute name="name">{=AqSnDFm7}Grave Guard Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='grave_guard_sword_001_pommel']/@name">
		<xsl:attribute name="name">{=2i37GXPk}Grave Guard Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='mannfred_sword_blade']/@name">
		<xsl:attribute name="name">{=UtCXTBxI}Mannfred Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='mannfred_sword_handle']/@name">
		<xsl:attribute name="name">{=QfgpDbJp}Mannfred Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='mannfred_sword_guard']/@name">
		<xsl:attribute name="name">{=1dzbWQo3}Mannfred Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='mannfred_sword_pommel']/@name">
		<xsl:attribute name="name">{=H5gAPUhm}Mannfred Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_001_blade']/@name">
		<xsl:attribute name="name">{=PNVFXrlw}Vampire Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_001_handle']/@name">
		<xsl:attribute name="name">{=qxo5zenc}Vampire Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_001_guard']/@name">
		<xsl:attribute name="name">{=lZkU9vsd}Vampire Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_001_pommel']/@name">
		<xsl:attribute name="name">{=NJPivptv}Vampire Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_002_blade']/@name">
		<xsl:attribute name="name">{=PNVFXrlw}Vampire Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_002_handle']/@name">
		<xsl:attribute name="name">{=qxo5zenc}Vampire Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_002_guard']/@name">
		<xsl:attribute name="name">{=lZkU9vsd}Vampire Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_002_pommel']/@name">
		<xsl:attribute name="name">{=NJPivptv}Vampire Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_003_blade']/@name">
		<xsl:attribute name="name">{=PNVFXrlw}Vampire Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_003_handle']/@name">
		<xsl:attribute name="name">{=qxo5zenc}Vampire Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_003_guard']/@name">
		<xsl:attribute name="name">{=lZkU9vsd}Vampire Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_003_pommel']/@name">
		<xsl:attribute name="name">{=NJPivptv}Vampire Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_004_blade']/@name">
		<xsl:attribute name="name">{=PNVFXrlw}Vampire Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_004_handle']/@name">
		<xsl:attribute name="name">{=qxo5zenc}Vampire Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_004_guard']/@name">
		<xsl:attribute name="name">{=lZkU9vsd}Vampire Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_004_pommel']/@name">
		<xsl:attribute name="name">{=NJPivptv}Vampire Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_005_blade']/@name">
		<xsl:attribute name="name">{=PNVFXrlw}Vampire Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_005_handle']/@name">
		<xsl:attribute name="name">{=qxo5zenc}Vampire Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_005_guard']/@name">
		<xsl:attribute name="name">{=lZkU9vsd}Vampire Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_005_pommel']/@name">
		<xsl:attribute name="name">{=NJPivptv}Vampire Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_006_blade']/@name">
		<xsl:attribute name="name">{=PNVFXrlw}Vampire Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_006_handle']/@name">
		<xsl:attribute name="name">{=qxo5zenc}Vampire Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_006_guard']/@name">
		<xsl:attribute name="name">{=lZkU9vsd}Vampire Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_006_pommel']/@name">
		<xsl:attribute name="name">{=NJPivptv}Vampire Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_007_blade']/@name">
		<xsl:attribute name="name">{=PNVFXrlw}Vampire Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_007_handle']/@name">
		<xsl:attribute name="name">{=qxo5zenc}Vampire Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_007_guard']/@name">
		<xsl:attribute name="name">{=lZkU9vsd}Vampire Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_007_pommel']/@name">
		<xsl:attribute name="name">{=NJPivptv}Vampire Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_008_blade']/@name">
		<xsl:attribute name="name">{=PNVFXrlw}Vampire Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_008_handle']/@name">
		<xsl:attribute name="name">{=qxo5zenc}Vampire Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_008_guard']/@name">
		<xsl:attribute name="name">{=lZkU9vsd}Vampire Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_008_pommel']/@name">
		<xsl:attribute name="name">{=NJPivptv}Vampire Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_009_blade']/@name">
		<xsl:attribute name="name">{=PNVFXrlw}Vampire Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_009_handle']/@name">
		<xsl:attribute name="name">{=qxo5zenc}Vampire Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_sword_009_guard']/@name">
		<xsl:attribute name="name">{=lZkU9vsd}Vampire Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='chaos_sword_01_blade']/@name">
		<xsl:attribute name="name">{=dq2ocbK6}Chaos Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='chaos_sword_01_handle']/@name">
		<xsl:attribute name="name">{=9yJZq38y}Chaos Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='chaos_sword_01_guard']/@name">
		<xsl:attribute name="name">{=4mpauH7z}Chaos Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='chaos_sword_01_pommel']/@name">
		<xsl:attribute name="name">{=8PhMHSqn}Chaos Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_sword_001_blade']/@name">
		<xsl:attribute name="name">{=ySRkiSvZ}Bretonnian Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_sword_001_handle']/@name">
		<xsl:attribute name="name">{=r0meOx8R}Bretonnian Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_sword_001_guard']/@name">
		<xsl:attribute name="name">{=HC6ENwxr}Bretonnian Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_sword_001_pommel']/@name">
		<xsl:attribute name="name">{=yRwup8xb}Bretonnian Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_sword_002_blade']/@name">
		<xsl:attribute name="name">{=ySRkiSvZ}Bretonnian Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_sword_002_handle']/@name">
		<xsl:attribute name="name">{=r0meOx8R}Bretonnian Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_sword_002_guard']/@name">
		<xsl:attribute name="name">{=HC6ENwxr}Bretonnian Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_sword_002_pommel']/@name">
		<xsl:attribute name="name">{=yRwup8xb}Bretonnian Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_lord_sword_001_pommel']/@name">
		<xsl:attribute name="name">{=BBRuUzrx}Glade Lord Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_lord_sword_001_handle']/@name">
		<xsl:attribute name="name">{=5KAFRySK}Glade Lord Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_lord_sword_001_blade']/@name">
		<xsl:attribute name="name">{=TgRvTZ2X}Glade Lord Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_sword_001_blade']/@name">
		<xsl:attribute name="name">{=vJBq9fKB}Wood Elven Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_sword_002_blade']/@name">
		<xsl:attribute name="name">{=vJBq9fKB}Wood Elven Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_sword_001_handle']/@name">
		<xsl:attribute name="name">{=34OIhyVM}Wood Elven Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_sword_002_handle']/@name">
		<xsl:attribute name="name">{=34OIhyVM}Wood Elven Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_sword_001_guard']/@name">
		<xsl:attribute name="name">{=NFIxVw5z}Wood Elven Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='de_sword_001_blade']/@name">
		<xsl:attribute name="name">{=7SaXfMiE}Dark Elven Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='de_sword_001_handle']/@name">
		<xsl:attribute name="name">{=SDRtAAv0}Dark Elven Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='de_sword_001_guard']/@name">
		<xsl:attribute name="name">{=ewrEtPet}Dark Elven Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='de_sword_001_pommel']/@name">
		<xsl:attribute name="name">{=5vLlCqjN}Dark Elven Sword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_sword_001_blade']/@name">
		<xsl:attribute name="name">{=DDpOBPqK}Ungor Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_sword_001_handle']/@name">
		<xsl:attribute name="name">{=zsqjJip4}Ungor Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_sword_001_guard']/@name">
		<xsl:attribute name="name">{=dPTBn1Dq}Ungor Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_sword_002_blade']/@name">
		<xsl:attribute name="name">{=DDpOBPqK}Ungor Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_sword_002_handle']/@name">
		<xsl:attribute name="name">{=zsqjJip4}Ungor Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_sword_002_guard']/@name">
		<xsl:attribute name="name">{=dPTBn1Dq}Ungor Sword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_sword_003_blade']/@name">
		<xsl:attribute name="name">{=DDpOBPqK}Ungor Sword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_sword_003_handle']/@name">
		<xsl:attribute name="name">{=zsqjJip4}Ungor Sword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_greatsword_001_blade']/@name">
		<xsl:attribute name="name">{=7HtR3Ll4}Empire Greatsword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_greatsword_001_hilt']/@name">
		<xsl:attribute name="name">{=VXLVmfgi}Empire Greatsword Grip</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_greatsword_001_guard']/@name">
		<xsl:attribute name="name">{=f4cAjutN}Empire Greatsword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_greatsword_001_pommel']/@name">
		<xsl:attribute name="name">{=aQH7pkmu}Empire Greatsword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_greatsword_002_blade']/@name">
		<xsl:attribute name="name">{=7HtR3Ll4}Empire Greatsword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_greatsword_002_hilt']/@name">
		<xsl:attribute name="name">{=VXLVmfgi}Empire Greatsword Grip</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_greatsword_002_guard']/@name">
		<xsl:attribute name="name">{=f4cAjutN}Empire Greatsword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_greatsword_002_pommel']/@name">
		<xsl:attribute name="name">{=aQH7pkmu}Empire Greatsword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='grave_guard_greatsword_001_blade']/@name">
		<xsl:attribute name="name">{=QCDSucaM}Grave Guard Greatsword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='grave_guard_greatsword_001_handle']/@name">
		<xsl:attribute name="name">{=aV97nQEu}Grave Guard Greatsword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='grave_guard_greatsword_001_guard']/@name">
		<xsl:attribute name="name">{=ZzcbIZ4m}Grave Guard Greatsword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='grave_guard_greatsword_001_pommel']/@name">
		<xsl:attribute name="name">{=PigdE5C8}Grave Guard Greatsword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_greatsword_001_blade']/@name">
		<xsl:attribute name="name">{=4RtTR4Hq}Vampire Greatsword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_greatsword_001_hilt']/@name">
		<xsl:attribute name="name">{=oHWINMSX}Vampire Greatsword Hilt</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_greatsword_001_guard']/@name">
		<xsl:attribute name="name">{=87HQ4FDd}Vampire Greatsword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_greatsword_001_pommel']/@name">
		<xsl:attribute name="name">{=nxt2j66f}Vampire Greatsword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='sword_de_lyonesse_blade']/@name">
		<xsl:attribute name="name">{=76xLXFNI}Sword de Lyonesse Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='sword_de_lyonesse_handle']/@name">
		<xsl:attribute name="name">{=g0J7Ohrm}Sword de Lyonesse Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='sword_de_lyonesse_guard']/@name">
		<xsl:attribute name="name">{=QX3zzaQ0}Sword de Lyonesse Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='sword_de_lyonesse_pommel']/@name">
		<xsl:attribute name="name">{=gdq1Hug3}Sword de Lyonesse Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_greatsword_001_blade']/@name">
		<xsl:attribute name="name">{=KJ9d8Nbv}Bretonnian Greatsword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_greatsword_001_handle']/@name">
		<xsl:attribute name="name">{=cDjNYnlo}Bretonnian Greatsword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_greatsword_001_guard']/@name">
		<xsl:attribute name="name">{=PbrEg3A6}Bretonnian Greatsword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_greatsword_001_pommel']/@name">
		<xsl:attribute name="name">{=K9QTcPJC}Bretonnian Greatsword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bret_squire_longsword_001_blade']/@name">
		<xsl:attribute name="name">{=Enmbghuk}Bretonnian Squire Greatsword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bret_squire_longsword_001_handle']/@name">
		<xsl:attribute name="name">{=FI1tLB8E}Bretonnian Squire Greatsword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bret_squire_longsword_001_guard']/@name">
		<xsl:attribute name="name">{=2B8w2tLn}Bretonnian Squire Greatsword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bret_squire_longsword_001_pommel']/@name">
		<xsl:attribute name="name">{=lD85LVwt}Bretonnian Squire Greatsword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bret_squire_longsword_002_blade']/@name">
		<xsl:attribute name="name">{=Enmbghuk}Bretonnian Squire Greatsword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bret_squire_longsword_002_handle']/@name">
		<xsl:attribute name="name">{=FI1tLB8E}Bretonnian Squire Greatsword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bret_squire_longsword_002_guard']/@name">
		<xsl:attribute name="name">{=2B8w2tLn}Bretonnian Squire Greatsword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bret_squire_longsword_002_pommel']/@name">
		<xsl:attribute name="name">{=lD85LVwt}Bretonnian Squire Greatsword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bret_squire_longsword_003_blade']/@name">
		<xsl:attribute name="name">{=Enmbghuk}Bretonnian Squire Greatsword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bret_squire_longsword_003_handle']/@name">
		<xsl:attribute name="name">{=FI1tLB8E}Bretonnian Squire Greatsword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bret_squire_longsword_003_guard']/@name">
		<xsl:attribute name="name">{=2B8w2tLn}Bretonnian Squire Greatsword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bret_squire_longsword_003_pommel']/@name">
		<xsl:attribute name="name">{=lD85LVwt}Bretonnian Squire Greatsword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='he_greatsword_001_blade']/@name">
		<xsl:attribute name="name">{=k3pR1tzR}High Elven Greatsword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='he_greatsword_001_handle']/@name">
		<xsl:attribute name="name">{=4ExjaGpy}High Elven Greatsword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='he_greatsword_001_guard']/@name">
		<xsl:attribute name="name">{=ntvUNiYx}High Elven Greatsword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='he_greatsword_001_pommel']/@name">
		<xsl:attribute name="name">{=8zyZ6Rmn}High Elven Greatsword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_greatsword_001_blade']/@name">
		<xsl:attribute name="name">{=9kGffKFf}Wood Elven Greatsword Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_greatsword_001_handle']/@name">
		<xsl:attribute name="name">{=OR7XsJb1}Wood Elven Greatsword Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_greatsword_001_guard']/@name">
		<xsl:attribute name="name">{=n6l1CmDo}Wood Elven Greatsword Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_greatsword_001_pommel']/@name">
		<xsl:attribute name="name">{=qaPZhJ6o}Wood Elven Greatsword Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='rapier_001_blade']/@name">
		<xsl:attribute name="name">{=3W3qqTqm}Empire Rapier Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='rapier_001_handle']/@name">
		<xsl:attribute name="name">{=xwxcHr05}Empire Rapier Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='rapier_001_guard']/@name">
		<xsl:attribute name="name">{=fEbccLNS}Empire Rapier Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='rapier_001_pommel']/@name">
		<xsl:attribute name="name">{=CAodgUpe}Empire Rapier Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_rapier_002_blade']/@name">
		<xsl:attribute name="name">{=3W3qqTqm}Empire Rapier Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_rapier_002_handle']/@name">
		<xsl:attribute name="name">{=xwxcHr05}Empire Rapier Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_rapier_002_pommel']/@name">
		<xsl:attribute name="name">{=CAodgUpe}Empire Rapier Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_rapier_003_blade']/@name">
		<xsl:attribute name="name">{=3W3qqTqm}Empire Rapier Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_rapier_003_handle']/@name">
		<xsl:attribute name="name">{=xwxcHr05}Empire Rapier Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_rapier_003_guard']/@name">
		<xsl:attribute name="name">{=fEbccLNS}Empire Rapier Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_rapier_003_pommel']/@name">
		<xsl:attribute name="name">{=CAodgUpe}Empire Rapier Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_rapier_004_blade']/@name">
		<xsl:attribute name="name">{=3W3qqTqm}Empire Rapier Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_rapier_004_handle']/@name">
		<xsl:attribute name="name">{=xwxcHr05}Empire Rapier Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_rapier_004_guard']/@name">
		<xsl:attribute name="name">{=fEbccLNS}Empire Rapier Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_rapier_004_pommel']/@name">
		<xsl:attribute name="name">{=CAodgUpe}Empire Rapier Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_rapier_005_blade']/@name">
		<xsl:attribute name="name">{=3W3qqTqm}Empire Rapier Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_rapier_005_handle']/@name">
		<xsl:attribute name="name">{=xwxcHr05}Empire Rapier Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_rapier_005_guard']/@name">
		<xsl:attribute name="name">{=fEbccLNS}Empire Rapier Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_rapier_005_pommel']/@name">
		<xsl:attribute name="name">{=CAodgUpe}Empire Rapier Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_axe_001_blade']/@name">
		<xsl:attribute name="name">{=wSKSymtU}Ungor Axe Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_axe_001_handle']/@name">
		<xsl:attribute name="name">{=ZUErKEsY}Ungor Axe Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_axe_002_blade']/@name">
		<xsl:attribute name="name">{=wSKSymtU}Ungor Axe Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_axe_002_handle']/@name">
		<xsl:attribute name="name">{=ZUErKEsY}Ungor Axe Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_axe_003_blade']/@name">
		<xsl:attribute name="name">{=wSKSymtU}Ungor Axe Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_axe_003_handle']/@name">
		<xsl:attribute name="name">{=ZUErKEsY}Ungor Axe Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_axe_004_blade']/@name">
		<xsl:attribute name="name">{=wSKSymtU}Ungor Axe Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_axe_004_handle']/@name">
		<xsl:attribute name="name">{=ZUErKEsY}Ungor Axe Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='stoneaxe_of_taal_head']/@name">
		<xsl:attribute name="name">{=ieFcOSnv}Stoneaxe of Taal Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='stoneaxe_of_taal_handle']/@name">
		<xsl:attribute name="name">{=v8HFqlvM}Stoneaxe of Taal Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='grave_guard_greataxe_001_blade']/@name">
		<xsl:attribute name="name">{=WHMvTsNH}Grave Guard Greataxe Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='grave_guard_greataxe_001_handle']/@name">
		<xsl:attribute name="name">{=4YHpxZtV}Grave Guard Greataxe Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_greataxe_001_blade']/@name">
		<xsl:attribute name="name">{=T9rJYFX9}Vampire Greataxe Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_greataxe_001_handle']/@name">
		<xsl:attribute name="name">{=edIHNODe}Vampire Greataxe Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_greataxe_002_blade']/@name">
		<xsl:attribute name="name">{=T9rJYFX9}Vampire Greataxe Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_greataxe_002_handle']/@name">
		<xsl:attribute name="name">{=edIHNODe}Vampire Greataxe Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='black_axe_of_krell_head']/@name">
		<xsl:attribute name="name">{=6uf8ZsNJ}Black Axe of Krell Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='black_axe_of_krell_handle']/@name">
		<xsl:attribute name="name">{=71sqzJeK}Black Axe of Krell Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_2h_axe_001_blade']/@name">
		<xsl:attribute name="name">{=R9PbJiv5}Wood Elven Ranger Axe Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_2h_axe_001_handle']/@name">
		<xsl:attribute name="name">{=VHgorddX}Wood Elven Ranger Axe Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='he_whitelion_2h_axe_001_blade']/@name">
		<xsl:attribute name="name">{=I9RfBNNo}High Elves White Lion Greataxe Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='he_whitelion_2h_axe_001_handle']/@name">
		<xsl:attribute name="name">{=ITrBW8w5}High Elves White Lion Greataxe Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_2h_axe_001_blade']/@name">
		<xsl:attribute name="name">{=BdFghSkP}Minotaur Greataxe Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_2h_axe_001_handle']/@name">
		<xsl:attribute name="name">{=BeJ9obRr}Minotaur Greataxe Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='chaos_2h_greataxe_001_blade']/@name">
		<xsl:attribute name="name">{=QtGsfUsu}Chaos Warrior Greataxe Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='chaos_2h_greataxe_001_handle']/@name">
		<xsl:attribute name="name">{=kCPXEtBY}Chaos Warrior Greataxe Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='nurgle_greataxe_001_blade']/@name">
		<xsl:attribute name="name">{=RtvEclHD}Nurgle Greataxe Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='nurgle_greataxe_001_handle']/@name">
		<xsl:attribute name="name">{=jfcRRNAh}Nurgle Greataxe Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='comet_flail_head']/@name">
		<xsl:attribute name="name">{=T8guRlAn}Comet Flail Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='comet_flail_handle']/@name">
		<xsl:attribute name="name">{=MM0eNCrV}Comet Flail Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_hammer_001_head']/@name">
		<xsl:attribute name="name">{=KLKx2Czt}Warrior Priest Hammer Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_hammer_001_handle']/@name">
		<xsl:attribute name="name">{=EzAPaZ76}Warrior Priest Hammer Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_hammer_002_head']/@name">
		<xsl:attribute name="name">{=KLKx2Czt}Warrior Priest Hammer Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_hammer_002_handle']/@name">
		<xsl:attribute name="name">{=EzAPaZ76}Warrior Priest Hammer Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_hammer_003_head']/@name">
		<xsl:attribute name="name">{=KLKx2Czt}Warrior Priest Hammer Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_hammer_003_handle']/@name">
		<xsl:attribute name="name">{=EzAPaZ76}Warrior Priest Hammer Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_hammer_004_head']/@name">
		<xsl:attribute name="name">{=KLKx2Czt}Warrior Priest Hammer Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_hammer_004_handle']/@name">
		<xsl:attribute name="name">{=EzAPaZ76}Warrior Priest Hammer Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='flagellant_mace_001_head']/@name">
		<xsl:attribute name="name">{=F6RRHSLC}Flagellant Mace Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='flagellant_mace_001_handle']/@name">
		<xsl:attribute name="name">{=QBwf6Eru}Flagellant Mace Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='flagellant_flail_head_001']/@name">
		<xsl:attribute name="name">{=7EdCd933}Flagellant Flail Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='flagellant_flail_handle_001']/@name">
		<xsl:attribute name="name">{=4TlvUGbf}Flagellant Flail Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='flagellant_flail_head_002']/@name">
		<xsl:attribute name="name">{=7EdCd933}Flagellant Flail Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='flagellant_flail_head_003']/@name">
		<xsl:attribute name="name">{=7EdCd933}Flagellant Flail Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_huss_hammer_head']/@name">
		<xsl:attribute name="name">{=77WKDSpR}Luthor Huss Hammer Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_huss_hammer_handle']/@name">
		<xsl:attribute name="name">{=MDYrhvJf}Luthor Huss Hammer Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_hammer_001_head']/@name">
		<xsl:attribute name="name">{=p5XMYeqF}Empire Hammer Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_hammer_001_handle']/@name">
		<xsl:attribute name="name">{=aiHDbbnp}Empire Hammer Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_hammer_002_head']/@name">
		<xsl:attribute name="name">{=p5XMYeqF}Empire Hammer Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_hammer_002_handle']/@name">
		<xsl:attribute name="name">{=aiHDbbnp}Empire Hammer Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vc_skeleton_warrior_mace_001_blade']/@name">
		<xsl:attribute name="name">{=EVJ7GpWx}Skeleton Warrior Mace Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vc_skeleton_warrior_mace_001_handle']/@name">
		<xsl:attribute name="name">{=IjE1lmXo}Skeleton Warrior Mace Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vc_skeleton_warrior_mace_002_blade']/@name">
		<xsl:attribute name="name">{=EVJ7GpWx}Skeleton Warrior Mace Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vc_skeleton_warrior_mace_002_handle']/@name">
		<xsl:attribute name="name">{=IjE1lmXo}Skeleton Warrior Mace Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vc_skeleton_warrior_mace_003_blade']/@name">
		<xsl:attribute name="name">{=EVJ7GpWx}Skeleton Warrior Mace Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vc_skeleton_warrior_mace_003_handle']/@name">
		<xsl:attribute name="name">{=IjE1lmXo}Skeleton Warrior Mace Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vc_skeleton_warrior_mace_004_blade']/@name">
		<xsl:attribute name="name">{=EVJ7GpWx}Skeleton Warrior Mace Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vc_skeleton_warrior_mace_004_handle']/@name">
		<xsl:attribute name="name">{=IjE1lmXo}Skeleton Warrior Mace Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='nurgle_hammer_001_head']/@name">
		<xsl:attribute name="name">{=bfMyz3bC}Nurgle Hammer Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='nurgle_hammer_001_handle']/@name">
		<xsl:attribute name="name">{=jFr2fqTa}Nurgle Hammer Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='ghal_maraz_head']/@name">
		<xsl:attribute name="name">{=vniRppWr}Ghal Maraz Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='ghal_maraz_handle']/@name">
		<xsl:attribute name="name">{=uX4rx6uQ}Ghal Maraz Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='holy_silver_hammer_head']/@name">
		<xsl:attribute name="name">{=HrCLOCHM}Holy Silver Hammer Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='holy_silver_hammer_handle']/@name">
		<xsl:attribute name="name">{=u1WzR1bC}Holy Silver Hammer Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='flagellant_mace_002_head']/@name">
		<xsl:attribute name="name">{=F6RRHSLC}Flagellant Mace Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='flagellant_mace_002_handle']/@name">
		<xsl:attribute name="name">{=QBwf6Eru}Flagellant Mace Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_twohanded_hammer_001_head']/@name">
		<xsl:attribute name="name">{=uE2XEHHo}Warrior Priest Two_Handed Hammer Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_twohanded_hammer_001_handle']/@name">
		<xsl:attribute name="name">{=293EitrP}Warrior Priest Two_Handed Hammer Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_twohanded_hammer_002_head']/@name">
		<xsl:attribute name="name">{=uE2XEHHo}Warrior Priest Two_Handed Hammer Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_twohanded_hammer_002_handle']/@name">
		<xsl:attribute name="name">{=293EitrP}Warrior Priest Two_Handed Hammer Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_twohanded_hammer_003_head']/@name">
		<xsl:attribute name="name">{=uE2XEHHo}Warrior Priest Two_Handed Hammer Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_twohanded_hammer_003_handle']/@name">
		<xsl:attribute name="name">{=293EitrP}Warrior Priest Two_Handed Hammer Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_greatmace_001_head']/@name">
		<xsl:attribute name="name">{=XwYsccVH}Vampire Two Handed Mace Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampire_greatmace_001_handle']/@name">
		<xsl:attribute name="name">{=VAdd9WhS}Vampire Two Handed Mace Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_polehammer_001_head']/@name">
		<xsl:attribute name="name">{=YsCpabxf}Warrior Priest Polehammer Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_polehammer_001_handle']/@name">
		<xsl:attribute name="name">{=5HizJbql}Warrior Priest Polehammer Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_polehammer_002_head']/@name">
		<xsl:attribute name="name">{=YsCpabxf}Warrior Priest Polehammer Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_polehammer_002_handle']/@name">
		<xsl:attribute name="name">{=5HizJbql}Warrior Priest Polehammer Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_polehammer_003_head']/@name">
		<xsl:attribute name="name">{=YsCpabxf}Warrior Priest Polehammer Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wp_polehammer_003_handle']/@name">
		<xsl:attribute name="name">{=5HizJbql}Warrior Priest Polehammer Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_spear_001_head']/@name">
		<xsl:attribute name="name">{=oq6YpK3h}Empire Spear Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_spear_002_head']/@name">
		<xsl:attribute name="name">{=oq6YpK3h}Empire Spear Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_spear_003_head']/@name">
		<xsl:attribute name="name">{=oq6YpK3h}Empire Spear Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_spear_004_head']/@name">
		<xsl:attribute name="name">{=oq6YpK3h}Empire Spear Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_spear_005_head']/@name">
		<xsl:attribute name="name">{=oq6YpK3h}Empire Spear Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_spear_head']/@name">
		<xsl:attribute name="name">{=W06x2OFn}Old Spearhead</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_spear_shaft']/@name">
		<xsl:attribute name="name">{=xjhe6gdq}Old Spearshaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_spear_guard']/@name">
		<xsl:attribute name="name">{=i9LU0ouy}Old Spearguard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='skeleton_spear_pommel']/@name">
		<xsl:attribute name="name">{=Wf286ENY}Old Spearpommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_trident_spear_head']/@name">
		<xsl:attribute name="name">{=Af45Dr7S}Bretonnian Trident Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_trident_spear_shaft']/@name">
		<xsl:attribute name="name">{=Vp2o7Dck}Bretonnian Trident Shaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_spear_001_head']/@name">
		<xsl:attribute name="name">{=CFjOrNAP}Bretonnian Spear Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_spear_001_shaft']/@name">
		<xsl:attribute name="name">{=tP7b2yys}Bretonnian Spear Shaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_spear_001_pommel']/@name">
		<xsl:attribute name="name">{=9ZeiH7hc}Bretonnian Spear Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_spear_002_head']/@name">
		<xsl:attribute name="name">{=CFjOrNAP}Bretonnian Spear Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_spear_002_shaft']/@name">
		<xsl:attribute name="name">{=tP7b2yys}Bretonnian Spear Shaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_spear_002_pommel']/@name">
		<xsl:attribute name="name">{=9ZeiH7hc}Bretonnian Spear Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_spear_003_head']/@name">
		<xsl:attribute name="name">{=CFjOrNAP}Bretonnian Spear Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_spear_003_shaft']/@name">
		<xsl:attribute name="name">{=tP7b2yys}Bretonnian Spear Shaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_spear_003_pommel']/@name">
		<xsl:attribute name="name">{=9ZeiH7hc}Bretonnian Spear Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_wildrider_spear_001_head']/@name">
		<xsl:attribute name="name">{=Rh8lTS6E}Wildrider Spear Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_wildrider_spear_001_shaft']/@name">
		<xsl:attribute name="name">{=VAo7jMqk}Wildrider Spear Shaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_spear_001_head']/@name">
		<xsl:attribute name="name">{=jjMLriLL}Wood Elven Spear Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_spear_002_head']/@name">
		<xsl:attribute name="name">{=jjMLriLL}Wood Elven Spear Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_spear_003_head']/@name">
		<xsl:attribute name="name">{=jjMLriLL}Wood Elven Spear Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_spear_004_head']/@name">
		<xsl:attribute name="name">{=jjMLriLL}Wood Elven Spear Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='we_spear_001_shaft']/@name">
		<xsl:attribute name="name">{=oCxM9c2s}Wood Elven Spear Shaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='he_spearmen_spear_001_head']/@name">
		<xsl:attribute name="name">{=ciLoeTIr}High Elven Spearmen Spear Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='he_spearmen_spear_001_shaft']/@name">
		<xsl:attribute name="name">{=7IaSzFnW}High Elven Spearmen Spear Shaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='de_spear_001_shaft']/@name">
		<xsl:attribute name="name">{=QJbPl5Ex}Dark Elven Spear Shaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='de_spear_001_head']/@name">
		<xsl:attribute name="name">{=oW85aSg3}Dark Elven Spear Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='de_spear_002_head']/@name">
		<xsl:attribute name="name">{=oW85aSg3}Dark Elven Spear Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_spear_001_head']/@name">
		<xsl:attribute name="name">{=Fn3Tq7ZT}Ungor Spearhead</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_spear_001_shaft']/@name">
		<xsl:attribute name="name">{=bzHUMikW}Ungor Spearshaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_spear_002_head']/@name">
		<xsl:attribute name="name">{=Fn3Tq7ZT}Ungor Spearhead</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_spear_002_shaft']/@name">
		<xsl:attribute name="name">{=bzHUMikW}Ungor Spearshaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_spear_003_head']/@name">
		<xsl:attribute name="name">{=Fn3Tq7ZT}Ungor Spearhead</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_spear_003_shaft']/@name">
		<xsl:attribute name="name">{=bzHUMikW}Ungor Spearshaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_spear_004_head']/@name">
		<xsl:attribute name="name">{=Fn3Tq7ZT}Ungor Spearhead</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='beastmen_ungor_spear_004_shaft']/@name">
		<xsl:attribute name="name">{=bzHUMikW}Ungor Spearshaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_halberd_head']/@name">
		<xsl:attribute name="name">{=RSraYzAJ}Empire Halberd Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_halberd_shaft']/@name">
		<xsl:attribute name="name">{=c2yLcMzj}Empire Halberd Shaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_halberd_002_head']/@name">
		<xsl:attribute name="name">{=RSraYzAJ}Empire Halberd Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_halberd_002_shaft']/@name">
		<xsl:attribute name="name">{=c2yLcMzj}Empire Halberd Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_halberd_003_head']/@name">
		<xsl:attribute name="name">{=RSraYzAJ}Empire Halberd Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_halberd_003_shaft']/@name">
		<xsl:attribute name="name">{=c2yLcMzj}Empire Halberd Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_halberd_004_head']/@name">
		<xsl:attribute name="name">{=RSraYzAJ}Empire Halberd Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_halberd_004_shaft']/@name">
		<xsl:attribute name="name">{=c2yLcMzj}Empire Halberd Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_halberd_005_head']/@name">
		<xsl:attribute name="name">{=RSraYzAJ}Empire Halberd Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_halberd_005_shaft']/@name">
		<xsl:attribute name="name">{=c2yLcMzj}Empire Halberd Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_halberd_006_head']/@name">
		<xsl:attribute name="name">{=RSraYzAJ}Empire Halberd Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vc_halberd_001_head']/@name">
		<xsl:attribute name="name">{=qz3l5Z17}Old Halberdhead</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vc_halberd_002_head']/@name">
		<xsl:attribute name="name">{=qz3l5Z17}Old Halberdhead</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vc_halberd_003_head']/@name">
		<xsl:attribute name="name">{=qz3l5Z17}Old Halberdhead</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_halberd_001_head']/@name">
		<xsl:attribute name="name">{=UUkUIQwG}Bretonnian Voulgier Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_halberd_001_shaft']/@name">
		<xsl:attribute name="name">{=1D8T94f5}Bretonnian Voulgier Shaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_halberd_002_head']/@name">
		<xsl:attribute name="name">{=UUkUIQwG}Bretonnian Voulgier Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_halberd_002_shaft']/@name">
		<xsl:attribute name="name">{=1D8T94f5}Bretonnian Voulgier Shaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_halberd_003_head']/@name">
		<xsl:attribute name="name">{=UUkUIQwG}Bretonnian Voulgier Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_halberd_003_shaft']/@name">
		<xsl:attribute name="name">{=1D8T94f5}Bretonnian Voulgier Shaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_halberd_004_head']/@name">
		<xsl:attribute name="name">{=UUkUIQwG}Bretonnian Voulgier Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_halberd_004_shaft']/@name">
		<xsl:attribute name="name">{=1D8T94f5}Bretonnian Voulgier Shaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_halberd_005_head']/@name">
		<xsl:attribute name="name">{=UUkUIQwG}Bretonnian Voulgier Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_halberd_006_head']/@name">
		<xsl:attribute name="name">{=UUkUIQwG}Bretonnian Voulgier Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='he_halberd_phoenix_001_shaft']/@name">
		<xsl:attribute name="name">{=4HYwurzt}High Elven Phoenix Guard Halberd Shaft</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='he_halberd_phoenix_001_head']/@name">
		<xsl:attribute name="name">{=UZOSzKu2}High Elven Phoenix Guard Halberd Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='magic_orb_head']/@name">
		<xsl:attribute name="name">{=1HM5B9XS}Magic Orb</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='exiled_wizard_dragon_staff_001_head']/@name">
		<xsl:attribute name="name">{=eAfhpcFc}Exiled Wizard Dragon Staff Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='exiled_wizard_dragon_staff_001_handle']/@name">
		<xsl:attribute name="name">{=XHHrxEtL}Exiled Wizard Dragon Staff Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bw_staff_001_head']/@name">
		<xsl:attribute name="name">{=Quexh3Gy}Bright Wizard Staff Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bw_staff_001_handle']/@name">
		<xsl:attribute name="name">{=rAVDZbvk}Bright Wizard Staff Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bw_staff_002_head']/@name">
		<xsl:attribute name="name">{=Quexh3Gy}Bright Wizard Staff Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bw_staff_002_handle']/@name">
		<xsl:attribute name="name">{=rAVDZbvk}Bright Wizard Staff Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='volkmar_staff_head']/@name">
		<xsl:attribute name="name">{=4g3ctEDD}Volkmar the Grim Staff Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='volkmar_staff_handle']/@name">
		<xsl:attribute name="name">{=VAYLmA7u}Volkmar the Grim Staff Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='balthazar_gelt_staff_head']/@name">
		<xsl:attribute name="name">{=O2eTVUbV}Balthazar Staff Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='balthazar_gelt_staff_handle']/@name">
		<xsl:attribute name="name">{=G3kcVOBf}Balthazar Staff Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_light_wizard_head']/@name">
		<xsl:attribute name="name">{=C4zEA1n8}Light Wizard Staff Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_light_wizard_handle']/@name">
		<xsl:attribute name="name">{=1ltJIF8o}Light Wizard Staff Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_light_wizard_002_head']/@name">
		<xsl:attribute name="name">{=C4zEA1n8}Light Wizard Staff Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_light_wizard_002_handle']/@name">
		<xsl:attribute name="name">{=1ltJIF8o}Light Wizard Staff Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_light_wizard_003_head']/@name">
		<xsl:attribute name="name">{=C4zEA1n8}Light Wizard Staff Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_light_wizard_003_handle']/@name">
		<xsl:attribute name="name">{=1ltJIF8o}Light Wizard Staff Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_celestial_wizard_head']/@name">
		<xsl:attribute name="name">{=caHz2QWf}Celestial Wizard Staff Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='nm_staff_001_head']/@name">
		<xsl:attribute name="name">{=1LcDgAlE}Necromancer Staff Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='nm_staff_001_handle']/@name">
		<xsl:attribute name="name">{=36Ckh7H7}Necromancer Staff Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='prophetess_staff_001_head']/@name">
		<xsl:attribute name="name">{=mlK02MxV}Prophetess Staff Head</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='prophetess_staff_001_handle']/@name">
		<xsl:attribute name="name">{=3u06ERVx}Prophetess Staff Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='jousting_lance_handle_small1']/@name">
		<xsl:attribute name="name">{=eGscFCdj}Jousting Lance Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='jousting_lance_handle_small_x']/@name">
		<xsl:attribute name="name">{=1TLZDrC2}Heavy Jousting Lance Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='lance_iron_handle']/@name">
		<xsl:attribute name="name">{=gkA64FMj}Iron Lance Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='lance_iron_handle_x']/@name">
		<xsl:attribute name="name">{=gkA64FMj}Iron Lance Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='jousting_lance_guard_long_x']/@name">
		<xsl:attribute name="name">{=GRK45pHQ}Heavy Jousting Lance Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='jousting_lance_guard_long_colored_bluewhite']/@name">
		<xsl:attribute name="name">{=GK1EYyO3}Colored Jousting Lance Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='jousting_lance_guard_long_colored_blueyellow']/@name">
		<xsl:attribute name="name">{=GK1EYyO3}Colored Jousting Lance Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='jousting_lance_guard_long_colored_blackwhite']/@name">
		<xsl:attribute name="name">{=GK1EYyO3}Colored Jousting Lance Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='jousting_lance_guard_long_colored_blackred']/@name">
		<xsl:attribute name="name">{=GK1EYyO3}Colored Jousting Lance Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='jousting_lance_guard_long_colored_redyellow']/@name">
		<xsl:attribute name="name">{=GK1EYyO3}Colored Jousting Lance Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='jousting_lance_guard_long_colored_redwhite']/@name">
		<xsl:attribute name="name">{=GK1EYyO3}Colored Jousting Lance Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='lance_iron_guard']/@name">
		<xsl:attribute name="name">{=oQhIGvrc}Lance Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='jousting_lance_pommel']/@name">
		<xsl:attribute name="name">{=zAOPEtow}Jousting Lance Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='jousting_lance_pommel_x']/@name">
		<xsl:attribute name="name">{=2yuoBQyp}Heavy Jousting Lance Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='lance_iron_pommel']/@name">
		<xsl:attribute name="name">{=9DdQQolV}Iron Lance Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='lance_iron_blade']/@name">
		<xsl:attribute name="name">{=5DimXhKK}Lance Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='lance_blade_9']/@name">
		<xsl:attribute name="name">{=5DimXhKK}Lance Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_lance_handle_001']/@name">
		<xsl:attribute name="name">{=VQdfSTws}Reiksguard Knight Lance Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_lance_guard_001']/@name">
		<xsl:attribute name="name">{=dIbyChIH}Reiksguard Knight Lance Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_lance_pommel_001']/@name">
		<xsl:attribute name="name">{=3cM9VFs1}Reiksguard Knight Lance Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_lance_blade_001']/@name">
		<xsl:attribute name="name">{=LUiMNLMM}Reiksguard Knight Lance Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_lance_handle_002']/@name">
		<xsl:attribute name="name">{=VQdfSTws}Reiksguard Knight Lance Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_lance_guard_002']/@name">
		<xsl:attribute name="name">{=dIbyChIH}Reiksguard Knight Lance Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_lance_pommel_002']/@name">
		<xsl:attribute name="name">{=3cM9VFs1}Reiksguard Knight Lance Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='reiksguard_knight_lance_blade_002']/@name">
		<xsl:attribute name="name">{=LUiMNLMM}Reiksguard Knight Lance Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='black_knight_lance_001_blade']/@name">
		<xsl:attribute name="name">{=ZAuZBFSy}Black Knight Lance Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='black_knight_lance_001_handle']/@name">
		<xsl:attribute name="name">{=kpanbI6A}Black Knight Lance Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='black_knight_lance_001_guard']/@name">
		<xsl:attribute name="name">{=AARRYjhP}Black Knight Lance Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='black_knight_lance_001_pommel']/@name">
		<xsl:attribute name="name">{=ytEocjIz}Black Knight Lance Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='chaos_ud_lance_handle_001']/@name">
		<xsl:attribute name="name">{=1XHc5rQK}Chaos Lance Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='chaos_ud_lance_guard_001']/@name">
		<xsl:attribute name="name">{=pkp6ZonE}Chaos Lance Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='chaos_ud_lance_pommel_001']/@name">
		<xsl:attribute name="name">{=2t2grloP}Chaos Lance Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='chaos_ud_lance_blade_001']/@name">
		<xsl:attribute name="name">{=xz1k8vCR}Chaos Lance Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_jousting_lance_handle_001']/@name">
		<xsl:attribute name="name">{=npNtAsao}Bretonnian Jousting Lance Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_jousting_lance_guard_001']/@name">
		<xsl:attribute name="name">{=5NC2Kvi8}Bretonnian Jousting Lance Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_jousting_lance_pommel_001']/@name">
		<xsl:attribute name="name">{=1Sp2aJBM}Bretonnian Jousting Lance Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_jousting_lance_blade_001']/@name">
		<xsl:attribute name="name">{=bgBW7YSz}Bretonnian Jousting Lance Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_jousting_lance_handle_002']/@name">
		<xsl:attribute name="name">{=npNtAsao}Bretonnian Jousting Lance Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_jousting_lance_guard_002']/@name">
		<xsl:attribute name="name">{=5NC2Kvi8}Bretonnian Jousting Lance Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_jousting_lance_pommel_002']/@name">
		<xsl:attribute name="name">{=1Sp2aJBM}Bretonnian Jousting Lance Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_jousting_lance_blade_002']/@name">
		<xsl:attribute name="name">{=bgBW7YSz}Bretonnian Jousting Lance Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_jousting_lance_handle_003']/@name">
		<xsl:attribute name="name">{=npNtAsao}Bretonnian Jousting Lance Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_jousting_lance_guard_003']/@name">
		<xsl:attribute name="name">{=5NC2Kvi8}Bretonnian Jousting Lance Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_jousting_lance_pommel_003']/@name">
		<xsl:attribute name="name">{=1Sp2aJBM}Bretonnian Jousting Lance Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_jousting_lance_blade_003']/@name">
		<xsl:attribute name="name">{=bgBW7YSz}Bretonnian Jousting Lance Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_jousting_lance_handle_004']/@name">
		<xsl:attribute name="name">{=npNtAsao}Bretonnian Jousting Lance Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_jousting_lance_guard_004']/@name">
		<xsl:attribute name="name">{=5NC2Kvi8}Bretonnian Jousting Lance Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_jousting_lance_pommel_004']/@name">
		<xsl:attribute name="name">{=1Sp2aJBM}Bretonnian Jousting Lance Pommel</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='bretonnian_jousting_lance_blade_004']/@name">
		<xsl:attribute name="name">{=bgBW7YSz}Bretonnian Jousting Lance Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_morr_scythe_001_blade']/@name">
		<xsl:attribute name="name">{=orOwEqya}Morr Scythe Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_morr_scythe_001_pole']/@name">
		<xsl:attribute name="name">{=CpiyZOym}Morr Scythe Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_morr_scythe_002_blade']/@name">
		<xsl:attribute name="name">{=orOwEqya}Morr Scythe Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_morr_scythe_002_pole']/@name">
		<xsl:attribute name="name">{=CpiyZOym}Morr Scythe Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_morr_scythe_003_blade']/@name">
		<xsl:attribute name="name">{=orOwEqya}Morr Scythe Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='empire_morr_scythe_003_pole']/@name">
		<xsl:attribute name="name">{=CpiyZOym}Morr Scythe Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='raven_scythe_blade']/@name">
		<xsl:attribute name="name">{=NXZ8GNFq}Raven Scythe Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='raven_scythe_handle']/@name">
		<xsl:attribute name="name">{=FNstk6OM}Raven Scythe Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampiric_scythe_blade']/@name">
		<xsl:attribute name="name">{=BaWQdETz}Vampiric Scythe Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='vampiric_scythe_handle']/@name">
		<xsl:attribute name="name">{=DnIkflDT}Vampiric Scythe Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wood_scythe_blade']/@name">
		<xsl:attribute name="name">{=n8SxnOIv}Wood Scythe Blade</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wood_scythe_handle']/@name">
		<xsl:attribute name="name">{=4LRmm3l3}Wood Scythe Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='lhm_fist_weapon_handle']/@name">
		<xsl:attribute name="name">{=lRht9Dkr}Monster Fist Weapon Handle</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='lhm_fist_weapon_blade']/@name">
		<xsl:attribute name="name">{=LAfETrIc}Monster Fist Weapon Blade</xsl:attribute>
	</xsl:template>
</xsl:stylesheet>