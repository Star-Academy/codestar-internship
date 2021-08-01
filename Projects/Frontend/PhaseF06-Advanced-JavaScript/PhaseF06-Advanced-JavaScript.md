<div dir="rtl">

# فاز شش: آشنایی با جاوا اسکریپت پیشرفته

  ## مقدمه
  
  تا اینجای کار، با مفاهیم ابتدایی Java Script آشنا شدید. در این فاز می‌خواهیم مباحث پیشرفته‌تر Java Script را یاد بگیریم تا در انتهای فاز بتوانید پروژه‌هایتان را به   `API` آهنگ‌ها متصل کنید و با سرور در ارتباط باشید. 

---
  ## یادگیری
  
  ### حافظه و Storage
   در این بخش می‌خواهیم به انواع حافظه در صفحه‌های وب بپردازیم. 
به پروژه اسپاتیفای خود فکر کنید! حتما برایتان سوال پیش آمده که اطلاعات کاربرانی که وارد سامانه می‌شوند چطور در سرتاسر برنامه ذخیره شود؟ چطور اطلاعات کاربران را در طول زمانی که در برنامه هستند نگه داریم و از آن‌ها استفاده کنیم؟ چگونه سلیقه کاربران را به خاطر بسپاریم تا آهنگ‌های مناسب را به آن ها پیشنهاد دهیم؟
برای این کار‌ها، از مفاهیمی به نام حافظه در وب استفاده می‌کنیم. حافظه‌ها می‌توانند انواع مختلفی داشته باشند. از معروف‌ترین آن‌ها یعنی `cookie`  ها شروع می‌کنیم!
  #### Cookie
  کوکی‌ها می‌توانند به دو صورت استفاده شوند: 
-	سمت سرور (HTTP Cookie): با این کاری نداریم!
-	با جاوا اسکریپت و استفاده از `document.cookie`
  
برای ذخیره‌ی مقدار جدید کوکی، تنها کافی است `document.cookie` را مقدار‌دهی کنیم. توجه داشته باشید که مقادیر `document.cookie`  تنها مختص به همان صفحه هستند و در صورتی که به صفحه‌ی دیگری از وب برویم، دیگر نمی‌توانند مورد استفاده قرار بگیرند. یعنی مقدار کوکی‌های `http://example.com` قابل استفاده در `http://example.com/foo` نیست. 
<div dir="ltr">
  
  ```javascript
  document.cookies = "username=codestar; password=1234; expires=Wed, 25 Aug 2021 21:08:53 GMT; path=/link.html"
  ```
  
  </div>
  
  
  مقدار `expires`  مشخص می‌کند که کوکی‌ها چه زمانی منقضی شوند. در صورتی که بخواهیم مقدار کوکی‌های یک صفحه دیگر را عوض کنیم، از `path` استفاده می‌کنیم. در مثال بالا، در صورت خواندن مقدار `document.cookie` در `example.com/link.html`، مقدار <span dir="ltr"> `username=codestar;password=1234;` </span> را دریافت می‌کنیم. برای ست کردن کوکی‌ها در همین صفحه، مقدار `/=path` بگذارید. 
توجه داشته باشید که در کوکی‌ها تنها می‌توانیم مقادیر `string` بخوانیم و بنویسیم.
  
  برای اطلاعات بیشتر درباره کوکی‌ها به لینک زیر مراجعه کنید:
  
  <div dir="ltr">
    
   - [Web APIs, Document.cookie](https://developer.mozilla.org/en-US/docs/Web/API/Document/cookie/)
    
  </div>
  
  مشکلی که با کوکی‌ها وجود داشت، مقدار حافظه‌ی کم آن‌ها (حداکثر 4 کیلوبایت) بود. در نتیجه   `session storage` و `local storage` معرفی شدند. بر‌خلاف کوکی‌ها، در این دو نوع از حافظه از ذخیره‌سازی `key, value` استفاده می‌شود. (مانند دیکشنری).
  
  #### Session storage
  
 Session storage نوع دیگری از حافظه در وب است. زمانی که پنجره و تب بسته می شود، اطلاعاتی هم که توسط session storage  ذخیره شده هم پاک می شود. همچنین توجه داشته باشید که اطلاعات تب‌های دیگر در session storage قابل استفاده نیست. 
  
  به مثال زیر توجه کنید:
  <div dir="ltr">
  
  ```javascript
  
    function getSession () {
      let x = document.getElementById("sessionShow");
      x.innerText = sessionStorage.getItem("username");
    }
    function setSession() {
      sessionStorage.setItem("username", "codestar");
    }

  ```
  ```html
    <div id="sessionShow"></div>
    <button onclick="getSession()">get</button>
    <button onclick="setSession()">set</button>

  ```
  <div>
  <div dir="rtl">
    
در این مثال دکمه‌ی `set`، مقدار `session storage` را ست می‌کند. در صورتی که صفحه را رفرش کنیم و `get` را بزنیم، مقدار ذخیره شده، نمایش داده می‌شود. 
    
برای اطلاعات بیشتر به لینک زیر رجوع کنید:
    
   </div>
    
- [Web APIs, Window.sessionStorage](https://developer.mozilla.org/en-US/docs/Web/API/Window/sessionStorage)
<div dir="rtl">
  
#### Local storage
  
  حافظه لوکال از بسیاری از جهات شبیه `session storage` است. با این تفاوت که بر‌خلاف `session storage`، با بستن تب از بین نمی‌رود و هیچ تاریخ انقضایی ندارد. 
ست کردن و گرفتن دیتا در `local storage` دقیقا مشابه `session storage` می‌باشد. 

  <div dir="ltr">
    
  ```javascript
    localstorage.setItem("country", "Iran");
    localstorage.remove(“counry”);
  ```
    
  </div>
  
   دستور `(key)remove` مقدار `key` , `value` مورد نظر را از حافظه لوکال پاک می‌کند. 
در صورتی که در http://example.com/foo مقدار `localstorage` را ست کردیم، در http://example.com/bar و یا هر جای دیگری می‌توانیم به آن اطلاعات دسترسی داشته باشیم.
  
برای خواندن درباره تفاوت حافظه‌ی کوکی و لوکال می‌توانید به لینک زیر مراجعه کنید:

  <span dir='ltr'>
    
  - [Cookies vs. LocalStorage: What’s the difference?](https://medium.com/swlh/cookies-vs-localstorage-whats-the-difference-d99f0eb09b44)
  </span>
  
  همچنین برای یادگیری مفصل‌تر این دو مبحث می‌توانید این لینک‌ها را بخوانید:
  
  <span dir="ltr">
    
  - [Web APIs, Window.localStorage](https://developer.mozilla.org/en-US/docs/Web/API/Window/localStorage)
  - [Using the Web Storage API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Storage_API/Using_the_Web_Storage_API)
    
  </span>
  
  ### JSON
  
  جیسون یا جیسان، یک فرمت سبک برای انتقال اطلاعات است. معمولا از `JSON` برای رد و بدل کردن اطلاعات بین سرور و صفحه‌ی وب استفاده می‌شود. 
برای یادگیری سینتکس و قواعد نوشتاری `JSON` به لینک‌های زیر مراجعه کنید:
 
  <span dir="ltr">
    
  - [JSON Syntax](https://www.w3schools.com/js/js_json_syntax.asp)
  - [JSON in 10 Minutes](https://www.youtube.com/watch?v=iiADhChRriM)
  
  </span>
  
  دو متد مهم برای استفاده از فرمت `JSON` در جاوا اسکریپت، `()JSON.parse` برای تبدیل یک رشته‌ی `JSON` به یک شی جاوا اسکریپتی و `()JSON.stringify` برای تبدیل یک شی جاوا اسکریپتی به رشته‌ی `JSON` هستند.
  
برای اطلاعات بیشتر درباره روش استفاده از این دو متد به لینک‌های زیر مراجعه کنید:
  
<span dir="ltr">
    
  - [JSON.parse](https://www.w3schools.com/js/js_json_parse.asp)
  - [JSON.stringify](https://www.w3schools.com/js/js_json_stringify.asp)
  
</span>
  
 قبل از این که سراغ بقیه‌ی مبحث برویم، مفاهیم `HTTP` و `Rest` را توضیح خواهیم داد.
  
 ### HTTP  چیست؟
  
  پروتکل `HTTP` مخفف عبارت `Hyper Text Transfer Protocol`  است و به ارتباط میان سرویس‌دهنده (server)  و سرویس‌گیرنده (client) در وب می‌پردازد.
ارتباط بین سیستم‌های سرویس‌گیرنده و سرورها از طریق ارسال درخواست‌های `HTTP` و دریافت پاسخ‌های `HTTP` انجام می‌شود. به زبان ساده‌تر، `HTTP`  یک نوع قانون است که ارسال و دریافت اطلاعات بین `client` و `server`  بر اساس آن انجام می‌شود.
برای آشنایی بهتر با `HTTP`  لینک‌های زیر می‌تواند به شما کمک کند.
 
<span dir="ltr">
    
- [An introduction to HTTP: everything you need to know](https://www.freecodecamp.org/news/http-and-everything-you-need-to-know-about-it/)
- [An overview of HTTP](https://developer.mozilla.org/en-US/docs/Web/HTTP/Overview)
    
</span>
  
### RESTful Api
  
  `Application Programming Interface`  که با رابط برنامه‌نویسی کاربردی ترجمه می‌شود یک مجموعه از قواعد و مکانیزم‌ها است که از طریق آن اپلیکیشن‌ها و یا کامپوننت‌های مختلف یک برنامه با همدیگر ارتباط برقرار می‌کنند. نام خود این مکانیزم بیانگر همه چیز است. منظور از رابط چیزی‌ست که دو شئ یا دو موجودیت مختلف را به همدیگر ربط می‌دهد. اما بیایید کمی با جزئیات بیشتر از این موضوع صحبت کنیم. API می‌تواند داده‌هایی که شما برای اپلیکیشن‌تان نیاز دارید را از طریق یک فرمت مناسب به خروجی بفرستد و یا آن‌ را برگشت دهد. فرمت `JSON` و `XML` از این دست فرمت‌ها هستند. در این مطلب ما قصد داریم روی `JSON` تمرکز بکنیم.

  برای آشنایی بیشتر با `RESTful api` مطالب زیر به شما کمک خواهد کرد.
  
 <span dir="ltr">
   
- [RESTful API به زبان ساده چیست؟](https://roocket.ir/articles/a-beginners-tutorial-for-understanding-restful-api)
- [What Is a REST API?](https://www.sitepoint.com/rest-api/)
   
  </span>
  
  </div>
    
  <div dir="rtl">
    
  ### غیر همزمانی‌ها در جاوا اسکریپت
  
  ممکن است زمانی پیش بیاید که در برنامه‌تان بخواهید در بخشی با استفاده از تابع `setTimeout`، مقداری صبر کنید و بعد از آن برنامه را ادامه دهید یا در مثال پروژه‌ی اسپاتیفای، شما لازم دارید که در ابتدای لود صفحه، اطلاعات آهنگ‌ها و خواننده‌ها را از `API` دریافت کنید و تا زمانی که این اطلاعات از `API` گرفته نشده‌اند، برنامه منتظر دریافت دیتا بماند.
    
کد زیر را در نظر بگیرید:

<span dir="ltr">
  
```javascript
    let text = 'text one;'
    let setDisplayTimeOut = () => {
      setTimeout(() => {
          text = 'text two';
      }, 1000);
      let output = document.getElementById("output");
      output.innerText = text;
    }
```
 </span>  
    
 طبق این کد، می‌خواهیم بعد از 1 ثانیه مقدار متغیر `text` عوض شود و `text two` در صفحه نمایش داده شود. اما در حالت عادی، جاوا اسکریپت مقدار نمایش داده شده را همان `text one` نشان می‌دهد.
 فرض کنید می‌خواهیم از سرور اطلاعات کاربران را دریافت کنیم و بعد از دریافت، تغییراتی را روی آن‌ها انجام بدهیم. اگر مانند مثال بالا، اطلاعات را دریافت کرده و تغییرات را انجام بدهیم، دچار خطا می‌شویم. زیرا روند دریافت اطلاعات کاربران کامل نشده. برنامه باید صبر کند تا دریافت اطلاعات کامل شود و بعد تغییرات را ایجاد کند.
    
در این شرایط است که `Promise` ها به کار ما می‌آیند!
    
#### Promise
`Promise` ها برای عملکرد‌های `asynchronous` مانند مثال‌های بالا به کار ما می‌آیند. با `promise` ما منتظر نتیجه می‌مانیم و با `()then` مشخص می‌کنیم که بعد از آن چه اتفاقی رخ بدهد. 
مثال بالا را با `Promise` بازنویسی می‌کنیم:

<span dir="ltr">
  
  ```javascript
  let text = 'text one;'
  const timePromise = new Promise((resolve, reject) => {
    setTimeout(() => {
        text = 'text two';
        if (text === 'text two') 
            resolve();
        else 
            reject('wrong data!');
    }, 5000);
    
  });

  const setText = () => {
    let output = document.getElementById("output");
    output.innerText = text;
  };

  function setDisplayTimeOut() {
    timePromise.then(setText)
    .catch((error) => {
        console.log(error);
     });
  }

  ```
  
</span>
    
در `Promise`، می‌توانید  `()resolve`و  `()reject`را بسته به موفقیت‌آمیز بودن و یا نبودن `Promise` صدا بزنید. در این تابع، در صورتی که مقدار `text`، برابر با `text two` باشد، Promise موفقیت‌آمیز بوده است و باید `()resolve` صدا شود و در غیر این صورت، موفقیت‌آمیز نبوده و `()reject` با پیغام مناسب باید صدا زده شود. 
تابع `()then`، دو تابع ورودی می‌گیرد اولی هندل‌کننده‌ی موفقیت‌آمیز بودن `Promise` و دومی هندل‌کننده‌ی موفقیت‌آمیز نبودن `Promise` است. به جای تابع دوم از `()catch.` هم می‌توان استفاده کرد.
    
مبحث `Promise` بسیار گسترده‌ست. برای اطلاعات بیشتر می‌توانید از لینک زیر استفاده کنید:


<span dir="ltr">
  
 - [Promise](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Promise)
 - [JavaScript Promises](https://www.w3schools.com/js/js_promise.asp)
  
</span>

 #### async, await
 در صورتی که پشت نام یک تابع `async` به کار رود، آن تابع یک `Promise` به عنوان خروجی برمی‌گرداند. `async`و `await` یک راه تمیز‌تر و ساده‌تر برای استفاده از `Promise` ها هستند. 
    
مسئله بالا را با استفاده از `async` و `await` حل می‌کنیم:

 <span dir="ltr">
   
   ```javascript
   let text = 'text one;'
   async function getTimePromise() {
    return new Promise((resolve) => {
        setTimeout(() => {
            text = 'text two';
            resolve();
        }, 5000);
      });
    }

  async function setText() {
    let output = document.getElementById("output");
    await getTimePromise();
    output.innerText = text;
  }

   ```
   
 </span>
    
ساختار بالا بسیار ساده است. با فراخوانی تابع `()setText`، منتظر می‌شویم تا نتیجه‌ی `()getTimePromise` برگردانده شود. بعد از آن که نتیجه موفقیت‌آمیز بود، مقدار خروجی را ست می‌کنیم. توجه داشته باشید در صورتی که در تابعی از `await` استفاده می‌شود، باید خود آن تابع هم `async` تعریف شود. مانند تابع `setText` که خودش `async` تعریف شده است.
    
در ادامه با `fetch`، کاربردهای بیشتری را می بینیم. 

#### fetch
    
`fetch Api` در جاوا اسکریپت برای ارسال درخواست به سمت سرور و لود کردن اطلاعات و جواب‌های سرور به کار می‌آید.
    
به کد زیر که برای گرفتن اطلاعات کاربران نوشته شده توجه کنید:

<span dir="ltr">
  
  ```javascript
  async function getData() {
    let response = await fetch('https://jsonplaceholder.typicode.com/users');
    if (response.ok) {
        let json = await response.json();
        let users = JSON.stringify(json);
        let output = document.getElementById('output');
        output.innerText = users;
    } else if (response.status == 500) {
        console.log("server error");
    }
  }

  ```
  
</span>
 
در حالت کلی، ورودی‌های تابع `url` ،`fetch`  و `option` هستند و خروجی آن یک `Promise` است. `option` پارامترهای دلخواهی است که در ارسال درخواست به سرور می‌توانیم در نظر بگیریم. به طور مثال تغییر متد ارسال، `header` و غیره. در صورتی که `option` به تابع پاس داده نشود، متد GET ساده در نظر گرفته می‌شود. 
در خط دوم برنامه‌ی بالا، با صدا زدن تابع `fetch`، منتظر نتیجه آن می‌مانیم و بعد از دریافت کامل اطلاعات، نتیجه در `response` ریخته می‌شود. 
با استفاده از `response` می‌توان نتیجه‌ی دریافت اطلاعات را مشاهده کرد. اگر `response.ok = true` باشد، یعنی دریافت اطلاعات به درستی انجام شده. `response.status` همان `Status code` این عملیات است. در صورتی که `Status code` برابر با 500 باشد، یعنی خطایی سمت سرور رخ داده. برای مشاهده لیست کامل `Status code` ها به لینک زیر مراجعه کنید:

<span dir="ltr">
  
  - [List of HTTP status codes](https://en.wikipedia.org/wiki/List_of_HTTP_status_codes)
  
<span>
  
</div>
  
<div dir="rtl">
  
برای دسترسی به `body` پاسخ این درخواست، یکسری توابع `async` دیگر با خروجی `Promise` وجود دارند. 
به طور مثال در کد بالا، `()response.json` یک تابع `async` برای برگرداندن یک `promise` با مقدار جیسونی اطلاعات است.
  
حتما توصیه می‌شود برای آشنایی کامل با توابع و کارایی `fetch`، به لینک زیر مراجعه کنید:

<span dir="ltr">
  
  - [Fetch](https://javascript.info/fetch)
  
<span>

<span dir="rtl">
  
برای جمع‌بندی مطالب `async` و  `promise` ، `fetch` می‌توانید به لینک زیر مراجعه کنید:
  
  </span>

<span dir="ltr">
  
 - [Async JS](https://www.youtube.com/watch?v=PoRJizFvM7s)
  
<span>

  </div>
  
<div dir="rtl"> 
  
  ### history
  
  شی `window.history`، نگهدارنده‌ی `history` مرورگر شما است. دو متد اصلی آن:

<span dir="ltr">
  
```
history.forward()
history.back()
```
  </span>
  
هستند. `()history.back` دقیقا مشابه کلیک کردن روی دکمه‌ی `back` در مرورگر و `()history.forward` مشابه کلیک کردن روی دکمه‌ی `forward` در مرورگر است.
از دیگر توابع آن، `(n)history.go` است. در صورتی که `n < 0` باشد، مرورگر `n` بار به عقب بر می‌گردد. بنابراین `()history.back` معادل `(-1)history.go` است. در صورتی که `n > 0` باشد، مرورگر n بار به جلو می‌رود و `()history.forward` معادل `(1)history.go` است.
  
برای دیدن جزئیات `history`، به لینک زیر رجوع کنید:

<span dir="ltr">
  
 - [History API](https://developer.mozilla.org/en-US/docs/Web/API/History_API)
  
<span>
  
</div>

<div dir="rtl">
    
### npm
در فاز سوم با `npm` کار کرده‌اید. `npm` یک `package manager` برای پکیج‌های java script است. 
با دستور 

<span dir="ltr">  
  
  ```
  npm init
  ```
  </span>
  
فایل `package.json` برای اپلیکیشن شما ساخته می‌شود. این فایل حاوی متادیتای اختصاصی پروژه همچون نام نویسنده، ایمیل، نام پروژه و اطلاعات مربوط به پکیج‌ها و اپلیکیشن‌هایی است که برنامه شما از آن استفاده می‌کند. 
در صورتی که فایل `package.json` در پروژه‌ای وجود داشته باشد، با دریافت پروژه و زدن 

<span dir="ltr">  
  
  ```
  npm install
  ```
</span>

تمام پکیج‌های مورد نیاز برنامه روی دستگاه شما نصب می‌شود. 
  
## پروژه
  
  
</div>
  
 
</div>
