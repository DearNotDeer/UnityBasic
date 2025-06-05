using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myself : MonoBehaviour
{
    private string myname = "�̼���";
    private int age = 33;
    private float height =169.2f;
    private float weight =115.3f;
    private string personalityType = "ENFP";
    private string hobbies = "����";
    private string favoriteColor = "�Ķ���";
    private bool isIntrovert = false;
    private string nationality = "���ѹα�";
    private string dream = "���ӱ�ȹ��";

    void Start()
    {
        SelfIntroduction();
        SelfIntroduction(myname, age, height, weight, personalityType, hobbies, favoriteColor, isIntrovert, nationality, dream);
    }
    public void SelfIntroduction()
    {
        Debug.Log("���� �̸��� " + myname + "�Դϴ�.");
        Debug.Log("���� ���̴� " + age + "�� �Դϴ�.");
        Debug.Log("���� Ű�� " + height + "�Դϴ�.");
        Debug.Log("���� �����Դ� " + weight + "�Դϴ�.");
        Debug.Log("���� MBTI�� " + personalityType + "�Դϴ�.");
        Debug.Log("���� ��̴� " + hobbies + "�Դϴ�.");
        Debug.Log("���� �����ϴ»��� " + favoriteColor + "�Դϴ�.");
        Debug.Log("������ " + (isIntrovert ? "�������Դϴ�" : "�������Դϴ�"));
        Debug.Log("���� ������ " + nationality + "�Դϴ�.");
        Debug.Log("���� ���� " + dream + "�Դϴ�.");
    }
    public void SelfIntroduction(string _name, int _age, float _height, float _weight,
        string _personalityType, string _hobbies, string _favoriteColor, bool _isIntrovert,
        string _nationality, string _dream)
        {
        Debug.Log($"�̸�: {_name}, ����: {_age}, Ű: {_height}, ������: {_weight}");
        Debug.Log($"����: {_personalityType}, ���: {_hobbies}, ����: {_favoriteColor}");
        Debug.Log($"������?: {_isIntrovert}, ����: {_nationality}, ��: {_dream}");
    }

}
