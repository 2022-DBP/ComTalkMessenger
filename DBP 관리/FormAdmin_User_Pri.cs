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
			this.user_id = user_id;	//이는 USER 테이블의 User_id가 아닌, ID임(인덱스).

			label_Pri_Title.Text = user_name + " 권한 조정";
		}

		//트리뷰(체크박스)에서 선택된 직원들/부서/팀에 대해서 처리(체크박스를 사용해서 해당 부서를 선택하면 최하단 노드(직원들)을 선택되게 만듬)
		//직원 트리뷰 출력시에는 본인은 제외하고 출력
	}
}
