using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private TMP_InputField playerName;

    public void StartGame()
    {
        playerName = transform.Find("Insert Name").GetComponent<TMP_InputField>();
        SceneDataSaver.Instance.playerName = playerName.text;
        SceneManager.LoadScene(1);
    }

}
