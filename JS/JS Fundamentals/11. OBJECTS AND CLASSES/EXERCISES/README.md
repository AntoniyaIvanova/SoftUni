# Exercise: Objects and Classes

Problems for exercise and homework for the ["JS Fundamentals" course @
SoftUni](https://softuni.bg/trainings/2343/js-fundamentals-may-2019).  
Submit your solutions in the SoftUni judge system at: [Objects and
Classes -
Exercise](https://judge.softuni.bg/Contests/1322/Objects-and-Classes-Exercise).

## Employees

You're tasked to create a list of employees and their personal numbers.

You will receive an array of strings. Each string is an employee
**name** and to assign them a personal number you have to find the
**length of the name** (whitespace included).

***Try to use an object***.

At the end print all the list employees in the following format:

**"Name: {employeeName} -- Personal Number: {personalNum}"**

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
<td><p>[</p>
<p>'Silas Butler',</p>
<p>'Adnaan Buckley',</p>
<p>'Juan Peterson',</p>
<p>'Brendan Villarreal'</p>
<p>]</p></td>
<td><p>Name: Silas Butler -- Personal Number: 12</p>
<p>Name: Adnaan Buckley -- Personal Number: 14</p>
<p>Name: Juan Peterson -- Personal Number: 13</p>
<p>Name: Brendan Villarreal -- Personal Number: 18</p></td>
</tr>
</tbody>
</table>

## Towns

You’re tasked to create and print **objects** from a text table.

You will receive input as an **array** of strings, where each string
represents a row of a table, with values on the row separated by pipes
**"|"** and spaces.

The table will consist of exactly 3 columns **"Town"**, **"Latitude"**
and **"Longitude"**. The **latitude** and **longitude** columns will
always contain **valid numbers**. Check the examples to get a better
understanding of your task.

The **output** should be **objects**. Latitude and longitude must be
parsed to **numbers and formatted to the second decimal point**\!

### Examples

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>['Sofia | 42.696552 | 23.32601',</p>
<p>'Beijing | 39.913818 | 116.363625'];</p></td>
</tr>
<tr class="even">
<td><strong>Output</strong></td>
</tr>
<tr class="odd">
<td><p>{ town: 'Sofia', latitude: '42.70', longitude: '23.33' }</p>
<p>{ town: 'Beijing', latitude: '39.91', longitude: '116.36' }</p></td>
</tr>
</tbody>
</table>

## Store Provision

You will receive **two arrays**. The first array represents a current
**stock** of the local store. The second array will contain **products**
which the store has **ordered** for delivery.

The following information applies to both arrays:

Every **even** index will hold the **name** of the **product** and on
every **odd** index will hold the **quantity** of that **product**. The
second array could contain products that are **already in** the local
store. If that happens **increase** the **quantity** for the given
product .You should store them into an **object**, and print them in the
following format: **(product -\> quantity)**

All of the arrays values will be **strings.**

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
<td><p>[</p>
<p>'Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Beer', '2'</p>
<p>],</p>
<p>[</p>
<p>'Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30'</p>
<p>]</p></td>
<td><p>Chips -&gt; 5</p>
<p>CocaCola -&gt; 9</p>
<p>Bananas -&gt; 44</p>
<p>Pasta -&gt; 11</p>
<p>Beer -&gt; 2</p>
<p>Flour -&gt; 44</p>
<p>Oil -&gt; 12</p>
<p>Tomatoes -&gt; 70</p></td>
</tr>
</tbody>
</table>

## Movies

Write a function that stores information about movies. The info will be
**name, director, date**. You can receive several types on input:

  - **"addMovie {movie name}"** – add the movie

  - **"{movie name} directedBy {director}"** – check if the movie
    **exists** and then add the director

  - **"{movie name} onDate {date}"** – check if the movie **exists** and
    then add the date

At the end print all the movies that have **all the info** (if the movie
has **no** director, name or date, **don’t** print it) in **JSON
format.**

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
<td><p>[</p>
<p>'addMovie Fast and Furious',</p>
<p>'addMovie Godfather',</p>
<p>'Inception directedBy <a href="https://www.imdb.com/name/nm0634240/?ref_=tt_ov_dr">Christopher Nolan</a>',</p>
<p>'Godfather directedBy <a href="https://www.imdb.com/name/nm0000338/?ref_=tt_ov_dr">Francis Ford Coppola</a>',</p>
<p>'Godfather onDate 29.07.2018',</p>
<p>'Fast and Furious onDate 30.07.2018',</p>
<p>'Batman onDate 01.08.2018',</p>
<p>'Fast and Furious directedBy <a href="https://www.imdb.com/name/nm0003418/?ref_=tt_ov_dr">Rob Cohen</a>'</p>
<p>]</p></td>
<td><p>{"name":"Fast and Furious","date":"30.07.2018","director":"Rob Cohen"}</p>
<p>{"name":"Godfather","director":"Francis Ford Coppola","date":"29.07.2018"}</p></td>
</tr>
</tbody>
</table>

## Inventory

Create a function which creates a **register for heroes**, with their
**names**, **level**, and **items** (if they have such).

The **input** comes as **array of strings**. Each element holds data for
a hero, in the following format:

“**{heroName} / {heroLevel} / {item1}, {item2}, {item3}...**”

You must store the data about every hero. The **name** is a **string**,
the **level** is a **number** and the items are all **strings.**

The **output** is all of the data for all the heroes you’ve stored
**sorted ascending by level** and **the items are sorted
alphabetically**. The data must be in the following format for each
hero:

**Hero: {heroName}**

**level =\> {heroLevel}**

**Items =\> {item1}, {item2}, {item3}**

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
<td><p>[</p>
<p>"Isacc / 25 / Apple, GravityGun",</p>
<p>"Derek / 12 / BarrelVest, DestructionSword",</p>
<p>"Hes / 1 / Desolator, Sentinel, Antara"</p>
<p>]</p></td>
<td><p>Hero: Hes</p>
<p>level =&gt; 1</p>
<p>items =&gt; Antara, Desolator, Sentinel</p>
<p>Hero: Derek</p>
<p>level =&gt; 12</p>
<p>items =&gt; BarrelVest, DestructionSword</p>
<p>Hero: Isacc</p>
<p>level =&gt; 25</p>
<p>items =&gt; Apple, GravityGun</p></td>
</tr>
</tbody>
</table>

## Make a Dictionary

You will receive an **array** with **strings in the form of JSON's.**

You have to parse these strings and combine them into **one object**.
Every string from the array will hold **terms** and a **description.**
If you receive the **same term** **twice** replace it with the **new
definition**.

Print every term and definition in that dictionary on new line in
format:

**Term: ${term} =\> Definition: ${definition}**

Don't forget to sort the dictionary **alphabetically** by the terms as
in real dictionaries.

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
<td><p>[</p>
<p>'{"Coffee":"A hot drink made from the roasted and ground seeds (coffee beans) of a tropical shrub."}',</p>
<p>'{"Bus":"A large motor vehicle carrying passengers by road, typically one serving the public on a fixed route and for a fare."}',</p>
<p>'{"Boiler":"A fuel-burning apparatus or container for heating water."}',</p>
<p>'{"Tape":"A narrow strip of material, typically used to hold or fasten something."}',</p>
<p>'{"Microphone":"An instrument for converting sound waves into electrical energy variations which may then be amplified, transmitted, or recorded."}'</p>
<p>]</p></td>
<td><p>Term: Boiler =&gt; Definition: A fuel-burning apparatus or container for heating water.</p>
<p>Term: Bus =&gt; Definition: A large motor vehicle carrying passengers by road, typically one serving the public on a fixed route and for a fare.</p>
<p>Term: Coffee =&gt; Definition: A hot drink made from the roasted and ground seeds (coffee beans) of a tropical shrub.</p>
<p>Term: Microphone =&gt; Definition: An instrument for converting sound waves into electrical energy variations which may then be amplified, transmitted, or recorded.</p>
<p>Term: Tape =&gt; Definition: A narrow strip of material, typically used to hold or fasten something.</p></td>
</tr>
</tbody>
</table>

## Class Vehicle

Create a class with name **Vehicle** that has the following properties:

  - **type** – a string

  - **model** – a string

  - **parts** – an object that contains:

<!-- end list -->

  - **engine** – number (quality of the engine)

  - **power** – number

  - **quality** – engine \* power

<!-- end list -->

  - **fuel** – a number

  - **drive** – a function that receives fuel loss and decreases the
    fuel of the vehicle by that number

The **constructor** should receive the **type**, the **model**, the
**parts** as an **object** and the **fuel**

In judge post your **class** (**Note: all names should be as
described**)

### Example

Test your Vehicle class

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>let parts = { engine: 6, power: 100 };</p>
<p>let vehicle = new Vehicle('a', 'b', parts, 200);</p>
<p>vehicle.drive(100);</p>
<p>console.log(vehicle.fuel);</p>
<p>console.log(vehicle.parts.quality);</p></td>
<td><p>100</p>
<p>600</p></td>
</tr>
</tbody>
</table>

## \*Class Storage

Create a **class** **Storage**. It should have the following
**properties**:

  - **capacity** – a number that **decreases when adding a given
    quantity** of products in storage

  - **storage** – **list of products** (object). **Each product** should
    have:

<!-- end list -->

  - **name** - a string

  - **price** – a number (price is for a single piece of product)

  - **quantity** – a number

<!-- end list -->

  - **totalCost** – sum of the cost of the products

  - **addProduct** – a function that receives a product and adds it to
    the storage

  - **getProcuts** – a function that returns all the products in storage
    in **JSON** format, each on a new line

The **constructor** should receive a **capacity**

Paste only the **class** **Storage in judge** (**Note: all names should
be as described**)

### Example

Test your Storage class

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>let productOne = {name: 'Cucamber', price: 1.50, quantity: 15};</p>
<p>let productTwo = {name: 'Tomato', price: 0.90, quantity: 25};</p>
<p>let productThree = {name: 'Bread', price: 1.10, quantity: 8};</p>
<p>let storage = new Storage(50);</p>
<p>storage.addProduct(productOne);</p>
<p>storage.addProduct(productTwo);</p>
<p>storage.addProduct(productThree);</p>
<p>storage.getProducts();</p>
<p>console.log(storage.capacity);</p>
<p>console.log(storage.totalCost);</p></td>
<td><p>{"name":"Cucamber","price":1.5,"quantity":15}</p>
<p>{"name":"Tomato","price":0.9,"quantity":25}</p>
<p>{"name":"Bread","price":1.1,"quantity":8}</p>
<p>2</p>
<p>53.8</p></td>
</tr>
</tbody>
</table>

## \*Catalogue

You have to create a sorted catalogue of store **products**. You will be
given the products’ **names** and **prices**. You need to order them by
**alphabetical order**.

The **input** comes as **array** of strings. Each element holds info
about a product in the following format:

“**{productName} : {productPrice}**”

The **product’s name** will be a **string**, which will **always**
**start with a capital letter**, and the **price** will be **a number**.
You can safely assume there will be **NO duplicate product input**. The
comparison for alphabetical order is **case-insensitive**.

As **output** you must print all the products in a specified format.
They must be ordered **exactly as specified above**. The products must
be **divided into groups**, by the **initial of their name**. The
**group’s initial should be printed**, and after that the products
should be printed with **2 spaces before their names**. For more info
check the examples.

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
<td><p>Appricot : 20.4</p>
<p>Fridge : 1500</p>
<p>TV : 1499</p>
<p>Deodorant : 10</p>
<p>Boiler : 300</p>
<p>Apple : 1.25</p>
<p>Anti-Bug Spray : 15</p>
<p>T-Shirt : 10</p></td>
<td><p><strong>A</strong></p>
<p><strong>Anti-Bug Spray: 15</strong></p>
<p><strong>Apple: 1.25</strong></p>
<p><strong>Appricot: 20.4</strong></p>
<p><strong>B</strong></p>
<p><strong>Boiler: 300</strong></p>
<p><strong>D</strong></p>
<p><strong>Deodorant: 10</strong></p>
<p><strong>F</strong></p>
<p><strong>Fridge: 1500</strong></p>
<p><strong>T</strong></p>
<p><strong>T-Shirt: 10</strong></p>
<p><strong>TV: 1499</strong></p></td>
</tr>
</tbody>
</table>

## 10\. \*Systems Register

You will be given a register of systems with components and
subcomponents. You need to build an **ordered** database of all the
elements that have been given to you.

The elements are registered in a very simple way. When you have
processed all of the input data, you must print them in a specific
order. For every **System** you must print its components in a specified
order, and for every Component, you must print its Subcomponents in a
specified order.

The **Systems** you’ve stored must be ordered by **amount of
components**, in **descending order**, as **first criteria**, and by
**alphabetical order** as **second criteria**. The **Components** must
be ordered by **amount of Subcomponents**, in **descending order**.

The **input** comes as array of strings. Each element holds **data**
about a **system**, a **component** in that **system**, and a
**subcomponent** in that **component**. If the given **system already
exists**, you should just **add the new component** to it. If even the
**component exists**, you should just **add** the **new subcomponent**
to it. The **subcomponents** will **always be** **unique**. The input
format is:

“**{systemName} | {componentName} | {subcomponentName}**”

All of the elements are strings, and can contain **any ASCII
character**. The **string comparison** for the alphabetical order is
**case-insensitive**.

As **output** you need to print all of the elements, ordered exactly in
the way specified above. The format is:

“{systemName}

|||{componentName}

|||{component2Name}

||||||{subcomponentName}

||||||{subcomponent2Name}

{system2Name}

...”

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
<td>SULS | Main Site | Home Page<br />
SULS | Main Site | Login Page<br />
SULS | Main Site | Register Page<br />
SULS | Judge Site | Login Page<br />
SULS | Judge Site | Submittion Page<br />
Lambda | CoreA | A23<br />
SULS | Digital Site | Login Page<br />
Lambda | CoreB | B24<br />
Lambda | CoreA | A24<br />
Lambda | CoreA | A25<br />
Lambda | CoreC | C4<br />
Indice | Session | Default Storage<br />
Indice | Session | Default Security</td>
<td><p><strong>Lambda<br />
|||CoreA<br />
||||||A23<br />
||||||A24<br />
||||||A25<br />
|||CoreB<br />
||||||B24<br />
|||CoreC<br />
||||||C4<br />
SULS<br />
|||Main Site<br />
||||||Home Page<br />
||||||Login Page<br />
||||||Register Page<br />
|||Judge Site<br />
||||||Login Page<br />
||||||Submittion Page</strong></p>
<p><strong>|||Digital Site</strong></p>
<p><strong>||||||Login Page<br />
Indice</strong></p>
<p><strong>|||Session</strong></p>
<p><strong>||||||Default Storage</strong></p>
<p><strong>||||||Default Security</strong></p></td>
</tr>
</tbody>
</table>
