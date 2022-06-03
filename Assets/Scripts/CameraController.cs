using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityLearn
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] public GameObject Player;
        [SerializeField] public Vector3 vector;
        void Start()
        {

        }


        void LateUpdate()
        {
            transform.position = Player.transform.position + vector;
        }
    }
}