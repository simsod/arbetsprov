# Arbetsprov - Mall

Det här projektet är en enkel mall för att utföra enklare arbetsprov i [ASP.NET Core MVC](https://www.asp.net/) / C#.

Ladda ner dotnet core SDK från webbplatsen [dot.net](http://dot.net/).

Vi rekomenderar att projektet öppnas i [Visual Studio Code](https://code.visualstudio.com/download) eller [Visual Studio](https://visualstudio.microsoft.com/downloads/).

Har du kunskaper om git och vill visa detta för oss så kan du klona eller forka detta repository, alternativt kan du [ladda ner en kopia av källkoden som en zip-fil](https://github.com/simsod/arbetsprov/archive/master.zip).

## Om projektmallen

Mallen innehåller följande:

* En enkel ASP.NET Core MVC-baserad webbplats
    * En controller för att visa startsidan
    * En controller som agerar api ämnat för konsumption från javascript.               
* jQuery
* Bootstrap (eftersom fokus ska ligga på C# och javascript inte på css)
* site.js där du kan skriva ditt eget javascript (~/src/Arbetsprov/wwwroot/js/site.js)
    * site.js är redan inlänkad i mallen.
* Ett C# testprojekt där enhetstester kan skrivas (ej obligatoriskt).


## Kom igång

För att starta projektet behöver du som sagt ha dotnet core installerat och en editor att arbeta i.

Projektet kan startas från editorn via "Debug" knappen i vscode: 

![vscode](https://github.com/simsod/arbetsprov/blob/master/vscode.png?raw=true)

eller "Start" knappen i Visual Studio.

![Visual studio](https://github.com/simsod/arbetsprov/blob/master/vs.png?raw=true)

Alternativt kan man välja att starta applikationen från command-line genom att använda kommandot `dotnet watch run`.

Exempel:

```
/Users/yourname/checkout-directory/arbetsprov/src/Arbetsprov
➜  Arbetsprov git:(master) ✗ dotnet watch run
```



