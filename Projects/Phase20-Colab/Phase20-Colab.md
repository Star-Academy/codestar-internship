<div dir="rtl" align='justify'>

# فاز بیست: آشنایی با ابزار های Data Science

در این فاز میخواهیم با زبان python و برخی از فناوری ها و ابزار های مورد استفاده‌ی Data Scientist ها آشنا بشویم.



## زبان برنامه نویسی python

احتمالاً تا کنون بار ها اسم این زبان را شنیده‌اید. این زبان محبوبیت زیادی بین Data Scientist ها دارد چون:

*  ساده و نزدیک به زبان انسان هست و برای بسیاری از Data Scientist ها که ممکن است تجربه‌ی کار با زبان‌های اصلی Object Oriented  و مفاهیم پیشرفته دنیای مهندسی نرم افزار را نداشته باشند، یادگیری راحتی دارد.

* وجود کتابخانه‌های زیاد و متنوع به زبان python در حوزه Data Science

در این فاز میخواهیم با استفاده از زبان python و کتابخانه‌های معروف آن، روی دیتاستی که در پایان این مستند آمده است، کار های ساده‌ ETL انجام دهیم.

 برای این کار آشنایی مقدماتی با python لازم است. اگر با python آشنایی ندارید می‌توانید با مطالعه لینک‌های زیر برای ادامه کار آماده شوید:

 * [Python Introduction](https://developers.google.com/edu/python/introduction)
 * [Python Lists](https://developers.google.com/edu/python/lists)
 * [Python Sorting](https://developers.google.com/edu/python/sorting)
 * [Python Dict and File](https://developers.google.com/edu/python/dict-files)
  

## آشنایی با Colab
محصول Google Colaboratory یا Colab یک ابزار بسیار راحت برای کار با داده‌ها به زبان python است. با استفاده از Colab می‌توانید کد‌های python را در مرورگر خود بنویسید و اجرای آن‌ها را به سرور بسپارید و بدون این که کامپیوتر خودتان درگیر اجرای کد روی داده شود نتیجه‌ی اجرا روی سرور در مرورگر به شما نشان داده شود.

برای این که بهتر متوجه شوید لینک زیر را باز کنید و با Colab کار کنید:

* [Overview of Colaboratory Features](https://colab.research.google.com/notebooks/basic_features_overview.ipynb)
* [Importing libraries](https://colab.research.google.com/notebooks/snippets/importing_libraries.ipynb)

همان طور که در لینک بالا دیدید، در Colab علاوه بر نوشتن کد python می‌توان توضیحاتی را به صورت markdown نوشت.

همچنین می‌توانید به صورت زیر فایل های Colab notebook را روی github ذخیره کنید و تغییرات را Commit کنید:
* [Using Google Colab with GitHub](https://colab.research.google.com/github/googlecolab/colabtools/blob/master/notebooks/colab-github-demo.ipynb)

یکی از امکانات  خوب Colab امکان اتصال به Google Drive و خواندن/نوشتن فایل‌های آن است:

* [Mounting Google Drive locally](https://colab.research.google.com/notebooks/io.ipynb#scrollTo=u22w3BFiOveA)


آشنایی مقدماتی با Colab به پایان رسید، برای جزئیات بیشتر و رفع ابهام می‌توانید به لینک زیر مراجعه کنید:

* [Google Colab — Your Python workspace on cloud](https://towardsdatascience.com/google-colab-your-python-workspace-on-cloud-c3aed424de0d)

برای آشنایی بیشتر با مفهوم notebook و معماری فنی آن لینک‌های زیر را بخوانید:

* [Project Jupyter](https://en.wikipedia.org/wiki/Project_Jupyter)
* [IPython](https://en.wikipedia.org/wiki/IPython)
* [Read–eval–print loop](https://en.wikipedia.org/wiki/Read%E2%80%93eval%E2%80%93print_loop)


## آشنایی با ساختمان داده DataFrame 

با استفاده از DataFrame در کتابخانه pandas می‌توان انواع عملیات ETL و Visualize داده را انجام داد. در این قسمت می‌خواهیم با استفاده از فایل‌های csv دیتاست های معروف دو تمرین دستگرمی انجام دهیم:

* [دستگرمی اول](https://colab.research.google.com/notebooks/mlcc/intro_to_pandas.ipynb) (Intro to pandas - California Housing CSV)
* [دستگرمی دوم](https://colab.research.google.com/github/ChadFulton/sm-notebooks-2021/blob/main/001-etl-data-covid-19.ipynb) (ETL Data - COVID-19 datasets)

نکته: از دستگرمی دوم فقط قسمت New York Times را اجرا کنید.


## پروژه اصلی - تحلیل داده‌های شیوع کرونا در ایران

در این قسمت می‌خواهیم بر اساس دو فایل csv آمار ابتلا و میزان واکسیناسیون که در ریپازیتوری [owid/covid-19-data](https://github.com/owid/covid-19-data/tree/master/public/data) وجود دارند، پردازش‌های ETL زیر را اجرا کنیم:

* فیلتر
* تمیز سازی ساده
* Sum
* Join
* Aggregation (Group by)

همچنین یک Visualization ساده نیز در نظر گرفتیم.

برای راحتی بیشتر شما در انجام این پروژه یک notebook آماده و تحلیل‌ها و خروجی‌های مورد نظر در آن نشان داده شده‌است. سپس بخش‌هایی از کد را پاک کردیم تا شما پیاده‌سازی کنید. لینک زیر را باز کنید و سپس محتوایات خواسته شده را پر کنید و با اجرای مجدد از درستی کدتان مطمئن شوید:

* [Iran-Covid-ETL-notebook.ipynb](https://colab.research.google.com/github/Star-Academy/codestar-internship/blob/feature%2FSE-phase20/Projects/Phase20-Colab/Iran-Covid-ETL-notebook.ipynb)

یک منبع خوب برای دستورات مورد نیاز شما در کار با DataFrame فایل [Pandas_Cheat_Sheet.pdf](https://pandas.pydata.org/Pandas_Cheat_Sheet.pdf) هست.

در پایان پروژه، notebook ویرایش شده‌ی خودتان را با استفاده از دگمه Share در گوشه‌ی بالا سمت راست صفحه‌ی Colab با دیگران به اشتراک بگذارید و دسترسی Comment گذاری به آن‌ها بدهید و لینک تولید شده را در ایشوی github تیم خودتان قرار دهید.


پی‌نوشت: فایل‌های csv موجود در ریپازیتوری [owid/covid-19-data](https://github.com/owid/covid-19-data/tree/master/public/data) به صورت روزانه بر اساس آخرین گزارش‌های کرونا به روز می‌شوند و بر اساس روزی که داده‌ها خوانده می‌شوند ممکن است نتایج اجرای شما تفاوت اندکی با خروجی قبلی داشته باشند. در صورتی که لینک‌ها خراب شوند یا بخواهید نتایج شما دقیقا مطابق خروجی باشد می‌توانید از [فایل‌های پشتیبان](./dataset_backup) استفاده کنید که در تاریخ 18-08-2021 از همان ریپازیتوری دانلود شده‌اند.


</div>