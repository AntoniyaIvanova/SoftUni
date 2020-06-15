# More Exercises: Objects and Classes

Problems for exercise and homework for the ["C\# Fundamentals" course @
SoftUni](https://softuni.bg/trainings/2363/csharp-fundamentals-may-2019)  
You can check your solutions in
[Judge](https://judge.softuni.bg/Contests/1325)

## Company Roster

Define a class **Employee** that holds the following information: a
**name, a salary** and a **department**.

Your task is to write a program, which takes **N** lines of employees
from the console, calculates the department with the highest average
salary and prints for each employee in that department his **name and
salary** – **sorted by salary in descending order**. The **salary**
should be rounded to **two digits** after the decimal seperator.

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
<p>Pesho 120.00 Development</p>
<p>Toncho 333.33 Marketing</p>
<p>Ivan 840.20 Development</p>
<p>Gosho 0.20 Nowhere</p></td>
<td><p>Highest Average Salary: Development</p>
<p>Ivan 840.20</p>
<p>Pesho 120.00</p></td>
</tr>
<tr class="even">
<td><p>6</p>
<p>Stanimir 496.37 Coding</p>
<p>Yovcho 610.13 Sales</p>
<p>Toshko 609.99 Sales</p>
<p>Venci 0.02 BeerDrinking</p>
<p>Andrei 700.00 Coding</p>
<p>Popeye 13.3333 SpinachGroup</p></td>
<td><p>Highest Average Salary: Sales</p>
<p>Yovcho 610.13</p>
<p>Toshko 609.99</p></td>
</tr>
</tbody>
</table>

## Oldest Family Member

Create two classes – **Family** and **Person**. The **Person** class
should have **Name** and **Age** properties. The **Family** class should
have a **list of people**, a method for adding members (**void
AddMember(Person member)**) and a method, which returns **the oldest
family member (Person GetOldestMember()).** Write a program that reads
the names and ages of **N** people and **adds them to the family**. Then
**print** the **name** and **age** of the oldest member.

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
<p><strong>Pesho 3</strong></p>
<p><strong>Gosho 4</strong></p>
<p><strong>Annie 5</strong></p></td>
<td><strong>Annie 5</strong></td>
</tr>
<tr class="even">
<td><p><strong>5</strong></p>
<p><strong>Steve 10</strong></p>
<p><strong>Christopher 15</strong></p>
<p><strong>Annie 4</strong></p>
<p><strong>Ivan 35</strong></p>
<p><strong>Maria 34</strong></p></td>
<td><strong>Ivan 35</strong></td>
</tr>
</tbody>
</table>

## Speed Racing

Your task is to implement a program that keeps track of cars and their
fuel and supports methods for moving the cars. Define a class **Car**
that keeps a track of a car’s **model, fuel amount, fuel consumption per
kilometer** and **traveled distance**. A Car’s model is **unique** -
there will never be 2 cars with the same model.

On the first line of the input, you will receive a number **N** – the
number of cars you need to track. On each of the next **N** lines you
will receive information about cars in the following format **“\<Model\>
\<FuelAmount\> \<FuelConsumptionFor1km\>**”. All **cars start at 0
kilometers traveled**.

After the **N** lines, until the command **"End"** is received, you will
receive commands in the following format **"Drive \<CarModel\>
\<amountOfKm\>".** Implement a method in the **Car** class to calculate
whether or not a car can move that distance. If it can, the car’s **fuel
amount** should be **reduced** by the amount of **used** **fuel** and
its **traveled** **distance** should be increased by the number of the
**traveled kilometers**. Otherwise, the car should not move (its fuel
amount and the traveled distance should stay the same) and you should
print on the console “**Insufficient fuel for the drive**”. After the
**"End"** command is received, print **each car**, its **current fuel
amount** and the **traveled** **distance** in the format **"\<Model\>
\<fuelAmount\> \<distanceTraveled\>"**. Print the fuel amount rounded to
**two digits** after the decimal separator.

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
<td><p>2</p>
<p>AudiA4 23 0.3</p>
<p>BMW-M2 45 0.42</p>
<p>Drive BMW-M2 56</p>
<p>Drive AudiA4 5</p>
<p>Drive AudiA4 13</p>
<p>End</p></td>
<td><p>AudiA4 17.60 18</p>
<p>BMW-M2 21.48 56</p></td>
</tr>
<tr class="even">
<td><p>3</p>
<p>AudiA4 18 0.34</p>
<p>BMW-M2 33 0.41</p>
<p>Ferrari-488Spider 50 0.47</p>
<p>Drive Ferrari-488Spider 97</p>
<p>Drive Ferrari-488Spider 35</p>
<p>Drive AudiA4 85</p>
<p>Drive AudiA4 50</p>
<p>End</p></td>
<td><p>Insufficient fuel for the drive</p>
<p>Insufficient fuel for the drive</p>
<p>AudiA4 1.00 50</p>
<p>BMW-M2 33.00 0</p>
<p>Ferrari-488Spider 4.41 97</p></td>
</tr>
</tbody>
</table>

## Raw Data

You are the owner of a courier company and you want to make a system for
tracking your cars and their cargo. Define a class **Car** that holds an
information about **model, engine** and **cargo**. The **Engine** and
**Cargo** should be **separate classes**. Create a constructor that
receives all of the information about the **Car** and creates and
initializes its inner components (engine and cargo).

On the first line of input, you will receive a number **N** – the number
of cars you have. On each of the next **N** lines, you will receive the
following information about a car: **"\<Model\> \<EngineSpeed\>
\<EnginePower\> \<CargoWeight\> \<CargoType\>"**, where the **speed**,
**power** and **weight** are all **integers.**

After the **N** lines you will receive a single line with one of 2
commands: **"fragile"** or **"flamable"**. If the command is
**"fragile"** print all cars, whose **Cargo Type is "fragile"** with
**cargo,** whose **weight** **\< 1000**. If the command is
**"flamable"** print all of the cars whose **Cargo Type is "flamable"**
and have **Engine Power \> 250**. The cars should be printed in order of
appearing in the input.

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
<td><p>2</p>
<p>ChevroletAstro 200 180 1000 fragile</p>
<p>Citroen2CV 190 165 900 fragile</p>
<p>fragile</p></td>
<td>Citroen2CV</td>
</tr>
<tr class="even">
<td><p>4</p>
<p>ChevroletExpress 215 255 1200 flamable</p>
<p>ChevroletAstro 210 230 1000 flamable</p>
<p>DaciaDokker 230 275 1400 flamable</p>
<p>Citroen2CV 190 165 1200 fragile</p>
<p>flamable</p></td>
<td><p>ChevroletExpress</p>
<p>DaciaDokker</p></td>
</tr>
</tbody>
</table>

## Shopping Spree

Create two classes: **class** **Person** and **class** **Product**. Each
person should have a **name**, **money** and a **bag** **of products**.
Each product should have a **name** and a **cost**.

Create a program, in which **each command** corresponds to a **person
buying a product**. If the person can **afford** a product, **add** it
to his bag. If a person **doesn’t have enough** money, print an
**appropriate** **message**: **"{Person} can't afford {Product}"**.

On the **first two lines** you are given **all people** and **all
products**. After all purchases, print **every person** in the order of
**appearance** and **all products** that he has **bought,** also in
order of **appearance**. If **nothing was bought**, print the name of
the person followed by **"Nothing bought"**.

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
<td><p>Pesho=11;Gosho=4</p>
<p>Bread=10;Milk=2;</p>
<p>Pesho Bread</p>
<p>Gosho Milk</p>
<p>Gosho Milk</p>
<p>Pesho Milk</p>
<p>END</p></td>
<td><p>Pesho bought Bread</p>
<p>Gosho bought Milk</p>
<p>Gosho bought Milk</p>
<p>Pesho can't afford Milk</p>
<p>Pesho - Bread</p>
<p>Gosho - Milk, Milk</p></td>
</tr>
<tr class="even">
<td><p>Mimi=0</p>
<p>Kafence=2</p>
<p>Mimi Kafence</p>
<p>END</p></td>
<td><p>Mimi can't afford Kafence</p>
<p>Mimi – Nothing bought</p></td>
</tr>
</tbody>
</table>
