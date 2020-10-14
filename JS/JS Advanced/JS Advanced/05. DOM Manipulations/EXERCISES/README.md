**Exercise: DOM Manipulations**

Problems for exercises and homework for the [[\"JavaScript Advanced\"
course @
SoftUni](https://softuni.bg/courses/js-advanced)\"]{.underline}. Submit
your solutions in the SoftUni judge system at
<https://judge.softuni.bg/Contests/1550/Exercise-DOM-Manipulations>.

Sections
--------

You will receive an **array** of strings. For each string, create a
**div** with a **paragraph** with the **string** in it. Each paragraph
is initially **hidden (display:none)**. Add a **click** **event**
**listener** to **each div** that **displays** the **hidden** paragraph.
Finally, you should **append** all divs to the element with an **id**
\"**content**\".

**Example**

![beforeClick](media/image1.png){width="3.121052055993001in"
height="3.1496062992125986in"}
![C:\\Users\\v\\AppData\\Local\\Microsoft\\Windows\\INetCache\\Content.Word\\afterClick.png](media/image2.png){width="3.1878291776028in"
height="3.1496062992125986in"}

Notification
------------

Write a **function** that receives a string **message** and **displays**
it inside a div with an id \"**notification**\" for 2 seconds. The div
is initially **hidden** and when the function is called, it must be
**shown**. After 2 seconds, **hide** the div. In the example below, a
notification is shown when you **click** the button.

**Example**

![](media/image3.png){width="7.490132327209099in" height="3.13in"}

When we click the \[**GET NOTIFIED**\] **button**, a **div** appears in
our upper-right corner. It should **disappear** in 2 seconds.

Time Converter
--------------

Create a program that **converts** different time units. Your task is to
add a **click** event listener to **all** \[**CONVERT**\] **buttons**.
When a button is **clicked**, read the **corresponding** input field,
**convert** the value to the **three other** time units and **display**
it in the input fields.

**Example**

![](media/image4.png){width="6.375980971128609in" height="4.41in"}

One day is equal to 24 hours/1440 minutes/86400 seconds. Whichever
button we **click,** the input fields should **change** depending on the
added value on the left. (For example, if we write 48 hours and click
convert the days, the field value should change to 2).

Locked Profile
--------------

In this problem, you should **create a JS functonality** which **shows**
and **hides** the additional

information about users.

![](media/image5.png){width="6.003981846019248in"
height="2.5166666666666666in"}

When one of the \[**Show more**\] **buttons** is clicked, the **hiden
information** inside the div should

be shown, only if **the profile is not locked**! If the current profile
is **locked,** nothing should

happen.

![](media/image6.png){width="5.895612423447069in"
height="3.1458333333333335in"}

If the **hidden information is displayed** and we **lock** **the profile
again**, the \[**Hide it**\] button

should **not be working**! Otherwise, when the profile is **unlocked**
and we click on the **\[Hide it\]**

button, the new fields must hide again.

Encode and Decode Messages
--------------------------

In this problem, you should **create a JS functonality** which **encodes
and decodes some**

**messages which travel to the network.**

![](media/image7.png){width="5.447259405074366in"
height="3.595138888888889in"}

This program should contain **two functionalities**.

The first one is to **encode the given message** and **send it** to the
**receiver**.

The second one is to **decode the received message** and **read it
(display it)**.

When the \[**Encode and send it**\] **button** is clicked, you should
get the given message from the first textarea. When you get the current
message, you should encode it as follows:

-   **Change** the **ASCII CODE** on **every single character** in that
    message when **you add 1** to the current **ASCII NUMBER**, that
    represent the current character in that message

-   **Clear** the **sender** **textarea** and **append** the encoded
    message to the **receiver textarea**

![](media/image8.png){width="5.1222659667541555in"
height="3.285416666666667in"}

[After clicking \[**Encode and send it**\] **button** the result should
be:]{.underline}

![](media/image9.png){width="5.158435039370079in"
height="3.3041666666666667in"}

After that, when the \[**Decode and read it**\] **button** is clicked.
You need to get the **encoded message** from **the receiver textarea**
and do the **opposite logic** from encoding:

-   **Subtract 1** from the current **ASCII NUMBER**, that represents
    the current character in that message

-   Replace the **encoded message** with the already **decoded message**
    in the receiver textrea, to make it readable

![](media/image10.png){width="5.6125in" height="3.5353094925634294in"}

Table -- Search Engine
----------------------

Write a function that **searches** in a **table** by given input.

![](media/image11.png){width="6.531944444444444in"
height="2.4316251093613297in"}

When the \"**Search**\" **button** is **clicked**, go through all cells
in the table except for the first row (Student name, Student email and
Student course) and check if the given input has a match (check for both
**full words** and **single letters**).

If any of the rows contain the submitted string, add a **select class**
to that row. Note that more than one row may contain the given string.

Оtherwise, if there is no match, **[nothing should
happen]{.underline}**.

**Note:** After every search (\"**Search**\" button is clicked),
**clear** **the input field** and **remove** **all already selected
classes** (if any) from the previous search, in order for the **new
search** to contain only the **new result**.

For instance, if we try to find **eva:**

![](media/image12.png){width="6.531944444444444in"
height="2.429475065616798in"}

The result should be:

![](media/image13.png){width="6.531944444444444in"
height="2.3161209536307963in"}

If we try to find all students who have email addresses in **softuni**
domain, the expected result should be:

![](media/image14.png){width="6.531944444444444in"
height="2.5237051618547683in"}

Furniture
---------

You will be given some furniture as an **array of objects**. Each object
will have a **name**, a **price** and a **decoration factor**.

When the **\"Generate\" button is clicked**, add a **new row to the
table** for each piece of furniture with **image, name, price** and
**decoration factor** (code example below).

When the **\"Buy\"** button is clicked, get all **checkboxes that are
marked** and show in the **result textbox** the **names** of the piece
of furniture that **were checked**, separated by a **comma** and
**single** **space** (**\", \"**) in the following format: **\"Bought
furniture: {furniture1} {furniture2}...\"**.

On the next line, print the total price in format: **\"Total price:
{totalPrice}\"** (formatted to the second decimal point). Finally, print
the average decoration factor in the format: **\"Average decoration
factor: {decFactor}\"**

### Input Example

> **\[{\"name\": \"Sofa\", \"img\":
> \"https://res.cloudinary.com/maisonsdumonde/image/upload/q\_auto,f\_auto/w\_200/img/grey-3-seater-sofa-bed-200-13-0-175521\_9.jpg\",
> \"price\": 150, \"decFactor\": 1.2}\]**

### Examples

![](media/image15.png){width="6.548077427821522in"
height="4.865621172353456in"}

![](media/image16.png){width="6.547916666666667in"
height="3.0897758092738408in"}

Cards
-----

Write **a function** which **checks cards**, shows which one **is
greater** and **keeps history of all hands**.

![](media/image17.png){width="5.458333333333333in"
height="3.0914457567804026in"}

![](media/image18.png){width="3.0508377077865267in" height="3.65in"}

**Firstly, add** **click events** to **all cards**. When one of the
cards is clicked, the current background card must be changed with the
\"**whiteCard.jpg**\" picture (it is given in the skeleton) and the
**card name should be appended** to one of the **span** elements in the
**div** with **id=\"result\".**

If a card **from the top side** is **clicked**, **append** the **card
name** to the **left span** (first empty **span**), otherwise **append**
the card **name** to the **right span** (second/last **span**).

![](media/image19.png){width="5.69576990376203in" height="3.125in"}

![](media/image20.png){width="5.697916666666667in"
height="3.4063167104111987in"}

When **cards** from **both sides** **are selected,** **check** which one
is **greater**. The greater card should have border \"**2px solid
green**\" and the lower card - \"**2px solid red\"**.

![](media/image21.png){width="6.485209973753281in"
height="3.4523458005249346in"}

![](media/image22.png){width="6.557192694663167in"
height="3.4461450131233597in"}

You should **clear** the **span elements** which **hold the current card
names** when both are selected, and the winner is selected. **After
every hand,** push the current card names in the **history div** in the
following format:

\[{top side card name} vs {bottom side card name} \]

![](media/image23.png){width="6.531796806649169in"
height="3.8958333333333335in"}

\* Distance Converter
---------------------

Your task is to convert from **one** distance unit to **another** by
adding a **click** event listener to a button. When it is clicked,
**read** the value from the input field and **get** the **selected**
option from the **input** and **output** units drop downs. Then
**calculate** and **display** the converted value in the **disabled**
output field.

**Example**

![](media/image24.png){width="6.3588932633420825in" height="1.94in"}

**Hints**

-   Multiply the incoming distance by the following conversion rates to
    convert to meter

-   Divide to convert from meters to the required output unit

-   To see which option is selected, read the properties of its parent:
    **value** gives you the value of the selected option (as displayed
    in the HTML), **selectedIndex** gives you the 0-based index of the
    selected option. For example, if miles are selected,
    **inputUnits.value** is \"**mi**\", **inputUnits.selectedIndex** is
    **4**. Option text is irrelevant

-   Use the following table information to do that:

  **1 km**    **1000 m**
  ----------- ---------------
  **1 m**     **1 m**
  **1 cm**    **0.01 m**
  **1 mm**    **0.001 m**
  **1 mi**    **1609.34 m**
  **1 yrd**   **0.9144 m**
  **1 ft**    **0.3048 m**
  **1 in**    **0.0254 m**

\* Sudomu
---------

Write a function that implements **SUDOMU** (**Sudoku inside the DOM**).

![](media/image25.png){width="6.482492344706912in"
height="2.5194444444444444in"}

The rules are simple and they are **the same** as the **typical sudoku
game** (for more information,

click
[here](https://sudoku.com/how-to-play/sudoku-rules-for-complete%20beginners/))

If the table is filled with the **right numbers**, and the \"**Quick
Check**\" button is **clicked**, the

expected result should be:

![](media/image26.png){width="6.182692475940508in"
height="2.7570614610673667in"}

The table borer should be changed to: \"**2px solid green\".** The
**text content** of the **paragraph**

inside the **div** with an **id** \"**check**\" must be \"**You solve
it! Congratulations!**\"

The text color of that div must be **green.**

Otherwise, when the filled table **does not solve** **the sudomu,** the
result should be:

![](media/image27.png){width="6.173077427821522in"
height="2.6314720034995625in"}

The table border should be changed to: \"**2px solid red**\".

The **text content** of the **paragraph** inside the **div** with an
**id** \"**check**\" must be:

\"**NOP! You are not done yet...**\"

The text color of that div must be **red!**

The \"**Clear**\" button **clears the whole** **SUDOMU (removes all
numbers)** and the **paragraph**

**which contains the messages. It also removes the table border.**

![](media/image25.png){width="6.482492344706912in"
height="2.5194444444444444in"}
