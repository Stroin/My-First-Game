using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Witaj w Szybka Bila!");
        Debug.Log("Poruszasz się za pomocą WSAD albo strzałek");
        Debug.Log("Nie uderzaj w ściany!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal")* Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;
        
        transform.Translate(xValue,0,zValue);
    }

}
