Ext.define('HostelSystem.Web.model.Gosc', {
    extend: 'Ext.data.Model',

    fields: [
        { name: 'imie', type: 'string' },
        { name: 'nazwisko', type: 'string' },
        { name: 'email', type: 'string' },
        { name: 'telefon', type: 'string' },
        { name: 'adres', type: 'string' }
    ],

    belongsTo: 'HostelSystem.Web.model.Rezerwacja'
});