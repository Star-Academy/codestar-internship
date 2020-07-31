<div dir="rtl" align='justify'>

# فاز چهار: C

در این فاز با زبان سی‌شارپ آشنا خواهید شد. همچنین برنامه‌ای را که به زبان جاوا نوشته‌اید را به زبان سی‌شارپ تبدیل خواهید کرد.

1. نصب پیشنیازها:

   برای اجرا کردن کدی که به زبان سی‌شارپ می‌نویسید نیاز است چند مورد را نصب کنید.

   - بر اساس سیستم‌عاملت نسخه مناسبت را از [سایت مایکروسافت ](https://dotnet.microsoft.com/download/dotnet-core/3.1) دانلود و نصب کن.
   - بر روی VSCode اکستنشن‌های زیر رو نصب کن:
     1. [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
     2. [Code Runner](https://marketplace.visualstudio.com/items?itemName=formulahendry.code-runner)
     3. [C# Extensions](https://marketplace.visualstudio.com/items?itemName=jchannon.csharpextensions)
     4. [vscode-solution-explorer](https://marketplace.visualstudio.com/items?itemName=fernandoescolar.vscode-solution-explorer)
     5. [.NET Core Test Explorer](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer)

2. مفهوم Solution و Project:

    برای شروع ساخت یک برنامه در سی شارپ لازمه اول با مفهوم Solution و Project آشنا بشی. برای همین لینک‌ زیر رو بخون.
    - [What is a C# solution and how to use it?](https://stackoverflow.com/a/40400159/7498797)

3. سلام به دنیای سی شارپ:

    برای شروع VSCode رو باز کن و یه فولدر رو جهت شروع انتخاب کن. بعد در ترمینال دستور زیر رو وارد کن.

    `dotnet new console`

    همینطوری که می‌بینی چند فایل و یک فولدر ساخته شد. اگه به فایل `Program.cs` بری اولین برنامه‌ای که با سی‌شارپ ساختی رو می‌بینی که یه کد ساده `Hello world!` است.
    برای اجرای این برنامه درون ترمینال دستور زیر را وارد کن.

    `dotnet run`

    الان در یک خط عبارت `Hello world!` چاپ شده رو می‌بینی.

4. NuGet چیست؟

یه ابزار مورد نیاز برای هر دولوپری وجود داشتن بستریه که بتونه باهاش یه کد رو به اشتراک بزاره تا بقیه هم بتونن ازش به عنوان پکیج در کدهاشون استفاده بکنند.
معمولا پکیج‌ها شامل یه سری کد کامپایل شده مثل DLL ها می‌شن به همراه بقیه چیزایی که ممکنه بهشون نیاز بشه.


برای .NET (از جمله .NET Core) ،بستری که مایکروسافت برای به اشتراک گذاری کد آماده کرده NuGet عه که نحوه ایجاد، میزبانی و مصرف پکیج‌های مربوط به .NET را مشخص می‌کنه.
می‌تونی به راحتی با نوشتن یه دستور در کنسول یه پکیج رو به پروژه‌ات اضافه بکنی.

`dotnet add package System.Text.Json`

دستور بالا پکیج `System.Text.Json` رو به برنامه اضافه می‌کنه. این پکیج آیتم‌ها سی‌شارپ رو به جیسون تبدیل می‌کنه. برای مثال کد زیر یه آیتم سی‌شارپ رو به جیسون تبدیل می‌کنه و در خروجی چاپ می‌کنه.

```
using System;
using System.Text.Json;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new { FirstName = "Mahdi", LastName= "Malverdi"};
            var serializedItem = JsonSerializer.Serialize(item);
            Console.WriteLine(serializedItem);
        }
    }
}
```

در سی‌شارپ برای استفاده از یه پکیج باید از using استفاده بکنید. using کارایی مشابه با import و include در زبان‌های دیگه رو داره.


5. کمی پیشرفته‌تر:
    خب حالا وقتشه که کمی پیشرفته‌تر و منظم‌تر با سی‌شارپ برخورد کنی! توی این مرحله یاد می‌گیری چطور تست بنویسی و هم اینکه چطور با کنسول کار بکنی.

    اول کار سری به این [آموزش](https://softchris.github.io/pages/dotnet-core.html#resources) بزن و سعی کن تمام کارهایی که گفته رو انجام بدی.

    اگه هم دوست داشتی می‌تونی از آموزش‌های زیر بر حسب موضوعی که نیاز داری استفاده بکنی:
    - [Console.ReadLine() Method in C#](https://www.geeksforgeeks.org/console-readline-method-in-c-sharp/#:~:text=Console.-,ReadLine()%20Method%20in%20C%23,user%20presses%20the%20Enter%20key.)
    - [Console Class in C#](https://www.geeksforgeeks.org/console-class-in-c-sharp/#:~:text=Weekday%20in%20C%23-,Console%20Class%20in%20C%23,output%20from%20the%20computer%20end.)
    - [.NET Core CLI overview](https://docs.microsoft.com/en-us/dotnet/core/tools/)
    - [10 commands you don't want to be without in .Net Core](https://softchris.github.io/pages/dotnet-10-commands.html#_4-dotnet-run)
    - [Getting Started with xUnit.net](https://xunit.net/docs/getting-started/netcore/cmdline)

6. Design patterns:


</div>
