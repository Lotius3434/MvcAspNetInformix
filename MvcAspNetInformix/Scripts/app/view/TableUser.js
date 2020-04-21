
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
        ];
        this.bbar= Ext.create('Ext.PagingToolbar', {
            store: 'UsersStore',
            displayInfo: true,
            displayMsg: 'Displaying topics {0} - {1} of {2}',
            emptyMsg: "No topics to display"
        }),
            this.items= [{
                //icon: 'del.png',
                handler: function (grid, rowIndex, colIndex) {
                    store.removeAt(rowIndex);
                }
            }]
        
            
        this.callParent(arguments);
    }
    
});