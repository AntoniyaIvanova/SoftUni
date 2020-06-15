# More Exercise: Associative Arrays

Problems for exercise and homework for the ["C\# Fundamentals" course @
SoftUni](https://softuni.bg/trainings/2363/csharp-fundamentals-may-2019)  
You can check your solutions in
[Judge](https://judge.softuni.bg/Contests/1302)

## Ranking

Here comes the final and the most interesting part – the Final ranking
of the candidate-interns. The final ranking is determined by the points
of the interview tasks and from the exams in SoftUni. Here is your final
task. You will receive some lines of input in the format
**“{contest}:{password for contest}”** until you receive **“end of
contests”**. Save that data because **you will need it later**. After
that you will receive other type of inputs in format
**“{contest}=\>{password}=\>{username}=\>{points}”** until you receive
**“end of submissions”**. Here is what you need to do.

  - Check if the **contest is valid (if you received it in the first
    type of input)**

  - Check if the **password is correct for the given contest**

  - Save the user with the contest they take part in **(a user can take
    part in many contests)** and the points the user has in the given
    contest. If you receive the **same contest and the same user update
    the points only if the new ones are more than the older ones.**

At the end you have to print the info for the user with the **most
points** in the format **“Best candidate is {user} with total {total
points} points.”**. After that print **all students ordered by their
names**. **For each user print each contest with the points in
descending order**. See the examples.

### Input

  - strings in format **“{contest}:{password for contest}”** until the
    **“end of contests”** command. There will be no case with two equal
    contests

  - strings in format
    **“{contest}=\>{password}=\>{username}=\>{points}”** until the
    **“end of submissions”** command.

  - **There will be no case with 2 or more users with same total
    points\!**

### Output

  - On the first line print the best user in format **“Best candidate is
    {user} with total {total points} points.”.**

  - Then print all students ordered as mentioned above in format:

> **{user1 name}**
> 
> **\# {contest1} -\> {points}**
> 
> **\# {contest2} -\> {points}**

### Constraints

  - the strings may contain any ASCII character except from **(:, =,
    \>)**

  - the numbers will be in range **\[0 - 10000\]**

  - second input is always valid

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

## Judge

You know the jude system, right?\! Your job is to create a program
similar to the Judge system.

You will receive **several input lines** in one of the following
formats:

{username} -\> {contest} -\> {points}

The **constestName and username** are strings, the given **points** will
be an integer number. You need to keep track of **every contest** and
**individual statistics of every user**. You should **check if such
contest already exists**, and if not, add it, otherwise **check if the
current user Is participating in the contest**, if he is participating
**take the higher score**, otherwise just **add it**.

Also you need to keep **individual statistics** for each **user -** the
**total points of all constests**.

You should end your program when you receive the command **"no more
time"**. At that point you should print each contest in **order of
input**, for each contest print the participants **ordered by points in
desecending order, than ordered by name in ascending order**. After
that, you should print **individual statistics for every participant**
ordered by **total points** in **desecnding** **order**, and **then by
alphabetical order**.

### Input / Constraints

  - The input comes in the form of commands in one of the formats
    specified above.

  - Username and contest name **always will be one word**.

  - Points will be an integer will be an **integer** in **range \[0,
    1000\]**.

  - There will be **no invalid** input lines.

  - If **all sorting criteria fail**, the order should be by **order**
    of **input**.

  - The input ends when you receive the command **"no more time"**.

### Output

  - The output format for the contests is:

> {constestName}: {participants.Count} participants

{position}. {username} **\<::\> {points}**

  - After you print all contests, print the **individual statistics for
    every participant.**

  - The output format is:

> Individual standings:
> 
> {position}. {username} -\> {totalPoints}

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
<td><p><strong>Pesho -&gt; Algo -&gt; 400</strong></p>
<p><strong>Gosho -&gt; Algo -&gt; 300</strong></p>
<p><strong>Stamat -&gt; Algo -&gt; 200</strong></p>
<p><strong>Pesho -&gt; DS -&gt; 150</strong></p>
<p><strong>Mimi -&gt; DS -&gt; 600</strong></p>
<p><strong>no more time</strong></p></td>
<td><p><strong>Algo: 3 participants</strong></p>
<p><strong>1. Pesho &lt;::&gt; 400</strong></p>
<p><strong>2. Gosho &lt;::&gt; 300</strong></p>
<p><strong>3. Stamat &lt;::&gt; 200</strong></p>
<p><strong>DS: 2 participants</strong></p>
<p><strong>1. Mimi &lt;::&gt; 600</strong></p>
<p><strong>2. Pesho &lt;::&gt; 150</strong></p>
<p><strong>Individual standings:</strong></p>
<p><strong>1. Mimi -&gt; 600</strong></p>
<p><strong>2. Pesho -&gt; 550</strong></p>
<p><strong>3. Gosho -&gt; 300</strong></p>
<p><strong>4. Stamat -&gt; 200</strong></p></td>
</tr>
<tr class="even">
<td><p><strong>Pesho -&gt; OOP -&gt; 350</strong></p>
<p><strong>Gosho -&gt; OOP -&gt; 250</strong></p>
<p><strong>Stamat -&gt; Advanced -&gt; 600</strong></p>
<p><strong>Gosho -&gt; OOP -&gt; 300</strong></p>
<p><strong>Prakash -&gt; OOP -&gt; 300</strong></p>
<p><strong>Prakash -&gt; Advanced -&gt; 250</strong></p>
<p><strong>Ani -&gt; JSCore -&gt; 400</strong></p>
<p><strong>no more time</strong></p></td>
<td><p><strong>OOP: 3 participants</strong></p>
<p><strong>1. Pesho &lt;::&gt; 350</strong></p>
<p><strong>2. Gosho &lt;::&gt; 300</strong></p>
<p><strong>3. Prakash &lt;::&gt; 300</strong></p>
<p><strong>Advanced: 2 participants</strong></p>
<p><strong>1. Stamat &lt;::&gt; 600</strong></p>
<p><strong>2. Prakash &lt;::&gt; 250</strong></p>
<p><strong>JSCore: 1 participants</strong></p>
<p><strong>1. Ani &lt;::&gt; 400</strong></p>
<p><strong>Individual standings:</strong></p>
<p><strong>1. Stamat -&gt; 600</strong></p>
<p><strong>2. Prakash -&gt; 550</strong></p>
<p><strong>3. Ani -&gt; 400</strong></p>
<p><strong>4. Pesho -&gt; 350</strong></p>
<p><strong>5. Gosho -&gt; 300</strong></p></td>
</tr>
</tbody>
</table>

## MOBA Challenger

Pesho is a pro MOBA player, he is struggling to become а master of the
Challenger tier. So he watches carefully the statistics in the tier.

You will receive **several input lines** in one of the following
formats:

"{player} -\> {position} -\> {skill}"

"{player} vs {player}"

The **player and position** are strings, the given **skill** will be an
integer number. You need to keep track of **every player**.

When you receive a **player and his position and skill**, add him to the
player pool, if he isn\`t present, **else add** his position and skill
**or update** his skill, only if the current position skill is lower
than the new value.

If you receive **"{player} vs {player}"** and **both players exist** in
the tier, **they duel** with the following rules:

Compare their positions, **if they got at least one in common**, the
player with better **total skill points** wins and the other is
**demoted** from the tier -\> remove him. If they have same total skill
points, **the duel is tie** and they both continue in the Season.

If they don\`t have positions in common, **the duel isn\`t happening**
and both continue in the Season.

You should end your program when you receive the command **"Season
end"**. At that point you should print the players, **ordered by total
skill in desecending order, then ordered by player name in ascending
order**. **Foreach** player print their position and skill, **ordered
desecending by skill, then ordered by position name in ascending
order.**

### Input / Constraints

  - The input comes in the form of commands in one of the formats
    specified above.

  - Player and position **will always be one word string, containing no
    whitespaces**.

  - Skill will be an **integer** in the **range \[0, 1000\]**.

  - There will be **no invalid** input lines.

  - The programm ends when you receive the command **"Season end"**.

### Output

  - The output format for each player is:

> "{player}: {totalSkill} skill"

"- {position} **\<::\> {skill}"**

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
<td><p><strong>Pesho -&gt; Adc -&gt; 400</strong></p>
<p><strong>Gosho -&gt; Jungle -&gt; 300</strong></p>
<p><strong>Stamat -&gt; Mid -&gt; 200</strong></p>
<p><strong>Stamat -&gt; Support -&gt; 250</strong></p>
<p><strong>Season end</strong></p></td>
<td><p><strong>Stamat: 450 skill</strong></p>
<p><strong>- Support &lt;::&gt; 250</strong></p>
<p><strong>- Mid &lt;::&gt; 200</strong></p>
<p><strong>Pesho: 400 skill</strong></p>
<p><strong>- Adc &lt;::&gt; 400</strong></p>
<p><strong>Gosho: 300 skill</strong></p>
<p><strong>- Jungle &lt;::&gt; 300</strong></p></td>
<td><strong>We order the players by total skill points descending, then by name. We print every position along its skill ordered descending by skill, then by position name.</strong></td>
</tr>
<tr class="even">
<td><p><strong>Pesho -&gt; Adc -&gt; 400</strong></p>
<p><strong>Bush -&gt; Tank -&gt; 150</strong></p>
<p><strong>Faker -&gt; Mid -&gt; 200</strong></p>
<p><strong>Faker -&gt; Support -&gt; 250</strong></p>
<p><strong>Faker -&gt; Tank -&gt; 250</strong></p>
<p><strong>Pesho vs Faker</strong></p>
<p><strong>Faker vs Bush</strong></p>
<p><strong>Faker vs Hide</strong></p>
<p><strong>Season end</strong></p></td>
<td><p><strong>Faker: 700 skill</strong></p>
<p><strong>- Support &lt;::&gt; 250</strong></p>
<p><strong>- Tank &lt;::&gt; 250</strong></p>
<p><strong>- Mid &lt;::&gt; 200</strong></p>
<p><strong>Pesho: 400 skill</strong></p>
<p><strong>- Adc &lt;::&gt; 400</strong></p></td>
<td><p><strong>Faker and Pesho don`t have common position, so the duel isn`t valid.</strong></p>
<p><strong>Faker wins vs Bush /common position: "Tank". Bush is demoted.</strong></p>
<p><strong>Hide doesn`t exist so the duel isn`t valid.</strong></p>
<p><strong>We print every player left in the tier.</strong></p></td>
</tr>
</tbody>
</table>

## Snowwhite

Snow White loves her dwarfs, but there are so many and she doesn’t know
how to order them. Does she order them by name? Or by color of their
hat? Or by physics? She can’t decide, so its up to you to write a
program that does it for her.

You will be receiving **several input lines** which contain **data**
about **dwarfs** in the following format:

{dwarfName} \<:\> {dwarfHatColor} \<:\> {dwarfPhysics}

The **dwarfName** and the **dwarfHatColor** are **strings**. The
**dwarfPhysics** is an **integer**.

You must **store** the **dwarfs** in your program. There are several
rules though:

  - If **2 dwarfs** have the **same name** but **different color**, they
    should be **considered different dwarfs**, and you should store
    **both** of them.

  - If **2 dwarfs** have the **same name** and the **same color**,
    **store** the **one** with the **higher physics**.

When you receive the command “**Once upon a time**”, the input ends. You
must **order** the **dwarfs** by **physics** in **descending order** and
then by **total** **count** of **dwarfs** with the **same hat color** in
**descending order**.  
Then you must print them all.

### Input

  - The input will consists of **several input lines**, containing
    **dwarf data** in the format, specified above.

  - The input **ends** when you receive the command “**Once upon a
    time**”.

### Output

  - As output you must print the **dwarfs**, **ordered** in the way ,
    specified above.

  - The output format is: **({hatColor}) {name} \<-\> {physics}**

### Constraints

  - The **dwarfName** will be a **string** which may contain **any
    ASCII** character except ‘ ’ (**space**), ‘**\<**’, ‘**:**’,
    ‘**\>**’.

  - The **dwarfHatColor** will be a **string** which may contain **any
    ASCII** character except ‘ ’ (**space**), ‘**\<**’, ‘**:**’,
    ‘**\>**’.

  - The **dwarfPhysics** will be an **integer** in **range \[0,
    2<sup>31</sup> – 1\]**.

  - There will be **no invalid** input lines.

  - If **all sorting criteria fail**, the order should be by **order**
    of **input**.

<!-- end list -->

  - Allowed working **time** / **memory**: **100ms** / **16MB**.

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
<td><p>Pesho &lt;:&gt; Red &lt;:&gt; 2000</p>
<p>Tosho &lt;:&gt; Blue &lt;:&gt; 1000</p>
<p>Gosho &lt;:&gt; Green &lt;:&gt; 1000</p>
<p>Sasho &lt;:&gt; Yellow &lt;:&gt; 4500</p>
<p>Prakasho &lt;:&gt; Stamat &lt;:&gt; 1000</p>
<p>Once upon a time</p></td>
<td><p>(Yellow) Sasho &lt;-&gt; 4500</p>
<p>(Red) Pesho &lt;-&gt; 2000</p>
<p>(Blue) Tosho &lt;-&gt; 1000</p>
<p>(Green) Gosho &lt;-&gt; 1000</p>
<p>(Stamat) Prakasho &lt;-&gt; 1000</p></td>
</tr>
<tr class="even">
<td><p>Pesho &lt;:&gt; Red &lt;:&gt; 5000</p>
<p>Pesho &lt;:&gt; Blue &lt;:&gt; 10000</p>
<p>Pesho &lt;:&gt; Red &lt;:&gt; 10000</p>
<p>Gosho &lt;:&gt; Blue &lt;:&gt; 10000</p>
<p>Once upon a time</p></td>
<td><p>(Blue) Pesho &lt;-&gt; 10000</p>
<p>(Blue) Gosho &lt;-&gt; 10000</p>
<p>(Red) Pesho &lt;-&gt; 10000</p></td>
</tr>
</tbody>
</table>

## Dragon Army

Heroes III is the best game ever. Everyone loves it and everyone plays
it all the time. Stamat is no exclusion to this rule. His favorite units
in the game are all **types** of dragons – black, red, gold, azure etc…
He likes them so much that he gives them **names** and keeps logs of
their **stats**: **damage, health** and **armor**. The process of
aggregating all the data is quite tedious, so he would like to have a
program doing it. Since he is no programmer, it’s your task to help him.

You need to categorize dragons by their **type**. For each dragon,
identified by **name,** keep information about his **stats.** Type is
**preserved** as in the order of input, but dragons are **sorted**
alphabetically by name. For each type, you should also print the average
**damage**, **health** and **armor** of the dragons. For each dragon,
print his own stats.

There **may** be **missing** stats in the input, though. If a stat is
missing you should assign it default values. Default values are as
follows: health **250**, damage **45**, and armor **10**. Missing stat
will be marked by **null**.

The input is in the following format **{type} {name} {damage} {health}
{armor}.** Any of the integers may be assigned null value. See the
examples below for better understanding of your task.

If the same dragon is added a second time, the new stats should
**overwrite** the previous ones. Two dragons are considered **equal** if
they match by **both** name and type.

### Input

  - On the first line, you are given number N -\> the number of dragons
    to follow

  - On the next N lines, you are given input in the above described
    format. There will be single space separating each element.

### Output

  - > Print the aggregated data on the console

  - > For each type, print average stats of its dragons in format
    > **{Type}::({damage}/{health}/{armor})**

  - > Damage, health and armor should be rounded to two digits after the
    > decimal separator

  - > For each dragon, print its stats in format **-{Name} -\> damage:
    > {damage}, health: {health}, armor: {armor}**

### Constraints

  - > N is in range \[1…100\]

  - > The dragon type and name are one word only, starting with capital
    > letter.

  - > Damage health and armor are integers in range \[0 … 100000\] or
    > **null**

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
<td><p>5</p>
<p>Red Bazgargal 100 2500 25</p>
<p>Black Dargonax 200 3500 18</p>
<p>Red Obsidion 220 2200 35</p>
<p>Blue Kerizsa 60 2100 20</p>
<p>Blue Algordox 65 1800 50</p></td>
<td><p>Red::(160.00/2350.00/30.00)</p>
<p>-Bazgargal -&gt; damage: 100, health: 2500, armor: 25</p>
<p>-Obsidion -&gt; damage: 220, health: 2200, armor: 35</p>
<p>Black::(200.00/3500.00/18.00)</p>
<p>-Dargonax -&gt; damage: 200, health: 3500, armor: 18</p>
<p>Blue::(62.50/1950.00/35.00)</p>
<p>-Algordox -&gt; damage: 65, health: 1800, armor: 50</p>
<p>-Kerizsa -&gt; damage: 60, health: 2100, armor: 20</p></td>
</tr>
<tr class="even">
<td><p>4</p>
<p>Gold Zzazx null 1000 10</p>
<p>Gold Traxx 500 null 0</p>
<p>Gold Xaarxx 250 1000 null</p>
<p>Gold Ardrax 100 1055 50</p></td>
<td><p>Gold::(223.75/826.25/17.50)</p>
<p>-Ardrax -&gt; damage: 100, health: 1055, armor: 50</p>
<p>-Traxx -&gt; damage: 500, health: 250, armor: 0</p>
<p>-Xaarxx -&gt; damage: 250, health: 1000, armor: 10</p>
<p>-Zzazx -&gt; damage: 45, health: 1000, armor: 10</p></td>
</tr>
</tbody>
</table>
