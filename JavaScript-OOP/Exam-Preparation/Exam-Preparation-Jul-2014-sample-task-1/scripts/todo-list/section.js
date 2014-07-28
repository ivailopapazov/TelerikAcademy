define(function () {
  'use strict';
  var Section;

  Section = (function () {
    function Section (title) {
      this.title = title;
      this._items = [];
    }

    Section.prototype = {
      add: function (item) {
        this._items.push(item);
      },
      getData: function () {
        var dataSection = {};

        dataSection.title = this.title;
        dataSection.items = [];

        for (var i = 0; i < this._items.length; i++) {
          dataSection.items.push(this._items[i].getData());
        }

        return dataSection;
      }
    };

    return Section;
  })();

  return Section;
});