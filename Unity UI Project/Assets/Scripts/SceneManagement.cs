using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    [SerializeField] GameObject popupPanel;

    private void Start()
    {
        if (popupPanel == null) return;

        popupPanel.SetActive(false);
    }

    public void OpenGameScene() => SceneManager.LoadScene("GameScene");

    public void ShowPopup()
    {
        if (popupPanel == null) return;

        popupPanel.SetActive(true);
    }

    public void HidePopup()
    {
        if (popupPanel == null) return;

        popupPanel.SetActive(false);
    }
}
