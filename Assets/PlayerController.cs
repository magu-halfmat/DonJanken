using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�ŏ�����
    //�܂��E�ɑ���o���A�G�ɂ���������W�����P��������
    //�������瑊�肪�����Ď����͉E�ɑ���
    //���̂Ƃ���܂ōs�����珟��


    float speed = 0.03f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�E�ɓ���
        this.transform.Translate(speed, 0, 0);
    }
}
