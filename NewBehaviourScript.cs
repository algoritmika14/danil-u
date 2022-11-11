using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Здоровье
    public int healt = 5;
    // уровень
    public int level = 1;
    // скорость
    public float speed = 1.2f;
    

    // Start is called before the first frame update
    void Start()
    {
        Vector3 newPosition = transform.position;
        healt += level;
        print(" healt =  " + healt);
        print(newPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
