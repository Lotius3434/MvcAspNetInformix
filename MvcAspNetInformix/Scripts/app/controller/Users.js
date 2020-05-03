Ext.define('MvcExtTest.controller.Users', {
    extend: 'Ext.app.Controller',

    views: ['TableUser', 'AddColumn', 'EditColumn','DeleteColumn'],
    stores: ['UsersStore'],
    models: ['User'],
    
    
    init: function () {
        
        this.control({
             
            'viewport > tableUser': {
                itemclick: this.editBook
                
            },
            'tableUser button[action=create]': {
                click: this.editBook
            },
            'tableUser button[action=edit]': {
                click: this.editBook
            },
            'tableUser button[action=delete]': {
                click: this.editBook
            },
            'tableUser button[action=downloadreport]': {
                click: this.downloadreport
            },
            
            
            'editColumn button[action=save]': {
                click: this.updateBook
            },
            'deleteColumn button[action=delete]': {
                click: this.deleteBook
            },
            'addColumn button[action=create]': {
                click: this.createBook
            },
            
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
                    //var store = Ext.widget('editColumn').getStore();
                    //store.load();
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
                    //var store = Ext.widget('addColumn').getStore();
                    //store.load();
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
                    var store = Ext.widget('deleteColumn').getStore();
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
    downloadreport: function () {
        Ext.Ajax.request({
            type: 'pdf',
            
            method: 'POST',
            url: 'Report/GetReport',
            success: function (response) {
                var win = window.open("report.pdf", '_blank');
                win.location = url;
                win.focus();
            }
            /*params: values,
            success: function (response, options) {
                var data = Ext.decode(response.responseText);
                if (data.success) {
                    Ext.Msg.alert('Создание', data.message);
                    //var store = Ext.widget('addColumn').getStore();
                    //store.load();
                }
                else {
                    Ext.Msg.alert('Создание', 'Не удалось создать строку');
                }
            }*/
        });

    },
    
    editBook: function (e, record) {
        if (e.id == "create") {
            var view = Ext.widget('addColumn');
            view.down('form').loadRecord(record);
        }
        if (e.id == "edit") {
            var view = Ext.widget('editColumn');
            view.down('form').loadRecord(this.record);
        };
        if (e.id == "delete") {
            var view = Ext.widget('deleteColumn');
            view.down('form').loadRecord(this.record);
        };
        this.record = record;        
    },
    

});