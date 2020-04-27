
Ext.define('MvcExtTest.view.TableUser' ,{
    extend: 'Ext.grid.Panel',
    alias: 'widget.tableUser',
    store: 'UsersStore',
    title: 'Таблица DB',
    
    

    initComponent: function () {
        
        

        this.columns = [
            {header: 'id',  dataIndex: 'id',  flex: 1},
            {header: 'Фамилия',  dataIndex: 'surname',  flex: 1},
            {header: 'Имя', dataIndex: 'name', flex: 1},
            {header: 'Отчество', dataIndex: 'patronymicName', flex: 1}
        ],
        this.bbar = Ext.create('Ext.PagingToolbar', {
            store: 'UsersStore',
            pageSize: 10,
            displayInfo: true,
            displayMsg: 'Displaying topics {0} - {1} of {2}',
            emptyMsg: "No topics to display"
        }),
            /*this.dockedItems = Ext.create('Ext.toolbar.Toolbar', {
                dock: 'right',
                items: [
                    {
                        text: 'Создать',
                        enableToggle: true,
                        scale: 'large'
                    }, {
                        text: 'Изменить',
                        enableToggle: true,
                        scale: 'large'
                    },{
                        text: 'Удалить',
                        enableToggle: true,
                        scale: 'large'
                    }]
            }),*/
            this.dockedItems = Ext.create('MvcExtTest.view.ToolbarEditUser', {
                
            }),
          
            this.callParent(arguments);
     }
        
    
});