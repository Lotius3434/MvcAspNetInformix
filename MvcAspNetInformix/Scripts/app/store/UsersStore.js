Ext.define('MvcExtTest.store.UsersStore', {
    extend: 'Ext.data.Store',
    model: 'MvcExtTest.model.User',
    autoLoad: true,
    storeId: 'UsersStore',
    pageSize: 10,
    proxy: {
        type: 'ajax',
        
        url: 'ReadJson/GetData',
        reader: {
            type: 'json',
            method: 'POST',
            root: 'newUsers',
            totalProperty: 'total' ,
            
        },
        
        
    }
});
