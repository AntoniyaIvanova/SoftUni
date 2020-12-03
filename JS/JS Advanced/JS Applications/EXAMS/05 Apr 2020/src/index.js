import { homePage } from './controllers/catalog.js';
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
    this.get('/login', login);
    this.get('/register', register);

});

app.run();

