function addEventListeners() {

    let navigationTemplate = Handlebars.compile(document.getElementById('navigation-template').innerHTML);
    let movieCardTemplate = Handlebars.compile(document.getElementById('movie-card-template').innerHTML);

    Handlebars.registerPartial('navigation-template', navigationTemplate);
    Handlebars.registerPartial('movie-card-template', movieCardTemplate);

    navigate(location.pathname == '/' ? 'home' : location.pathname.slice(1));
}

function navigateHandlerbars(e) {
    e.preventDefault();

    if (e.target.tagName != 'A') {
        return;
    }

    let url = new URL(e.target.href);

    navigate(url.pathname.slice(1));
};

function onLoginSubmit(e) {
    e.preventDefault();

    let formData = new FormData(document.forms['form-login']);

    let email = formData.get('email');
    let password = formData.get('password');

    authServices.login(email, password)
        .then(data => {
            navigate('home');
        });
}

function onAddMovieSubmit(e) {
    e.preventDefault();

    let formData = new FormData(document.forms['add-movie-form']);
    let title = formData.get('title');
    let description = formData.get('description');
    let imageUrl = formData.get('imageUrl');

    movieServices.add({
        title,
        description,
        imageUrl,
    }).then(res => {
        navigate('home');
    })
}

function deleteMovie(e){
    e.preventDefault();

    let id = e.target.dataset.id;

    movieServices.deleteMovie(id)
    .then(res => {
        navigate('home');
    })
}

function onEditMovieSubmit(e, id){
    e.preventDefault();

    let formData = new FormData(document.forms['edit-movie-form']);
    let title = formData.get('title');
    let description = formData.get('description');
    let imageUrl = formData.get('imageUrl');

    movieServices.editMovie(id, {
        title,
        description,
        imageUrl,
    })
    .then(res=>{
        navigate(`details/${id}`)
    });
}


addEventListeners();