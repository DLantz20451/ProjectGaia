using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    //let camera follow target
    public class CameraFollow : MonoBehaviour
    {
        public Transform target;
        public float lerpSpeed = 1.0f;

        private Vector3 offset;

        private Vector3 targetPos;

        private void Start()
        {
            if (target == null) return;

            offset = transform.position - target.position;
        }

        private void Update()
        {
            if (target == null) return;

            //controlls how th ecamera moves with the player, for example lerp is the slight delay of movement when the player moves
            targetPos = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPos, lerpSpeed * Time.deltaTime);
        }

    }
}
