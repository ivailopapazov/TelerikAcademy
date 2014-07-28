define(function () {
  'use strict';
  var Item;

  Item = (function () {
    function Item (content, type) {
      this._content = content;
      this.type = type;
    }

    Item.prototype = {
      getData: function () {
        return {
          content: this._content
        };
      }
    };

    return Item;
  })();

  return Item;
});