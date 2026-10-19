# Module 5 — Editor Intelligence

This reference collects the Visual Studio options related to C# IntelliSense, Quick Actions, refactoring, snippets, formatting, code style, and editor hints. Use **Tools > Options > All Settings > Languages > C#** for the C#-specific pages. Keyboard examples assume a **US English keyboard layout**.

## IntelliSense and completion — Lessons 5.1–5.3

**Tools > Options > All Settings > Languages > C# > IntelliSense**

- **Show completion list after a character is typed** opens completion as you type. Turn off only if automatic lists interrupt your workflow; use `Ctrl+Space` to invoke manually.
- **Show completion list after a character is deleted** reopens the list after Backspace. Disable if deletion causes distracting popups.
- **Highlight matching portions of completion list items** emphasizes the typed prefix/CamelCase matches.
- **Show completion item filters** displays the completion filters (members, types, snippets, and other categories).
- **Show name suggestions** proposes variable/parameter names based on the type and configured naming conventions.
- **Include keywords** and **Include code snippets** control whether keywords and snippets appear in completion.
- Snippet behavior controls when snippets appear: never, always, or when invoked with `?` + Tab. Use **Always include snippets** if you regularly use built-in C# templates.
- **Show items from unimported namespaces** offers types whose namespace is not yet imported; accepting one can add the `using` directive.
- **Tab twice to insert arguments** generates a method-call argument template after selecting a completion item. Tab moves between argument placeholders.
- **Automatically show completion list in argument lists** offers values suitable for a method parameter while entering arguments.
- **Enter key behavior** determines whether Enter accepts a selected completion item, inserts a newline, or does both. Choose the behavior that matches your muscle memory; use Tab to accept completion if you want Enter to consistently make a new line.
- String-context assistance includes completion and validation for regular expressions, `DateTime`/`TimeSpan` format strings, and JSON strings. Enable the feature and invalid-pattern diagnostics that are useful to your work.

**Tools > Options > All Settings > Languages > C# > Advanced**

- **Add missing using directives on paste** adds imports when pasted code requires them.
- **Suggest usings for types in reference assemblies**, **NuGet packages**, and **.NET reference assemblies** control Quick Action and completion suggestions for those sources.
- **Place 'System' directives first when sorting usings** and **Separate using directive groups** control sorting and blank-line grouping.

## Quick Actions, refactoring, and inline assistance — Lessons 5.4–5.8

- **Quick Actions and Refactorings** are invoked from the lightbulb or `Ctrl+.`. The available fixes depend on the active diagnostic, project context, and installed analyzers.
- **Tools > Options > All Settings > Languages > C# > Advanced > Analysis**:
  - **Run background code analysis for** controls analyzer scope: None, Current document, Open documents, or Entire solution. Broader scopes find more issues sooner but use more CPU/memory.
  - **Show compiler errors and warnings for** controls where compiler diagnostics appear (None, Open documents, or Entire solution). Open documents is a useful balance for most solutions.
- **Advanced > Using Directives**: **Place 'System' directives first** and **Separate using directive groups** control sort order and blank lines; **Suggest usings** for reference assemblies, NuGet packages, and .NET reference assemblies controls what Quick Actions can offer; **Add missing using directives on paste** inserts imports when pasted code needs them.
- **Advanced > Highlighting**: **Highlight references to symbol under cursor** marks same-symbol references; **Highlight related keywords under cursor** pairs constructs such as `if`/`else`, `try`/`catch`, and `switch`/`case`. Navigate highlighted symbol references with the next/previous-reference commands.
- **Advanced > Outlining**: **Enter outlining mode when files open** creates folds; **Show procedure line separators** draws boundaries between members; options control collapsing `#region`s/usings/metadata on open and whether declarations, code blocks, comments, and preprocessor regions can be folded.
- **Advanced > Block Structure Guides** shows vertical guides for declaration-level constructs (types/members) and code-level constructs (control-flow blocks). Enable both to trace nested braces, or disable code-level guides if the editor becomes crowded.
- **Advanced > Editor Help** includes **Generate XML documentation comments for `///`**, comment-star continuation, **Show inheritance margin** (implementation/override glyphs), **Include global imports in inheritance margin**, **Underline reassigned variables**, **Fade out unused usings**, **Fade out unreachable code**, support for source-generator files, regex/JSON colorization, related regex-component highlighting, and automatic stack-trace explorer behavior. Enable the feedback features you rely on; syntax-aware extras can be disabled if they add visual noise.
- **Advanced > Go To Definition**: **Enable navigation to Source Link and Embedded sources** prefers available source; **Enable navigation to decompiled sources** decompiles referenced assemblies when source is unavailable; **Navigate to Object Browser for symbols defined in metadata** chooses Object Browser instead of source/decompiled navigation.
- **Advanced > Extract Method**: **Don't put ref or out on custom struct** controls whether extracted-method signatures use `ref`/`out` for custom struct parameters. The refactoring is invoked separately from the editor.
- **Advanced > Inline Hints** opens the dedicated inline-hints page. Configure parameter-name and inferred-type hints there; enable only categories that clarify code without obscuring it.
- **Advanced > Comments**: **Show remarks in Quick Info** includes XML `<remarks>` content in Quick Info tooltips. Use remarks for thread-safety, performance, or usage caveats that do not fit the summary.
- Copilot options are separate from base C# editor settings. Configure them under the Copilot section in **Tools > Options** when the extension is installed; organization policies may restrict availability.

## Formatting — Lessons 5.11 and 5.13

**Tools > Options > All Settings > Languages > C# > Formatting**

- **General**: automatic formatting when typing, after `;`, after `}`, on Return, on paste, and on block completion. Enable the triggers that prevent formatting drift; turn off on-paste formatting temporarily for intentionally aligned/generated text.
- **Indentation**: indent block contents, braces, switch `case` labels/contents, and labels. Keep indentation consistent with the repository's `.editorconfig`.
- **New Lines**: choose whether braces for types, methods, properties, control blocks, initializers, and lambdas go on new lines; also set `else`, `catch`, `finally`, object/anonymous initializer, and query-clause placement.
- **Spacing**: configure spaces in method declarations/calls, control-flow keywords, brackets, delimiters, casts, and binary operators.
- **Wrapping**: controls whether single-line blocks and same-line statements/member declarations are preserved when formatting.
- **Tabs** (under the C# language settings): set tab size, indent size, and whether to insert spaces or tabs. A common .NET convention is four spaces, but repository `.editorconfig` takes precedence for files covered by it.
- **Format Document** formats the whole document; **Format Selection** formats only the selected code. Check the preview/diff before applying broad formatting changes.

## Code style and naming — Lessons 5.12 and 5.14

**Tools > Options > All Settings > Languages > C# > Code Style > General**

- Preferences cover `this.` qualification, predefined type keywords versus framework names, `var` usage, expression-bodied members, pattern matching, null checks, and other C# idioms. Each preference has a severity.
- **Refactoring Only** makes a preference available as a refactoring but does not generally show a continuous editor diagnostic. **Suggestion**, **Warning**, and **Error** make violations progressively more visible in the editor and Error List. Whether an error prevents builds depends on analyzer/build configuration.
- Use the preview pane to see a preference's effect. Set related preferences consistently and use `.editorconfig` to share rules with the team.

**Tools > Options > All Settings > Languages > C# > Code Style > Naming**

- A **Symbol Specification** selects applicable symbols (for example, private fields or interfaces).
- A **Naming Style** defines capitalization, required prefix/suffix, and word separator.
- A **Naming Rule** connects the specification and style and assigns severity.
- Example policies include `_camelCase` private fields and `I`-prefixed PascalCase interfaces. Keep the rule aligned with `.editorconfig` so command-line builds and teammates use the same standard.

## Keyboard Options command names

Search each command in **Tools > Options > Environment > Keyboard**. The common bindings below may differ by scheme/version.

| Keyboard Options command | Common US binding / purpose |
|---|---|
| `Edit.ListMembers` | `Ctrl+J` — completion/member list |
| `Edit.CompleteWord` | `Ctrl+Space` — complete word |
| `Edit.ParameterInfo` | `Ctrl+Shift+Space` — parameter information |
| `Edit.QuickInfo` | `Ctrl+K, Ctrl+I` — Quick Info |
| `Edit.ShowQuickInfo` | Display Quick Info where available |
| `View.QuickActions` | `Ctrl+.` — Quick Actions/Refactorings |
| `Refactor.Rename` | `Ctrl+R, Ctrl+R`; `F2` may also be bound to this command |
| `Refactor.ExtractMethod` | `Ctrl+R, Ctrl+M` — Extract Method |
| `Edit.FormatDocument` | `Ctrl+K, Ctrl+D` |
| `Edit.FormatSelection` | `Ctrl+K, Ctrl+F` |
| `Edit.RemoveAndSortUsings` | Remove and sort imports/usings |
| `Edit.SortUsings` | Sort using directives |
| `Edit.InsertSnippet` | Insert a code snippet |
| `Edit.SurroundWith` | Surround selected code with a snippet |
| `Edit.ToggleCompletionMode` | Toggle completion mode where available |
| `Edit.NextHighlightedReference` / `Edit.PreviousHighlightedReference` | Navigate highlighted symbol references where available |
| `Edit.ToggleOutliningExpansion` | Toggle current fold |
| `Edit.CollapseToDefinitions` | Collapse to definitions |
| `Edit.ToggleAllOutlining` | Toggle all outlining |
| `Edit.NextHighlightedReference` / `Edit.PreviousHighlightedReference` | `Ctrl+Shift+Down` / `Ctrl+Shift+Up` — navigate highlighted references |

To assign a key, select the command, choose **Use new shortcut in** (for example, Global or Text Editor), press the desired US-layout key sequence, and select **Assign**. Avoid overwriting a binding you rely on.
