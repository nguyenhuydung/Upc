using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour {

	// Use this for initialization
    public void Quitgame() {
        Application.Quit();
    }

    public void ScenePlayTlmn() {
        SceneManager.LoadScene("3.0.PlayTlmn");
    }

    public void SceneGamesSelect()
    {
        SceneManager.LoadScene("2.GameSelect");
    }
}
