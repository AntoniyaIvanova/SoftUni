# Exercises: Sets and Dictionaries Advanced

Problems for exercises and homework for the ["C\# Advanced" course @
SoftUni](https://softuni.bg/courses/csharp-advanced).

You can check your solutions here:
<https://judge.softuni.bg/Contests/1466/Sets-and-Dictionaries-Advanced-Exercise>

## Unique Usernames

Write a program that reads from the console a sequence of **N
usernames** and keeps a collection only of the **unique** ones. On the
**first** line you will be given an integer **N**. On the next **N**
lines you will receive **one** username **per** **line**. Print the
collection on the console in **order** of **insertion**:

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
<td><p>6</p>
<p>Ivan</p>
<p>Ivan</p>
<p>Ivan</p>
<p>Pesho</p>
<p>Ivan</p>
<p>NiceGuy1234</p></td>
<td><p>Ivan</p>
<p>Pesho</p>
<p>NiceGuy1234</p></td>
</tr>
</tbody>
</table>

## Sets of Elements

Write a program that prints a **set of elements**. On the first line you
will receive two numbers - **n** and **m**, which represent the lengths
of two separate sets. On the next **n** + **m** lines you will receive
**n** numbers, which are the numbers in the **first** set, and **m**
numbers, which are in the **second** set. Find all the **unique**
**elements** that appear in **both of them** and **print** them in the
order in which they appear in the **first** set - **n**.

**For example:**

Set with length n = 4: {1, **3**, **5**, 7}

Set with length m = 3: {**3**, 4, **5**}

Set that contains all the **elements** that repeat in **both** **sets**
-\> {**3**, **5**}

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
<td><p>4 3</p>
<p>1</p>
<p>3</p>
<p>5</p>
<p>7</p>
<p>3</p>
<p>4</p>
<p>5</p></td>
<td>3 5</td>
</tr>
<tr class="even">
<td><p>2 2</p>
<p>1</p>
<p>3</p>
<p>1</p>
<p>5</p></td>
<td>1</td>
</tr>
</tbody>
</table>

## Periodic Table

Write a program that keeps all the **unique** chemical **elements**. On
the first line you will be given a number **n** - the **count** of input
**lines** that you are going to receive. On the next **n** lines you
will be receiving **chemical** **compounds**, separated by a **single**
**space**. Your task is to print all the **unique ones** in
**ascending** **order**:

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
<p>Ce O</p>
<p>Mo O Ce</p>
<p>Ee</p>
<p>Mo</p></td>
<td>Ce Ee Mo O</td>
</tr>
<tr class="even">
<td><p>3</p>
<p>Ge Ch O Ne</p>
<p>Nb Mo Tc</p>
<p>O Ne</p></td>
<td>Ch Ge Mo Nb Ne O Tc</td>
</tr>
</tbody>
</table>

## Even Times

Write a program that **prints** a **number** from a collection, which
appears an **even** **number** of **times** in it. On the first line,
you will be given **n** – the **count** of **integers** you will
receive. On the next n lines you will be receiving **the numbers**. It
is **guaranteed** that **only** **one** of them **appears** an **even**
**number** of times. Your task is to **find** that **number** and
**print** it in the end.

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
<td><p>3</p>
<p>2</p>
<p>-1</p>
<p>2</p></td>
<td>2</td>
</tr>
<tr class="even">
<td><p>5</p>
<p>1</p>
<p>2</p>
<p>3</p>
<p>1</p>
<p>5</p></td>
<td>1</td>
</tr>
</tbody>
</table>

## Count Symbols

Write a program that reads some **text** from the console and **counts**
the **occurrences** of **each** character in it. Print the results in
**alphabetical** (lexicographical) order.

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
<td>SoftUni rocks</td>
<td><p>: 1 time/s</p>
<p>S: 1 time/s</p>
<p>U: 1 time/s</p>
<p>c: 1 time/s</p>
<p>f: 1 time/s</p>
<p>i: 1 time/s</p>
<p>k: 1 time/s</p>
<p>n: 1 time/s</p>
<p>o: 2 time/s</p>
<p>r: 1 time/s</p>
<p>s: 1 time/s</p>
<p>t: 1 time/s</p></td>
</tr>
<tr class="even">
<td>Did you know Math.Round rounds to the nearest even integer?</td>
<td><p>: 9 time/s</p>
<p>.: 1 time/s</p>
<p>?: 1 time/s</p>
<p>D: 1 time/s</p>
<p>M: 1 time/s</p>
<p>R: 1 time/s</p>
<p>a: 2 time/s</p>
<p>d: 3 time/s</p>
<p>e: 7 time/s</p>
<p>g: 1 time/s</p>
<p>h: 2 time/s</p>
<p>i: 2 time/s</p>
<p>k: 1 time/s</p>
<p>n: 6 time/s</p>
<p>o: 5 time/s</p>
<p>r: 3 time/s</p>
<p>s: 2 time/s</p>
<p>t: 5 time/s</p>
<p>u: 3 time/s</p>
<p>v: 1 time/s</p>
<p>w: 1 time/s</p>
<p>y: 1 time/s</p></td>
</tr>
</tbody>
</table>

## Wardrobe

Write a program that helps you decide what **clothes** to wear from your
**wardrobe**. You will receive the **clothes**, which are currently in
your wardrobe, sorted by their **color** in the following **format**:

"**{color} -\> {item1},{item2},{item3}…**"

If you receive a certain color, which already **exists** in your
wardrobe, just **add** the clothes to **its** **records**. You can also
receive **repeating** **items** for a certain **color** and you have to
keep their **count**.

In the end, you will receive a **color** and a piece of **clothing**,
which you will **look for** in the wardrobe, separated by a space in the
following format:

**"{color} {clothing}"**

Your task is to print all the **items** and their **count** for **each**
**color** in the following format**:**

**"{color}** **clothes**:

\* **{item1}** - **{count}**

\* **{item2}** - **{count}**

\* **{item3}** - **{count}**

…

\* **{itemN}** - **{count}"**

If you find the **item** you are **looking for**, you need to print
**"(found\!)"** next to it:

"\* **{itemN}** - **{count} (found\!)"**

### Input

  - On the **first** **line**, you will receive **n** – the **number of
    lines** of clothes, which you will receive.

  - On the next **n** lines, you will receive the **clothes** in the
    **format** **described** above.

### Output

  - Print the **clothes** from your wardrobe in the **format**
    **described** above

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
<p>Blue -&gt; dress,jeans,hat</p>
<p>Gold -&gt; dress,t-shirt,boxers</p>
<p>White -&gt; briefs,tanktop</p>
<p>Blue -&gt; gloves</p>
<p>Blue dress</p></td>
<td><p>Blue clothes:</p>
<p>* dress - 1 (found!)</p>
<p>* jeans - 1</p>
<p>* hat - 1</p>
<p>* gloves - 1</p>
<p>Gold clothes:</p>
<p>* dress - 1</p>
<p>* t-shirt - 1</p>
<p>* boxers - 1</p>
<p>White clothes:</p>
<p>* briefs - 1</p>
<p>* tanktop - 1</p></td>
</tr>
<tr class="even">
<td><p>4</p>
<p>Red -&gt; hat</p>
<p>Red -&gt; dress,t-shirt,boxers</p>
<p>White -&gt; briefs,tanktop</p>
<p>Blue -&gt; gloves</p>
<p>White tanktop</p></td>
<td><p>Red clothes:</p>
<p>* hat - 1</p>
<p>* dress - 1</p>
<p>* t-shirt - 1</p>
<p>* boxers - 1</p>
<p>White clothes:</p>
<p>* briefs - 1</p>
<p>* tanktop - 1 (found!)</p>
<p>Blue clothes:</p>
<p>* gloves - 1</p></td>
</tr>
<tr class="odd">
<td><p>5</p>
<p>Blue -&gt; shoes</p>
<p>Blue -&gt; shoes,shoes,shoes</p>
<p>Blue -&gt; shoes,shoes</p>
<p>Blue -&gt; shoes</p>
<p>Blue -&gt; shoes,shoes</p>
<p>Red tanktop</p></td>
<td><p>Blue clothes:</p>
<p>* shoes - 9</p></td>
</tr>
</tbody>
</table>

## \*The V-Logger

Create a program that keeps information about **vloggers** and their
**followers**. The **input** will come as a sequence of strings, where
each string will represent a **valid** command. The commands will be
presented in the following format:

  - "**{vloggername}**" **joined The V-Logger** – keep the vlogger in
    your records.
    
      - > Vloggernames **consist** **of only one word**.
    
      - > If the **given** **vloggername** already **exists, ignore**
        > that command**.**

  - "**{vloggername} followed {vloggername}**" – The first vlogger
    followed the second vlogger.
    
      - > If **any** of the **given vlogernames** **does not exist** in
        > you collection, **ignore** that command**.**
    
      - > Vlogger **cannot** follow **himself**
    
      - > Vlogger **cannot** follow someone he is **already a follower**
        > **of**

  - **"Statistics" -** Upon receiving this command, you have to print a
    statistic about the vloggers.

Each vlogger has an unique **vloggername**. **Vloggers** can **follow
other vloggers** and a vlogger **can follow** **as many other vloggers**
**as he wants**, but he **cannot** follow **himself** or follow someone
he is **already a follower** **of**. You need to print the **total**
**count** of **vloggers** in your collection. Then you have to print the
**most** **famous** **vlogger** – the one with the most followers, with
**his** **followers.** If more than one vloggers have the **same**
**number** of **followers**, print the one **following less** people and
his **followers** should be printed in **lexicographical order (**in
case the vlogger has **no followers**, print just the first line, which
is described **below**). Lastly, print the **rest** **vloggers**,
ordered by the **count** of followers in **descending** order, then by
the number of vloggers he follows in **ascending** **order.** The
**whole output must be** in the following format:

**"****The V-Logger has a total of {registered vloggers} vloggers in its
logs.**

**1. {mostFamousVlogger} : {followers} followers, {followings}
following**

**\*** {follower1}

\* {follower2} …

**{No}. {vlogger} : {followers} followers, {followings} following**

**{No}. {vlogger} : {followers} followers, {followings} following…"**

### Input

  - The input will come in the format described above.

### Output

  - On the first line, print **the total count of vloggers** in the
    format described above.

  - On the second line, print the **most** **famous** vlogger in the
    format described above.

  - On the **next** lines, print all of the **rest** vloggers in the
    format described above.

### Constraints

  - There will be **no** **invalid** input.

  - There will be no situation where **two** **vloggers** have **equal**
    count of **followers** and **equal** count of **followings**

  - Allowed time/memory: **100ms/16MB**.

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
<td><p>EmilConrad joined The V-Logger</p>
<p>VenomTheDoctor joined The V-Logger</p>
<p>Saffrona joined The V-Logger</p>
<p>Saffrona <strong>followed</strong> EmilConrad</p>
<p>Saffrona <strong>followed</strong> VenomTheDoctor</p>
<p>EmilConrad <strong>followed</strong> VenomTheDoctor</p>
<p>VenomTheDoctor <strong>followed</strong> VenomTheDoctor</p>
<p>Saffrona <strong>followed</strong> EmilConrad</p>
<p>Statistics</p></td>
<td><p>The V-Logger has a total of 3 vloggers in its logs.</p>
<p>1. VenomTheDoctor : 2 followers, 0 following</p>
<p>* EmilConrad</p>
<p>* Saffrona</p>
<p>2. EmilConrad : 1 followers, 1 following</p>
<p>3. Saffrona : 0 followers, 2 following</p></td>
</tr>
<tr class="even">
<td><p>JennaMarbles joined The V-Logger</p>
<p>JennaMarbles followed Zoella</p>
<p>AmazingPhil joined The V-Logger</p>
<p>JennaMarbles followed AmazingPhil</p>
<p>Zoella joined The V-Logger</p>
<p>JennaMarbles followed Zoella</p>
<p>Zoella followed AmazingPhil</p>
<p>Christy followed Zoella</p>
<p>Zoella followed Christy</p>
<p>JacksGap joined The V-Logger</p>
<p>JacksGap followed JennaMarbles</p>
<p>PewDiePie joined The V-Logger</p>
<p>Zoella joined The V-Logger</p>
<p>Statistics</p></td>
<td><p>The V-Logger has a total of 5 vloggers in its logs.</p>
<p>1. AmazingPhil : 2 followers, 0 following</p>
<p>* JennaMarbles</p>
<p>* Zoella</p>
<p>2. Zoella : 1 followers, 1 following</p>
<p>3. JennaMarbles : 1 followers, 2 following</p>
<p>4. PewDiePie : 0 followers, 0 following</p>
<p>5. JacksGap : 0 followers, 1 following</p></td>
</tr>
</tbody>
</table>

## \*Ranking

Write a program that **ranks** candidate-interns, depending on the
**points** from the **interview** **tasks** and their **exam**
**results** in SoftUni. You will receive some lines of **input** in the
format **"{contest}:{password for contest}"** until you receive **"end
of contests"**. Save that data because **you will need it later**. After
that you will receive other type of inputs in format
**"{contest}=\>{password}=\>{username}=\>{points}"** until you receive
**"end of submissions"**. Here is what you need to do:

  - Check if the **contest is valid (if you received it in the first
    type of input)**

<!-- end list -->

  - Check if the **password is correct for the given contest**

  - Save the user with the **contest** they take part in **(a user can
    take part in many contests)** and the points the user has in the
    **given** **contest**. If you receive the **same contest** and the
    **same user, update** the **points only if the new ones** are **more
    than** the **older ones.**

At the end you have to print the info for the user with the **most
points** in the format:

**"Best candidate is {user} with total {total points} points."**. After
that print **all students ordered** by their **names**. For **each**
user, print **each contest** with the **points** in **descending** order
in the following format:

**"{user1 name}**

**\# {contest1} -\> {points}**

**\# {contest2} -\> {points}**

**{user2 name}**

**…"**

### Input

  - You will be receiving strings in formats described above, until the
    appropriate commands, also described above, are given.

### Output

  - On the **first** line print the best user in the format
    **described** above.

  - On the **next** lines print all students ordered as mentioned above
    in format.

### Constraints

  - There will be **no** case with two **equal** **contests**.

<!-- end list -->

  - The **strings** may contain any ASCII character except from **(:, =,
    \>).**

  - The **numbers** will be in range **\[0 - 10000\]**.

  - The **second** input is always **valid**.

  - There will be no case with **2** or **more** users with **same**
    **total** **points**.

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
<td><p>Part One Interview:success</p>
<p>Js Fundamentals:Pesho</p>
<p>C# Fundamentals:fundPass</p>
<p>Algorithms:fun</p>
<p>end of contests</p>
<p>C# Fundamentals=&gt;fundPass=&gt;Tanya=&gt;350</p>
<p>Algorithms=&gt;fun=&gt;Tanya=&gt;380</p>
<p>Part One Interview=&gt;success=&gt;Nikola=&gt;120</p>
<p>Java Basics Exam=&gt;pesho=&gt;Petkan=&gt;400</p>
<p>Part One Interview=&gt;success=&gt;Tanya=&gt;220</p>
<p>OOP Advanced=&gt;password123=&gt;BaiIvan=&gt;231</p>
<p>C# Fundamentals=&gt;fundPass=&gt;Tanya=&gt;250</p>
<p>C# Fundamentals=&gt;fundPass=&gt;Nikola=&gt;200</p>
<p>Js Fundamentals=&gt;Pesho=&gt;Tanya=&gt;400</p>
<p>end of submissions</p></td>
<td><p>Best candidate is Tanya with total 1350 points.</p>
<p>Ranking:</p>
<p>Nikola</p>
<p># C# Fundamentals -&gt; 200</p>
<p># Part One Interview -&gt; 120</p>
<p>Tanya</p>
<p># Js Fundamentals -&gt; 400</p>
<p># Algorithms -&gt; 380</p>
<p># C# Fundamentals -&gt; 350</p>
<p># Part One Interview -&gt; 220</p></td>
</tr>
<tr class="even">
<td><p>Java Advanced:funpass</p>
<p>Part Two Interview:success</p>
<p>Math Concept:asdasd</p>
<p>Java Web Basics:forrF</p>
<p>end of contests</p>
<p>Math Concept=&gt;ispass=&gt;Monika=&gt;290</p>
<p>Java Advanced=&gt;funpass=&gt;Simona=&gt;400</p>
<p>Part Two Interview=&gt;success=&gt;Drago=&gt;120</p>
<p>Java Advanced=&gt;funpass=&gt;Petyr=&gt;90</p>
<p>Java Web Basics=&gt;forrF=&gt;Simona=&gt;280</p>
<p>Part Two Interview=&gt;success=&gt;Petyr=&gt;0</p>
<p>Math Concept=&gt;asdasd=&gt;Drago=&gt;250</p>
<p>Part Two Interview=&gt;success=&gt;Simona=&gt;200</p>
<p>end of submissions</p></td>
<td><p>Best candidate is Simona with total 880 points.</p>
<p>Ranking:</p>
<p>Drago</p>
<p># Math Concept -&gt; 250</p>
<p># Part Two Interview -&gt; 120</p>
<p>Petyr</p>
<p># Java Advanced -&gt; 90</p>
<p># Part Two Interview -&gt; 0</p>
<p>Simona</p>
<p># Java Advanced -&gt; 400</p>
<p># Java Web Basics -&gt; 280</p>
<p># Part Two Interview -&gt; 200</p></td>
</tr>
</tbody>
</table>
