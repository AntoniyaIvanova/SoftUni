**Lab: DOM Manipulations**

Problems for in-class lab for the [[\"JavaScript Advanced" course @
SoftUni](https://softuni.bg/courses/js-advanced)\"]{.underline}. Submit
your solutions in the SoftUni judge system at
<https://judge.softuni.bg/Contests/1549/Lab-DOM-Manipulation>.

List of Items
-------------

Write a function that **read** the text inside an input field and
**appends** the specified text to a list inside an HTML page.

### Examples

![](media/image1.png){width="2.2708333333333335in" height="1.89375in"}
![](media/image2.png){width="2.2291666666666665in"
height="1.923089457567804in"}
![](media/image3.png){width="2.2368055555555557in"
height="1.9166666666666667in"}

Add / Delete
------------

Extend the previous problem to display a **\[Delete\] link** after each
list item. **Clicking** it, should **delete** the item with no
confirmation.

### Examples

![](media/image4.png){width="2.8090277777777777in"
height="2.334869860017498in"}
![](media/image5.png){width="3.5902777777777777in"
height="2.3418821084864394in"}

Delete from Table
-----------------

Write a program that **takes** an **e-mail** from an **input field** and
**deletes** the matching row from a table. If no entry is found, an
**error** should be displayed in a **\<div\>** with ID \"**results**\".
The error should be \"**Not found**.\" Submit **only** the
**deleteByEmail()** function in judge.

**Input/Output**

There will be no input/output, your program should instead **modify**
the DOM of the given HTML document.

**Examples**

![](media/image6.png){width="4.395833333333333in"
height="2.4033278652668417in"}

![](media/image7.png){width="4.4125in" height="2.1828838582677164in"}

Stopwatch
---------

Write a **timer** that counts **minutes** and **seconds**. The user
should be able to control it with **buttons**. Clicking **\[Start\]**
**starts** the **counter.** Clicking **\[Stop\]** **resets** the timer
back to **zero**. Only **one** of the buttons should be **enabled** at a
time (you cannot stop the timer, if it is not running).

Submit only the **stopwatch()** function in judge.

**Input/Output**

There will be no input/output, your program should instead **modify**
the DOM of the given HTML document.

**Examples**

![](media/image8.png){width="4.4180314960629925in"
height="2.2777777777777777in"}

Mouse Gradient
--------------

Write a program that **detects** and **displays** how far along a
gradient the user has **moved** their **mouse**. The result should be
**rounded down** and displayed as a **percentage** inside the
**\<div\>** with ID \"**result**\".

Submit **only** the **attachGradientEvents()** function in judge.

**Input/Output**

There will be no input/output, your program should instead **modify**
the DOM of the given HTML document.

**Examples**

![](media/image9.png){width="4.2563845144356955in"
height="0.9444444444444444in"}

Highlight Active
----------------

Write a **function** that **highlights** the **currently active**
section of a document. There will be **multiple** divs with **input
fields** inside them. Set the **class** of the **div** that contains the
**currently focused** input field to \"**focus**\". When focus is lost
(**blurred**), **remove the class** from the element.

Submit only the **focus()** function in judge.

**Input/Output**

There will be no input/output, your program should instead **modify**
the DOM of the given HTML document.

**Example**

![](media/image10.png){width="2.5381627296587927in"
height="2.2920669291338585in"}
![](media/image11.png){width="2.4791666666666665in"
height="2.296946631671041in"}

Dynamic Validation
------------------

Write a **function** that **dynamically validates** an **email** input
field when it is **changed**. If the input is **invalid**, apply the
style \"**error**\". Do **not** validate on every keystroke, as it is
annoying for the user, consider only **change** events.

A valid email is considered to be in the format:
**\<name\>@\<domain\>.\<extension\>**

Only **lowercase Latin characters** are allowed for any of the parts of
the email. If the input is valid, **clear** the style. Submit **only**
the **validate()** function in judge.

**Input/Output**

There will be no input/output, your program should instead **modify**
the DOM of the given HTML document.

**Example**

![](media/image12.png){width="3.1881977252843394in"
height="0.6361767279090114in"}
![](media/image13.png){width="2.98752624671916in"
height="0.6430555555555556in"}
