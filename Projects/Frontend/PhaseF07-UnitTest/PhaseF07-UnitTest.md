<div dir="rtl" align='justify'>

[لیست تسک‌های مرتبط با این فاز به صورت issue template](./issue-template-PhaseF07.md)

# فاز هفتم: Unit Test

در این فاز با Unit Test،
مفهوم Code Coverage
و همچنین مفهوم TDD
آشنا خواهید شد. در این فاز، برای کدی که در فازهای قبلی نوشته‌اید، تست می‌نویسید و با استفاده از مفاهیم Coverage
و اصول تست نویسی،
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

karma ابزاری node-base است که میتوانید با استفاده از آن برای کدهای javascript
خود تست نویسی کنید. (node-base: ابزار هایی که برای اجرا به nodeJS نیاز دارند.)

پیشنهاد: برای شروع یادگیری تست نویسی پروژه‌ای جدای از پروژه spotify خود درست کنید و ابزار های karma و jasmine را در آن امتحان کنید و سعی کنید تمام مفاهیم آن را یک بار استفاده کنید و پس از آن سعی بر تست‌نویسی برای پروژه spotify کنید.

### ایجاد محیط یادگیری
1. یک پروژه‌ی جدید، با اجرای دستور زیر بسازید:
    <div dir="ltr">

    ```
    npm init -y
    ```

    </div>
1. حال karma را به پروژه خود اضافه کنید:
    <div dir="ltr">

    ```
    npm install karma@latest –save-dev
    ```

    </div>

1. در این مرحله برای آنکه بتوانید از command line برای اجرای ابزارهای karma استفاده کنیذ، آن را با استفاده از دستور زیر در سیستم خود نصب کنید:
    <div dir="ltr">

    ```
    npm install -g karma-cli
    ```
    </div>
1. حال باید تنظیمات مربوط به karma را انجام دهید. دستور زیر را در command line وارد کنید:
    <div dir="ltr">

    ```
    karma init
    ```
    </div>
    برای انجام تنظیمات مربوط به karma چند سوال پرسیده میشود که همه آنها را بررسی میکنیم:
    
    1. در ابتدا شما باید freamwork مورد نظر خود را که میخواهید با آن تست‌نویسی کنید را انتخاب کنید. در این آموزش ما از `jasmine` استفاده میکنیم.
    1. ما در این آموزش از فایل Required.js استفاده نخواهیم کرد پس گزینه `no` را انتخاب کنید. میتوانید در باره Required.js در [اینجا](https://requirejs.org/docs/start.html)(اختیاری) مطالعه کنید.
    1. زمانی که تست‌ها را اجرا میکنید خروجی در مرورگر نیز نمایش داده میشود. در این قسمت مرورگر پیش فرض خود را انتخاب کنید. پیشنهاد: `Chrome`
    1. در این قسمت باید مکان فایل های تست  و فایل‌های پروژه خود را انتخاب کنید. پیشنهاد:
        <div dir="ltr">

        ```
        > src/**/*.js
        > test/**/*.spec.js
        ```
        </div>
        
        فایل های پروژه خود را در پویشه src و فایل های تست خود را در پویشه test که دارای پسوند `spec.js` هستند نگه‌داری کنید.
        
    1. در این قسمت فایل هایی که نمیخواهید در karma استفاده کنید را انتخاب کنید.
    1. در آخرین سوالی که از شما پرسیده میشود باید مشخص کنید آیا مایل هستید درصورتی که فایل هایتان تغییر کرد، تست‌ها به صورت خودکار دوباره اجرا شوند یا خیر. گزینه `yes` را انتخاب نمایید.
    
    میتوانید برای کسب اطلاعات بیشتر درباره نصب و راه‌اندازی karma [این مستند](https://www.softwaretestinghelp.com/karma-test-runner-tutorial/) را مطالعه نمایید.

### اجرای نمونه تست
در این قسمت یک فایل `javascript` مینویسیم و برای آن تست طراحی میکنیم.
1. در ابتدا فایل `main.js` را در پوشه `src` ایجاد کنید و محتویات زیر در آن کپی نمایید:
    <div dir="ltr">

    ```
    var HelloCodeStar = function() {
        return 'Hello CodeStar';
    }
    ```
    </div>
1. فایلی به نام `main.spec.js` در پوشه `test` ایجاد کنید و محتویات زیر را درون آن کپی نمایید:
    <div dir="ltr">

    ```
    describe("hello code star", function() { 
        it("should Return Hello CodeStar",function() { 
            expect(HelloCodeStar()).toEqual('Hello CodeStar'); 
        }); 
    });
    ```
    </div>
1. در مرحله آخر با اجرای دستور زیر نتیجه تست را مشاهده نمایید:
    <div dir="ltr">

    ```
    karma start
    ```
    </div>
### ابزارهای تست نویسی
تا اینجا با مفاهیم تست‌نویسی آشنا شدید و پس از آن یک محیط توسعه برای آموزش تست نویسی ایجاد کردید. در ادامه میخواهیم با ابزارهای تست نویسی آشنا شویم و آنها را دقیق تر بررسی کنیم. در ابتدا درباره `Building Blocks of Test` مطالعه نمایید.

میتوانید [این مستند](https://www.tutorialspoint.com/jasminejs/jasminejs_building_blocks_of_test.htm) را مطالعه نمایید.

حالا که با `Suite Block` آشنا شدید درباره `Matchers` تحقیق نمایید.

میتوانید [این مستند](https://www.tutorialspoint.com/jasminejs/jasminejs_matchers.htm) را مطالعه نمایید.

انوع مختلف `Matcher` وجود دارد. میتوانید برای آشنایی بیشتر با آنها مجموعه سندهای زیر را مطالعه نمایید:

<div dir="ltr">

- [Equality Check](https://www.tutorialspoint.com/jasminejs/jasminejs_equality_check.htm)
- [Boolean Check](https://www.tutorialspoint.com/jasminejs/jasminejs_boolean_check.htm)
- [Sequential Check](https://www.tutorialspoint.com/jasminejs/jasminejs_sequential_check.htm)
- [Null Check](https://www.tutorialspoint.com/jasminejs/jasminejs_null_check.htm)
- [Inequality Check](https://www.tutorialspoint.com/jasminejs/jasminejs_inequality_check.htm)
- [Not a Number Check](https://www.tutorialspoint.com/jasminejs/jasminejs_not_number_check.htm)
- [Exception Check](https://www.tutorialspoint.com/jasminejs/jasminejs_exception_check.htm)
</div>


</div>
