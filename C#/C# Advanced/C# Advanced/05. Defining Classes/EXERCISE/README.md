# Exercise: Defining Classes

Problems for exercise and homework for the <span class="underline">["C\#
Advanced" course @ Software
University](https://softuni.bg/courses/csharp-advanced).</span>  
You can check your solutions here:
<https://judge.softuni.bg/Contests/1479/Defining-Classes-Exercise>

## Define a Class Person

**NOTE**: You need a **StartUp** class with the namespace
**DefiningClasses**.

Define a class **Person** with **private** fields for **name** and
**age** and **public** properties **Name** and **Age**.

### Bonus\*

Try to create a few objects of type Person:

| **Name** | **Age** |
| -------- | ------- |
| Pesho    | 20      |
| Gosho    | 18      |
| Stamat   | 43      |

Use both the inline initialization and the default constructor.

## Creating Constructors

**NOTE**: You need a **StartUp** class with the namespace
**DefiningClasses**.

Add **3** constructors to the **Person** class from the last task. Use
constructor chaining to reuse code:

  - The **first** should take **no arguments** and produce a person with
    name "**No name**" and **age** **= 1**.

  - The **second** should accept only an integer **number** for the
    **age** and produce a person with name "**No name**" and **age**
    equal to the passed **parameter**.

  - The **third** one should accept a **string** for the **name** and an
    integer for the **age** and should produce a person with the given
    **name** and **age**.

## Oldest Family Member

Use your **Person** **class** from the previous tasks. Create a class
**Family**. The class should have a **list of people**, a method for
adding members - **void AddMember(Person member)** and a method
**returning the oldest family member – Person GetOldestMember().** Write
a program that reads the names and ages of **N** people and **adds them
to the family**. Then **print** the **name** and **age** of the oldest
member.

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
<p>Pesho 3</p>
<p>Gosho 4</p>
<p>Annie 5</p></td>
<td>Annie 5</td>
</tr>
<tr class="even">
<td><p>5</p>
<p>Steve 10</p>
<p>Christopher 15</p>
<p>Annie 4</p>
<p>Ivan 35</p>
<p>Maria 34</p></td>
<td>Ivan 35</td>
</tr>
</tbody>
</table>

## Opinion Poll

Using the **Person** class, write a program that reads from the console
**N** lines of personal information and then prints all people, whose
**age** is **more than 30** years, **sorted in alphabetical order**.

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
<p>Pesho 12</p>
<p>Stamat 31</p>
<p>Ivan 48</p></td>
<td><p>Ivan - 48</p>
<p>Stamat - 31</p></td>
</tr>
<tr class="even">
<td><p>5</p>
<p>Nikolai 33</p>
<p>Yordan 88</p>
<p>Tosho 22</p>
<p>Lyubo 44</p>
<p>Stanislav 11</p></td>
<td><p>Lyubo - 44</p>
<p>Nikolai - 33</p>
<p>Yordan - 88</p></td>
</tr>
</tbody>
</table>

## Date Modifier

Create a class **DateModifier**, which stores the difference of the days
between two dates. It should have a method which takes **two string
parameters** **representing a date** as strings and **calculates** the
difference in the days between them.

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
<td><p>1992 05 31</p>
<p>2016 06 17</p></td>
<td>8783</td>
</tr>
<tr class="even">
<td><p>2016 05 31</p>
<p>2016 04 19</p></td>
<td>42</td>
</tr>
</tbody>
</table>

## Speed Racing

Write a program that keeps track of **cars** and their **fuel** and
supports methods for **moving** the cars. Define a class **Car**. Each
Car has the following properties:

  - **string Model**

  - **double FuelAmount**

  - **double FuelConsumptionPer**K**ilometer**

  - **double Travelled distance**

A car’s model is **unique** - there will never be 2 cars with the same
model. On the first line of the input, you will receive a number **N** –
the **number** of **cars** you need to track. On each of the next **N**
lines, you will receive information about a car in the following format:

**"{model} {fuelAmount} {fuelConsumptionFor1km}"**

All **cars start at 0 kilometers traveled**. After the **N** lines,
until the command **"End"** is received, you will receive commands in
the following format:

"**Drive {carModel} {amountOfKm}**"

Implement a method in the **Car** class to calculate whether or not a
car can **move** that **distance**. If it can, the car’s **fuel amount**
should be **reduced** by the amount of **used** **fuel** and its
**traveled** **distance** should be increased by the number of the
**traveled kilometers**. Otherwise, the car should not move (its fuel
amount and the traveled distance should stay the same) and you should
print on the console:

"**Insufficient fuel for the drive**"

After the "**End**" command is received, print **each car** and its
**current fuel amount** and the **traveled** **distance** in the format:

**"{model} {fuelAmount} {distanceTraveled}**"

Print the fuel amount formatted **two digits** after the decimal
separator.

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
<p>AudiA4 23 0.3</p>
<p>BMW-M2 45 0.42</p>
<p>Drive BMW-M2 56</p>
<p>Drive AudiA4 5</p>
<p>Drive AudiA4 13</p>
<p>End</p></td>
<td><p>AudiA4 17.60 18</p>
<p>BMW-M2 21.48 56</p></td>
</tr>
<tr class="even">
<td><p>3</p>
<p>AudiA4 18 0.34</p>
<p>BMW-M2 33 0.41</p>
<p>Ferrari-488Spider 50 0.47</p>
<p>Drive Ferrari-488Spider 97</p>
<p>Drive Ferrari-488Spider 35</p>
<p>Drive AudiA4 85</p>
<p>Drive AudiA4 50</p>
<p>End</p></td>
<td><p>Insufficient fuel for the drive</p>
<p>Insufficient fuel for the drive</p>
<p>AudiA4 1.00 50</p>
<p>BMW-M2 33.00 0</p>
<p>Ferrari-488Spider 4.41 97</p></td>
</tr>
</tbody>
</table>

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

## Car Salesman

Define two classes **Car** and **Engine.**

**Car** has the following properties:

  - **Model**

  - **Engine**

  - **Weight**

  - **Color**

Engine has the following properties:

  - **Model**

  - **Power**

  - **Displacement**

  - **Efficiency**

A Car’s **weight** and **color** and its Engine’s **displacement** and
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
real engine** in it, instead of just the engine’s model. Note that the
optional properties **might be missing** from the formats.

Your task is to **print** all the **cars** in the order they were
received and their information in the format defined bellow. If any of
the optional fields is missing, print "**n/a**" in its place:

{CarModel}:  
{EngineModel}:  
Power: {EnginePower}  
Displacement: {EngineDisplacement}  
Efficiency: {EngineEfficiency}  
Weight: {CarWeight}  
Color: {CarColor}

### Bonus\*

Override the classes’ **ToString()** methods to have a reusable way of
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

## Pokemon Trainer

Define a class **Trainer** and a class **Pokemon**.

**Trainers** have:

  - **Name**

  - **Number of badges**

  - **A collection of pokemon**

**Pokemon** have:

  - **Name**

  - **Element**

  - **Health**

All values are **mandatory**. Every Trainer **starts with 0 badges**.

You will be receiving lines until you receive the command
"**Tournament**". Each line will carry information about a pokemon and
the trainer who caught it in the format:

**"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"**

**TrainerName** is the name of the Trainer who caught the pokemon.
Trainers’ names are **unique**.  
After receiving the command "**Tournament**", you will start receiving
commands until the "**End**" command is received. They can contain one
of the following:

  - **"Fire"**

  - **"Water"**

  - **"Electricity"**

For every command you must check if a trainer has at least 1 pokemon
with the given element. If he does, he receives 1 badge. Otherwise, all
of his pokemon **lose 10 health**. If a pokemon falls **to 0 or less
health**, **he dies** and must be deleted from the trainer’s collection.
In the end, you should print all of the trainers, **sorted by the amount
of badges they have in descending order** (if two trainers have the same
amount of badges, they should be sorted by order of appearance in the
input) in the format:

**"{trainerName} {badges} {numberOfPokemon}"**

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
<td><p>Pesho Charizard Fire 100</p>
<p>Gosho Squirtle Water 38</p>
<p>Pesho Pikachu Electricity 10</p>
<p>Tournament</p>
<p>Fire</p>
<p>Electricity</p>
<p>End</p></td>
<td><p>Pesho 2 2</p>
<p>Gosho 0 1</p></td>
</tr>
<tr class="even">
<td><p>Stamat Blastoise Water 18</p>
<p>Nasko Pikachu Electricity 22</p>
<p>Jicata Kadabra Psychic 90</p>
<p>Tournament</p>
<p>Fire</p>
<p>Electricity</p>
<p>Fire</p>
<p>End</p></td>
<td><p>Nasko 1 1</p>
<p>Stamat 0 0</p>
<p>Jicata 0 1</p></td>
</tr>
</tbody>
</table>

## SoftUni Parking

#### Preparation

Download the skeleton provided in Judge. **Do not** change the
**StartUp** class or its **namespace**.

***Problem Description***

Your task is to create a repository, which stores cars by creating the
classes described below.

First, write a C\# class **Car** with the following properties:

  - **Make: string**

  - **Model: string**

  - **HorsePower: int**

  - **RegistrationNumber: string**

<table>
<tbody>
<tr class="odd">
<td><p><strong>public class Car</strong></p>
<p>{<br />
<em>// <strong>TODO: implement this class<br />
</strong></em>}</p></td>
</tr>
</tbody>
</table>

The class' **constructor** should receive **make, model, horsePower**
and **registrationNumber** and override the **ToString()** method in the
following format:

**"Make: {make}"**

**"Model: {model}"**

**"HorsePower: {horse power}"**

**"RegistrationNumber: {registration number}"**

Write a C\# class **Parking** that has **Cars** (a collection which
stores the entity **Car**). All entities inside the class have the
**same properties**.

<table>
<tbody>
<tr class="odd">
<td><p><strong>public class Parking</strong></p>
<p>{<br />
<em>// <strong>TODO: implement this class<br />
</strong></em>}</p></td>
</tr>
</tbody>
</table>

The class' **constructor** should initialize the **Cars** with a new
instance of the collection and accept **capacity** as a parameter**.**

Implement the following fields:

  - Field **cars** – a **collection** that holds added cars.

  - Field **capacity** – accessed only by the base class (responsible
    for the parking capacity).

Implement the following **methods**:

***AddCar(Car Car)***

The method first checks if there is already a car with the provided car
registration number and if there is, the method returns the following
message:

"Car with that registration number, already exists\!"

Next checks if the count of the cars in the parking is more than the
capacity and if it is returns the following message:

"Parking is full\!"

Finally if nothing from the previous conditions is true it just adds the
current car to the cars in the parking and returns the message:

"Successfully added new car {Make} {RegistrationNumber}"

***RemoveCar(string RegistrationNumber)***

Removes a car with the given registration number. If the provided
registration number does not exist returns the message:

"Car with that registration number, doesn't exist\!"

Otherwise, removes the car and returns the message:

"Successfully removed {registrationNumber}"

***GetCar(string RegistrationNumber)***

Returns the **Car** with the provided registration number.

***RemoveSetOfRegistrationNumber(List\<string\> RegistrationNumbers)***

A void method, which removes all cars that have the provided
registration numbers. Each car is removed only if the registration
number exists.

And the following **property**:

  - **Count** **-** Returns the number of stored cars.

#### Examples

This is an example how the **Parking** class is **intended to be used**.

<table>
<thead>
<tr class="header">
<th>Sample code usage</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>var car = new Car("Skoda", "Fabia", 65, "CC1856BG");</p>
<p>var car2 = new Car("Audi", "A3", 110, "EB8787MN");</p>
<p>Console.WriteLine(car.ToString());</p>
<p>//Make: Skoda</p>
<p>//Model: Fabia</p>
<p>//HorsePower: 65</p>
<p>//RegistrationNumber: CC1856BG</p>
<p>var parking = new Parking(5);</p>
<p>Console.WriteLine(parking.AddCar(car));</p>
<p>//Successfully added new car Skoda CC1856BG</p>
<p>Console.WriteLine(parking.AddCar(car));</p>
<p>//Car with that registration number, already exists!</p>
<p>Console.WriteLine(parking.AddCar(car2));</p>
<p>//Successfully added new car Audi EB8787MN</p>
<p>Console.WriteLine(parking.GetCar("EB8787MN").ToString());</p>
<p>//Make: Audi</p>
<p>//Model: A3</p>
<p>//HorsePower: 110</p>
<p>//RegistrationNumber: EB8787MN</p>
<p>Console.WriteLine(parking.RemoveCar("EB8787MN"));</p>
<p>//Successfullyremoved EB8787MN</p>
<p>Console.WriteLine(parking.Count); //1</p></td>
</tr>
</tbody>
</table>

#### Submission

Zip all the files in the project folder except **bin** and **obj**
folders.
