Ext.define('MvcExtTest.view.EditTableUser', {
    extend: 'Ext.window.Window',
    alias: 'widget.editTableUser',

    title: 'Редактирование',
    layout: 'fit',
    autoShow: true,

    initComponent: function() {
        this.items = [{
            xtype: 'form',
            items: [{
                xtype: 'textfield',
                name : 'surname',
                fieldLabel: 'Фамилия'
            },{
                xtype: 'textfield',
                name : 'name',
                fieldLabel: 'Имя'
            },{
                xtype: 'textfield',
                name : 'patronymicName',
                fieldLabel: 'Отчество',

            }]
        }];
        this.dockedItems=[{
            xtype:'toolbar',
            docked: 'top',
            items: [{
                text:'Создать',
                action: 'new'
            },{
                text:'Изменить',
                action: 'save'
            },{
                text:'Удалить',
                action: 'delete'
            }]
        }];
        this.buttons = [{
            text: 'Очистить',
            scope: this,
            action: 'clear'
        }];

        this.callParent(arguments);
    }
});