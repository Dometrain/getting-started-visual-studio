# Module 2 — Advanced Navigation and Flow

This reference describes navigation, document tabs, editor scrolling, outlining, and bookmarks covered in Module 2. Keyboard examples assume the **US English keyboard layout**.

## Settings and how to use them

### Track the active document — Lesson 2.3

**Tools > Options > Projects and Solutions > General**

- **Track Active Item in Solution Explorer** follows the active source file in the project tree.
- Enable it when finding the file's project context matters; disable it if it causes the tree to jump while you browse.

### Editor structure, brace matching, and outlining — Lesson 2.3

Keyboard assignments are managed under **Tools > Options > Environment > Keyboard**; search for `Edit.GotoBrace`, `Edit.SelectToMatchingBrace`, and outlining commands.

- **Edit.GotoBrace** moves between a matching brace or bracket.
- **Edit.SelectToMatchingBrace** extends a selection to the matching delimiter.
- **Edit.ToggleOutliningExpansion**, **Edit.ToggleAllOutlining**, and **Edit.CollapseToDefinitions** control code folding. Use collapse-to-definitions to inspect a file's member structure, and expand only the code being studied.
- Language-specific structure guides and outlining options are under **Tools > Options > All Settings > Languages > C# > Advanced**. Declaration-level guides mark types and members; code-level guides mark nested control-flow blocks. Turn off code-level guides if their density distracts.

### Scrolling and zoom — Lesson 2.5

- **Tools > Options > Environment > General > Scroll speed** controls how many lines the wheel advances. Raise it for large-file navigation; lower it for precise review.
- For C#, use **Tools > Options > All Settings > Languages > C# > Scrolling** to configure language-specific scrolling behavior, including mouse-wheel zoom where offered.
- Other languages expose their own scrolling pages under **Languages**. Scroll Bar settings control map mode, annotations, and previews; use the map to jump through long files or disable extra annotations if they are visually noisy.

### Document-tab layout — Lesson 2.4

**Tools > Options > Environment > Tabs and Windows**

- **Tab layout** positions tabs at the top, bottom, left, or right. Left/right tabs preserve full file names when many files are open.
- **Colorize document tabs by** groups tabs by project, extension, or framework. Project coloring is helpful when several projects contain files with the same name.
- **Configure tab color for projects** assigns project-specific colors. Use high-contrast colors that remain readable with the current theme.
- **Show tabs in multiple rows** keeps tab names visible instead of shrinking them into a single row.
- **Allow new files to be opened in preview tab** opens single-clicked files in a temporary tab. Disable it if you want every opened file to remain as a full document tab.
- Modified-tab indicators can be shown/hidden in this page; their colors are configured under **Tools > Options > Environment > Fonts and Colors**.
- Pin a tab from its context menu to keep important documents grouped. **View > New Tab Group** creates a separate editor group.

### Bookmarks — Lesson 2.6

- The built-in bookmark list is available at **View > Other Windows > Bookmark Window**.
- Built-in bookmark navigation and the Bookmark Studio extension are separate systems. If Bookmark Studio is installed, configure its numbered-marker behavior under **Tools > Options > Bookmark Studio**; extension settings will not change built-in bookmarks.

## Keyboard Options command names

Search these IDs under **Tools > Options > Environment > Keyboard**. Defaults are profile-dependent; examples in the middle column are common bindings for the General/Visual C# scheme on a US keyboard.

| Keyboard Options command | Common US binding / purpose |
|---|---|
| `Edit.GoToAll` | `Ctrl+T` or `Ctrl+,` — Go To All |
| `Edit.GoToType` | Search for a type |
| `Edit.GoToFile` | Search for a file |
| `Edit.GoToMember` | Search for a member |
| `Edit.GoToSymbol` | Search for a symbol |
| `Edit.GoToDefinition` | `F12` — go to definition |
| `Edit.PeekDefinition` | `Alt+F12` — peek definition |
| `Edit.GoToImplementation` | `Ctrl+F12` — go to implementation |
| `Edit.GoToBase` | `Alt+Home` — go to base type/member |
| `View.NavigateBackward` | `Ctrl+-` — navigate backward |
| `View.NavigateForward` | `Ctrl+Shift+-` — navigate forward |
| `Edit.PromotePeekView` | Promote Peek to a document tab |
| `Edit.GotoBrace` | Go to matching brace |
| `Edit.SelectToMatchingBrace` | Select to matching brace |
| `View.TrackDocumentInSolutionExplorer` | Locate active file in Solution Explorer |
| `Edit.ToggleOutliningExpansion` | Toggle current fold |
| `Edit.ToggleAllOutlining` | Toggle all folds |
| `Edit.CollapseToDefinitions` | Collapse to member definitions |
| `Window.CloseDocumentWindow` | `Ctrl+W` / `Ctrl+F4` — close document |
| `File.SaveAll` | `Ctrl+Shift+S` — save all |
| `Window.PinTab` | Pin the active tab where available |
| `Window.NextDocumentWindow` | `Ctrl+Tab` — next document |
| `Window.PreviousDocumentWindow` | `Ctrl+Shift+Tab` — previous document |
| `Window.ShowEzMDIFileList` | `Ctrl+Alt+Down` — document list |
| `Edit.ScrollLineDown` / `Edit.ScrollLineUp` | `Ctrl+Down` / `Ctrl+Up` — scroll without moving caret |
| `Edit.DocumentStart` / `Edit.DocumentEnd` | `Ctrl+Home` / `Ctrl+End` |
| `Edit.PageDown` / `Edit.PageUp` | `Page Down` / `Page Up` |
| `Edit.ToggleBookmark` | Toggle a built-in bookmark |
| `Edit.NextBookmark` / `Edit.PreviousBookmark` | Navigate built-in bookmarks |
| `Edit.ClearBookmarks` | Clear built-in bookmarks |
| `View.BookmarkWindow` | Open Bookmark Window |

