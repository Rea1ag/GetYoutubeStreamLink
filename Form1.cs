using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetYoutubeThreads
{
	public partial class Form1 : Form
	{
		string page;
		string HDPage;
		string _subString;
		string _AllLink;
		string _ThreadsubString;
		string Thread = "96";

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			GetWeb();
			SearchLink();
		}

		private void GetWeb()
		{
			using (var client = new WebClient())
			{
				page = client.DownloadString(textBox1.Text);
			}

			File.WriteAllText("AllPage.txt", page);
			//page = File.ReadAllText("save.txt", Encoding.Default);
			textBox2.Text = page;
		}

		private void SearchLink()
		{
			StreamReader str = new StreamReader("AllPage.txt", Encoding.Default);
			while (!str.EndOfStream)
			{
				string st = str.ReadLine();
				if (st.StartsWith("ytimg.preload"))
				{
					string firstString = "https://manifest.googlevideo.com/api/manifest/hls_variant"; //индекс первого символа
					string lastString = "file/index.m3u8"; //индекс последнего символа
					int indexOffirststring = st.IndexOf(firstString);
					int indexOflaststring = st.LastIndexOf(lastString);
					int length = indexOflaststring - indexOffirststring;
					string subString = st.Substring(indexOffirststring, length + 15); //Извлекаем ссылку (Первый индекс, длинна)
																					  //string ReadyLink = subString + "file/index.m3u8";
					_subString = subString;
					File.WriteAllText("ReadyLink.txt", subString);
					textBox2.Text = Convert.ToString(subString);
					textBox2.ForeColor = SystemColors.WindowText;
					textBox2.Enabled = true;
					textBox2.SelectAll();
					break;
				}
				else if (st.StartsWith("ytimg.preload"))
				{
					textBox2.Text = "";
					textBox2.Enabled = false;
					//pictureBox2.Visible = false;
					MessageBox.Show("Данный источник не является трансляцией.\nПопробуйте снова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
				}

			}

		}

		private void textBox2_Click(object sender, EventArgs e)
		{
			label2.Text = "Скопированно";                               //GAVNO
			if (label2.Visible == false & label2.Text == "Скопированно")//GAVNO
			{
				var t = new Timer { Interval = 500 };                     //GAVNO
				t.Interval = 2500;                                      //GAVNO
				t.Tick += new EventHandler(t_Tick);                     //GAVNO
				t.Start();                                              //GAVNO
				label2.Visible = true;                                  //GAVNO
			}
			Clipboard.Clear();
			Clipboard.SetText(textBox2.Text);
			textBox2.SelectAll();
		}

		private void t_Tick(object sender, EventArgs e)
		{

			label2.Text = "";
		}

		private void Form1_Load(object sender, EventArgs e)
		{

			textBox2.Text = "Your link";
			if (textBox2.Text == "Your link")
			{
				textBox2.Enabled = false;
			}
			textBox2.ForeColor = SystemColors.InactiveCaption;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			GetWeb();
			SearchLink();
			using (var client = new WebClient())
			{
				HDPage = client.DownloadString(_subString);
			}

			File.WriteAllText("index.m3u8", HDPage);
			//page = File.ReadAllText("save.txt", Encoding.Default);
			//textBox2.Text = HDPage;
			StreamReader str = new StreamReader("index.m3u8", Encoding.Default);
			while (!str.EndOfStream)
			{
				string st = str.ReadLine();
				if (st.StartsWith("https://manifest.googlevideo.com/api/manifest/hls_playlist"))
				{
					string firstString = "/itag/"; //индекс первого символа
					string lastString = "/source/"; //индекс последнего символа
					int indexOffirststring = st.IndexOf(firstString)+6;
					int indexOflaststring = st.LastIndexOf(lastString);
					int length = indexOflaststring - indexOffirststring;
					string OneTrashsubString = st.Substring(indexOffirststring, length);
					_ThreadsubString = OneTrashsubString;

					if (st.StartsWith("https://manifest.googlevideo.com/api/manifest/hls_playlist")  && _ThreadsubString == Thread)//& st.IndexOf(OnefirstString) == 139
					{
						_AllLink = st;
						File.WriteAllText("1080p.m3u8", _AllLink);
						textBox2.Text = Convert.ToString(_AllLink);
						textBox2.ForeColor = SystemColors.WindowText;
						textBox2.Enabled = true;
						textBox2.SelectAll();
						break;
					}
				}
			}
		}
	}
}

