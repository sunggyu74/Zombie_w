﻿using UnityEngine;

// 플레이어 캐릭터를 조작하기 위한 사용자 입력을 감지
// 감지된 입력값을 다른 컴포넌트가 사용할 수 있도록 제공
public class PlayerInput : MonoBehaviour
{
    // 앞뒤 움직임을 위한 입력축 이름
    public string moveAxisName = "Vertical";
    // 좌우 회전을 위한 입력축 이름
    public string rotateAxisName = "Horizontal";
    // 발사를 위한 입력 버튼 이름, inputmanager - mouse leftbutton
    public string fireButtonName = "Fire1";
    // 재장전을 위한 입력 버튼 이름
    public string reloadButtonName = "Reload";

    // 프로퍼티 : 값 할당은 내부에서만 가능
    public float move { get; private set; } // 감지된 움직임 입력값
    public float rotate { get; private set; } // 감지된 회전 입력값
    public bool fire { get; private set; } // 감지된 발사 입력값
    public bool reload { get; private set; } // 감지된 재장전 입력값

    void Update() // 매프레임 사용자 입력을 감지
    {
        // 게임오버 상태에서는 사용자 입력을 감지하지 않음
        if(GameManager.instance != null && GameManager.instance.isGameover)
        {
            move = 0;
            rotate = 0;
            fire = false;
            reload = false;
            return;
        }

        // move에 관한 입력 감지
        move = Input.GetAxis(moveAxisName);
        // rotate에 관한 입력 감지
        rotate = Input.GetAxis(rotateAxisName);
        // fire에 관한 입력 감지
        fire = Input.GetButton(fireButtonName);
        // reload에 관한 입력 감지, inputmanager 생성
        reload = Input.GetButtonDown(reloadButtonName);
    }
}
