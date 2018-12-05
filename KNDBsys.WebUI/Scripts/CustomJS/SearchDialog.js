(function () {

    var dom = {
        text: "SearchTxt",
        icon: "SearchTxt-Icon",
        win: "SearchTxt-Win",
        WinIframe: "SearchTxt-Win-Iframe"
    };


    var SearchDialogDom = {

        Klog: function (str) {
            console.error(str);
            return this;
        },
        SearchDialog: function (dict) {
            var FieldArrLen = dict.FieldArr.length;
            if (dict.DomArr.length !== FieldArrLen) {
                SearchDialogDom.Klog('获取数据不相符');
                return this;
            }
        }

    };

    var moreFn = function (dict) {
        var MoreValArr = dict.MoreValArr.length;
        var MoreKeyArr = dict.MoreValArr.length;
        var moreParam = "";
        if (MoreValArr && MoreKeyArr) {
            if (MoreValArr.length !== MoreKeyArr.length) {
                SearchDialogDom.Klog("更多查询数据不相符");
                return;
            }
            for (var i = 0; i < dict.MoreValArr.length; i++) {
                moreParam += "&" + dict.MoreKeyArr[i] + encodeURIComponent(dict.MoreValArr[i].val());
            }
            if (status === 0) {
                if (dict.WinUrl.indexOf("?") === -1) {
                    moreParam = "?SearchParam=" + moreParam;
                }
            }
        }
    };

    //var MustValArr = dict.MustValArr ? dict.MustValArr : "";
    //var CountValArr = dict.CountValArr ? dict.CountValArr : "";
    //dict.DomArr[0].netx();




    this.SearchDialog = SearchDialogDom;

})();