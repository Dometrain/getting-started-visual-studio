# Module 1 — Workspace and Window Layouts

This reference supplements the Module 1 lessons with the settings that control Visual Studio windows, layouts, and profile isolation. Keyboard examples use the **US English keyboard layout**. Visual Studio version and the selected keyboard scheme can change available commands or default bindings.

## Settings and how to use them

### Window types and graphics — Lesson 1.1

**Tools > Options > Environment > General**

- **Use hardware graphics acceleration if available** delegates UI rendering to the GPU. Leave it enabled unless you see rendering glitches, flicker, or poor responsiveness on a particular graphics driver; test disabling it and restart Visual Studio.
- **Window > Reset Window Layout** restores the standard tool-window arrangement if panels become lost or unusable. It does not reset editor or keyboard preferences.
- Tool windows (such as Solution Explorer) and document windows (source files) have different docking and tab behavior. Choose Float, Dock, Auto Hide, or tab-dock operations to suit the workspace; save a layout after arranging frequently used windows.

### Floating-window ownership — Lesson 1.4

**Tools > Options > Environment > Windows**

- **Float windows by default** affects how windows are floated when undocked. Enable only if floating windows are part of the normal multi-monitor workflow.
- A floating window belongs to a Visual Studio instance. When using multiple instances, make sure it is associated with the intended instance; minimizing that instance can make its windows appear to disappear.
- Windows PowerToys FancyZones is an optional Windows utility, not a Visual Studio option. Hold **Shift** while moving a floating window to place it in a configured zone.

### Follow the active file — Lesson 1.5

**Tools > Options > Projects and Solutions > General**

- **Track Active Item in Solution Explorer** selects and expands the active document in Solution Explorer.
- Turn it on when you often need to locate the current file in a large solution. Turn it off if automatic tree movement interrupts manual browsing.
- A second Solution Explorer view is opened from **View > Solution Explorer Views > New Solution Explorer View**. It can retain a separate browsing context.

### Save and apply window layouts — Lesson 1.3

Use **Window > Save Window Layout** to name the current tool-window arrangement, and **Window > Manage Window Layouts** to rename, remove, or apply saved layouts. Keep separate layouts for coding, debugging, and presenting if those activities use different panels. A window layout is distinct from environment settings and is not automatically a portable team configuration.

### Profile and instance isolation — Lesson 1.6

`devenv.exe /rootsuffix Exp` starts a Visual Studio instance with a separate settings and extension hive. This is a command-line switch, not a Tools > Options checkbox. Use it to test extensions or configuration changes without affecting the main profile. Layouts and environment preferences made in that instance belong to its isolated profile.

## Keyboard Options command names

Open **Tools > Options > Environment > Keyboard**. Search the command name under **Show commands containing**; inspect its current binding and the **Use new shortcut in** scope before assigning a key. The tables list command IDs, not guaranteed defaults.

| Keyboard Options command | Purpose |
|---|---|
| `View.SolutionExplorer` | Open Solution Explorer |
| `View.Output` | Open Output |
| `View.ErrorList` | Open Error List |
| `View.PropertiesWindow` | Open Properties |
| `View.Toolbox` | Open Toolbox |
| `View.TrackDocumentInSolutionExplorer` | Locate the active document in Solution Explorer |
| `View.NewSolutionExplorer` | Create a new Solution Explorer view |
| `Window.Split` | Split the active editor |
| `Window.RemoveSplit` | Remove the editor split |
| `Window.Float` | Float the active window |
| `Window.Dock` | Dock the active window |
| `Window.ResetWindowLayout` | Reset the window layout |
| `Window.SaveWindowLayout` | Save the current layout |
| `Window.ManageWindowLayouts` | Manage saved layouts |
| `Window.ApplyWindowLayout1` … `Window.ApplyWindowLayout10` | Apply numbered layouts where available |
| `Window.NextDocumentWindow` | Move to the next document |
| `Window.PreviousDocumentWindow` | Move to the previous document |

## Notes

Some layout commands are menu-only or depend on the installed Visual Studio version. Search by `Window` or `Layout` in Keyboard Options if a command is not listed in the table.
