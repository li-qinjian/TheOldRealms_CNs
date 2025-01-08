<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="Settlement[@name='Ferry Point']/@name">
        <xsl:attribute name="name">{=B8oOmYpMoy}Ferry Point</xsl:attribute>
    </xsl:template>

    <xsl:template match="Settlement[@text='A ferry point']/@text">
        <xsl:attribute name="text">{=9L5pkQqMvT}A ferry point</xsl:attribute>
    </xsl:template>
</xsl:stylesheet>