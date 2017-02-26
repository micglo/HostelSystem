Ext.define('HostelSystem.Web.model.Rezerwacja', {
    extend: 'Ext.data.Model',

    fields: ['kodRezerwacji', 'dataUtworzenia', 'cena', 'dataZameldowania', 'dataWymeldowania', 'prowizja', 'id'],

    hasMany: { model: 'HostelSystem.Web.model.Gosc', name: 'goscie' }
});