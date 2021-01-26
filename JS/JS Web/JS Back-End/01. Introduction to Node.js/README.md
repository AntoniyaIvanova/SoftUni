Cat Shelter
===========

The exercise itself will be distributed into several parts each
containing more concrete information and guide steps on how to develop
the functionality specified below.

*\"Cat Shelter\"* is very simple **cat** **catalog** which shows the
\"database\" (JSON file) of some **cat** **shelter** and **everyone**
(registration is not required) user can be their **potential**
**owner**. The application will consist of the basic CRUD operations
(**Create** cat, **Read** cat, **Update** cat and **Delete** cat).
**Each** **cat** has a **name**, **description**, **image** and
**breed**.

Project Specification {#project-specification .list-paragraph}
---------------------

Design and implement a \"***Cat Shelter***\" **web application**
(containing routing and multiple web pages) using HTML 5, CSS 3 and
Node.js. It must contain the following functionality:

### Functionality

-   **Add Cat Breed**

    -   Create cat **breed** which later can be picked when a new cat is
        added to the shelter

-   **Add Cat**

    -   Create a new cat, which has **name**, **description**, **image**
        and **breed**

    -   **All cats** must be saved in **json file** (that will be our
        database)

-   **List All Cats**

    -   List all cats from the \"database\" **no matter the breed**

-   **Edit Cat**

    -   Edits cat\'s information. Changes must be persisted in
        \"database\"

-   **Delete Cat**

    -   Deletes specific cat from database. Changes must be persisted in
        \"database\"

-   **Search Cat**

    -   Search in cat \"database\" by some **query** **string** and
        shows the results if any

### Examples

-   Home page ***(\'/\')***, where **all** created **cats** in the
    database are **shown**

![](media/image1.png){width="6.53125in" height="3.984722222222222in"}

-   Add Breed **(\'/addBreed\')**, where **new cat breed** can be
    created which later can be picked when a new cat is added to the
    shelter

![](media/image2.png){width="6.523611111111111in"
height="3.0388888888888888in"}

-   Add Cat **(\'/addCat\')**, where new cat can be created and stored
    in the shelter \"database\" and all created breeds before that are
    shown in the selected menu

> ![](media/image3.png){width="6.538888888888889in" height="3.84375in"}
>
> Currently these 5 breeds are created (**Bombay Cat**, **American
> Bobtail Cat**, **Bengal Cat**, **British Shorthair Cat** and
> **Unknown**)
>
> ![](media/image4.png){width="6.53125in" height="4.179861111111111in"}

**Expected Behavior**

Adding a new cat breed called \"**Persian cat**\"

![](media/image5.png){width="6.531944444444444in" height="2.025in"}

After that we create **a new** cat with the newly created **breed**
\"**Persian cat**\", **name** \"**Niya**\", **description** \"**Lonely
and lazy cat seek for a hospitable owner**\" and imported
image![](media/image6.png){width="6.531944444444444in"
height="4.156944444444444in"}

![](media/image7.png){width="6.531944444444444in" height="3.55625in"}

After clicking the **\[ADD CAT\] button**, a **redirect** should be
followed and the Home page **(\'/\')** should be shown with all cats in
the shelter, including the newly one

![](media/image8.png){width="6.531944444444444in"
height="4.336111111111111in"}

For instance, if we click over **Jerry\'s** **\[Change Info\] button,**
the following page should be shown

![](media/image9.png){width="6.531944444444444in"
height="3.6527777777777777in"}

We change Jerry\'s **name** and **breed**

![](media/image10.png){width="6.531944444444444in"
height="3.6465277777777776in"}

After clicking \[**EDIT CAT\]** **button**, the redirect to the Home
page (**\'/\'**) should follow and the changes should be applied

![](media/image11.png){width="6.531944444444444in" height="4.21875in"}

Now if we click over LeeRoy\'s \[**New Home**\] **button** the following
page should be shown

![](media/image12.png){width="6.531944444444444in"
height="4.628472222222222in"}

If we click over \[**SHELTER THE CAT**\] **button**, a Home page
(**\'/\'**) should be shown by redirection and the LeeRoy should be
**gone** because someone offered him a shelter and he became a pet

![](media/image13.png){width="6.531944444444444in"
height="2.6493055555555554in"}

If we use the search bar to check all Persian cats, the result should
be:

![](media/image14.png){width="6.531944444444444in"
height="2.936111111111111in"}

![](media/image15.png){width="6.531944444444444in"
height="2.8256944444444443in"}

### Routing

There will be different views which are displayed based on the routing
(the URL). There are no strict rules of how the current application
routing should look like but there are some common set of rules to
follow:

1.  Use **short** and **clear** URL\'s

    a.  Good examples

        -   \"/cats/add\"

        -   \"/cats/edit/3 \"

    b.  Bad examples

        -   \"/catAddInfo.html\"

        -   \"showAllProductsByCategoryName/{categoryName}\"

2.  Follow the **HTTP standards**

    a.  Proper usage of HTTP methods (GET, POST, PUT etc.)

    b.  Follow the GET -- POST -- Redirect pattern

### Models

**Cat**

-   **id - string or number** which is **required** and **unique**

-   **name - string** which is required

-   **description - string** containing some additional information
    about the cat

-   **image - string** containing **reference** to an **image** which
    displays the given cat

-   **breed - string** referring to the real breed on that cat

Laying the Project Fundamentals
===============================

Setup IDE
---------

For starter configure your IDE or text editor. As mentioned above the
following steps will include screenshots from [Visual Studio
Code](https://code.visualstudio.com/).

Other popular choices are [Atom](https://atom.io/) and
[WebStorm](https://www.jetbrains.com/webstorm/).

Before you continue with the next step make sure everything about your
IDE is configured and you are up and ready to go.

Initial Setup
-------------

First let's create our project

Go to the folder where you want the project to be, then press "*Shift*"
+ "*Right mouse click*" and use "*Open command window here*", then type
"**npm init**" and fill the project\'s data as you see
fit![](media/image16.png){width="4.1375in"
height="2.24292760279965in"}![](media/image17.png){width="4.160230752405949in"
height="1.7486111111111111in"}

If you are using **Visual Studio Code,** then in the same console (after
you have inserted all the needed information) type: "**code .**". This
will open the editor for you.

![](media/image18.png){width="3.32088145231846in"
height="1.3926377952755906in"}

![](media/image19.png){width="4.133333333333334in"
height="2.9569641294838145in"}

Now let\'s create the initial project folder structure. It may look like
this:

![](media/image20.png){width="3.716666666666667in"
height="1.9090146544181976in"}

Download the
[**resources**](http://svn.softuni.org/admin/svn/js-web/Sept-2019/JS-Back-End/01.%20JS-Back-End-Intro-to-NodeJS/01.%20Cat-Shelter-Workshop-Resources.zip)
and put the **site.css** and **favicon.ico** in the \"***content***\"
folder like this:

![](media/image21.png){width="3.217899168853893in"
height="2.140277777777778in"}

And move all **views** into the **views** **folder** like this:

![](media/image22.png){width="3.625in" height="3.0625in"}

**Start the Server**

Go to index.js file and start implementing the server.

First you should create **two** **constants**, one for the **http
module** and the another one for the **port** we will use for our
server.

![](media/image23.png){width="3.5416666666666665in"
height="0.8541666666666666in"}

Once we require our http module, we can create our server via
**createServer** **function.**

![](media/image24.png){width="3.8958333333333335in" height="1.90625in"}

When you do that, just open the Terminal with (**Ctrl** + **\`**) and
run the server with **node index** command

![](media/image25.png){width="5.020833333333333in" height="1.59375in"}

**Display the Home Page**

We will start implementing the logic for application in the following
steps. Note that the application doesn't have users.

First whenever we access our site, we want to display the \"default\"
page or so called \"home\" page. In order to do that we have to:

1.  Implement back-end logic of what to be displayed

2.  Write our view (the HTML and CSS)

3.  Make the server execute the logic we implement in the first step

Now go to \"**handlers\"** folder and add new \"**home.js**\". In the
beginning add the modules we are going to use:

![](media/image26.png){width="6.531944444444444in"
height="1.4958333333333333in"}

As we mention above, we will use **json files** to simulate a database,
so create one folder called \"**data**\" and create 2 json files
(**cats** and **breeds**)

![](media/image27.png){width="3.4875in" height="2.322321741032371in"}

And don't forget to include in into the home.js file. We will need them
later, but lets include them anyway.

![](media/image28.png){width="4.708333333333333in"
height="1.5208333333333333in"}

Then let\'s start with exporting the logic as a function which is
accepting both request and response. Then we can parse the requested URL
and attach it to the request object:

![](media/image29.png){width="5.9375in" height="1.0208333333333333in"}

Now we should tell the server when the home handler will handle request
(when the requested URL is: \"/\" and the request method is
\"**GET**\"):

![](media/image30.png){width="6.531944444444444in"
height="2.040277777777778in"}

If we could not handle the current request, we will notify the server of
that by returning true (is request not handled - true)

What is left is to find the HTML5 page read it and send it as a response
-- here is how it could be done:

### Hints

Inside the if statement above we should locate the local index.html file
(our home page) and store the path to it into a variable called
**filePath** for instance. Use **path.normalize** and **path.join**
functions and **\_\_dirname property** to achieve that.

![](media/image31.png){width="5.708333333333333in"
height="0.6666666666666666in"}

Use the fs module to read the HTML file using the **readFile** function
with the given **filePath**. If an error occurs send a **404 response**
code and some **plain text message**. If the specified file path name is
correct send the **HTML** as a response with code **200** and content
type **\"text/html\"**.

![](media/image32.png){width="5.25in" height="3.966666666666667in"}

Our html page (home page) is almost ready (later the cats will be
added). We are almost ready to test if everything mentioned above is
about to work.

Go to the \"**handlers**\" folder and add \"**index.js**\" file.

![](media/image33.png){width="6.531944444444444in"
height="2.334722222222222in"}

This **index**.**js** file inside the \"**handlers**\" folder will be
our file which exports all future handlers which we will create
(**static file** **handler** and **cat** **handler**).

After that go back to the **root** **folder** and open the
**index**.**js** (that file where we create our http server).

As we mentioned above, the **index.js file** inside the \"**handlers**\"
**folder** will export **all handlers** to the \"open world\". That's
why we should require them in this **index.js** file. Like:

![](media/image34.png){width="4.5625in" height="1.0104166666666667in"}

And loop through all handlers and if the right handler is found break
the loop.

![](media/image35.png){width="4.75in" height="1.8541666666666667in"}

**Start** **the** **server** again and type **localhost:3000** in the
the browser to see the result.

Sadly, the result will be **waiting** **on** **the** **localhost\...**

![](media/image36.png){width="6.520833333333333in" height="3.03125in"}

Stop the page loading by clicking on the **\[X\] button**

![](media/image37.png){width="3.023682195975503in"
height="8.319444444444445in"}

Our **index.html** file but **without** **any** **styles**, if you open
the **network** **tab** inside **dev** **tools** and refresh the page
the result will be something like this:

![](media/image38.png){width="6.531944444444444in"
height="1.4409722222222223in"}

In other words, the server doesn\'t have the functionality to serve
static files. We will take care of that in the next section.

Serve Static Files
------------------

In this step we will serve static files. In other words, load **css**,
**js** and **image** files.

Let\'s begin by adding the back-end logic. In \"**handler**\" folder add
new file \"***static-files.js***\". It will behave like a normal handler
but instead of returning html it will return file(s). Our public folder
will be the \"**content**\":

First, let\'s create one function called **getContentType** which will
receive our **pathname** (url), checks the **file extension** and
**returns** the **correct** **content**-**type**. Like:

![](media/image39.png){width="3.46875in" height="1.65625in"}

As it\'s shown, just continue the logic to wrap the other extensions
like (**html**, **png**, **js** etc\...)

After that you should **export** a **function** which will receive our
so familiar **request** and **response** parameters and checks the
**pathname** and the **request** method:

![](media/image40.png){width="6.21875in" height="2.21875in"}

Implement the missing logic.

1.  **Read** **a** **file** via **readFile** **function** from **file**
    **system** (**fs**)

2.  Check for errors

3.  Deliver the correct content type

4.  **Send** the correct **response** with the **received** **data**
    from the fs module

![](media/image41.jpeg){width="6.108333333333333in"
height="4.566666666666666in"}

This will work for now, but when we load the cat images locally, we
should make some changes here \...

Go back to \"***handlers/index.js***\" and add the static file handler:

![](media/image42.png){width="6.531944444444444in"
height="2.097916666666667in"}

If you have not included the \"**site.css**\" file and the
\"**favicon.ico**\" in \"***home/index.html***\" go back and do it.

***Note*** *Make sure that all **href** attributes inside the HTML start
with \"**/content/...**\"*

Start the web application again:

![](media/image43.png){width="6.531944444444444in"
height="3.832638888888889in"}

Implement \"Database\"
----------------------

As we mentioned early, we will use **json files**. So, create new folder
called \"**data**\" (if you haven\'t done that already) and add **two**
json files in there (**cats** and **breeds**). At the beginning they
will be an **empty** **array** (both files) but when we start creating
**cats** and **breeds,** we will fill them.

![](media/image44.png){width="3.5208333333333335in"
height="2.1369214785651796in"}

![](media/image45.png){width="2.8875in" height="0.6115890201224847in"}

![](media/image46.png){width="2.8875in" height="0.6757983377077865in"}

**Accessing All Views**

New handler should be created for the cat logic.

Create \"***cat.js***\" inside the \"**handlers**\" folder. The handler
will be responsible for displaying the (html) form **or** parsing the
data from it and add a new cat inside the **json** file:

First, include all needed libraries:

![](media/image47.png){width="4.239583333333333in" height="1.8125in"}

This time they are a quite a lot, but don\'t worry, we will use every
one of them in a specific moment.

Feel free to check the official [Node
documentation](https://nodejs.org/dist/latest-v10.x/docs/api/) to
understand what each module does.

Now, the logic is similar as before. Using the if statement, you should
check every single **pathname** and **request** **method** and load an
HTML page or parse the incoming data.

Create the variable, which will be the parsed **request** and get the
**url** current **pathname** and check the different cases.

![](media/image48.png){width="6.531944444444444in"
height="3.451388888888889in"}

You already have all needed views. Use **readFile** or
**createReadStream** function to read each of the HTML files (Check the
difference between these two functions)

![](media/image49.jpeg){width="6.531944444444444in"
height="2.852777777777778in"}One more thing before we test our
application -- go to \"**handlers/index.js**\" and add our cat handler

![](media/image50.png){width="5.916666666666667in"
height="1.4583333333333333in"}

Restart the server and go to the **localhost:3000/cats/add-cat**

![](media/image51.png){width="6.531944444444444in"
height="2.245833333333333in"}

![](media/image52.png){width="6.531944444444444in"
height="3.207638888888889in"}

### Handling Post

In order to create a new cat, first we should create the cat breeds
functionality, because they will be listed in **addCat page** as
**options** **elements** inside the **select menu**.

Handle the post request in **/cats/add-breed**, save the given breed
inside the **breeds.json** file and when the **addCat.html** file is
loaded we should use the breeds inside that **json** file, so they could
be picked when a new cat is added to our application.

To handle **POST** **request**, the logic is similar:

![](media/image53.png){width="6.531944444444444in"
height="2.4194444444444443in"}

You have to:

1.  **Parse** the **incoming** **data** from the **form**

2.  **Read** the **breeds.json** file

3.  **Modify** the **breeds.json** file

4.  **Update** the **breeds.json** file

5.  **Redirect** to the home page (**\'/\'**) and **end** the
    **response**

![](media/image54.jpeg){width="6.531944444444444in"
height="3.051388888888889in"}

Here\'s an example how it works:

**breeds.json before**

![](media/image55.png){width="5.09375in" height="1.0625in"}

Adding a \"**Unknown breed**\"

![](media/image56.png){width="6.531944444444444in"
height="1.809524278215223in"}

If you got redirected to the home page, you have successfully
implemented adding a breed.

![](media/image57.png){width="6.531944444444444in"
height="3.9902777777777776in"}

Now if we check the **breeds. json** again, the result is:

![](media/image58.png){width="5.197916666666667in"
height="1.1145833333333333in"}

Now every single breed which is created by the app is saved in this json
file. The next step is to visualize all breeds from this json file, into
the **select** **menu** as **options** in the **addCat**.**html**
because now the Fluffy Cat Breed is just placeholder.

![](media/image59.png){width="2.4523818897637795in"
height="2.1907950568678913in"}

### Making Custom Templates

To continue, we must create **2** **templates**. One for all created
**breads** inside the json file and one for all listed **cats** into the
home page. Let\'s start with the simple one (breeds) because we can\'t
create a new cat yet.

Here\'s the structure

![](media/image60.png){width="4.197916666666667in"
height="0.8333333333333334in"}

Every breed should be an **option** which has a **value** with the
current breed and **text** **content** also with the current breed. And
all of them should be inside the **select** **element** with id
\"**group**\".

Now, when we render the **addCat**.**html** file we should **replace**
some of the content inside the HTML. To do that we simply modify the
**addCat**.**html** file to be like this:

![](media/image61.png){width="5.4875in" height="5.180045931758531in"}

After that open the **cat.js** **handler** and open the statement where
you render the **addCat**.**html** file.

Modify the data. Replace the \"**{{catBreeds}}**\" with the current
**breed** **placeholder** like this:

![](media/image62.png){width="6.531944444444444in"
height="0.4736111111111111in"}

In this case, **breeds** is a variable which is **required** at the top
of the file and refers to **breeds.json**.

We can replace/modify the data and pass it to the **res.write()** method
as simple as sounds.

Now let\'s add another breed just to check if this logic is working
fine:

![](media/image63.png){width="6.531944444444444in"
height="1.7881944444444444in"}

And after we open the **Add** **Cat** Tab, you will see this time the
options are the actual breeds inside the json file.

![](media/image64.png){width="6.531944444444444in"
height="3.0347222222222223in"}

**Voilà**

As you can guess we can use the same logic to render all created cats in
the home page, but first you should make the logic where a new cat is
added to our **cat**.**json** file via form.

But here comes the funny part, because the add new cat form contains the
input where the type is **\'file\'.** That means this time we must
process the incoming data differently.

We will use **formidable**. You can check how this library works, but
simply you can use the following code structure:

![](media/image65.png){width="6.531944444444444in"
height="1.5868055555555556in"}

In this case **fields** and **files** will be **objects**, where
**fields** is the incoming data from the form and **files** is the
information about the uploaded file via form.

![](media/image66.jpeg){width="6.531944444444444in"
height="3.292361111111111in"}

Use **rename()** function to change the location on the uploaded file.

In other words, you can **save it** somewhere in the local files. Just
get the **old** and the **new** **path** on that file and pass them as
arguments in that function.

And via **readFile()** and **writeFile()** functions in **fs**
**module** you can get all cats inside **json**.**file,** modify them
and write them back to the json file where the new cat will be included.

Here\'s the example:

![](media/image67.png){width="6.531944444444444in"
height="3.0659722222222223in"}

This time if we open the **cats**.**json** file it won\'t be an empty
array anymore.

![](media/image68.png){width="6.531944444444444in"
height="0.4305555555555556in"}

Now we already can create new cats. To fully check if the entire logic
is working, you can check the /**content**/**images**/. If the uploaded
picture from you is there, everything is fine. So, we can use the given
template and render all cats inside the **cats.json file**

Here is the cat structure:

![](media/image69.png){width="4.351041119860017in"
height="3.7055555555555557in"}

![](media/image70.png){width="6.531944444444444in"
height="1.2826388888888889in"}

When rendering the **index**.**html** page we should loop through all
cats inside **cats**.**json** and use the placeholder from above to
change and include them into the HTML file before it is rendered.

Here\'s how that work can be done:

Go to **home.js,** because there is the logic we should change. There we
load **index**.**html** **file** but with static data. Change it to
this:

![](media/image71.png){width="6.531944444444444in"
height="1.7020833333333334in"}Loop through all cats inside the
**cats**.**json** file and use the given from the skeleton placeholder
to fill every single cat information into the right place. Don\'t forget
to **write()** and **end()** the response.

Don't forget to change the **index.html** as well.

![](media/image72.png){width="5.0375in" height="4.528180227471566in"}

Now, if you restart the server and check the home page
(**localhost:3000**), the result might be something like this:

![](media/image73.png){width="6.531944444444444in" height="2.5125in"}

The picture is not visualized on the page. The reason behind that is
because when we serve static files, we don\'t think about all edge
cases. To solve this problem, we should extend our
**static**-**handler**.**js** logic.

![](media/image74.png){width="6.531944444444444in"
height="1.9854166666666666in"}

This is the structure you should use to resolve this problem. The logic
inside these two **readFile()** function is 99% the same. The only
difference between them is the **encoding** which is the second argument
and it\'s optional. When some of the following files is served, there
should be no encoding or at least no **utf8** (**png**, **jpg**,
**jpeg** etc\...)

You should just **check** when, the **pathname** **starts** **with**
\'**/content\'** and the **request** **method** is **\'GET\'**, and also
the **pathname** **ends** **with** some of the image extension, read the
file, pass the **pathname** and the **callback** as arguments that\'s
it. In any other cases no matter the **panthname** ending you should put
the encoding **(\'utf8\')** for now. As it\'s done above in the picture.

If you do that the result will be:

![](media/image75.png){width="6.531944444444444in"
height="2.588888888888889in"}

Edit and Delete
---------------

\[**Change Info**\] and \[**New Home**\] are buttons which every cat
should have. You have been given all the necessary views, including
these two (**editCat.html** and **catShelter.html**) clicking over some
of them, the app should show the current view with current cat info
inside it.

So, the missing logic we should implement is:

![](media/image76.png){width="6.531944444444444in"
height="3.467361111111111in"}

When some of the \[**Change** **info**\] buttons are clicked, you should
check the **cat id** which is provided into the **url**, search that cat
in the **cat.json file** and use templates to replace the static data
with the current cat information

If you check **home**.**js** **handler,** you will see this:

![](media/image77.png){width="6.531944444444444in"
height="1.6694444444444445in"}

This is our **cat** **template**. When you get the current cat from the
**json**.**file**, you can use the logic from above to get the file and
render it and just apply the template:

![](media/image78.png){width="6.531944444444444in"
height="1.5506944444444444in"}

Also **don\'t forget** to change the **editCat**.**html** file as well:

![](media/image79.png){width="6.531944444444444in" height="2.625in"}

The logic after clicking over \[**New** **Home**\] button is the same:

1.  Check the **url** to get the current **cat** **id**

2.  **Search** through **cat.json** file that id

3.  **Replace** editCat.html with the current cat information like above

**POST** **request** for these two actions is almost the same as the
logic for **adding new cat**. With the simple difference when you
**edit** some of the cat information you **change** that cat inside json
file instead creating new one (change it with the incoming information
from the form). And **delete** the current cat from the shelter
(**cats.json file**).

The steps are the same:

**Parse** the incoming data from the form (if you are editing the cat\'s
information)

**Read** the **cats.json** file via **fs** module update the cats (edit
the cat or deleting it)

**Rewriting** the **cats.json** file with the applied changes.

![](media/image80.jpeg){width="6.531944444444444in"
height="2.7715277777777776in"}

Search\*
--------

Having web page with cats is fun but sometimes you want to filter them
by some criteria. Therefore, our home page includes a little form which
has only one text field (cat\'s name or part of it). After submitting
the form, all the cats containing such text or having same name should
be displayed.

**GOOD LUCK**
