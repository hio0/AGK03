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
        int[] result = baeyoul;

        for(int i = 0; i < result.Length; i++)
        {
            if(i < result.Length - 1) // 마지막 제외
            {
                if (result[i] > result[i + 1]) // 다음 값이 지금 값보다 작다면
                {
                    int a = result[i];
                    int b = result[i + 1];

                    result[i + 1] = a;
                    result[i] = b; // 서로 바꿔치기
                }
            }
            else if(i == result.Length - 1) // 비교할 것이 없는 마지막 순번일 경우
            {
                for(int j = result.Length - 1; j > 0;j--)
                {
                    if (result[j] < result[j - 1]) // 이전 값들을 계속 비교해서 이전 값보다 작다
                    {
                        int a = result[j];
                        int b = result[j - 1];

                        result[j - 1] = a;
                        result[j] = b; // 서로 바꿔치기
                    }
                }
            }

            /* 논리 구조는 맞았는데 이렇게 쓰는 구조가 더 빨랐다... 코드 최적화에 노력을
            for(int i = 0; i < result.Length; i++)
            {
                for(int j = i+1;j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        int temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            */
        }

        for (int k = 0; k < result.Length; k++)
        {
            Debug.Log(result[k]);
        }
    }
}
