# Module 7 — Solution Files, NuGet, and Code Quality

The module covers project/solution files, package management, build operations, EditorConfig, and code cleanup. Some settings live in project files or `.editorconfig`, not in the global Options dialog; those scopes are called out below.

## Settings and how to use them

### Solution and project files — Lessons 7.1–7.5

- **Tools > Options > Projects and Solutions > General > Always show solution** controls whether a single-project solution still displays its `.sln` node. Enable it when working with solution-level files or planning to add projects.
- **Tools > Options > Projects and Solutions > Build and Run** controls parallel project builds and MSBuild output verbosity. Use higher verbosity only when diagnosing a failure.
- `.sln`, `.slnx` (where supported), and SDK-style `.csproj` files are plain-text configuration. Review edits carefully and use source control to track them.
- **Project > Properties** configures target framework, output, build settings, and project-specific values. Prefer project-level configuration when behavior should travel with the code.
- **Tools > Options > Projects and Solutions > SDK-Style Projects** contains SDK-style project handling options where present; labels vary by Visual Studio version.

### NuGet packages — Lessons 7.6–7.10

- **Tools > Options > NuGet Package Manager > General** controls package restore behavior, including whether missing packages are restored automatically and whether restore warnings are shown.
- **Tools > Options > NuGet Package Manager > Package Sources** manages feeds. Enable only trusted sources; source order and authentication can affect package restore.
- **Tools > Options > NuGet Package Manager > Package Source Mapping** (when available) maps package ID patterns to permitted sources and helps prevent dependency-confusion risks.
- Manage project dependencies through **Manage NuGet Packages** or the `.csproj`; central package management uses `Directory.Packages.props` and is repository-wide.
- Package version updates can change transitive dependencies. Review package diffs and restore/build results rather than accepting updates blindly.

### Code Cleanup, save behavior, and EditorConfig — Lessons 7.16–7.17

**Analyze > Code Cleanup > Configure Code Cleanup** (also **Tools > Options > Text Editor > Code Cleanup** in versions that expose the page)

- Configure **Profile 1** and **Profile 2** as ordered collections of cleanup steps, such as format document, remove/sort usings, apply code-style preferences, or simplify code.
- Keep the save profile conservative. **Run Code Cleanup profile on Save** runs the chosen profile when saving; a broad profile can create large diffs on a trivial save.
- Run profiles manually from **Analyze > Code Cleanup** or the editor status bar and review the resulting changes.
- A common scheme is Profile 1 for format and unused imports on save, and Profile 2 for broader style transformations on demand.

**EditorConfig**

- Add an `.editorconfig` at the repository/solution root to share formatting and code-style rules. A nearer nested `.editorconfig` overrides applicable parent rules.
- Common C# keys include `indent_style`, `indent_size`, `dotnet_sort_system_directives_first`, `csharp_style_var_*`, naming rules, and `dotnet_diagnostic.<ID>.severity`.
- Visual Studio exposes C# naming rules under **Tools > Options > All Settings > Languages > C# > Code Style > Naming**; use Symbol Specification, Naming Style, and Naming Rule together.
- Check the active `.editorconfig` before changing GUI preferences: file-based rules may override user-level settings.

## Keyboard Options command names

Search command IDs under **Tools > Options > Environment > Keyboard**. Bindings below are common examples, not guaranteed for every scheme.

| Keyboard Options command | Common US binding / purpose |
|---|---|
| `File.NewProject` | Create a project |
| `Project.AddNewItem` | `Ctrl+Shift+A` |
| `Project.AddExistingItem` | `Shift+Alt+A` |
| `Project.EditProjectFile` | Edit project file |
| `Project.Properties` | Project properties |
| `Build.BuildSolution` | `Ctrl+Shift+B` |
| `Build.BuildSelection` | Build selected project |
| `Build.RebuildSolution` | Rebuild solution |
| `Build.CleanSolution` | Clean solution |
| `Build.Cancel` | Cancel a build |
| `Build.ConfigurationManager` | Open Configuration Manager |
| `Debug.Start` | `F5` |
| `Debug.StartWithoutDebugging` | `Ctrl+F5` |
| `Edit.FormatDocument` | `Ctrl+K, Ctrl+D` |
| `Edit.FormatSelection` | `Ctrl+K, Ctrl+F` |
| `Edit.RemoveAndSortUsings` | Remove and sort imports |
| `Edit.SortUsings` | Sort using directives |
| `Edit.QuickActions` | `Ctrl+.` — apply fixes/refactorings |
| `Edit.RunCodeCleanup` | Run Code Cleanup where available |
| `Analyze.RunCodeCleanupProfile1` / `Analyze.RunCodeCleanupProfile2` | Run cleanup profiles where available |
| `View.ErrorList` | Open Error List |
| `View.Output` | Open Output |

