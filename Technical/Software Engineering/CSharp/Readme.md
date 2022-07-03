<div dir="rtl" align='right'>

#  آشنایی با #C

<div align='center'>

**[⚡Issues⚡](./issue-template.md)**
</div>

در این فاز با زبان #C آشنا خواهید شد. همچنین چند برنامۀ ساده با زبان #C خواهید نوشت.

## نصب پیش‌نیازها:

در قدم اول برای کار با زبان #C پیشنهاد می‌کنیم از [VS Code]() استفاده کنید تا با  [Net CLI.](https://docs.microsoft.com/en-us/dotnet/core/tools/) بهتر آشنا شوید.
برای نوشتن کد به زبان #C در VS Code مراحل زیر را طی کنید:

1. نصب [NET SDK](https://dotnet.microsoft.com/en-us/download).
1. نصب اکستنشن [#C](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)

پس از نصب موارد بالا دستور ```dotnet --info ``` را در ترمینال اجرا کنید.

*پیشنهاد می‌شود نسخه جدید [ترمینال ویندوز](https://github.com/microsoft/terminal/releases) را نیز نصب کنید.*


## آشنایی با زبان #C:

بهتر است ابتدا با Solution و Project  در زبان C# آشنا شوید که برای درک این مفاهیم [?What is a C# solution and how to use it](https://stackoverflow.com/a/40400159/7498797) را مطالعه کنید، سپس در صورتی که با زبان Java آشنایی دارید [C# Crash Course for Java Developers](https://nerdparadise.com/programming/csharpforjavadevs) را مطالعه بفرمایید. در غیر این صورت از [این لینک](https://www.w3schools.com/cs/index.php) استفاده ‌‌‌‌‌‌‌کنید.

## اولین برنامه
   
ابتدا VS Code را باز کنید و یک پوشه انتخاب کنید.  سپس در ترمینال، برای ایجاد یک Console App دستور زیر را اجرا کنید:
<div dir="ltr" align='justify'>

`dotnet new console`
</div>

برای باز کردن ترمینال در محیط VSCode از short-key زیر استفاده کنید.


<div dir="ltr" align='justify'>

```
ctrl + `
```

</div>

پس از اجرای دستور بالا چند فایل و یک پوشه ساخته می‌شوند. اگر فایل `Program.cs` را باز کنید، مشاهده می‌کنید که یک کد ساده‌ی چاپ `Hello world` در این فایل نوشته شده است. برای اجرای این برنامه درون ترمینال دستور زیر را اجرا کنید:

<div dir="ltr" align='justify'>

`dotnet run`
</div>

با اجرای دستور بالا باید عبارت `Hello World` در ترمینال چاپ شود.

به سیمنتبمنسیت 
sldkjfalsdkjf
سمینبتشسمینبتس
sldkjfasdlkf


## NuGet
توسعه‌دهندگان برای اشتراک و دریافت کدهای به اشتراک گذاشته شده از ابزارهایی تحت عنوان Package Manager استفاده می‌‌کنند. در پلتفرم .Net ما از NuGet Package Manager استفاده ‌می‌کنیم.  این ابزار، مکانیزم‌هایی برای ایجاد، نگهداری و استفادۀ از کدها ارائه می‌دهد که برای هرکدام از این مکانیزم‌ها ابزارهایی را فراهم کرده‌است. NuGet کدها را در قالب Packageهایی با پسوند .nupkg نگه‌داری می‌کند. این فایل حاوی کدهای کامپایل شده (dll)، فایل‌های مورد نیاز برای استفاده از package و نیز اطلاعات خود Package می‌باشد. NuGet Pckage Manager خود نیز عملیات دریافت و اشتراک کدها را مدیریت می‌کند.




دستور زیر پکیج `System.Text.Json` را به برنامه اضافه می‌کند. این پکیج امکان تبدیل اشیاء زبان #C به Json و برعکس را فراهم می‌کند. برای مثال کد زیر یک شیء #C را به Json تبدیل کرده و در خروجی چاپ می‌کند.

<div dir="ltr" align='justify'>

`dotnet add package System.Text.Json`

</div>

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

در #C برای استفاده از کتابخانه‌ها باید با کلیدواژۀ using کتابخانه را به کد اضافه کنید. کارایی using مشابه با import و include  در زبان‌های دیگر می‌باشد. همچنین برای تعریف متغییر می‌توانید از کلیدواژۀ var استفاده کنید. در این صورت کامپایلر از روی مقدار اولیه، نوع متغیر را مشخص می‌کند.

<div dir="ltr" align='justify'>

```C#
var i = 0;
// i is int
var s = "hi";
// s is string
```

</div>

اگر دوست دارید بیشتر در مورد NuGet بدانید می‌توانید مقاله [An introduction to NuGet](https://docs.microsoft.com/en-us/nuget/what-is-nuget) را بخوانید.

## کمی پیشرفته‌تر:

در این مرحله یاد می‌گیرید چگونه با کنسول کار کنید.
 ابتدا سری به این [آموزش](https://softchris.github.io/pages/dotnet-core.html#creating-a-solution) بزنید و سعی کنید تمام کارهای گفته شده را انجام دهید. سپس می‌توانید برحسب نیاز از آموزش‌های زیر نیز استفاده کنید:
<div dir="ltr" align='justify'>

- [Console.ReadLine() Method in C#](<https://www.geeksforgeeks.org/console-readline-method-in-c-sharp/#:~:text=Console.-,ReadLine()%20Method%20in%20C%23,user%20presses%20the%20Enter%20key.>)
- [Console Class in C#](https://www.geeksforgeeks.org/console-class-in-c-sharp/#:~:text=Weekday%20in%20C%23-,Console%20Class%20in%20C%23,output%20from%20the%20computer%20end.)
- [10 commands you don't want to be without in .Net Core](https://softchris.github.io/pages/dotnet-10-commands.html#_4-dotnet-run)

</div>

##  نام‌گذاری‌ها در #C:
یکی از گام‌های مهم یادگیری هر زبان برنامه‌نویسی یادگیری اصول نام‌گذاری زبان می‌باشد. شاید نام‌گذاری در وهله اول مورد مهمی به نظر نرسد اما این موضوع از جهتی اهمیت دارد که نباید کد شما نسبت به کدهای جامعه برنامه نویسان آن زبان تافته جدا بافته باشد. برای آشنایی با این قواعد صفحات زیر را مطالعه کنید:

<div dir="ltr" align='justify'>

- [C# Coding Standards and Naming Conventions](https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md)
- [Naming Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines)

</div>

## Lambda Expressions:

عبارات لامبدا (Lambda expressions) ساده شده متدهای بی‌نام (Anonymous Function) هستند.
برای اینکه با این مفهوم بیشتر آشنا بشید می‌تونید لینک‌های زیر را مطالعه کنید.

<div dir="ltr" align='justify'>

- [Lambda Expressions in C# (GeeksforGeeks)](https://www.geeksforgeeks.org/lambda-expressions-in-c-sharp/)
- [Lambda Expressions in C# (C# Corner)](https://www.c-sharpcorner.com/UploadFile/bd6c67/lambda-expressions-in-C-Sharp/)

</div>

## Extension Method

برای اضافه کردن متد به تایپ‌های موجود، بدون تغییر تایپ اصلی، تعریف کلاس فرزند یا کامپایل مجدد کتاب‌خانه از Extension Method استفاده می‌شود. Extension method ها static هستند اما به نحوی صدا زده می‌شوند که گویا عضوی از تایپ مورد‌نظر می‌باشند.
مثلا می‌خواهیم یک عملکرد برای تایپ string پیاده‌سازی کنیم به صورتی که تعداد کلمات یک  متن را برای ما شمارش کند:
<div dir="ltr" align='justify'>

```C#
namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static int WordCount(string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
} 
```
</div>

استفاده از کد بالا به صورت زیر می باشد.

<div dir="ltr" align='justify'>

```C#
String s = “Hello Extension Methods”
Int i = MyExtensions.WordCount(s)
```

</div>

حال اگر عبارت `public static int WordCount(string str)` را مانند `public static int WordCount(this string str)` بنویسیم. میتوانیم به این صورت از extension method استفاده کنیم.
<div dir="ltr" align='justify'>

```
string s = "Hello Extension Methods";
int i = s.WordCount();
```
</div>



## LINQ

LINQ مخفف عبارت Language-Integrated Query است توجه داشته باشید که آن را لینک (Link) تلفظ کنید. LINQ یک راه یکسان برای اتصال برقرار کردن به هر داده ساختار استاندارد را فراهم می‌کنه.
برای درک بهتر و تمرین بیشتر می‌تونید لینک‌های زیر را مطالعه کنید:

<div dir="ltr" align='justify'>

- [LINQ Operators and Lambda Expressions](https://www.c-sharpcorner.com/UploadFile/babu_2082/linq-operators-and-lambda-expression-syntax-examples/)
- [LINQ Lambda Expressions](https://www.tutlane.com/tutorial/linq/linq-lambda-expressions)


</div>

## C# Interactive

بعضا نیاز داریم در محیطی تعاملی مانند زبانهای مفسری (javascript, python, ...) دستورات ad-hoc اجرا کنیم. C# نیز این امکان را در اختیار ما قرار داده است. برای استفاده از ‌‌‌ C# Interactive [این لینک](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-interactive-vscode) را دنبال کنید.

در محیط C# Interactive این دستورات را اجرا کنید.

<div dir="ltr" align='justify'>

```C#
2 + 2
```

```C#
System.IO.Directory.GetCurrentDirectory()
```

</div>


## پروژه

برای کار با زبان C# می‌توانید IDE های [Visual Studio]("") یا [Rider]("") را نصب کنید و از امکاناتشان بهره‌مند شوید. برای کار با پروژه‌های بزرگ پیشنهاد می‌شود حتما از IDE استفاده ‌‌‌‌کنید.



برنامه‌ای بنویسید که دو فایل [دانشجویان](https://github.com/Star-Academy/codestar-internship/blob/master/Projects/Phase04-CSharp/Students.json) و [نمرات](https://github.com/Star-Academy/codestar-internship/blob/master/Projects/Phase04-CSharp/Scores.json) را بخواند و سپس نام، نام خانوادگی و معدل سه دانشجوی اول را چاپ کند.

</div>
