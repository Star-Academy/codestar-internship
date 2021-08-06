<div dir="rtl" style="text-align: justify">

# فاز ده: آشنایی با انگولار پیشرفته

‌<p>
تا این فاز با مفاهیم اولیه فریم‌ورک انگولار آشنا شدید. در این فاز با قسمت‌های پیشرفته‌تر این فریم‌ورک آشنا خواهید شد. 
</p>

## Routing
‌<p>
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

‌<p> 
در اینجا مقدار routes که یک آرایه‌ای از routeها است، خالی است. اگر مقدار زیر را در آن قرار دهیم، به این معنی خواهد بود که اگر در url، آدرس test وارد شد، کامپوننت TestComponent را در صفحه به جای router-outlet لود کن. این تگ در app.component.html وجود دارد و محل لود شدن routeها را مشخص می‌کند.
</p>

<div dir="ltr">

```typescript
const routes: Routes = [
  { path: 'test', component: TestComponent }
];
```
</div>

‌<p> 
 به همین شکل برای تمامی routeها باید عمل شود. اگر در path مقدار ** وجود داشته باشد، به معنای همه routeهاست و برای ایجاد صفحه 404 استفاده می‌شود. برای اطلاعات بیشتر در زمینه Routing انگولار، به لینک‌های زیر مراجعه کنید:
</p>

<div dir="ltr">

- [Angular Router](https://angular.io/guide/router)

</div>

## Two-Way Binding


‌<p> 
مبحث Two-way binding به کامپوننت‌های انگولار این اجازه را می‌دهد تا داده بین خودشان به اشتراک گذارند. این اشتراک داده به صورت دوطرفه خواهد بود یعنی هر زمانی که تغییری در مقدار داده ایجاد شود، در همه جا این مقدار تغییر خواهد کرد. یک نمونه Two-way binding در شکل زیر آمده است:
</p>

<pre dir="ltr">
&lt;input [(ngModel)]="value" name="name" /&gt;
</pre>

‌<p> 
در مثال بالا، به محض تغییر کردن مقدار input، مقدار متغیر value نیز تغییر خواهد کرد. شما می‌توانید برای کامپوننت‌های خود امکان Two-way binding را ایجاد کنید. برای این منظور کافیست یک ورودی به هر نامی که می‌خواهید داشته باشید و سپس یک خروجی با همان نام که در انتهای آن Change آمده است ایجاد کنید و با تغییر ورودی، خروجی خود را emit کنید.
</p>

<pre dir="ltr">
export class SizerComponent {

  @Input()  size!: number | string;
  @Output() sizeChange = new EventEmitter<number>();

  dec() { this.resize(-1); }
  inc() { this.resize(+1); }

  resize(delta: number) {
    this.size = Math.min(40, Math.max(8, +this.size + delta));
    this.sizeChange.emit(this.size);
  }
}
</pre>

<p> 
برای اطلاعات بیشتر در زمینه Two-way binding به لینک‌های زیر مراجعه کنید:
</p>

<div dir="ltr">

- [Two-way binding](https://angular.io/guide/two-way-binding)

</div>

## Pipe

<p>
از pipeها برای تغییر شکل داده در صفحات HTML استفاده می‌شود. فرض کنید یک عدد به صورت 12345 دارید و قصد دارید این عدد را سه رقم، سه رقم جدا کنید؛ برای این منظور از pipe استفاده می‌شود. یک سری pipeهای آماده در انگولار وجود دارد مانند DatePipe که برای نمایش بهتره تاریخ استفاده می‌شود یا UpperCasePipe که نوشته شما را به صورت upper case نمایش می‌دهد. علاوه بر این pipeهای موجود شما نیز می‌توانید pipe جدیدی ایجاد کنید. برای ایجاد pipe از دستور زیر در CLI استفاده می‌شود:
</p>

<pre dir="ltr">
ng generate pipe pipe-name
</pre>

<p>
هر pipe یک متد transform دارد که ورودی آن مقداری است که قرار است در HTML تغییر کند و خروجی آن مقدار تغییر یافته است. نحوه استفاده از pipeها در HTML نیز به شکل زیر است:
</p>

<pre dir="ltr">
{{ birthday | date }}
</pre>

<p> 
برای اطلاعات بیشتر در زمینه pipeها به لینک‌های زیر مراجعه کنید:
</p>

<div dir="ltr">

- [Transforming Data Using Pipes](https://angular.io/guide/pipes)

</div>

## RxJs

<p>
یکی از کتابخانه‌هایی که خیلی زیاد در انگولار مورد استفاده قرار می‌گیرد، کتابخانه RxJs است. این کتابخانه امکان برنامه‌نویسی reactive را به شما می‌دهد و مدیریت حالت‌ها را برای شما راحت‌تر می‌کند.
</p>

<p>
برای اطلاعات بیشتر در زمینه RxJs به لینک‌های زیر مراجعه کنید:
</p>

<div dir="ltr">

- [RxJS](https://rxjs.dev/)
- [The RxJS library](https://angular.io/guide/rx-library)

</div>

## Angular Material

<p>
انگولار متریال یک کتابخانه یوآی برای دولوپرهای انگولار است. در این کتابخانه تعداد زیادی کامپوننت‌های آماده وجود دارد که می‌توانید از آن‌ها استفاده کنید. برای طراحی این کامپوننت‌های از اصول متریال استفاده شده است. کامپوننت‌های موجود در این کتابخانه شامل Button، Dialog، Select، Table، Paginator و ... است. برای طراحی سایت خود می‌توانید از این کتابخانه کمک بگیرید. برای اطلاعات بیشتر در زمینه انگولار متریال به لینک‌های زیر مراجعه کنید:
</p>

<div dir="ltr">

- [Angular Material](https://material.angular.io/)
- [Material Design](https://material.io/)

</div>

</div>