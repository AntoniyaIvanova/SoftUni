# Lab: Functional Programming

Problems for the [.](https://softuni.bg/courses/csharp-advanced)

You can check your solutions here:
<https://judge.softuni.bg/Contests/1472/Functional-Programming-Lab>

## Sort Even Numbers

Write a program that reads one line of **integers** separated by **",
"**. Then prints the **even numbers** of that sequence **sorted** in
**increasing** order.

### Examples

| **Input**                     | **Output**     |  | **Input** | **Output** |  | **Input** | **Output** |
| ----------------------------- | -------------- |  | --------- | ---------- |  | --------- | ---------- |
| 4, 2, 1, 3, 5, 7, 1, 4, 2, 12 | 2, 2, 4, 4, 12 |  | 1, 3, 5   |            |  | 2, 4, 6   | 2, 4, 6    |

### Hint

It is up to you what type of data structures you will use to solve this
problem. Use functional programming filter and sort the collection of
numbers.

## Sum Numbers

Write a program that reads a line of **integers** separated by **", "**.
Print on two lines the **count** of numbers and their **sum.**

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
<td>4, 2, 1, 3, 5, 7, 1, 4, 2, 12</td>
<td><p>10</p>
<p>41</p></td>
</tr>
<tr class="even">
<td>2, 4, 6</td>
<td><p>3</p>
<p>12</p></td>
</tr>
</tbody>
</table>

## Count Uppercase Words

Write a program that reads a line of **text** from the console. Print
**all** the words that start with an **uppercase letter** in the **same
order** you've received them in the text.

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
<td>The following example shows how to use Function</td>
<td><p>The</p>
<p>Function</p></td>
</tr>
<tr class="even">
<td>Write a program that reads one line of text from console. Print count of words that start with Uppercase, after that print all those words in the same order like you find them in text.</td>
<td><p>Write</p>
<p>Print</p>
<p>Uppercase,</p></td>
</tr>
</tbody>
</table>

### Hint

Use **Func\<string, bool\>** and use **" "** for splitting words.

## Add VAT

Write a program that reads one line of **double** prices separated by
**", "**. Print the **prices** with **added** **VAT** for all of them.
**Format** them to **2** **signs** after the decimal point. The
**order** of the prices must be the **same**.  
VAT is equal to 20% of the price.

### Examples

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th></th>
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>1.38, 2.56, 4.4</strong></td>
<td><p><strong>1.66</strong></p>
<p><strong>3.07</strong></p>
<p><strong>5.28</strong></p></td>
<td></td>
<td><strong>1, 3, 5, 7</strong></td>
<td><p><strong>1.20</strong></p>
<p><strong>3.60</strong></p>
<p><strong>6.00</strong></p>
<p><strong>8.40</strong></p></td>
</tr>
</tbody>
</table>

## Filter by Age

Write a program that receives an integer **N** on first line. On the
next **N** lines, read pairs of **"\[name\], \[age\]".** Then read three
lines with:

  - **Condition** - "**younger**" or "**older**"

  - **Age** - Integer

  - **Format** - "**name**", "**age**" or "**name** **age**"

Depending on the **condition**, print the correct **pairs** in the
correct **format**. **Don’t use the built-in functionality from .NET.
Create your own methods.**

### Examples

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th></th>
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th></th>
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>5</p>
<p>Lucas, 20<br />
Tomas, 18<br />
Mia, 29<br />
Noah, 31<br />
Simo, 16</p>
<p>older</p>
<p>20</p>
<p>name age</p></td>
<td><p>Lucas - 20</p>
<p>Mia - 29</p>
<p>Noah - 31</p></td>
<td></td>
<td><p>5</p>
<p>Lucas, 20<br />
Tomas, 18<br />
Mia, 29<br />
Noah, 31<br />
Simo, 16</p>
<p>younger</p>
<p>20</p>
<p>name</p></td>
<td><p>Tomas</p>
<p>Simo</p></td>
<td></td>
<td><p>5</p>
<p>Lucas, 20<br />
Tomas, 18<br />
Mia, 29<br />
Noah, 31<br />
Simo, 16</p>
<p>younger</p>
<p>50</p>
<p>age</p></td>
<td><p>20</p>
<p>18</p>
<p>29</p>
<p>31</p>
<p>16</p></td>
</tr>
</tbody>
</table>
