Blazor singleton AddHttpClient demo
===================================

This project demonstrates how when attempting to inject HttpClient to singleton
service using extension method AddHttpClient transforms the singleton service to 
either transient or scoped.

## How to demonstrate
* Run the application in HowSingletonsShouldWork branch
* Open browser and open dev tools
* Navigate to 'Counter' page

What you should see: there should be one line of logging

`info: AddHttpClientSingletonExample.Services.CounterService[0] CounterService ctor`

This means that the **CounterService** had an instance created for *Counter* page.

* Click the 'Click me" button a couple of times
* Navigate to Counter 2

What you should see:

The count is at whatever number you stopped at page *Counter*

* Run the application in UsingExtensionMethod branch
* Open browser and open dev tools
* Navigate to 'Counter' page

What you should see: there should be one line of logging

`info: AddHttpClientSingletonExample.Services.CounterService[0] CounterService ctor`

This means that the **CounterService** had an instance created for *Counter* page.

* Click the 'Click me" button a couple of times
* Navigate to Counter 2

What you should see:

Current count is 0 and you should see another log line in console.

This proves that every time user navigates between two counter pages, 
a new instance of **CounterService** class is created and injected. This is expected
behaviour for scoped and transient services but not singleton.

