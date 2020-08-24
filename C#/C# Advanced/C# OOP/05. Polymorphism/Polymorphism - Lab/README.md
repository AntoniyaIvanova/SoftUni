# Lab: Polymorphism

Problems for exercises and homework for the ["C\# OOP" course @
SoftUni"](https://softuni.bg/trainings/2244/csharp-oop-february-2019).

You can check your solutions here:
<https://judge.softuni.bg/Contests/1503/Polymorphism-Lab>

## MathOperation

**NOTE**: You need a public **StartUp** class with the namespace
**Operations**.

Create a class **MathOperations**, which should have 3 times method
**Add().** Method **Add()** has to be invoked with:

  - Add(int, int): **int**

  - Add(double, double, double): **double**

  - Add(decimal, decimal, decimal): **decimal**

You should be able to use the class like this:

<table>
<thead>
<tr class="header">
<th>StartUp.cs</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>public static void Main()</p>
<p>{</p>
<p>MathOperations mo = new MathOperations();</p>
<p>Console.WriteLine(mo.Add(2, 3));</p>
<p>Console.WriteLine(mo.Add(2.2, 3.3, 5.5));</p>
<p>Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));</p>
<p>}</p></td>
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
<td><p><strong>5</strong></p>
<p><strong>11</strong></p>
<p><strong>9.9</strong></p></td>
</tr>
</tbody>
</table>

### Solution

Created MathOperation class should look like this:

![](./media/image1.png)

## Animals

**NOTE**: You need a public **StartUp** class with the namespace
**Animals**.

Create a class Animal, which holds two fields:

  - name: string

  - favouriteFood: string

Animal has one virtual method **ExplainSelf(): string.  
**You should add two new classes - **Cat** and **Dog. Override** the
**ExplainSelf()** method by adding concrete animal sound on a new line.
(Look at examples below)

You should be able to use the class like this:

<table>
<thead>
<tr class="header">
<th>StartUp.cs</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Animal cat = new Cat("Pesho", "Whiskas");</p>
<p>Animal dog = new Dog("Gosho", "Meat");</p>
<p>Console.WriteLine(cat.ExplainSelf());</p>
<p>Console.WriteLine(dog.ExplainSelf());</p></td>
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
<td><p><strong>I am Pesho and my fovourite food is Whiskas</strong></p>
<p><strong>MEEOW</strong></p>
<p><strong>I am Gosho and my fovourite food is Meat</strong></p>
<p><strong>DJAAF</strong></p></td>
</tr>
</tbody>
</table>

### Solution

![C:\\Users\\david\\Desktop\\devenv\_2018-02-28\_16-56-40.png](./media/image2.png)

![C:\\Users\\david\\Documents\\ShareX\\Screenshots\\2018-02\\devenv\_2018-02-28\_16-59-49.png](./media/image3.png)

## Shapes

**NOTE**: You need a public **StartUp** class with the namespace
**Shapes**.

Create a class hierarchy, starting with **abstract** class Shape:

  - **Abstract methods:**
    
      - **CalculatePerimeter(): doulbe**
    
      - **CalculateArea(): double**

  - **Virtual methods:**
    
      - **Draw(): string**

Extend the Shape class with two children:

  - **Rectangle**

  - **Circle**

Each of them need to have:

  - **Fields:**
    
      - **height and width for Rectangle**
    
      - **radius for Circle**

  - **Encapsulation for these fields**

  - **A public constructor**

  - **Concrete methods for calculations (perimeter and area)**

  - **Override methods for drawing**
