
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
		//USER 폼에 이미 관련 UI가 있지만, 권한 조정이 USER 폼에 들어가고 로그 검색이 폼 열기로 바뀔 수 있으므로 일단 삭제하지 않고 남겨둠

		private string user_name;
		private int user_id;

		public FormAdmin_User_Chat(string user_name, int userID) {
            InitializeComponent();

			this.user_name = user_name;
			this.user_id = user_id;

			label_Chat_Title.Text = user_name + " 로그 검색";

			load_listBox();
		}

		private void load_listBox() {
			//사용자의 로그(대화, 접속 시간..) 출력

		}

		private void button_Chat_Search_Click(object sender, EventArgs e) {
			//textBox에 입력된 값이 해당하는 대화 검색

		}
	}
}