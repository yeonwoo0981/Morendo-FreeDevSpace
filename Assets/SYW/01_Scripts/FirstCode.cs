using System;
using UnityEngine;
using DG.Tweening;

namespace SYW._01_Scripts
{
    public class FirstCode : MonoBehaviour
    {
        private void Start()
        {
            gameObject.transform.DOScale(new Vector3(2.5f, 1.2f), 1.2f)
                .SetLoops(10, LoopType.Yoyo);
        }
    }
}
