using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPractice : MonoBehaviour
{
    string star;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }
    
    public void Phase1()
    {
    string star = "";

    for (int i = 1; i <= 5; i++)
    {
        for (int j = 0; j < i; j++)
        {
            star += "★";
        }
        star += "\n";
    }

    Debug.Log(star);
}

    public void Phase2()
    {
    string star = "";

    for (int i = 5; i >= 1; i--)
    {
        for (int j = 0; j < i; j++)
        {
            star += "★";
        }
        star += "\n";
    }

    Debug.Log(star);
}

    public void Phase3()
    {
    string star = "";

    // 위
    for (int i = 1; i <= 5; i++)
    {
        for (int j = 0; j < i; j++)
            star += "★";
        star += "\n";
    }

    // 아래
    for (int i = 4; i >= 1; i--)
    {
        for (int j = 0; j < i; j++)
            star += "★";
        star += "\n";
    }

    Debug.Log(star);
}

    public void Phase4()
    {
    string star = "";
    int max = 5;

    // 위쪽
    for (int i = 1; i <= max; i++)
    {
        for (int j = 0; j < max - i; j++)
            star += "　";  // 전각 공백

        for (int j = 0; j < i; j++)
            star += "★";

        star += "\n";
    }

    // 아래쪽
    for (int i = max - 1; i >= 1; i--)
    {
        for (int j = 0; j < max - i; j++)
            star += "　";  // 전각 공백

        for (int j = 0; j < i; j++)
            star += "★";

        star += "\n";
    }

    Debug.Log(star);
}

    public void Phase5()
    {
    string star = "";
    for (int i = 0; i < 9; i++)
    {
        int s = (i <= 4) ? i : 8 - i;
        int count = 1 + s * 2;
        int space = (9 - count) / 2;

        star += new string('　', space);
        star += new string('★', count);
        if (i != 8) star += "\n";
    }
    Debug.Log(star);
}
    
    void Update()
    {
        
    }
}
