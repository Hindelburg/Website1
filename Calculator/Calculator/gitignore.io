# Download this file using PowerShell v3 under Windows with the following comand
# Invoke-WebRequest httpsgist.githubusercontent.comkmorcinek2710267raw -OutFile .gitignore
# or wget
# wget --no-check-certificate httpgist.githubusercontent.comkmorcinek2710267raw.gitignore

# User-specific files
.suo
.user
.sln.docstates

# Build results

[Dd]ebug
[Rr]elease
x64
build
[Bb]in
[Oo]bj

# NuGet Packages
.nupkg
# The packages folder can be ignored because of Package Restore
packages
# except build, which is used as an MSBuild target.
!packagesbuild
# Uncomment if necessary however generally it will be regenerated when needed
#!packagesrepositories.config

# MSTest test Results
[Tt]est[Rr]esult
[Bb]uild[Ll]og.

_i.c
_p.c
.ilk
.meta
.obj
.pch
.pdb
.pgc
.pgd
.rsp
.sbr
.tlb
.tli
.tlh
.tmp
.tmp_proj
.log
.vspscc
.vssscc
.builds
.pidb
.log
.scc

# OS generated files #
.DS_Store
Icon

# Visual C++ cache files
ipch
.aps
.ncb
.opensdf
.sdf
.cachefile

# Visual Studio profiler
.psess
.vsp
.vspx

# Guidance Automation Toolkit
.gpState

# ReSharper is a .NET coding add-in
_ReSharper
.[Rr]e[Ss]harper

# TeamCity is a build add-in
_TeamCity

# DotCover is a Code Coverage Tool
.dotCover

# NCrunch
.ncrunch
.crunch.local.xml

# Installshield output folder
[Ee]xpress

# DocProject is a documentation generator add-in
DocProjectbuildhelp
DocProjectHelp.HxT
DocProjectHelp.HxC
DocProjectHelp.hhc
DocProjectHelp.hhk
DocProjectHelp.hhp
DocProjectHelpHtml2
DocProjectHelphtml

# Click-Once directory
publish

# Publish Web Output
.Publish.xml

# Windows Azure Build Output
csx
.build.csdef

# Windows Store app package directory
AppPackages

# Others
.Cache
ClientBin
[Ss]tyle[Cc]op.
~$
~
.dbmdl
.[Pp]ublish.xml
.pfx
.publishsettings
modulesbin
tempbin

# EPiServer Site file (VPP)
AppData

# RIASilverlight projects
Generated_Code

# Backup & report files from converting an old project file to a newer
# Visual Studio version. Backup files are not needed, because we have git ;-)
_UpgradeReport_Files
Backup
UpgradeLog.XML
UpgradeLog.htm

# vim
.txt~
.swp
.swo
 
# svn
.svn

# Remainings from resolvings conflicts in Source Control
.orig

# SQL Server files
App_Data.mdf
App_Data.ldf
App_Data.sdf


#LightSwitch generated files
GeneratedArtifacts
_Pvt_Extensions
ModelManifest.xml

# =========================
# Windows detritus
# =========================

# Windows image file caches
Thumbs.db
ehthumbs.db

# Folder config file
Desktop.ini

# Recycle Bin used on file shares
$RECYCLE.BIN

# Mac desktop service store files
.DS_Store

# SASS Compiler cache
.sass-cache

# Visual Studio 2014 CTP
.sln.ide

# Visual Studio temp something
.vs

# VS 2015+
.vc.vc.opendb
.vc.db

# Rider
.idea

# Output folder used by Webpack or other FE stuff
node_modules
wwwroot

# SpecFlow specific
.feature.cs
.feature.xlsx.
.Specs_.html

#####
# End of core ignore list, below put you custom 'per project' settings (patterns or path)
#####