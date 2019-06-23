using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace songapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET api/values/Faith
        [HttpGet("{title}")]
        public ActionResult<string> Get(string title)
        {
            if (title == "Grow")
            {
                return "[{\n   \"title\": \"J1\", \n   \"author\": \"J\", \n   \"lyrics\":\" Another day without your smile<br>\n               Another day just passes by<br>\n                But now i know how much it means<br>\n                For you to stay right here with me<br>\n                The time we spent apart will make our love grow stronger<br>\n                But it hurts so bad i can't take it any longer<br>\n                <br>\n                I want to grow old with you<br>\n                I want to die lying in your arms<br>\nI want to grow old with you<br>\nI want to be looking in your eyes<br>\nI want to be there for you, sharing everything you do<br>\nI want to grow old with you<br>\n                \"\n},\n\n{\"title\": \"J2\", \n   \"author\": \"J\", \n   \n   \"lyrics\":\" A thousand miles between us now<br>\nIt causes me to wonder how<br>\nOur love tonight remains so strong<br>\nIt makes our risk right all along<br>\nThe time we spent apart will make our love grow stronger<br>\nBut it hurt so bad i can't take it any longer<br><br>\n\nI want to grow old with you<br>\nI want to die lying in your arms<br>\nI want to grow old with you<br>\nI want to be looking in your eyes<br>\nI want to be there for you, sharing everything you do<br>\nI want to grow old with you<br><br>\n\nThings can come and go<br>\nI know but<br>\nBaby I believe<br>\nSomething's burning strong between us<br>\nMakes it clear to me<br>\n<br>\n\nI want to grow old with you<br>\nI want to die lying in your arms<br>\nI want to grow old with you<br>\nI want to be looking in your eyes<br>\nI want to be there for you, sharing everything you do<br>\nI want to grow old with you<br>\n\n\"\n   \n   \n   }\n\n\n]";
            }

            if (title == "Xiao")
            {
                return "[{\n   \"title\": \"J1\", \n   \"author\": \"J\", \n   \"lyrics\":\"我想要看春天的雨漫<br>\n也想要闻夏天的傍晚<br>\n我想拥抱秋天的落单<br>\n这些在冬里哑声呼喊<br>\n依稀看见乌云压过来轰隆隆<br>\n果然期待的事又落空<br><br>\n破碎的墙皮腐朽的树木空洞<br>\n里面的枯枝桠何时开上花<br>\n结果从黑暗里的时间里的指尖里成为\n\n\n\n                \"\n},\n\n{\"title\": \"J2\", \n   \"author\": \"J\", \n   \n   \"lyrics\":\"一年孤寡的笑嘻嘻的无聊的多一岁<br>\n生活不会再糟糕糟糕的只有人后悔<br><br>\n\n后悔没有...<br>\n我想要看<br>\n春天的雨漫<br>\n   也想要闻夏天的傍晚<br>\n我想拥抱秋天的落单<br>\n这些在冬里哑声呼喊<br>\n我想要唱东边的呢喃<br>\n也想要踩西边的海岸<br>\n我想靠近南边的温暖<br><br>\n\n这些在北边静静上船<br>\n从来 只为 一人 盛开<br>\n也从 只为 一人 垂败<br>\n经过的叶子路都比记忆还清楚<br>\n掘断的根茎<br>\n生硬到念不清<br><br>\n\n结果从白昼里的抚慰里的欲望里后退<br>\n一年可爱的流了泪的二X的多一岁<br>\n日落不会再逃跑<br>\n逃跑的只有美好<br>\n知不知道<br><br>\n\n我想要看春天的雨漫<br>\n也想要闻夏天的傍晚<br>\n我想拥抱秋天的落单<br>\n这些在冬里哑声呼喊<br>\n我想要唱东边的呢喃<br>\n也想要踩西边的海岸<br>\n我想靠近南边的温暖<br>\n这些在北边静静上船<br><br>\n\n结果从黑暗里的时间里的指尖里成为<br>\n一年孤寡的笑嘻嘻的无聊的多一岁<br>\n生活不会再糟糕糟糕的只有人后悔<br>\n后悔没有...<br>\n结果从白昼里的抚慰里的欲望里后退<br>\n一年可爱的流了泪的二X的多一岁<br>\n日落不会再逃跑<br>\n逃跑的只有美好<br><br>\n\n知不知道<br>\n结果从黑暗里的时间里的指尖里成为<br>\n一年孤寡的笑嘻嘻的无聊的多一岁<br>\n生活不会再糟糕糟糕的只有人后悔<br>\n后悔没有...<br>\n结果从白昼里的抚慰里的欲望里后退<br>\n一年可爱的流了泪的二X的多一岁<br>\n日落不会再逃跑<br>\n逃跑的只有美好<br>\n知不知道\n\n\n\n\n\n\n\"\n   \n   \n   }\n\n\n]";
            }

            if (title == "Jaiho")
            {
                return "[{\n   \"title\": \"J1\", \n   \"author\": \"J\", \n   \"lyrics\":\"जय हो<br>\nजय हो<br>\nजय हो<br>\nजय हो<br>\nआजा आजा जींद शामियाने के तले<br>\nआजा ज़री वाले नीले आसमान के तले<br><br>\nजय हो, जय हो<br>\nजय हो, जय हो, जय हो, जय हो<br>\nजय हो, जय हो, जय हो, जय हो<br>\nरत्ती रत्ती सच्ची मैंने जान गंवाई है<br>\nनच-नच कोयलों पे रात बिताई है<br>\nअंखियों की नींद मैंने फूंकों से उड़ा दी<br>\nगिन गिन तारे मैंने ऊंगली जलाई है<br>\nआजा आजा जींद शामियाने के तले<br>\nआजा ज़री वाले नीले आसमान के तले<br>\nजय हो, जय हो, जय हो, जय हो<br>\n                \"\n},\n\n{\"title\": \"J2\", \n   \"author\": \"J\", \n   \n   \"lyrics\":\"जय हो, जय हो<br>\nजय हो, जय हो, जय हो, जय हो<br>\nजय हो, जय हो, जय हो, जय हो<br><br>\nचख ले, हां चख ले, ये रात शहद है, चख ले<br>\nरख ले, हां दिल है, दिल आखरी हद है रख ले<br>\nकाला काला काजल तेरा कोई काला जादू है ना<br>\nआजा आजा जींद शामियाने के तले<br>\nआजा ज़री वाले नीले आसमान के तले<br>\nजय हो, जय हो<br><br>\n\nजय हो, जय हो<br>\nजय हो, जय हो, जय हो, जय हो<br>\nजय हो, जय हो, जय हो, जय हो<br><br>\n\nकब से हां कब से जो लब पे रुकी है<br>\nकह दे कह दे, हां कह दे<br>\nअब आंख झुकी है, कह दे<br>\nऐसी ऐसी रोशन आंखें<br>\nरोशन दोनों हीरे हैं क्या?<br>\nआजा आजा जींद शामियाने के तले<br>\nआजा ज़री वाले नीले आसमान के तले<br>\nजय हो, जय हो, जय हो, जय हो<br><br>\n\nजय हो <br>\nजय हो <br>\nजय हो <br>\nजय हो <br>\n \n\n\n\n\n\"\n   \n   \n   }\n\n\n]"
            ;
            }

            if (title == "comethru")
            {
                return "[{\n   \"title\": \"J1\", \n   \"author\": \"J\", \n   \"lyrics\":\" " +
                    "I might lose my mind<br>\n                Waking when the sun's down<br>\n                " +
                    "Riding all these highs<br>\n                Waiting for the comedown<br>\n               " +
                    " Walk these streets with me<br>\n                I'm doing decently<br>\n                Just glad that I can breathe, yeah<br>\n                I'm trying to realize<br>\n                It's alright to not be fine on your own \"\n},\n\n{\"title\": \"J2\", \n   \"author\": \"J\", \n   \n   \"lyrics\":\" Now I'm shaking, drinking all this coffee<br>\n               " +
                    " These last few weeks have been exhausting<br>\n                " +
                    "I'm lost in my imagination<br>\n                " +
                    "And there's one thing that I need from you<br>\n                Can you come through, through<br>\n                Through, yeah<br><br>\n                And there's one thing that I need from you<br>\n                Can you come through?<br>\n                Ain't got much to do<br>\n                Too old for my hometown<br>\n                Went to bed at noon<br>\n                Couldn't put my phone down<br>\n                Scrolling patiently<br>\n                It's all the same to me<br>\n                Just faces on a screen, yeah<br><br>\n                I'm trying to realize<br>\n                It's alright to not be fine on your own<br>\n                Now I'm shaking, drinking all this coffee<br>\n                These last few weeks have been exhausting<br>\n                I'm lost in my imagination<br><br>\n                And there's one thing that I need from you<br>\n                Can you come through, through<br>\n                Through, yeah<br>\n                And there's one thing that I need from you<br>\n                Can you come through, through<br>\n                Through, yeah<br>\n                And there's one thing that I need from you<br>\n                Can you come through?\"\n   \n   \n   }\n\n\n]";
            
                    }

            return "unknown";
        }
    }
}
