using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void LoadCardListScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("CardListScene");
    }

    public void LoadMainMenuScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    public void LoadGameScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
}
