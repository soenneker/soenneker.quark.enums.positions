[![](https://img.shields.io/nuget/v/soenneker.quark.enums.positions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.positions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.positions/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.positions/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.positions/build-and-test.yml?label=Build&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.positions/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.positions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.positions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.positions/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.positions/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.Positions

Strongly typed CSS `position` values for Quark components and styles.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.Positions
```

## Usage

```csharp
PositionKeyword position = PositionKeyword.Absolute;
string cssValue = position.Value; // "absolute"
```

Positioning still requires the corresponding inset values (`top`, `right`, `bottom`, `left`, or logical insets) when an element needs to be moved. The type also includes CSS-wide values from `GlobalKeyword`.

## Values

| Member | CSS value | Behavior |
| --- | --- | --- |
| `Static` | `static` | Uses normal flow; inset properties do not reposition the element. |
| `Relative` | `relative` | Keeps its space in normal flow and offsets from that position. |
| `Absolute` | `absolute` | Leaves normal flow and uses its containing block for offsets. |
| `Fixed` | `fixed` | Leaves normal flow and is usually positioned against the viewport. |
| `Sticky` | `sticky` | Behaves relatively until a scroll threshold is reached. |
