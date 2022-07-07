<div dir="rtl">

# فاز سه: آشنایی با SCSS

## مقدمه

**SCSS** یک **Preprocessor** برای **CSS** است که با استفاده از آن کار توسعه‌دهنده به شدت آسان می‌شود.
در این فاز قصد داریم با قابلیت‌های معروف **SCSS** و کاربرد هر یک از آن‌ها آشنا شویم.

در اینجا تنها به بخشی از این قابلیت‌ها اشاره می‌شود
بنابراین توصیه می‌کنیم برای یادگیری کامل **SCSS** به
[وبسایت رسمی آن](https://sass-lang.com/documentation)
مراجعه کنید.

---

##نصب

### Node.js

برای استفاده از SCSS باید اول Node.js را بر روی سیستم خود نصب کنید.
پس به
[این لینک](https://nodejs.org/)
مراجعه کنید.

ما پیشنهاد می‌کنیم نسخۀ LTS را دانلود و نصب کنید.

### npm

با نصبِ Node.js پکیج‌منیجیر آن یعنی npm نیز بر روی سیستم شما نصب خواهد شد
که ما از آن برای نصب SCSS استفاده خواهیم کرد.

### SASS

SASS به نوعی ورژن قبلی SCSS محسوب می‌شود که همچنان برخی از آن استفاده می‌کنند.
تفاوت اصلی SASS و SCSS در syntax آن‌هاست.
به عنوان مثال SASS مانند پایتون از indent برای scopeها استفاده می‌کند
اما SCSS مانند CSS از همان آکلاد.

پیشنهاد ما همان SCSS است اما اسم پکیجی که با استفاده از npm باید نصب کنیم sass می‌باشد.
برای نصب این پکیج در Terminal یا CMD دستور زیر را وارد کنید:

<div dir="ltr">

```shell
npm i -g sass
```

</div>

با اجرای این دستور، پکیج sass به صورت global در سیستم شما نصب می‌شود.
یعنی در هر فولدری که باشید می‌توانید از طریق Terminal از sass استفاده کنید.

---

## یادگیری

### Nested Selectors

شاید بتوان گفت Nested Selection معروف‌ترین و پُراستفاده‌ترین مزیت SCSS نسبت به CSS است.
برای توضیح این قابلیت به مثال زیر توجه کنید.

فرض کنید ساختار فایل html ما به شکل زیر باشد:

<div dir="ltr">

```html
<body>
  <header>
    <a href="/">Logo</a>

    <nav>
      <ul>
        <li><a href="#">Home</a></li>
        <li><a href="#">Products</a></li>
        <li><a href="#">About Us</a></li>
        <li><a href="#">Contact Us</a></li>
      </ul>
    </nav>

    <button>SIGNUP</button>
  </header>
</body>
```

</div>

و style زیر را با استفاده از CSS برای آن در نظر گرفته باشیم:

<div dir="ltr">

```css
body {
  display: grid;
  grid-template-areas: "header header" "main aside" "footer footer";
  grid-template-columns: minmax(0, 1fr) auto;
  grid-template-rows: auto minmax(0, 1fr) auto;
}

header {
  grid-area: header;

  display: flex;
  align-items: center;
  justify-content: space-between;
}

header > a {
  color: hsl(220, 100%, 55%);
}

header > ul {
  display: flex;
  align-items: center;
  justify-content: center;
  gap: 1rem;

  list-style: none;
}

header > ul > li > a {
  padding: 0.5rem 1rem;

  border-radius: 999rem;

  text-decoration: none;
}

header > ul > li > a:hover {
  background-color: hsl(221, 100%, 93%);
}
```

</div>

همان‌طور که می‌بینید هر چقد المانی که می‌خواهیم انتخاب کنیم
در جایگاه عمیق‌تری از ساختار html باشد،
selectorهایی مانند header و ul نیز باید تکرار شوند.
در صورتی که اگر بخواهیم از SCSS استفاده کنیم می‌توانیم کد بالا را به شکل زیر کوتاه کنیم:

<div dir="ltr">

```scss
body {
  display: grid;
  grid-template-areas: "header header" "main aside" "footer footer";
  grid-template-columns: minmax(0, 1fr) auto;
  grid-template-rows: auto minmax(0, 1fr) auto;

  header {
    grid-area: header;

    display: flex;
    align-items: center;
    justify-content: space-between;

    > a {
      color: hsl(220, 100%, 55%);
    }

    > ul {
      display: flex;
      align-items: center;
      justify-content: center;
      gap: 1rem;

      list-style: none;

      li {
        > a {
          padding: 0.5rem 1rem;

          border-radius: 999rem;

          text-decoration: none;

          &:hover {
            background-color: hsl(221, 100%, 93%);
          }
        }
      }
    }
  }
}
```

</div>

کد جدید نه تنها نسبت به کد قبلی از لحاظ تعداد خط و تعداد کاراکتر تکراری بهینه‌تر است،
بلکه از لحاظ خوانایی و دیداری نیز در فهم کد بیشتر به ما کمک می‌کند.

احتمالاً متوجه علامت & در کد بالا شده‌اید. این علامت selector پدر را عیناً کپی می‌کند.
به عنوان مثال کد زیر:

<div dir="ltr">

```scss
a {
  text-decoration: none;

  &.some-class-name {
    color: cornflowerblue;

    &:hover {
      color: orangered;
    }
  }
}
```

</div>

به این کد:

<div dir="ltr">

```css
a {
  text-decoration: none;
}

a.some-class-name {
  color: cornflowerblue;
}

a.some-class-name:hover {
  color: orangered;
}
```

</div>

تبدیل می‌شود.

---

### Variables

در SCSS هم مانند CSS می‌توانیم متغیر داشته باشیم. متغیرهای SCSS به این شکل تعریف می‌شوند:

<div dir="ltr">

```scss
$color-primary: hsl(220, 100%, 55%);
$padding--large: 4rem;
```

</div>

البته متغیرهای SCSS با متغیرهای CSS تفاوت‌های اساسی دارند:

- مقادیر اختصاص داده شده به متغیرهای SCSS در زمان Compile جایگزین می‌شوند در صورتی که متغیرهای CSS به همان شکل در کد نهایی استفاده می‌شوند.
- متغیرهای CSS برای المان‌های مختلف می‌توانند دارای مقادیر متفاوت باشند اما متغیرهای SCSS در آنِ واحد تنها یک مقدار دارند.
- مقادیر متغیرهای SCSS به صورت قطعی در نظر گرفته می‌شوند به طوری که اگر از متغیر در جایی از کد استفاده کنید و در جای دیگر مقدار آن را عوض کنید، مقدار جدید جایگزین مقدار قبلی نخواهد شد.

---

### Mixins

زمانی که قطعه‌ای از کد را بخواهیم در مکان‌های مختلف استفاده کنیم می‌توانیم از Mixinها کمک بگیریم.

به عنوان مثال فرض کنید در دو جا بخواهیم یک Layout با سه ستون هم‌عرض داشته باشیم.
برای این کار قطعه کد زیر را می‌نویسیم:

<div dir="ltr">

```scss
.products {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
}

.items {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
}
```

</div>

همان‌طور که می‌بینید قطعه‌ای از کد عیناً تکرار شده است.
می‌توانیم کد بالا را به شکل زیر بازنویسی کنیم:

<div dir="ltr">

```scss
@mixin layout-with-3-equal-columns {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
}

.products {
  @include layout-with-3-equal-columns;
}

.items {
  @include layout-with-3-equal-columns;
}
```

</div>

البته Mixinها مانند توابع می‌توانند پارامتر ورودی دریافت و با توجه به آن‌ها کد مورد نظر را تولید کنند:

<div dir="ltr">

```scss
@mixin layout-with-n-equal-columns($n: 3) {
  display: grid;
  grid-template-columns: repeat(#{$n}, 1fr);
}

.products {
  @include layout-with-n-equal-columns;
}

.items {
  @include layout-with-n-equal-columns(4);
}
```

</div>

همان‌طور که در بالا می‌بینید، Mixin ما یک متغیر به نام n را از ورودی دریافت می‌کند
و با توجه به مقدار آن تعداد ستون‌ها را تشکیل می‌دهد.
همچنین برای متغیر n مقدار پیشفرض 3 را در نظر گرفته‌ایم.

دقت کنید که از سینتکسِ
`#{}`
برای درجِ مقدار n استفاده کردیم
که به آن Interpolation گفته می‌شود.

---

## پروژه

با استفاده از SCSS ساختار HTML که در فاز یک طراحی کردید را Style دهید.

سعی کنید از تمام قابلیت‌های SCSS به نفع خود استفاده کنید؛
با استفاده از Nesting خوانایی کد را افزایش و
با استفاده از Mixin حجم آن را کاهش دهید.

</div>
