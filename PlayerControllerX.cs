using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float intervalTime = 2f;
    float myTimer;

    void Start()
    {
        // Игрок спамит первую собаку в любое время
        myTimer = intervalTime;
    }

    
    void Update()
    {
        
        myTimer += 1 * Time.deltaTime;
       
        // Спам собаки если таймер больше названного и нажата кнопка пробел
        if (Input.GetKeyDown(KeyCode.Space) && myTimer > intervalTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            // Сброс таймера
            myTimer = 0f;
        }


        Debug.Log(myTimer);
    }


}
