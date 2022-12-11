# Performance dotNet Labs

## Overview

This repo contains useful code used for the performance of  .NET

## Links useful

 - :rocket: [SharpLab](https://sharplab.io/)

## Requirements

The project requires [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).

## Compatible IDEs

Tested on:

- Visual Studio Code (1.73.1)

## Useful commands

From the terminal/shell/command line tool, use the following commands to build and test.

### Build the project

```console
$ dotnet build
```

### Run the tests

```console
$ dotnet test
```
## Examples


1 - String Manipulation

The most basic thing whats we need to know about it:

- String is a **reference type**
- But String is **immutable**

```csharp
 // cost to 1000 iteration
 string: 124 ms
 StringBuilder: 0 ms
```

*Avoid*
```csharp
string test = string.Empty;
test += "concat";
```
*Use*
```csharp
var test = new StringBuilder();
test.Append("append");
```

