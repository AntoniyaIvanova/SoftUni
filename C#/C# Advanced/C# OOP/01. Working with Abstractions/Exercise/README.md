# Exercise: Working with Abstraction

This document defines the **exercise assignments** for the
[<span class="underline">"C\# OOP" course @ Software
University</span>](https://softuni.bg/opencourses/csharp-oop).

You can check your solutions here:
[https://judge.softuni.bg/Contests/Working-with-Abstraction-Exercise](https://judge.softuni.bg/Contests/1496/Working-with-Abstraction-Exercise)

Your job is to download [source
code](https://softuni.bg/downloads/svn/csharp-fundamentals/2018-Jan/CSharp-OOP-Basics/02.%20CSharp-OOP-Basics-Working-with-Abstraction/02.%20CSharp-OOP-Basics-Working-with-Abstraction-Exercises-Resources.zip)
and **refactor** it.

## Raw Data

Write a program that tracks **cars** and their **cargo**. Define a class
**Car** that holds an information about **model, engine, cargo** and a
**collection of exactly 4 tires**. The **engine**, **cargo** and
**tire** should be **separate classes**. Create a **constructor** that
receives all of the information about the **Car** and creates and
**initializes** its inner **components** (**engine**, **cargo** and
**tires**).

On the first line of input, you will receive a number **N** - the number
of cars you have. On each of the next **N** lines, you will receive an
information about each car in the format:

"**{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType}
{tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure}
{tire3Age} {tire4Pressure} {tire4Age}"**

The **speed**, **power**, **weight** and **tire age** are **integers**
and **tire** **pressure** is a **double.**

After the **N** lines, you will receive a single line with one of the
following commands:

  - "**fragile**" - print all cars whose **cargo** is **"fragile"** with
    **a tire**, whose **pressure is** **\< 1**

  - "**flamable**" - print all of the cars, whose **cargo** is
    **"flamable"** and have **engine power \> 250**

The cars should be printed in order of appearing in the input.

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
<td><p>2</p>
<p>ChevroletAstro 200 180 1000 fragile 1.3 1 1.5 2 1.4 2 1.7 4</p>
<p>Citroen2CV 190 165 1200 fragile 0.9 3 0.85 2 0.95 2 1.1 1</p>
<p>fragile</p></td>
<td>Citroen2CV</td>
</tr>
<tr class="even">
<td><p>4</p>
<p>ChevroletExpress 215 255 1200 flamable 2.5 1 2.4 2 2.7 1 2.8 1</p>
<p>ChevroletAstro 210 230 1000 flamable 2 1 1.9 2 1.7 3 2.1 1</p>
<p>DaciaDokker 230 275 1400 flamable 2.2 1 2.3 1 2.4 1 2 1</p>
<p>Citroen2CV 190 165 1200 fragile 0.8 3 0.85 2 0.7 5 0.95 2</p>
<p>flamable</p></td>
<td><p>ChevroletExpress</p>
<p>DaciaDokker</p></td>
</tr>
</tbody>
</table>

## Cars Salesman

**You are given the problem and the solution of this task. Refactor it
by reusing the base constructors in the classes.**

Define two classes **Car** and **Engine.**

**Car** has the following properties:

  - **Model**

  - **Engine**

  - **Weight**

  - **Color**

**Engine** has the following properties:

  - **Model**

  - **Power**

  - **Displacement**

  - **Efficiency**

A Car's **weight** and **color** and its Engine's **displacement** and
**efficiency** are **optional**.

On the first line, you will read a number **N,** which will specify how
many lines of engines you will receive. On each of the next **N** lines,
you will receive information about an **Engine** in the following
format:

**"{model} {power} {displacement} {efficiency}"**

After the lines with engines, you will receive a number **M**. On each
of the next **M** lines, an information about a **Car** will follow in
the format:

**"{model} {engine} {weight} {color}"**

The engine will be the **model of an existing** **Engine**. When
creating the object for a **Car**, you should keep a **reference to the
real engine** in it, instead of just the engine's model.

**Note:** that the optional properties **might be missing** from the
formats.

Your task is to **print** all the **cars** in the order they were
received and their information in the format defined bellow. If any of
the optional fields are missing, print "**n/a**" in its place:

{CarModel}:  
{EngineModel}:  
Power: {EnginePower}  
Displacement: {EngineDisplacement}  
Efficiency: {EngineEfficiency}  
Weight: {CarWeight}  
Color: {CarColor}

### Bonus\*

Override the classes'  **ToString()** methods to have a reusable way of
displaying the objects.

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
<td><p>2</p>
<p>V8-101 220 50</p>
<p>V4-33 140 28 B</p>
<p>3</p>
<p>FordFocus V4-33 1300 Silver</p>
<p>FordMustang V8-101</p>
<p>VolkswagenGolf V4-33 Orange</p></td>
<td><p>FordFocus:</p>
<p>V4-33:</p>
<p>Power: 140</p>
<p>Displacement: 28</p>
<p>Efficiency: B</p>
<p>Weight: 1300</p>
<p>Color: Silver</p>
<p>FordMustang:</p>
<p>V8-101:<br />
Power: 220<br />
Displacement: 50</p>
<p>Efficiency: n/a</p>
<p>Weight: n/a</p>
<p>Color: n/a</p>
<p>VolkswagenGolf:</p>
<p>V4-33:</p>
<p>Power: 140</p>
<p>Displacement: 28</p>
<p>Efficiency: B</p>
<p>Weight: n/a</p>
<p>Color: Orange</p></td>
</tr>
<tr class="even">
<td><p>4</p>
<p>DSL-10 280 B</p>
<p>V7-55 200 35</p>
<p>DSL-13 305 55 A+</p>
<p>V7-54 190 30 D</p>
<p>4</p>
<p>FordMondeo DSL-13 Purple</p>
<p>VolkswagenPolo V7-54 1200 Yellow</p>
<p>VolkswagenPassat DSL-10 1375 Blue</p>
<p>FordFusion DSL-13</p></td>
<td><p>FordMondeo:</p>
<p>DSL-13:</p>
<p>Power: 305</p>
<p>Displacement: 55</p>
<p>Efficiency: A+</p>
<p>Weight: n/a</p>
<p>Color: Purple</p>
<p>VolkswagenPolo:</p>
<p>V7-54:</p>
<p>Power: 190</p>
<p>Displacement: 30</p>
<p>Efficiency: D</p>
<p>Weight: 1200</p>
<p>Color: Yellow</p>
<p>VolkswagenPassat:</p>
<p>DSL-10:</p>
<p>Power: 280</p>
<p>Displacement: n/a</p>
<p>Efficiency: B</p>
<p>Weight: 1375</p>
<p>Color: Blue</p>
<p>FordFusion:</p>
<p>DSL-13:</p>
<p>Power: 305</p>
<p>Displacement: 55</p>
<p>Efficiency: A+</p>
<p>Weight: n/a</p>
<p>Color: n/a</p></td>
</tr>
</tbody>
</table>

## Jedi Galaxy

**Rework the following solutions in order to avoid repeating code,
increase readability and improve performance.**

Ivo's galaxy is represented as a two-dimensional array. You will receive
**two** integers, separated by a space, which represent the two
dimensional array - the first being the rows and the second being the
columns. Every cell in the matrix is a star that has a value. Ivo starts
at the given **row** and **col**. He can move only on the diagonal
**from the lowest left to the upper right**, and **adds** to his score
**all** the **stars** (values) from the cells he **passes through**.
Unfortunately, there is always an Evil power that tries to prevent his
success.

Evil power starts at the given **row** and **col** and instantly
**destroys** **all stars** on the **opposite** diagonal - **from lowest
right to the upper left.** Ivo **adds** the values only of the stars
that are **not** **destroyed** by the evil power.

Then, you must fill the two dimensional array with increasing integers
starting from 0, and continuing on every row, like this:

first row: 0, 1, 2… m

second row: n+1, n+2, n+3… n + n.

**Example:**

![](./media/image1.png)Ivo starts with coordinates **row = 5**, **col =
-1**. He must collect all stars with value **\[20, 16, 12, 8, 4\]**.
Evil starts with coordinates **row = 5**, **col = 5**. The Evil
**destroys** all stars in range **\[24, 18, 12, 6, 0\]**. The star with
value **12** is the **cross** **point** for Ivo and The Evil, so Ivo
**skips** the stars and **collects** only these who are not in the evil
range.

![](./media/image2.png)

You will also receive multiple pairs of commands in the form of 2
integers separated by a single space. The first two integers will
represent Ivo's start coordinates. The second one will represent the
Evil Power's start coordinates.

The input ends when you receive the command "**Let the Force be with
you**". When that happens, you must print the value of all stars that
Ivo has collected successfully.

### Input

  - On the first line, you will receive the number N, M -\> the
    dimensions of the matrix. You must then fill the matrix according to
    these dimensions.

  - On the next several lines you will begin receiving 2 integers
    separated by a single **space**, which represent Ivo's row and col.
    On the next line you will receive the Evil Power's coordinates.

  - There will always be **at least 2 lines** of input to represent at
    least 1 path of Ivo and the Evil force.

  - When you receive the command, "**Let the Force be with you**" the
    input ends.

### Output

  - The output is simple. Print the sum of the values from all stars
    that Ivo has collected.

### Constraints

  - The dimensions of the matrix will be integers in the range \[5,
    2000\].

  - The given rows will be valid integers in the range \[0, 2000\].

  - The given columns will be valid integers in the range
    \[-2<sup>31</sup> + 1, 2<sup>31</sup> - 1\].

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>5 5</p>
<p>5 -1</p>
<p>5 5</p>
<p>Let the Force be with you</p></td>
<td>48</td>
</tr>
<tr class="even">
<td><p>5 5</p>
<p>4 -1</p>
<p>4 5</p>
<p>Let the Force be with you</p></td>
<td>29</td>
</tr>
</tbody>
</table>

## Hospital

Your task will be to prepare an electronic register for a hospital. In
the hospital we have different departments:

  - **Cardiology**

  - [**Oncology**](https://en.wikipedia.org/wiki/Oncology)

  - **[Emergency
    department](https://en.wikipedia.org/wiki/Emergency_department)**

  - **etc.**

Each department has **20** rooms for patients and **each room has 3
beds**. When a new patient goes in the hospital, he/she is placed on the
first free bed in the department. If there are no free beds, the patient
should go in another hospital. Of course, in every hospital there are
doctors. Each doctor can have patients in a different department. You
will receive an information about the patients in the format
**{Department} {Doctor} {Patient}**

After the **"Output"** command, you will receive some other commands
about what kind of output you need to print. The commands are:

  - **{Department}** - You need to **print all patients** in this
    department in the **order of receiving**.

  - **{Department} {Room}** - You need to **print all patients** in this
    room in **alphabetical order**.

  - **{Doctor}** - You need to **print all patients** for this doctor in
    **alphabetical order.**

The program ends when you receive command **"End"**.

### Input

On the first lines you will receive info for the hospital, department,
doctors and patients in the following format:

**{Department} {Doctor} {Patient}**

When you read the **"Output"** line you will get one or more commands
telling you what you need to print

Keep reading commands for printing untill you reach the command
**"End"**.

### Output

  - **{Department}** - print all patients in this department in order of
    receiving on a new line

  - **{Department} {Room}** - print all patients in this room in
    alphabetical order each on new line

  - **{Doctor}** - print all patients that are healed from doctor in
    alphabetical order on new line

### Constraints

  - **{Department}** - single word with length **1 \< n \< 100**

  - **{Doctor}** - name and surname, both with length **1 \< n \< 20**

  - **{Patient}** - unique name with length **1 \< n \< 20**

  - **{Room}** - integer **1 \<= n \<= 20**

  - Time limit: 0.3 sec. Memory limit: 16 MB.

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
<td><p>Cardiology Petar Petrov Ventsi</p>
<p>Oncology Ivaylo Kenov Valio</p>
<p>Emergency Mariq Mircheva Simo</p>
<p>Cardiology Genka Shikerova Simon</p>
<p>Emergency Ivaylo Kenov NuPogodi</p>
<p>Cardiology Gosho Goshov Esmeralda</p>
<p>Oncology Gosho Goshov Cleopatra</p>
<p>Output</p>
<p>Cardiology</p>
<p>End</p></td>
<td><p>Ventsi</p>
<p>Simon</p>
<p>Esmeralda</p></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Cardiology Petar Petrov Ventsi</p>
<p>Oncology Ivaylo Kenov Valio</p>
<p>Emergency Mariq Mircheva Simo</p>
<p>Cardiology Genka Shikerova Simon</p>
<p>Emergency Ivaylo Kenov NuPogodi</p>
<p>Cardiology Gosho Goshov Esmeralda</p>
<p>Oncology Gosho Goshov Cleopatra</p>
<p>Output</p>
<p>Cardiology 1</p>
<p>End</p></td>
<td><p>Esmeralda</p>
<p>Simon</p>
<p>Ventsi</p></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Cardiology Petar Petrov Ventsi</p>
<p>Oncology Ivaylo Kenov Valio</p>
<p>Emergency Mariq Mircheva Simo</p>
<p>Cardiology Genka Shikerova Simon</p>
<p>Emergency Ivaylo Kenov NuPogodi</p>
<p>Cardiology Gosho Goshov Esmeralda</p>
<p>Oncology Gosho Goshov Cleopatra</p>
<p>Output</p>
<p>Ivaylo Kenov</p>
<p>End</p></td>
<td><p>NuPogodi</p>
<p>Valio</p></td>
</tr>
</tbody>
</table>

## Greedy Times

Finally, you have unlocked the safe and reached the treasure\! Inside
there are all kinds of gems, cash in different currencies and gold
bullions. Next to you there is a bag which unfortunately has a limited
space. You don't have much time so you need to take as much wealth as
possible\! But in order to get a bigger amount of the most valuable
items, you need to keep the following rules:

  - The **gold amount** in your bag should **always** **be** **more**
    than **or equal** to the **gem** **amount** at **any** time

  - The **gem amount** should **always** **be** **more** than **or**
    **equal** to the **cash** **amount** at **any** time

If you read an **item** which **breaks** one of **these rules** you
**should not put** it in the **bag**. You should **always** be careful
**not** to **exceed** the overall **bag**'**s capacity,** because it
will tear down and you will lose everything\! You will receive the
**content** **of** the **safe** on a **single line** in the **format**
of **item - quantity** pairs, separated by **whitespace**. You need to
gather **only** **three** **types** of items:

  - Cash - All **three letter** items

  - Gem - All **items** which **end** on "**Gem**" (at least 4 symbols)

  - Gold - this type has **only one item** with the name - "**Gold**"

Each **item** which **does not** fall **in** one of the **above
categories** is **useless** and you should **skip it**. Reading item's
**names** should be **CASE-INSENSITIVE**. You should **aggregate**
**item's quantities** which have the **same** **name**.

If you've kept the rules you should escape successfully with a bag full
of wealth. Now it's time to review what you have managed to get out of
the safe. **Print all** the **types** ordered by **total amount** in
**descending order**. Inside a type, **order** the **items** first
**alphabetically** in **descending** order and **then by** their
**amount** in **ascending** order. Use the following format for each
type:

**"\<{type}\> ${total amount}"**

**"\#\#{item} - {amount}"** - each item from this type on new line

### Input

  - On the **first line**, you will receive a **number** which
    represents the **capacity** of the **bag**

  - On the **second line**, you will receive a **sequence** of **item -
    quantity** pairs

### Output

  - Print **only** the **types** from which you **have items in the
    bag**, ordered by **Total Amount** in descending order. Inside a
    type, order the **items** **first** **alphabetically** in
    **descending** order and **then** by **amount** in **ascending**
    **order**. Use the following format for each type:

**"\<{type}\> ${total amount}"**

**"\#\#{item} - {amount}"** - each item on new line

### Constraints

  - The Bag's **max capacity** will **always** be a **positive number**

  - All **quantities** will be **positive** **integer** in the range \[0
    … 2100000000\]

  - Each item of type **gem** will have a **name** - **at** **least 4**
    symbols

  - Time limit: 0.1 sec. Memory limit: 16 MB

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
<td><p>150</p>
<p>Gold 28 Rubygem 16 USD 9 GBP 8</p></td>
<td><p>&lt;Gold&gt; $28</p>
<p>##Gold - 28</p>
<p>&lt;Gem&gt; $16</p>
<p>##Rubygem - 16</p>
<p>&lt;Cash&gt; $9</p>
<p>##USD - 9</p></td>
</tr>
<tr class="even">
<td><p>24000010</p>
<p>USD 1030 Gold 300000 EmeraldGem 900000 Topazgem 290000 CHF 280000 Gold 10000000 JPN 10000 Rubygem 10000000 KLM 3120010</p></td>
<td><p>&lt;Gold&gt; $10300000</p>
<p>##Gold - 10300000</p>
<p>&lt;Gem&gt; $10290000</p>
<p>##Topazgem - 290000</p>
<p>##Rubygem - 10000000</p>
<p>&lt;Cash&gt; $3410010</p>
<p>##KLM - 3120010</p>
<p>##JPN - 10000</p>
<p>##CHF - 280000</p></td>
</tr>
<tr class="odd">
<td><p>80345</p>
<p>RubyGem 70000 JAV 10960 Bau 60000 Gold 80000</p></td>
<td><p>&lt;Gold&gt; $80000</p>
<p>##Gold - 80000</p></td>
</tr>
</tbody>
</table>

## Sneaking

After our hero Sam got the recipe from the first problem, there is
another thing he needs to check off from his to-do list. In order to
make the recipe even more valuable, he needs to **"**eliminate**"**
anyone who possesses the knowledge of it. That person is Sam's sworn
enemy - **Nikoladze**. Sam needs to get through a rectangular room of
**patrolling** **enemies** until he finally **reaches Nikoladze**.

A standard room looks like this:

<table>
<thead>
<tr class="header">
<th><strong>Room</strong></th>
<th><strong>Legend</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>......N...<br />
b.........<br />
..d.......<br />
......d...<br />
.....S....</td>
<td><p><strong>S Sam,</strong> the player character</p>
<p><strong>b/d left/right-facing patrolling enemy</strong></p>
<p><strong>N Nikoladze</strong></p>
<p><strong>. Empty space</strong></p></td>
</tr>
</tbody>
</table>

Each turn proceeds as follows:

  - **Enemies** move either **left** or **right**, depending on which
    **direction** they are **facing** (**b** goes **right**, **d** goes
    **left**)
    
      - If an enemy is standing on the **edge** of the room, he flips
        his **direction** (from **d** to **b** or from **b** to **d**)

  - After that, Sam moves in the **direction** he is instructed to
    (either **U**/**D**/**L**/**R** or **W**, which means **wait**).

  - If **Sam** moves **onto an enemy** (**same row** and **column**),
    Sam **kills** the enemy and **leaves no trace of him**.

  - Otherwise, if an enemy is on the **same row** as Sam, and also
    **facing** **Sam** (eg. **.b.S.**), the **enemy** **kills Sam**.

  - If Sam reaches the **same row** as **Nikoladze**, **Sam** kills
    **Nikoladze** (replacing him with an **X**)

### Input

  - On the **first line** of input, you will receive n - the **number of
    rows** the **room** will consist of

  - On the next **n lines**, you will receive the **room**, which Sam
    will have to navigate.

  - On the **final line** of input, you will receive a sequence of
    **directions** - one of (U, D, L, R, W)

### Output

  - If Sam is **killed**, print **"Sam died at {row}, {col}".**

  - If Nikoladze is **killed**, print **"Nikoladze killed\!".**

  - Then, in both cases, **print** the **final state of the room** on
    the **console**, with either **Sam** or **Nikoladze**'**s**
    **symbols** replaced by an **X**.

### Constraints

  - The room will always be **rectangular**.

  - There will **always** be enough moves for **Sam** to reach
    **Nikoladze.**

  - There will be **no case** where **Sam** is instructed to move **out
    of the bounds of the room**.

  - There will be **no case** with **two enemies on the same row**.

  - There will be **no case** with an **enemy and Nikoladze** standing
    on the **same row**.

  - There will be **no case** where Sam reaches the same **row and
    column** as **Nikoladze**.

### Examples

<table>
<thead>
<tr class="header">
<th><strong>Input</strong></th>
<th><strong>Output</strong></th>
<th><strong>Comments</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>5</p>
<p>......N...</p>
<p>b.........</p>
<p>..d.......</p>
<p>......d...</p>
<p>.....S....</p>
<p>UUUUR</p></td>
<td><p>Sam died at 2, 5</p>
<p>......N...</p>
<p>...b......</p>
<p>b....X....</p>
<p>..........</p>
<p>..........</p></td>
<td><p>Turn 1: <strong>Enemies</strong> move, then Sam <strong>steps on</strong> the enemy on the <strong>4th</strong> row.</p>
<p>Turn 2: Enemies move, then Sam moves.</p>
<p>Turn 3: Enemy 2 <strong>turns around</strong>, Sam goes on the same row as him.</p>
<p>Turn 4: Enemy sees Sam and <strong>kills him</strong>.</p></td>
</tr>
<tr class="even">
<td><p>3</p>
<p>N......</p>
<p>.b.....</p>
<p>..dS...</p>
<p>WUUU</p></td>
<td><p>Nikoladze killed!</p>
<p>X..S...</p>
<p>.......</p>
<p>b......</p></td>
<td><p>Turn 1: Enemies move, Sam waits.</p>
<p>Turn 2: Enemies move, Sam goes <strong>up, steps on an enemy</strong>.</p>
<p>Turn 3: Enemies move, Sam goes <strong>up, kills Nikoladze</strong>.</p></td>
</tr>
<tr class="odd">
<td><p>6</p>
<p>.............</p>
<p>....S........</p>
<p>.b...........</p>
<p>...........d.</p>
<p>.............</p>
<p>....N........</p>
<p>WWWDWWWDDRD</p></td>
<td><p>Nikoladze killed!</p>
<p>.............</p>
<p>.............</p>
<p>............b</p>
<p>d............</p>
<p>.............</p>
<p>....XS.......</p></td>
<td><p>Turn 1/2/3: Enemies <strong>move</strong>, Sam <strong>waits</strong>.</p>
<p>Turn 4: Enemies <strong>move</strong>, Sam goes <strong>down</strong>.</p>
<p>Turn 5/6/7: Enemies <strong>move</strong>, Sam <strong>waits</strong>.</p>
<p>Turn 8/9: Enemies <strong>move</strong>, Sam goes <strong>down</strong>.</p>
<p>Turn 10: Enemies <strong>move</strong>, Sam goes <strong>right</strong>.</p>
<p>Turn 11: Enemies <strong>move</strong>, Sam goes <strong>down</strong> and <strong>kills</strong> Nikoladze.</p></td>
</tr>
</tbody>
</table>
