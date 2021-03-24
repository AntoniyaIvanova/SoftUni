const config = {
    development:{
        PORT: 5000,
        SALT_ROUNDS: 10,
        DB_CONNECTION: 'mongodb://localhost/cubicle',
        SECRET: 'ijustcant',
        COOKIE_NAME: 'USER_SESSION',
    },
    production:{
        PORT: 80,
        DB_CONNECTION: 'insert mongodb atlas connection here',
        SECRET: 'ijustcant',
        COOKIE_NAME: 'USER_SESSION',
    }
}

module.exports = config[process.env.NODE_ENV.trim()];