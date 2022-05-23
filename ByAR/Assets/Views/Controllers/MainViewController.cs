using UnityEngine;

namespace ByAR.Views
{
    public class MainViewController : AViewController
    {
        [SerializeField]
        private GameObject mainMenuViewPrefab;

        private GameObject mainMenuViewContainer;

        private MainMenuView mainMenuView;

        public override void InitView()
        {

        }
        public override void OpenView()
        {


        }

        public void PressedARSceneSelect() => LoadARScene();

        public void PressedNonARSceneSelect() => LoadNonARScene();
      
        public void GetUserName(string name) => PlayerPrefs.SetString("USERNAME", name);

        public void UpdateRandomText() => mainMenuView.UpdateRandomText(GenerateRandomText());

        private string GenerateRandomText()
        {
            return "";
        }

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