Lab: Advanced Functions
=======================

Problems for in-class lab for the [\"JavaScript Advanced\" course @
SoftUni](https://softuni.bg/courses/js-advanced). Submit your solutions
in the SoftUni judge system at
<https://judge.softuni.bg/Contests/1528/Lab-Advanced-Functions>.

Add
---

Write a program that keeps a number **inside its context** and
**returns** new function that **adds** a **given** number to the
previous one.

### Input

Check the **examples** **below** to see how your code will be executed

### Output

Your function should **return** the final result .

### Examples

+-------------------------+--------+
| Sample Input            | Output |
+=========================+========+
| let add5 = solution(5); | 7      |
|                         |        |
| console.log(add5(2));   | 8      |
|                         |        |
| console.log(add5(3));   |        |
+-------------------------+--------+
| let add7 = solution(7); | 9      |
|                         |        |
| console.log(add7(2));   | 10     |
|                         |        |
| console.log(add7(3));   |        |
+-------------------------+--------+

Currency Format
---------------

Write a **higher-order** function that fixes some of the parameters of
another function. Your program will receive a function that **takes 4
parameters** and **returns a formatted string** (a monetary value with
currency symbol).

Your task is to **return another function** that only **takes one
parameter** and **returns** the **same formatted string**.

You will receive the following function:

+---------------------------------------------------------------------+
| currencyFormatter                                                   |
+=====================================================================+
| function currencyFormatter(separator, symbol, symbolFirst, value) { |
|                                                                     |
| let result = Math.trunc(value) + separator;                         |
|                                                                     |
| result += value.toFixed(2).substr(-2,2);                            |
|                                                                     |
| if (symbolFirst) return symbol + \' \' + result;                    |
|                                                                     |
| else return result + \' \' + symbol;                                |
|                                                                     |
| }                                                                   |
+---------------------------------------------------------------------+

Set the following parameters to fixed values:

separator: \",\"

symbol: \"\$\"

symbolFirst: true

The final parameter **value** is the one that the returned function will
receive.

### Input

You will receive a **function** parameter

### Output

You need to **return a function** that takes one parameter - **value**

### Examples

+-----------------------------------------------------+
| Sample Input                                        |
+=====================================================+
| let dollarFormatter = result(currencyFormatter);    |
|                                                     |
| console.log(dollarFormatter(5345)); *// \$ 5345,00* |
|                                                     |
| console.log(dollarFormatter(3.1429)); *// \$ 3,14*  |
|                                                     |
| console.log(dollarFormatter(2.709)); *// \$ 2,71*   |
+-----------------------------------------------------+

Filter Employees
----------------

Write a program that filters the employees of your company. You should
print the result in a specific format. You will receive **2** parameters
(**data**, **criteria**). You should **parse** the input, find all
employees that fullfil the citeria and print them.

### Input

You will receive a **string** with all the employees, and a **criteria**
by witch you should sort the employees. If the criteria is **\"all\"**
print all the employees in the given format.

### Output

The output should be the **printed** on the console.

For more information check the examples.

### Examples

+----------------------------------+----------------------------------+
| Sample Input                     | Output                           |
+==================================+==================================+
| \`\[{                            | 0\. Ardine Bassam -              |
|                                  | abassam0\@cnn.com                |
| \"id\": \"1\",                   |                                  |
|                                  | 1\. Kizzee Jost -                |
| \"first\_name\": \"Ardine\",     | kjost1\@forbes.com               |
|                                  |                                  |
| \"last\_name\": \"Bassam\",      |                                  |
|                                  |                                  |
| \"email\":                       |                                  |
| \"abassam0\@cnn.com\",           |                                  |
|                                  |                                  |
| \"gender\": \"Female\"           |                                  |
|                                  |                                  |
| }, {                             |                                  |
|                                  |                                  |
| \"id\": \"2\",                   |                                  |
|                                  |                                  |
| \"first\_name\": \"Kizzee\",     |                                  |
|                                  |                                  |
| \"last\_name\": \"Jost\",        |                                  |
|                                  |                                  |
| \"email\":                       |                                  |
| \"kjost1\@forbes.com\",          |                                  |
|                                  |                                  |
| \"gender\": \"Female\"           |                                  |
|                                  |                                  |
| },                               |                                  |
|                                  |                                  |
| {                                |                                  |
|                                  |                                  |
| \"id\": \"3\",                   |                                  |
|                                  |                                  |
| \"first\_name\": \"Evanne\",     |                                  |
|                                  |                                  |
| \"last\_name\": \"Maldin\",      |                                  |
|                                  |                                  |
| \"email\":                       |                                  |
| \"emaldin2\@hostgator.com\",     |                                  |
|                                  |                                  |
| \"gender\": \"Male\"             |                                  |
|                                  |                                  |
| }\]\`,                           |                                  |
|                                  |                                  |
| \'gender-Female\'                |                                  |
+----------------------------------+----------------------------------+
| \`\[{                            | 0\. Kaylee Johnson - k0\@cnn.com |
|                                  |                                  |
| \"id\": \"1\",                   | 1\. Kizzee Johnson -             |
|                                  | kjost1\@forbes.com               |
| \"first\_name\": \"Kaylee\",     |                                  |
|                                  | 2\. Evanne Johnson -             |
| \"last\_name\": \"Johnson\",     | ev2\@hostgator.com               |
|                                  |                                  |
| \"email\": \"k0\@cnn.com\",      |                                  |
|                                  |                                  |
| \"gender\": \"Female\"           |                                  |
|                                  |                                  |
| }, {                             |                                  |
|                                  |                                  |
| \"id\": \"2\",                   |                                  |
|                                  |                                  |
| \"first\_name\": \"Kizzee\",     |                                  |
|                                  |                                  |
| \"last\_name\": \"Johnson\",     |                                  |
|                                  |                                  |
| \"email\":                       |                                  |
| \"kjost1\@forbes.com\",          |                                  |
|                                  |                                  |
| \"gender\": \"Female\"           |                                  |
|                                  |                                  |
| }, {                             |                                  |
|                                  |                                  |
| \"id\": \"3\",                   |                                  |
|                                  |                                  |
| \"first\_name\": \"Evanne\",     |                                  |
|                                  |                                  |
| \"last\_name\": \"Maldin\",      |                                  |
|                                  |                                  |
| \"email\":                       |                                  |
| \"emaldin2\@hostgator.com\",     |                                  |
|                                  |                                  |
| \"gender\": \"Male\"             |                                  |
|                                  |                                  |
| }, {                             |                                  |
|                                  |                                  |
| \"id\": \"4\",                   |                                  |
|                                  |                                  |
| \"first\_name\": \"Evanne\",     |                                  |
|                                  |                                  |
| \"last\_name\": \"Johnson\",     |                                  |
|                                  |                                  |
| \"email\":                       |                                  |
| \"ev2\@hostgator.com\",          |                                  |
|                                  |                                  |
| \"gender\": \"Male\"             |                                  |
|                                  |                                  |
| }\]\`,                           |                                  |
|                                  |                                  |
| \'last\_name-Johnson\'           |                                  |
+----------------------------------+----------------------------------+

Command Processor
-----------------

Write a program that keeps a string **inside its context** and can
execute different **commands** that modify or print the string on the
console.

**append(string)** - append the given **string** at the end of the
internal string

**removeStart(n)** - **remove** the **first** **n** characters from the
string, **n** is an integer

**removeEnd(n)** - **remove** the **last n** characters from the string,
**n** is an integer

**print** - **print** the stored string on the **console**

### Input

Check the examples below to see how your code will be executed

### Output

Whenever you receive the command **print**, the output should be the
**printed** on the console.

### Examples

+----------------------------------+--------+
| Sample Input                     | Output |
+==================================+========+
| let firstZeroTest = solution();  | loa    |
|                                  |        |
| firstZeroTest.append(\'hello\'); |        |
|                                  |        |
| firstZeroTest.append(\'again\'); |        |
|                                  |        |
| firstZeroTest.removeStart(3);    |        |
|                                  |        |
| firstZeroTest.removeEnd(4);      |        |
+----------------------------------+--------+
| let secondZeroTest = solution(); | 34     |
|                                  |        |
| secondZeroTest.append(\'123\');  |        |
|                                  |        |
| secondZeroTest.append(\'45\');   |        |
|                                  |        |
| secondZeroTest.removeStart(2);   |        |
|                                  |        |
| secondZeroTest.removeEnd(1);     |        |
|                                  |        |
| secondZeroTest.print();          |        |
+----------------------------------+--------+
