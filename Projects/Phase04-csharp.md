<div dir="rtl" align='justify'>

# فاز چهار: #C

در این فاز با زبان سی‌شارپ آشنا خواهید شد. همچنین چند برنامه ساده با زبان سی‌شارپ خواهید نوشت.

1. نصب پیشنیازها:

   برای اجرا کردن کدی که به زبان سی‌شارپ می‌نویسید نیاز است چند مورد را نصب کنید.

   - بر اساس سیستم‌عامل نسخه مناسب  <span dir="ltr" align='justify'> .Net Core </span> را از [سایت مایکروسافت ](https://dotnet.microsoft.com/download) دانلود و نصب کنید.
   - بر روی VSCode اکستنشن‌های زیر رو نصب کنید:

    <div dir="ltr" align='justify'>

   * [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
   * [Code Runner](https://marketplace.visualstudio.com/items?itemName=formulahendry.code-runner)
   * [C# Extensions](https://marketplace.visualstudio.com/items?itemName=jchannon.csharpextensions)
   * [vscode-solution-explorer](https://marketplace.visualstudio.com/items?itemName=fernandoescolar.vscode-solution-explorer)
   * [.NET Core Test Explorer](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer)

    </div>

2. مفهوم Solution و Project:

   برای شروع ساخت یک برنامه در سی شارپ لازمه اول با مفهوم Solution و Project آشنا بشی. برای همین لینک‌ زیر رو بخون.


    <div dir="ltr" align='justify'>

    - [What is a C# solution and how to use it?](https://stackoverflow.com/a/40400159/7498797)
    </div>

3. سلام به دنیای سی شارپ:

   برای شروع VSCode رو باز کنید و یه فولدر رو جهت شروع انتخاب کنید. بعد در ترمینال دستور زیر رو وارد کنید. با این دستور یک پروژه‌ی سی‌شارپ با رابط کاربری کنسول ساخته می‌شود

   <div dir="ltr" align='justify'>

   `dotnet new console`
   </div>

   همینطوری که می‌بینی چند فایل و یک فولدر ساخته شد. اگه به فایل `Program.cs` بری اولین برنامه‌ای که با سی‌شارپ ساختی رو می‌بینی که یه کد ساده `Hello world!` است. برای اجرای این برنامه درون ترمینال دستور زیر را وارد کن.

   <div dir="ltr" align='justify'>

   `dotnet run`
   </div>

   الان در یک خط عبارت `Hello world!` چاپ شده رو می‌بینی.

4. NuGet چیست؟

   یه ابزار مورد نیاز برای هر دولوپری وجود داشتن بستریه که بتونه باهاش یه کد رو به اشتراک بزاره تا بقیه هم بتونن ازش به عنوان پکیج در کدهاشون استفاده بکنند.
   معمولا پکیج‌ها شامل یه سری کد کامپایل شده مثل DLL ها می‌شن به همراه بقیه چیزایی که ممکنه بهشون نیاز بشه.


    برای .NET (از جمله .NET Core) ،بستری که مایکروسافت برای به اشتراک گذاری کد آماده کرده NuGet عه که نحوه ایجاد، میزبانی و مصرف پکیج‌های مربوط به .NET را مشخص می‌کنه.
    می‌تونی به راحتی با نوشتن یه دستور در کنسول یه پکیج رو به پروژه‌ات اضافه بکنی.

    <div dir="ltr" align='justify'>

    `dotnet add package System.Text.Json`

    </div>

    دستور بالا پکیج `System.Text.Json` رو به برنامه اضافه می‌کنه. این پکیج آیتم‌ها سی‌شارپ رو به جیسون تبدیل می‌کنه. برای مثال کد زیر یه آیتم سی‌شارپ رو به جیسون تبدیل می‌کنه و در خروجی چاپ می‌کنه.

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
                var item = new Person() { FirstName = "Mahdi", LastName = "Malverdi"};
                var serializedItem = JsonSerializer.Serialize(item);
                Console.WriteLine(serializedItem);
            }
        }
    }
    ```

    </div>

    در سی‌شارپ برای استفاده از یه پکیج باید از using استفاده بکنید. using کارایی مشابه با import و include در زبان‌های دیگه رو داره.
    همچنین با استفاده از کلمه var در سی شارپ میتونی یک متغیر را تعریف کنی. وقتی از این کلمه برای تعریف متغیر استفاده می‌شه نیازی نیس نوع داده‌ی متغیر نیست و کامپایلر از روی مقداردهی اولیه، نوع متغیر را مشخص می‌کنه.

    اگه دوست داری بیشتر در مورد NuGet بدونی می‌تونی مقاله [An introduction to NuGet](https://docs.microsoft.com/en-us/nuget/what-is-nuget) رو بخونی.

5.  کمی پیشرفته‌تر:

    خب حالا وقتشه که کمی پیشرفته‌تر و منظم‌تر با سی‌شارپ برخورد کنی! توی این مرحله یاد می‌گیری چطور تست بنویسی و هم اینکه چطور با کنسول کار بکنی.

    اول کار سری به این [آموزش](https://softchris.github.io/pages/dotnet-core.html#creating-a-solution) بزن و سعی کن تمام کارهایی که گفته رو انجام بدی.

    اگه هم دوست داشتی می‌تونی از آموزش‌های زیر بر حسب موضوعی که نیاز داری استفاده بکنی:

    <div dir="ltr" align='justify'>

    - [Console.ReadLine() Method in C#](<https://www.geeksforgeeks.org/console-readline-method-in-c-sharp/#:~:text=Console.-,ReadLine()%20Method%20in%20C%23,user%20presses%20the%20Enter%20key.>)
    - [Console Class in C#](https://www.geeksforgeeks.org/console-class-in-c-sharp/#:~:text=Weekday%20in%20C%23-,Console%20Class%20in%20C%23,output%20from%20the%20computer%20end.)
    - [.NET Core CLI overview](https://docs.microsoft.com/en-us/dotnet/core/tools/)
    - [10 commands you don't want to be without in .Net Core](https://softchris.github.io/pages/dotnet-10-commands.html#_4-dotnet-run)
    - [Getting Started with xUnit.net](https://xunit.net/docs/getting-started/netcore/cmdline)

    </div>

6.  نام‌گذاری‌ها در سی‌شارپ:

    یکی از گام‌های مهم یادگیری هر زبان برنامه‌نویسی یادگیری اصول نامگذاری در اون زبانه! شاید در وهله اول مورد مهمی در نظر نیاد اما از اون نظر اهمیت داره که کدی می‌نویسی نباید تافته جدا بافته از بقیه جامعه اون زبان باشه. برای همین یه نگاهی به دو لینک زیر بنداز تا با قواعد نام گذاری در این زبان آشنا بشی.

    <div dir="ltr" align='justify'>

    - [C# Coding Standards and Naming Conventions](https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md)
    - [Naming Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines)

    </div>

7.  Lambda Expressions:

    عبارات لامبدا (Lambda expressions) ساده شده دستور زبان متدهای بی نام هستند.
    برای اینکه با این مفهوم بیشتر آشنا بشید می‌تونید لینک‌های زیر را مطالعه کنید.

    <div dir="ltr" align='justify'>

    - [Lambda Expressions in C#](https://www.geeksforgeeks.org/lambda-expressions-in-c-sharp/)
    - [Lambda Expressions in C#](https://www.c-sharpcorner.com/UploadFile/bd6c67/lambda-expressions-in-C-Sharp/)

   </div>

</div>

<div dir="rtl" align='justify'>

8.  Linq:

    LINQ مخفف عبارت Language-Integrated Query است توجه داشته باشید که آن را لینک (Link) تلفظ کنید. LINQ یک راه یکسان برای اتصال برقرار کردن به هر داده ساختار استاندارد را فراهم می‌کنه.
    برای درک بهتر و تمرین بیشتر می‌تونید لینک‌های زیر را مطالعه کنید:

    <div dir="ltr" align='justify'>

    - [LINQ Operators and Lambda Expressions](https://www.c-sharpcorner.com/UploadFile/babu_2082/linq-operators-and-lambda-expression-syntax-examples/)
    - [LINQ Lambda Expressions](https://www.tutlane.com/tutorial/linq/linq-lambda-expressions)

   </div>

</div>
