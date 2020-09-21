Lab: Arrays 
===========

Problems for in-class lab for the [\"JavaScript Advanced\" course @
SoftUni](https://softuni.bg/courses/js-advanced). Submit your solutions
in the SoftUni judge system at
<https://judge.softuni.bg/Contests/1797/Lab-Arrays>.

Sum First Last
--------------

Write a function that calculates and prints the sum of the first and the
last elements in an array.

The **input** comes **as array of string elements** holding numbers.

The **output** is the return value of your function.

### Example

  **Input**                    **Output**      **Input**           **Output**
  ---------------------------- ------------ -- ------------------- ------------
  \[\'20\', \'30\', \'40\'\]   60              \[\'5\', \'10\'\]   15

Even Position Element
---------------------

Write a function that finds the elements at even positions in an array.

The **input** comes as **array of string** elements.

The **output** is the return value of your function. Collect all
elements in a string, separated by space.

### Examples

  **Input**                    **Output**      **Input**           **Output**
  ---------------------------- ------------ -- ------------------- ------------
  \[\'20\', \'30\', \'40\'\]   20 40           \[\'5\', \'10\'\]   5

Negative / Positive Numbers
---------------------------

Write a JS function that processes the elements in an array one by one
and produces a new array. **Prepend** each **negative** element at the
front of the result and **append** each **positive** (or 0) element at
the end of the result.

The **input** comes as **array of number elements**.

The **output** is printed on the console, each element on a new line.

### Example

+-----------------+------------+---+------------------+------------+
| **Input**       | **Output** |   | **Input**        | **Output** |
+=================+============+===+==================+============+
| \[7, -2, 8, 9\] | -2         |   | \[3, -2, 0, -1\] | -1         |
|                 |            |   |                  |            |
|                 | 7          |   |                  | -2         |
|                 |            |   |                  |            |
|                 | 8          |   |                  | 3          |
|                 |            |   |                  |            |
|                 | 9          |   |                  | 0          |
+-----------------+------------+---+------------------+------------+

Last K Numbers Sequence
-----------------------

You are given two integers **n** and **k**. Write a JS function that
generates and prints the following sequence:

-   The first element is 1

-   Every following element equals the **sum** of the previous **k**
    elements

-   The length of the sequence is **n** elements

The **input** comes as **two number arguments**. The first element
represents the number **n**, and the second -- the number **k**.

The **output** is printed on the console on a single line, separated by
space.

### Example

  **Input**   **Output**        **Input**   **Output**
  ----------- -------------- -- ----------- -------------------
  6, 3        1 1 2 4 7 13      8, 2        1 1 2 3 5 8 13 21

#### Explanation

The 2^nd^ element (1) is the sum of the 3 elements before it, but there
is only 1, so we take that. The third element is the sum of the first 2
(1 and 1) and the 4^th^ -- the sum of 1, 1 and 2. The 5^th^ element is
the sum of the 2^nd^, 3^rd^ and 4^th^ (1, 2 and 4) and so on.

Process Odd Numbers
-------------------

You are given an array of numbers. Write a JS function that prints the
elements at **odd** **positions** from the array, **doubled** and in
**reverse** order.

The **input** comes as **array of number elements**.

The **output** is printed on the console on a single line, separated by
space.

### Example

  **Input**            **Output**      **Input**               **Output**
  -------------------- ------------ -- ----------------------- ------------
  \[10, 15, 20, 25\]   50 30           \[3, 0, 10, 4, 7, 3\]   6 8 0

Smallest Two Numbers
--------------------

Write a function that prints the two smallest elements from an array of
numbers.

The **input** comes as **array of number elements**.

The **output** is printed on the console on a single line, separated by
space.

### Example

  **Input**           **Output**      **Input**               **Output**
  ------------------- ------------ -- ----------------------- ------------
  \[30, 15, 50, 5\]   5 15            \[3, 0, 10, 4, 7, 3\]   0 3

Biggest Element
---------------

Write a function that finds the biggest element inside a matrix.

The **input** comes as **array of arrays**, containing number elements
(2D matrix of numbers).

The **output** is the return value of your function. Find the biggest
element and return it.

### Examples

+-------------------+------------+---+--------------------+------------+
| **Input**         | **Output** |   | **Input**          | **Output** |
+===================+============+===+====================+============+
| \[\[20, 50, 10\], | 145        |   | \[\[3, 5, 7, 12\], | 33         |
|                   |            |   |                    |            |
| \[8, 33, 145\]\]  |            |   | \[-1, 4, 33, 2\],  |            |
|                   |            |   |                    |            |
|                   |            |   | \[8, 3, 0, 4\]\]   |            |
+-------------------+------------+---+--------------------+------------+

Diagonal Sums
-------------

A square matrix of numbers comes as an array of **strings**, each string
holding numbers (space separated). Write a function that finds the sum
at the main and at the secondary diagonals.

The **input** comes as **array of arrays**, containing number elements
(2D matrix of numbers).

The **output** is printed on the console, on a single line separated by
space. First print the sum at the main diagonal, then the sum at the
secondary diagonal.

### Example

+---------------+------------+---+-----------------+------------+
| **Input**     | **Output** |   | **Input**       | **Output** |
+===============+============+===+=================+============+
| \[\[20, 40\], | 80 50      |   | \[\[3, 5, 17\], | 99 25      |
|               |            |   |                 |            |
| \[10, 60\]\]  |            |   | \[-1, 7, 14\],  |            |
|               |            |   |                 |            |
|               |            |   | \[1, -8, 89\]\] |            |
+---------------+------------+---+-----------------+------------+

Equal Neighbors
---------------

Write a function that finds the number of **equal** **neighbor** pairs
inside a **matrix** of variable size and type (numbers or strings).

The **input** comes as **array of arrays**, containing string elements
(2D matrix of strings).

The **output** is return value of your function. Save the number of
equal pairs you find and return it.

### Example

+-------------------+------------+---+-------------------+------------+
| **Input**         | **Output** |   | **Input**         | **Output** |
+===================+============+===+===================+============+
| \[\[\'2\', \'3\', | 1          |   | \[\[\'test\',     | 2          |
| \'4\', \'7\',     |            |   | \'yes\', \'yo\',  |            |
| \'0\'\],          |            |   | \'ho\'\],         |            |
|                   |            |   |                   |            |
| \[\'4\', \'0\',   |            |   | \[\'well\',       |            |
| \'5\', \'3\',     |            |   | \'done\', \'yo\', |            |
| \'4\'\],          |            |   | \'6\'\],          |            |
|                   |            |   |                   |            |
| \[\'2\', \'3\',   |            |   | \[\'not\',        |            |
| \'5\', \'4\',     |            |   | \'done\',         |            |
| \'2\'\],          |            |   | \'yet\',          |            |
|                   |            |   | \'5\'\]\]         |            |
| \[\'9\', \'8\',   |            |   |                   |            |
| \'7\', \'5\',     |            |   |                   |            |
| \'4\'\]\]         |            |   |                   |            |
+-------------------+------------+---+-------------------+------------+

 {#section .list-paragraph}
