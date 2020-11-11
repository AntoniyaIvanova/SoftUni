const htmlSelectors = {
    'loadBooks': () => document.getElementById('loadBooks'),
    'createBtn': () => document.querySelector('#create-form > button'),
    'createTitleInput': () => document.getElementById('create-title'),
    'createAuthorInput': () => document.getElementById('create-author'),
    'createIsbnInput': () => document.getElementById('create-isbn'),
    'createTagsInput': () => document.getElementById('create-tags'),
    'booksContainer': () => document.querySelector('table > tbody'),
    'errorContainer': () => document.getElementById('error-notification'),
    'editForm': () => document.getElementById('edit-form'),
    'editBtn': () => document.querySelector('#edit-form > button'),
    'editTitleInput': () => document.getElementById('edit-title'),
    'editAuthorInput': () => document.getElementById('edit-author'),
    'editTagsInput': () => document.getElementById('edit-tags'),
    'editIsbnInput': () => document.getElementById('edit-isbn'),
    'deleteForm': () => document.getElementById('delete-form'),
    'deleteTitleInput': () => document.getElementById('delete-title'),
    'deleteAuthorInput': () => document.getElementById('delete-author'),
    'deleteIsbnInput': () => document.getElementById('delete-isbn'),
    'deleteTagsInput': () => document.getElementById('delete-tags'),
    'deleteBtn': () => document.querySelector('#delete-form > button'),
}

htmlSelectors['loadBooks']()
    .addEventListener('click', fetchAllBooks);

htmlSelectors['createBtn']()
    .addEventListener('click', createBook);

htmlSelectors['editBtn']()
    .addEventListener('click', editBook);

htmlSelectors['deleteBtn']()
    .addEventListener('click', deleteBook);

function fetchAllBooks() {
    fetch('https://books-exercise-2b72a.firebaseio.com/Books/.json')
        .then(res => res.json())
        .then(renderBooks)
        .catch(handleError)
}

function createBook(e) {
    e.preventDefault();
    const titleInput = htmlSelectors['createTitleInput']();
    const tagsInput = htmlSelectors['createTagsInput']();
    const authorInput = htmlSelectors['createAuthorInput']();
    const isbnInput = htmlSelectors['createIsbnInput']();

    if (titleInput.value !== '' && authorInput.value !== '' && isbnInput.value !== '') {
        const inputObj = {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                title: titleInput.value,
                tags: tagsInput.value,
                author: authorInput.value,
                isbn: isbnInput.value,
            })
        }
        fetch('https://books-exercise-2b72a.firebaseio.com/Books/.json', inputObj)
            .then(fetchAllBooks)
            .catch(handleError);

        titleInput.value = '';
        tagsInput.value = '';
        authorInput.value = '';
        isbnInput.value = '';
    } else {
        const error = { message: '' };

        if (titleInput.value === '') {
            error.message += 'Title must not be empty!';
        }

        if (titleInput.value === '') {
            error.message += 'Tags must not be empty!';
        }

        if (authorInput.value === '') {
            error.message += 'Author must not be empty!';
        }

        if (isbnInput.value === '') {
            error.message += 'ISBN must not be empty!';
        }

        handleError(error);
    }
}

function loadEditBookById() {
    const id = this.getAttribute('data-key');
    fetch(`https://books-exercise-2b72a.firebaseio.com/Books/${id}/.json`)
        .then(res => res.json())
        .then((data) => {
            htmlSelectors['editTitleInput']().value = data.title;
            htmlSelectors['editTagsInput']().value = data.tags;
            htmlSelectors['editIsbnInput']().value = data.isbn;
            htmlSelectors['editAuthorInput']().value = data.author;
            htmlSelectors['editForm']().style.display = 'block';
            htmlSelectors['editBtn']().setAttribute('data-key', id);
        })
        .then(fetchAllBooks)
        .catch(handleError);
}

function loadDeleteBookById() {
    const id = this.getAttribute('data-key');
    fetch(`https://books-exercise-2b72a.firebaseio.com/Books/${id}/.json`)
        .then(res => res.json())
        .then((data) => {
            htmlSelectors['deleteTitleInput']().value = data.title;
            htmlSelectors['deleteAuthorInput']().value = data.author;
            htmlSelectors['deleteIsbnInput']().value = data.isbn;
            htmlSelectors['deleteForm']().style.display = 'block';
            htmlSelectors['deleteBtn']().setAttribute('data-key', id);
        })
        .then(fetchAllBooks)
        .catch(handleError);
}

function editBook(e) {
    e.preventDefault();
    const titleInput = htmlSelectors['editTitleInput']();
    const authorInput = htmlSelectors['editAuthorInput']();
    const isbnInput = htmlSelectors['editIsbnInput']();


    if (titleInput.value !== '' && authorInput.value !== '' && isbnInput.value !== '') {
        const id = this.getAttribute('data-key');
        const inputObj = {
            method: 'PATCH',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                title: titleInput.value,
                author: authorInput.value,
                isbn: isbnInput.value,
            })
        }

        fetch(`https://books-exercise-2b72a.firebaseio.com/Books/${id}/.json`, inputObj)
            .then(() => {
                htmlSelectors['editForm']().style.display = 'none';
                fetchAllBooks();
            })
            .catch(handleError);

        titleInput.value = '';
        authorInput.value = '';
        isbnInput.value = '';
    } else {
        const error = { message: '' };

        if (titleInput.value === '') {
            error.message += 'Title must not be empty!';
        }

        if (authorInput.value === '') {
            error.message += 'Author must not be empty!';
        }

        if (isbnInput.value === '') {
            error.message += 'ISBN must not be empty!';
        }

        handleError(error);
    }
}

function deleteBook(e) {
    e.preventDefault();
    const id = this.getAttribute('data-key');
    const inputObj = {
        method: 'DELETE'
    }

    fetch(`https://books-exercise-2b72a.firebaseio.com/Books/${id}/.json`, inputObj)
        .then(() => {
            htmlSelectors['deleteForm']().style.display = 'none';
        })
        .then(fetchAllBooks)
        .catch(handleError);
}

function renderBooks(booksData) {
    const booksContainer = htmlSelectors['booksContainer']();

    if (booksContainer.innerHTML !== '') {
        booksContainer.innerHTML = '';
    }


    Object.keys(booksData)
        .forEach(bookId => {
            const { title, tags, author, isbn } = booksData[bookId];
            const tableRow = createDOMElement('tr', '', {}, {},
                createDOMElement('td', title, {}, {}),
                createDOMElement('td', '', {}, {}, 
                   ),
                createDOMElement('td', author, {}, {}),
                createDOMElement('td', isbn, {}, {}),
                createDOMElement('td', '', {}, {},
                    createDOMElement('button', 'Edit', { 'data-key': bookId }, { click: loadEditBookById }),
                    createDOMElement('button', 'Delete', { 'data-key': bookId }, { click: loadDeleteBookById }),
                ));

            booksContainer.appendChild(tableRow);
        })
}

function handleError(err) {
    const errorContainer = htmlSelectors['errorContainer']();
    errorContainer.style.display = 'block';
    errorContainer.textContent = err.message;

    setTimeout(() => {
        errorContainer.style.display = 'none';
    }, 2000);
}

function createDOMElement(type, text, attributes, events, ...children) {
    const domElement = document.createElement(type);

    if (text !== '') {
        domElement.textContent = text;
    }

    Object.entries(attributes)
        .forEach(([attrKey, attrValue]) => {
            domElement.setAttribute(attrKey, attrValue)
        });

    Object.entries(events)
        .forEach(([eventKey, eventHandler]) => {
            domElement.addEventListener(eventKey, eventHandler)
        });

    domElement.append(...children);

    return domElement;
}