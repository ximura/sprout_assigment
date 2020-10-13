# Sprout Therapy Assignment
![.NET Core](https://github.com/ximura/sprout_assigment/workflows/.NET%20Core/badge.svg)

.Net Core implementation of Sprout Therapy Assignment

Expected behavior achieved by the strict schema in request query also with functional tests of business logic.

### Testing

#### Run unit tests

```
>dotnet test
  Test run for E:\git-repo\sprout_assigment\sprout_assigment\calculator_test\bin\Debug\netcoreapp3.1\calculator_test.dll(.NETCoreApp,Version=v3.1)
  Microsoft (R) Test Execution Command Line Tool Version 16.7.0
  Copyright (c) Microsoft Corporation.  All rights reserved.

  Starting test execution, please wait...

  A total of 1 test files matched the specified pattern.

  Test Run Successful.
  Total tests: 39
       Passed: 39
   Total time: 0.9674 Seconds
```
#### Run postman tests

sprout_assigment.postman_collection - collection of postman tests

### Usage

Using curl

```shell script
curl -X POST -d "{\"a\": true, \"b\": true, \"c\": false, \"d\": 22.2, \"e\": 3, \"f\": 2, \"mode\": 2}" http://localhost:8000/api/v1/calculator

{"h":"t","k":20.72}
```

### Architecture
Web server build on Asp.Net Core

* calculator - project with busness logic
  * CalculatorBase - base implementation for requested functionality
  * CalculatorV1/CalculatorV2 - ovverride and extend functionality from CalculatorBase, it's implemented by inheritance

* calculator_test - project with unit test for busness logic

* sprout_assigment - web application, implements requests to different calculators from busnes logic. Calculators injectend into controllers as constructor parameter (simple dependency injection). 
  * BaseCalculatorController - base implementation for calculator controller
  * CalculatorController - api controller that use CalculatorBase. Request example: https://localhost:32768/api/v1/calculator/ 
  * CalculatorV1Controller - api controller that use CalculatorV1. Request example: https://localhost:32768/api/v2/calculator/ 
  * CalculatorV2Сontroller - api controller that use CalculatorV2. Request example: https://localhost:32768/api/v3/calculator/ 


