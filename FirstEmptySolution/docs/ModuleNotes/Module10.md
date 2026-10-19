# Module 10 — Extensions

This final module covers extensions and extension-related productivity tools. Extension settings are owned by the extension and can change when it is updated; verify that the extension is installed and compatible with the current Visual Studio release.

## Settings and how to use them

### Manage extensions

- Open **Extensions > Manage Extensions** to browse, install, disable, update, or uninstall extensions.
- The **Installed**, **Updates**, **Online**, and **Roaming** sections (availability depends on release/account) show different extension sources/states.
- Most extension installs or updates require Visual Studio to close before the installer can apply changes. Restart the intended Visual Studio instance afterward.
- Prefer trusted publishers and review required permissions, supported Visual Studio versions, and update history before installing.

### Extension-specific options

- Extensions generally add their own section to **Tools > Options** or a toolbar/menu. Search the Options dialog for the extension name when the page is not obvious.
- Configure only the settings relevant to the course feature. Record the extension name and version when documenting a workflow, because labels and defaults can change between releases.
- If a feature disappears after an update, check **Extensions > Manage Extensions > Installed**, disable conflicting extensions, and restart Visual Studio before concluding that the base IDE behavior changed.
- Export Visual Studio settings before moving to another machine; extension packages and extension-owned state may not be included in the exported settings file.

### CodeShot and other capture/export extensions

- CodeShot-style extensions expose their actions in an extension menu, editor context menu, or command palette/menu. Choose the code selection and output options (theme, background, line numbers, and image/export format) in that UI.
- For CodeShot, select code and use **Edit > Copy as CodeShot** to copy an image or **Edit > Save as CodeShot** to write a PNG. Its options are under **Tools > Options > CodeShot**: **Background color** (transparent/custom/gradient), **Window style** (none/macOS/Windows), **Show line numbers**, **Shadow**, **Padding**, and **Font scale**. The syntax colors and font are taken from the Visual Studio editor theme/font.
- Review the captured image before sharing it: ensure secrets, private identifiers, and unrelated code are not included.
- These are extension settings, not built-in **Tools > Options > Text Editor** settings. Consult the installed extension's options/help for current labels.

### Visual/editor extensions

The lessons demonstrate extensions such as **Rainbow Braces**, **Solution Colors**, **File Icons**, and **ClaudiaIDE**:

- Rainbow Braces colorizes nested delimiter pairs. Its level colors are configured under **Tools > Options > Environment > Fonts and Colors**; the extension may add an on/off command or setting.
- Solution Colors assigns per-solution/working-directory colors. Configure automatic/manual color from the extension's **Tools > Solution Colors** menu.
- File Icons changes Solution Explorer icons by file type and generally requires no setup after installation.
- ClaudiaIDE configures an editor background under **Tools > Options > ClaudiaIDE**. Options include the image/folder path, opacity, position, slideshow interval, and display scope. Keep opacity low enough to preserve code readability.

### Productivity extensions

The lessons also cover **Add New File**, **Tweaks**, **Shifter**, **Comment Remover**, and **Bookmark Studio**:

- Add New File creates nested folders/files from a path entered in one dialog; its commonly shown shortcut is `Shift+F2`.
- Tweaks exposes independent behavior toggles under **Tools > Options > Tweaks**. Examples include start-page behavior, closing documents with a solution, Solution Explorer folder collapsing, copying a line when no selection exists, and running a single test on double-click.
- Shifter adjusts numbers, booleans, CSS values, and colors. Common defaults are `Shift+Alt+Up` and `Shift+Alt+Down`; confirm the extension's binding in Keyboard Options.
- Comment Remover adds commands under **Edit > Comment Remover** to remove all comments or selected comment categories. Review the diff; removal can delete meaningful documentation.
- Bookmark Studio provides numbered/grouped bookmark behavior and has extension-specific settings under **Tools > Options > Bookmark Studio**. This is separate from built-in bookmarks.
- Rainbow Braces commonly adds a toggle command (shown in the lesson as `Ctrl+Shift+9`); because this key can conflict with other layouts/extensions, verify its binding in Keyboard Options.

### Code quality extensions

The lessons demonstrate **Roslynator**, **CodeMaid**, and **EditorConfig Language Service**:

- Roslynator adds analyzer diagnostics and refactorings to the lightbulb/`Ctrl+.` workflow. Configure rule severity in **Tools > Options > Roslynator** where available or in `.roslynatorconfig`; analyzer package configuration can also be committed for build/CI consistency.
- CodeMaid offers cleaning, reorganization, and navigation views such as Spade. Configure individual cleanup steps under **Tools > CodeMaid > Options**; **Auto Clean on Save** can run cleanup on save. Avoid overlapping destructive cleanup steps with Visual Studio Code Cleanup profiles.
- EditorConfig Language Service adds syntax coloring, completion, and validation while editing `.editorconfig`. It improves the editor experience but does not replace the actual EditorConfig rules consumed by Visual Studio and command-line tools.

### Extension shortcuts and updates

Extension shortcut bindings are contributed dynamically. Search Keyboard Options for the extension/command name after installation; do not assume a shortcut shown in a lesson remains the default after an update or scheme change. Update or disable extensions from **Extensions > Manage Extensions**, then restart as prompted.

## Keyboard Options command names

Extension command IDs are contributed by the installed extension, so their exact names are not stable across versions. Open **Tools > Options > Environment > Keyboard**, search by the extension's name or feature, and assign a key in the appropriate scope.

| Command search term / ID | Purpose |
|---|---|
| `Tools.ExtensionsandUpdates` | Open Manage Extensions in versions using the legacy command name |
| `Extensions.ManageExtensions` | Search for Manage Extensions in versions exposing the newer command name |
| `Tools.ExternalTools` | Open External Tools if covered by the extension workflow |
| `CodeShot` | Search for the CodeShot command(s) contributed by the installed version |
| `Live Share` | Search for extension collaboration commands if installed |
| `Dev Tunnels` | Search for tunnel-management commands if installed |
| `Rainbow Braces` | Search for the toggle command (lesson example: `Ctrl+Shift+9`) |
| `Shifter` | Search for increase/decrease value commands |
| `Bookmark Studio` | Search for numbered bookmark commands |
| `CodeMaid` | Search for cleanup, reorganization, and Spade commands |
| `Comment Remover` | Search for comment-removal commands |
| `Add New File` | Search for the create-file command |

These search terms are intentionally not presented as guaranteed command IDs or default shortcuts. Confirm the exact command shown in your own Keyboard Options list before assigning a key. As a baseline, the built-in command **`Tools.ManageExtensions`** may be available in some Visual Studio releases.
