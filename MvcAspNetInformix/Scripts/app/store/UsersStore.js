Ext.define('MvcExtTest.store.UsersStore', {
    extend: 'Ext.data.Store',
    model: 'MvcExtTest.model.User',
    autoLoad: true,
    storeId: 'UsersStore',
    pageSize: 4,
    proxy: {
        type: 'ajax',
        url: "ReadJson/GetData",
        reader: {
            type: 'json',
            method: 'POST',
            //root: 'users',
            //successProperty: 'success'
            simpleSortMode: true
        },
        /*sorters: [{
            property: 'lastpost',
            direction: 'DESC'
        }]*/
        //pageSize: 10
    }
});