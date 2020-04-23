
Ext.define('MvcExtTest.view.TableUser' ,{
    extend: 'Ext.grid.Panel',
    alias: 'widget.tableUser',
    store: 'UsersStore',
    title: 'Таблица DB',
    
    

    initComponent: function () {
        this.items = [{
            xtype: 'form',
            items: [{
                xtype: 'textfield',
                name: 'name',
                fieldLabel: 'Название'
            }, {
                xtype: 'textfield',
                name: 'author',
                fieldLabel: 'Автор'
            }, {
                 xtype: 'textfield',
                name: 'year',
                fieldLabel: 'Год',
                minValue: 1,
            }]
        }];
        //this.plugins = [Ext.create('Ext.grid.plugin.RowEditing',
        //    {
        //        clicksToEdit: 2
        //    })],
        this.columns = [
            {header: 'id',  dataIndex: 'id',  flex: 1},
            {header: 'Фамилия',  dataIndex: 'surname',  flex: 1},
            {header: 'Имя', dataIndex: 'name', flex: 1},
            {header: 'Отчество', dataIndex: 'patronymicName', flex: 1}
        ],
        this.bbar = Ext.create('Ext.PagingToolbar', {
            store: 'UsersStore',
            pageSize: 4,
            displayInfo: true,
            displayMsg: 'Displaying topics {0} - {1} of {2}',
            emptyMsg: "No topics to display"
        }),
          
            this.callParent(arguments);
     }
        
    
});