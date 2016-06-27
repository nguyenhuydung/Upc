using UnityEngine;

namespace Assets.Scripts {
    public class CardModel : MonoBehaviour {
        public Sprite[] CardFaces;

        //Animation
        public bool CardUp;
        public Vector3 CardMove;
        public float CardX;
        public float CardY;
        public float CardRotation;

        private Animation ani;

        // Use this for initialization
        void Start () {
            var abc = GetComponent<SpriteRenderer>();
            abc.sprite = CardFaces[3];
        }
	
        // Update is called once per frame
        void Update () {
	
        }
    }
}
