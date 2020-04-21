Ext.define('MvcExtTest.controller.Users', {
    extend: 'Ext.app.Controller',

    views: ['TableUser'],
    stores: ['UsersStore'],
    models: ['User']

});