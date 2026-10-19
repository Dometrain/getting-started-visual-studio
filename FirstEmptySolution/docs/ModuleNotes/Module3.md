# Module 3 — Solutions and Projects

Module 3 uses project properties, solution configuration, and MSBuild files in addition to global Visual Studio options. The locations below use the English Visual Studio UI.

## Settings and how to use them

### New projects, solutions, and items — Lessons 3.1–3.3

- Use **File > New > Project** to select a template, language, and target framework. Confirm that the required SDK/workload is installed before choosing a target.
- In Solution Explorer, **Add > New Solution Folder** creates a logical solution grouping; it does not create a physical directory.
- **Add > New Item** and **Add > Existing Item** add project items. The item type and project file determine how the item is built.
- **File Nesting** changes only Solution Explorer presentation. Where available, configure it under **Tools > Options > Text Editor > Advanced > File Nesting**; related files appear nested without being moved on disk.

### Project dependencies, build order, and parallel build — Lesson 3.4

- Use **Project > Project Dependencies** and **Project > Build Order** to see and configure dependency ordering. Set real project references/dependencies rather than relying on alphabetical order.
- **Tools > Options > Projects and Solutions > Build and Run > maximum number of parallel project builds** controls how many projects Visual Studio builds concurrently. Increase only while CPU and disk have capacity; a high value can reduce performance on constrained machines.
- **MSBuild project build output verbosity** under the same page can be raised to **Detailed** or **Diagnostic** while investigating build order or duration. Return to **Minimal** or **Normal** for routine use.
- **Build > Batch Build** selects projects/configurations for a batch operation.

### Startup projects and launch profiles — Lesson 3.5

- Right-click the solution and select **Configure Startup Projects**.
- **Single startup project** launches one project. **Multiple startup projects** can start an API, worker, and UI together; set each action to **Start**, **Start without debugging**, or **None**.
- Check `launchSettings.json` profile URLs/ports if multiple web applications collide.

### Framework, build, and project properties — Lesson 3.6

Right-click a project and open **Properties**:

- **Application**: target framework, output type, assembly name, root namespace.
- **Build**: configuration-specific compiler options and conditional compilation symbols.
- SDK-style project files store target frameworks as `TargetFramework` or `TargetFrameworks` in `.csproj`; use a semicolon-separated list for multi-targeting.
- If a preview target is missing, check SDK installation and **Tools > Options > Environment > Preview Features**.

### Build configurations and platforms — Lesson 3.7

Open **Build > Configuration Manager**:

- Select the active solution configuration and platform (for example, Debug/Release and Any CPU/x64).
- The project grid's **Build** and **Deploy** checkboxes control participation in the selected solution configuration.
- When creating a configuration, copy from a known configuration, then verify each project's mapping and Build checkbox.

## Keyboard Options command names

Search command IDs under **Tools > Options > Environment > Keyboard**. `Unassigned` means the command can be found and assigned even if the current scheme has no shortcut.

| Keyboard Options command | Common US binding / purpose |
|---|---|
| `File.NewProject` | Open New Project |
| `File.NewFile` | Create a new file |
| `Project.AddNewItem` | `Ctrl+Shift+A` — Add New Item |
| `Project.AddExistingItem` | `Shift+Alt+A` — Add Existing Item |
| `Project.AddNewFolder` | Add a project folder |
| `Project.NewFolder` | Add a solution folder in supported contexts |
| `Project.EditProjectFile` | Edit `.csproj` |
| `Project.Properties` | `Alt+Enter` with a project selected |
| `Project.SetasStartupProject` / `Project.SetasStartUpProject` | Set the selected project as startup project; spelling may vary by version |
| `Build.ConfigurationManager` | Open Configuration Manager |
| `Build.BuildSolution` | `Ctrl+Shift+B` — build solution |
| `Build.BuildSelection` | Build selected project(s) |
| `Build.RebuildSolution` | Rebuild solution |
| `Build.CleanSolution` | Clean solution outputs |
| `Build.Cancel` | `Ctrl+Break` — cancel build |
| `Debug.Start` | `F5` — start debugging |
| `Debug.StartWithoutDebugging` | `Ctrl+F5` — start without debugging |
| `Debug.AttachtoProcess` | `Ctrl+Alt+P` — attach to process |
| `Debug.StopDebugging` | `Shift+F5` — stop debugging |
| `View.Output` | `Ctrl+Alt+O` — Output |
| `View.PropertiesWindow` | `F4` — Properties |
| `View.SolutionExplorer` | `Ctrl+Alt+L` — Solution Explorer |

