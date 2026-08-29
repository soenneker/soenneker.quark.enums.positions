[![](https://img.shields.io/nuget/v/soenneker.quark.enums.positions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.positions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.positions/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.positions/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.positions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.positions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.positions/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.positions/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.Positions

An HTML CSS keyword set in .NET enumeration form.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.Positions
```

## What you get

- `PositionKeyword` — An HTML CSS keyword set in .NET enumeration form.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `PositionKeyword.Relative` | Positioned relative to its normal position. | Positioned relative to its normal position. |
| `PositionKeyword.Absolute` | Positioned relative to the nearest positioned ancestor. | Positioned relative to the nearest positioned ancestor. |
| `PositionKeyword.Fixed` | Positioned relative to the viewport. | Positioned relative to the viewport. |
| `PositionKeyword.Sticky` | Positioned based on the user's scroll position. | Positioned based on the user's scroll position. |
