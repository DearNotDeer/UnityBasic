using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaPractice : MonoBehaviour
{
    List<string> pokemons = new List<string>
    {
        "피카츄",
        "꼬부기",
        "파이리",
        "이상해씨",
        "캐터피",
        "구구",
        "잠만보",
        "뮤"
    };

    void Start()
    {
        
    }

    public void RunGacha(int count)
    {
        List<string> result = PerformGacha(count);

        Debug.Log($" {count}연 가챠 결과 ");
        foreach (string p in result)
        {
            Debug.Log(p);
        }
    }

    
    List<string> PerformGacha(int count)
    {
        List<string> result = new List<string>();

        for (int i = 0; i < count; i++)
        {
            int randomIndex = Random.Range(0, pokemons.Count);
            result.Add(pokemons[randomIndex]);
        }

        return result;
    }

    
    void Update()
    {
        
    }
}
