/**
 * This class is the main view for the application. It is specified in app.js as the
 * "mainView" property. That setting automatically applies the "viewport"
 * plugin causing this view to become the body element (i.e., the viewport).
 *
 * TODO - Replace this content of this view to suite the needs of your application.
 */
Ext.define('HostelSystem.Web.view.main.Main', {
    extend: 'Ext.grid.Panel',
    xtype: 'rezerwacje',

    requires: [
        'HostelSystem.Web.store.Rezerwacja'
    ],

    title: 'Rezerwacje',

    store: {
        type: 'rezerwacja'
    },

    columns: [
        { text: 'Id', dataIndex: 'id', flex: 1 },
        { text: 'Kod rezerwacji', dataIndex: 'kodRezerwacji', flex: 1 },
        { text: 'Data utworzenia', dataIndex: 'dataUtworzenia', flex: 1 },
        { text: 'Data zameldowania', dataIndex: 'dataZameldowania', flex: 1 },
        { text: 'Data wymeldowania', dataIndex: 'dataWymeldowania', flex: 1 },
        { text: 'Cena', dataIndex: 'cena', flex: 1 },
        { text: 'Prowizja', dataIndex: 'prowizja', flex: 1 },
        {
            text: 'Goscie', dataIndex: 'goscie', flex: 1, renderer: function (goscieList) {
                var returnString = '';
            Ext.each(goscieList,
                function(gosc) {
                    returnString += gosc.imie + ' ' + gosc.nazwisko + '<br/>';
                });
                return returnString;
            }}
    ]
});
