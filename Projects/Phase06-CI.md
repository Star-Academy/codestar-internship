<div dir="rtl" align='justify'>

[لیست تسک‌های مرتبط با این فاز به صورت issue template](./issue-template-Phase06.md)

#  فاز شش: CI/CD

در این فاز با مفهوم CI/CD
و اهمیت استفاده از آن آشنا خواهید شد. همچنین پروژهٔ خود را به CI
مجهز می‌کنید.

1. CI/CD چیست و چرا اهمیت دارد:

    در این مرحله، در مورد مفهوم CI/CD
    و اهمیت آن مطالعه کنید. در این بخش، مطالعه‌ی لینک‌های زیر پیشنهاد می‌شود.

    <div dir="ltr">

    - [What is CI/CD?](https://medium.com/tilicholabs/what-is-ci-cd-c7c047b80e6b)
    - [What’s the Point of CI Anyway?](https://medium.com/swlh/whats-the-point-of-ci-anyway-ac3f9eaa244c)
    - [The Journey to CI/CD](https://medium.com/driven-by-code/the-journey-to-ci-cd-b1872927c36b)

    </div>

1. آشنایی با GithHub Actions و اضافه کردن CI/CD Pipeline به ریپازیتوری:

    یکی از ابزار CI/CD
    مطرح، GitHub Actions
    است که به کمک آن، می‌توانید یک Pipeline
    شامل عملیات build،
    اجرای unit test
    ها و همچنین انتشار package
    و دیگر عملیاتی که در دستهٔ CI/CD
    می‌گنجد را به ریپازیتوری گیت‌هاب خود اضافه کنید.

    1. ابتدا Pipeline
    خود را با تسک build
    بسازید.


1. Unit Test و اهمیت آن:

    در این مرحله در مورد اهمیت نوشتن Unit Test
    در توسعه نرم‌افزار مطالعه کنید. در این مرحله مطالعه‌ی لینک‌های زیر پیشنهاد می‌شود.

    <div dir="ltr">

    - [Unit Testing - Important role in Software Development](https://medium.com/nonstopio/unit-testing-important-role-in-software-development-1f52f7c810f8)
    - [Why Is Unit Testing Important in Software Development?](https://performancelabus.com/unit-testing-importance/)
    - [The importance of Unit Testing](https://fortegrp.com/the-importance-of-unit-testing/)
    - [Time difference between developing with unit tests vs no tests](https://softwareengineering.stackexchange.com/questions/322256/time-difference-between-developing-with-unit-tests-vs-no-tests)

    </div>

1. مفهوم Code Coverage در Unit Testing و اهمیت آن:

    پس از مطالعه و درک مفهوم Unit Testing
    و اهمیت آن در توسعه‌ی نرم‌افزار، در مورد مفهوم Code Coverage
    و اهمیت آن مطالعه کنید. در این مرحله مطالعه‌ی لینک‌های زیر پیشنهاد می‌شود.

    <div dir="ltr">

    - [Code Coverage - Wikipedia](https://en.wikipedia.org/wiki/Code_coverage)
    - [5 Reasons You Should Care about Code Coverage](https://eldarion.com/blog/2017/07/13/5-reasons-you-should-care-about-code-coverage/)
    - [The Importance of Code Coverage](https://blog.cloudboost.io/the-importance-of-code-coverage-9b4d513f39b4)

    </div>

1. نوشتن Unit Test در جاوا:
    
    در این مرحله، در مورد نحوه‌ی نوشتن تست در زبان جاوا و با استفاده از کتابخانه `JUnit`
    مطالعه کنید. برای شروع کار با این کتابخانه، پیشنهاد می‌شود [Getting started with junit](https://riptutorial.com/junit)
    را مطالعه کنید. همچنین نحوه‌ی مشاهده‌ی code coverage
    را از
    [اینجا](https://www.jetbrains.com/help/idea/running-test-with-coverage.html)
    می‌توانید بخوانید.

1. اصول SOLID:

    یکی از مهم‌ترین مجموعه اصول در مهندسی نرم‌افزار، اصول پنج‌گانهٔ SOLID می‌باشد.
    این اصول عبارت‌اند از:

    <div dir="ltr">

    1. **S**ingle Responsibility
    1. **O**pen for Extension/Closed for Modification
    1. **L**iskov Substitution
    1. **I**nterface Segregation
    1. **D**ependency Inversion

    </div>

    در مورد هر یک از این اصول مطالعه کنید. همچنین می‌توانید از لینک‌های زیر نیز کمک بگیرید:

    <div dir="ltr">

    - [SOLID Principles in Java Application Development](https://www.jrebel.com/blog/solid-principles-in-java)
    - [S.O.L.I.D principles in Java](https://medium.com/@karthikcsridhar/s-o-l-i-d-principles-in-java-1aaff453d7ea)

    </div>

1. تاثیر اصول SOLID بر Unit Tesing:

    در این مرحله، درمورد تاثیر رعایت اصول SOLID
    بر تست‌نویسی مطالعه کنید. در این مرحله می‌توانید از لینک زیر کمک بگیرید:

    <div dir="ltr">

    - [SOLID, Object Oriented Design and Unit Testing](https://huestones.co.uk/2015/06/solid-object-oriented-design-and-unit-testing/)

    </div>

1. آشنایی با Mock:

    Mock
    کردن، یک تکنیک تست‌نویسی است که در آن، قسمتی از کد را با یک پیاده‌سازی دلخواه جایگزین می‌کنیم و از آن برای شبیه‌سازی یک عملیات واقعی استفاده می‌شود. معمولا mock
    کردن زمانی استفاده می‌شود که یک متد یا کلاس، وابستگی یا وابستگی‌هایی دارد که در تست ما تداخل نامطلوبی ایجاد می‌کند.

    مثلا فرض کنید میخواهید سرویسی را تست کنید که در آن از یک `SmsSender`
    استفاده شده است. در نتیجه هر بار که آن تست را اجرا کنید، یک SMS
    نیز ارسال می‌شود، که این برای ما مطلوب نیست.

    در این صورت، باید `SmsSender`
    را mock
    کرد که دیگر SMS
    ارسال نکند، ولی همواره مثلا `true`
    برگرداند، به این معنی که ارسال با موفقیت انجام شده است. در نتیجه می‌توانیم functionality
    همان متد را تست کنیم، به جای این که بخواهیم درگیر وابستگی‌های آن نیز شویم. 

    در این مرحله، در مورد این مفهوم مطالعه کنید. می‌توانید از لینک‌های زیر کمک بگیرید:

    <div dir="ltr">

    - [What is a mock and when should you use it](https://stackoverflow.com/questions/214092/what-is-a-mock-and-when-should-you-use-it)
    - [Unit tests with Mockito - Tutorial](https://www.vogella.com/tutorials/Mockito/article.html)

    </div>

1. نوشتن تست برای الگوریتم جستجو:

    در این مرحله، با استفاده از دانشی که در این فاز به دست آورده‌اید، برای بخش‌های مختلف کد خود تست بنویسید. سعی کنید Code Coverage
    تست را به بالای ۹۵٪ برسانید.

    برای این کار یک برنچ با نام `feature/unit-test`
    بسازید و نوشتن تست را روی آن انجام دهید.




</div>
