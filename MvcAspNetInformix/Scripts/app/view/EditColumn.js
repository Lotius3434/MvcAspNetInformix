Ext.define('MvcExtTest.view.EditColumn', {
    extend: 'Ext.window.Window',
    alias: 'widget.editColumn',

    title: 'Редактирование',
    layout: 'fit',
    autoShow: true,

    initComponent: function () {
        this.items = [{
            xtype: 'form',
            items: [{
                xtype: 'textfield',
                name: 'surname',
                fieldLabel: 'Фамилия'
            }, {
                xtype: 'textfield',
                name: 'name',
                fieldLabel: 'Имя'
            }, {
                xtype: 'textfield',
                name: 'patronymicName',
                fieldLabel: 'Отчество',

            }]
        }];
        
        this.buttons = [{
            text: 'Сохранить',
            
            action: 'save'
        }];

        this.callParent(arguments);
    }
});