using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace ByAR.Views
{   
    public class MainMenuView : MonoBehaviour, IView
    {
        [SerializeField]
        private MainViewController mainMenuViewController;

        [SerializeField]
        private TMP_Text randomText;

        [SerializeField]
        private TMP_InputField nameField;

        public void CloseView()
        {

        }

        public void OpenView(AViewController viewController)
        {
            mainMenuViewController = (MainViewController)viewController;
        }

        public void PressedARSceneSelect() => mainMenuViewController.PressedARSceneSelect();

        public void PressedNonARSceneSelect() => mainMenuViewController.PressedNonARSceneSelect();

        public void GetUserName() => mainMenuViewController.GetUserName(nameField.text);

        public void UpdateRandomText(string text) => randomText.text = text;
    }
}