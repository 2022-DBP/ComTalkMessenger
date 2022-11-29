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
			this.user_id = user_id; //이는 USER 테이블의 User_id가 아닌, ID임(인덱스).

			label_Chat_Title.Text = user_name + " 대화 검색";

			//이후 기능 추가하기 각 탭별로 리스트박스/트리뷰 로드
			//트리뷰는 현재 사용자를 제외하고 출력할 것
		}
	}
}