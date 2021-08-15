<div dir="rtl" align='justify'>

# OGMA JS

`OGMA` یک کتاب‌خانه جاوااسکریپت است که برای مصورسازی گراف به کار می‌رود. برای آشنایی با سایر کتاب‌خانه‌های موجود در این حوزه می‌توانید به [این صفحه](https://medium.com/@Elise_Deux/the-list-of-graph-visualization-libraries-7a7b89aab6a6) مراجعه کنید. در ادامه نحوه راه‌اندازی `OGMA` را بررسی می‌کنیم:


1. یک `div` با شناسه دلخواه در صفحه `html` بسازید تا بعدا آن را به عنوان `container` محیط نمایش گراف معرفی کنید. به طور مثال:

    <div dir="ltr">

    ```html
    <div id="graph-container"></div>
    ```
    </div>

1. فایل کتاب‌خانه `OGMA` را دانلود کنید و در پوشه پروژه قرار دهید تا بتوانید کلاس `OGMA` را از آن دریافت کنید. (فایل <a href="../Assets/Scripts/ogma.min.rar">ogma.min.js</a> در همین ریپو موجود است.)

1. در بالای صفحه تایپ اسکریپت `OGMA` را تعریف کنید:
    <div dir="ltr">
    
    ```js
    import * as Ogma from '../../assets/ogma.min.js';
    ```
    </div>

1. داخل تابع `ngOnInit` کامپوننت آبجکت `OGMA` را بسازید. (داخل [این فایل](../Assets/Scripts/ogma.example.ts) یک مثال آورده شده است.) برای مطالعه از داک اگما به [این صفحه](https://doc.linkurio.us/ogma/latest/quickstart.html) مراجعه کنید.

</div>
