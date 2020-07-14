# Lab: Encapsulation

Problems for exercises and homework for the ["C\# OOP" course @
SoftUni"](https://softuni.bg/trainings/2244/csharp-oop-february-2019).

You can check your solutions here:
<https://judge.softuni.bg/Contests/1497/Encapsulation-Lab>

## Sort Persons by Name and Age

**NOTE**: You need a public **StartUp** class with the namespace
**PersonsInfo**.

Create a class **Person**, which should have **public** properties with
**private** setters for:

  - > **FirstName**: **string**

  - > **LastName**: **string**

  - > **Age**: **int**

  - > **ToString()**: **string** - **override**

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
<p>var lines = int.Parse(Console.ReadLine());</p>
<p>var persons = new List&lt;Person&gt;();</p>
<p>for (int i = 0; i &lt; lines; i++)</p>
<p>{</p>
<p>var cmdArgs = Console.ReadLine().Split();</p>
<p>var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));</p>
<p>persons.Add(person);</p>
<p>}</p>
<p>persons.OrderBy(p =&gt; p.FirstName)</p>
<p>.ThenBy(p =&gt; p.Age)</p>
<p>.ToList()</p>
<p>.ForEach(p =&gt; Console.WriteLine(p.ToString()));</p>
<p>}</p></td>
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
<td><p><strong>5</strong></p>
<p><strong>Asen Ivanov 65</strong></p>
<p><strong>Boiko Borisov 57</strong></p>
<p><strong>Ventsislav Ivanov 27</strong></p>
<p><strong>Asen Harizanoov 44</strong></p>
<p><strong>Boiko Angelov 35</strong></p></td>
<td><p><strong>Asen Harizanoov is 44 years old.</strong></p>
<p><strong>Asen Ivanov is 65 years old.</strong></p>
<p><strong>Boiko Angelov is 35 years old.</strong></p>
<p><strong>Boiko Borisov is 57 years old.</strong></p>
<p><strong>Ventsislav Ivanov is 27 years old.</strong></p></td>
</tr>
</tbody>
</table>

### Solution

Create a **new class** and ensure **proper naming**. Define the
**public** properties:

![](./media/image1.png)

Create a constructor for Person, which takes 3 parameters firstName,
lastName, age:

![](./media/image2.png)

Override **ToString()** method:

![](./media/image3.png)

## Salary Increase

**NOTE**: You need a public **StartUp** class with the namespace
**PersonsInfo**.

**Refactor the project from the last task.**

Read a Person with their names, age and salary. Read the percentage of
the bonus to every Person salary. People younger than 30 **get half the
increase**. Expand **Person** from the previous task.

New **properties** and **methods:**

  - **Salary**: **decimal**

  - > **IncreaseSalary**(**decimal** **percentage**)

You should be able to use the class like this:

<table>
<thead>
<tr class="header">
<th>StartUp.cs</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>var lines = int.Parse(Console.ReadLine());</p>
<p>var persons = new List&lt;Person&gt;();</p>
<p>for (int i = 0; i &lt; lines; i++)</p>
<p>{</p>
<p>var cmdArgs = Console.ReadLine().Split();</p>
<p>var person = new Person(cmdArgs[0],</p>
<p>cmdArgs[1],</p>
<p>int.Parse(cmdArgs[2]),</p>
<p>decimal.Parse(cmdArgs[3]));</p>
<p>persons.Add(person);</p>
<p>}</p>
<p>var parcentage = decimal.Parse(Console.ReadLine());</p>
<p>persons.ForEach(p =&gt; p.IncreaseSalary(parcentage));</p>
<p>persons.ForEach(p =&gt; Console.WriteLine(p.ToString()));</p></td>
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
<td><p><strong>5</strong></p>
<p><strong>Asen Ivanov 65 2200</strong></p>
<p><strong>Boiko Borisov 57 3333</strong></p>
<p><strong>Ventsislav Ivanov 27 600</strong></p>
<p><strong>Asen Harizanoov 44 666.66</strong></p>
<p><strong>Boiko Angelov 35 559.4</strong></p>
<p><strong>20</strong></p></td>
<td><p><strong>Asen Ivanov receives 2640.00 leva.</strong></p>
<p><strong>Boiko Borisov receives 3999.60 leva.</strong></p>
<p><strong>Ventsislav Ivanov receives 660.00 leva.</strong></p>
<p><strong>Asen Harizanoov receives 799.99 leva.</strong></p>
<p><strong>Boiko Angelov receives 671.28 leva.</strong></p></td>
</tr>
</tbody>
</table>

### Solution

Add a new **public** property for **salary** and **refactor
constructor**. Add new **method**, which will **update** salary with a
bonus

![](./media/image4.png)

Refactor the **ToString()** method for this task.

## Validation of Data

**NOTE**: You need a public **StartUp** class with the namespace
**PersonsInfo**.

Expand Person with proper validation for every field:

  - **Names must be at least 3 symbols**

  - **Age must not be zero or negative**

  - **Salary can't be less than 460.0**

Print proper messages to the user:

  - **“Age cannot be zero or a negative integer\!”**

  - **“First name cannot contain fewer than 3 symbols\!”**

  - **“Last name cannot contain fewer than 3 symbols\!”**

  - **“Salary cannot be less than 460 leva\!”**

Use ArgumentExeption with messages from example.

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
<td><p><strong>5</strong></p>
<p><strong>Asen Ivanov -6 2200</strong></p>
<p><strong>B Borisov 57 3333</strong></p>
<p><strong>Ventsislav Ivanov 27 600</strong></p>
<p><strong>Asen H 44 666.66</strong></p>
<p><strong>Boiko Angelov 35 300</strong></p>
<p><strong>20</strong></p></td>
<td><p><strong>Age cannot be zero or a negative integer!</strong></p>
<p><strong>First name cannot contain fewer than 3 symbols!</strong></p>
<p><strong>Last name cannot contain fewer than 3 symbols!</strong></p>
<p><strong>Salary cannot be less than 460 leva!</strong></p>
<p><strong>Ventsislav Ivanov gets 660.00 leva.</strong></p></td>
</tr>
</tbody>
</table>

### Solution

Add validation to all of the setters in Person. Validation may look like
this or something similar:

![](./media/image5.png)

## First and Reserve Team

**NOTE**: You need a public **StartUp** class with the namespace
**PersonsInfo**.

Create a Team class. Add to this team all of the people you have
received. Those who are younger than 40 go to the first team, others go
to the reverse team. At the end print the sizes of the first and the
reserved team.

The class should have **private fields** for:

  - **name**: **string**

  - **firstTeam**: **List\<Person\>**

  - **reserveTeam**: **List\<Person\>**

The class should have **constructors**:

  - **Team(string name)**

The class should also have **public properties** for:

  - **FirstTeam: List\<Person\> (read only\!)**

  - **ReserveTeam: List\<Person\> (read only\!)**

And a method for adding players:

  - **AddPlayer**(**Person** **person**): **void**

You should be able to use the class like this:

![](./media/image6.png)

You should **NOT** be able to use the class like this:

![](./media/image7.png) ![](./media/image8.png)

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
<td><p><strong>5</strong></p>
<p><strong>Asen Ivanov 20 2200</strong></p>
<p><strong>Boiko Borisov 57 3333</strong></p>
<p><strong>Ventsislav Ivanov 27 600</strong></p>
<p><strong>Grigor Dimitrov 25 666.66</strong></p>
<p><strong>Boiko Angelov 35 555</strong></p></td>
<td><p><strong>First team has 4 players.</strong></p>
<p><strong>Reserve team has 1 players.</strong></p></td>
</tr>
</tbody>
</table>

### Solution

Add a new class Team. Its fields and **constructor** should look like:

![](./media/image9.png)

Properties for **FirstTeam** and **ReserveTeam** have only getters:

![](./media/image10.png)

There will be only one method, which adds players to teams:

![](./media/image11.png)
