const { Router } = require('express');
const productService = require('../services/productService');
const accessoryService = require('../services/accessoryService');
const { validateProduct } = require('./helpers/productHelpers');

const isAuthenticated = require('../middlewares/isAuthenticated');
const isGuest = require('../middlewares/isGuest');

const router = Router();

router.get('/', (req, res) => {
    let products = productService.getAll(req.query)
        .then(products => {
            res.render('home', { title: 'Browse', products });
        })
        .catch(() => res.status(500).end());
});

router.get('/create', isAuthenticated, (req, res) => {
    res.render('create', { title: 'Create' });
});

router.post('/create', isAuthenticated, validateProduct, (req, res) => {
    productService.create(req.body, req.user._id)
        .then(() => res.redirect('/products'))
        .catch(() => res.status(500).end())
});

router.get('/details/:id', async (req, res) => {
    let product = await productService.getOneWithAccessories(req.params.id);
    res.render('details', { title: 'Product Details', product });
});


router.get('/:id/attach', isAuthenticated, async (req, res) => {
    let product = await productService.getOne(req.params.id);
    let accessories = await accessoryService.getAllUnattached(product.accessories);

    res.render('attachAccessory', { product, accessories });
});


router.post('/:id/attach', isAuthenticated, (req, res) => {
    productService.attachAccessory(req.params.id, req.body.accessory)
        .then(() => res.redirect(`/products/details/${req.params.id}`))
        .catch(() => res.status(500).end());
});

router.get('/:id/edit', isAuthenticated, (req, res) => {
    productService.getOne(req.params.id).then(product => {
        res.render('editCube', product);
    })
});

router.post('/:id/edit', isAuthenticated, validateProduct, (req, res) => {
    productService.updateOne(req.params.id, req.body)
        .then(response => {
            res.redirect(`/products/details/${req.params.id}`);
        })
        .catch(error => {
            console.log(error)
        })
});


router.get('/:id/delete', isAuthenticated, (req, res) => {
    productService.getOne(req.params.id)
        .then(response => {
            if (req.user._id != response.creator) {
                res.redirect('/products');
            } else {
                res.render('deleteCube', response);
            }
        }).catch(err => {
            console.log(err);
        })
})

router.post('/:id/delete', isAuthenticated, (req, res) => {

    productService.getOne(req.params.id)
        .then(response => {
            if (req.user._id != response.creator) {
                return res.redirect('/products');
            }

            return productService.deleteOne(req.params.id)
        })
    .then(response => {
        res.redirect('/products');
    })
    .catch(err => {
        console.log(err);
    })
})


module.exports = router;