# Module 4 — Debugging Windows and Variable Analysis

Use these options and commands as a companion to the Module 4 debugging lessons. Most debugger windows are available from **Debug > Windows**. Keyboard bindings vary by scheme and Visual Studio version; the command IDs are the reliable search terms.

## Settings and how to use them

### Autos, Locals, and Watch — Lessons 4.1–4.2

Open **Debug > Windows > Autos**, **Locals**, or **Watch**:

- **Autos** shows variables relevant to the current and previous statements.
- **Locals** shows locals in the active stack frame and scope.
- **Watch 1–4** holds expressions across stops. Add expressions before or during a paused session; use separate windows for different concerns.
- Watch search/display controls are on the window toolbar or context menu and are useful when evaluating large object graphs.

### Immediate Window — Lesson 4.3

Open **Debug > Windows > Immediate**. While paused, evaluate expressions and supported debugger commands. Assignments can mutate the debugged process; do not treat Immediate as a read-only view.

### Breakpoints and exception behavior — Lessons 4.4 and 4.4b

- Right-click a breakpoint for **Conditions**, **Hit Count**, **Actions**, and **Filter**. Conditions break only when an expression is true; Hit Count waits for a chosen number of visits; Actions can emit trace messages; Filter limits the breakpoint to a thread/process condition.
- **Debug > Windows > Breakpoints** organizes, labels, imports, and exports breakpoints. Disable or delete stale breakpoints to avoid unexpected stops.
- **Debug > Windows > Exception Settings** configures which exception types break when thrown or when user-unhandled. Avoid enabling broad exception groups without a reason; framework code may throw and handle many exceptions internally.

### Diagnostic Tools and performance profiling — Lessons 4.5–4.6

- **Debug > Windows > Show Diagnostic Tools** provides a timeline and in-session CPU/memory/event information.
- **Debug > Performance Profiler** runs targeted profiling tools. Use it for focused CPU, memory, or allocation investigations rather than treating a single timeline as a complete profile.
- Whether Diagnostic Tools opens automatically is controlled by debugger options. The option label/location can vary by Visual Studio release; search **Tools > Options** for `Diagnostic Tools`.

### Multithreaded diagnostics — Lesson 4.7

Open **Debug > Windows > Threads**, **Parallel Stacks**, **Parallel Watch**, and **Call Stack**:

- **Threads** shows the active threads and their current locations.
- **Parallel Stacks** visualizes call stacks across threads, helping identify waits and deadlocks.
- **Parallel Watch** evaluates the same expression across multiple threads.
- Use each window's toolbar/context menu to switch the active thread/frame and filter the view.

## Keyboard Options command names

Search under **Tools > Options > Environment > Keyboard**. The common bindings below are for the General/Visual C# scheme with a US keyboard; confirm before relying on them.

| Keyboard Options command | Common US binding / purpose |
|---|---|
| `Debug.Autos` | `Ctrl+D, A` — Autos |
| `Debug.Locals` | `Ctrl+D, L` — Locals |
| `Debug.Watch1` … `Debug.Watch4` | `Ctrl+D, W, 1` … `4` — Watch windows |
| `Debug.QuickWatch` | `Shift+F9` — Quick Watch |
| `Debug.Immediate` | `Ctrl+D, I` or `Ctrl+Alt+I` — Immediate |
| `Debug.Breakpoints` | `Ctrl+Alt+B` — Breakpoints |
| `Debug.ToggleBreakpoint` | `F9` — toggle breakpoint |
| `Debug.DisableAllBreakpoints` | Disable all breakpoints |
| `Debug.DeleteAllBreakpoints` | Delete all breakpoints |
| `Debug.NewFunctionBreakpoint` | Add a function breakpoint |
| `Debug.ToggleTemporaryBreakpoint` | Toggle temporary breakpoint |
| `Debug.EditBreakpointCondition` | Edit breakpoint condition |
| `Debug.ExceptionSettings` | `Ctrl+Alt+E` — Exception Settings |
| `Debug.DiagnosticTools` | `Ctrl+Alt+F2` — Diagnostic Tools |
| `Analyze.PerformanceProfiler` / `Debug.PerformanceProfiler` | Open Performance Profiler; command name depends on version |
| `Debug.ParallelStacks` | Parallel Stacks |
| `Debug.Threads` | Threads |
| `Debug.ParallelWatch1` | Parallel Watch 1 |
| `Debug.CallStack` | Call Stack |
| `Debug.StepOver` | `F10` |
| `Debug.StepInto` | `F11` |
| `Debug.StepOut` | `Shift+F11` |
| `Debug.RunToCursor` | `Ctrl+F10` |
| `Debug.Start` | `F5` |
| `Debug.StopDebugging` | `Shift+F5` |

Breakpoint context-menu commands may have no default key. Search their command ID and assign a key only if the command is available in your version.

