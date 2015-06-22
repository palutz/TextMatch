# TextMatch

**Text Match website**

This is a **Asp.Net 5 (MVC)** application, running on *Mac OS X* and *Linux* (and *Windows* as well) and developed with [Visual Studio Code](https://www.visualstudio.com/en-us/products/code-vs.aspx).  
For the ***DI*** I used the integrated container shipped with Asp.Net vNext.  
For test I used [xUnit](http://xunit.github.io/), the default test framework coming up with Asp.Net vNext.  
  
To build the project you can do it inside *Visual Studio 2015* on *Windows* or using *Visual Studio Core* on *Mac OS X / Linux*.  
From the root of the project type `dnu restore` to restore and install all the packages and then `dnu build src/TextMatch`.  
To run the website from the root folder of the project type `dnx src/TextMatch kestrel` on *OS X/Linux* or `dnx src/TextMatch web` on *Windows*. You will find the website at: [localhost:5001](http://localhost:5001).  
To run the tests, from the root folder of the project type `dnx test test`.

