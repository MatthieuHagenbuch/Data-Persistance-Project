using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button startBtn;

    // Start is called before the first frame update
    void Start()
    {
        startBtn.onClick.AddListener(OnBtnClick);
    }

    private void OnBtnClick()
    {
        if(inputField != null)
        {
            SceneManager.LoadScene("main");
        }
    }

}
