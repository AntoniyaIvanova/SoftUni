# Exercises: **Functional Programming**

Problems for exercises and homework for the
[.](https://softuni.bg/courses/csharp-advanced)

You can check your solutions here:
<https://judge.softuni.bg/Contests/1473/Functional-Programming-Exercises>

## Action Point

Write a program that reads a collection of **strings** from the console
and then **prints** them onto the **console**. Each name should be
printed on a **new** **line**. Use **Action\<T\>**.

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
<td>Lucas Noah Tea</td>
<td><p>Lucas</p>
<p>Noah</p>
<p>Tea</p></td>
</tr>
</tbody>
</table>

## Knights of Honor

Write a program that reads a collection of **names** as **strings** from
the **console**, appends "**Sir**" in front of every name and **prints**
it back on the **console**. Use **Action\<T\>**.

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
<td>Eathan Lucas Noah StanleyRoyce</td>
<td><p>Sir Eathan</p>
<p>Sir Lucas</p>
<p>Sir Noah</p>
<p>Sir StanleyRoyce</p></td>
</tr>
</tbody>
</table>

## Custom Min Function

Write a simple program that reads from the **console** a set of
**integers** and **prints** back on the **console** the **smallest**
**number** from the collection. Use **Func\<T, T\>**.

### Examples

| **Input**      | **Output** |
| -------------- | ---------- |
| 1 4 3 2 1 7 13 | 1          |

## Find Evens or Odds

You are given a lower and an upper bound for a range of integer numbers.
Then a command specifies if you need to list all even or odd numbers in
the given range. Use **Predicate\<T\>**.

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
<td><p>1 10</p>
<p>odd</p></td>
<td>1 3 5 7 9</td>
</tr>
<tr class="even">
<td><p>20 30</p>
<p>even</p></td>
<td>20 22 24 26 28 30</td>
</tr>
</tbody>
</table>

## Applied Arithmetics

Write a program that executes some mathematical operations on a given
collection. On the **first line** you are given **a list of numbers**.
On the **next lines** you are passed **different commands** that you
need to **apply to all the numbers** in the list:

  - **"add"** -\> add 1 to each number

  - **"multiply"** -\> multiply each number by 2

  - **"subtract"** -\> subtract 1 from each number

  - **"print"** -\> print the collection

  - "**end**" -\> ends the input

Use functions.

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
<td><p>1 2 3 4 5</p>
<p>add</p>
<p>add</p>
<p>print</p>
<p>end</p></td>
<td>3 4 5 6 7</td>
</tr>
<tr class="even">
<td><p>5 10</p>
<p>multiply</p>
<p>subtract</p>
<p>print</p>
<p>end</p></td>
<td>9 19</td>
</tr>
</tbody>
</table>

## Reverse and Exclude

Write a program that reverses a collection and removes elements that are
divisible by a given integer **n**. Use predicates/functions.

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
<td><p>1 2 3 4 5 6</p>
<p>2</p></td>
<td>5 3 1</td>
</tr>
<tr class="even">
<td><p>20 10 40 30 60 50</p>
<p>3</p></td>
<td>50 40 10 20</td>
</tr>
</tbody>
</table>

## Predicate for Names

Write a program that filters a list of names according to their length.
On the first line, you will be given an integer **n,** representing a
name's length. On the second line, you will be given some names as
strings separated by space. Write a function that prints only the names
whose length is **less than or equal** to **n**.

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
<td><p>4</p>
<p>Kurnelia Qnaki Geo Muk Ivan</p></td>
<td><p>Geo</p>
<p>Muk</p>
<p>Ivan</p></td>
</tr>
<tr class="even">
<td><p>4</p>
<p>Karaman Asen Kiril Yordan</p></td>
<td>Asen</td>
</tr>
</tbody>
</table>

## Custom Comparator

Write a custom comparator that sorts all even numbers before all the odd
ones in ascending order. Pass it to **Array.Sort()** function and print
the result. Use functions.

### Examples

| **Input**   | **Output**  |
| ----------- | ----------- |
| 1 2 3 4 5 6 | 2 4 6 1 3 5 |
| \-3 2       | 2 -3        |

## List of Predicates

Find all numbers in the range 1...N that are divisible by the numbers of
a given sequence. On the first line, you will be given an integer **N**
– which is the end of the range. On the second line, you will be given
a sequence of integers which are the dividers. Use predicates/functions.

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
<td><p>10</p>
<p>1 1 1 2</p></td>
<td>2 4 6 8 10</td>
</tr>
<tr class="even">
<td><p>100</p>
<p>2 5 10 20</p></td>
<td>20 40 60 80 100</td>
</tr>
</tbody>
</table>

## Predicate Party\!

Ivancho’s parents are on a vacation for the holidays and he is planning
an epic party at home. Unfortunately, his organizational skills are next
to non-existent, so you are given the task to help him with the
reservations.

On the **first line,** you receive a **list** **with all the people**
that are coming. On the **next lines**, until you get the **"Party\!"
command**, you may be asked to **double** or **remove** **all the
people** that apply to a given **criteria**. There are **three
different** **criteria**:

  - Everyone that has his **name** **starting** with a **given string**

  - Everyone that has a **name** **ending** with a **given string**

  - Everyone that has a **name** with a **given length**.

Finally, **print all the guests** who are going to the party **separated
by** ", " and then **add the ending** "are going to the party\!". If
there are **no guests** going to the party print "Nobody is going to the
party\!". See the examples below:

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
<td><p>Pesho Misho Stefan</p>
<p>Remove StartsWith P</p>
<p>Double Length 5</p>
<p>Party!</p></td>
<td>Misho, Misho, Stefan are going to the party!</td>
</tr>
<tr class="even">
<td><p>Pesho</p>
<p>Double StartsWith Pesh</p>
<p>Double EndsWith esho</p>
<p>Party!</p></td>
<td>Pesho, Pesho, Pesho, Pesho are going to the party!</td>
</tr>
<tr class="odd">
<td><p>Pesho</p>
<p>Remove StartsWith P</p>
<p>Party!</p></td>
<td>Nobody is going to the party!</td>
</tr>
</tbody>
</table>

## Party Reservation Filter Module

You need to implement a filtering module to a party reservation
software. First, to the Party Reservation Filter Module (PRFM for short)
is **passed a list** with invitations. Next the PRFM receives a
**sequence of commands** that specify whether you need to add or remove
a given filter.

Each PRFM command is in the given format:

"**{command;filter type;filter parameter}"**

You can receive the following PRFM commands:

  - "**Add filter**"

  - "**Remove filter**"

  - "**Print**"

The possible PRFM filter types are:

  - "**Starts with**"

  - "**Ends with**"

  - "**Length**"

  - "**Contains**"

All PRFM filter parameters will be a string (or an integer only for the
"**Length"** filter). Each command will be valid e.g. you won’t be asked
to remove a non-existent filter. The input will **end** with a
"**Print**" command, after which you should print all the party-goers
that are left after the filtration. See the examples below:

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
<td><p>Pesho Misho Slav</p>
<p>Add filter;Starts with;P</p>
<p>Add filter;Starts with;M</p>
<p>Print</p></td>
<td>Slav</td>
</tr>
<tr class="even">
<td><p>Pesho Misho Jica</p>
<p>Add filter;Starts with;P</p>
<p>Add filter;Starts with;M</p>
<p>Remove filter;Starts with;M</p>
<p>Print</p></td>
<td>Misho Jica</td>
</tr>
</tbody>
</table>

## TriFunction

Write a program that traverses a collection of names and returns the
**first name,** whose sum of characters is **equal** to or **larger**
than a given number **N,** which will be given on the first line. Use a
function that **accepts another function** as one of its parameters.
Start off by building a regular function to hold the basic logic of the
program. Something along the lines of **Func\<string, int, bool\>**.
Afterwards create your main function which should accept the first
function as one of its parameters.

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
<td><p>800</p>
<p>Qvor Qnaki Petromir Sadam</p></td>
<td>Petromir</td>
</tr>
</tbody>
</table>
