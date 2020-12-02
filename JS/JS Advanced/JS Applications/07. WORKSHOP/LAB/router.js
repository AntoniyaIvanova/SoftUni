const routes = {
    'home': 'home-template',
    'login': 'login-form-template',
    'register': 'register-form-template',
    'add-movie': 'add-movie-template',
    'details': 'movie-details-template',
    'edit-movie': 'edit-movie-template',
};

const router = async (url) => {
    let [fullPath, queryString] = url.split('?');
    let [path, id, param] = fullPath.split('/');
    let app = document.getElementById('app');
    let templateData = authServices.getData();

    let templateId = routes[path];

    switch (path) {
        case 'home':
            let searchedElemenet = queryString?.split('=')[1];
            templateData.movies = await movieServices.getAll(searchedElemenet);
            break;
        case 'logout':
            authServices.logout();
            return navigate('home');
        case 'details':
            let movieDetails = await movieServices.getOne(id);
            Object.assign(templateData, movieDetails, {id});

            if (param == 'edit') {
                templateId = 'edit-movie-template';
            }
            break;
        default:
            break;
    }

    let template = Handlebars.compile(document.getElementById(templateId).innerHTML);

    app.innerHTML = template(templateData);
};

const navigate = (path) => {
    history.pushState({}, '', '/' + path);

    router(path);
}