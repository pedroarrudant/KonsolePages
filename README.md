# Konsole Pages

Use this package to help you with your console application. It allows you to make fancy and easy-to-use pages on your console app to improve navigability and readability.

![GitHub - Badge](https://github.com/pedroarrudant/KonsolePages/actions/workflows/publish.yml/badge.svg?branch=main)

![Nuget Version](https://img.shields.io/nuget/v/KonsolePages)

![Nuget Downloads](https://img.shields.io/nuget/dt/KonsolePages)

![GitHub](https://img.shields.io/github/license/pedroarrudant/konsolepages)

## Installation

Install the NuGet package of [Konsole Pages](https://www.nuget.org/packages/KonsolePages)

## How to use

Use the correct namespaces.

```csharp
using Core.Elements;
using Core.Page;
```

Instantiate your first window:

```csharp
var firstWindow = new Window();
```

Then use the method *GenerateWindow* to create a new element on a *Header*, *Footer* or *Body* section.

```csharp
            firstWindow.GenerateWindow(x => {
                x.Header.AddPageElement(Element.Line);
                x.Header.AddPageElement(Element.Label, "Header");
                x.Header.AddPageElement(Element.Line);
                x.Body.AddPageElement(Element.Option, mainMenu);
                x.Footer.AddPageElement(Element.Line);
                x.Footer.AddPageElement(Element.Label, "Footer");
                x.Footer.AddPageElement(Element.Line);
            });
```

You can use some elements to fill your page, such as:

```json
        Option,
        ConditionalStatement,
        Label,
        ProgressBar,
        Line
```

Then you can set the page to have a return type on generics calling the method *Run*.

```csharp
var @return = firstWindow.Run<int>();
```

All types are easy to use, and just using the *Run* method you can play with those. But when you use a *ProgressBar* element, you need to call the *Update* method to increase the progress 25% for every update. This is needed because there's no parameter to input on a new element.

```csharp
firstWindow.Update();
```