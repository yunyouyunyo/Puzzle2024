using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;

    private void Awake()
    {
        // Singleton 模式，確保只有一個 UIManager 實例存在
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // 在場景切換時不銷毀
        }
        else
        {
            Destroy(gameObject); // 如果已經存在實例，銷毀新的實例
        }
    }

    // 在這裡添加其他 UI 相關的方法和屬性
}
