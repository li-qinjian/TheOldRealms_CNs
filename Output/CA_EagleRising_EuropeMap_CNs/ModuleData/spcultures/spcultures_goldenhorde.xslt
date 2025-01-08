<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>
    <!--原MOD金帐汗国文化使用骑砍2原版库塞特文化的StringID，导致汉化不能覆盖生效，所以用此xslt文件更改金帐汗国StringID，用以汉化-->
    <xsl:template match="Culture[@id='goldenhorde']/@name">
        <xsl:attribute name="name">{=NhijjZdk}Golden Horde</xsl:attribute>
    </xsl:template>
    
</xsl:stylesheet>