using UnityEngine;
using UnityEngine.UI;

namespace Parallax{
    public class ObjectParallax : MonoBehaviour{
        public float speed;

        [SerializeField] private Color _color;
        [SerializeField] private int _layer;

        private void Awake()
        {
            SpriteRenderer[] childrenSprites = GetComponentsInChildren<SpriteRenderer>();
            foreach (var sprite in childrenSprites) {
                sprite.color = _color;
                sprite.sortingOrder = _layer;
            }
        }
    }
}