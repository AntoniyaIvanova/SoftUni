# Exercise: Generics

Problems for exercise and homework for the
[<span class="underline">"CSharp Advanced" course @ Software
University</span>](https://softuni.bg/courses/csharp-advanced).

You can check your solutions here:
<https://judge.softuni.bg/Contests/1475/Generics-Exercises>

## Generic Box of String

Create a generic **class** **Box** that can be initialized with **any
type** and **store the value**. Override the **ToString()** method and
**print** the **type** and **stored** **value**.

### Input

  - On the first line, you will get **n** - the number of strings to
    read from the console.

  - On the next **n** lines, you will get the **actual strings**.
    
      - For each of them, create a box and call its **ToString()**
        method to **print** its data on the console.

**Output**

  - The output should be in the given format:

**"{class full name: value}"**

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
<p><strong>life in a box</strong></p>
<p><strong>box in a life</strong></p></td>
<td><p><strong>System.String: life in a box</strong></p>
<p><strong>System.String: box in a life</strong></p></td>
</tr>
</tbody>
</table>

## Generic Box of Integer

Use the description of the previous problem but now, test your generic
box with Integers.

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
<p><strong>7</strong></p>
<p><strong>123</strong></p>
<p><strong>42</strong></p></td>
<td><p><strong>System.Int32: 7</strong></p>
<p><strong>System.Int32: 123</strong></p>
<p><strong>System.Int32: 42</strong></p></td>
</tr>
</tbody>
</table>

## Generic Swap Method Strings

Create a **generic** **method** that receives **a list**, containing
**any** **type** of **data** and **swaps** **the elements** at **two**
**given** **indexes**.

### Input

  - On the first line, you will read **n** number of boxes of type
    **string** and **add** them to the list.

  - On the next line, however, you will receive a **swap command**
    consisting of **two indexes**.

### Output

  - Use the **method** you've created to swap the elements that
    correspond to the given indexes and **print each element in the
    list**.

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
<p><strong>Pesho</strong></p>
<p><strong>Gosho</strong></p>
<p><strong>Swap me with Pesho</strong></p>
<p><strong>0 2</strong></p></td>
<td><p><strong>System.String: Swap me with Pesho</strong></p>
<p><strong>System.String: Gosho</strong></p>
<p><strong>System.String: Pesho</strong></p></td>
</tr>
</tbody>
</table>

## Generic Swap Method Integers

Use the description of the previous problem, but now, **test** your list
of generic boxes with **integers**.

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
<p><strong>7</strong></p>
<p><strong>123</strong></p>
<p><strong>42</strong></p>
<p><strong>0 2</strong></p></td>
<td><p><strong>System.Int32: 42</strong></p>
<p><strong>System.Int32: 123</strong></p>
<p><strong>System.Int32: 7</strong></p></td>
</tr>
</tbody>
</table>

## Generic Count Method Strings

Create a **method** that receives as an argument a **list of any type,
that can be compared** and an **element of the given type**. The method
should **return the count of elements that are greater than the value of
the given element**. **Modify your Box class** to support **comparison
by value** of the stored data.

### Input

  - On the **first** line, you will receive **n** - the number of
    **elements** to **add to the list**.

  - On the next **n** lines, you will receive the **actual elements**.

  - On the **last** line, you will get the **value** of the **element**
    for comparison.

### Output

  - Print the **count of elements** that are **larger** than the value
    of the given element.

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
<p><strong>aa</strong></p>
<p><strong>aaa</strong></p>
<p><strong>bb</strong></p>
<p><strong>aa</strong></p></td>
<td><strong>2</strong></td>
</tr>
</tbody>
</table>

## Generic Count Method Doubles

Use the description of the previous problem, but now, **test** your
**list** of generic boxes with **doubles**.

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
<p><strong>7.13</strong></p>
<p><strong>123.22</strong></p>
<p><strong>42.78</strong></p>
<p><strong>7.55</strong></p></td>
<td><strong>2</strong></td>
</tr>
</tbody>
</table>

## Tuple

A
[**Tuple**](https://msdn.microsoft.com/en-us/library/system.tuple\(v=vs.110\).aspx)
is a class in C\#, in which you can store a few objects. First, we are
going to focus on the **Tuple's type**, which contains two objects. The
first one is "**item1**" and the second one is "**item2**". It is kind
of like a **KeyValuePair,** except – it **simply has items, which are
neither key nor value**. Your task is to create a class "**Tuple**",
which holds two objects. The first one, will be "**item1**" and the
second one – "**item2**". The tricky part here is to make the class
**hold generics**. This means, that when you create a new object of
class – "**Tuple**", there should be a way to explicitly specify both
items' **type** **separately**.

### Input

The input consists of **three** lines:

  - The **first** one is holding a **person's name** and **an address**.
    They are separated by space(s). Your task is to **collect** them in
    the **tuple** and **print** them on the **console**. Format of the
    input:

**{first name} {last name} {address}**

  - The second line holds a **name** of a person and the **amount of
    beer** (int) he can drink. Format:

**{name} {liters of beer}**

  - The last line will hold an **integer** and a **double**. Format:

**{integer} {double}**

### Output

  - Print the tuples’ items in format: **{item1} -\> {item2}**

### Constraints

  - Use the good practices we have learned. Create the class and make it
    have getters and setters for its class variables. The input will be
    **valid**, no need to check it explicitly\!

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
<td><p>Adam Smith California</p>
<p>Mark 2</p>
<p>23 21.23212321</p></td>
<td><p>Adam Smith -&gt; California</p>
<p>Mark -&gt; 2</p>
<ol start="23" type="1">
<li><p>-&gt; 21.23212321</p></li>
</ol></td>
</tr>
</tbody>
</table>

## Threeuple

Create a Class **Threeuple**. Its name is telling us, that it will hold
no longer, just a pair of objects. The task is simple, our **Threeuple**
should **hold three objects**. Make it have getters and setters. You can
even extend the previous class

### Input

The input consists of three lines:

  - The first one is holding a name, an address and a town. Format of
    the input:

**{first name} {last name} {address} {town}**

  - The second line is holding a **name**, **beer** **liters**, and a
    **boolean** variable with value - **drunk** or **not**. Format:

**{name} {liters of beer} {drunk or not}**

  - The last line will hold a **name**, a **bank** **balance**
    (**double**) and a **bank name**. Format:

**{name} {account balance} {bank name}**

### Output

  - Print the Threeuples' objects in format:

**"{firstElement} -\> {secondElement} -\> {thirdElement}"**

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
<td><p>Adam Smith Wallstreet New York</p>
<p>Mark 18 drunk</p>
<p>Karren 0.10 USBank</p></td>
<td><p>Adam Smith -&gt; Wallstreet -&gt; New York</p>
<p>Mark -&gt; 18 -&gt; True</p>
<p>Karren -&gt; 0.1 -&gt; USBank</p></td>
</tr>
<tr class="even">
<td><p>Ivan Ivanov TheHills Plovdiv</p>
<p>Mitko 18 not</p>
<p>George 0.10 NGB</p></td>
<td><p>Ivan Ivanov -&gt; TheHills -&gt; Plovdiv</p>
<p>Mitko -&gt; 18 -&gt; False</p>
<p>George -&gt; 0.1 -&gt; NGB</p></td>
</tr>
</tbody>
</table>

**Note:** You may extend your previous solution.
