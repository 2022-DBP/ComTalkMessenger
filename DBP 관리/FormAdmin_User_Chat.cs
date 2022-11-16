using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_관리 {
    public partial class FormAdmin_User_Chat : Form {
		private string user_name;
		private int user_id;

		public FormAdmin_User_Chat(string user_name, int userID) {
            InitializeComponent();

			this.user_name = user_name;
			this.user_id = user_id;

			label_Chat_Title.Text = user_name + " 대화 검색";

			load_listBox();
		}

		private void load_listBox() {
			//사용자의 대화 리스트 출력
			//선택 후에 따로 대화창 출력 혹은 UI 옆에 따로 만들어서 대화 내용 보여주기

		}

		private void button_Chat_Search_Click(object sender, EventArgs e) {
			//textBox에 입력된 값이 해당하는 대화 검색

		}
	}
}