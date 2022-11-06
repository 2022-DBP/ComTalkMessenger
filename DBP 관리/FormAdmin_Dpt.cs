namespace DBP_관리 {
	public partial class FormAdmin_Dpt : Form {
		public FormAdmin_Dpt() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {

		}

		private void 메인화면ToolStripMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show("작동");
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button_Dpt_Search_Click(object sender, EventArgs e)
		{
            string Connection_string = "Server=115.85.181.212;Port=3306;Database=s5469698;Uid=s5469698;Pwd=s5469698;CharSet=utf8;";
        }
	}
}