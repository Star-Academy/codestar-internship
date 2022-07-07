<div dir="rtl" align='right'>

#  آشنایی با #C

<div align='center'>

**[⚡Issues⚡](./issue-template.md)**
</div>

در این فاز با زبان #C آشنا خواهید شد. همچنین چند برنامۀ ساده با این زبان خواهید نوشت.

## نصب پیش‌نیازها

در قدم اول برای کار با زبان #C پیشنهاد می‌کنیم از [VS Code]() استفاده کنید تا با  [Net CLI.](https://docs.microsoft.com/en-us/dotnet/core/tools/) بهتر آشنا شوید.
برای نوشتن کد به زبان #C در VS Code مراحل زیر را طی کنید:

1. نصب [NET SDK](https://dotnet.microsoft.com/en-us/download).
1. نصب [اکستنشن #C](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)

پس از نصب موارد بالا دستور ```dotnet --info ``` را در ترمینال اجرا کنید تا نسخه‌های Net. نصب شده را مشاهده کنید.
*پیشنهاد می‌شود نسخه جدید [ترمینال ویندوز](https://github.com/microsoft/terminal/releases) را نیز نصب کنید.*

## آشنایی با مبانی زبان #C

بهتر است ابتدا با Solution و Project  در زبان #C آشنا شوید که برای درک این مفاهیم [?What is a C# solution and how to use it](https://stackoverflow.com/a/40400159/7498797) را مطالعه کنید؛ سپس در صورتی که با زبان Java آشنایی دارید [C# Crash Course for Java Developers](https://nerdparadise.com/programming/csharpforjavadevs) را مطالعه بفرمایید. در غیر این صورت از [این لینک](https://www.w3schools.com/cs/index.php) جهت یادگیری مبانی #C استفاده ‌‌‌‌‌‌‌کنید.

## اولین برنامه
   
ابتدا VS Code را باز کنید و یک پوشه انتخاب کنید.  سپس در ترمینال، برای ایجاد یک Console App دستور زیر را اجرا کنید:
<div dir="ltr" align='justify'>

```shell
dotnet new console
```
</div>

برای باز کردن ترمینال در محیط VSCode می‌توانید از میانبر ```ctrl + ` (tilde)``` استفاده کنید.
پس از اجرای دستور بالا چند فایل و یک پوشه ساخته می‌شوند. اگر فایل `Program.cs` را باز کنید، مشاهده می‌کنید که یک کد ساده‌ی چاپ `Hello world` در آن نوشته شده است. برای اجرای این برنامه درون ترمینال دستور زیر را اجرا کنید:

<div dir="ltr" align='justify'>

```shell
dotnet run
```

</div>

با اجرای دستور بالا باید عبارت `Hello World` در ترمینال چاپ شود.

## NuGet
توسعه‌دهندگان برای اشتراک و دریافت کدهای به اشتراک گذاشته شده از ابزارهایی تحت عنوان Package Manager استفاده می‌‌کنند. در پلتفرم Net. از NuGet استفاده ‌می‌شود.  NuGet کدها را در قالب فایل‌هایی (Package) با پسوند nupkg. نگه‌داری می‌کند. این فایل یک فایل zip حاوی کدهای کامپایل شده (dll)، فایل‌های مورد نیاز برای استفاده از package و نیز اطلاعات خود Package می‌باشد.  این ابزار، مکانیزم‌هایی برای ایجاد، نگهداری و استفادۀ از کدها ارائه می‌دهد که برای هرکدام از این مکانیزم‌ها ابزارهایی نیز فراهم کرده‌است. هنگام استفاده از NuGet توسعه دهنده نگران دریافت و اشتراک کدها نمی‌باشد چرا که خود NuGet این عملیات‌ها را مدیریت می‌کند.




دستور زیر پکیج `System.Text.Json` را به برنامه اضافه می‌کند. این پکیج امکان تبدیل اشیاء زبان #C به Json و برعکس را فراهم می‌کند. 

<div dir="ltr" align='justify'>

```shell
dotnet add package System.Text.Json
```

</div>

کد زیر یک شیء #C را به Json تبدیل کرده و در خروجی چاپ می‌کند.


<div dir="ltr" align='justify'>

```C#
using System;
using System.Text.Json;

namespace HelloWorld
{
    public class Person
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            var item = new Person() { FirstName = "Foo", LastName = "Bar"};
            var serializedItem = JsonSerializer.Serialize(item);
            Console.WriteLine(serializedItem);
        }
    }
}
```

</div>

در #C برای استفاده از کتابخانه‌ها باید با کلیدواژۀ using کتابخانه را به کد اضافه کنید. کارایی using مشابه با import و include  در زبان‌های دیگر می‌باشد.

 همچنین برای تعریف متغییر می‌توانید از کلیدواژۀ var استفاده کنید. در این صورت کامپایلر از روی مقدار اولیه، نوع متغیر را مشخص می‌کند.

<div dir="ltr" align='justify'>

```C#
var i = 0;
// i is int
var s = "hi";
// s is string
```

</div>

اگر دوست دارید بیشتر در مورد NuGet بدانید می‌توانید مقاله [An introduction to NuGet](https://docs.microsoft.com/en-us/nuget/what-is-nuget) را بخوانید.

## کمی پیشرفته‌تر

در این مرحله یاد می‌گیرید چگونه با کنسول کار کنید.
 ابتدا سری به این [آموزش](https://softchris.github.io/pages/dotnet-core.html#creating-a-solution) بزنید و سعی کنید تمام کارهای گفته شده را انجام دهید. سپس می‌توانید برحسب نیاز از آموزش‌های زیر نیز استفاده کنید:
<div dir="ltr" align='justify'>

- [Console.ReadLine() Method in C#](<https://www.geeksforgeeks.org/console-readline-method-in-c-sharp/#:~:text=Console.-,ReadLine()%20Method%20in%20C%23,user%20presses%20the%20Enter%20key.>)
- [Console Class in C#](https://www.geeksforgeeks.org/console-class-in-c-sharp/#:~:text=Weekday%20in%20C%23-,Console%20Class%20in%20C%23,output%20from%20the%20computer%20end.)
- [10 commands you don't want to be without in .Net Core](https://softchris.github.io/pages/dotnet-10-commands.html#_4-dotnet-run)

</div>

###  نام‌گذاری‌ها در #C
یکی از گام‌های مهم یادگیری هر زبان برنامه‌نویسی یادگیری اصول نام‌گذاری زبان می‌باشد. شاید نام‌گذاری در وهله اول مورد مهمی به نظر نرسد اما این موضوع از جهتی اهمیت دارد که نباید کد شما نسبت به کدهای جامعه برنامه نویسان آن زبان تافته جدا بافته باشد. برای آشنایی با این قواعد صفحات زیر را مطالعه کنید:

<div dir="ltr" align='justify'>

- [C# Coding Standards and Naming Conventions](https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md)
- [Naming Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines)

</div>

### Lambda Expressions

عبارات لامبدا (Lambda expressions) ساده شده متدهای بی‌نام (Anonymous Function) هستند.
برای اینکه با این مفهوم بیشتر آشنا بشید می‌تونید لینک‌های زیر را مطالعه کنید.

<div dir="ltr" align='justify'>

- [Lambda Expressions in C# (GeeksforGeeks)](https://www.geeksforgeeks.org/lambda-expressions-in-c-sharp/)
- [Lambda Expressions in C# (C# Corner)](https://www.c-sharpcorner.com/UploadFile/bd6c67/lambda-expressions-in-C-Sharp/)

</div>

### Extension Method

برای اضافه کردن متد به کلاس‌های موجود بدون تغییر کلاس اصلی، تعریف کلاس فرزند یا کامپایل مجدد کتابخانه از Extension Method استفاده می‌شود. Extension methodها static هستند و خارج از کلاس مورد نظر پیاده سازی می‌شوند اما به نحوی صدا زده می‌شوند که گویا عضوی از آن کلاس می‌باشند.
مثلا می‌خواهیم یک عملکرد برای کلاس string پیاده‌سازی کنیم به صورتی که تعداد کلمات یک  متن را برای ما شمارش کند:

<div dir="ltr" align='justify'>

```C#
namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static int WordCount(string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
} 
```

</div>

استفاده از کد بالا به صورت زیر می باشد.

<div dir="ltr" align='justify'>

```C#
var s = “Hello Extension Methods”;
var i = MyExtensions.WordCount(s);
```

</div>

حال اگر عبارت `public static int WordCount(string str)` را به `public static int WordCount(this string str)` تغییر دهیم. می‌توانیم به این صورت از extension method استفاده کنیم:

<div dir="ltr" align='justify'>

```C#
var s = "Hello Extension Methods";
var i = s.WordCount();
```

</div>

برای مطالعه‌ی بیشتر [Extension Methods (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods) را مطالعه کنید.

### LINQ

واژه LINQ (توجه داشته باشید که آن را Link تلفظ کنید) مخفف عبارت Language-Integrated Query است. LINQ یک راه یکسان را برای اتصال برقرار کردن به هر داده ساختار استاندارد فراهم می‌کند.
برای درک بهتر و تمرین بیشتر لینک‌های زیر را مطالعه کنید:

<div dir="ltr" align='justify'>

- [LINQ Operators and Lambda Expressions](https://www.c-sharpcorner.com/UploadFile/babu_2082/linq-operators-and-lambda-expression-syntax-examples/)
- [LINQ Lambda Expressions](https://www.tutlane.com/tutorial/linq/linq-lambda-expressions)


</div>

### C# Interactive

گاهی نیاز داریم در محیطی تعاملی مانند زبان‌های مفسری (مثل javascript ،python یا ...) دستورات ad-hoc اجرا کنیم. C# نیز این امکان را با نام Net Interactive. در اختیار ما قرار داده است. برای استفاده از این ابزار اکستنشن [Net Interactive.](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-interactive-vscode) را برای VS Code نصب کنید.
پس از نصب اکستنشن در محیط Net Interactive. این دستورات را اجرا کنید.

<div dir="ltr" align='justify'>

```C#
2 + 2
```

```C#
System.IO.Directory.GetCurrentDirectory()
```

</div>


## پروژه

برنامه‌ای بنویسید که دو فایل [دانشجویان](./Students.json) و [نمرات](./Scores.json) را بخواند و سپس نام، نام خانوادگی و معدل سه دانشجوی اول را چاپ کند.


برای کار با زبان C# می‌توانید IDEهای [Visual Studio]("") یا [Rider]("") را نصب کنید و از امکاناتشان بهره‌مند شوید.
**برای کار روی پروژه‌ها پیشنهاد می‌شود حتما از IDE استفاده ‌‌‌‌کنید.**


</div>