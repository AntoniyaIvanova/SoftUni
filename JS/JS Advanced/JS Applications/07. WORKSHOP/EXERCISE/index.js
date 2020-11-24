const UserModel = firebase.auth();
const dbContext = firebase.firestore();

const app = Sammy('#root', function () {
    this.use('Handlebars', 'hbs');

    this.get('/home', function (context) {
        dbContext.collection('offers')
            .get()
            .then((res) => {
                context.offers = res.docs.map((offer => { return { id: offer.id, ...offer.data() } }));
                loadPartialsToContext(context)
                    .then(function () {
                        this.partial('./templates/home.hbs');
                    })
            })
            .catch((e) => console.log(e));
    })

    this.get('/register', function (context) {
        loadPartialsToContext(context)
            .then(function () {
                this.partial('./templates/register.hbs');
            })
    })

    this.post('/register', function (context) {
        let { email, password, repassword } = context.params;

        if (password !== repassword) {
            return;
        }

        UserModel.createUserWithEmailAndPassword(email, password)
            .then((userdata) => {
                this.redirect('/login');
            })
            .catch((e) => console.log(e));
    });

    this.get('/login', function (context) {
        loadPartialsToContext(context)
            .then(function () {
                this.partial('./templates/login.hbs');
            })
    })

    this.post('/login', function (context) {
        let { email, password } = context.params;

        UserModel.signInWithEmailAndPassword(email, password)
            .then((userdata) => {
                saveUserData(userdata);
                this.redirect('/home');
            })
            .catch((e) => console.log(e));
    });

    this.get('/logout', function () {
        UserModel.signOut()
            .then((res) => {
                clearUserData();
                this.redirect('/home');
            })
            .catch((e) => console.log(e));
    })

    this.get('/create-offer', function (context) {
        loadPartialsToContext(context)
            .then(function () {
                this.partial('./templates/createOffer.hbs');
            })
    })

    this.post('/create-offer', function (context) {
        const { productName, price, imageUrl, description, brand } = context.params;
        console.log(context.params);

        dbContext.collection("offers").add({
            productName,
            price,
            imageUrl,
            description,
            brand,
            salesman: getUserData().uid,
            clients: [],
        })
            .then((createdProduct) => {
                console.log(createdProduct);
                this.redirect('/home');
            })
            .catch((e) => console.log(e));
    })

    this.get('#/details/:offerId', function (context) {
        const { offerId } = context.params;
        dbContext.collection('offers')
            .doc(offerId)
            .get()
            .then((response) => {
                const { uid } = getUserData();
                const actualOfferData = response.data();
                const imTheSalesman = actualOfferData.salesman === uid;
                const userIndex = actualOfferData.clients.indexOf(uid);
                console.log(userIndex);
                const imInTheClientsList = userIndex > -1;
                context.offer = { ...actualOfferData, imTheSalesman, id: offerId, imInTheClientsList };
                loadPartialsToContext(context)
                    .then(function () {
                        this.partial('./templates/details.hbs');
                    })
            })
    })

    this.get('#/delete/:offerId', function (context) {
        const { offerId } = context.params;

        dbContext
            .collection('offers')
            .doc(offerId)
            .delete()
            .then(() => this.redirect('/home'))
            .catch((e) => console.log(e));
    })

    this.get('#/edit/:offerId', function (context) {
        const { offerId } = context.params;

        dbContext.collection('offers')
            .doc(offerId)
            .get()
            .then((res) => {
                context.offer = { id: offerId, ...res.data() };
                loadPartialsToContext(context)
                    .then(function () {
                        this.partial('./templates/editOffer.hbs');
                    });
            });

    })

    this.post('#/edit/:offerId', function (context) {
        const { offerId, productName, price, brand, imageUrl, description } = context.params;

        dbContext.collection('offers')
            .doc(offerId)
            .get()
            .then((response) => {

                return dbContext.collection('offers')
                    .doc(offerId)
                    .set({
                        ...response.data(),
                        productName,
                        price,
                        brand,
                        imageUrl,
                        description
                    })

            })
            .then((resp) => {
                this.redirect(`#/details/${offerId}`);
            })
            .catch((e) => console.log(e));
    });

    this.get('#/buy/:offerId', function (context) {
        const { offerId } = context.params;
        const { uid } = getUserData();

        dbContext.collection('offers')
            .doc(offerId)
            .get()
            .then((response) => {
                const offerData = { ...response.data() };
                offerData.clients.push(uid)

                return dbContext.collection('offers')
                    .doc(offerId)
                    .set(offerData)
            })
            .then(() => {
                this.redirect(`#/details/${offerId}`);
            })
            .catch((e) => console.log(e));
    })
});

(() => {
    app.run('/home');
})();

function loadPartialsToContext(context) {
    const user = getUserData();
    context.isLoggedIn = Boolean(user);
    context.email = user ? user.email : '';

    return context.loadPartials({
        'header': './partials/header.hbs',
        'footer': './partials/footer.hbs',
    })
}

function saveUserData(data) {
    const { user: { email, uid } } = data;
    localStorage.setItem('user', JSON.stringify({ email, uid }));
}

function getUserData() {
    const user = localStorage.getItem('user');

    return user ? JSON.parse(user) : null;
}

function clearUserData() {
    localStorage.removeItem('user');
}