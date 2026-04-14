using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Print : MonoBehaviour
{
    public new string name;
    public string description;

    public int[] baeyoul = new int[3];

    // Start is called before the first frame update
    void Start()
    {
        ICanThinkNAme();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Printinfo()
    {
        Debug.Log($"name: {name} / description: {description}");
    }

    int Sum(int a, int b)
    {
        int result = 0;

        result = a + b;
        return result;
    }

    void AllSum()
    {
        int result = 0;
        foreach(int a in baeyoul)
        {
            result += a;
        }
    }
    
    int AllMax()
    {
        int result = 0;
        foreach (int a in baeyoul)
        {
            if(result < a)
            {
                result = a;
            }
        }

        return result;
    }

    void ICanThinkNAme()
    {
        int[] result = new int[baeyoul.Length];

        result = baeyoul;

        for(int i = 0; i < result.Length; i++)
        {
            if(i < result.Length)
            {
                if (result[i] < result[i + 1]) // 다음 값이 지금 값보다 크다면 
                {
                    int a = 0;
                    int b = 0;
                    result[i] = a;
                    result[i + 1] = b;

                    result[i + 1] = result[a];
                    result[i] = result[b]; // 서로 바꿔치기
                }
            }
        }

        for (int i = 0; i < result.Length; i++)
        {
            Debug.Log(result[i]);
        }
    }
}
