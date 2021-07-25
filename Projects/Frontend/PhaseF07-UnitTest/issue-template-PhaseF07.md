<div dir="rtl" align='justify'>

[لیست تسک‌های مرتبط با این فاز به صورت issue template](./issue-template-Phase03.md)

#  فاز سه: Unit Test

در این فاز با Unit Test،
مفهوم Code Coverage
و همچنین اصول SOLID
آشنا خواهید شد. در این فاز، برای کدی که در فازهای قبلی نوشته‌اید، تست می‌نویسید و با استفاده از مفاهیم Coverage
و اصول SOLID،
کیفیت کد خود را بیش از پیش افزایش می‌دهید.
## بخش اول: مفاهیم تست‌نویسی و اهمیت آن
1. Unit Test و اهمیت آن:

    در این مرحله در مورد اهمیت نوشتن Unit Test
    در توسعه نرم‌افزار مطالعه کنید. مطالعه‌ی لینک‌های زیر پیشنهاد می‌شود.

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
    را Mock
    کرد که دیگر SMS
    ارسال نکند، ولی همواره مثلا `true`
    برگرداند، به این معنی که ارسال با موفقیت انجام شده است. در نتیجه می‌توانیم Functionality
    همان متد را تست کنیم، به جای این که بخواهیم درگیر وابستگی‌های آن نیز شویم. 

    در این مرحله، در مورد این مفهوم مطالعه کنید. می‌توانید از لینک‌های زیر کمک بگیرید:

    <div dir="ltr">

    - [What is a mock and when should you use it](https://stackoverflow.com/questions/214092/what-is-a-mock-and-when-should-you-use-it)

    </div>
1. آشنایی با مفهوم TDD:

    در این قسمت با مفاهیم Test-driven development
    آشنا خواهید شد و در اصول SOLID
    نیز عمیق‌تر می‌شوید.

    1. آشنایی با TDD:

        در این مرحله، در مورد مفهوم TDD
        و مراحل آن مطالعه کنید. برای این مرحله مطالعهٔ لینک‌های زیر پیشنهاد می‌شود.

        <div dir="ltr">

        - [Testing Software: What is TDD?](https://medium.com/javascript-scene/testing-software-what-is-tdd-459b2145405c)
        - [Test Driven Development (TDD): The Advantages and Disadvantages](https://medium.com/@stevenpcurtis.sc/test-driven-development-tdd-the-advantages-and-disadvantages-5347899ead90)
        - [Introduction to Test Driven Development (TDD)](https://medium.com/hackernoon/introduction-to-test-driven-development-tdd-61a13bc92d92)

        </div>

    1. تاثیر اصول SOLID بر TDD:
        
        در این مرحله، فکر کنید که هر یک از اصول SOLID،
        چگونه می‌تواند بر ساده‌تر شدن روند TDD
        تاثیر بگذارد. با هم‌تیمی خود در این مورد بحث کنید.

        در ادامه در مورد این موضوع مطالعه کنید. برای این مرحله می‌توانید از لینک‌های زیر استفاده کنید.

        <div dir="ltr">

        - [SOLID design principles make test-driven development (TDD) faster and easier](https://medium.com/ibm-garage/solid-design-principles-makes-test-driven-development-faster-and-easier-35c9eec22ff1)
        - [Does test-driven development force me to follow SOLID?](https://softwareengineering.stackexchange.com/a/111868)

        </div>

## بخش دوم: آشنایی با Karma و Jasmine

</div>
