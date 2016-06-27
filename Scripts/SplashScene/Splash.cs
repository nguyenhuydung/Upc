using System.Collections;
using Assets.Scripts.Tools;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.SplashScene {
    public class Splash : MonoBehaviour {
        public float Duration = 5.0f;
        public string NextScene = "1.0.Logon";

        private Fader _compFader;
        private void Start() {
            _compFader = GameObject.Find("FadeImage").GetComponent<Fader>();
            _compFader.StartFadeIn(() => {
                StartCoroutine(Wait());
            });
        }

        private IEnumerator Wait() {
            yield return new WaitForSeconds(Duration);
            _compFader.StartFadeOut(() => {
                SceneManager.LoadScene(NextScene);
            });
        }
       
    }
}