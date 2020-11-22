const routes = {
    'home': 'home-template',
    'login': 'login-form-template',
    'register': 'register-form-template',
    'add-movie': 'add-movie-template',
    'details': 'movie-details-template'
};

const router = async (fullPath) => {
    let [path, id, param] = fullPath.split('/');
    let app = document.getElementById('app');
    let templateData = authServices.getData();
    let templateId = routes[path];

    switch (path) {
        case 'home':
            templateData.movies = await movieServices.getAll();
            break;
        case 'logout':
            authServices.logout();
            return navigate('home');
        case 'details':
            let movieDetails = await movieServices.getOne(id);
            Object.assign(templateData, movieDetails);
            if (param === 'edit') {
                templateId = 'edit=movie-template';
            }
            break;
        default:
            break;
    }

    let template = Handlebars.compile(document.getElementById(templateId).innerHTML);


    app.innerHTML = template(authData);
};

const navigate = (path) => {
    history.pushState({}, '', '/' + path);

    router(path);
}