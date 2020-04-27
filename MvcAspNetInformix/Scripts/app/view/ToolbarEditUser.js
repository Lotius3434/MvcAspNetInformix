Ext.define('MvcExtTest.view.ToolbarEditUser',{
    extend: 'Ext.toolbar.Toolbar',
    alias: 'widget.toolbarEditUser',
    autoShow: true,
    
    initComponent: function () {
        
        this.item = [
            {
                text: 'Создать',
                action : '',
            },
            {
                text: 'Редактировать',
                action : '',
            },
            {
                text: 'Удалить',
                action : '',
            },
        ],
        this.callParent(arguments);

    }

})