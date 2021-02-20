const { Router } = require('express');
const productService = require('../services/productService');
const {validateProduct} = require('./helpers/productHelpers');

const router = Router();

router.get('/', (req, res) => {
    let products = productService.getAll();
    res.render('home', { title: 'Browse', products });
});

router.get('/create', (req, res) => {
    res.render('create', { title: 'Create' });
});

router.post('/create', validateProduct, (req, res) => {

    productService.create(req.body, (err) => {
        if(err){
            return res.status(500).end();
        }
        
        res.redirect('/products');
    });

});

router.get('/details/:id', (req, res) => {
    let cube = productService.getById(req.params.id);
    console.log(req.params.id);
    res.render('details', { title: 'Product Details', cube });
});

module.exports = router;