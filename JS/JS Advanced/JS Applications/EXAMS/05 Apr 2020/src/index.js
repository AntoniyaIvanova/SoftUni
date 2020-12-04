import { homePage } from './controllers/catalog.js';
import { registerPage, loginPage, postRegister } from './controllers/user.js';
import * as api from './data.js';

window.api = api;

const app = Sammy('#root', function (context) {

    this.use('Handlebars', 'hbs');

    /*
    const user = getUserData();
    this.userData = {
        isLoggedIn: user ? true : false,
        ...user
    }*/

    this.get('/', homePage);
    this.get('/home', homePage);
    this.get('/login', loginPage);
    this.get('/register', registerPage);
    this.post('/register', (context) => { postRegister(context); });

});

app.run();

