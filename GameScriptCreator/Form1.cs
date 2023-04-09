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
    }
}