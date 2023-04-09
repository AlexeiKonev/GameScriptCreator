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

        private void btnCreateDialogue_Click(object sender, EventArgs e) {
            // �������� ������ �������
            string dialogueText = txtDialogueText.Text;
            dialogues.Add(dialogueText);
            lstDialogues.Items.Add(dialogueText);
            txtDialogueText.Clear();
        }
        private void lstScenes_SelectedIndexChanged(object sender, EventArgs e) {
            // ����� ������� �����
            if (lstScenes.SelectedIndex >= 0) {
                currentScene = scenes[lstScenes.SelectedIndex];
            }
        }
        private void lstDialogues_SelectedIndexChanged(object sender, EventArgs e) {
            // ����� �������� �������
            if (lstDialogues.SelectedIndex >= 0) {
                currentDialogue = dialogues[lstDialogues.SelectedIndex];
            }
        }

        private void btnAddDialogueToScene_Click_Click(object sender, EventArgs e) {
            // ���������� ������� � ������� �����
            if (!string.IsNullOrEmpty(currentScene) && !string.IsNullOrEmpty(currentDialogue)) {
                string scriptLine = $"ShowDialogue('{currentScene}', '{currentDialogue}');";
                txtScript.AppendText(scriptLine + Environment.NewLine);
            }
        }
    }
}