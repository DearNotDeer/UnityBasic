using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void OnEnable()
    {
        
        Debug.Log(Random.Range(1,100));
        // 1 이상 100 미만의 랜덤하 값을 만들겠다.
    }
}
