using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_BuleCandy : MonoBehaviour, ITarget
{
    [SerializeField] private GameObject bulecandy; 

    [Space]
    [SerializeField] private string[] needItemNames; // 필요한 아이템들

    [SerializeField]
    private bool[] isItemUsed;

    private void Start()
    {
        isItemUsed = new bool[needItemNames.Length];

        for (int i = 0; i < needItemNames.Length; i++)
        {
            isItemUsed[i] = false;
        }
            bulecandy.SetActive(false);
    }

    private void Update()
    {
        bool isItemAllUsed = false;

        for (int i = 0; i < needItemNames.Length; i++)
        {
            if (isItemUsed[i] == false)
            {
                return;
            }

            isItemAllUsed = true;
        }

        if (isItemAllUsed)
        {
            if (bulecandy != null)
            {
                bulecandy.SetActive(true);
            }

        }
    }

    public void UseItemAction(string itemName)
    {
        for (int i = 0; i < needItemNames.Length; i++)
        {
            Debug.Log(itemName);
            Debug.Log(needItemNames[i]);
            if (itemName == needItemNames[i])
            {
                isItemUsed[i] = true;
            }
        }
    }
}