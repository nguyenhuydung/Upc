using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour {

    public float height = 9f;

    public float width = 16f;

    

    private void Awake() {
        Camera.main.aspect = width/height;
        //r panel = GetComponent<GU>()
    }
}