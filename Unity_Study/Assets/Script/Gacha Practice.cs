using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaPractice : MonoBehaviour
{
    List<string> pokemons = new List<string>
    {
        "��ī��",
        "���α�",
        "���̸�",
        "�̻��ؾ�",
        "ĳ����",
        "����",
        "�Ḹ��",
        "��"
    };

    void Start()
    {
        
    }

    public void RunGacha(int count)
    {
        List<string> result = PerformGacha(count);

        Debug.Log($" {count}�� ��í ��� ");
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
