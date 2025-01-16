<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

	<xsl:template match="string[@id='str_customresource_trade_label']/@text">
		<xsl:attribute name="text">{=q3bhAMpk}You will {?PAY_OR_GET}get{?}pay{\?} {TRADE_AMOUNT}"</xsl:attribute>
	</xsl:template>
</xsl:stylesheet>