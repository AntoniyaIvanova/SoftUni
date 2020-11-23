const UserModel = firebase.auth;

const app = Sammy('#root', function () {
    this.use('Handlebars', 'hbs');

    this.get('/home', function (context) {
        loadPartialsToContext(context)
            .then(function () {
                this.partial('./templates/homeGuest.hbs');
            })
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
                this.redirect('/home');
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

    this.get('/logout', function(){
        UserModel.signOut()
        .then((res)=>{
            clearUserData();
            this.redirect('/home');
        })
        .catch((e)=>console.log(e));
    })

    this.get('/create-offer', function (context) {
        loadPartialsToContext(context)
            .then(function () {
                this.partial('./templates/createOffer.hbs');
            })
    })

    this.get('/edit-offer', function (context) {
        loadPartialsToContext(context)
            .then(function () {
                this.partial('./templates/editOffer.hbs');
            })
    })

    this.get('/details', function (context) {
        loadPartialsToContext(context)
            .then(function () {
                this.partial('./templates/details.hbs');
            })
    })


});

(() => {
    app.run('/home');
})();

function loadPartialsToContext(context) {

    let user = getUserData();
    context.isLoggedIn = Boolean(user);
    context.email = user ? user.email : '';

    return context.loadPartials({
        'header': './partials/header.hbs',
        'footer': './partials/footer.hbs',
    })
}

function saveUserData(data) {
    const { user: {email, uid} } = data;
    localStorage.setItem('user', JSON.stringify(email, uid));
}

function getUserData(){
    const user = localStorage.getItem('user');

    return user ? JSON.parse(user) : null;
}

function clearUserData(){
    this.localStorage.removeItem('user');
}