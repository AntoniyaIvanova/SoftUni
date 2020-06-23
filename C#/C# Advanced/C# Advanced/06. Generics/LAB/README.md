# Lab: Generics

Problems for the [<span class="underline">"CSharp Advanced" course @
Software University</span>](https://softuni.bg/courses/csharp-advanced).

You can check your solutions here:
<https://judge.softuni.bg/Contests/1474/Generics-Lab>

# Part I: Generics

## Box of T

**NOTE**: You need a public **StartUp** class with the namespace
**BoxOfT**.

Create a class **Box\<\>** that can store anything. It should have two
public methods:

  - void Add(element) – adds an element on the top of the list.

  - element Remove() – removes the topmost element.

  - int Count { get; }

### Examples

<table>
<tbody>
<tr class="odd">
<td><p>public static void Main(string[] args)</p>
<p>{</p>
<p>Box&lt;int&gt; box = new Box&lt;int&gt;();</p>
<p>box.Add(1);</p>
<p>box.Add(2);</p>
<p>box.Add(3);</p>
<p>Console.WriteLine(box.Remove());</p>
<p>box.Add(4);</p>
<p>box.Add(5);</p>
<p>Console.WriteLine(box.Remove());</p>
<p>}</p></td>
</tr>
</tbody>
</table>

### Hints

Use the syntax **Box\<T\>** to create a generic class

## Generic Array Creator

**NOTE**: You need a public **StartUp** class with the namespace
**GenericArrayCreator**.

Create a class **ArrayCreator** with a method and a single overload to
it:

  - static T\[\] Create(int length, T item)

The method should return an array with the given length and every
element should be set to the given default item.

###   
  
Examples

<table>
<tbody>
<tr class="odd">
<td><p>static void Main(string[] args)</p>
<p>{</p>
<p>string[] strings = ArrayCreator.Create(5, "Pesho");</p>
<p>int[] integers = ArrayCreator.Create(10, 33);</p>
<p>}</p></td>
</tr>
</tbody>
</table>

# Part II: Generic Constraints

## Generic Scale

**NOTE**: You need a public **StartUp** class with the namespace
**GenericScale**.

Create a class **EqualityScale\<T\>** that holds two elements - left and
right. The scale should receive the elements through its single
constructor:

  - EqualityScale(T left, T right)

The scale should have a single method:

  - bool AreEqual()

The greater of the two elements is the heavier. The method should return
**true** if the elements are equal.
