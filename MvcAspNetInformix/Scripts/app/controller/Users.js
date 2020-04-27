Ext.define('MvcExtTest.controller.Users', {
    extend: 'Ext.app.Controller',

    views: ['TableUser', 'EditTableUser','ToolbarEditUser'],
    stores: ['UsersStore'],
    models: ['User'],
    
    
    init: function () {
        
        this.control({
             
            'viewport > tableUser': {
                itemclick: this.editBook
                
            },
            'tableUser button[action=on]': {
                click: this.editBook
            },
            
            'editTableUser button[action=new]': {
                click: this.createBook
            },
            'editTableUser button[action=save]': {
                click: this.updateBook
            },
            'editTableUser button[action=delete]': {
                click: this.deleteBook
            },
            'editTableUser button[action=clear]': {
                click: this.clearForm
            }
        });
    },
    // обновление
    updateBook: function(button) {
        var win    = button.up('window'),
            form   = win.down('form'),
            values = form.getValues(),
            id = form.getRecord().get('id');
        values.id=id;
        Ext.Ajax.request({
            url: 'EditColumn/UpdateColumn',
            params: values,
            success: function(response){
                var data=Ext.decode(response.responseText);
                if(data.success){
                    var store = Ext.widget('tableUser').getStore();
                    store.load();
                    Ext.Msg.alert('Обновление',data.message);
                }
                else{
                    Ext.Msg.alert('Обновление','Не удалось обновить строку ');
                }
            }
        });
    },
    // создание
    createBook: function(button) {
        var win    = button.up('window'),
            form   = win.down('form'),
            values = form.getValues();
        Ext.Ajax.request({
            url: 'EditColumn/CreateColumn',
            params: values,
            success: function(response, options){
                var data=Ext.decode(response.responseText);
                if(data.success){
                    Ext.Msg.alert('Создание',data.message);
                    var store = Ext.widget('tableUser').getStore();
                    store.load();
                }
                else{
                    Ext.Msg.alert('Создание','Не удалось создать строку');
                }
            }
        });
    },
    // удаление
    deleteBook: function(button) {
        var win    = button.up('window'),
            form   = win.down('form'),
            id = form.getRecord().get('id');
        Ext.Ajax.request({
            url: 'EditColumn/DeleteColumn',
            params: {id:id},
            success: function(response){
                var data=Ext.decode(response.responseText);
                if(data.success){
                    Ext.Msg.alert('Удаление',data.message);
                    var store = Ext.widget('editTableUser').getStore();
                    var record = store.getById(id);
                    store.remove(record);
                    form.getForm.reset();
                }
                else{
                    Ext.Msg.alert('Удаление','Не удалось удалить строку');
                }
            }
        });
    },
    clearForm: function(grid, record) {
        var view = Ext.widget('editTableUser');
        view.down('form').getForm().reset();
    },
    
    editBook: function (e, record) {
        if (e.id == "create") {
            var view = Ext.widget('editTableUser');
            view.down('form').loadRecord(this.record);
        }
        this.record = record;
        
        
        
    },
    

});