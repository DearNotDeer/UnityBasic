using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myself : MonoBehaviour
{
    private string myname = "이성훈";
    private int age = 33;
    private float height =169.2f;
    private float weight =115.3f;
    private string personalityType = "ENFP";
    private string hobbies = "게임";
    private string favoriteColor = "파란색";
    private bool isIntrovert = false;
    private string nationality = "대한민국";
    private string dream = "게임기획자";

    void Start()
    {
        SelfIntroduction();
        SelfIntroduction(myname, age, height, weight, personalityType, hobbies, favoriteColor, isIntrovert, nationality, dream);
    }
    public void SelfIntroduction()
    {
        Debug.Log("저의 이름은 " + myname + "입니다.");
        Debug.Log("저의 나이는 " + age + "세 입니다.");
        Debug.Log("저의 키는 " + height + "입니다.");
        Debug.Log("저의 몸무게는 " + weight + "입니다.");
        Debug.Log("저의 MBTI는 " + personalityType + "입니다.");
        Debug.Log("저의 취미는 " + hobbies + "입니다.");
        Debug.Log("제가 좋아하는색은 " + favoriteColor + "입니다.");
        Debug.Log("성격은 " + (isIntrovert ? "내향적입니다" : "외향적입니다"));
        Debug.Log("저의 국적은 " + nationality + "입니다.");
        Debug.Log("저의 꿈은 " + dream + "입니다.");
    }
    public void SelfIntroduction(string _name, int _age, float _height, float _weight,
        string _personalityType, string _hobbies, string _favoriteColor, bool _isIntrovert,
        string _nationality, string _dream)
        {
        Debug.Log($"이름: {_name}, 나이: {_age}, 키: {_height}, 몸무게: {_weight}");
        Debug.Log($"성격: {_personalityType}, 취미: {_hobbies}, 색깔: {_favoriteColor}");
        Debug.Log($"내향적?: {_isIntrovert}, 국적: {_nationality}, 꿈: {_dream}");
    }

}
