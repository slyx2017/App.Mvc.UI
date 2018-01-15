//function avo(name, id, path) {
//    var url = path;
//    layui.use(['element'], function () {
//        var $ = layui.jquery;
//        element = layui.element;
//        //实例化element。
//        /* 判断是否存在 */
//        if ($(".layui-tab-title li[lay-id='" + id + "']").length > 0) {
//            element.tabChange('demo', id);
//        } else {
//            $(".layui-body .layui-tab-content").html("");
//            var res1 = "<div style='padding: 15px;'><iframe src='" + url + "' frameborder='0' scrolling='auto' style='width:100%;height:99%;min-height: 500px;'></iframe></div>";
//            // 判断tab
//            parent.element.tabAdd('demo', {
//                title : name,
//                content: res1,//'内容' + (Math.random() * 1000 | 0),
//                id: id
//            });
//        }
//        element.tabChange('demo', id);
//    });
//}

