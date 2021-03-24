
const { Router } = require('express');
const router = Router();

const productController = require('./controllers/productController');
const homeController = require('./controllers/homeController');
const accessoriesController = require('./controllers/accessoryController');
const authController = require('./controllers/authController');

router.use('/', homeController);
router.use('/auth', authController);
router.use('/products', productController);
router.use('/accessories', accessoriesController);

router.get('*', (req, res) => {
    res.render('404');
})

module.exports = router;