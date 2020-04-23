Ext.define('MvcExtTest.store.UsersStore', {
    extend: 'Ext.data.Store',
    model: 'MvcExtTest.model.User',
    autoLoad: true,
    storeId: 'UsersStore',
    pageSize: 4,
    proxy: {
        type: 'ajax',
        //api: {
        //    read: 'ReadJson/GetData',
        //},

        url: 'ReadJson/GetData',
        reader: {
            type: 'json',
            method: 'POST',
            root: 'newUsers',
            totalProperty: 'total' ,
            
        },
        
        
    }
});
