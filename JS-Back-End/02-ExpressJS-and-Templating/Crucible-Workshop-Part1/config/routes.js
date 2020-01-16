const cubeController = require('../controllers/cube');

module.exports = (app) => {
    app.get('/details/:id', cubeController.details);
    app.get('/create', cubeController.getCreate);
    app.post('/create', cubeController.postCreate);
    app.get('/not-found', cubeController.notFound);
    app.get('/about', cubeController.about);
    app.get('/', cubeController.index);
    app.get('*', cubeController.notFound);

};