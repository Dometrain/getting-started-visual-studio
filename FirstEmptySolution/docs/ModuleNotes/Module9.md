# Module 9 — Miscellaneous Productivity Features

This module groups miscellaneous Visual Studio features, including rename, debugging and editing shortcuts, settings portability, Hot Reload, Live Share, and Dev Tunnels. **Hot Reload, Live Share, and Dev Tunnels are documented here rather than in Module 8.** Keyboard examples assume a **US English keyboard layout**.

## Settings and how to use them

### Clipboard history, editing, and build/run commands

- Visual Studio's clipboard ring can retain multiple copied items. Use its command from **Edit > Advanced** or the editor context menu; available behavior can depend on the keyboard scheme.
- The editor's common editing commands (line movement, comment toggling, selection, and case conversion) can be assigned in **Tools > Options > Environment > Keyboard**. Set the scope to **Text Editor** for editor-only bindings.
- **Debug > Start Debugging** launches with the debugger; **Debug > Start Without Debugging** launches the selected startup target without attaching a debugger. Startup project selection and launch profiles are configured at solution/project level, not through the shortcut itself.
- To keep the Build, Debug, Error List, and Output windows visible, arrange them as tool windows and save the layout from **Window > Save Window Layout**.
- **Tools > Options > Environment > General** includes environment/startup preferences. **Tools > Options > Environment > Keyboard** is where command bindings are searched and assigned; actual bindings depend on the selected mapping scheme.

### Rename refactoring (F2) — moved into Module 9

- Put the caret on a C# symbol (local, parameter, method, property, or type) and invoke **Rename**. Visual Studio updates references to that symbol, rather than performing a plain text replacement.
- Review the preview before applying a rename across a large solution.
- `F2` may be bound to Rename in the active keyboard scheme. If it is not, use **Edit > Refactor > Rename**, the editor lightbulb, or assign `Refactor.Rename` under **Tools > Options > Environment > Keyboard**. `Ctrl+R, Ctrl+R` is a common alternative binding.
- File rename and symbol rename are different operations. Use Solution Explorer to rename a file; use the refactoring command for a code symbol.

### Hot Reload

- Hot Reload applies supported code changes to a running application, reducing stop/rebuild/restart cycles. Not every edit, project type, runtime, or debugger configuration supports every change.
- **Tools > Options > Debugging > .NET/C++ Hot Reload** (page and labels depend on workload/version) contains Hot Reload behavior options. Search the Options dialog for **Hot Reload** if the exact page differs.
- Start the app under the debugger and use the Hot Reload action (commonly the flame icon) after an edit. If a change cannot be applied, Visual Studio reports that a restart is required.
- Hot Reload is not a substitute for verifying a clean build or running tests. Some changes can leave runtime state different from a fresh launch.

### Live Share

- Live Share is an extension/service workflow for collaborative sessions. Sign in and start or join a session from the Live Share toolbar/menu. The host controls which files, terminals, and servers are shared.
- Configure sharing and guest access in the Live Share extension's **Tools > Options > Live Share** page when available, and review the extension's current security/access options before sharing.
- Share only the files and terminals needed for the session; a shared terminal can expose powerful access to the host's environment.

### Dev Tunnels

- Dev Tunnels expose a local service through a secure tunnel for remote collaboration or testing. Create/manage tunnels from **View > Other Windows > Dev Tunnels** or the Dev Tunnels window/toolbar provided by the installed workload.
- Sign in and choose the tunnel's access/visibility settings deliberately. Use private or authenticated access unless a public endpoint is explicitly required.
- A tunnel forwards network access; it does not replace application authentication, authorization, or firewall rules. Stop a tunnel when it is no longer needed.

### Import/export settings and external tools

- **Tools > Import and Export Settings** exports selected environment categories (such as keyboard mappings, themes, and window layouts) and imports them into another profile.
- Export a backup before resetting or importing. Importing can overwrite existing settings depending on the choices made in the wizard.
- External tools are managed under **Tools > External Tools**. Configure title, command, arguments, initial directory, and output behavior; use Visual Studio macros such as `$(SolutionDir)` where supported. Avoid hard-coded paths if the tool should be portable.

### Devenv switches, settings sync, and preview features

- **Developer Command Prompt** and **Developer PowerShell** provide the Visual Studio environment for command-line tools. `devenv.exe` switches such as `/RootSuffix Exp` create/use an isolated experimental settings hive; `/Log` writes activity information for troubleshooting. Maintenance switches such as `/Setup` are not normal IDE launch options.
- **Tools > Import and Export Settings** can export selected categories (keyboard, fonts/colors, environment, and window layouts) or import a saved `.vssettings` file. Export a backup before resetting or importing settings.
- Sign-in and roaming settings are under **File > Account Settings**. Roaming/backup availability depends on account and product version; do not assume extension binaries or all extension-owned state will roam.
- **Tools > Options > Environment > Preview Features** enables/disables experimental IDE features. Preview features may be incomplete and can move or disappear; disable a preview when diagnosing unexpected behavior.
- **Tools > Options > Environment > General** includes startup and environment preferences. Search within Options for a setting label if Microsoft moves it between releases.

### Fonts, colors, themes, zoom, and popup transparency

- **Tools > Options > Environment > Fonts and Colors** selects a target surface (Text Editor, Environment Font, Output Window, Data Tips, and others) and lets you set foreground, background, and bold for individual display items.
- For editor behavior, useful items include **Current Line (Active)**, **Brace Matching**, **Highlighted Reference**, **Excluded Code**, **Inline Hints**, **Breakpoint**, and **Current Statement**. Keep contrast high enough for the active theme.
- **Tools > Options > Environment > General > Color theme** changes the built-in theme. Extensions such as Color Theme Designer add themes but are not required for the built-in choices.
- Editor zoom is adjusted from the editor zoom control or its keyboard commands; Output/other text tool windows may have their own zoom. Zoom changes display scale, not the stored code font setting.
- Debug Data Tips can be pinned and expanded while paused. Where supported, transparency is controlled by hovering the Data Tip and using its opacity control; settings are debugger/UI behavior, not C# code formatting.

### Visual Studio performance and help/support

- **Help > About Microsoft Visual Studio** shows the installed edition/version. **Help > Send Feedback** and **Help > Report a Problem** provide feedback/support routes.
- Under **Tools > Options > Environment** and **Tools > Options > Projects and Solutions**, reduce nonessential live analysis, startup windows, or automatic features if a large solution strains the machine. Prefer measuring before disabling diagnostics.
- Use **Debug > Performance Profiler** (`Alt+F2`) for CPU, memory, allocation, database, file I/O, async, or other supported measurements. Select only the tools relevant to the suspected bottleneck to limit profiler overhead.
- **Analyze > Calculate Code Metrics** reports structural metrics (such as maintainability and complexity) for supported projects. **Analyze > Run Code Analysis** runs configured analyzers; `.editorconfig`, analyzer packages, and project settings govern many of the rules.

### Extension management and garbage-collection visualization

- **Extensions > Manage Extensions** installs, updates, disables, and removes extensions. Check compatibility and publisher before installation; restart Visual Studio when prompted.
- **Tools > Options > Environment > Extensions** configures extension galleries where available. Add only trusted galleries.
- The lesson's GC visualization/“Secret Garbage Collector” feature depends on its corresponding extension or profiler view. Treat its displays as diagnostic aids; verify actual allocation/GC behavior with the Performance Profiler or runtime counters.

### Conditional compilation and preprocessor directives

- C# uses `#if`, `#elif`, `#else`, and `#endif` to include code according to compile-time symbols. `DEBUG` is a symbol, not a directive; `#debug` is not valid C# syntax.
- Configure symbols for the selected build configuration in **Project > Properties > Build > Conditional compilation symbols**. SDK-style projects can also define them with `DefineConstants` in the `.csproj` or `Directory.Build.props`. Confirm the active Debug/Release configuration in **Build > Configuration Manager**.
- `#define` and `#undef` are file-local and must appear before namespace/type declarations. Prefer configuration-level symbols for project-wide features.
- `#pragma warning disable CSxxxx` suppresses a specific compiler warning; pair it with `#pragma warning restore CSxxxx` as narrowly as possible and explain why. Consider analyzer severity in `.editorconfig` for policy-wide changes instead.
- `#nullable enable`/`disable` can change nullable analysis for a file or region. It does not switch runtime null checks on or off.
- To change the appearance of inactive conditional code, use **Tools > Options > Environment > Fonts and Colors**, set **Show settings for** to **Text Editor**, and customize **Excluded Code**. This only changes appearance; the active compilation symbol still determines which branch builds.

## Keyboard Options command names

Search command IDs under **Tools > Options > Environment > Keyboard**. Defaults depend on the active scheme and Visual Studio version.

| Keyboard Options command | Common US binding / purpose |
|---|---|
| `Refactor.Rename` | `F2` where assigned; otherwise `Ctrl+R, Ctrl+R` |
| `Edit.FindAllReferences` | `Shift+F12` |
| `Edit.GoToDefinition` | `F12` |
| `Edit.PeekDefinition` | `Alt+F12` |
| `Debug.Start` | `F5` |
| `Debug.StartWithoutDebugging` | `Ctrl+F5` |
| `Debug.StopDebugging` | `Shift+F5` |
| `Debug.Restart` | `Ctrl+Shift+F5` |
| `Debug.ToggleBreakpoint` | `F9` |
| `Debug.StepOver` | `F10` |
| `Debug.StepInto` | `F11` |
| `Debug.StepOut` | `Shift+F11` |
| `File.SaveAll` | `Ctrl+Shift+S` |
| `Tools.ImportandExportSettings` | Open Import and Export Settings where available |
| `Tools.Options` | Open Options where available |
| `Tools.AccountSettings` | Open account settings where available |
| `Tools.ExtensionsandUpdates` | Open Manage Extensions |
| `Tools.ExternalTools` | Open/configure External Tools where available |
| `Tools.ExternalCommand1` … `Tools.ExternalCommandN` | Run configured external tools |
| `Tools.CreateGUID` | Open Create GUID |
| `Tools.CommandPrompt` | Open Developer Command Prompt |
| `View.DeveloperPowerShell` | Open Developer PowerShell |
| `View.Terminal` | Open the integrated terminal |
| `Edit.CycleClipboardRing` | `Ctrl+Shift+V` — cycle the clipboard ring |
| `Edit.FormatDocument` | `Ctrl+K, Ctrl+D` |
| `Edit.FormatSelection` | `Ctrl+K, Ctrl+F` |
| `Edit.DeleteHorizontalWhiteSpace` | `Ctrl+K, Ctrl+\` |
| `Edit.CommentSelection` / `Edit.UncommentSelection` | `Ctrl+K, Ctrl+C` / `Ctrl+K, Ctrl+U` |
| `Edit.Duplicate` | `Ctrl+E, Ctrl+V` — duplicate line/selection |
| `Edit.LineDelete` | `Ctrl+Shift+L` — delete line |
| `Edit.WordDeleteToEnd` | `Ctrl+Delete` |
| `Edit.ToggleOutliningExpansion` | `Ctrl+M, Ctrl+M` |
| `Edit.CollapseToDefinitions` | `Ctrl+M, Ctrl+O` |
| `Edit.ToggleAllOutlining` | `Ctrl+M, Ctrl+L` |
| `Edit.MakeLowercase` / `Edit.MakeUppercase` | `Ctrl+U` / `Ctrl+Shift+U` |
| `Edit.ParameterInfo` | `Ctrl+Shift+Space` — Parameter Info |
| `Edit.CompleteWord` | `Ctrl+Space` — IntelliSense |
| `Edit.GotoBrace` / `Edit.GotoBraceExtend` | `Ctrl+]` / `Ctrl+Shift+]` |
| `Edit.GoTo` | `Ctrl+G` — Go To Line |
| `Build.BuildSolution` | `Ctrl+Shift+B` — build solution |
| `Build.BuildSelection` | Build selected project |
| `Build.RebuildSolution` | `Ctrl+Alt+F7` — rebuild solution |
| `Help.ManageVisualStudioPerformance` | Manage Visual Studio Performance |
| `Debug.PerformanceProfiler` | `Alt+F2` — Performance Profiler |
| `Debug.DiagnosticsHub.Toolwindow` | `Ctrl+Alt+F2` — Diagnostic Tools |
| `Analyze.CalculateCodeMetricsforSolution` | Calculate solution Code Metrics |
| `Help.About` | About Visual Studio |
| `Feedback.ReportaProblem` | Report a Problem |
| `Feedback.SuggestaFeature` | Suggest a Feature |
| `View.ZoomIn` / `View.ZoomOut` | Zoom in/out on supported views |
| `Window.QuickLaunch` | `Ctrl+Q` — Visual Studio Search |

Live Share and Dev Tunnels commands are commonly exposed through tool-window buttons rather than stable default keyboard shortcuts. Search for `Live Share` or `Dev Tunnels` in Keyboard Options if you want to assign a shortcut.
