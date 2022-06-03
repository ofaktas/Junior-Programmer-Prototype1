using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityLearn
{
    public class PlayerControler : MonoBehaviour
    {
        [SerializeField] private float speed;
         
        void Start()
        {

        }


        void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.forward* Time.deltaTime * -speed);
            }
            
        }
    }

}