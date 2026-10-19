# Copilot Instructions for "Not This One (Continued)" Mod

Welcome to the codebase for the "Not This One (Continued)" mod for RimWorld. Below you will find detailed instructions and insights on how to navigate, understand, and enhance this mod with GitHub Copilot's assistance. 

## Mod Overview and Purpose

The "Not This One (Continued)" mod enhances RimWorld gameplay by providing players with the ability to protect specific tamed animals from being slaughtered. Users can toggle a special gizmo for each tamed animal, ensuring that selected animals cannot be queued for slaughter either manually or through the auto-slaughter feature found in the animals tab.

## Key Features and Systems

- **Gizmo Toggle:** New functionality allows players to mark individual tamed animals as "protected," preventing them from being slaughtered.
- **Harmony Patches:** Utilizes the Harmony library to inject code into RimWorld's existing methods, ensuring seamless integration of new features.
- **Error Reporting and Support:** Instructions for diagnosing and reporting errors are included to ensure smooth gameplay experiences.

## Coding Patterns and Conventions

- **Namespace Usage:** Organize classes logically. For instances, all classes related to gizmo interaction are structured similarly.
- **Types and Members:** Follow C# conventions such as PascalCase for types and members. Common types include `AutoSlaughterManager_CanAutoSlaughterNow`, `Designator_Slaughter_CanDesignateThing`, and `NotThisOneGameComponent`.
- **Clean and Commented Code:** Ensure that all code changes include comments explaining their purpose, helping Copilot provide more accurate suggestions.

## XML Integration

- The project contains an `About.xml` file, which defines mod metadata and dependencies.
- XML files are used minimally since most logic is implemented via Harmony patches.
- Ensure XML structures are correct and adhere to RimWorld's XML schema when necessary.

## Harmony Patching

- **Usage of Harmony:** This mod uses Harmony to patch into existing RimWorld methods. Key methods include:
  - `AutoSlaughterManager_CanAutoSlaughterNow`
  - `Designator_Slaughter_CanDesignateThing`
  - `Pawn_GetGizmos`
- **Postfix Usage:** The majority of patches use Postfix methods to modify the behavior after the original method execution.
- **Component Exposure:** `ExposeData` method is used to handle data serialization and deserialization for game components.

## Suggestions for Copilot

- **Pattern Recognition:** Copilot is adept at recognizing patterns such as Harmony patch signatures. Ensure your comments highlight where a specific behavior modification occurs, aiding Copilot in generating patches or new gizmo methods.
- **Gizmo Extensions:** Leverage Copilot to suggest new gizmo options by providing contextual comments about the desired outcome.
- **Performance Optimization:** Annotating areas of high computation can lead Copilot to suggest better data structures or algorithms.
- **Error Handling:** Utilize Copilot to explore robust error handling paths by marking sections where errors have been reported during testing.

By understanding these components and following the outlined conventions, you can leverage Copilot to effectively contribute to the "Not This One (Continued)" mod.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

