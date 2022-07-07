<div dir="rtl">

# فاز چهار: آشنایی با مفاهیم مقدماتی JavaScript

## مقدمه

در این فاز قصد داریم با مفاهیم نسبتاً سادۀ **JavaScript** آشنا شویم.

- چرا برای تعریف متغیر از سه عبارت `var` و `let` و `const` می‌توان استفاده کرد؟
- تفاوت **Function** معمولی با **Arrow Function** چیست؟
- مفهوم و کاربرد `this` چیست؟
- **DOM** و راهکارهای مختلف برای اتصال و ایجاد تغییر در آن چه چیزهایی هستند؟

در پایان این فاز امیدواریم بتوانیم به ابهاماتی مانند سوالات بالا پاسخ دهیم.

---

## یادگیری

### Variables

قبل از سال 2015 میلادی، برای تعریف متغیر در JavaScript تنها می‌توانستیم از var استفاده کنیم.
اما با معرفی ES6 عبارت‌های let و const نیز به این زبان اضافه شدند که در اینجا توضیحات مختصری در مورد هر کدام ارائه می‌کنیم.

#### var

زمانی که یک متغیر را با عبارت var تعریف می‌کنید،
آن متغیر در Global Scope یا نزدیک‌ترین Function Scope تعریف می‌شود.

به عنون مثال خروجی کد زیر:

<div dir="ltr">

```javascript
function defineAndPrintName() {
  if (true) {
    var name = "Bijan";
    console.log(`inner scope -> name: ${name}`);
  }

  console.log(`outer scope -> name: ${name}`);
}

defineAndPrintName();
```

</div>

به شکل زیر خواهد بود:

<div dir="ltr">

```text
inner scope -> name: Bijan
outer scope -> name: Bijan
```

</div>

چرا که متغیر name داخل scope تابع defineAndPrintName قرار می‌گیرد.

لازم به ذکر است که Scopeها در JavaScript با آکلاد مشخص می‌شوند
بنابراین نیازی به `if (true)` نداریم.

#### let

برخلاف var، زمانی که از let برای تعریف یک متغیر استفاده کنیم،
آن متغیر در Scope فعلی محدود می‌شود.

به عنوان مثال خروجی کد زیر:

<div dir="ltr">

```javascript
function defineAndPrintName() {
  {
    let name = "Bijan";
    console.log(`inner scope -> name: ${name}`);
  }

  console.log(`outer scope -> name: ${name}`);
}

defineAndPrintName();
```

</div>

به شکل زیر خواهد بود:

<div dir="ltr">

```text
inner scope -> name: Bijan
ReferenceError: name is not defined
```

</div>

#### const

دقیقاً مانند let عمل می‌کند با این تفاوت که فقط یک بار می‌توان مقدار آن را set کرد.

برای آشنایی بیشتر با این مفهوم می‌توانید از لینک‌های زیر استفاده کنید:

<div dir="ltr">

- [var vs let vs const in JavaScript](https://ui.dev/var-let-const/)
- [Difference Between Var, Let and Const in ES6](https://medium.com/infancyit/difference-between-var-let-and-const-in-es6-16a08d74b8b2)
- [Var, Let, and Const – What's the Difference?](https://www.freecodecamp.org/news/var-let-and-const-whats-the-difference/)

</div>

---

### Regular Function vs Arrow Function

در JavaScript به دو شکل می‌توان یک تابع را تعریف کرد:

<div dir="ltr">

```javascript
function sayHello(name) {
  console.log(`hello, ${name}!`);
}

// or

const sayHello = (name) => {
  console.log(`hello, ${name}!`);
};
```

</div>

که به نوع اول Regular Function و به نوع دوم Arrow Function گفته می‌شود
که از این پس اولی را با عنوان RF و دومی را با عنوان AF ذکر می‌کنیم.
در اینجا به تفاوت این دو روش می‌پردازدیم.

#### this

زمانی که از RF استفاده می‌کنیم مقدار this با توجه به مکانی که تابع از آنجا صدا زده شده متفاوت است.
اما اگر از AF استفاده کنیم، همواره برابر با شیئی است که تابع در آن تعریف شده.

<div dir="ltr">

```javascript
const rfWrapper = {
  whatIsThis: function () {
    console.log(this); // rfWrapper
  },
};

const afWrapper = {
  whatIsThis: () => {
    console.log(this); // globalThis
  },
};

rfWrapper.whatIsThis();
afWrapper.whatIsThis();
```

</div>

#### Constructor

قبل از اینکه کلاس‌ها به JavaScript بیایند، از RF به عنوان Constructor استفاده می‌شد.
منتهی از آنجایی که در AF مقدار this همواره ثابت است، نمی‌توانیم این قابلیت را برایش داشته باشیم.

<div dir="ltr">

```javascript
function Circle(radius) {
  this.radius = radius;

  this.printSurface = function () {
    console.log("surface", Math.PI * Math.pow(this.radius, 2));
  };
}

const small = new Circle(10);
const large = new Circle(100);

small.printSurface();
large.printSurface();
```

</div>

#### arguments & args

در RF یک کلیدواژه به نام arguments وجود دارد که درواقع آرایه‌ای از پارامترهای ورودی می‌باشد.
در AF هم می‌توانیم به این پارامترها دسترسی داشته باشیم منتهی باید صراحتاً در ورودی‌های تابع به آن اشاره کنیم.

<div dir="ltr">

```javascript
function rfSum() {
  let result = 0;

  for (const n of arguments) {
    if (!isNaN(n)) result += n;
  }

  return result;
}

const afSum = (...args) => {
  let result = 0;

  for (const n of args) {
    if (!isNaN(n)) result += n;
  }

  return result;
};

console.log("RF", rfSum(4, 8, 15, 16, 23, 42)); // 108
console.log("AF", afSum(4, 8, 15, 16, 23, 42)); // 108
```

</div>

#### return

در AF اگر بدنۀ تابع فقط شامل یک Expression باشد، می‌توان آن را بدونِ استفاده از آکلاد و return نوشت.

<div dir="ltr">

```javascript
const rand = (min, max) => Math.floor(Math.random() * (max - min) + min);

console.log(rand(4, 42));
```

</div>

برای آشنایی بیشتر با این مفهوم می‌توانید از لینک‌های زیر استفاده کنید:

<div dir="ltr">

- [5 Differences Between Arrow and Regular Functions](https://dmitripavlutin.com/differences-between-arrow-and-regular-functions/)
- [When (and why) you should use ES6 arrow functions — and when you shouldn’t](https://www.freecodecamp.org/news/when-and-why-you-should-use-es6-arrow-functions-and-when-you-shouldnt-3d851d7f0b26/)

</div>

---

## پروژه

با استفاده از مفاهیمی که از JavaScript یاد گرفتید سعی کنید بخشی از منطق سایت را پیاده‌سازی کنید.

از آنجایی که هنوز با مفاهیم ارتباط با سرور آشنا نشده‌اید، انتظار نمی‌رود مسائلی مانند Signup و Login را انجام دهید.
اما در فازهای آینده به این مسائل خواهیم پرداخت.

</div>
