using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class LineChatController : ApiController
    {
        [HttpPost]
        public IHttpActionResult POST()
        {
            string ChannelAccessToken = "XYaRE0qBH4/2oKlLnvo37e20XZDV6Oz104ynfWt/jwIKC1kQC+MN/Ryvj8jVo0W/Gnej675fXB6jrFQkMt5xz/nx1aGFsLlFi8igSkNttLYJdG4U1+LSl9dcXhPizM3XjD3dNFNjDKJCzYSaHmdbJQdB04t89/1O/w1cDnyilFU=";


            //isRock.LineBot.Utility.PushMessage(UserId, 要傳送的訊息, AccessToken);
            try
            {
                //取得 http Post RawData(should be JSON)
                string postData = Request.Content.ReadAsStringAsync().Result;
                //剖析JSON
                var ReceivedMessage = isRock.LineBot.Utility.Parsing(postData);
                //回覆訊息

                string  ReplyToken, timestamp, type;

                string groupId,roomId, userId, souretype;

                string messagetype, id, text, title, address, latitude, longitude;
                int packageId, stickerId;

                string data;

                string Message;

                //timestamp = ReceivedMessage.events[0].timestamp.ToString();
                ReplyToken = ReceivedMessage.events[0].replyToken;
                //type = ReceivedMessage.events[0].type.ToString();

                //groupId = ReceivedMessage.events[0].source.groupId.ToString();
                //roomId = ReceivedMessage.events[0].source.roomId.ToString();
                //userId = ReceivedMessage.events[0].source.userId;
                //souretype = ReceivedMessage.events[0].source.type.ToString();

                //messagetype = ReceivedMessage.events[0].message.type.ToString();
                id = ReceivedMessage.events[0].message.id.ToString();
                text = ReceivedMessage.events[0].message.text;
                //title = ReceivedMessage.events[0].message.title.ToString();
                //address = ReceivedMessage.events[0].message.address.ToString();
                //latitude = ReceivedMessage.events[0].message.latitude.ToString();
                //longitude = ReceivedMessage.events[0].message.longitude.ToString();
                //packageId = ReceivedMessage.events[0].message.packageId;
                //stickerId = ReceivedMessage.events[0].message.stickerId;

                //data = ReceivedMessage.events[0].postback.data.ToString();

                Message = "你說了:" + text +"----id:"+id;
                //回覆用戶
                isRock.LineBot.Utility.ReplyMessage(ReplyToken, Message, ChannelAccessToken);
                //回覆API OK
                return Ok();
            }
            catch (Exception ex)
            {
                return Ok();
            }
        }
    }
}
