# Exercise 8 – Interface i C#

En liten konsolövning som visar hur klasser kan implementera ett eller flera interface, och hur interface används för att anropa metoder.

## Det här visar övningen

- `Program1` implementerar både `IMyInterface` och `IMyExtraInterface`.
- `Program2` implementerar `IMyInterface`.
- `DoubleTrouble` implementerar två interface som båda deklarerar metoden `run()`, men med olika returtyper.
- `DoubleTrouble` använder **explicit interface implementation**. Därför anropas metoderna via respektive interface i stället för direkt på objektet:

```csharp
((IDoubleTroubleVoid)doubleTrouble).run();
int value = ((IDoubleTroubleInt)doubleTrouble).run();
```

Detta låter klassen ge de två interface-metoderna olika implementationer trots att de har samma namn. Den första metoden returnerar inget värde; den andra returnerar `7`.

## Kör programmet

Från lösningens rotmapp:

```powershell
dotnet run --project .\Exercise8\Exercise8.csproj
```

Programmet skriver ut meddelanden från `Program1`, `Program2` och `DoubleTrouble`, inklusive värdet som returneras från `IDoubleTroubleInt.run()`.

## Projektstruktur

- `Exercise8\Program.cs` – interface, implementationer och programmets `Main`-metod.
- `Exercise8\Exercise8.csproj` – projektfil för konsolprogrammet (målramverk .NET 10).