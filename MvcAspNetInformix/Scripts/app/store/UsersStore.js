Ext.define('MvcExtTest.store.UsersStore', {
    extend: 'Ext.data.Store',
    model: 'MvcExtTest.model.User',
    autoLoad: true,
    storeId: 'UsersStore',
    proxy: {
        type: 'ajax',
        url: "ReadJson/GetData",
        reader: {
            type: 'json',
            method: 'POST',
            //root: 'users',
            //successProperty: 'success'
        }
    }
});