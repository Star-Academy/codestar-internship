<div dir="rtl" align='justify'>

[لیست تسک‌های مرتبط با این فاز به صورت issue template](./issue-template-Phase05.md)

#  فاز پنج: TDD

در این فاز با مفاهیم Test-driven development
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

1. آشنایی بیشتر با اصول SOLID و تاثیر آن بر TDD:
    
    در این مرحله، فکر کنید که هر یک از اصول SOLID،
    چگونه می‌تواند بر ساده‌تر شدن روند TDD
    تاثیر بگذارد. با هم‌تیمی‌های خود در این مورد بحث کنید.

    در ادامه در مورد این موضوع مطالعه کنید. برای این مرحله می‌توانید از لینک‌های زیر استفاده کنید.

    <div dir="ltr">

    - [SOLID design principles make test-driven development (TDD) faster and easier](https://medium.com/ibm-garage/solid-design-principles-makes-test-driven-development-faster-and-easier-35c9eec22ff1)
    - [Does test-driven development force me to follow SOLID?](https://softwareengineering.stackexchange.com/a/111868)

    </div>

1. بازنویسی پروژهٔ سرچ با زبان C# و با رویکرد TDD:

    در این مرحله، پروژهٔ سرچ خود را که قبلاً جاوا نوشته‌اید را بعنوان یک library
    سرچ به زبان C#
    بازنویسی کنید. در بازنویسی خود به طور کامل رویکرد TDD
    را به کار ببرید و آموخته‌های خود از مرحلهٔ قبل را اعمال کنید. برای نوشتن تست در C#
    از XUnit
    استفاده کنید. درمورد نحوهٔ تست در کتابخانهٔ XUnit
    مطالعه کنید.

    همچنین مراحل زیر را برای ساختن پروژهٔ خود دنبال کنید.

    - ساختن solution:
    با استفاده از دستور زیر در command-line
    یک solution
    بسازید:

    <div dir="ltr">

    ```Bash
    dotnet new sln -o SampleLibrary
    cd .\SampleLibrary\
    ```

    </div>

    - ساختن یک پروژهٔ Class Library:
    در این مرحله یک پروژهٔ .Net Class Library
    بسازید. این نوع از پروژه، executable
    نمی‌باشد و صرفاً بعنوان یک کتابخانه در پروژهٔ های دیگر می‌تواند مورد استفاده قرار گیرد. سپس آن را به solution
    خود اضافه کنید:

    <div dir="ltr">

    ```Bash
    dotnet new classlib -o .\SampleLibrary
    dotnet sln add .\SampleLibrary\
    ```

    </div>

    - ساختن پروژه تست: در این مرحله یک پروژه تست با فریم‌ورک XUnit
    بسازید، آن را به solution
    اضافه کنید و همچنین یک رفرنس به پروژهٔ Class Library
    ای که قبلاً ساخته‌اید بدهید:

    <div dir="ltr">

    ```Bash
    dotnet new XUnit -o .\SampleLibrary.Test
    dotnet sln add .\SampleLibrary.Test\
    dotnet add .\SampleLibrary.Test\ reference .\SampleLibrary\
    ```

    </div>

    - تبریک! شما ساختار پروژهٔ خود را آماده کردید. حال می‌توانید شروع به کد زدن کنید. توجه کنید که کد پروژهٔ شما، در پروژهٔ Class Library
    ای که ساختید قرار می‌گیرد، و از طریق پروژهٔ تستی که ساختید، می‌توانید با دستور زیر تست‌های خود را اجرا کنید:

    <div dir="ltr">

    ```Bash
    dotnet test
    ```

    </div>



</div>
