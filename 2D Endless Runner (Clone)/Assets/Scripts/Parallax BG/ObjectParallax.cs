using UnityEngine;

namespace Parallax{
    public class ObjectParallax : MonoBehaviour{
        public float speed;

        [SerializeField] private Color _color;
        [SerializeField] private int _layer;

        private void Start(){
            SpriteRenderer[] childrenSprites = GetComponentsInChildren<SpriteRenderer>();
            foreach (var sprite in childrenSprites) {
                sprite.color = _color;
                sprite.sortingOrder = _layer;
            }
        }
    }
}