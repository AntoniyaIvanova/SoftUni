# Lab: Data Types and Variables

Problems for in-class lab for the  
You can check your solutions in
[Judge](https://judge.softuni.bg/Contests/1192/Data-Types-and-Variables-Lab)

# Integer and Real Numbers

## Convert Meters to Kilometers

You will be given an integer that will be distance in meters. Write a
program that converts meters to kilometers formatted to the second
decimal point.

### Examples

| **Input** | **Output** |
| --------- | ---------- |
| 1852      | 1.85       |
| 798       | 0.80       |

## Pounds to Dollars

Write a program that converts British pounds to US dollars formatted to
3th decimal point.

1 British Pound = 1.31 Dollars

### Examples

| **Input** | **Output** |
| --------- | ---------- |
| 80        | 104.800    |
| 39        | 51.090     |

## Exact Sum of Real Numbers

Write program to enter **n** numbers and calculate and print their
**exact sum** (without rounding).

### Examples

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><strong>3</strong></p>
<p><strong>1000000000000000000</strong></p>
<p><strong>5</strong></p>
<p><strong>10</strong></p></td>
<td><strong>1000000000000000015</strong></td>
</tr>
<tr class="even">
<td><p><strong>2</strong></p>
<p><strong>0.00000000003</strong></p>
<p><strong>333333333333.3</strong></p></td>
<td><strong>333333333333.30000000003</strong></td>
</tr>
</tbody>
</table>

### Hints

Use **BigInteger** to not lose precision.

# Data Types and Type Conversion

## Centuries to Minutes

Write program to enter an integer number of **centuries** and convert it
to **years**, **days**, **hours** and **minutes**.

### Examples

| **Input** | **Output**                                                                    |
| --------- | ----------------------------------------------------------------------------- |
| **1**     | **1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes**    |
| **5**     | **5 centuries = 500 years = 182621 days = 4382904 hours = 262974240 minutes** |

### Hints

  - Use appropriate data type to fit the result after each data
    conversion.

  - Assume that a year has **365.2422 days at average ([the Tropical
    year](https://en.wikipedia.org/wiki/Tropical_year)).**

## Special Numbers

A **number** is **special** when its **sum of digits is 5, 7 or 11**.

Write a program to read an integer **n** and for all numbers in the
range **1…n** to print the number and if it is special or not (**True**
/ **False**).

### Examples

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>15</strong></td>
<td><p><strong>1 -&gt; False</strong></p>
<p><strong>2 -&gt; False</strong></p>
<p><strong>3 -&gt; False</strong></p>
<p><strong>4 -&gt; False</strong></p>
<p><strong>5 -&gt; True</strong></p>
<p><strong>6 -&gt; False</strong></p>
<p><strong>7 -&gt; True</strong></p>
<p><strong>8 -&gt; False</strong></p>
<p><strong>9 -&gt; False</strong></p>
<p><strong>10 -&gt; False</strong></p>
<p><strong>11 -&gt; False</strong></p>
<p><strong>12 -&gt; False</strong></p>
<p><strong>13 -&gt; False</strong></p>
<p><strong>14 -&gt; True</strong></p>
<p><strong>15 -&gt; False</strong></p></td>
</tr>
</tbody>
</table>

### Hints

To calculate the sum of digits of given number **num**, you might repeat
the following: sum the last digit (**num** **%** **10**) and remove it
(**sum** **=** **sum** **/** **10**) until **num** reaches **0**.

## Reversed Chars

Write a program that takes 3 lines of characters and prints them in
reversed order with a space between them.

### Examples

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>A</p>
<p>B</p>
<p>C</p></td>
<td>C B A</td>
</tr>
<tr class="even">
<td><p>1</p>
<p>L</p>
<p>&amp;</p></td>
<td>&amp; L 1</td>
</tr>
</tbody>
</table>

## Concat Names

Read two names and a delimiter. Print the names joined by the delimiter.

### Examples

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><strong>John</strong></p>
<p><strong>Smith</strong></p>
<p><strong>-&gt;</strong></p></td>
<td><strong>John-&gt;Smith</strong></td>
</tr>
<tr class="even">
<td><p><strong>Jan</strong></p>
<p><strong>White</strong></p>
<p><strong>&lt;-&gt;</strong></p></td>
<td><strong>Jan&lt;-&gt;White</strong></td>
</tr>
<tr class="odd">
<td><p><strong>Linda</strong></p>
<p><strong>Terry</strong></p>
<p><strong>=&gt;</strong></p></td>
<td><strong>Linda=&gt;Terry</strong></td>
</tr>
</tbody>
</table>

## Town Info

You will be given 3 lines of input. On the first line you will be given
the name of the town, on the second – the population and on the third
the area. Use the correct data types and print the result in the
following format:

"**Town {town name} has population of {population} and area {area}
square km**".

### Examples

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Sofia</p>
<p>1286383</p>
<p>492</p></td>
<td>Town Sofia has population of 1286383 and area 492 square km.</td>
</tr>
</tbody>
</table>

## Chars to String

Write a program that reads 3 lines of input. On each line you get a
single character. Combine all the characters into one string and print
it on the console.

### Examples

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>a</p>
<p>b</p>
<p>c</p></td>
<td>abc</td>
</tr>
<tr class="even">
<td><p>%</p>
<p>2</p>
<p>o</p></td>
<td>%2o</td>
</tr>
<tr class="odd">
<td><p>1</p>
<p>5</p>
<p>p</p></td>
<td>15p</td>
</tr>
</tbody>
</table>

## Lower or Upper

Write a program that prints whether a given character is upper-case or
lower case.

### Examples

| **Input** | **Output** |
| --------- | ---------- |
| L         | upper-case |
| f         | lower-case |

# Variables

## Refactor Volume of Pyramid 

You are given a **working code** that finds the **volume of a pyramid**.
However, you should consider that the variables exceed their optimum
span and have improper naming. Also, search for variables that **have
multiple purpose**.

### Hints

  - **Reduce the span** of the variables by declaring them in the moment
    they receive a value, not before

  - Rename your variables to **represent their** real **purpose**
    (example: "dul" should become length, etc.)

  - Search for variables that have multiple purpose. If you find any,
    **introduce a new variable**.

<table>
<thead>
<tr class="header">
<th><strong>Sample Code</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>double dul, sh, V = 0;</p>
<p>Console.WriteLine("Length: ");</p>
<p>dul = double.Parse(Console.ReadLine());</p>
<p>Console.WriteLine("Width: ");</p>
<p>sh = double.Parse(Console.ReadLine());</p>
<p>Console.WriteLine("Heigth: ");</p>
<p>V = double.Parse(Console.ReadLine());</p>
<p>V = (dul + sh + V) / 3;</p>
<p>Console.WriteLine($"Pyramid Volume: {V:f2}");</p></td>
</tr>
</tbody>
</table>

## Refactor Special Numbers

You are given a **working code** that is a solution to **Problem 5**.
**Special Numbers**. However, the variables are **improperly named,
declared before** they are needed and some of them are used for multiple
things. Without using your previous solution, **modify the code** so
that it is **easy to read and understand**.

<table>
<thead>
<tr class="header">
<th><strong>Sample Code</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>int kolkko = int.Parse(Console.ReadLine());</p>
<p>int obshto = 0;</p>
<p>int takova = 0;</p>
<p>bool toe = false;</p>
<p>for (int ch = 1; ch &lt;= kolkko; ch++)</p>
<p>{</p>
<p>takova = ch;</p>
<p>while (ch &gt; 0)</p>
<p>{</p>
<p>obshto += ch % 10;</p>
<p>ch = ch / 10;</p>
<p>}</p>
<p>toe = (obshto == 5) || (obshto == 7) || (obshto == 11);</p>
<p>Console.WriteLine("{0} -&gt; {1}", takova, toe);</p>
<p>obshto = 0;</p>
<p>ch = takova;</p>
<p>}</p></td>
</tr>
</tbody>
</table>

### Hints

  - Reduce the span of the variables by declaring them in the moment
    they receive a value, not before

  - Rename your variables to represent their real purpose (example:
    "toe" should become isSpecialNum, etc.)

  - Search for variables that have multiple purpose. If you find any,
    introduce a new variable
