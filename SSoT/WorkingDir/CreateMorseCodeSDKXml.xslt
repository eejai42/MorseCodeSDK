<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:param name="output-filename" select="'output.txt'" />

    <xsl:template match="@* | node()">
        <xsl:copy>
            <xsl:apply-templates select="@* | node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="/*">
        <FileSet>
            <FileSetFiles>
                <FileSetFile>
                    <RelativePath>
                        <xsl:text>../MorseCodeSDK.xml</xsl:text>
                    </RelativePath>
                    <xsl:element name="FileContents" xml:space="preserve"><MorseCodeSDK>
    <Variants>
        <xsl:for-each select="//Variant">
            <xsl:variable name="variant" select="." />
            <Variant>
            <xsl:apply-templates select="*"/>
            <Characters>
                <xsl:for-each select="//Character">
                    <xsl:variable name="variant-signal-codes" select="*[name() = $variant/Name]" />
                    <Character>
                        <xsl:apply-templates select="Name"/>
                        <SignalCodes><xsl:value-of select="$variant-signal-codes" /></SignalCodes>
                        <Signals>
                            <xsl:call-template name="parse-variant-signal-codes">
                                <xsl:with-param name="signal-codes" select="$variant-signal-codes" />
                            </xsl:call-template>
                        </Signals>
                    </Character>
                </xsl:for-each>
            </Characters>
            </Variant>
        </xsl:for-each>
    </Variants>
</MorseCodeSDK>
</xsl:element>
                </FileSetFile>
            </FileSetFiles>
        </FileSet>
    </xsl:template>

    <xsl:template name="parse-variant-signal-codes">
        <xsl:param name="signal-codes" select="''" />
        <xsl:variable name="next-signal" select="substring($signal-codes, 1, 1)" />
        <xsl:if test="string-length($next-signal) = 1">
            <xsl:apply-templates select="//Signal[Symbol = $next-signal]"/>
            <xsl:variable name="remaining-signal-codes" select="substring($signal-codes, 2, string-length($signal-codes))" />
            <xsl:call-template name="parse-variant-signal-codes">
                <xsl:with-param name="signal-codes" select="$remaining-signal-codes" />
            </xsl:call-template>
        </xsl:if>
    </xsl:template>

    <xsl:template match="text()">
    <xsl:variable name="amp">&amp;</xsl:variable>
        <xsl:choose>
            <xsl:when test="string-length(substring-before(., $amp)) > 0">&lt;![CDATA[<xsl:copy-of select="."/>]]&gt;</xsl:when>
            <xsl:when test="string-length(substring-after(., $amp)) > 0">&lt;![CDATA[<xsl:copy-of select="."/>]]&gt;</xsl:when>
            <xsl:when test="normalize-space(.) = $amp">&lt;![CDATA[<xsl:copy-of select="."/>]]&gt;</xsl:when>
            <xsl:otherwise><xsl:value-of select="."/></xsl:otherwise>
        </xsl:choose>
    </xsl:template>
</xsl:stylesheet>
