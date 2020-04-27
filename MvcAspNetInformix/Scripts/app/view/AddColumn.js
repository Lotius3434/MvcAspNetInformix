Ext.define('MvcExtTest.view.AddColumn', {
    extend: 'Ext.window.Window',
    alias: 'widget.addColumn',

    title: 'Создание строки',
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
            text: 'Создать',
            action: 'create'

        }];

        this.callParent(arguments);
    }
});