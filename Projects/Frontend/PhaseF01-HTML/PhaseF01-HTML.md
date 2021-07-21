<div dir="rtl">

# فاز یک: آشنایی با مفاهیم HTML

##مقدمه

در این فاز قصد داریم با مفاهیم نسبتاً ساده اما فراموش‌شدۀ **HTML** آشنا شویم.
حتماً **Tag**هایی مانند `header`, `nav`, `main`, `aside`, `footer` و `section` یا **Attribute**هایی مانند `alt` و `type` را قبلاً دیده‌اید.

- تفاوت این تگ‌ها با یکدیگر در چیست؟
- چرا با وجود تگ `div` همچنان نیاز به این تگ‌ها بوده؟
- تگ‌های دیگری مانند `b` و `strong` چه تفاوتی با یکدیگر دارند؟
- با وجود **CSS** چه نیازی به این تگ‌ها وجود دارد؟

در پایان این فاز امیدواریم بتوانیم به ابهاماتی مانند سوالات بالا پاسخ دهیم.

توصیه می‌کنیم همزمان با خواندن این مطلب،
[صفحۀ دمو](https://star-academy.github.io/codestar-internship/Demos/Frontend/pages/Phase01-HTML/index.html)
را نیز مشاهده کنید تا به صورت دیداری و کاربردی با مفاهیم آشنا شوید.

##یادگیری

### Semantic Elements

در HTML تگ‌هایی وجود دارند که صرفاً برای یک کار خاص طراحی شده‌اند و با دیدن نام آن‌ها می‌توان کاربردشان را متوجه شد.
به این تگ‌ها، **تگ‌های معنایی** گفته می‌شود که لیستی از آن‌ها را به همراه توضیحات مختصری در اینجا مشاهده می‌کنید:

- [header](https://star-academy.github.io/codestar-internship/Demos/Frontend/pages/Phase01-HTML/index.html#header)
  - معمولاً در بالاترین بخش صفحه یا المان مورد نظر قرار می‌گیرد و در اکثر مواقع شامل لوگو، nav و دکمه‌های Call-to-Action می‌باشد.
- [nav](https://star-academy.github.io/codestar-internship/Demos/Frontend/pages/Phase01-HTML/index.html#nav)
  - شامل لینک‌هایی به قسمت‌های مختلف صفحۀ اصلی یا سایت می‌باشد.
- [main](https://star-academy.github.io/codestar-internship/Demos/Frontend/pages/Phase01-HTML/index.html#main)
  - شامل محتوای اصلی سایت می‌باشد و در اکثر موقع بیشترین حجم از صفحه را اشغال می‌کند.
- [aside](https://star-academy.github.io/codestar-internship/Demos/Frontend/pages/Phase01-HTML/index.html#aside)
  - شامل محتوایی غیر از محتوای اصلی می‌باشد به طوری که نمی‌توان آن را در main قرار داد.
- [footer](https://star-academy.github.io/codestar-internship/Demos/Frontend/pages/Phase01-HTML/index.html#footer)
  - معمولاً در پایین‌ترین بخش صفحه یا المان مورد نظر قرار می‌گیرد و در اکثر مواقع شامل Copyright، توضیحات مختصری در مورد سایت و شخص/گروه سازنده می‌باشد.
  
- [article](https://star-academy.github.io/codestar-internship/Demos/Frontend/pages/Phase01-HTML/index.html#article)
  - بخشی از محتواست که کاملاً از بخش‌های دیگر مستقل می‌باشد به گونه‌ای که می‌توان آن را به طور جداگانه استفاده یا منتشر کرد. به عنوان مثال می‌توان به مقاله‌ای از یک مجله یا پستی از یک وبلاگ اشاره کرد.
- [section](https://star-academy.github.io/codestar-internship/Demos/Frontend/pages/Phase01-HTML/index.html#results)
  - بخشی از محتوای اصلی سایت را مشخص می‌کند. معمولاً از این تگ برای ایجاد تمایز بینِ قسمت‌های مختلف استفاده می‌شود. معمولاً در ابتدای هر بخش از heading یعنی تگ‌های h1 تا h6 استفاده می‌شود.
- [details](https://star-academy.github.io/codestar-internship/Demos/Frontend/pages/Phase01-HTML/index.html#details)
  - شامل بخشی از محتواست که کاربر می‌تواند در صورت نیاز آن را show یا hide کند.
- [summary](https://star-academy.github.io/codestar-internship/Demos/Frontend/pages/Phase01-HTML/index.html#summary)
  - همواره داخل المان details استفاده می‌شود و باید شامل توضیحاتی دربارۀ آن باشد.

البته موارد بالا تنها بخشی از تگ‌های معنایی HTML می‌باشند. برای آشنایی بیشتر با این مفهوم می‌توانید از لینک‌های زیر استفاده کنید:

<div dir="ltr">

- [HTML Elements Reference](https://developer.mozilla.org/en-US/docs/Web/HTML/Element)
- [HTML Semantic Elements](https://www.w3schools.com/html/html5_semantic_elements.asp)
- [What On Earth Is Semantic Markup?](https://html.com/semantic-markup/)
- [A Friendly Tutorial For Developing Meaningful Web Pages](https://internetingishard.netlify.app/html-and-css/semantic-html/index.html)
- [Semantic HTML5 Elements Explained](https://www.freecodecamp.org/news/semantic-html5-elements/)

</div>

### Text Formatting Elements

بعضی از تگ‌ها مانند b و i برای تغییر ظاهر بخشی از متن استفاده می‌شوند که لیست آن‌ها را اینجا ذکر می‌کنیم:

- b & strong
  - عبارت مورد نظر را به صورت bold یا پُررنگ نمایش می‌دهد.
- i & em
  - عبارت مورد نظر را به صورت italic یا کج نمایش می‌دهد.
- mark
  - برای highlight کردن بخشی از نوشته مورد استفاده قرار می‌گیرد.
- small
  - عبارت مورد نظر را با اندازۀ کوچکتری نسبت به اندازۀ اصلی نمایش می‌دهد.
- del
  - برای نوشته‌های حذف‌شده استفاده می‌شود به طوری که معمولاً آن‌ها را به صورت خط‌خورده نمایش می‌دهد.
- ins
  - برای نوشته‌های اضافه‌شده استفاده می‌شود به طوری که معمولاً آن‌ها را یا underline نمایش می‌دهد.
- sub
  - معمولاً برای نمایش اندیس‌ها در پایینِ عبارت مورد استفاده قرار می‌گیرد.
- sup
  - معمولاً برای نمایش شماره‌های پاورقی در بالای عبارت مورد استفاده قرار می‌گیرد.

اما تمامِ این styleها را با استفاده از css نیز می‌توانیم داشته باشیم؛ پس علت وجود این تگ‌ها چیست؟ چرا برای بعضی از استایل‌ها مانند bold، دو تگ متفاوت داریم؟

کاربرد اصلی این تگ‌ها برای استفادۀ سریع هنگام نوشتن محتوای سایت است.
به عنوان مثال هر وقت خواستیم یک کلمه را bold کنیم
به جای اینکه از span در html و class در css استفاده کنیم،
می‌توانیم از b یا strong در html استفاده کنیم، بدونِ آنکه نیاز باشد تغییری در کد css دهیم.

از طرفی در صورت نیاز می‌توانید این تگ‌ها را مانند هر تگ دیگری style دهید.
یعنی مثلاً به جای اینکه یک کلاس به اسم bold درست کنید و هر بار مجبور باشید در html از آن استفاده کنید،
می‌توانید صرفاً تگ b را استعمال کنید و در css فرمت دلخواه را اعمال کنید.

تگ‌های b و strong در ظاهر تفاوتی باهم ندارند. اما زمانی که شما از strong استفاده کنید،
علاوه بر اینکه عبارت مورد نظر به شکل bold نمایش داده می‌شود، اگر کاربر از Screen Reader استفاده کند،
نرم‌افزار به این موضوع اشاره خواهد کرد.
به طور کلی زمانی که صرفاً بخواهید ظاهر کلمه پُررنگ باشد از b و
زمانی که بخواهید مفهوم کلمه پُررنگ باشد از strong استفاده کنید.

همچنین در مورد تگ‌های i و em، اگر از em استفاده کنید،
نرم‌افزار آن عبارت را با استرس بیشتری می‌خواند.

برای آشنایی بیشتر با این مفهوم می‌توانید از لینک زیر استفاده کنید:

<div dir="ltr">

- [HTML Text Formatting](https://www.w3schools.com/html/html_formatting.asp)

</div>

### Images

حتما با alt در تگ img آشنا هستید. حتی شاید زمانی که از آن استفاده نکردید، متوجه هشدار IDE شده باشید.
اما کاربرد این attribute چیست؟
زمانی که از عکس استفاده می‌کنیم چرا باید توضیحی برای بنویسیم؟
مقدار این attribute به کاربر نشان داده نمی‌شود، پس نوشتن آن چه فایده‌ای دارد؟



##تمرین

</div>
