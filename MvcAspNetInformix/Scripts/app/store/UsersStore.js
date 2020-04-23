Ext.define('MvcExtTest.store.UsersStore', {
    extend: 'Ext.data.Store',
    model: 'MvcExtTest.model.User',
    //data: "ReadJson/GetData",
    //fields: ['id', 'surname', 'name', 'patronymicName'],
    autoLoad: true,
    storeId: 'UsersStore',
    pageSize: 2,
    proxy: {
        type: 'ajax',
        
        url: "ReadJson/GetData",
        
        
        reader: {
            type: 'json',
            method: 'GET',
            //enablePaging: true,
            totalProperty: 4,
            //root: 'users',
            successProperty: 'success'
        }
    }
});