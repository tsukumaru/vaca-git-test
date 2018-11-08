using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottomWallController : MonoBehaviour {

    public GameObject GameOverText;

    private void Awake()
    {
         GameOverText.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ボールを消す
        Destroy(collision.gameObject);
        // ゲームオーバー
        GameOverText.SetActive(true);
        // テキスト表示後数秒待って、スタートに戻る
        StartCoroutine(Timer());
    }

    // タイマー
    private IEnumerator Timer()
    {
        // 5秒
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Start");
    }


}
