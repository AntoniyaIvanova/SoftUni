# Lab: **Interfaces and Abstraction**

Problems for exercises and homework for the ["C\# OOP" course @
SoftUni"](https://softuni.bg/trainings/2244/csharp-oop-february-2019).

You can check your solutions here:
<https://judge.softuni.bg/Contests/1501/Interfaces-and-Abstraction-Lab>

## Shapes

**NOTE**: You need a public **StartUp** class with the namespace
**Shapes**.

Build hierarchy of interfaces and classes:

![C:\\Users\\david\\Desktop\\WINWORD\_2018-02-24\_13-45-17.png](./media/image1.png)

You should be able to use the class like this:

<table>
<thead>
<tr class="header">
<th>StartUp.cs</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>var radius = int.Parse(Console.ReadLine());</p>
<p>IDrawable circle = new Circle(radius);</p>
<p>var width = int.Parse(Console.ReadLine());</p>
<p>var height = int.Parse(Console.ReadLine());</p>
<p>IDrawable rect = new Rectangle(width, height);</p>
<p>circle.Draw();</p>
<p>rect.Draw();</p></td>
</tr>
</tbody>
</table>

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
<p><strong>4</strong></p>
<p><strong>5</strong></p></td>
<td><p><strong>*******</strong></p>
<p><strong>** **</strong></p>
<p><strong>** **</strong></p>
<p><strong>* *</strong></p>
<p><strong>** **</strong></p>
<p><strong>** **</strong></p>
<p><strong>*******</strong></p>
<p><strong>****</strong></p>
<p><strong>* *</strong></p>
<p><strong>* *</strong></p>
<p><strong>* *</strong></p>
<p><strong>****</strong></p></td>
</tr>
</tbody>
</table>

### Solution

The algorithm for drawing a circle is:

![](./media/image2.png)

The algorithm for drawing a rectangle is:

![](./media/image3.png)

## Cars

**NOTE**: You need a public **StartUp** class with the namespace
**Cars**.

Build a hierarchy of interfaces and classes:

![C:\\Users\\david\\Desktop\\WINWORD\_2018-02-24\_13-53-46.png](./media/image4.png)

Your hierarchy must be used with this code:

<table>
<thead>
<tr class="header">
<th>StartUp.cs</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>ICar seat = new Seat("Leon", "Grey");</p>
<p>ICar tesla = new Tesla("Model 3", "Red", 2);</p>
<p>Console.WriteLine(seat.ToString());</p>
<p>Console.WriteLine(tesla.ToString());</p></td>
</tr>
</tbody>
</table>

### Examples

<table>
<thead>
<tr class="header">
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><strong>Grey Seat Leon</strong></p>
<p><strong>Engine start</strong></p>
<p><strong>Breaaak!</strong></p>
<p><strong>Red Tesla Model 3 with 2 Batteries<br />
Engine start</strong></p>
<p><strong>Breaaak!</strong></p></td>
</tr>
</tbody>
</table>
