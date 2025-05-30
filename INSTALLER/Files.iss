; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Online Shop"
#define MyAppVersion "1.5"
#define MyAppPublisher "Grace Ann"
#define MyAppURL "https://www.onlineshopui.com/"
#define MyAppExeName "EDP_ONLINE_SHOP.exe"
#define MyAppAssocName MyAppName + " File"
#define MyAppAssocExt ".myp"
#define MyAppAssocKey StringChange(MyAppAssocName, " ", "") + MyAppAssocExt

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{DA2C0DD2-A420-470A-9C13-5AA5D0D47CA6}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
UninstallDisplayIcon={app}\{#MyAppExeName}
ChangesAssociations=yes
DisableProgramGroupPage=yes
InfoBeforeFile=C:\Users\Grace Ann Lladone\Downloads\software.txt
; Uncomment the following line to run in non administrative install mode (install for current user only).
;PrivilegesRequired=lowest
OutputDir=C:\Users\Grace Ann Lladone\Documents
OutputBaseFilename=onlineshopui
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\BouncyCastle.Cryptography.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\BouncyCastle.Cryptography.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\EDP_ONLINE_SHOP.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\EDP_ONLINE_SHOP.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\EDP_ONLINE_SHOP.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\Google.Protobuf.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\Google.Protobuf.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\Google.Protobuf.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\K4os.Compression.LZ4.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\K4os.Compression.LZ4.Streams.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\K4os.Compression.LZ4.Streams.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\K4os.Compression.LZ4.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\K4os.Hash.xxHash.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\K4os.Hash.xxHash.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\Microsoft.Bcl.AsyncInterfaces.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\Microsoft.Bcl.AsyncInterfaces.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\MySql.Data.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\MySql.Data.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\System.Buffers.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\System.Buffers.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\System.Configuration.ConfigurationManager.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\System.Configuration.ConfigurationManager.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\System.Diagnostics.DiagnosticSource.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\System.Diagnostics.DiagnosticSource.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\System.IO.Pipelines.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\System.IO.Pipelines.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\System.Memory.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\System.Memory.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\System.Numerics.Vectors.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\System.Numerics.Vectors.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\System.Runtime.CompilerServices.Unsafe.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\System.Runtime.CompilerServices.Unsafe.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\System.Threading.Tasks.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\System.Threading.Tasks.Extensions.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Grace Ann Lladone\Documents\GitHub\edp\bin\Debug\ZstdSharp.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Registry]
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocExt}\OpenWithProgids"; ValueType: string; ValueName: "{#MyAppAssocKey}"; ValueData: ""; Flags: uninsdeletevalue
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}"; ValueType: string; ValueName: ""; ValueData: "{#MyAppAssocName}"; Flags: uninsdeletekey
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\{#MyAppExeName},0"
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

