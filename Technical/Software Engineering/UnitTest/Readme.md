<div dir="rtl" align='right'>

# Unit Test

<div align='center'>

**[⚡Issues⚡](./issue-template-simpleProject.md)**

</div>

در این فاز با Unit Test
و مفهوم Code Coverage
آشنا خواهید شد. همچنین برای کدی که در فازهای قبلی نوشته‌اید، تست می‌نویسید و کیفیت کد خود را بیش از پیش افزایش می‌دهید.

## مفهوم Unit Test و اهمیت آن 

برای آگاهی از اهمیت نوشتن Unit Test
در فرایند توسعۀ نرم‌افزار، لینک‌های زیر را مطالعه کنید:

<div dir="ltr" align="left">

- [Unit Testing - Important role in Software Development](https://medium.com/nonstopio/unit-testing-important-role-in-software-development-1f52f7c810f8)
- [Why Is Unit Testing Important in Software Development?](https://performancelabus.com/unit-testing-importance/)
- [The importance of Unit Testing](https://fortegrp.com/the-importance-of-unit-testing/)
- [Time difference between developing with unit tests vs no tests](https://softwareengineering.stackexchange.com/questions/322256/time-difference-between-developing-with-unit-tests-vs-no-tests)

</div>

## مفهوم Code Coverage در Unit Testing و اهمیت آن

پس از مطالعه و درک مفهوم Unit Testing
و اهمیت آن در توسعۀ‌ نرم‌افزار، برای درک مفهوم Code Coverage
و اهمیت آن لینک‌های زیر را مطالعه کنید:

<div dir="ltr" align="left">

- [Code Coverage - Wikipedia](https://en.wikipedia.org/wiki/Code_coverage)
- [5 Reasons You Should Care about Code Coverage](https://eldarion.com/blog/2017/07/13/5-reasons-you-should-care-about-code-coverage/)
- [The Importance of Code Coverage](https://blog.cloudboost.io/the-importance-of-code-coverage-9b4d513f39b4)

</div>

## نوشتن Unit Test در #C با استفاده از xUnit

برای شروع کار با xUnit، پیشنهاد می‌شود [Using xUnit to Test your C# Code](https://auth0.com/blog/xunit-to-test-csharp-code/)
و [Getting Started with xUnit.net](https://xunit.net/docs/getting-started/netfx/visual-studio) را مطالعه کنید. همچنین می‌توانید نحوۀ مشاهدۀ Code Coverage
را برای IDEهای Visual Studio و Rider از طریق لینک‌های زیر یاد بگیرید:

<div dir="ltr" align="left">

- [Use code coverage to determine how much code is being tested (Visual Studio)](https://docs.microsoft.com/en-us/visualstudio/test/using-code-coverage-to-determine-how-much-code-is-being-tested?view=vs-2022&tabs=csharp)
- [Analyze Coverage of Unit Tests (Rider)](https://www.jetbrains.com/help/rider/Cover_Unit_Tests_(Basic_Scenario).html)

</div>

برای آشنایی بهتر با xUnit مشاهده [Writing tests in .NET using xUnit](https://www.youtube.com/watch?v=2Wp8en1I9oQ) پیشنهاد می‌شود.

## تاثیر اصول SOLID بر Unit Tesing

برای آگاهی از تاثیر رعایت اصول SOLID
بر تست‌نویسی [SOLID, Object Oriented Design and Unit Testing](https://huestones.co.uk/2015/06/solid-object-oriented-design-and-unit-testing/) را مطالعه کنید.

## آشنایی با Mock

یک تکنیک تست‌نویسی، Mock 
کردن است که در آن، قسمتی از کد را با یک پیاده‌سازی دلخواه جایگزین می‌کنیم و از آن برای شبیه‌سازی یک عملیات واقعی استفاده می‌شود. معمولا Mock
کردن زمانی استفاده می‌شود که یک متد یا کلاس، وابستگی یا وابستگی‌هایی دارد که در تست ما تداخل نامطلوبی ایجاد می‌کند.

مثلا فرض کنید می‌خواهید سرویسی را تست کنید که در آن از یک `SmsSender`
استفاده شده‌است. در نتیجه هر بار که آن تست را اجرا کنید، یک SMS
نیز ارسال می‌شود، که این برای ما مطلوب نیست.

در این صورت، باید `SmsSender`
را Mock
کرد که دیگر SMS
ارسال نکند، ولی همواره مثلا `true`
برگرداند، به این معنی که ارسال با موفقیت انجام شده‌است. در نتیجه می‌توانیم عملکرد همان متد را تست کنیم، به جای این که بخواهیم درگیر وابستگی‌های آن نیز شویم. 

برای آشنایی بهتر با Mock
و نحوۀ استفاده این تکنیک در زبان #C
از لینک‌های زیر کمک بگیرید:

<div dir="ltr" align="left">

- [What is a mock and when should you use it](https://stackoverflow.com/questions/214092/what-is-a-mock-and-when-should-you-use-it)
- [Getting started with moq](https://riptutorial.com/moq)

</div>

## نوشتن تست برای الگوریتم جستجو

در این مرحله، با استفاده از دانشی که در این فاز به دست آورده‌اید، برای بخش‌های مختلف کد خود تست بنویسید. سعی کنید Code Coverage
تست را به بالای ۹۵٪ برسانید.

برای این کار یک برنچ با نام `feature/unit-test`
بسازید و نوشتن تست را روی آن انجام دهید.

</div>