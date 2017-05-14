using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class LineNotifyCallback : System.Web.UI.Page
    {
        public static string access_token;
        string code;
        protected void Page_Load(object sender, EventArgs e)
        {
            //callback頁面取回code
            code = Request.QueryString["code"].ToString();
            if (!string.IsNullOrEmpty(code) && string.IsNullOrEmpty(this.TextBox1.Text))
            {
                //用code換Token//2Hpyf9miqUhdSOGs31DQeR
                var ret = isRock.LineNotify.Utility.GetToeknFromCode(
                    code, "xJ1U6e9jRyh2xYDOxdleDc", //ClientID一定要100%對
                    "dAO6BiSIkeQgzCgvEm1e9vQG5KmgsmKeOplEeIT6Qta", //ClientSecret 一定要100%對
                    "https://fortestlinebot.azurewebsites.net/LineNotifyCallback.aspx" //Callback url一定要100%對
                    );
                this.TextBox1.Text = ret.access_token;
                access_token = ret.access_token;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //發送訊息
            isRock.LineNotify.Utility.SendNotify(this.TextBox1.Text, "test" + DateTime.Now.ToString());
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            isRock.LineNotify.Utility.SendNotify(this.TextBox1.Text, this.TextBox2.Text + DateTime.Now.ToString());
        }
    }
}