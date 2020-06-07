# More Exercise: Methods

Problems for exercise and homework for the ["C\# Fundamentals" course @
SoftUni](https://softuni.bg/modules/57/tech-module-4-0)  
You can check your solutions in
[Judge](https://judge.softuni.bg/Contests/1287)

## Data Types

Write a program that, depending on the first line of the input, reads
an **int**, **double** or **string**.

  - If the data type is **int**, multiply the number by 2.

  - If the data type is **real**, multiply the number by 1.5 and format
    it to the second decimal point.

  - If the data type is **string**, surround the input with "$".

Print the result on the console.

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
<td><p>int</p>
<p>5</p></td>
<td>10</td>
</tr>
<tr class="even">
<td><p>real</p>
<p>2</p></td>
<td>3.00</td>
</tr>
<tr class="odd">
<td><p>string</p>
<p>hello</p></td>
<td>$hello$</td>
</tr>
</tbody>
</table>

### Hint

Try to solve the problem using only one method with different overloads.

## Center Point

You are given the coordinates of two points on a [Cartesian coordinate
system](https://en.wikipedia.org/wiki/Cartesian_coordinate_system) - X1,
Y1, X2 and Y2. **Create a method** that prints the point that is closest
to the center of the coordinate system (0, 0) in the format (X, Y). If
the points are on a same distance from the center, print only the first
one.

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
<td><p><strong>2</strong></p>
<p><strong>4</strong></p>
<p><strong>-1</strong></p>
<p><strong>2</strong></p></td>
<td><strong>(-1, 2)</strong></td>
</tr>
</tbody>
</table>

## Longer Line

You are given the coordinates of four points in the 2D plane. The first
and the second pair of points form two different lines. Print the longer
line in format "(X1, Y1)(X2, Y2)" starting with the point that is closer
to the center of the coordinate system (0, 0) (You can reuse the method
that you wrote for the previous problem). If the lines are of equal
length, print only the first one.

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
<td><p><strong>2</strong></p>
<p><strong>4</strong></p>
<p><strong>-1</strong></p>
<p><strong>2</strong></p>
<p><strong>-5</strong></p>
<p><strong>-5</strong></p>
<p><strong>4</strong></p>
<p><strong>-3</strong></p></td>
<td><strong>(4, -3)(-5, -5)</strong></td>
</tr>
</tbody>
</table>

## Tribonacci Sequence

In the **"Tribonacci" sequence**, every number is formed by the **sum of
the previous 3**.

You are given a number **num**. Write a program that prints **num**
numbers from the Tribonacci sequence, each on a new line, starting from
1. The input comes as a parameter named **num**. The value **num** will
always be positive integer.

### Examples

| **Input** | **Output** |  | **Input** | **Output**         |
| --------- | ---------- |  | --------- | ------------------ |
| 4         | 1 1 2 4    |  | 8         | 1 1 2 4 7 13 24 44 |

## Multiplication Sign

You are given a number **num1**, **num2** and **num3**. Write a program
that finds if **num1 \* num2 \* num3** (the product) is **negative**,
**positive or zero**. Try to do this **WITHOUT** multiplying the 3
numbers.

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
<td><p>2</p>
<p>3</p>
<p>-1</p></td>
<td>negative</td>
<td></td>
<td><p>2</p>
<p>3</p>
<p>1</p></td>
<td>positive</td>
</tr>
</tbody>
</table>
