
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
        this.dockedItems= [{
            xtype: 'pagingtoolbar',
            itemId: 'PagingToolBar',
            store: 'UsersStore',
            pageSize: 2,
            dock: 'bottom',
            displayInfo: true,
            //overflowHandler: 'scroller',
            overflowHandler: 'menu',
            items: ['-', {
                xtype: 'combo',
                itemId: 'PerPageCombo',
                store: [20, 50, 100],
                queryMode: 'local',
                width: 70,
                value: '20',
                editable: false,
                listeners: {
                    change: {
                        fn: function (cmb, v) {
                            var pagingBar = cmb.ownerCt;
                            pagingBar.getStore().setPageSize(parseInt(v));
                            pagingBar.moveFirst();
                        }
                    }
                }
            }, {
                    xtype: 'label',
                    text: '件表示'
                }]
        }],

        this.callParent(arguments);
    }
});