 var Kquery = (function () {
    function _firstFunc(str) {
        console.log(str);
    };
     return {
         firstFunc: _firstFunc
     };

})();

(function () {

    var _plugin_api = {
        kimlog: function (str) {
            console.log(str);
            return this;
        }
    }
    this.KWrench = _plugin_api;
})();
