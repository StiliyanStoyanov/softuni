const mongoose = require('mongoose');
const config = require('./config');
module.exports = (app) => {
    return mongoose.connect(config.dbURL, { useNewUrlParser: true, useUnifiedTopology: true });
};