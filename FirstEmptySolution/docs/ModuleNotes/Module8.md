# Module 8 — Useful Windows and Tools

This reference covers the Visual Studio tool windows and workflows demonstrated in Module 8: Task List, Error List, Output, Command Window, C# Interactive, Terminal, Object Browser, Code Definition Window, Find All References, Call Hierarchy, Properties, Toolbox, Server Explorer, SQL Server Object Explorer, Git, Test Explorer, and Live Unit Testing. Menu labels and command availability may vary slightly by Visual Studio release.

## Settings and how to use them

### Solution Explorer and document context

- **Tools > Options > Projects and Solutions > General > Track Active Item in Solution Explorer** automatically selects the file currently open in the editor. Turn it on for navigation through a large solution; turn it off if it disrupts manual tree browsing.
- In Solution Explorer, use the toolbar to switch between **Solution View** and **Folder View** when the physical directory layout is more useful than project grouping.
- **Show All Files** reveals files present on disk but not included in a project. This is a view toggle, not a project inclusion operation.
- **Tools > Options > Environment > Preview Features** can expose preview Solution Explorer/project features. Preview availability depends on the installed release.

### Task List and Error List

- **Task List** is opened from **View > Task List**. Its **Comments** view collects comment tokens, while **User Tasks** are personal items stored with the solution's user state.
- Add/change comment tokens and priorities under **Tools > Options > Environment > Task List**. The built-in tokens include `TODO`, `HACK`, `UNDONE`, and `NOTE`; custom tokens such as `PERF` or `SECURITY` can be assigned High/Normal/Low priority. The **Enumerate comment tasks** option controls whether comments are scanned.
- **Error List** filters by scope (entire solution/open documents/current project) and source (Build/IntelliSense). Use the source filter to distinguish build diagnostics from live editor analysis; use the scope filter when investigating a large solution.
- **Tools > Options > All Settings > Languages > C# > Advanced** controls the analysis scope that supplies live diagnostics.

### Output and Command Window

- **Output** is opened from **View > Output**; select a source such as Build, Debug, Tests, or source control in **Show output from**. Clear the pane before reproducing an issue so new output is easy to isolate.
- **Command Window** is opened from **View > Other Windows > Command Window**. It executes Visual Studio IDE commands; it is not a shell. Use `>` in the main Search/Quick Launch box to discover commands without opening the Command Window.
- Command Window aliases are user-profile settings. Use `alias` to list them and `alias <name> <command>` to define one; export settings before using reset operations because aliases can be cleared.

### C# Interactive and Terminal

- **C# Interactive** is opened from **View > Other Windows > C# Interactive**. It evaluates C# in an interactive session; use **Execute in Interactive** for selected code where available. Initialize the session with the project when you need its references and imports.
- **View > Terminal** opens the integrated terminal. Use its profile selector to choose PowerShell, Developer PowerShell, Command Prompt, or another configured shell. Terminal profiles and startup configuration are managed from the terminal profile UI/Visual Studio terminal settings; shell environment variables and PATH are separate from Visual Studio editor options.
- **Developer PowerShell** and **Developer Command Prompt** initialize the shell for Visual Studio tools. Prefer these for `MSBuild`, `devenv`, and developer command-line utilities when the standard shell lacks the required environment.

### Object Browser, Class View, Code Definition Window, and Call Hierarchy

- **Object Browser** explores namespaces, types, and members in referenced assemblies. Use its scope selector to choose the solution/current project or a .NET/framework component, then search for the API.
- **Class View** presents project types and members. It is a structural browser, not a source-file view.
- **Code Definition Window** follows the selected symbol and shows its definition while you navigate. Pin the window or disable its automatic tracking when you want to keep one definition visible. Use Peek Definition for an inline temporary inspection.
- **Call Hierarchy** is opened from a symbol's context menu or **View > Call Hierarchy**. Expand **Calls To** and **Calls From** to inspect callers and callees. Remove a root from the hierarchy when the result tree becomes cluttered.
- Find All References results support grouping, filters, and **Keep Results** to preserve earlier result sets. Reference highlighting can be controlled under **Tools > Options > Text Editor > General > Highlight references to symbol under cursor**; customize **Highlighted Reference** and **Highlighted Written Reference** in **Environment > Fonts and Colors**.

### Properties, Toolbox, Server Explorer, and SQL Server Object Explorer

- **Properties** displays properties of the selected solution, project, file, or designer component. The contents change with the selection; use **F4** to open the window.
- **Toolbox** contents depend on the active designer/editor and its selected category. Pin or auto-hide it as appropriate. **Tools > Choose Toolbox Items** manages installed components; toolbox snippets can be dragged into supported editors.
- **Server Explorer** shows configured connections and data sources. **SQL Server Object Explorer** is the SQL-specific tree for servers, databases, tables, and query actions; use the context menu to connect, query, or compare schema.
- SQL connection options are provided by the relevant connection dialog. Under **Tools > Options > SQL Server Tools**, configure SQL tooling behavior when the installed workload provides that page.
- Schema/data comparison **Options** determine which differences are ignored (such as whitespace or column order) and whether possible data loss blocks an update. Inspect these before generating or applying a database update.

### Find All References and search

- Use **Find All References** from a symbol's context menu or the editor. Results can be grouped by project, definition, or path from the results toolbar.
- **Tools > Options > Environment > Find and Replace** controls search-history and search behavior where available. **Match case**, **Match whole word**, and **Use regular expressions** are per-search options; verify them before interpreting a zero-result search.
- The **Find Results** window preserves result sets so you can compare or revisit searches.

### Test Explorer and Live Unit Testing

- Open with **Test > Test Explorer**. Use its toolbar to run all tests, run failed tests, rerun, group, and filter by status/traits.
- **Tools > Options > Test** or **Tools > Options > Test > General** (exact page varies by release) controls test discovery/run behavior, such as whether tests are discovered in real time and default processor usage.
- For slow or nondeterministic tests, change one execution setting at a time and compare results. Test adapter and framework settings can also come from the project/package configuration and may override IDE expectations.
- **Test > Live Unit Testing > Start** runs supported tests continuously as code changes. Use **Pause**, **Continue**, and **Stop** from the Live Unit Testing menu; configure exclusions/solution behavior under **Tools > Options > Live Unit Testing** when the page is available. It requires a supported test framework and can add CPU/build overhead in large solutions.

### Git, changes, and history

- Open **View > Git Changes** and **View > Git Repository** (or use the Git menu). These are tool windows rather than global editor settings.
- The commit/push workflow depends on repository state; inspect changed files and diffs before committing.
- Git-related Visual Studio preferences are under **Tools > Options > Source Control > Git Global Settings** and **Git Repository Settings** in versions that expose these pages. User identity, line endings, and repository-specific settings can also be controlled by Git configuration files.

### C# Interactive and Output

- Open **View > Other Windows > C# Interactive** to run C# expressions interactively. It is useful for small experiments but does not replace testing code in its actual project context.
- **View > Output** contains separate output streams; choose a source such as Build, Debug, or Tests in the **Show output from** selector.
- **Tools > Options > Debugging > General** includes debugger-output controls such as whether output from the debugged process is shown in the Output window. Keep only useful streams enabled if the window is noisy.

## Keyboard Options command names

Search IDs in **Tools > Options > Environment > Keyboard**. Examples assume a US English keyboard and the General/Visual C# scheme.

| Keyboard Options command | Common US binding / purpose |
|---|---|
| `View.TaskList` | `Ctrl+\, T` — Task List |
| `Edit.InsertTask` | Create a User Task |
| `View.NextTask` | Move to the next task |
| `View.ErrorList` | `Ctrl+\, E` — Error List |
| `Edit.GoToNextLocation` / `Edit.GoToPrevLocation` | `F8` / `Shift+F8` — next/previous diagnostic location |
| `View.CommandWindow` | `Ctrl+Alt+A` — Command Window |
| `Window.QuickLaunch` | `Ctrl+Q` — Visual Studio Search |
| `View.CSharpInteractiveWindow` | Open C# Interactive |
| `ProjectandSolutionContextMenus.Project.ExecuteInInteractive` | `Ctrl+E, Ctrl+E` — execute selection in Interactive |
| `View.Terminal` | `Ctrl+\`` — Terminal |
| `Tools.DeveloperPowerShell` | Open Developer PowerShell |
| `Tools.CommandPrompt` | Open Developer Command Prompt |
| `View.ObjectBrowser` | `Ctrl+Alt+J` — Object Browser |
| `View.ClassView` | `Ctrl+Shift+C` — Class View |
| `View.CodeDefinitionWindow` | `Ctrl+\, D` — Code Definition Window |
| `Edit.EditDefinition` | Open the definition for editing |
| `View.CallHierarchy` | `Ctrl+K, Ctrl+T` — Call Hierarchy |
| `View.SolutionExplorer` | `Ctrl+Alt+L` — Solution Explorer |
| `View.Output` | `Ctrl+Alt+O` — Output |
| `View.PropertiesWindow` | `F4` — Properties |
| `View.Toolbox` | `Ctrl+Alt+X` — Toolbox |
| `Tools.ChooseToolboxItems` | Choose Toolbox Items |
| `View.ServerExplorer` | `Ctrl+Alt+S` — Server Explorer |
| `View.SQLServerObjectExplorer` | `Ctrl+\, Ctrl+S` — SQL Server Object Explorer |
| `View.DataSources` | `Shift+Alt+D` — Data Sources |
| `SQL.Execute` | `Ctrl+Shift+E` — execute T-SQL where available |
| `View.GitChanges` | Git Changes |
| `View.GitRepositoryWindow` | Git Repository |
| `Team.Git.CommitAll` | `Ctrl+Enter` while Git Changes has focus |
| `Team.Git.Pull` | Pull |
| `TestExplorer.ShowTestExplorer` | `Ctrl+E, T` — Test Explorer |
| `TestExplorer.RunAllTests` | `Ctrl+R, A` — run all tests |
| `TestExplorer.RunAllTestsInContext` | `Ctrl+R, T` — run contextual tests |
| `TestExplorer.RepeatLastRun` | `Ctrl+R, L` — repeat last run |
| `Test.LiveUnitTesting.Start` / `.Pause` / `.Continue` / `.Stop` | Live Unit Testing controls |
| `Edit.FindAllReferences` | `Shift+F12` — Find All References |
| `View.CallHierarchyRemoveRoot` | Remove a Call Hierarchy root |
| `Edit.FindinFiles` | `Ctrl+Shift+F` — Find in Files |
| `Edit.ReplaceinFiles` | `Ctrl+Shift+H` — Replace in Files |
| `Edit.Find` | `Ctrl+F` — Find |
| `View.TrackDocumentInSolutionExplorer` | Select the active document in Solution Explorer |

If a window command is not listed, open it from its menu and search Keyboard Options by a distinctive word such as `Test`, `Git`, or the window name. Some commands have no default binding.
