Ext.define('MvcExtTest.view.EditToolbarUser', {
    extend: 'Ext.toolbar.Toolbar',
    alias: 'widget.editToolbarUser',

    title: 'Редактирование',
    layout: 'fit',
    autoShow: true,
    docked: 'right',
    initComponent: function () {
        this.items = [{
            text: 'Создать',
            action: 'new'
        }, {
            text: 'Изменить',
            action: 'save'
        }, {
            text: 'Удалить',
            action: 'delete'
        }];
        /*this.dockedItems = [{
            xtype: 'toolbar',
            docked: 'right',
            items: [{
                text: 'Создать',
                action: 'new'
            }, {
                text: 'Изменить',
                action: 'save'
            }, {
                text: 'Удалить',
                action: 'delete'
            }]
        }];*/
        /*this.buttons = [{
            text: 'Очистить',
            scope: this,
            action: 'clear'
        }];*/

        this.callParent(arguments);
    }
});