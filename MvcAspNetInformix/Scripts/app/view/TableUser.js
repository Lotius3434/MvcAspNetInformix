
Ext.define('MvcExtTest.view.TableUser' ,{
    extend: 'Ext.grid.Panel',
    alias: 'widget.tableUser',
    store: 'UsersStore',
    title: 'Таблица DB',


    initComponent: function() {
        this.columns = [
            {header: 'id',  dataIndex: 'id',  flex: 1},
            {header: 'Фамилия',  dataIndex: 'surname',  flex: 1},
            {header: 'Имя', dataIndex: 'name', flex: 1},
            {header: 'Отчество', dataIndex: 'patronymicName', flex: 1}
        ];

        this.callParent(arguments);
    }
});