using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaController : MonoBehaviour
{
    string charaName;
    float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        charaName = this.gameObject.name;

        if (charaName == "Player")
        {
            speed = 0.03f;
        }

        else if (charaName == "Enemy")
        {
            speed = -0.03f;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        this.transform.Translate(speed * -50, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {

        //‰E‚É“®‚­
        this.transform.Translate(speed, 0, 0);
    }
}
