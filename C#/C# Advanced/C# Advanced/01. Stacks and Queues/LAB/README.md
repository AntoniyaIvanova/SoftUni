# Lab: Stacks and Queues

Problems for exercises and homework for the
[<span class="underline">"CSharp Advanced" course @ Software
University</span>](https://softuni.bg/courses/csharp-advanced).

You can check your solutions here:
<https://judge.softuni.bg/Contests/1445/Stacks-and-Queues-Lab>

# Working with Stacks

## Reverse Strings

Write program that:

  - **Reads** an **input string**

  - **Reverses** it **using a Stack\<T\>**

  - **Prints** the result back at the terminal

### Examples

| **Input**             | **Output**            |
| --------------------- | --------------------- |
| I Love C\#            | **\#C evoL I**        |
| **Stacks and Queues** | **seueuQ dna skcatS** |

### Hints

  - Use a **Stack\<string\>**

  - Use the methods **Push()**, **Pop()**

## Stack Sum

Write program that:

  - **Reads** an **input of integer numbers** and **adds** them to a
    **stack**

  - **Reads commands** until **"end"** is received

  - **Prints** the **sum** of the remaining elements of the **stack**

### Input

  - On the **first** **line** you will receive **an array of integers**

  - On the **next** **lines**, until the "**end**" command is given, you
    will receive **commands** – a **single** **command** and **one** or
    **two** numbers after the **command, depending** on what **command**
    you are given

  - If the **command** is "**add**", you will **always** receive
    **exactly two** numbers after the command which you need to **add**
    in the **stack**

  - If the **command** is "**remove**", you will **always** receive
    **exactly** **one** number after the command which represents the
    **count** of the numbers you need to **remove** from the **stack.**
    If there are **not enough elements** skip the command.

### Output

  - When the **command** "**end**" is received, you need to **print the
    sum** of the **remaining** elements in the **stack**

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
<td><p><strong>1 2 3 4</strong></p>
<p><strong>adD 5 6</strong></p>
<p>REmove 3</p>
<p>eNd</p></td>
<td><strong>Sum: 6</strong></td>
</tr>
<tr class="even">
<td><p><strong>3 5 8 4 1 9</strong></p>
<p><strong>add 19 32</strong></p>
<p><strong>remove 10</strong></p>
<p><strong>add 89 22</strong></p>
<p><strong>remove 4</strong></p>
<p><strong>remove 3</strong></p>
<p><strong>end</strong></p></td>
<td><strong>Sum: 16</strong></td>
</tr>
</tbody>
</table>

### Hints

  - Use a **Stack\<int\>**

  - Use the methods **Push()**, **Pop()**

  - Commands **may** be given in **mixed case**

## Simple Calculator

**Create a simple calculator** that can **evaluate simple expressions**
with only addition and subtraction. There will not be any parentheses.

Solve the problem **using a Stack**.

### Examples

| **Input**              | **Output** |
| ---------------------- | ---------- |
| **2 + 5 + 10 - 2 - 1** | **14**     |
| **2 - 2 + 5**          | **5**      |

### Hints

  - Use a **Stack\<string\>**

  - You can either
    
      - add the elements and then **Pop()** them out
    
      - or **Push()** them and reverse the stack

## Matching Brackets

We are given an arithmetic expression with brackets. Scan through the
string and extract each sub-expression.

Print the result back at the terminal.

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
<td><strong>1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5</strong></td>
<td><p><strong>(2 + 3)</strong></p>
<p><strong>(3 + 1)</strong></p>
<p><strong>(2 - (2 + 3) * 4 / (3 + 1))</strong></p></td>
</tr>
<tr class="even">
<td><strong>(2 + 3) - (2 + 3)</strong></td>
<td><p><strong>(2 + 3)</strong></p>
<p><strong>(2 + 3)</strong></p></td>
</tr>
</tbody>
</table>

### Hints

  - Scan through the expression searching for brackets
    
      - If you find an opening bracket, push the index into the stack
    
      - If you find a closing bracket pop the topmost element from the
        stack. This is the index of the opening bracket.
    
      - Use the current and the popped index to extract the
        sub-expression

# Working with Queues

## Print Even Numbers

Write program that:

  - **Reads** an array of **integers** and **adds** them to a **queue**

  - **Prints** the **even** numbers **separated** by "**,** "

### Examples

| **Input**                   | **Output**         |
| --------------------------- | ------------------ |
| **1 2 3 4 5 6**             | **2, 4, 6**        |
| **11 13 18 95 2 112 81 46** | **18, 2, 112, 46** |

### Hints

  - Use a **Queue\<int\>**

  - Use the methods **Enqueue()**, **Dequeue(), Peek()**

## Supermarket

**Reads** an **input** consisting of a **name** and **adds** it to a
**queue** until "**End**" is received. If you receive "Paid", **print**
every customer name and empty the queue, otherwise we receive a client
and we have to add him to the queue. When we receive **"End"** we have
to print the count of the remaining people in the queue in the format:
"**{count} people remaining.".**

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
<td><p><strong>Liam</strong></p>
<p><strong>Noah</strong></p>
<p><strong>James</strong></p>
<p><strong>Paid</strong></p>
<p><strong>Oliver</strong></p>
<p><strong>Lucas</strong></p>
<p><strong>Logan</strong></p>
<p><strong>Tiana</strong></p>
<p><strong>End</strong></p></td>
<td><p><strong>Liam</strong></p>
<p><strong>Noah</strong></p>
<p><strong>James</strong></p>
<p><strong>4 people remaining.</strong></p></td>
</tr>
<tr class="even">
<td><p><strong>Amelia</strong></p>
<p><strong>Thomas</strong></p>
<p><strong>Elias</strong></p>
<p><strong>End</strong></p></td>
<td><strong>3 people remaining.</strong></td>
</tr>
</tbody>
</table>

## Hot Potato

Hot potato is a game in which **children form a circle and start passing
a hot potato**. The counting starts with the fist kid. **Every
n<sup>th</sup> toss the child left with the potato leaves the game**.
When a kid leaves the game, it passes the potato along. This continues
**until there is only one kid left**.

Create a program that simulates the game of Hot Potato. **Print every
kid that is removed from the circle**. In the end, **print the kid that
is left last**.

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
<td><p>Alva James William</p>
<p>2</p></td>
<td><p>Removed James</p>
<p>Removed Alva</p>
<p>Last is William</p></td>
</tr>
<tr class="even">
<td><p>Lucas Jacob Noah Logan Ethan</p>
<p>10</p></td>
<td><p>Removed Ethan</p>
<p>Removed Jacob</p>
<p>Removed Noah</p>
<p>Removed Lucas</p>
<p>Last is Logan</p></td>
</tr>
<tr class="odd">
<td><p>Carter Dylan Jack Luke Gabriel</p>
<p>1</p></td>
<td><p>Removed Carter</p>
<p>Removed Dylan</p>
<p>Removed Jack</p>
<p>Removed Luke</p>
<p>Last is Gabriel</p></td>
</tr>
</tbody>
</table>

## Traffic Jam

Create a program that simulates the **queue** that forms during a
**traffic** **jam**. During a traffic jam only **N** cars can **pass**
the crossroads when the **light** **goes** **green**. Then the program
reads the **vehicles** that **arrive** one by one and **adds** them to
the **queue**. When the light **goes** **green** **N** number of cars
**pass** the crossroads and **for** **each** a **message** "{car}
passed\!" is displayed. When the "**end**" command is given,
**terminate** the program and **display** a **message** with the
**total** **number** of cars that **passed** the crossroads.

### Input

  - On the **first** **line** you will receive **N** – the number of
    cars that can pass during a green light

  - On the **next** **lines**, until the "**end**" command is given, you
    will receive **commands** – a **single** **string**, either a
    **car** or "**green**"

### Output

  - Every time the "**green**" command is given, **print** **out** a
    message for **every** **car** that **passes** the crossroads in the
    format "{car} passed\!"

  - When the "**end**" command is given, **print** **out** a message in
    the format "{number of cars} cars passed the crossroads."

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
<p>Hummer H2</p>
<p>Audi</p>
<p>Lada</p>
<p>Tesla</p>
<p>Renault</p>
<p>Trabant</p>
<p>Mercedes</p>
<p>MAN Truck</p>
<p>green</p>
<p>green</p>
<p>Tesla</p>
<p>Renault</p>
<p>Trabant</p>
<p>end</p></td>
<td><p>Hummer H2 passed!</p>
<p>Audi passed!</p>
<p>Lada passed!</p>
<p>Tesla passed!</p>
<p>Renault passed!</p>
<p>Trabant passed!</p>
<p>Mercedes passed!</p>
<p>MAN Truck passed!</p>
<p>8 cars passed the crossroads.</p></td>
</tr>
<tr class="even">
<td><p>3</p>
<p>Enzo's car</p>
<p>Jade's car</p>
<p>Mercedes CLS</p>
<p>Audi</p>
<p>green</p>
<p>BMW X5</p>
<p>green</p>
<p>end</p></td>
<td><p>Enzo's car passed!</p>
<p>Jade's car passed!</p>
<p>Mercedes CLS passed!</p>
<p>Audi passed!</p>
<p>BMW X5 passed!</p>
<p>5 cars passed the crossroads.</p></td>
</tr>
</tbody>
</table>
