namespace GameScriptCreator {
    public partial class Form1 : Form {
        private List<string> scenes = new List<string>(); // ������ ����
        private List<string> dialogues = new List<string>(); // ������ ��������
        private string currentScene = ""; // ������� �����
        private string currentDialogue = ""; // ������� ������
        public Form1() {
            InitializeComponent();
        }

        private void btnCreateScene_Click(object sender, EventArgs e) {
            // �������� ����� �����
            string sceneName = txtSceneName.Text;
            scenes.Add(sceneName);
            lstScenes.Items.Add(sceneName);
            txtSceneName.Clear();
        }
    }
}