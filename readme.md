### VSCode + csharp(.net) + wmi

[参考](https://impsbl.hatenablog.jp/entry/VSCodeWithDNFW2)

#### install procedure
>dotnet new console --target-framework-override net472 -lang c# -o wmiSamples

> dotnet build
> dotnet run

#### add csproj

ItemGroupタグで参照するdllを追加する

```csproj
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net472</TargetFramework>
  </PropertyGroup>

    <ItemGroup>
    <Reference Include="System.Management" />
  </ItemGroup>

</Project>

```

#### wmi info
- 機種品番(型番/Model Number)/SystemSKUNumber
Win32_ComputerSystem.SystemSKUNumber

- 製造番号/SerialNumber
Win32_BIOS.SerialNumber