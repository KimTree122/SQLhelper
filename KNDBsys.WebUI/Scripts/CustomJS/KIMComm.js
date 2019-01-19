(function ($) {
    $.getUrlParam = function (name) {
        var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)");
        var r = window.location.search.substr(1).match(reg);
        if (r != null) return unescape(r[2]); return null;
    }
})(jQuery);



$(selector).each(function (index, element) { })
　　　　//index - 选择器的 index 位置
　　　　//element - 当前的元素（也可使用 "this" 选择器）
　　$(selector).each(function () { })
　　$.each(array, function (Key, Value) { })

//遍历js数组
$(function () {
    var array = ["aaa", "bbb", "ccc"];
    $.each(array, function (i, j) {
        alert(i + ":" + j);　　//i表示索引，j代表值
    });
})

//遍历Object对象
var obj = new Object();
obj.name = "zs";
$.each(obj, function (name, value) {
    　　alert(this);  //this指向当前属性的值,等价于value
    　　alert(name);  //name表示Object当前属性的名称
    　　alert(value);  //value表示Object当前属性的值
});

//遍历JSON对象
var json = { "name": "zhangSan", "role": "student" };
$.each(json, function (key, value) {
    alert(key + ":" + value);
});

//遍历由多个JSON对象组成的数组
var json2 = [{ "name": "Amy", "role": "student" }, { "name": "Tom", "role": "student" }];
$.each(json2, function (index, value) {
    alert("index=" + index + "\n" + "name:" + value.name + "\n" + "role:" + value.role + "\n");
});