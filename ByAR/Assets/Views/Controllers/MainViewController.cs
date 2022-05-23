using UnityEngine;

namespace ByAR.Views
{
    public class MainViewController : AViewController
    {
        [SerializeField]
        private GameObject mainMenuViewPrefab;

        [SerializeField]
        private int minWords, maxWords, minSentences, maxSentences, numParagraphs;

        private GameObject mainMenuViewContainer;

        private MainMenuView mainMenuView;

        private RandomTextGenerator gen;

        void Awake() => gen = new RandomTextGenerator();
    
        public override void InitView()
        {

        }
        public override void OpenView()
        {


        }

        public void PressedARSceneSelect() => LoadARScene();

        public void PressedNonARSceneSelect() => LoadNonARScene();
      
        public void GetUserName(string name) => PlayerPrefs.SetString("USERNAME", name);

        public void UpdateRandomText() => mainMenuView.UpdateRandomText(GenerateRandomText(gen));

        private string GenerateRandomText(RandomTextGenerator generator) => generator.LoremIpsum(minWords, maxWords, minSentences, maxSentences,
        numParagraphs);

        private void LoadARScene()
        {
            PlayerPrefs.Save();
        }

        private void LoadNonARScene()
        {
            PlayerPrefs.Save();
        }
    }
}