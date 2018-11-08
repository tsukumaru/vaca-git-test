using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
    }

    // イベントを見つけられるように必ずpublicにする
    public void OnClick()
    {
        // ゲームシーンへ遷移
        SceneManager.LoadScene("Game");
    }
}