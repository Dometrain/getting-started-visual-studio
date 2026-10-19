# Module 6 — Power Keyboard Shortcuts

Module 6 focuses on editor commands and shortcut customization. Keyboard bindings vary with the selected scheme; the **Keyboard Options command name** is the durable identifier. The key examples assume a **US English keyboard layout**.

## Settings and how to use them

Open **Tools > Options > Environment > Keyboard**:

- Search by command name or part of its ID in **Show commands containing**.
- Select the command, choose a scope in **Use new shortcut in** (Global, Text Editor, or another context), press the shortcut, then select **Assign**.
- **Shortcuts for selected command** shows existing bindings. Remove a conflict only after checking which command currently owns it.
- **Apply the following additional keyboard mapping scheme** changes the entire default mapping. Do not change schemes merely to set one shortcut; assign the individual command instead.
- If a shortcut is context-sensitive, bind it to **Text Editor** rather than Global to reduce conflicts elsewhere.

## Editing commands

The following command IDs are useful for the editing techniques demonstrated in this module. Search the exact name before assigning a key; some commands are intentionally unassigned by default.

| Keyboard Options command | Purpose |
|---|---|
| `Edit.CycleClipboardRing` | Cycle through items in the Visual Studio clipboard ring |
| `Edit.Paste` | Paste the current clipboard item |
| `Edit.MoveSelectedLinesUp` | Move selected lines upward |
| `Edit.MoveSelectedLinesDown` | Move selected lines downward |
| `Edit.LineTranspose` | Swap the current line with the adjacent line |
| `Edit.InsertNextMatchingCaret` | Add a caret at the next matching occurrence |
| `Edit.InsertCaretsatAllMatching` | Add carets at all matching occurrences where available |
| `Edit.InsertNextMatchingCaret` | Add the next matching caret |
| `Edit.DeleteLine` | Delete the current line |
| `Edit.DuplicateSelection` | Duplicate selected text |
| `Edit.CommentSelection` | Comment selected lines |
| `Edit.UncommentSelection` | Uncomment selected lines |
| `Edit.ToggleLineComment` | Toggle line comments where supported |
| `Edit.JoinLines` | Join selected/current lines where available |
| `Edit.InsertLineAbove` | Insert a line above |
| `Edit.InsertLineBelow` | Insert a line below |
| `Edit.Home` / `Edit.End` | Move caret within a line |
| `Edit.DocumentStart` / `Edit.DocumentEnd` | Move to document boundaries |
| `Edit.SelectCurrentWord` | Select the word at the caret where available |
| `Edit.ExpandSelection` / `Edit.ContractSelection` | Expand or shrink structural selection where supported |
| `Edit.IncreaseFilterLevel` / `Edit.DecreaseFilterLevel` | Adjust completion-list filtering where supported |

## Navigating and configuring shortcuts

- For any technique not bound by default, use its command ID in Keyboard Options rather than guessing the menu label.
- To restore a command's default, select it and use **Remove** for the custom binding; to reset all bindings, use **Reset** only after exporting your current settings.
- Use **Tools > Import and Export Settings** to back up keyboard mappings before making broad changes.
- The same key can be assigned in different contexts. Verify that **Use new shortcut in** matches the context in which you expect the shortcut to work.

## Related commonly used commands

| Keyboard Options command | Common US binding / purpose |
|---|---|
| `Edit.Undo` / `Edit.Redo` | `Ctrl+Z` / `Ctrl+Y` |
| `Edit.Cut` / `Edit.Copy` / `Edit.Paste` | `Ctrl+X` / `Ctrl+C` / `Ctrl+V` |
| `Edit.Find` / `Edit.Replace` | `Ctrl+F` / `Ctrl+H` |
| `Edit.GoToAll` | `Ctrl+T` or `Ctrl+,` |
| `Edit.FormatDocument` | `Ctrl+K, Ctrl+D` |
| `Edit.FormatSelection` | `Ctrl+K, Ctrl+F` |
| `Edit.QuickActions` | `Ctrl+.` |
| `Refactor.Rename` | `Ctrl+R, Ctrl+R` or `F2` if assigned |

