function addEventListeners() {
    document.querySelector('.navigation').addEventListener('click', navigateHandlerbars);
}

function navigateHandlerbars(e) {
    e.preventDefault();

    if (!e.target.classList.contains('nav-link')) {
        return;
    }

    let url = new URL(e.target.href);

    history.pushState({}, '', url.pathname);

    router(url.pathname.slice(1));
};

function onLoginSubmit(e){
    e.preventDefault();
    let formData = new FormData(document.forms['form-login']);
    let email = formData.get('email');
    let password = formData.get('password');
}

addEventListeners();