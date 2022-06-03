using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityLearn
{
    public class PlayerControler : MonoBehaviour
    {
        //private variables
        [SerializeField] private float speed;
        [SerializeField] private float turnSpeed;
        [SerializeField] private float HorizantalInput;
        [SerializeField] private float ForwardInput;

        void Start()
        {

        }


        void Update()
        {
            //The player input
            HorizantalInput = Input.GetAxis("Horizontal");
            ForwardInput = Input.GetAxis("Vertical");

            transform.Translate(Vector3.forward * Time.deltaTime * speed* ForwardInput);
            transform.Rotate(Vector3.up * turnSpeed * HorizantalInput * Time.deltaTime);

            /* if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.forward* Time.deltaTime * -speed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.up * Time.deltaTime * turnSpeed);
            }
            if(Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.up * Time.deltaTime * -turnSpeed);
            }
            */

        }
    }

}