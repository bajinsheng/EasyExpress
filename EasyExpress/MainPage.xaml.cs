using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using EasyExpress.Resources;
using System.IO;
using System.Text;

namespace EasyExpress
{
    public partial class MainPage : PhoneApplicationPage
    {
            public string retString;
            information ht = new information();

            // 构造函数
            public MainPage()
            {
                InitializeComponent();
                string[,] company = Common.GetExpressCompany();
                List<Company> source = new List<Company>();
                for (int i = 0; i < company.Length / 2; i++)
                {
                    source.Add(new Company() { Name = company[i, 0].ToString(), NO = company[i, 1].ToString() });
                }
                listPicker.ItemsSource = source;
            }
            private void Button_Click(object sender, EventArgs e)
            {
                if (!Microsoft.Phone.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    MessageBox.Show("手机网络不可用！");
                    return;
                }
                if (Input.Text == "")
                {
                    MessageBox.Show("请输入单号！");
                    return;
                }
                filter.Visibility = Visibility.Visible;
                pro.Visibility = Visibility.Visible;
                string company = ((Company)listPicker.SelectedItem).NO;
                string sn = Input.Text;
                string postDataStr = "type=" + company + "&postid=" + sn;
                UriBuilder fullUri = new UriBuilder("http://www.kuaidi100.com/query" + (postDataStr == "" ? "" : "?") + postDataStr);
                WebRequest request = HttpWebRequest.Create(fullUri.Uri);
                IAsyncResult result = (IAsyncResult)request.BeginGetResponse(ResponseCallback, request);

            }

            private void ResponseCallback(IAsyncResult ar)
            {
                try
                {
                    HttpWebRequest request = (HttpWebRequest)ar.AsyncState;
                    WebResponse response = request.EndGetResponse(ar);
                    Stream streamResult = response.GetResponseStream();
                    StreamReader myStreamReader = new StreamReader(streamResult, Encoding.GetEncoding("utf-8"));
                    string json = myStreamReader.ReadToEnd();
                    ht = JsonCommon.SelectDictionary(streamResult);
                    if (ht.status == "200")
                    {
                        List<information.indexList> n = ht.data;
                        int a = ht.state;
                        Deployment.Current.Dispatcher.BeginInvoke(() =>
                        {
                            expressList.ItemsSource = n;
                            filter.Visibility = Visibility.Collapsed;
                            pro.Visibility = Visibility.Collapsed;
                        });
                        myStreamReader.Dispose();
                        streamResult.Dispose();
                        return;
                    }
                    else
                    {
                        Deployment.Current.Dispatcher.BeginInvoke(() =>
                        {
                            MessageBox.Show("查询不到结果！");
                            filter.Visibility = Visibility.Collapsed;
                            pro.Visibility = Visibility.Collapsed;
                            return;
                        });
                    }
                }
                catch (FormatException)
                {
                    Deployment.Current.Dispatcher.BeginInvoke(() =>
                    {
                        MessageBox.Show("请检查手机网络！");
                        filter.Visibility = Visibility.Collapsed;
                        pro.Visibility = Visibility.Collapsed;
                    });
                    return;
                }
            }
    }
}