# Lab: Sets and Dictionaries Advanced

Problems for exercises and homework for the ["C\# Advanced" course @
SoftUni](https://softuni.bg/courses/csharp-advanced).

You can check your solutions here:
<https://judge.softuni.bg/Contests/1465/Sets-and-Dictionaries-Advanced-Lab>

## Dictionaries

### Count Same Values in Array

Write a program that counts in a given array of double values the number
of occurrences of each value.

#### Examples

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>-2.5 4 3 -2.5 -5.5 4 3 3 -2.5 3</td>
<td><p><strong>-2.5 - 3 times</strong></p>
<p><strong>4 - 2 times</strong></p>
<p><strong>3 - 4 times</strong></p>
<p><strong>-5.5 - 1 times</strong></p></td>
</tr>
<tr class="even">
<td>2 4 4 5 5 2 3 3 4 4 3 3 4 3 5 3 2 5 4 3</td>
<td><p>2 - 3 times</p>
<p>4 - 6 times</p>
<p>5 - 4 times</p>
<p>3 - 7 times</p></td>
</tr>
</tbody>
</table>

### Average Student Grades

Write a program, which reads a **name** of a student and his/her
**grades** and **adds** them to the **student record**, then **prints**
**the** student's **names** with their **grades** and their **average
grade**.

#### Examples

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>7</p>
<p>Ivancho 5.20</p>
<p>Mariika 5.50</p>
<p>Ivancho 3.20</p>
<p>Mariika 2.50</p>
<p>Stamat 2.00</p>
<p>Mariika 3.46</p>
<p>Stamat 3.00</p></td>
<td><p>Ivancho -&gt; 5.20 3.20 (avg: 4.20)</p>
<p>Mariika -&gt; 5.50 2.50 3.46 (avg: 3.82)</p>
<p>Stamat -&gt; 2.00 3.00 (avg: 2.50)</p></td>
</tr>
<tr class="even">
<td><p>4</p>
<p>Vladimir 4.50</p>
<p>Petko 3.00</p>
<p>Vladimir 5.00</p>
<p>Petko 3.66</p></td>
<td><p>Vladimir -&gt; 4.50 5.00 (avg: 4.75)</p>
<p>Petko -&gt; 3.00 3.66 (avg: 3.33)</p></td>
</tr>
<tr class="odd">
<td><p>5</p>
<p>Gosho 6.00</p>
<p>Gosho 5.50</p>
<p>Gosho 6.00</p>
<p>Ivan 4.40</p>
<p>Petko 3.30</p></td>
<td><p>Gosho -&gt; 6.00 5.50 6.00 (avg: 5.83)</p>
<p>Ivan -&gt; 4.40 (avg: 4.40)</p>
<p>Petko -&gt; 3.30 (avg: 3.30)</p></td>
</tr>
</tbody>
</table>

#### Hints

  - Use a **dictionary** (**string** **List\<decimal\>**)

  - Check if the name **exists** before adding the grade. If it doesn’t,
    add it to the dictionary.

  - Pass through all **key-value pairs** in the dictionary and print the
    results. You can use the **.Average()** method to quickly calculate
    the average value from a list.

### Product Shop

Write a program that prints information about **food shops** in Sofia
and the **products** they **store**. Until the "**Revision**" command is
received, you will be receiving input in the format: **"{shop},
{product}, {price}"**. Keep in mind that if you receive a **shop** you
already **have** **received**, you must **collect** its **product**
**information**.

Your output must be **ordered** by shop **name** and must be in the
format:

{shop}-\>

Product: {product}, Price: {price}

#### Examples

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>lidl, juice, 2.30</p>
<p>fantastico, apple, 1.20</p>
<p>kaufland, banana, 1.10</p>
<p>fantastico, grape, 2.20</p>
<p>Revision</p></td>
<td><p>fantastico-&gt;</p>
<p>Product: apple, Price: 1.2</p>
<p>Product: grape, Price: 2.2</p>
<p>kaufland-&gt;</p>
<p>Product: banana, Price: 1.1</p>
<p>lidl-&gt;</p>
<p>Product: juice, Price: 2.3</p></td>
</tr>
<tr class="even">
<td><p>tmarket, peanuts, 2.20</p>
<p>GoGrill, meatballs, 3.30</p>
<p>GoGrill, HotDog, 1.40</p>
<p>tmarket, sweets, 2.20</p>
<p>Revision</p></td>
<td><p>GoGrill-&gt;</p>
<p>Product: meatballs, Price: 3.3</p>
<p>Product: HotDog, Price: 1.4</p>
<p>tmarket-&gt;</p>
<p>Product: peanuts, Price: 2.2</p>
<p>Product: sweets, Price: 2.2</p></td>
</tr>
</tbody>
</table>

### Cities by Continent and Country

Write a program that reads **continents**, **countries** and their
**cities**, puts them in a **nested dictionary** and **prints** them.

#### Examples

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>9</p>
<p>Europe Bulgaria Sofia</p>
<p>Asia China Beijing</p>
<p>Asia Japan Tokyo</p>
<p>Europe Poland Warsaw</p>
<p>Europe Germany Berlin</p>
<p>Europe Poland Poznan</p>
<p>Europe Bulgaria Plovdiv</p>
<p>Africa Nigeria Abuja</p>
<p>Asia China Shanghai</p></td>
<td><p>Europe:</p>
<p>Bulgaria -&gt; Sofia, Plovdiv</p>
<p>Poland -&gt; Warsaw, Poznan</p>
<p>Germany -&gt; Berlin</p>
<p>Asia:</p>
<p>China -&gt; Beijing, Shanghai</p>
<p>Japan -&gt; Tokyo</p>
<p>Africa:</p>
<p>Nigeria -&gt; Abuja</p></td>
</tr>
<tr class="even">
<td><p>3</p>
<p>Europe Germany Berlin</p>
<p>Europe Bulgaria Varna</p>
<p>Africa Egypt Cairo</p></td>
<td><p>Europe:</p>
<p>Germany -&gt; Berlin</p>
<p>Bulgaria -&gt; Varna</p>
<p>Africa:</p>
<p>Egypt -&gt; Cairo</p></td>
</tr>
<tr class="odd">
<td><p>8</p>
<p>Africa Somalia Mogadishu</p>
<p>Asia India Mumbai</p>
<p>Asia India Delhi</p>
<p>Europe France Paris</p>
<p>Asia India Nagpur</p>
<p>Europe Germany Hamburg</p>
<p>Europe Poland Gdansk</p>
<p>Europe Germany Danzig</p></td>
<td><p>Africa:</p>
<p>Somalia -&gt; Mogadishu</p>
<p>Asia:</p>
<p>India -&gt; Mumbai, Delhi, Nagpur</p>
<p>Europe:</p>
<p>France -&gt; Paris</p>
<p>Germany -&gt; Hamburg, Danzig</p>
<p>Poland -&gt; Gdansk</p></td>
</tr>
</tbody>
</table>

#### Hints

  - Use a **nested** **dictionary** (**string** (**Dictionary
    List\<string\>)**)

  - Check if the continent exists before adding the country. If it
    doesn’t, add it to the dictionary.

  - Check if the country exists, before adding the city. If it doesn’t,
    add it to the dictionary.

  - Pass through all **key-value pairs** in the dictionary and the
    values’ key-value pairs and print the results.

## Sets

### Record Unique Names

Write a program, which will take a list of **names** and print **only**
the **unique** names in the list.

#### Examples

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
<td><p>8</p>
<p>Ivan</p>
<p>Pesho</p>
<p>Ivan</p>
<p>Stamat</p>
<p>Pesho</p>
<p>Alice</p>
<p>Peter</p>
<p>Pesho</p></td>
<td><p>Ivan</p>
<p>Pesho</p>
<p>Stamat</p>
<p>Alice</p>
<p>Peter</p></td>
<td></td>
<td><p>7</p>
<p>Lyle</p>
<p>Bruce</p>
<p>Alice</p>
<p>Easton</p>
<p>Shawn</p>
<p>Alice</p>
<p>Shawn</p>
<p>Peter</p></td>
<td><p>Lyle</p>
<p>Bruce</p>
<p>Alice</p>
<p>Easton</p>
<p>Shawn</p></td>
<td></td>
<td><p>6</p>
<p>Roki</p>
<p>Roki</p>
<p>Roki<br />
Roki</p>
<p>Roki</p>
<p>Roki</p></td>
<td>Roki</td>
</tr>
</tbody>
</table>

#### Hints

You can store the names in a **HashSet\<string\>** to extract only the
unique ones.

### Parking Lot

Write a program that:

  - Records a **car number** for every car that enters the **parking
    lot**

  - Removes a **car number** when the car leaves the **parking lot**

The input will be a string in the format: **\[direction, carNumber\]**.
You will be receiving commands, until the **"END"** command is given.

Print the car numbers of the cars, which are still in the parking lot:

#### Examples

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><strong>IN, CA2844AA</strong></p>
<p><strong>IN, CA1234TA</strong></p>
<p><strong>OUT, CA2844AA</strong></p>
<p><strong>IN, CA9999TT</strong></p>
<p><strong>IN, CA2866HI</strong></p>
<p><strong>OUT, CA1234TA</strong></p>
<p><strong>IN, CA2844AA</strong></p>
<p><strong>OUT, CA2866HI</strong></p>
<p><strong>IN, CA9876HH</strong></p>
<p><strong>IN, CA2822UU</strong></p>
<p>END</p></td>
<td><p><strong>CA9999TT</strong></p>
<p><strong>CA2844AA</strong></p>
<p><strong>CA9876HH</strong></p>
<p><strong>CA2822UU</strong></p></td>
</tr>
<tr class="even">
<td><p><strong>IN, CA2844AA</strong></p>
<p><strong>IN, CA1234TA</strong></p>
<p><strong>OUT, CA2844AA</strong></p>
<p><strong>OUT, CA1234TA</strong></p>
<p><strong>END</strong></p></td>
<td><strong>Parking Lot is Empty</strong></td>
</tr>
</tbody>
</table>

#### Hints

  - Car numbers are **unique**

  - Before printing, **first** **check** if the set has any elements

#### Solution

You can help yourself with the code below:

![](./media/image1.png)

### SoftUni Party

#### There is a party in SoftUni. Many guests are invited and there are two types of them: VIP and Regular. When a guest comes, check if he/she exists in any of the two reservation lists.

All reservation numbers will be with the length of 8 chars.

All VIP numbers start with a digit.

First, you will be receiving the reservation numbers of the guests. You
can also receive 2 possible commands:

  - **"PARTY"** – After this command you will begin receiving the
    reservation numbers of the people, who actually came to the party.

  - **"END"** –The party is over and you have to stop the program and
    print the appropriate output.

In the end, print the count of the quests who didn't come to the party
and afterwards, print their reservation numbers. the VIP guests must be
first.

#### Examples

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><strong>7IK9Yo0h</strong></p>
<p><strong>9NoBUajQ</strong></p>
<p><strong>Ce8vwPmE</strong></p>
<p><strong>SVQXQCbc</strong></p>
<p><strong>tSzE5t0p</strong></p>
<p><strong>PARTY</strong></p>
<p><strong>9NoBUajQ</strong></p>
<p><strong>Ce8vwPmE</strong></p>
<p><strong>SVQXQCbc</strong></p>
<p><strong>END</strong></p></td>
<td><p><strong>2</strong></p>
<p><strong>7IK9Yo0h</strong></p>
<p><strong>tSzE5t0p</strong></p></td>
<td><p><strong>m8rfQBvl</strong></p>
<p><strong>fc1oZCE0</strong></p>
<p><strong>UgffRkOn</strong></p>
<p><strong>7ugX7bm0</strong></p>
<p><strong>9CQBGUeJ</strong></p>
<p><strong>2FQZT3uC</strong></p>
<p><strong>dziNz78I</strong></p>
<p><strong>mdSGyQCJ</strong></p>
<p><strong>LjcVpmDL</strong></p>
<p><strong>fPXNHpm1</strong></p>
<p><strong>HTTbwRmM</strong></p>
<p><strong>B5yTkMQi</strong></p>
<p><strong>8N0FThqG</strong></p>
<p><strong>xys2FYzn</strong></p>
<p><strong>MDzcM9ZK</strong></p>
<p><strong>PARTY</strong></p>
<p><strong>2FQZT3uC</strong></p>
<p><strong>dziNz78I</strong></p>
<p><strong>mdSGyQCJ</strong></p>
<p><strong>LjcVpmDL</strong></p>
<p><strong>fPXNHpm1</strong></p>
<p><strong>HTTbwRmM</strong></p>
<p><strong>B5yTkMQi</strong></p>
<p><strong>8N0FThqG</strong></p>
<p><strong>m8rfQBvl</strong></p>
<p><strong>fc1oZCE0</strong></p>
<p><strong>UgffRkOn</strong></p>
<p><strong>7ugX7bm0</strong></p>
<p><strong>9CQBGUeJ</strong></p>
<p><strong>END</strong></p></td>
<td><p><strong>2</strong></p>
<p><strong>xys2FYzn</strong></p>
<p><strong>MDzcM9ZK</strong></p></td>
</tr>
</tbody>
</table>
