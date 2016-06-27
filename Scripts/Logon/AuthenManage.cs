using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Tools;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Logon {
    public class AuthenManage : MonoBehaviour {
        public InputField Password;
        public InputField UserName;

        // Use this for initialization
        private void Start() {
        }

        // Update is called once per frame
        private void Update() {
        }

        private IEnumerator WaitForRequest(WWW www) {
            yield return www;
            if (www.error == null) {
                Debug.Log("WWW Ok!: " + www.text);
            }
            else {
                Debug.Log("WWW Error: " + www.error);
            }

            SceneManager.LoadScene("1.1.Logoned");
        }

        //Button login click:
        public void ButtonLogin() {
            var form = new WWWForm();
            form.AddField("grant_type", "password");
            form.AddField("username", UserName.text);
            form.AddField("password", Password.text);
            var headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/x-www-form-urlencoded");
            var www = new WWW("http://www.thgame.vn/token", form.data, headers);
            StartCoroutine(WaitForRequest(www));
        }

        public void ButtonClose() {
            var compFader = GameObject.Find("FadeImage").GetComponent<Fader>();
            compFader.StartFadeOut(Application.Quit);
            
        }


    }
}