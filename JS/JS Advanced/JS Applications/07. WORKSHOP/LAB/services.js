const apiKey = 'AIzaSyDxp4DtoQ-J3NDqqTWxSZNAMKSWlZDD8Us';
const dbUrl = `https://movies-b5a2a.firebaseio.com/`;

const request = async (url, method, body) => {
    let options = {
        method,
    };

    if (body) {
        Object.assign(options, {
            headers: {
                'content-type': 'application/json'
            },
            body: JSON.stringify(body)
        });
    }

    let response = await fetch(url, options);

    let data = await response.json();

    return data;
}

const authServices = {
    async login(email, password) {
        let response = await fetch(`https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=${apiKey}`, {
            method: 'POST',
            headers: {
                'content-type': 'application/json'
            },
            body: JSON.stringify({
                email,
                password,
            })
        });

        let data = await response.json();

        localStorage.setItem('auth', JSON.stringify(data));

        return data;
    },

    async register(email, password) {
        let response = await fetch(`https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=${apiKey}`, {
            method: 'POST',
            headers: {
                'content-type': 'application/json'
            },
            body: JSON.stringify({
                email,
                password,
            })
        });

        let data = await response.json();

        return data;
    },

    getData() {
        try {
            let data = JSON.parse(localStorage.getItem('auth'));

            return {
                isAuthenticated: Boolean(data.idToken),
                email: data.email || 'Guest'
            };
        } catch (error) {
            return {
                isAuthenticated: false,
                email: ''
            };
        }
    },

    logout() {
        localStorage.setItem('auth', '');
    }
};

const movieServices = {
    async add(movieData) {
        let res = await request(`${dbUrl}/movies.json`, 'POST', movieData);
        return res;
    },

    async getAll(searchedElemenet) {
        let res = await request(`${dbUrl}/movies.json`, 'GET');

        return Object.keys(res).map(key => ({ key, ...res[key] })).filter(x => !searchedElemenet || searchedElemenet == x.title);
    },

    async getOne(id) {
        let res = await request(`${dbUrl}/movies/${id}.json`, 'GET');
        let { email } = authServices.getData();
        let likes = Object.values(res.likes || {});
        let alreadyLiked = likes.some(x => x.creator == email);

        return Object.assign(res, { isOwn: res.creator == email, alreadyLiked, likes: likes.length });
    },

    async deleteMovie(id) {
        let res = await request(`${dbUrl}/movies/${id}.json`, 'DELETE');

        return res;
    },

    async editMovie(id, movie) {
        let res = await request(`${dbUrl}/movies/${id}.json`, 'PATCH', movie);

        return res;
    },

    async likeMovie(id, creator) {
        let res = await request(`${dbUrl}/movies/${id}/likes.json`, 'POST', { creator });

        return res;
    }

}