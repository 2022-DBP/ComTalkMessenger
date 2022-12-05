﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using Org.BouncyCastle.Asn1;
using MySqlX.XDevAPI;
using System.Collections.ObjectModel;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using MySql.Data.MySqlClient;

namespace DBP_관리
{
    public partial class Form_ChattingRoom : Form
    {
        private string chattingPartner = null;
        private TcpClient client = null;
        private string chattingRoomID = "";
        private ObservableCollection<string> messageList = new ObservableCollection<string>();


        public Form_ChattingRoom(TcpClient client, string chattingPartner, string RoomID)
        {
            string[] SplitedSender = chattingPartner.Split('%');
            chattingRoomID = RoomID;
            string chattingPartnerName = SplitedSender[1];

            this.chattingPartner = chattingPartner;//채팅하는 상대방의 이름
            this.client = client;
            InitializeComponent();

            listBoxHistory.Items.Add(messageList.ToString());
            messageList.Add(string.Format("{0}님이 입장하였습니다.", chattingPartnerName));
            this.Text = chattingPartnerName + "님과의 채팅방";

            //USER.ID를 인자로 추가할 것...
            //Load_User_Config(user_ID);
		}

		private void Load_User_Config(string user_ID) {
			//원래 저장된 테마 데이터 불러오기 및 적용
			string selectedColor = "";

			string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
			string query = "SELECT Back_Color FROM USER_Config WHERE User_ID = " + user_ID + ";";

			using (MySqlConnection connection = new MySqlConnection(Connection_string)) {
				connection.Open();
				MySqlCommand cmd = new MySqlCommand(query, connection);
				MySqlDataReader rdr = cmd.ExecuteReader();

				if (!rdr.Read()) {
					//기존 데이터가 없다면 기본 다크 모드
					selectedColor = "DarkMode";
				}

				selectedColor = rdr[0].ToString();
			}

			Apply_Mode(selectedColor);
		}

		private void Apply_Mode(string selectedColor) {
			if (selectedColor.Equals("DarkMode")) {
				this.BackColor = Color.FromArgb(66, 66, 66);
				this.ForeColor = Color.White;
			}
			else {
				this.BackColor = Color.White;
				this.ForeColor = Color.FromArgb(66, 66, 66);
			}
            this.label1.BackColor = this.BackColor;
            this.label1.ForeColor = this.ForeColor;
            this.label2.BackColor = this.BackColor;
            this.label2.ForeColor = this.ForeColor;
            this.buttonSend.BackColor = this.ForeColor;
			this.buttonSend.ForeColor = this.BackColor;
		}


		private void buttonSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSend.Text))
                return;
            string message = textBoxSend.Text;
            string parsedMessage = "";

            if (message.Contains('<') || message.Contains('>'))
            {
                MessageBox.Show("죄송합니다. >,< 기호는 사용하실수 없습니다.", "Information");
                return;
            }

            if (chattingPartner != null)
            {
                parsedMessage = string.Format("{0}<{1}#{2}>", chattingPartner, chattingRoomID, message);

                byte[] byteData = UTF8Encoding.UTF8.GetBytes(parsedMessage);
                client.GetStream().Write(byteData, 0, byteData.Length);
            }
            messageList.Add("나: " + message);
            textBoxSend.Clear();
            RefreshListBox();

        }


        private void Form_ChattingRoom_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(textBoxSend.Text))
                    return;
                string message = textBoxSend.Text;
                string parsedMessage = "";

                if (message.Contains('<') || message.Contains('>'))
                {
                    System.Windows.Forms.MessageBox.Show("죄송합니다. >,< 기호는 사용하실수 없습니다.", "Information");
                    return;
                }

                if (chattingPartner != null)
                {
                    parsedMessage = string.Format("{0}<{1}#{2}>", chattingPartner, chattingRoomID, message);
                    byte[] byteData = UTF8Encoding.UTF8.GetBytes(parsedMessage);
                    client.GetStream().Write(byteData, 0, byteData.Length);
                }


                messageList.Add("나: " + message);
                textBoxSend.Clear();
                RefreshListBox();
            }

        }
        public void ReceiveMessage(string sender, string message)
        {
            string[] SplitedSender = sender.Split('%');

            sender = SplitedSender[1];

            if (message == "ChattingStart")
            {
                return;
            }

            if (message == "상대방이 채팅방을 나갔습니다.")
            {
                string parsedMessage = string.Format("{0}님이 채팅방을 나갔습니다.", sender);
                messageList.Add(parsedMessage);


                return;
            }
            //리스트박스에 잘 띄워보자...
            messageList.Add(string.Format("{0}: {1}", sender, message));
            RefreshListBox();

        }
        private void RefreshListBox()
        {
            listBoxHistory.DataSource = null;
            listBoxHistory.DataSource = messageList;

        }

        private void Form_ChattingRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] SplitedSender = chattingPartner.Split('%');
            string chattingPartnerName = SplitedSender[1];

            string message = string.Format("{0}님과의 채팅을 종료합니다.", chattingPartnerName);
            MessageBox.Show(message);
            try
            {
                string exitMessage = "상대방이 채팅방을 나갔습니다.";
                string parsedMessage = string.Format("{0}<{1}>", chattingPartner, exitMessage);
                byte[] byteData = UTF8Encoding.UTF8.GetBytes(parsedMessage);
                client.GetStream().Write(byteData, 0, byteData.Length);
            }
            catch (Exception)
            {

            }
        }

        private void Form_ChattingRoom_Load(object sender, EventArgs e)
        {

        }
    }

}
