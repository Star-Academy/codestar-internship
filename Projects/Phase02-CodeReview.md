<div dir="rtl" align='right'>

[لیست تسک‌های مرتبط با این فاز به صورت issue template](./issue-template-Phase02.md)

##  فاز دو: افزایش کیفیت کد و آشنایی با Code Review اصولی
در این فاز با مفاهیم و تکنیک‌های مختلفی برای افزایش کیفیت کد آشنا می‌شوید، در این فاز، کد فاز قبل را به یک کد بسیار با کیفیت تبدیل می‌کنید، سپس کد خود را با سایر کارآموزان به اشتراک می‌گذارید و از آن‌ها می‌خواهید کدتان را Review کنند.
1. قبل از شروع این فاز حدود نیم ساعت تا یک ساعت در مورد دو سوال زیر فکر کنید و با هم تیمی خود بحث کنید، بعد از پایان بحث برای هر سوال سه دلیل را که فکر می‌کنید از بقیه مهم‌تر هستند در Issueی خودتان بنویسید:
    1. «چرا تمیز بودن کد و داشتن معماری خوب مهم است؟ چرا باید وقت و انرژی زیادی صرف طراحی و نوشتن کد تمیز شود؟»
    1. «چرا این موضوع (تمیز نوشتن کد و صرف وقت و انرژی زیاد برای آن) در **صنعت نرم افزار** بسیار بیشتر از سایر پروژه‌ها (مثلاً کد هایی که در دانشگاه نوشته می‌شوند) اهمیت دارد؟»

    
    
    > :warning: در مرحله‌ی یک تلاش کنید **فقط با فکر خودتان و بحث با هم تیمی** به جواب سوالات بالا از دیدگاه خودتان برسید تا ذهن شما برای مراحل بعد آماده شود، لطفا قبل از فکر کردن به این سوالات به سراغ مراحل بعدی و خواندن اسپویل نروید!

1. در این مرحله در مورد دلایل اهمیت کد تمیز در صنعت در نرم افزار مطالعه کنید، مطالعه‌ی [The Importance of Clean Code](https://www.arcanys.com/blog/the-importance-of-clean-code) را در مورد سوال اول و مطالعه‌ی [Why software maintainability is crucial - TechHQ](https://techhq.com/2019/06/why-software-maintainability-is-crucial/) را در مورد سوال دوم پیشنهاد می‌کنیم.
    
1. بعد از مطالعه موارد مرحله‌ی قبل دوباره به سوالات مرحله‌ی اول فکر کنید و بعد از بحث با هم تیمی خود جواب‌های جدید را در Issue بنویسید.

1. یکی از راه‌های افزایش کیفیت کد، پیدا کردن نشانه‌های کد کثیف در برنامه و سپس Refactor کردن برنامه است به صورتی که نشانه‌های کد کثیف از بین بروند. به این نشانه‌ها [Code Smell](https://en.wikipedia.org/wiki/Code_smell) می‌گوییم. در این مرحله در مورد Code Smell های زیر مطالعه کنید و مشخص کنید کدام یک از موارد زیر در کدی که برای فاز اول زدید به وجود آمده است؟
    - [Long Method](https://refactoring.guru/smells/long-method)
    - [Primitive Obsession](https://refactoring.guru/smells/primitive-obsession)
    - [Large Class](https://refactoring.guru/smells/large-class)
    - [Long Parameter List](https://refactoring.guru/smells/long-parameter-list)
    - [Temporary Field](https://refactoring.guru/smells/temporary-field)
    - [Duplicate Code](https://refactoring.guru/smells/duplicate-code)


1. حالا برای رفع این Code Smellها در کد فاز یک تلاش کنید. می‌توانید برای Refactor کردن بخش‌های مختلف کدتان خلاقیت به خرج دهید و ایده بزنید یا سَری به مجموعه [Refactoring Techniques - refactoring.guru](https://refactoring.guru/refactoring/techniques) بزنید، اما مطالعه‌ی دقیق تمام موارد موجود در این لینک نیاز نیست همین که به فهرست آن نگاه کنید و بعضی از آن‌ها را مرور کنید کافیست. تغییرات کد در این مرحله را روی  یک Branch غیر از Master انجام دهید و بعد از اتمام این مرحله یک [Pull Request](https://docs.github.com/en/github/collaborating-with-issues-and-pull-requests/about-pull-requests) بسازید اما آن را در این مرحله Merge نکنید.



1. یکی از تیم‌های دیگر را انتخاب کنید و از آن‌ها بخواهید Pull Requestی که در مرحله‌ی قبل ساخته‌اید را Review کنند و بر اساس لیست Code Smellهای مرحله‌ی  4 به شما فیدبک بدهند (روی Pull Request کامنت بگذارند)، در این مرحله حتما از تیم‌های دیگر هم سراغ شما می‌آیند و می‌خواهند کدشان را Review کنید، قبل از Review کد دیگران یکی از دو راهنمای زیر را مطالعه کنید و Review خود را بر اساس این راهنما انجام دهید:
    - اگر وقت شما کم هست و از بقیه تیم‌ها عقب تر هستید نسخه خلاصه را بخوانید: [Effective Code Reviews: Code Review Checklist](https://nyu-cds.github.io/effective-code-reviews/03-checklist/)

    - اگر وقت شما بیشتر است و از بقیه تیم‌ها جلوتر هستید نسخه جامع (راهنمای Review شرکت گوگل)  را بخوانید:
    [What to look for in a code review | eng-practices](https://google.github.io/eng-practices/review/reviewer/looking-for.html) (CL stands for Code Line)

    > :warning: با توجه به این که در این فاز صحبتی در مورد انواع تست به خصوص Unit Test نکردیم قسمت‌هایی از لینک‌های بالا که در مورد تست است را نادیده بگیرید.

1. فیدبک‌ها و کامنت‌های دیگران را روی Pull Requestی که دو مرحله قبل ساخته بودید با دقت مطالعه کنید و اگر با نظر تیم مقابل موافق هستید کد خود را بر اساس آن اصلاح کنید، اگر موافق نیستید تلاش کنید تیم مقابل را قانع کنید، اگر در این زمینه به مشورت نیاز داشتید می‌توانید مسئله را با راهبر یا همیار تیم خود مطرح کنید. در نهایت با اتمام تغییرات دوباره کد را به تیم مقابل نشان دهید و از آن‌ها بخواهید Pull Request را Approve کنند سپس از همیار و در آخر از راهبر خود نیز بخواهید کد شما را Review کنند و در نهایت PR را روی برنچ master ببرید. (Merge کنید)
    

</div>
