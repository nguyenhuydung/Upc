using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Tools {
    public class Fader : MonoBehaviour {
        private bool _fadeInOnAction = false;
        private bool _fadeOutOnAction = false;

        public float FadeSpeed = 1f;    // Speed that the screen fades to and from black.
        private Image _guiImage;          //Image black to overlay

        private void Awake() {
            _guiImage = GetComponent<Image>();
            _guiImage.rectTransform.localScale = new Vector2(Screen.width, Screen.height);
            _guiImage.enabled = false;
        }

        private void Update() {
            if (_fadeInOnAction) {
                FadeToClear();
            }

            if (_fadeOutOnAction) {
                FadeToBlack();
            }
        }

        private void FadeToClear() {
            Debug.Log("Fadeing to clear");
            _guiImage.enabled = true;
            _guiImage.color = Color.Lerp(_guiImage.color, Color.clear, FadeSpeed*Time.deltaTime);
            if (_guiImage.color.a >= 0.05f) return;
            _guiImage.color = Color.clear;
            _guiImage.enabled = false;
            _fadeInOnAction = false;
            _onComplete();
        }

        private void FadeToBlack() {
            Debug.Log("Fading to black");
            _guiImage.enabled = true;
            _guiImage.color = Color.Lerp(_guiImage.color, Color.black, FadeSpeed*Time.deltaTime);
            if (_guiImage.color.a < 0.95f) return;
            _fadeOutOnAction = false;
            _onComplete();
        }

        private Action _onComplete; 
        public void StartFadeIn(Action onCompleteFadeIn) {
            _guiImage.color = Color.black;
            _fadeInOnAction = true; // for update action:
            _onComplete = onCompleteFadeIn;
        }

        public void StartFadeOut(Action onCompleteFadeOut) {
            _guiImage.color = Color.clear;
            _fadeOutOnAction = true; // for update action
            _onComplete = onCompleteFadeOut;
        }
    }
}