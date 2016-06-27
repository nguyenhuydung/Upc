using UnityEngine;

namespace Assets.Scripts.Tools {
    public class FadeScene : MonoBehaviour {
        public Texture2D BlackTexture;
        public float FadeSpeed = 0.8f;

        private int _depth = -1000;
        private float _alpha = 1.0f;
        private int _direction = -1;

        void OnGUI() {
            _alpha += _direction*FadeSpeed*Time.deltaTime;
            _alpha = Mathf.Clamp01(_alpha);
            Debug.Log("alpha = " + _alpha);

            GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, _alpha);
            GUI.depth = _depth;
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), BlackTexture);
        }

        public void BeginFade() {
            
        }
    }
}
