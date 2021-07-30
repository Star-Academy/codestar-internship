<div dir="rtl">

# فاز پنج: Best Practices

## مقدمه

در این فاز قصد داریم با بهترین روش‌های توسعۀ فرانت‌اند آشنا شویم.

- کد تمیز چه ویژگی‌هایی دارد؟
- تفاوت UI و UX چیست؟
- کدام رنگ‌ها هم‌نشینی بهتری با یکدیگر دارند؟
- چه فونت‌هایی برای استفاده در سایت پیشنهاد می‌شوند؟

در پایان این فاز امیدواریم بتوانیم به ابهاماتی مانند سوالات بالا پاسخ دهیم.

---

## یادگیری

### Clean Code

#### چرا؟

قبل از شروع، حدود نیم ساعت تا یک ساعت در مورد دو سوال زیر فکر کنید و با هم تیمی خود بحث کنید. بعد از پایان بحث
برای هر سوال سه دلیلی را که فکر می‌کنید از بقیه مهم‌تر هستند در Issueی خودتان بنویسید.

- چرا تمیز بودن کد و داشتن معماری خوب مهم است و چرا باید وقت و انرژی زیادی صرف طراحی و نوشتن کد تمیز شود؟
- چرا این موضوع در صنعت، بسیار بیشتر از سایر پروژه‌ها (مثلاً کدهایی که در دانشگاه نوشته می‌شوند) اهمیت دارد؟

تلاش کنید فقط با فکر خود و بحث با هم‌تیمی‌تان به جواب سوالات بالا برسید تا ذهن شما برای مراحل بعد آماده شود.
لطفاً قبل از فکر کردن به این سوالات به سراغ مراحل بعدی و خواندن اسپویل نروید!

#### مطالعه

در مورد دلایل اهمیت کد تمیز مطالعه کنید:

<div dir="ltr">

- [The Importance of Clean Code](https://www.arcanys.com/blog/the-importance-of-clean-code/)
- [Why software maintainability is crucial](https://techhq.com/2019/06/why-software-maintainability-is-crucial/)

</div>

بعد از مطالعه، دوباره به سوالات بالا فکر کنید و بعد از بحث با هم‌تیمی خود جواب‌های جدید را در
Issue بنویسید.

#### Code Smells

یکی از راه‌های افزایش کیفیت کد، پیدا کردن نشانه‌های کد کثیف در برنامه و سپس Refactor کردن برنامه است به صورتی که
نشانه‌های کد کثیف از بین بروند. به این نشانه‌ها Code Smell می‌گوییم.

در مورد Code Smellهای زیر مطالعه کنید و مشخص کنید کدام یک از آن‌ها در کدی که برای پروژه زدید وجود دارد:

<div dir="ltr">

- [Code smell](https://en.wikipedia.org/wiki/Code_smell)
- [Long Method](https://refactoring.guru/smells/long-method)
- [Primitive Obsession](https://refactoring.guru/smells/primitive-obsession)
- [Large Class](https://refactoring.guru/smells/large-class)
- [Long Parameter List](https://refactoring.guru/smells/long-parameter-list)
- [Temporary Field](https://refactoring.guru/smells/temporary-field)
- [Duplicate Code](https://refactoring.guru/smells/duplicate-code)

</div>

---

### Design

معمولاً در پروژه‌های بزرگ، وظیفۀ طراحی بر عهدۀ شخصی به جز توسعه‌دهندۀ فرانت‌اند است.
اما در خیلی از مواقع ممکن است شما خودتان بخواهید این کار را انجام دهید.
بنابراین در اینجا مواردی که باید در طراحی به آن‌ها توجه کنید را توضیح می‌دهیم.

#### UI/UX

قطعاً بارها این دو کلمه را در جاهای مختلف شنیده‌اید.
UI یا User Interface به معنای رابط کاربری، مربوط به المان‌هایی است که کاربر با آن‌ها ارتباط دارد.
UX یا User Experience به معنای تجربۀ کاربری، مربوط به کیفیتی است که کاربر هنگاه استفاده از محصول تجربه می‌کند.

برای آشنایی بیشتر با این مفهوم می‌توانید از لینک‌های زیر استفاده کنید:

<div dir="ltr">

- [The difference between UI and UX, according to designer and Maze CEO, Jonathan Widawski](https://maze.co/blog/ui-vs-ux/)
- [UI vs. UX: What’s the difference between user interface and user experience?](https://www.usertesting.com/blog/ui-vs-ux)
- [The Difference Between UX and UI Design – A Beginner’s Guide](https://careerfoundry.com/en/blog/ux-design/the-difference-between-ux-and-ui-design-a-laymans-guide/)

</div>

#### White Space

المان‌های شما باید فضای کافی برای تنفس داشته باشند.
هیچوقت حجم انبوهی از اطلاعات را در یک مکان کوچک جا ندهید
چرا که کاربر نمی‌تواند به اندازۀ کافی تمرکز کند و این مسئله برایش عذاب‌آور خواهد بود.

برای ایجاد White Space راحت‌ترین کار استفاده از margin و padding است.
همچنین در flex و grid می‌توانید از gap استفاده کنید.

#### Color

رنگ‌ها و روانشناسی آن‌ها موضوعی است که سال‌ها طراحان را درگیر خود کرده.
هر رنگ نشان‌دهندۀ مجموعه‌ای از مفاهیم است که به آن روانشناسی رنگ‌ها گفته می‌شود.
به عنون مثال رنگ آبی نشانۀ صلح، آرامش، اعتماد، امن و ... می‌باشد؛
به همین خاطر خیلی از شرکت‌های بزرگ دنیا مانند facebook و twitter از این رنگ در محصولات خود استفاده می‌کنند.

همچنین زمانی که بخواهید بیش از یک رنگ داشته باشید،
باید دقت کنید که رنگ‌های انتخابی شما یکدگیر را تکمیل کنند.

به عنوان مثال اگر از دو رنگ استفاده می‌کنید، معمولاً توصیه می‌شود رنگ‌های متضاد را انتخاب کنید.
به عنوان مثال اگر رنگ اول شما آبی است، رنگ دوم را می‌توانید نارنجی بگذارید.

در پوستر خیلی از فیلم‌ها این موضوع را می‌توان مشاهده کرد:

<div dir=ltr align="center">

![Blue and Orange Movie Posters](https://github.com/Star-Academy/codestar-internship/blob/master/Projects/Frontend/PhaseF05-Best-Practices/Images/blue-and-orange-movie-posters.jpg)

</div>

برای انتخاب رنگ‌بندی، ما سایت Adobe Color را پیشنهاد می‌کنیم.
ابتدا از سمت چپ، نوع قالب رنگی را مشخص کنید،
سپس با استفاده از Color Wheel در وسط صفحه، رنگ اصلی را انتخاب کنید.
مشاهده خواهید کرد که ادوبی، باقی رنگ‌ها را به طور خودکار در اختیار شما قرار می‌دهد.

<div dir="ltr">

- [Adobe Color](https://color.adobe.com/create/color-wheel)

</div>

برای آشنایی بیشتر با این مفهوم می‌توانید از لینک‌های زیر استفاده کنید:

<div dir="ltr">

- [The Know It All Guide To Color Psychology In Marketing + The Best Hex Chart](https://coschedule.com/blog/color-psychology-marketing)
- [Color Psychology in Marketing and Branding is All About Context](https://www.helpscout.com/blog/psychology-of-color/)

</div>

#### Contrast

کنتراست موضوعی است که به شدت با رنگ‌ها در ارتباط است.
کنتراست یعنی تضاد بین رنگ‌ها.
به عنوان مثال اگر دکمه‌ای داشته باشیم،
می‌توان تضاد بین رنگ نوشته و رنگ پس‌زمینه را در نظر گرفت.

در دنیا استانداردی به نام WCAG وجود دارد که بیان می‌کند چه نسبتی بین نوشته و پس‌زمینه باید وجود داشته باشد.
این استاندارد شامل دو حالت AA و AAA است که حالت دوم رتبه‌بندی بهتری دارد و در صورت امکان باید آن را در نظر گرفت.

همچینن میزان کنتراست به بزرگ متن نیز وابسته است.
به عنوان مثال در رتبه‌بندی AA اگر اندازۀ متن معمولی باشد، نسبت کنتراست باید حداقل 4.5 به 1 باشد؛
اما اگر اندازۀ متن بزرگ باشد، این نسبت می‌تواند تا 3 به 1 کاهش پیدا کند.

برای بدست آوردن این نسبت می‌توانید از ابزارهای زیر استفاده کنید:

<div dir="ltr">

- [Colour Contrast Checker](https://colourcontrast.cc/)
- [Adobe Contrast Checker](https://color.adobe.com/create/color-contrast-analyzer)

</div>

برای آشنایی بیشتر با این مفهوم می‌توانید از لینک‌های زیر استفاده کنید:

<div dir="ltr">

- [Color contrast](https://developer.mozilla.org/en-US/docs/Web/Accessibility/Understanding_WCAG/Perceivable/Color_contrast)
- [The Myths of Color Contrast Accessibility](https://uxmovement.com/buttons/the-myths-of-color-contrast-accessibility/)
- [How to use contrast in UI Design](https://blog.prototypr.io/how-contrast-works-in-ui-design-21bf75a5a2bf)

</div>

#### Visual Hierarchy

زمانی که کاربر وارد صفحه می‌شود، با چشمانش المان‌های صفحه را به ترتیب بررسی می‌کند
که به آن Visual Hierarchy گفته می‌شود.
همواره المان‌های مهم‌تر باید رتبۀ بالاتری در این رده‌بندی داشته باشند.
به عنوان مثال تیتر یک صفحه از اهمیت بالایی برخوردار است اما تاریخ نگارش آن ممکن است خیلی مهم نباشد.

برای بالا بردن رتبۀ یک المان و جلب توجه کاربر از موارد متعددی مانند سایز و وزن فونت، فضای تنفس، رنگ و انیمیشن می‌توانید استفاده کنید.

برای آشنایی بیشتر با این مفهوم می‌توانید از لینک‌های زیر استفاده کنید:

<div dir="ltr">

- [6 principles of visual hierarchy for designers](https://en.99designs.nl/blog/tips/6-principles-of-visual-hierarchy/)
- [Key Principles of Visual Hierarchy in UX Design](https://xd.adobe.com/ideas/process/information-architecture/visual-hierarchy-principles-examples/)

</div>

#### Alignment

Alignment یا تراز بودن، به شدت ارتباط تنگاتنگی با Visual Hierarchy دارد
و اگر بتوان از این دو به درستی استفاده کرد،
شاهد یک UI و UX بی‌نظیر خواهیم بود.

المان‌هایی که کنتراست بالایی دارند، باید در یک ستون نسبت به المان‌های بالا و پایین خود قرار داشته باشند.
به این ترتیب می‌توان یک ساختار مشخص ایجاد و به بهبود تمرکز کاربر کمک کرد.

در اکثر مواقع توصیه نمی‌کنیم المان‌ها رو به صورت وسط‌چین تنظیم کنید؛
مگر اینکه فضای کوچکی مانند صفحه نمایش تلفن همراه در اختیار داشته باشد.
همچنین در موارد محدود می‌توانید Hero Section خود را به این شکل انتخاب کنید.
اما بیشتر اوقات بهتر است با توجه به RTL یا LTR بودن سایت، همان جهت را برای تراز کردن المان‌ها انتخاب کنید.

برای آشنایی بیشتر با این مفهوم می‌توانید از لینک‌های زیر استفاده کنید:

<div dir="ltr">

- [Principles of Design: Alignment](https://uxengineer.com/principles-of-design/alignment/)
- [Alignment Principle in Design: Importance & Examples](https://ux360.design/alignment-principle-design/)

</div>

#### Typography

تایپوگرافی چیزی فراتر از انتخاب یک فونت مناسب است.
تمام سایت‌ها از متن استفاده می‌کنند.
این متن می‌تواند در جایی مثل تیتر، پاراگراف و دکمه استفاده شود.
بنابراین تنظیم‌کردن خصوصیات این متون باید به بهترین شکل ممکن انجام شود.

همچنین برای پاراگراف‌ها و متن‌های طولانی توصیه می‌شود با توجه به نوع مطلب،
عرض خطوط بین 40 تا 70 کاراکتر باشد.
این مسئله به شدت به خوانایی متن کمک می‌کند.

برای آشنایی بیشتر با این مفهوم می‌توانید از لینک‌های زیر استفاده کنید:

<div dir="ltr">

- [10 Principles for Typography in UI Design](https://uxdesign.cc/10-principles-for-typography-usage-in-ui-design-a8f038f43ffd)
- [8 Rules for Perfect Typography in UI](https://blog.prototypr.io/8-rules-for-perfect-typography-in-ui-21b37f6f23ce)
- [Typography in UI Design](https://xd.adobe.com/ideas/process/ui-design/typography-in-ui-design/)

</div>

#### Simplicity

تا جایی که می‌توانید سعی کنید ذهن کاربر را با افکت‌های عجیب و غریب مشغول نکنید.
سعی کنید همه چیز کاملاً ساده، گویا و بدونِ حشو باشد.

به کار بردن افکتی که به تازگی آن را یاد گرفته‌اید ممکن است برای شخص شما بسیار جذّاب باشد،
اما برای اکثر کاربران صرفاً باری اضافه و امتیازی منفی محسوب می‌شود.

از سایه‌ها فقط و فقط در جایی که به آن احتیاج دارید استفاده کنید.
پیشنهاد می‌کنیم از border و outline استفاده نکنید،
اما اگر اصرار بر این کار دارید، نوع، اندازه و رنگ آن باید طوری انتخاب شود که توجه زیادی را از کاربر نگیرد.
Gradientها فقط زمانی خوب به نظر می‌آیند که بی‌نقص پیاده‌سازی شده باشند؛
بنابراین در حالت کلی بهتر است از رنگ‌های Solid استفاده کنید.

از طرفی باید دقت کنید که طرح شما Over-simplified نباشد.
این اتفاق بر سر بسیاری از لوگوها آمده و کاربران از آن بیزارند.
همه چیز باید به اندازه باشد تا بهترین UI و UX حاصل شود.

برای آشنایی بیشتر با این مفهوم می‌توانید از لینک‌های زیر استفاده کنید:

<div dir="ltr">

- [Why Simplicity is so Incredibly Important in UX Design](https://careerfoundry.com/en/blog/ux-design/how-important-is-simplicity-in-ux-design/)
- [False Simplicity in UI Design: Simple is not always better](https://tomkenny.design/articles/false-simplicity)

</div>

---

## پروژه

### Code Smells

با توجه به توضیحات این فاز، سعی کنید Code Smellهایی که در کدتان وجود دارد را شناسایی و اصلاح کنید.
برای این کار می‌توانید از لینک زیر کمک بگیرید:

<div dir="ltr">

- [Refactoring Techniques](https://refactoring.guru/refactoring/techniques)

</div>

### Pull Request and Code Review

بعد از اینکه موارد بالا را اصلاح کردید، یک PR بسازید
و اعضای یکی از تیم‌های دیگر را به عنوان Reviewer انتخاب کنید و به آن‌ها اطلاع بدهید
تا کد شما را بازبینی کنند.

قطعاً باقی تیم‌ها هم به سراغ شما خواهند آمد بنابراین قبل از Review کد آن‌ها،
حتماً از لینک‌های زیر استفاده کنید.

اگر از بقیۀ تیم‌ها عقب هستید و وقت کافی ندارید، لینک اول و در غیر این صورت لینک دوم را مطالعه کنید:

<div dir="ltr">

- [Effective Code Reviews: Code Review Checklist](https://github.com/nyu-cds/effective-code-reviews/blob/master/_episodes/03-checklist.md)
- [What to look for in a code review](https://google.github.io/eng-practices/review/reviewer/looking-for.html)

</div>

با توجه به این که در این فاز صحبتی در مورد انواع تست به خصوص Unit Test نکردیم قسمت‌هایی از لینک‌های بالا که در مورد تست است را نادیده بگیرید.

فیدبک‌ها و کامنت‌های دیگران را روی PR خود با دقت مطالعه کنید و اگر با نظر تیم
مقابل موافق هستید، کد خود را بر اساس آن اصلاح کنید، در غیر این صورت تلاش کنید آن‌ها را قانع کنید. اگر در این
زمینه به مشورت نیاز داشتید می‌توانید مسئله را با منتور خود مطرح کنید. در نهایت با اتمام تغییرات دوباره
کد را به تیم مقابل نشان دهید و از آن‌ها بخواهید PR را Approve کنند.

سپس از منتورهای خود نیز
بخواهید کد شما را Review کنند و در نهایت آن را روی برنچ master ببرید.

</div>
