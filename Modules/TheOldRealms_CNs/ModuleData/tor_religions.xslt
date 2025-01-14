<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

	<!-- empire religions -->
	<xsl:template match="Religions/Religion[@id='cult_of_sigmar']/@DeityName">
		<xsl:attribute name="DeityName">{=uAcDYWQY}Sigmar</xsl:attribute>
	</xsl:template>
	<xsl:template match="Religions/Religion[@id='cult_of_taal']/@Name">
		<xsl:attribute name="Name">{=rptmi0UA}Cult of Taal</xsl:attribute>
	</xsl:template>
	<xsl:template match="Religions/Religion[@id='cult_of_ulric']/@Name">
		<xsl:attribute name="Name">{=To2UP6EE}Cult of Ulric</xsl:attribute>
	</xsl:template>
	<xsl:template match="Religions/Religion[@id='cult_of_shallya']/@Name">
		<xsl:attribute name="Name">{=2Udeg0Ga}Cult of Shallya</xsl:attribute>
	</xsl:template>
	<xsl:template match="Religions/Religion[@id='cult_of_manaan']/@Name">
		<xsl:attribute name="Name">{=NTPbEeHn}Cult of Manaan</xsl:attribute>
	</xsl:template>
	
	<!-- bretonnia religions -->
	<xsl:template match="Religions/Religion[@id='cult_of_lady']/@Name">
		<xsl:attribute name="Name">{=5V6f3I9K}Cult of The Lady</xsl:attribute>
	</xsl:template>

	<!-- vampire religions -->
	<xsl:template match="Religions/Religion[@id='cult_of_nagash']/@Name">
		<xsl:attribute name="Name">{=MUMTzo1G}Children of Nagash</xsl:attribute>
	</xsl:template>

	<!-- chaos religions -->
	<xsl:template match="Religions/Religion[@id='chaos_undivided']/@Name">
		<xsl:attribute name="Name">{=vTvOAztl}Chaos Undivided</xsl:attribute>
	</xsl:template>
	<xsl:template match="Religions/Religion[@id='cult_of_slaanesh']/@Name">
		<xsl:attribute name="Name">{=9Il43M6M}Cult of Slaanesh</xsl:attribute>
	</xsl:template>
	<xsl:template match="Religions/Religion[@id='cult_of_nurgle']/@Name">
		<xsl:attribute name="Name">{=fIcPUzGv}Cult of Nurgle</xsl:attribute>
	</xsl:template>
	<xsl:template match="Religions/Religion[@id='cult_of_khorne']/@Name">
		<xsl:attribute name="Name">{=TXT9KJsN}Cult of Khorne</xsl:attribute>
	</xsl:template>
	<xsl:template match="Religions/Religion[@id='cult_of_tzeentch']/@Name">
		<xsl:attribute name="Name">{=8qLEOMRf}Cult of Tzeentch</xsl:attribute>
	</xsl:template>

	<!-- elven religions -->
	<xsl:template match="Religions/Religion[@id='cult_of_isha']/@Name">
		<xsl:attribute name="Name">{=Nbfh9BEO}Cult of Isha</xsl:attribute>
	</xsl:template>
	<xsl:template match="Religions/Religion[@id='cult_of_kurnous']/@Name">
		<xsl:attribute name="Name">{=i1xo0UUr}Cult of Kurnous</xsl:attribute>
	</xsl:template>
	<xsl:template match="Religions/Religion[@id='cult_of_vaul']/@Name">
		<xsl:attribute name="Name">{=qOwxILpB}Cult of Vaul</xsl:attribute>
	</xsl:template>
	<xsl:template match="Religions/Religion[@id='cult_of_anath_raema']/@Name">
		<xsl:attribute name="Name">{=6oV6DXuW}Cult of Anath Raema</xsl:attribute>
	</xsl:template>
	<xsl:template match="Religions/Religion[@id='cult_of_asuryan']/@Name">
		<xsl:attribute name="Name">{=Ni8GpT4x}Cult of Asuryan</xsl:attribute>
	</xsl:template>
	<xsl:template match="Religions/Religion[@id='cult_of_loec']/@Name">
		<xsl:attribute name="Name">{=GdXUNDIA}Cult of Loec</xsl:attribute>
	</xsl:template>
</xsl:stylesheet>