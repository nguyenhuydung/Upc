using Assets.Scripts.Tools;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Logon {
    public class RegisterAccount : MonoBehaviour {
        public void OnButtonBack() {
            var compFader = GameObject.Find("FadeImage").GetComponent<Fader>();
            compFader.StartFadeOut(() => {
                SceneManager.LoadScene("1.0.Logon");
            });
        }
    }
}
