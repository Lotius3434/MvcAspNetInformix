Ext.application({
	requires: ['Ext.container.Viewport'],
	name: 'MvcExtTest',
	appFolder: 'Scripts/app',
	controllers: ['Users'],

	launch: function() {
		Ext.create('Ext.container.Viewport', {
			layout: 'fit',
			items: {
				xtype: 'tableUser'
			}
		});
	}
});