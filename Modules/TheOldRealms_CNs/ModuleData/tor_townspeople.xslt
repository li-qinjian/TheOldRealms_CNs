<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

	 <!-- Empire Notables -->
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_0']/@name">
		<xsl:attribute name="name">{=dhnqW8Gq}Cautious imperial merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_0b']/@name">
		<xsl:attribute name="name">{=TLeiSU3v}{FIRSTNAME} the Vintner</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_1']/@name">
		<xsl:attribute name="name">{=9k0q6hGg}Empire merchant 3, ruthless</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_1b']/@name">
		<xsl:attribute name="name">{=h4GAJ43V}Cold imperial merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_2']/@name">
		<xsl:attribute name="name">{=OHjvpnjX}{FIRSTNAME} the Saltpanner</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_2b']/@name">
		<xsl:attribute name="name">{=YYKFTHkJ}Empire merchant 6, cautious</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_3']/@name">
		<xsl:attribute name="name">{=97Gso8zX}Empire merchant 7, selfmade</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_3b']/@name">
		<xsl:attribute name="name">{=B59KaGgt}Empire merchant 8, jocular</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_4']/@name">
		<xsl:attribute name="name">{=xcD1mLrk}Empire merchant 9, heiress</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_4b']/@name">
		<xsl:attribute name="name">{=cfVwj9m5}Empire merchant 10, devious</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_5']/@name">
		<xsl:attribute name="name">{=DUU3eSrc}Messianic imperial preacher</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_6']/@name">
		<xsl:attribute name="name">{=7EB59HvP}Puritan imperial preacher</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_7']/@name">
		<xsl:attribute name="name">{=HTfH2O9X}Female imperial mystic</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_8']/@name">
		<xsl:attribute name="name">{=wk0DDRtR}Imperial gruff labor leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_9']/@name">
		<xsl:attribute name="name">{=HOl9L6oC}Imperial outgoing labor leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_gl1']/@name">
		<xsl:attribute name="name">{=yR9D56B0}Protective imperial male gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_10']/@name">
		<xsl:attribute name="name">{=OzJfch0u}Ironic imperial gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_11']/@name">
		<xsl:attribute name="name">{=hPHNesHZ}Intimidating male imperial gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_gl4']/@name">
		<xsl:attribute name="name">{=sdL5vR3U}Bestial male imperial gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_12']/@name">
		<xsl:attribute name="name">{=T0Wqn5SD}Female imperial gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_13']/@name">
		<xsl:attribute name="name">{=iVVTXFmX}Menacing female imperial gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_21']/@name">
		<xsl:attribute name="name">{=FN2GXtOl}Empire gruff rural notable</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_empire_22']/@name">
		<xsl:attribute name="name">{=pXkJI8ep}Empire rural notable agreeable</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_empire_headman_1']/@name">
		<xsl:attribute name="name">{=8rDOA0e2}empire rebellious headman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_empire_headman_2']/@name">
		<xsl:attribute name="name">{=Vae5bJXu}empire conservative headman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_empire_headman_3']/@name">
		<xsl:attribute name="name">{=Ud54TULd}empire devious headman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_empire_headman_3']/@name">
		<xsl:attribute name="name">{=Ud54TULd}empire devious headman</xsl:attribute>
	</xsl:template>

	<!-- Sylvanian Notables -->
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_0']/@name">
		<xsl:attribute name="name">{=dhnqW8Gq}Cautious imperial merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_0b']/@name">
		<xsl:attribute name="name">{=TLeiSU3v}{FIRSTNAME} the Vintner</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_1']/@name">
		<xsl:attribute name="name">{=F5w5kSap}Empire merchant 3, ruthless</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_1b']/@name">
		<xsl:attribute name="name">{=h4GAJ43V}Cold imperial merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_2']/@name">
		<xsl:attribute name="name">{=OHjvpnjX}{FIRSTNAME} the Saltpanner</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_2b']/@name">
		<xsl:attribute name="name">{=YYKFTHkJ}Empire merchant 6, cautious</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_3']/@name">
		<xsl:attribute name="name">{=97Gso8zX}Empire merchant 7, selfmade</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_3b']/@name">
		<xsl:attribute name="name">{=B59KaGgt}Empire merchant 8, jocular</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_4']/@name">
		<xsl:attribute name="name">{=xcD1mLrk}Empire merchant 9, heiress</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_4b']/@name">
		<xsl:attribute name="name">{=cfVwj9m5}Empire merchant 10, devious</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_5']/@name">
		<xsl:attribute name="name">{=DUU3eSrc}Messianic imperial preacher</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_6']/@name">
		<xsl:attribute name="name">{=7EB59HvP}Puritan imperial preacher</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_7']/@name">
		<xsl:attribute name="name">{=HTfH2O9X}Female imperial mystic</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_8']/@name">
		<xsl:attribute name="name">{=wk0DDRtR}Imperial gruff labor leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_9']/@name">
		<xsl:attribute name="name">{=HOl9L6oC}Imperial outgoing labor leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_gl1']/@name">
		<xsl:attribute name="name">{=yR9D56B0}rotective imperial male gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_10']/@name">
		<xsl:attribute name="name">{=OzJfch0u}Ironic imperial gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_11']/@name">
		<xsl:attribute name="name">{=hPHNesHZ}Intimidating male imperial gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_gl4']/@name">
		<xsl:attribute name="name">{=sdL5vR3U}Bestial male imperial gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_12']/@name">
		<xsl:attribute name="name">{=T0Wqn5SD}Female imperial gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_13']/@name">
		<xsl:attribute name="name">{=iVVTXFmX}Menacing female imperial gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_21']/@name">
		<xsl:attribute name="name">{=FN2GXtOl}Empire gruff rural notable</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_sylvania_22']/@name">
		<xsl:attribute name="name">{=pXkJI8ep}Empire rural notable agreeable</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_sylvania_headman_1']/@name">
		<xsl:attribute name="name">{=8rDOA0e2}empire rebellious headman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_sylvania_headman_2']/@name">
		<xsl:attribute name="name">{=Vae5bJXu}empire conservative headman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_sylvania_headman_3']/@name">
		<xsl:attribute name="name">{=Ud54TULd}empire devious headman</xsl:attribute>
	</xsl:template>

	<!-- Blood dragons -->
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_0']/@name">
		<xsl:attribute name="name">{=dhnqW8Gq}Cautious imperial merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_0b']/@name">
		<xsl:attribute name="name">{=TLeiSU3v}{FIRSTNAME} the Vintner</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_1']/@name">
		<xsl:attribute name="name">{=F5w5kSap}Empire merchant 3, ruthless</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_1b']/@name">
		<xsl:attribute name="name">{=h4GAJ43V}Cold imperial merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_2']/@name">
		<xsl:attribute name="name">{=YTX8ssOE}{FIRSTNAME} the Saltpanner</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_2b']/@name">
		<xsl:attribute name="name">{=YYKFTHkJ}Empire merchant 6, cautious</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_3']/@name">
		<xsl:attribute name="name">{=97Gso8zX}Empire merchant 7, selfmade</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_3b']/@name">
		<xsl:attribute name="name">{=B59KaGgt}Empire merchant 8, jocular</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_4']/@name">
		<xsl:attribute name="name">{=xcD1mLrk}Empire merchant 9, heiress</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_4b']/@name">
		<xsl:attribute name="name">{=cfVwj9m5}Empire merchant 10, devious</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_5']/@name">
		<xsl:attribute name="name">{=DUU3eSrc}Messianic imperial preacher</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_6']/@name">
		<xsl:attribute name="name">{=7EB59HvP}Puritan imperial preacher</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_7']/@name">
		<xsl:attribute name="name">{=HTfH2O9X}Female imperial mystic</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_8']/@name">
		<xsl:attribute name="name">{=wk0DDRtR}Imperial gruff labor leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_9']/@name">
		<xsl:attribute name="name">{=HOl9L6oC}Imperial outgoing labor leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_gl1']/@name">
		<xsl:attribute name="name">{=yR9D56B0}rotective imperial male gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_10']/@name">
		<xsl:attribute name="name">{=OzJfch0u}Ironic imperial gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_11']/@name">
		<xsl:attribute name="name">{=hPHNesHZ}Intimidating male imperial gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_gl4']/@name">
		<xsl:attribute name="name">{=sdL5vR3U}Bestial male imperial gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_12']/@name">
		<xsl:attribute name="name">{=T0Wqn5SD}Female imperial gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_13']/@name">
		<xsl:attribute name="name">{=iVVTXFmX}Menacing female imperial gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_21']/@name">
		<xsl:attribute name="name">{=FN2GXtOl}Empire gruff rural notable</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_notable_blooddragons_22']/@name">
		<xsl:attribute name="name">{=pXkJI8ep}Empire rural notable agreeable</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_blooddragons_headman_1']/@name">
		<xsl:attribute name="name">{=8rDOA0e2}empire rebellious headman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_blooddragons_headman_2']/@name">
		<xsl:attribute name="name">{=Vae5bJXu}empire conservative headman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tor_blooddragons_headman_3']/@name">
		<xsl:attribute name="name">{=Ud54TULd}empire devious headman</xsl:attribute>
	</xsl:template>

	 <!-- URBAN CHARACTERS OF BRETONNIA -->
	 <xsl:template match="NPCCharacter[@id='spc_notable_bretonnia_merch1']/@name">
		<xsl:attribute name="name">{=OKdhvd1d}Ironic bretonnia merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_bretonnia_merch2']/@name">
		<xsl:attribute name="name">{=H3MU6o0o}curt bretonnia merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_bretonnia_merch3']/@name">
		<xsl:attribute name="name">{=Iu26PDgS}Daring bretonnia merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_bretonnia_merch4']/@name">
		<xsl:attribute name="name">{=on6JK95u}Softspoken bretonnia merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_bretonnia_merch5']/@name">
		<xsl:attribute name="name">{=sGx53Rcj}{FIRSTNAME} the Manciple</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_bretonnia_1']/@name">
		<xsl:attribute name="name">{=F7nnlG4J}{FIRSTNAME} the Warehouser</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_bretonnia_1b']/@name">
		<xsl:attribute name="name">{=JXCp0PJX}{FIRSTNAME} the Heiress</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_bretonnia_2']/@name">
		<xsl:attribute name="name">{=vCs1kf1z}Puritan male preacher</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_bretonnia_3']/@name">
		<xsl:attribute name="name">{=nNheEOBU}Rebellious female preacher</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_bretonnia_gangleader_1']/@name">
		<xsl:attribute name="name">{=VKZoMRc0}Standard male gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_bretonnia_gangleader_2']/@name">
		<xsl:attribute name="name">{=uaBJ5JFg}Female gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_bretonnia_gangleader_3']/@name">
		<xsl:attribute name="name">{=JliyBypF}Male gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_bretonnia_artisan_1']/@name">
		<xsl:attribute name="name">{=XBtVxFoN}Bretonnian artisan 1</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_bretonnia_artisan_2']/@name">
		<xsl:attribute name="name">{=XBtVxFoN}Bretonnian artisan 2</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_bretonnia_rural_1']/@name">
		<xsl:attribute name="name">{=L4QdVLJ9}Bretonnian yeoman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_bretonnia_rural_2']/@name">
		<xsl:attribute name="name">{=L4QdVLJ9}Bretonnian yeoman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_bretonnia_headman_1']/@name">
		<xsl:attribute name="name">{=cV3YrsXl}Bretonnian rebellious headman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_bretonnia_headman_2']/@name">
		<xsl:attribute name="name">{=fsYVUloI}Bretonnian conservative headman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_bretonnia_headman_3']/@name">
		<xsl:attribute name="name">{=tl27s1nx}Bretonnian devious headman</xsl:attribute>
	</xsl:template>

	<!-- URBAN CHARACTERS OF MOUSILLON -->
	<xsl:template match="NPCCharacter[@id='spc_notable_mousillon_merch1']/@name">
		<xsl:attribute name="name">{=nBGUX3lc}Ironic mousillon merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_mousillon_merch2']/@name">
		<xsl:attribute name="name">{=f9K0KWoD}curt mousillon merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_mousillon_merch3']/@name">
		<xsl:attribute name="name">{=2ywbrXp4}Daring mousillon merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_mousillon_merch4']/@name">
		<xsl:attribute name="name">{=YBjuzheM}Softspoken mousillon merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_mousillon_merch5']/@name">
		<xsl:attribute name="name">{=sGx53Rcj}{FIRSTNAME} the Manciple</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_mousillon_1']/@name">
		<xsl:attribute name="name">{=F7nnlG4J}{FIRSTNAME} the Warehouser</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_mousillon_1b']/@name">
		<xsl:attribute name="name">{=JXCp0PJX}{FIRSTNAME} the Heiress</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_mousillon_2']/@name">
		<xsl:attribute name="name">{=vCs1kf1z}Puritan male preacher</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_mousillon_3']/@name">
		<xsl:attribute name="name">{=nNheEOBU}Rebellious female preacher</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_mousillon_gangleader_1']/@name">
		<xsl:attribute name="name">{=VKZoMRc0}Standard male gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_mousillon_gangleader_2']/@name">
		<xsl:attribute name="name">{=uaBJ5JFg}Female gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_mousillon_gangleader_3']/@name">
		<xsl:attribute name="name">{=JliyBypF}Male gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_mousillon_artisan_1']/@name">
		<xsl:attribute name="name">{=2MyiitEs}mousillonn artisan 1</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_mousillon_artisan_2']/@name">
		<xsl:attribute name="name">{=2MyiitEs}mousillonn artisan 2</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_mousillon_rural_1']/@name">
		<xsl:attribute name="name">{=DnGmasQc}mousillonn yeoman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_mousillon_rural_2']/@name">
		<xsl:attribute name="name">{=DnGmasQc}mousillonn yeoman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_mousillon_headman_1']/@name">
		<xsl:attribute name="name">{=piscrypk}mousillonn rebellious headman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_mousillon_headman_2']/@name">
		<xsl:attribute name="name">{=lX0Gpv79}mousillonn conservative headman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_mousillon_headman_3']/@name">
		<xsl:attribute name="name">{=3cRiuKe5}mousillonn devious headman</xsl:attribute>
	</xsl:template>

	<!-- URBAN CHARACTERS OF CHAOS -->
	<xsl:template match="NPCCharacter[@id='spc_notable_chaos_merch1']/@name">
		<xsl:attribute name="name">{=qmy64O5S}Ironic chaos merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_chaos_merch2']/@name">
		<xsl:attribute name="name">{=628FED2q}curt chaos merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_chaos_merch3']/@name">
		<xsl:attribute name="name">{=DzKnZWNQ}Daring chaos merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_chaos_merch4']/@name">
		<xsl:attribute name="name">{=HchY4Evx}Softspoken chaos merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_chaos_merch5']/@name">
		<xsl:attribute name="name">{=sGx53Rcj}{FIRSTNAME} the Manciple</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_chaos_1']/@name">
		<xsl:attribute name="name">{=F7nnlG4J}{FIRSTNAME} the Warehouser</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_chaos_1b']/@name">
		<xsl:attribute name="name">{=JXCp0PJX}{FIRSTNAME} the Heiress</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_chaos_2']/@name">
		<xsl:attribute name="name">{=vCs1kf1z}Puritan male preacher</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_chaos_3']/@name">
		<xsl:attribute name="name">{=nNheEOBU}Rebellious female preacher</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_chaos_gangleader_1']/@name">
		<xsl:attribute name="name">{=VKZoMRc0}Standard male gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_chaos_gangleader_2']/@name">
		<xsl:attribute name="name">{=uaBJ5JFg}Female gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_chaos_gangleader_3']/@name">
		<xsl:attribute name="name">{=JliyBypF}Male gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_chaos_artisan_1']/@name">
		<xsl:attribute name="name">{=GLJlAXwr}chaos artisan 1</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_chaos_artisan_2']/@name">
		<xsl:attribute name="name">{=GLJlAXwr}chaos artisan 2</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_chaos_rural_1']/@name">
		<xsl:attribute name="name">{=RJ3e6JyT}chaos yeoman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_chaos_rural_2']/@name">
		<xsl:attribute name="name">{=RJ3e6JyT}chaos yeoman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_chaos_headman_1']/@name">
		<xsl:attribute name="name">{=1TEYlGWr}chaos rebellious headman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_chaos_headman_2']/@name">
		<xsl:attribute name="name">{=zbyqtuFj}chaos conservative headman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_chaos_headman_3']/@name">
		<xsl:attribute name="name">{=1UtoYXt1}chaos devious headman</xsl:attribute>
	</xsl:template>

	<!-- URBAN CHARACTERS OF asrai -->
	<xsl:template match="NPCCharacter[@id='blacksmith_woodelf']/@name">
		<xsl:attribute name="name">{=RDxNNSrd}asrai Blacksmith</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='weaponsmith_woodelf']/@name">
		<xsl:attribute name="name">{=G2063vhL}asrai Weaponsmith</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='armorer_woodelf']/@name">
		<xsl:attribute name="name">{=M85Fqmfw}asrai Armorer</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='townsman_woodelf']/@name">
		<xsl:attribute name="name">{=M85Fqmfw}Halls dweller</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='townswoman_woodelf']/@name">
		<xsl:attribute name="name">{=M85Fqmfw}Halls dweller</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='village_woman_woodelf']/@name">
		<xsl:attribute name="name">{=ofUPwuGb}Asrai Villager</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='shop_worker_woodelf']/@name">
		<xsl:attribute name="name">{=0POnANRU}Asrai Shopworker</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tavernkeeper_woodelf']/@name">
		<xsl:attribute name="name">{=PMkG8JV1}Asrai Tavernkeeper</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='musician_woodelf']/@name">
		<xsl:attribute name="name">{=w5zIJJ7M}Asrai Musician</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='merchant_woodelf']/@name">
		<xsl:attribute name="name">{=ZAT1aeol}Asrai merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='horseMerchant_woodelf']/@name">
		<xsl:attribute name="name">{=hXlmeRa8}Asrai Horse merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='merchant_notary_woodelf']/@name">
		<xsl:attribute name="name">{=GQahppiE}Asrai Merchant notary</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='artisan_notary_woodelf']/@name">
		<xsl:attribute name="name">{=jv1AvLzg}Asrai Artisan notary</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='rural_notable_notary_woodelf']/@name">
		<xsl:attribute name="name">{=VkCN7M9A}Asrai Rural notary</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='ransom_broker_woodelf']/@name">
		<xsl:attribute name="name">{=rLsjmlQU}Asrai Ransombroker</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='gangleader_bodyguard_woodelf']/@name">
		<xsl:attribute name="name">{=CkFS5ici}Asrai Rogue</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_asrai_merch1']/@name">
		<xsl:attribute name="name">{=zFpYcm8V}Ironic asrai merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_asrai_merch2']/@name">
		<xsl:attribute name="name">{=XrFiFJU0}Curt asrai merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_asrai_merch3']/@name">
		<xsl:attribute name="name">{=vsMyoiSj}Daring asrai merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_asrai_merch4']/@name">
		<xsl:attribute name="name">{=TIAmrMFP}Softspoken asrai merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_asrai_merch5']/@name">
		<xsl:attribute name="name">{=sGx53Rcj}{FIRSTNAME} the Manciple</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_asrai_1']/@name">
		<xsl:attribute name="name">{=F7nnlG4J}{FIRSTNAME} the Warehouser</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_asrai_1b']/@name">
		<xsl:attribute name="name">{=JXCp0PJX}{FIRSTNAME} the Heiress</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_asrai_2']/@name">
		<xsl:attribute name="name">{=vCs1kf1z}Puritan male preacher</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_asrai_3']/@name">
		<xsl:attribute name="name">{=nNheEOBU}Rebellious female preacher</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_asrai_gangleader_1']/@name">
		<xsl:attribute name="name">{=VKZoMRc0}Standard male gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_asrai_gangleader_2']/@name">
		<xsl:attribute name="name">{=uaBJ5JFg}Female gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_asrai_gangleader_3']/@name">
		<xsl:attribute name="name">{=JliyBypF}Male gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_asrai_artisan_1']/@name">
		<xsl:attribute name="name">{=XeBFuEiN}Asrai Artisan 1</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_asrai_artisan_2']/@name">
		<xsl:attribute name="name">{=XeBFuEiN}Asrai Artisan 2</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_asrai_rural_1']/@name">
		<xsl:attribute name="name">{=GE29oqmD}Asrai yeoman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_asrai_rural_2']/@name">
		<xsl:attribute name="name">{=GE29oqmD}Asrai yeoman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_asrai_headman_1']/@name">
		<xsl:attribute name="name">{=mXWvk4Sb}Asrai rebellious headman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_asrai_headman_2']/@name">
		<xsl:attribute name="name">{=XyJrovDB}Asrai conservative headman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_asrai_headman_3']/@name">
		<xsl:attribute name="name">{=gySlb2Or}Asrai devious headman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='prison_guard_asrai']/@name">
		<xsl:attribute name="name">{=ubysnNf8}Prison Guard</xsl:attribute>
	</xsl:template>

	<!-- URBAN CHARACTERS OF eonir -->
	<xsl:template match="NPCCharacter[@id='blacksmith_eonir']/@name">
		<xsl:attribute name="name">{=Bc55IVvo}Eonir Blacksmith</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='weaponsmith_eonir']/@name">
		<xsl:attribute name="name">{=ThQnTYhY}Eonir Weaponsmith</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='armorer_eonir']/@name">
		<xsl:attribute name="name">{=sEoArnKv}Eonir Armorer</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='townsman_eonir']/@name">
		<xsl:attribute name="name">{=zrM5atg1}Toriour</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='townswoman_eonir']/@name">
		<xsl:attribute name="name">{=zrM5atg1}Toriour</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='villager_eonir']/@name">
		<xsl:attribute name="name">{=3EtMj0Cm}Faniour</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='village_woman_eonir']/@name">
		<xsl:attribute name="name">{=3EtMj0Cm}Faniour</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='barber_eonir']/@name">
		<xsl:attribute name="name">{=UVxUf985}Eonir Hairdresser</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='shop_worker_eonir']/@name">
		<xsl:attribute name="name">{=39Na3uUp}Eonir Shopworker</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tavernkeeper_eonir']/@name">
		<xsl:attribute name="name">{=vH9PAq5F}Eonir Tavernkeeper</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='musician_eonir']/@name">
		<xsl:attribute name="name">{=aCAt31d3}Eonir Musician</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='wench_eonir']/@name">
		<xsl:attribute name="name">{=Ic20Op6c}Eonir Dan</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='dancer_eonir']/@name">
		<xsl:attribute name="name">{=t6Wp8yl5}Eonir Dan</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='merchant_eonir']/@name">
		<xsl:attribute name="name">{=EecY2jTx}Eonir merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='horseMerchant_eonir']/@name">
		<xsl:attribute name="name">{=8cKHnEcH}Eonir Horse merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='merchant_notary_eonir']/@name">
		<xsl:attribute name="name">{=dkuAAleH}Eonir Merchant notary</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='artisan_notary_eonir']/@name">
		<xsl:attribute name="name">{=dkuAAleH}Eonir Artisan notary</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='rural_notable_notary_eonir']/@name">
		<xsl:attribute name="name">{=dkuAAleH}Eonir Rural notary</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='ransom_broker_eonir']/@name">
		<xsl:attribute name="name">{=8rT0F33G}Eonir Ransombroker</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='prison_guard_eonir']/@name">
		<xsl:attribute name="name">{=genMUJyE}Prison Guard</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='tournament_master_eonir']/@name">
		<xsl:attribute name="name">{=tp8SV1Ow}Tournament Master</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='gangleader_bodyguard_eonir']/@name">
		<xsl:attribute name="name">{=9ysraKi0}Eonir Gang Leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_eonir_merch1']/@name">
		<xsl:attribute name="name">{=UPkYTknh}Ironic eonir merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_eonir_merch2']/@name">
		<xsl:attribute name="name">{=kM2liUnY}curt eonir merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_eonir_merch2']/@name">
		<xsl:attribute name="name">{=1P0RDsMC}Daring eonir merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_eonir_merch4']/@name">
		<xsl:attribute name="name">{=oWNdJhlc}Softspoken eonir merchant</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_eonir_merch5']/@name">
		<xsl:attribute name="name">{=sGx53Rcj}{FIRSTNAME} the Manciple</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_eonir_1']/@name">
		<xsl:attribute name="name">{=F7nnlG4J}{FIRSTNAME} the Warehouser</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_eonir_1b']/@name">
		<xsl:attribute name="name">{=JXCp0PJX}{FIRSTNAME} the Heiress</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_eonir_2']/@name">
		<xsl:attribute name="name">{=vCs1kf1z}Puritan male preacher</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_eonir_3']/@name">
		<xsl:attribute name="name">{=nNheEOBU}Rebellious female preacher</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_eonir_gangleader_1']/@name">
		<xsl:attribute name="name">{=VKZoMRc0}Standard male gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_eonir_gangleader_2']/@name">
		<xsl:attribute name="name">{=uaBJ5JFg}Female gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_eonir_gangleader_3']/@name">
		<xsl:attribute name="name">{=JliyBypF}Male gang leader</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_eonir_artisan_1']/@name">
		<xsl:attribute name="name">{=xUSx6x7z}eonirn artisan 1</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_eonir_artisan_2']/@name">
		<xsl:attribute name="name">{=xUSx6x7z}eonirn artisan 2</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_eonir_rural_1']/@name">
		<xsl:attribute name="name">{=KymX0G9B}eonirn yeoman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_notable_eonir_rural_2']/@name">
		<xsl:attribute name="name">{=KymX0G9B}eonirn yeoman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_eonir_headman_1']/@name">
		<xsl:attribute name="name">{=YVJvzrWA}eeonirn rebellious headman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_eonir_headman_2']/@name">
		<xsl:attribute name="name">{=GY8cmXme}eeonirn conservative headman</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[@id='spc_eonir_headman_3']/@name">
		<xsl:attribute name="name">{=VRo8F2Kt}eeonirn devious headman</xsl:attribute>
	</xsl:template>
</xsl:stylesheet>