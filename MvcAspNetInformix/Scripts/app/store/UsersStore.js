Ext.define('MvcExtTest.store.UsersStore', {
    extend: 'Ext.data.Store',
    model: 'MvcExtTest.model.User',
    autoLoad: true,
    storeId: 'UsersStore',
    
    proxy: {
        type: 'ajax',
        //api: {
        //    read: 'Scripts/app/data/users.json',
        //},
        //url: 'Scripts/app/data/users.json',
        pageSize: 4,
        url: 'ReadJson/GetData',
        reader: {
            type: 'json',
            method: 'POST',
            //root: 'users',
            //totalProperty: 12 ,
            //successProperty: 'success',
            enablePaging: true
            //simpleSortMode: true
        },
        
        
    }
});
