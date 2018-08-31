# Tax Planning

> This web application compares annuity options and shows performance projections for various annuities with various riders based on market scenarios generated with a basic Monte Carlo method. It was built for the [PIEtech, Inc](https://www.moneyguidepro.com/ifa/). internship in summer 2018, as the second of three projects. It was built by a team of five interns: two business/technical analysts, two back-end developers, and me, a front-end developer.

---

#### Built with:

* [Aurelia](https://aurelia.io/)
* ASP.NET Core MVC Web API

---

#### My contributions:
* Built entire front-end using Sass SCSS and Typescript with the Aurelia framework
* Used the Chart.js charting library to generate responsive charts
* Entire application is mobile-friendly&ast;


#### Basic structure:

* Back-end code can be found in the `GuaranteedIncome` directory
* Front-end code can be found in the `web-app` directory

This code was never deployed; it was an intern project and the goal was to have a functional development build. The only way it has ever been run is a Webpack development server for the front-end and the Visual Studio built-in IIS Express server for the back-end. To run it on any other configuration, the fetch URL on the front-end will have to be changed, and, depending on the configuration, CORS may have to be reconfigured.

---

## Important Note

As with any project, there are things that I did that I could have done better. Upon completion of the project, we did a code review and professional developers were very helpful and pointed out several things that could have been improved. I have left it as-is in order to
1. Demonstrate progress in software development ability with the [first](https://github.com/cabellwg/tax-planning) and [third](https://github.com/cabellwg/monte-carlo) projects and
2. Accurately demonstrate my software development skills in a limited period of development time (one two-week sprint).

---

&ast;_Mobile-friendliness is not perfect and disregards several best practices. But it does look decent until you get to screen sizes smaller than about 500 pixels._

I hadn't done web development in almost a year and I was a little rusty. See the code for [my personal website](https://github.com/cabellwg/williamcabell) for a peek at some much better front-end code.
