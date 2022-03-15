using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_OnClick(object sender, EventArgs e)
    {
        string msg = TextArea1.Value;
        string path = "C:/Text";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        path = path + "/" + DateTime.Today.ToString("yyyyMMdd") + "Log.txt";
        FileStream fs = new FileStream(path, FileMode.Append);
        StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("UTF-8"));
        sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + msg+ "\r\n");
        sw.Close();
        fs.Close();
        TextArea1.Value="";
    }
}