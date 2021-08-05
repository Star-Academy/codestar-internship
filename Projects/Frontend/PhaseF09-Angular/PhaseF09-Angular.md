
<div dir="rtl">

# فاز هشت: آشنایی با مفاهیم مقدماتی انگولار
‌<p dir="rtl" style="text-align: justify">
یکی از محبوب‌ترین فریمورک‌های طراحی وب، انگولار است که توسط تیمی در گوگل، طراحی و پیاده‌سازی شده است. در این فریمورک به جای جاوااسکریپت، از زبان تایپ اسکریپت استفاده می‌کند. این زبان توسط ماکروسافت طراحی شده است و یک super set روی جاوااسکریپت است. به این معنی که تمام موارد داخل جاوااسکریپت را دارد و علاوه بر آن‌، موارد بیشتری را نیز پشتیبانی می‌کند. برای مثال در تایپ‌اسکریپت بر خلاف جاوااسکریپت، تایپ وجود دارد و شما می‌توانید برای متغیرهای خود تایپ تعیین کنید. 
</p>
‌<p dir="rtl" style="text-align: justify">
همچنین در تایپ‌اسکریپت، interface و abstract class پشتیبانی می‌شود که به وسیله‌ی آن‌ها می‌توان کد تمیزتری که از اصول SOLID استفاده می‌کند، ایجاد کرد. در انگولار، کد به زبان typescript نوشته می‌شود و در انتها به زبان javascript کامپایل می‌شود، زیرا تنها زبانی که مرورگر‌ها پشتیبانی می‌کنند، زبان javascript است. 
</p>
‌<p dir="rtl" style="text-align: justify">
برای این که تفاوت‌های این دو زبان را بیشتر متوجه شوید، می‌توانید به لینک‌های زیر مراجعه کنید.
</p>

<div dir="ltr">

- [Javascript vs Typescript](https://www.javatpoint.com/javascript-vs-typescript)
- [Typescript vs JavaScript: What's the Difference?](https://www.guru99.com/typescript-vs-javascript.html)

</div>

## Angular CLI

‌<p dir="rtl" style="text-align: justify">
انگولار به همراه خود cli مخصوص خود را دارد که ایجاد پروژه، کامپوننت، ماژول و ... را برای developerها آسان‌تر می‌کند. برای شروع کار با انگولار به شکل زیر عمل می‌شود.
</p>

### مرحله اول: نصب انگولار

‌<p dir="rtl" style="text-align: justify">
برای نصب انگولار و cli مربوطه در ابتدا باید node.js نصب داشته باشید. برای این منظور به سایت <a target="_blank"  href="https://nodejs.org/en/">node.js</a> مراجعه کرده و نسخه‌ LTS را دریافت کنید. 
</p>

‌<p dir="rtl" style="text-align: justify">
سپس cmd یا terminal را باز نموده و دستور زیر را جهت نصب انگولار و cli مربوطه در سیستم وارد کنید:
</p>

<pre dir="ltr">
npm i -g @angular/cli
</pre>

<p dir="rtl" style="text-align: justify">
در حال حاضر آخرین نسخه‌ی انگولار، نسخه 12 است که با این دستور در سیستم شما نصب خواهد شد. 
</p>

### مرحله دوم: ایجاد پروژه

‌<p dir="rtl">
برای ایجاد پروژه، به کمک cmd یا terminal به داخل فولدر دلخواه رفته و دستور زیر را وارد کنید: 
</p>

<pre dir="ltr">
ng new project-name
</pre>

‌<p dir="rtl" style="text-align: justify"> 
پس از وارد کردن این دستور چند سوال از شما پرسیده می‌شود. اولی وجود روتینگ در پروژه است که در فاز بعدی بیشتر در مورد آن صحبت می‌شود و دومی فرمت stylesheetهای پروژه است. در قسمت اول بهتر است، yes وارد کنید و در قسمت دوم از scss استفاده کنید. در انتهای این دستور یک پروژه‌ی انگولار، به نام my-project در فولدر شما ساخته می‌شود. این کار معمولا زمان‌بر است زیرا پکیج‌های زیادی را باید نصب کند. 
</p>

### مرحله سوم: اجرای پروژه

‌<p dir="rtl" style="text-align: justify">
پس از ایجاد پروژه، می‌توانید با دستور زیر، پروژه را اجرا کنید و در مرورگر آن را مشاهده کنید:
</p>

<pre dir="ltr">
ng serve
</pre>

‌<p dir="rtl" style="text-align: justify"> 
این دستور یک سرور مجازی روی پورت 4200 ایجاد کرده و سایت را روی آن اجرا می‌کند. به این ترتیب شما اولین پروژه‌ی انگولاری خود را ایجاد کرده‌اید. در ادامه به معرفی بخش‌های مختلف انگولار پرداخته می‌شود.
</p>

### Module
‌<p dir="rtl" style="text-align: justify">
ماژول مجموعه‌ای از کامپوننت‌ها و سرویس‌ها است که با یکدیگر وابستگی نزدیکی دارند. هر پروژه انگولار حداقل یک ماژول دارد که به آن AppModule می‌گویند و در ابتدا ساخته می‌شود. در این ماژول مشخص می‌شود که کامپوننت شروع‌کننده برنامه چیست. این کامپوننت در قسمت bootstrap مشخص می‌شود. اگر در داخل یک ماژول از ماژول دیگری استفاده شود، نام آن در import می‌آید و نام تمام کامپوننت‌های داخل ماژول نیز در declarations مشخص می‌شود. اگر بالای هر کلاس تایپ‌اسکریپت از دکوراتور @NgModule استفاده شود، آن کلاس تبدیل به ماژول می‌شود. برای اطلاعات بیشتر در زمینه ماژول به لینک‌های زیر مراجعه کنید:
</p>

<div dir="ltr">

- [Decorators](https://codecraft.tv/courses/angular/es6-typescript/decorators/)
- [Introduction to modules](https://angular.io/guide/architecture-modules)
- [What is an Angular Module?](https://angular-training-guide.rangle.io/modules/introduction)

</div>

‌<p dir="rtl" style="text-align: justify">
برای ایجاد یک ماژول جدید به کمک Angular CLI، از دستور زیر استفاده می‌شود:
</p>

<pre dir="ltr">
ng generate module module-name
</pre>

### Component
‌<p dir="rtl" style="text-align: justify">
 هر پروژه‌ی انگولار از چندین کامپوننت تشکیل شده است. هر کامپوننت معماری MVVM دارد و شامل یک فایل HTML، یک فایل استایل‌شیت و یک فایل تایپ‌اسکریپت است. اگر بالای هر کلاس تایپ‌اسکریپت از دکوراتور <span dir="ltr">@Component()</span> استفاده شود، آن کلاس تبدیل به کامپوننت می‌شود. هر کامپوننت باید در داخل declarations یک ماژول تعریف شده باشد. برای اطلاعات بیشتر در زمینه کامپوننت‌های انگولار به لینک‌های زیر مراجعه کنید: 
</p>

<div dir="ltr">

- [Angular Components Overview](https://angular.io/guide/component-overview)

</div>

‌<p dir="rtl" style="text-align: justify">
برای ایجاد یک کامپوننت جدید به کمک Angular CLI، از دستور زیر استفاده می‌شود:
</p>

<pre dir="ltr">
ng generate component component-name
</pre>

### Service
‌<p dir="rtl" style="text-align: justify">
 برای دریافت داده و یا logicهایی که مخصوص یک کامپوننت خاص نیست، از service استفاده می‌شود. در انگولار از Dependency Injection استفاده می‌شود. نحوه‌ی عملکرد آن به این صورت است که سرویس‌های مربوط به یک ماژول در قسمت providers موجود در ماژول، مشخص می‌شود و در زمان اجرا، آن service ساخته می‌شود و به کامپوننت‌های داخل ماژول داده می‌شود. بالای هر سرویس از دکوراتور <span dir="ltr">@Injectable()</span> استفاده می‌شود. یکی از مهم‌ترین سرویس‌های موجود در انگولار، HttpClient است. از این سرویس برای ارسال درخواست‌های Get و یا Post به سرور استفاده می‌شود. برای اطلاعات بیشتر در زمینه سرویس‌های انگولار به لینک‌های زیر مراجعه کنید: 
</p>

<div dir="ltr">

- [Introduction to services and dependency injection](https://angular.io/guide/architecture-services)

</div>

‌<p dir="rtl" style="text-align: justify">
برای ایجاد یک سرویس جدید به کمک Angular CLI، از دستور زیر استفاده می‌شود:
</p>

<pre dir="ltr">
ng generate service service-name
</pre>

### Routing
‌<p dir="rtl" style="text-align: justify">
 اولین سوالی که در زمان ایجاد پروژه از شما شد، وجود routing در پروژه بود. برنامه‌های انگولار به صورت SPA یا Single Page Application هستند. به این شکل که شما تنها یک صفحه در سایت خود دارید و محتوا به صورت داینامیک در همان صفحه لود می‌شود. این که محتوای چه قسمتی در صفحه لود شود، به کمک Routing مشخص می‌شود. به صورت پیش‌فرض پس از ایجاد یک پروژه، routing زیر برای شما در فایل app-routing.module.ts به وجود خواهد آمد. 
</p>

<div dir="ltr">

```typescript
const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

```
</div>

‌<p dir="rtl" style="text-align: justify"> 
در اینجا مقدار routes که یک آرایه‌ای از routeها است، خالی است. اگر مقدار زیر را در آن قرار دهیم، به این معنی خواهد بود که اگر در url، آدرس test وارد شد، کامپوننت TestComponent را در صفحه به جای router-outlet لود کن. این تگ در app.component.html وجود دارد و محل لود شدن routeها را مشخص می‌کند.
</p>

<div dir="ltr">

```typescript
const routes: Routes = [
  { path: 'test', component: TestComponent }
];
```
</div>

‌<p dir="rtl" style="text-align: justify"> 
 به همین شکل برای تمامی routeها باید عمل شود. اگر در path مقدار ** وجود داشته باشد، به معنای همه routeهاست و برای ایجاد صفحه 404 استفاده می‌شود. برای اطلاعات بیشتر در زمینه Routing انگولار، به لینک‌های زیر مراجعه کنید:
</p>

<div dir="ltr">

- [Angular Router](https://angular.io/guide/router)

</div>

</div>
