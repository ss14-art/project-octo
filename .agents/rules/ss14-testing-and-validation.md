# SS14 Testing And Validation

Choose the smallest meaningful verification for the files you touched.

## Required Validation By Change Type

- C# gameplay code: build the affected project or repo slice.
- Prototypes or FTL: run the YAML/content validation path.
- RSI metadata or sprite state changes: validate RSI metadata when scripts are available.
- Client code or UI: do an in-game or runtime client pass when possible.
- Database changes: test SQLite and Postgres paths when migrations or models change.

## Standard Commands

- Restore: `dotnet restore`
- Build: `dotnet build --configuration DebugOpt --no-restore /m`
- Content tests: `dotnet test --configuration DebugOpt Content.Tests/Content.Tests.csproj`
- Integration tests: `dotnet test --configuration DebugOpt Content.IntegrationTests/Content.IntegrationTests.csproj`
- YAML/resource edits: `dotnet run --project Content.YAMLLinter/Content.YAMLLinter.csproj`

## Reporting

- State exactly what you ran.
- State what you could not run.
- If runtime verification was not possible, call that out explicitly.
