# Lab: Lists

Problems for in-class lab for the  
You can check your solutions in
[Judge](https://judge.softuni.bg/Contests/1210)

## Sum Adjacent Equal Numbers

Write a program to **sum all adjacent equal numbers** in a list of
decimal numbers, starting from **left to right**.

  - After two numbers are summed, the obtained result could be equal to
    some of its neighbors and should be summed as well (see the examples
    below).

  - Always sum the **leftmost** two equal neighbors (if several couples
    of equal neighbors are available).

### Examples

| **Input**        | **Output**  | **Explanation**                                                                                                                           |
| ---------------- | ----------- | ----------------------------------------------------------------------------------------------------------------------------------------- |
| **3 3 6 1**      | 12 1        | **<span class="underline">3 3</span> 6 1 <span class="underline">6 6</span> 1 12 1**                                                      |
| **8 2 2 4 8 16** | **16 8 16** | **8 <span class="underline">2 2</span> 4 8 16 8 <span class="underline">4 4</span> 8 16 <span class="underline">8 8</span> 8 16 16 8 16** |
| **5 4 2 1 1 4**  | **5 8 4**   | **5 4 2 <span class="underline">1 1</span> 4 5 4 <span class="underline">2 2</span> 4 5 <span class="underline">4 4</span> 4 5 8 4**      |

### Solution

Read a list of numbers.

![](./media/image1.png)

Iterate through the elements. Check if the number at the **current**
**index** is **equal** to the **next** number. If it is, **aggregate**
**the numbers** and **reset** the loop, otherwise **don't do anything**.

![](./media/image2.png)

Finally, you have to print the numbers joined by a single space.

![](./media/image3.png)

## Gauss' Trick

Write a program that **sums** all of the **numbers in a list** in the
following order:

*first **+** last*, *first + 1* ***+** last - 1*, *first + 2* **+**
*last **-** 2***,** … *first + n*, *last - n*.

![](./media/image4.png)

### Example

| **Input** | **Output** |
| --------- | ---------- |
| 1 2 3 4 5 | 6 6 3      |
| 1 2 3 4   | 5 5        |

## Merging Lists

You are going to receive two lists with numbers. Create a result list,
which contains the numbers from both of the lists. The **first**
**element** should be **from the first list**, the **second** from the
**second list** and so on. If the length of the two lists **are not
equal**, just **add** the **remaining** **elements** at the **end** of
the list.

### Example

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><strong>3 5 2 43 12 3 54 10 23</strong></p>
<p><strong>76 5 34 2 4 12</strong></p></td>
<td><strong>3</strong> <strong>76</strong> <strong>5</strong> <strong>5</strong> <strong>2</strong> <strong>34</strong> <strong>43</strong> <strong>2</strong> <strong>12</strong> <strong>4</strong> <strong>3</strong> <strong>12</strong> <strong>54</strong> <strong>10</strong> <strong>23</strong></td>
</tr>
<tr class="even">
<td><p><strong>76 5 34 2 4 12</strong></p>
<p><strong>3 5 2 43 12 3 54 10 23</strong></p></td>
<td><strong>76</strong> <strong>3</strong> 5 <strong>5</strong> <strong>34</strong> <strong>2</strong> <strong>2</strong> <strong>43</strong> <strong>4</strong> <strong>12</strong> <strong>12</strong> <strong>3</strong> <strong>54 10 23</strong></td>
</tr>
</tbody>
</table>

### Hint

  - Read the two lists

  - Create a result list

  - Start looping through them until you reach the end of the smallest
    one

  - Finally add the remaining elements (if there are any) to the end of
    the list

## List of Products

Read a number **n** and **n lines of products**. Print a **numbered
list** of all the products **ordered by name**.

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
<p>Potatoes</p>
<p>Tomatoes</p>
<p>Onions</p>
<p>Apples</p></td>
<td><p>1.Apples</p>
<p>2.Onions</p>
<p>3.Potatoes</p>
<p>4.Tomatoes</p></td>
</tr>
</tbody>
</table>

### Solution

First, we need to read the number **n** from the console.

![](./media/image5.png)

Then we need to create our **list of strings**, because the **products
are strings.**

![Без име](./media/image6.png)

Then we need to iterate **n times** and **read our current product**.

![](./media/image7.png)

The next step is to **add** the current product to the list.

![](./media/image8.png)

After we finish reading the products, we **sort our list
alphabetically.**

![](./media/image9.png)

  - The **sort method** sorts the list in ascending order.

> Finally, we have to **print our sorted** list. To do that we **loop
> through the list**.

![](./media/image10.png)

  - We use **i + 1**, because we want to **start counting from 1**, we
    put the **'.'**, and **finally** we put **the actual product.**

## Remove Negatives and Reverse

Read a **list of integers**, **remove all negative numbers** from it and
print the remaining elements in **reversed order**. In case there are no
elements left in the list, print "**empty**".

### Examples

| **Input**            | **Output** |
| -------------------- | ---------- |
| **10 -5 7 9 -33 50** | 50 9 7 10  |
| **7 -2 -10 1**       | **1 7**    |
| **-1 -2 -3**         | **empty**  |

### Solution

Read a list of integers.

![](./media/image11.png)

Remove all negative numbers.

![](./media/image12.png)

If the list count is equal to 0 print "empty", otherwise print all
numbers joined by space.

![](./media/image13.png)

## List Manipulation Basics

Write a program that reads a list of integers. Then until you receive
**"end"**, you will receive different **commands:**

**Add {number}:** add a number to the end of the list.  
**Remove {number}:** remove a number from the list.  
**RemoveAt {index}:** remove a number at a given index.  
**Insert {number} {index}:** insert a number at a given index.

**Note: All the indices will be valid\!**

When you receive the **"end"** command, print the **final state** of the
list (**separated by spaces**).

### Example

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>4 19 2 53 6 43</p>
<p>Add 3</p>
<p>Remove 2</p>
<p>RemoveAt 1</p>
<p>Insert 8 3</p>
<p>end</p></td>
<td>4 53 6 8 43 3</td>
</tr>
</tbody>
</table>

### Solution

First let us read the list from the console.

![](./media/image14.png)

  - We **split** the string we have received from the console, then we
    **loop through each of the elements** and parse them to
    **integers.**

  - This returns **IEnumarable\<int\>** (a **collection** of integers)
    and we have to keep it in the form of a list.

Next, we go through the input using a while loop and a switch case
statement for the different commands.

![](./media/image15.png)

  - We stop the cycle if the line is end, otherwise we **split** the
    input string into **tokens**.

![](./media/image16.png)

Now, let us implement **each** of the **commands**.

![](./media/image17.png)

  - For each of the commands, **except "Insert",** **tokens\[1\]** is
    the **number/index.**

  - For the **"Insert"** command we receive a **number and an index**
    (**tokens\[1\], tokens\[2\]**).

Finally, we **print** the numbers, joined by **a single space.**

![](./media/image18.png)

## List Manipulation Advanced

Next, we are going to implement more complicated list commands,
**extending the previous task**. Again, read a list and keep reading
commands until you receive **"end"**:

**Contains {number}** – check if the list contains the number and if so
- print **"Yes**", **otherwise** print **"No such number"**.  
**PrintEven** – print **all the even numbers**, **separated by a
space**.  
**PrintOdd** – print **all the odd numbers, separated by a space**.**  
GetSum** – print the **sum of all the numbers**.**  
Filter {condition} {number}** – print all the numbers that **fulfill the
given condition**. The condition will be either '**\<**', '**\>**',
"**\>=**", "**\<=**".

**After** the **end** **command,** print the list **only if** you have
made some **changes** to the **original list**. **Changes** are made
**only** from the commands from the **previous task**.

### Example

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>2 13 43 876 342 23 543</p>
<p>Contains 100</p>
<p>Contains 543</p>
<p>PrintEven</p>
<p>PrintOdd</p>
<p>GetSum</p>
<p>Filter &gt;= 43</p>
<p>Filter &lt; 100</p>
<p>end</p></td>
<td><p>No such number</p>
<p>Yes</p>
<p>2 876 342</p>
<p>13 43 23 543</p>
<p>1842</p>
<p>43 876 342 543</p>
<p>2 13 43 23</p></td>
</tr>
</tbody>
</table>

##
