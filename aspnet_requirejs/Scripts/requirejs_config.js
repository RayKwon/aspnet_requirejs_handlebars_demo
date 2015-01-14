requirejs.config({
    baseUrl: '../scripts/app',
    paths: {
        jquery: '../lib/jquery-1.10.2',
        bootstrap: '../lib/bootstrap',
        underscore: '../lib/lodash',
        backbone: '../lib/backbone',
        hbs: '../lib/require-handlebars-plugin/hbs'
    },
    shim: {
        bootstrap: {
            deps: ['jquery']
        }
    },
    hbs: { // optional
        helpers: true,            // default: true
        i18n: false,              // default: false
        templateExtension: 'hbs', // default: 'hbs'
        partialsUrl: ''           // default: ''
    }
});