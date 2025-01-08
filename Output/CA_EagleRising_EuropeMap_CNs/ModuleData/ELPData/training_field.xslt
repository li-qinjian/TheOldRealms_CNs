<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="Settlement[@name='{=rQge8OSi}Training Field']/@name">
        <xsl:attribute name="name">训练场</xsl:attribute>
    </xsl:template>

    <xsl:template match="Settlement[@text='{=!}This is the training field.']/@text">
        <xsl:attribute name="text">这是一个训练场。</xsl:attribute>
    </xsl:template>
</xsl:stylesheet>