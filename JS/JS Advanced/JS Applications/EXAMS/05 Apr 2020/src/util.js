export function setUserData(data) {
    localStorage.setItem('auth', JSON.stringify(data));
}

export function getUserData() {
    const auth = localStorage.getItem('auth');

    if (auth !== null) {
        return JSON.parse(auth);
    }

    return null;
}

export function getUserId(){
    const auth = localStorage.getItem('auth');

    if (auth !== null) {
        return JSON.parse(auth).localId;
    }

    return null;
}