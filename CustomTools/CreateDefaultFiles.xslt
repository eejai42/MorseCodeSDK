<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>
    <xsl:include href="../CommonXsltTemplates.xslt"/>
    <xsl:param name="project-name" select="'SSoTme-MS-Ionic-Seed'" />
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
                        <xsl:text>../MVCRestApi/Web.config</xsl:text>
                    </RelativePath>
                    <OverwriteMode>Never</OverwriteMode>
                    <xsl:element name="FileContents" xml:space="preserve">&lt;?xml version="1.0" encoding="utf-8"?>
&lt;!--
  For more information on how to configure your ASP.NET application, please visit
  https://go.microsoft.com/fwlink/?LinkId=301879
  -->
&lt;configuration>
  &lt;appSettings>
    &lt;add key="webpages:Version" value="3.0.0.0" />
    &lt;add key="webpages:Enabled" value="false" />
    &lt;add key="ClientValidationEnabled" value="true" />
    &lt;add key="UnobtrusiveJavaScriptEnabled" value="true" />
  &lt;/appSettings>
    &lt;connectionStrings>
        &lt;clear />
        &lt;add name="DefaultConnection" connectionString="Data Source=.;Initial Catalog=<xsl:value-of select="$project-name" />;Integrated Security=sspi" />
    &lt;/connectionStrings>
  &lt;system.web>
    &lt;compilation debug="true" targetFramework="4.6.1" />
    &lt;httpRuntime targetFramework="4.6.1" />
    &lt;httpModules>
      &lt;add name="ApplicationInsightsWebTracking" type="Microsoft.ApplicationInsights.Web.ApplicationInsightsHttpModule, Microsoft.AI.Web" />
    &lt;/httpModules>
  &lt;/system.web>
  &lt;system.webServer>
    &lt;handlers>
      &lt;remove name="ExtensionlessUrlHandler-Integrated-4.0" />
      &lt;remove name="OPTIONSVerbHandler" />
      &lt;remove name="TRACEVerbHandler" />
      &lt;add name="ExtensionlessUrlHandler-Integrated-4.0" path="*." verb="*" type="System.Web.Handlers.TransferRequestHandler" preCondition="integratedMode,runtimeVersionv4.0" />
    &lt;/handlers>
    &lt;validation validateIntegratedModeConfiguration="false" />
    &lt;modules>
      &lt;remove name="TelemetryCorrelationHttpModule" />
      &lt;add name="TelemetryCorrelationHttpModule" type="Microsoft.AspNet.TelemetryCorrelation.TelemetryCorrelationHttpModule, Microsoft.AspNet.TelemetryCorrelation" preCondition="integratedMode,managedHandler" />
      &lt;remove name="ApplicationInsightsWebTracking" />
      &lt;add name="ApplicationInsightsWebTracking" type="Microsoft.ApplicationInsights.Web.ApplicationInsightsHttpModule, Microsoft.AI.Web" preCondition="managedHandler" />
    &lt;/modules>
  &lt;/system.webServer>
  &lt;runtime>
    &lt;assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      &lt;dependentAssembly>
        &lt;assemblyIdentity name="Newtonsoft.Json" culture="neutral" publicKeyToken="30ad4fe6b2a6aeed" />
        &lt;bindingRedirect oldVersion="0.0.0.0-10.0.0.0" newVersion="10.0.0.0" />
      &lt;/dependentAssembly>
      &lt;dependentAssembly>
        &lt;assemblyIdentity name="System.Web.Optimization" publicKeyToken="31bf3856ad364e35" />
        &lt;bindingRedirect oldVersion="1.0.0.0-1.1.0.0" newVersion="1.1.0.0" />
      &lt;/dependentAssembly>
      &lt;dependentAssembly>
        &lt;assemblyIdentity name="WebGrease" publicKeyToken="31bf3856ad364e35" />
        &lt;bindingRedirect oldVersion="0.0.0.0-1.6.5135.21930" newVersion="1.6.5135.21930" />
      &lt;/dependentAssembly>
      &lt;dependentAssembly>
        &lt;assemblyIdentity name="System.Web.Helpers" publicKeyToken="31bf3856ad364e35" />
        &lt;bindingRedirect oldVersion="1.0.0.0-3.0.0.0" newVersion="3.0.0.0" />
      &lt;/dependentAssembly>
      &lt;dependentAssembly>
        &lt;assemblyIdentity name="System.Web.WebPages" publicKeyToken="31bf3856ad364e35" />
        &lt;bindingRedirect oldVersion="1.0.0.0-3.0.0.0" newVersion="3.0.0.0" />
      &lt;/dependentAssembly>
      &lt;dependentAssembly>
        &lt;assemblyIdentity name="System.Web.Mvc" publicKeyToken="31bf3856ad364e35" />
        &lt;bindingRedirect oldVersion="1.0.0.0-5.2.3.0" newVersion="5.2.3.0" />
      &lt;/dependentAssembly>
      &lt;dependentAssembly>
        &lt;assemblyIdentity name="Antlr3.Runtime" publicKeyToken="eb42632606e9261f" culture="neutral" />
        &lt;bindingRedirect oldVersion="0.0.0.0-3.5.0.2" newVersion="3.5.0.2" />
      &lt;/dependentAssembly>
      &lt;dependentAssembly>
        &lt;assemblyIdentity name="System.Diagnostics.DiagnosticSource" publicKeyToken="cc7b13ffcd2ddd51" culture="neutral" />
        &lt;bindingRedirect oldVersion="0.0.0.0-4.0.2.1" newVersion="4.0.2.1" />
      &lt;/dependentAssembly>
    &lt;/assemblyBinding>
  &lt;/runtime>
  &lt;system.codedom>
    &lt;compilers>
      &lt;compiler language="c#;cs;csharp" extension=".cs" type="Microsoft.CodeDom.Providers.DotNetCompilerPlatform.CSharpCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=1.0.8.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" warningLevel="4" compilerOptions="/langversion:default /nowarn:1659;1699;1701" />
      &lt;compiler language="vb;vbs;visualbasic;vbscript" extension=".vb" type="Microsoft.CodeDom.Providers.DotNetCompilerPlatform.VBCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=1.0.8.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" warningLevel="4" compilerOptions="/langversion:default /nowarn:41008 /define:_MYTYPE=\&amp;quot;Web\&amp;quot; /optionInfer+" />
    &lt;/compilers>
  &lt;/system.codedom>
&lt;/configuration>
                    </xsl:element>
                </FileSetFile>
                <FileSetFile>
                    <RelativePath>
                        <xsl:text>../</xsl:text>
                        <xsl:value-of select="$project-name"/>
                        <xsl:text>.sln</xsl:text>
                    </RelativePath>
                    <OverwriteMode>Never</OverwriteMode>
                    <xsl:element name="FileContents" xml:space="preserve">
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.26730.16
MinimumVisualStudioVersion = 10.0.40219.1
Project("{E24C65DC-7377-472B-9ABA-BC803B73C61A}") = "SSoT", "SSoT\", "{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}"
	ProjectSection(WebsiteProperties) = preProject
		TargetFrameworkMoniker = ".NETFramework,Version%3Dv4.0"
		Debug.AspNetCompiler.VirtualPath = "/localhost_59839"
		Debug.AspNetCompiler.PhysicalPath = "SSoT\"
		Debug.AspNetCompiler.TargetPath = "PrecompiledWeb\localhost_59839\"
		Debug.AspNetCompiler.Updateable = "true"
		Debug.AspNetCompiler.ForceOverwrite = "true"
		Debug.AspNetCompiler.FixedNames = "false"
		Debug.AspNetCompiler.Debug = "True"
		Release.AspNetCompiler.VirtualPath = "/localhost_59839"
		Release.AspNetCompiler.PhysicalPath = "SSoT\"
		Release.AspNetCompiler.TargetPath = "PrecompiledWeb\localhost_59839\"
		Release.AspNetCompiler.Updateable = "true"
		Release.AspNetCompiler.ForceOverwrite = "true"
		Release.AspNetCompiler.FixedNames = "false"
		Release.AspNetCompiler.Debug = "False"
		VWDPort = "59839"
		SlnRelativePath = "SSoT\"
	EndProjectSection
EndProject
Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "Config", "Config", "{419B1AF3-2AB0-4740-8478-B1230325AA16}"
	ProjectSection(SolutionItems) = preProject
		Docs\SinglePageDocs.html = Docs\SinglePageDocs.html
	EndProjectSection
EndProject
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "CoreLibrary", "CoreLibrary\CoreLibrary.csproj", "{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}"
EndProject
Project("{E24C65DC-7377-472B-9ABA-BC803B73C61A}") = "ODXML", "ODXML\", "{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}"
	ProjectSection(WebsiteProperties) = preProject
		TargetFrameworkMoniker = ".NETFramework,Version%3Dv4.0"
		Debug.AspNetCompiler.VirtualPath = "/localhost_59878"
		Debug.AspNetCompiler.PhysicalPath = "ODXML\"
		Debug.AspNetCompiler.TargetPath = "PrecompiledWeb\localhost_59878\"
		Debug.AspNetCompiler.Updateable = "true"
		Debug.AspNetCompiler.ForceOverwrite = "true"
		Debug.AspNetCompiler.FixedNames = "false"
		Debug.AspNetCompiler.Debug = "True"
		Release.AspNetCompiler.VirtualPath = "/localhost_59878"
		Release.AspNetCompiler.PhysicalPath = "ODXML\"
		Release.AspNetCompiler.TargetPath = "PrecompiledWeb\localhost_59878\"
		Release.AspNetCompiler.Updateable = "true"
		Release.AspNetCompiler.ForceOverwrite = "true"
		Release.AspNetCompiler.FixedNames = "false"
		Release.AspNetCompiler.Debug = "False"
		VWDPort = "59878"
		SlnRelativePath = "ODXML\"
	EndProjectSection
EndProject
Project("{E24C65DC-7377-472B-9ABA-BC803B73C61A}") = "SqlServer", "SqlServer\", "{5546C69F-57F6-4DDD-901F-3F3225577B79}"
	ProjectSection(WebsiteProperties) = preProject
		TargetFrameworkMoniker = ".NETFramework,Version%3Dv4.0"
		Debug.AspNetCompiler.VirtualPath = "/localhost_59880"
		Debug.AspNetCompiler.PhysicalPath = "SqlServer\"
		Debug.AspNetCompiler.TargetPath = "PrecompiledWeb\localhost_59880\"
		Debug.AspNetCompiler.Updateable = "true"
		Debug.AspNetCompiler.ForceOverwrite = "true"
		Debug.AspNetCompiler.FixedNames = "false"
		Debug.AspNetCompiler.Debug = "True"
		Release.AspNetCompiler.VirtualPath = "/localhost_59880"
		Release.AspNetCompiler.PhysicalPath = "SqlServer\"
		Release.AspNetCompiler.TargetPath = "PrecompiledWeb\localhost_59880\"
		Release.AspNetCompiler.Updateable = "true"
		Release.AspNetCompiler.ForceOverwrite = "true"
		Release.AspNetCompiler.FixedNames = "false"
		Release.AspNetCompiler.Debug = "False"
		VWDPort = "59880"
		SlnRelativePath = "SqlServer\"
	EndProjectSection
EndProject
Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "CSharp", "CSharp", "{0A541AE6-FA3A-464B-8B0B-1AA73CC0C164}"
EndProject
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "WinApp", "WinApp\WinApp.csproj", "{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Android = Debug|Android
		Debug|Any CPU = Debug|Any CPU
		Debug|iOS = Debug|iOS
		Debug|Windows-AnyCPU = Debug|Windows-AnyCPU
		Debug|Windows-ARM = Debug|Windows-ARM
		Debug|Windows-x64 = Debug|Windows-x64
		Debug|Windows-x86 = Debug|Windows-x86
		Release|Android = Release|Android
		Release|Any CPU = Release|Any CPU
		Release|iOS = Release|iOS
		Release|Windows-AnyCPU = Release|Windows-AnyCPU
		Release|Windows-ARM = Release|Windows-ARM
		Release|Windows-x64 = Release|Windows-x64
		Release|Windows-x86 = Release|Windows-x86
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Debug|Android.ActiveCfg = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Debug|Android.Build.0 = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Debug|iOS.ActiveCfg = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Debug|iOS.Build.0 = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Debug|Windows-AnyCPU.ActiveCfg = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Debug|Windows-AnyCPU.Build.0 = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Debug|Windows-ARM.ActiveCfg = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Debug|Windows-ARM.Build.0 = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Debug|Windows-x64.ActiveCfg = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Debug|Windows-x64.Build.0 = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Debug|Windows-x86.ActiveCfg = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Debug|Windows-x86.Build.0 = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Release|Android.ActiveCfg = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Release|Android.Build.0 = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Release|Any CPU.ActiveCfg = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Release|Any CPU.Build.0 = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Release|iOS.ActiveCfg = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Release|iOS.Build.0 = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Release|Windows-AnyCPU.ActiveCfg = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Release|Windows-AnyCPU.Build.0 = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Release|Windows-ARM.ActiveCfg = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Release|Windows-ARM.Build.0 = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Release|Windows-x64.ActiveCfg = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Release|Windows-x64.Build.0 = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Release|Windows-x86.ActiveCfg = Debug|Any CPU
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B}.Release|Windows-x86.Build.0 = Debug|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Debug|Android.ActiveCfg = Debug|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Debug|Android.Build.0 = Debug|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Debug|iOS.ActiveCfg = Debug|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Debug|iOS.Build.0 = Debug|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Debug|Windows-AnyCPU.ActiveCfg = Debug|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Debug|Windows-AnyCPU.Build.0 = Debug|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Debug|Windows-ARM.ActiveCfg = Debug|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Debug|Windows-ARM.Build.0 = Debug|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Debug|Windows-x64.ActiveCfg = Debug|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Debug|Windows-x64.Build.0 = Debug|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Debug|Windows-x86.ActiveCfg = Debug|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Debug|Windows-x86.Build.0 = Debug|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Release|Android.ActiveCfg = Release|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Release|Android.Build.0 = Release|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Release|Any CPU.Build.0 = Release|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Release|iOS.ActiveCfg = Release|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Release|iOS.Build.0 = Release|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Release|Windows-AnyCPU.ActiveCfg = Release|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Release|Windows-AnyCPU.Build.0 = Release|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Release|Windows-ARM.ActiveCfg = Release|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Release|Windows-ARM.Build.0 = Release|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Release|Windows-x64.ActiveCfg = Release|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Release|Windows-x64.Build.0 = Release|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Release|Windows-x86.ActiveCfg = Release|Any CPU
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF}.Release|Windows-x86.Build.0 = Release|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Debug|Android.ActiveCfg = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Debug|Android.Build.0 = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Debug|iOS.ActiveCfg = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Debug|iOS.Build.0 = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Debug|Windows-AnyCPU.ActiveCfg = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Debug|Windows-AnyCPU.Build.0 = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Debug|Windows-ARM.ActiveCfg = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Debug|Windows-ARM.Build.0 = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Debug|Windows-x64.ActiveCfg = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Debug|Windows-x64.Build.0 = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Debug|Windows-x86.ActiveCfg = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Debug|Windows-x86.Build.0 = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Release|Android.ActiveCfg = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Release|Android.Build.0 = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Release|Any CPU.ActiveCfg = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Release|Any CPU.Build.0 = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Release|iOS.ActiveCfg = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Release|iOS.Build.0 = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Release|Windows-AnyCPU.ActiveCfg = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Release|Windows-AnyCPU.Build.0 = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Release|Windows-ARM.ActiveCfg = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Release|Windows-ARM.Build.0 = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Release|Windows-x64.ActiveCfg = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Release|Windows-x64.Build.0 = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Release|Windows-x86.ActiveCfg = Debug|Any CPU
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967}.Release|Windows-x86.Build.0 = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Debug|Android.ActiveCfg = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Debug|Android.Build.0 = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Debug|iOS.ActiveCfg = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Debug|iOS.Build.0 = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Debug|Windows-AnyCPU.ActiveCfg = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Debug|Windows-AnyCPU.Build.0 = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Debug|Windows-ARM.ActiveCfg = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Debug|Windows-ARM.Build.0 = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Debug|Windows-x64.ActiveCfg = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Debug|Windows-x64.Build.0 = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Debug|Windows-x86.ActiveCfg = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Debug|Windows-x86.Build.0 = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Release|Android.ActiveCfg = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Release|Android.Build.0 = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Release|Any CPU.ActiveCfg = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Release|Any CPU.Build.0 = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Release|iOS.ActiveCfg = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Release|iOS.Build.0 = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Release|Windows-AnyCPU.ActiveCfg = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Release|Windows-AnyCPU.Build.0 = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Release|Windows-ARM.ActiveCfg = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Release|Windows-ARM.Build.0 = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Release|Windows-x64.ActiveCfg = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Release|Windows-x64.Build.0 = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Release|Windows-x86.ActiveCfg = Debug|Any CPU
		{5546C69F-57F6-4DDD-901F-3F3225577B79}.Release|Windows-x86.Build.0 = Debug|Any CPU
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|Android.ActiveCfg = Debug|Android
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|Android.Build.0 = Debug|Android
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|Android.Deploy.0 = Debug|Android
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|Any CPU.ActiveCfg = Debug|Android
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|iOS.ActiveCfg = Debug|iOS
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|iOS.Build.0 = Debug|iOS
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|iOS.Deploy.0 = Debug|iOS
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|Windows-AnyCPU.ActiveCfg = Debug|Windows-AnyCPU
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|Windows-AnyCPU.Build.0 = Debug|Windows-AnyCPU
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|Windows-AnyCPU.Deploy.0 = Debug|Windows-AnyCPU
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|Windows-ARM.ActiveCfg = Debug|Windows-ARM
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|Windows-ARM.Build.0 = Debug|Windows-ARM
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|Windows-ARM.Deploy.0 = Debug|Windows-ARM
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|Windows-x64.ActiveCfg = Debug|Windows-x64
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|Windows-x64.Build.0 = Debug|Windows-x64
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|Windows-x64.Deploy.0 = Debug|Windows-x64
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|Windows-x86.ActiveCfg = Debug|Windows-x86
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|Windows-x86.Build.0 = Debug|Windows-x86
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Debug|Windows-x86.Deploy.0 = Debug|Windows-x86
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|Android.ActiveCfg = Release|Android
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|Android.Build.0 = Release|Android
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|Android.Deploy.0 = Release|Android
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|Any CPU.ActiveCfg = Release|Android
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|iOS.ActiveCfg = Release|iOS
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|iOS.Build.0 = Release|iOS
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|iOS.Deploy.0 = Release|iOS
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|Windows-AnyCPU.ActiveCfg = Release|Windows-AnyCPU
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|Windows-AnyCPU.Build.0 = Release|Windows-AnyCPU
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|Windows-AnyCPU.Deploy.0 = Release|Windows-AnyCPU
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|Windows-ARM.ActiveCfg = Release|Windows-ARM
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|Windows-ARM.Build.0 = Release|Windows-ARM
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|Windows-ARM.Deploy.0 = Release|Windows-ARM
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|Windows-x64.ActiveCfg = Release|Windows-x64
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|Windows-x64.Build.0 = Release|Windows-x64
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|Windows-x64.Deploy.0 = Release|Windows-x64
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|Windows-x86.ActiveCfg = Release|Windows-x86
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|Windows-x86.Build.0 = Release|Windows-x86
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD}.Release|Windows-x86.Deploy.0 = Release|Windows-x86
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Debug|Android.ActiveCfg = Debug|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Debug|Android.Build.0 = Debug|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Debug|iOS.ActiveCfg = Debug|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Debug|iOS.Build.0 = Debug|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Debug|Windows-AnyCPU.ActiveCfg = Debug|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Debug|Windows-AnyCPU.Build.0 = Debug|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Debug|Windows-ARM.ActiveCfg = Debug|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Debug|Windows-ARM.Build.0 = Debug|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Debug|Windows-x64.ActiveCfg = Debug|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Debug|Windows-x64.Build.0 = Debug|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Debug|Windows-x86.ActiveCfg = Debug|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Debug|Windows-x86.Build.0 = Debug|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Release|Android.ActiveCfg = Release|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Release|Android.Build.0 = Release|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Release|Any CPU.Build.0 = Release|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Release|iOS.ActiveCfg = Release|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Release|iOS.Build.0 = Release|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Release|Windows-AnyCPU.ActiveCfg = Release|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Release|Windows-AnyCPU.Build.0 = Release|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Release|Windows-ARM.ActiveCfg = Release|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Release|Windows-ARM.Build.0 = Release|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Release|Windows-x64.ActiveCfg = Release|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Release|Windows-x64.Build.0 = Release|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Release|Windows-x86.ActiveCfg = Release|Any CPU
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0}.Release|Windows-x86.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(NestedProjects) = preSolution
		{7FDA781F-B802-4C2B-AD88-5E61FC0E827B} = {419B1AF3-2AB0-4740-8478-B1230325AA16}
		{C3C5F7F6-D9D8-4165-911B-0527B69EA7EF} = {0A541AE6-FA3A-464B-8B0B-1AA73CC0C164}
		{A40F7CDC-1AD8-44A0-BFAC-BC6CF2D9D967} = {419B1AF3-2AB0-4740-8478-B1230325AA16}
		{5546C69F-57F6-4DDD-901F-3F3225577B79} = {419B1AF3-2AB0-4740-8478-B1230325AA16}
		{549CBA80-397B-4F8E-BB0E-5944E9D7E7DD} = {223A3EF4-7F7F-47E5-9601-A1DE95684ECE}
		{EFE45374-1DB7-4E92-AC9C-9B047DD5B8D0} = {0A541AE6-FA3A-464B-8B0B-1AA73CC0C164}
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {3B3E5043-67BA-4195-943E-FD31E9B5D30F}
	EndGlobalSection
EndGlobal

</xsl:element>
                </FileSetFile>
            </FileSetFiles>
        </FileSet>
    </xsl:template>
</xsl:stylesheet>
