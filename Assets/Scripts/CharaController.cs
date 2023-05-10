using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaController : MonoBehaviour
{
    string charaName;
    public float speed;
    bool isTouch = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Transform charaPos = this.transform;
        Vector3 pos = charaPos.position;
        
        for (int i = 0; i < 50; i++)
        {
            pos.x += speed * -1;
            charaPos.position = pos;
        }
       
        isTouch = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (isTouch == false)
        {
            this.transform.Translate(speed, 0, 0);
        }
        
    }


}
