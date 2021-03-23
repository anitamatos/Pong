using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5f;

    [SerializeField]
    KeyCode upKey = KeyCode.UpArrow;

    [SerializeField]
    KeyCode downKey = KeyCode.DownArrow; 


    // Update is called once per frame
    void Update()

    {
        if (Input.GetKey(upKey))
        {
            // transform.position =
            //  transform.position + velocidade * Vector3.up;

            transform.position += Vector3.up * Time.deltaTime;
        }
        else if (Input.GetKey(downKey))
        {
            //transform.position =
            //transform.position + velocidade * Vector3.down; 

            transform.position += Vector3.down * Time.deltaTime;
        }

        float cameraHeight = Camera.main.orthographicSize;
        float halfPaddleSize = 0.5f;
        if (transform.position.y >= cameraHeight - halfPaddleSize)
        {
            //Na pratica o codigo abaixo faz: transform.position >= 3f - o.5f
            Vector3 positionAux = transform.position;
            positionAux.y = cameraHeight - halfPaddleSize;
            transform.position = positionAux;
        }

        if (transform.position.y <= -cameraHeight + halfPaddleSize)
        {
         
            Vector3 positionAux = transform.position;
            positionAux.y = -cameraHeight + halfPaddleSize;
            transform.position = positionAux;
        }

    }


}



