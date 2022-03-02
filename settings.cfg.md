## This is the documentation for Easy Installer v* package settings.cfg file.

### Available Sections:

- Settings *[SETTINGS]*
- Installation *[INSTALLATION]*
- Register Control Panel Program *[RegisterControlPanelProgram]*
- Shortcut *[Shortcut]*

### Usable variables:

- Installation Path *{INSTALLATION_PATH}*
- User Profile *{USERPROFILE}*

You can set the default files location. `default_files_location = {INSTALLATION_PATH}\`

- The installation section is used for specify files to put somewhere else than default location. The usage for it is **file_path_in_zip** = **file_path_where_want_to_extract**

### Shortcut *[Shortcut]*

Everything is **required** except `description` and `hotkey`. If you don't want to set this just delete the keys.

### Example cfg:
```
[SETTINGS]
default_files_location = {INSTALLATION_PATH}\

[INSTALLATION]
titkos.txt = {INSTALLATION_PATH}\titkos\titkos.txt
test\d_b_card_design.json = {INSTALLATION_PATH}\test\d_b_card_design.json
main_directory\hello.exe = {INSTALLATION_PATH}\hello.exe

[RegisterControlPanelProgram]
name = TestApp
publisher = Da4ndo
installation_path =  {INSTALLATION_PATH}
display_icon = {INSTALLATION_PATH}\icon.ico
uninstallstring = {INSTALLATION_PATH}\uninst.exe
display_version = 1.0.0

[Shortcut]
name = TestApp
description = This is the TestApp for testing :)
icon = {INSTALLATION_PATH}\icon.ico
target = {INSTALLATION_PATH}\hello.exe
hotkey = Ctrl+Shift+T
```

> If you use [RegisterControlPanelProgram] you must specify an uninstaller (uninstallstring). With a high chance you need to make one by yourself. The uninstaller must delete the key/keys from registry and delete the local files.