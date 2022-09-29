# 第4次練習-練習-PC4
>
>學號：109111136
><br />
>姓名：李俊賢
><br />
>作業撰寫時間：30 (mins，包含程式撰寫時間)
><br />
>最後撰寫文件日期：2022/9/29
>

本份文件包含以下主題：(至少需下面兩項，若是有多者可以自行新增)
- [x]說明內容
- [x]個人認為完成作業須具備觀念

## 說明程式與內容
下段程式碼則為使用後結果：test是利用Age判斷

    protected void Page_Load(object sender, EventArgs e)
        {
            int i_Age = 1;
            int i_Sex = 0;
            if (i_Age >= 50)
            {
                if (i_Sex == 0)
                {
                    Response.Write("壯年女人");
                }
                else
                {
                    Response.Write("壯年男人");
                }
            }
            else
            {
                if (i_Sex == 0)
                {
                    Response.Write("年輕女人");
                }
                else
                {
                    Response.Write("年輕男人");
                }
            }
        }

    protected void Page_Load(object sender, EventArgs e)
        {
            int i_Age = 1;
            int i_Sex = 0;
            if (!(!(i_Age >= 50) || !(i_Sex == 1)))
            {
                Response.Write("壯年男人");
            }
            else if (!(!(i_Age < 50) || !(i_Sex == 1)))
            {
                Response.Write("年輕男人");
            }
            else if (!(!(i_Age >= 50) || !(i_Sex == 0)))
            {
                Response.Write("壯年女人");
            }
            else if (!(!(i_Age < 50) || !(i_Sex == 0)))
            {
                Response.Write("年輕女人");
            }
            else
            {
                Response.Write("其他");
            }
        }

若要於內文中標示部分.aspx檔，則使用以下標籤` ```html 程式碼 ``` `，
下段程式碼則為使用後結果：

```html
<%@ Page Language="C#" AutoEventWireup="true" ...>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" ...>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
```


## 個人認為完成作業須具備觀念

開始寫說明，需要說明本次作業個人覺得需學會那些觀念 (需寫成文章，需最少50字，
並且文內不得有你、我、他三種文字)

