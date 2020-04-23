Ext.define('MvcExtTest.controller.Users', {
    extend: 'Ext.app.Controller',

    views: ['TableUser', 'EditTableUser'],
    stores: ['UsersStore'],
    models: ['User'],
    init: function() {
        this.control({
            'viewport > tableUser': {
                itemdblclick: this.editBook
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
            url: 'TestEditColumn/UpdateColumn',
            params: values,
            success: function(response){
                var data=Ext.decode(response.responseText);
                if(data.success){
                    var store = Ext.widget('tableUser').getStore();
                    store.load();
                    Ext.Msg.alert('Обновление',data.message);
                }
                else{
                    Ext.Msg.alert('Обновление','Не удалось обновить книгу в библиотеке');
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
            url: 'TestEditColumn/CreateColumn',
            params: values,
            success: function(response, options){
                var data=Ext.decode(response.responseText);
                if(data.success){
                    Ext.Msg.alert('Создание',data.message);
                    var store = Ext.widget('tableUser').getStore();
                    store.load();
                }
                else{
                    Ext.Msg.alert('Создание','Не удалось добавить книгу в библиотеку');
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
            url: 'app/data/delete.php',
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
                    Ext.Msg.alert('Удаление','Не удалось удалить книгу из библиотеки');
                }
            }
        });
    },
    clearForm: function(grid, record) {
        var view = Ext.widget('editTableUser');
        view.down('form').getForm().reset();
    },
    editBook: function(grid, record) {
        var view = Ext.widget('editTableUser');
        view.down('form').loadRecord(record);
    }


});