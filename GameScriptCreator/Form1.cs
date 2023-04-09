namespace GameScriptCreator {
    public partial class Form1 : Form {
        private List<string> scenes = new List<string>(); // список сцен
        private List<string> dialogues = new List<string>(); // список диалогов
        private string currentScene = ""; // текущая сцена
        private string currentDialogue = ""; // текущий диалог
        public Form1() {
            InitializeComponent();
        }

        private void btnCreateScene_Click(object sender, EventArgs e) {
            // Создание новой сцены
            string sceneName = txtSceneName.Text;
            scenes.Add(sceneName);
            lstScenes.Items.Add(sceneName);
            txtSceneName.Clear();
        }

        private void btnCreateDialogue_Click(object sender, EventArgs e) {
            // Создание нового диалога
            string dialogueText = txtDialogueText.Text;
            dialogues.Add(dialogueText);
            lstDialogues.Items.Add(dialogueText);
            txtDialogueText.Clear();
        }
        private void lstScenes_SelectedIndexChanged(object sender, EventArgs e) {
            // Выбор текущей сцены
            if (lstScenes.SelectedIndex >= 0) {
                currentScene = scenes[lstScenes.SelectedIndex];
            }
        }
        private void lstDialogues_SelectedIndexChanged(object sender, EventArgs e) {
            // Выбор текущего диалога
            if (lstDialogues.SelectedIndex >= 0) {
                currentDialogue = dialogues[lstDialogues.SelectedIndex];
            }
        }

        private void btnAddDialogueToScene_Click_Click(object sender, EventArgs e) {
            // Добавление диалога в текущую сцену
            if (!string.IsNullOrEmpty(currentScene) && !string.IsNullOrEmpty(currentDialogue)) {
                string scriptLine = $"ShowDialogue('{currentScene}', '{currentDialogue}');";
                txtScript.AppendText(scriptLine + Environment.NewLine);
            }
        }
    }
}