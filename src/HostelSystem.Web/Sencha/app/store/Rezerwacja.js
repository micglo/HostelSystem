Ext.define('HostelSystem.Web.store.Rezerwacja', {
    extend: 'Ext.data.Store',

    alias: 'store.rezerwacja',

    requires: [
        'HostelSystem.Web.model.Rezerwacja'
    ],

    model: 'HostelSystem.Web.model.Rezerwacja',

    proxy: {
        type: 'rest',
        url: 'http://localhost:37266/api/rezerwacja',
        reader: {
            type: 'json',
            rootProperty: 'rezerwacje'
        }
    },
    autoLoad: true
});