$(function () {
    var option = {
        page: 1,
        i: 4,//每版放4个图片  
        DTime: null,
        funRight: function () {
            //向后 按钮  
            $(".btnright").click(function () {    //绑定click事件
                var content = $(".stage-outer");
                var content_list = $(".owl-item");
                var v_width = content.width();
                var len = content.find("ul li").length;
                var page_count = Math.ceil(len / option.i);   //只要不是整数，就往大的方向取最小的整数  
                if (!content_list.is(":animated")) {    //判断“内容展示区域”是否正在处于动画  
                    if (option.page == page_count) {  //已经到最后一个版面了,如果再向后，必须跳转到第一个版面。  
                        content_list.animate({ left: '0px' }, "slow"); //通过改变left值，跳转到第一个版面  
                        option.page = 1;
                    } else {
                        content_list.animate({ left: '-=' + v_width }, "slow");  //通过改变left值，达到每次换一个版面  
                        option.page++;
                    }
                }
            });
        },
        funLeft: function () {
            //往前 按钮  
            $(".btnleft").click(function () {
                var content = $(".stage-outer");
                var content_list = $(".owl-item");
                var v_width = content.width();
                var len = content.find("ul li").length;
                var page_count = Math.ceil(len / option.i);   //只要不是整数，就往大的方向取最小的整数  
                if (!content_list.is(":animated")) {    //判断“内容展示区域”是否正在处于动画  
                    if (option.page == 1) {  //已经到第一个版面了,如果再向前，必须跳转到最后一个版面。  
                        content_list.animate({ left: '-=' + v_width * (page_count - 1) }, "slow");
                        option.page = page_count;
                    } else {
                        content_list.animate({ left: '+=' + v_width }, "slow");
                        option.page--;
                    }
                }
            });
        },
        timers: function () {
            option.DTime = setInterval(function () {
                var content = $(".stage-outer");
                var content_list = $(".owl-item");
                var v_width = content.width();
                var len = content.find("ul li").length;
                var page_count = Math.ceil(len / option.i);   //--只要不是整数，就往大的方向取最小的整数-->
                if (!content_list.is(":animated")) {    //判断“内容展示区域”是否正在处于动画  
                    if (option.page == 1) {  //已经到第一个版面了,如果再向前，必须跳转到最后一个版面。  
                        content_list.animate({ left: '-=' + v_width * (page_count - 1) }, "slow");
                        option.page = page_count;
                    } else {
                        content_list.animate({ left: '+=' + v_width }, "slow");
                        option.page--;
                    }
                }
            }, 5000);
        }
    };
    option.funLeft();
    option.funRight();
    option.timers();
});