Problem 4 -- Hit List
=====================

One final task for Sam before he gets to go home\... Data mining!

Sam will receive info about one or several people in the format

-   "**{name}={key}:{value};{key}:{value};...**".

The goal here is to **group** the info for every person by their
**name**. If a **key** is received **multiple times**, keep **only the
most recent value**.

On the last line, you will receive "**Kill {name}**". Your task is to
find all the info on that name and print it, **ordered alphabetically by
key**.

Then, Sam needs to build a so-called **info index** on them. The **info
index** is comprised of the **sum** of all the **keys' lengths** and
**values' lengths** of that person's info.

If the **info index** is **larger or equal to** the **target info
index** (given on the **first line** of input), print "**Proceed**".
Otherwise, print "**Need {infoNeeded} more info.**".

Input
-----

-   On the **first line**, you will receive the **target info index**,
    an **integer** in the **range** **\[25-90\]**

-   Until you receive the text "**end transmissions**", **keep reading**
    **new lines** with information.

-   On the final line, you will receive "**Kill {name}**"

Output
------

-   On the first line, print "**Info on {name}:**".

-   On the next lines, print "**\-\--{info}: {value}**"

-   On the next line, print "**Info index: {infoIndex}**" with the
    **info index** of the selected person.

-   On the final line, print either "**Proceed**" or "**Need
    {infoNeeded} more info.**", depending on whether the info is
    **enough** to carry out the hit or not.

Constraints
-----------

-   There will **always** be at least **one** name in the input.

-   Each name will **always** have **one or several** **key/value**
    pairs associated with it.

Examples
--------

+---------------------------------+-----------------------------+
| **Input**                       | **Output**                  |
+=================================+=============================+
| 30                              | Info on Kobin:              |
|                                 |                             |
| Kobin=age:20;salary:700         | \-\--age: 20                |
|                                 |                             |
| Grimsdottir=salary:5000         | \-\--education: High School |
|                                 |                             |
| Kobin=education:High School     | \-\--salary: 700            |
|                                 |                             |
| end transmissions               | Info index: 34              |
|                                 |                             |
| Kill Kobin                      | Proceed                     |
+---------------------------------+-----------------------------+
| 20                              | Info on Lambert:            |
|                                 |                             |
| Lambert=age:57;salary:7000      | \-\--age: 57                |
|                                 |                             |
| Grimsdottir=salary:5000         | \-\--salary: 7000           |
|                                 |                             |
| John=salary:1550                | Info index: 15              |
|                                 |                             |
| John=lastName:Smith             | Need 5 more info.           |
|                                 |                             |
| John=salary:1800                |                             |
|                                 |                             |
| Kobin=education:High School     |                             |
|                                 |                             |
| end transmissions               |                             |
|                                 |                             |
| Kill Lambert                    |                             |
+---------------------------------+-----------------------------+
| 25                              | Info on Bill:               |
|                                 |                             |
| Bill=salary:900;lastName:Billov | \-\--lastName: Billov       |
|                                 |                             |
| Kobin=salary:1300               | \-\--salary: 900            |
|                                 |                             |
| Kobin=education:High School     | Info index: 23              |
|                                 |                             |
| end transmissions               | Need 2 more info.           |
|                                 |                             |
| Kill Bill                       |                             |
+---------------------------------+-----------------------------+
