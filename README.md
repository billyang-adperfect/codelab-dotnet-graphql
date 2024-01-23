# How to run C# in vscode

## 1. Install .NET

```sh
dotnet --version
```

## 2. Create a new C# project in vscode

```sh
# other template see
# https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new
dotnet new console -o app
cd app
code .
```

## 3. Run C# code in vscode

```sh
dotnet run
# OR run with a specified profile in launchSettings.json
dotnet watch -lp https
```

## 4. Debug C# code in vscode

In stall official C# extension in vscode
Then in vscode open the Command Palette search for `.NET: Generate Assets for Build and Debug`

## 5. Compile your code

```sh
dotnet build
```

## 6. check

open url + /graphql, input

```json
query {
  bookById(id:123){
    id
    name
    authorId
  }
}
```

## 7. generate a gitignore

You can use the command: `dotnet new gitignore` to generate a customizable .gitignore file
