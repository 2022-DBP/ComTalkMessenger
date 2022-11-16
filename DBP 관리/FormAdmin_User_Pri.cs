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
	public partial class FormAdmin_User_Pri : Form {
		private string user_name;
		private int user_id;

		public FormAdmin_User_Pri(string user_name, int user_id) {
			InitializeComponent();

			this.user_name = user_name;
			this.user_id = user_id;

			label_Pri_Title.Text = user_name + " 권한 조정";

			load_user_list();
		}

		private void load_user_list() {
			//직원 리스트(현재 선택된 직원 제외) 출력하기

		}

		private void button_Pri_Udt_Click(object sender, EventArgs e) {
			//직원보기 혹은 대화 권한 선택 후 리스트에서 선택된 직원들에 대해서 처리

		}
	}
}
