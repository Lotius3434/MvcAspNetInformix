Ext.define('MvcExtTest.view.DeleteColumn', {
    extend: 'Ext.window.Window',
    alias: 'widget.deleteColumn',

    title: 'Удаление строки',
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
            text: 'Удалить',

            action: 'delete'
        }];

        this.callParent(arguments);
    }
});