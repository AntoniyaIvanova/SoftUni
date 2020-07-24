# Lab: Objects and Classes

## Person Info

Write a function that receives **3 parameters**, sets them to an
**object** and prints the object's properties by key and value in the
format: "**{key}: {value}**"

The input comes as **3 separate strings** in the following order:
**firstName**, **lastName**, **age**.

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
<td>"Peter",<br />
"Pan",<br />
"20"</td>
<td><p>firstName: Peter</p>
<p>lastName: Pan</p>
<p>age: 20</p></td>
</tr>
</tbody>
</table>

### Hints

![](./media/image1.png)

## City

Receive **five single strings**.

Create a **city object** which will hold the city **name**, **area**,
**population**, **country** and **postcode**.

Loop through all the **keys** and print them with their **values** in
format: "**{key} -\> {value}**"

The input will be in the following order: **name**, **area**,
**population**, **country** and **postCode**.

See the examples below.

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
<td>"Sofia"," 492", "1238438", "Bulgaria", "1000"</td>
<td><p>name -&gt; Sofia</p>
<p>area -&gt; 492</p>
<p>population -&gt; 1238438</p>
<p>country -&gt; Bulgaria</p>
<p>postCode -&gt; 1000</p></td>
</tr>
</tbody>
</table>

## Convert to Object

Write a function that receives a **string** in **JSON format** and
converts it to **object**.

Loop through all the keys and print them with their values in format:
"**{key}: {value}**"

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
<td>'{"name": "George", "age": 40, "town": "Sofia"}'</td>
<td><p>name: George</p>
<p>age: 40</p>
<p>town: Sofia</p></td>
</tr>
</tbody>
</table>

### Hints

  - Use **JSON.parse()** method to parse JSON string to an object

![](./media/image2.png)

## Convert to JSON

Write a Function That Receives Name, LastName, HairColor and Sets Them
to an Object.

Convert the **object** to **JSON string** and print it.

Input is provided as **3 single strings** in the order stated above.

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
<td><p>'George',</p>
<p>'Jones',</p>
<p>'Brown'</p></td>
<td>{"name":"George",<br />
"lastName":"Jones",<br />
"hairColor":"Brown"}</td>
</tr>
</tbody>
</table>

### Hints

  - Use **JSON.stringify()** to parse the object to JSON string

![](./media/image3.png)

## Cats

Write a function that receives **array** of strings in the following
format **'{cat name} {age}'**.

Create a **Cat** **class** that receives in the **constructor** the
**name** and the **age** parsed from the input.

It should also have a function named **"meow"** that will print **"{cat
name}, age {age} says Meow"** on the console.

For each of the strings provided you must **create a cat object.**

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
<td>['Mellow 2', 'Tom 5']</td>
<td><p>Mellow, age 2 says Meow</p>
<p>Tom, age 5 says Meow</p></td>
</tr>
</tbody>
</table>

### Hints

  - Create a Cat class with properties and methods described above

  - Parse the input data

  - Create all objects using class constructor and the parsed input
    data, store them in an array

  - Loop through the array using **for…of** cycle and **invoke .meow()**
    method

![](./media/image4.png)

## Songs

Define a **class** **Song**, which holds the following information about
songs: **typeList**, **name** and **time**.

You will receive the input as an **array**.

The first element **n** will be the number of songs. Next **n** elements
will be the songs data in the following format:
**"{typeList}\_{name}\_{time}"**, and the the last element will be
**Type List** / **"all".**

Print only the **names of the songs** which are from that **Type List**
/ **All songs**.

**Examples**

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><strong>[3,</strong></p>
<p>'favourite_DownTown_3:14',</p>
<p>'favourite_Kiss_4:16',</p>
<p>'favourite_Smooth Criminal_4:01',</p>
<p>'favourite']</p></td>
<td><p>DownTown</p>
<p>Kiss</p>
<p>Smooth Criminal</p></td>
</tr>
<tr class="even">
<td><p><strong>[4,</strong></p>
<p>'favourite_DownTown_3:14',</p>
<p>'listenLater_Andalouse_3:24',</p>
<p>'favourite_In To The Night_3:58',</p>
<p>'favourite_Live It Up_3:48',</p>
<p>'listenLater']</p></td>
<td>Andalouse</td>
</tr>
<tr class="odd">
<td><p><strong>[2,</strong></p>
<p><strong>'like_Replay_3:15',</strong></p>
<p><strong>'ban_Photoshop_3:48',</strong></p>
<p><strong>'all']</strong></p></td>
<td><p>Replay</p>
<p>Photoshop</p></td>
</tr>
</tbody>
</table>

### Solution:

Create a Song class with properties described above

![](./media/image5.png)

Create a new array, where you will store songs

![](./media/image6.png)

Iterate over the songs:

![](./media/image7.png)

![](./media/image8.png)
