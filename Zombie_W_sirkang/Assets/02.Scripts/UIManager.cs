//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 씬 관리자 관련 코드
using UnityEngine.UI; // UI 관련 코드

// 필요한 UI에 즉시 접근하고 변경할 수 있도록 허용하는 UI 매니저

public class UIManager : MonoBehaviour
{


    public static UIManager instance{
        get
        {
            if (m_instance == null){
                m_instance = FindObjectOfType<UIManager>();

            }

            return m_instance;

        }

    }

    private static UIManager m_instance; // 싱글턴이 할당될 변수

    public Text ammoText; // 탄알 표시용 텍스트
    public Text scoreText; // 점수 표시용 텍스트
    public Text waveText; // 적 웨이브 표시용 텍스트
    public GameObject gameoverUI; // 게임오버 시 활성화할 UI

    // 탄알 텍스트 갱신
    public void UpdateAmmoText(int magAmmo, int ammoRemain){
        ammoText.text = magAmmo + "/" + ammoRemain;

    }

    // 점수 텍스트 갱신
    public void updateScoreText(int newScore){
        scoreText.text = "Score :" + newScore;

    }

    // 적 웨이브 텍스트 갱신
    public void updateWaveText(int waves, int count){
        waveText.text = "Wave :" + waves + "/n Enemy Left :" + count;

    }

    // 게임오버 UI 활성화
    public void SetActiveGameoverUI (bool active){
        gameoverUI.SetActive(active);

    }

    // 게임 재시작
    public void GameRestart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
