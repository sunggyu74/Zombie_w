﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour, IItem
{
    public float health = 50; // 체력을 회복할 수치
    
    public void Use(GameObject target)
    {
        // 전달받은 게임 오브젝트로부터 LIvingEntity 컴포넌트 가져오기 시도
        LivingEntity life = target.GetComponent<LivingEntity>();

        // LivingEntiy 컴포넌트가 있다면
        if (life != null){
            // 체력 회복 실행
            life.RestoreHealth(health);

        }

        // 사용되었으므로 자신을 파괴
        Destroy(gameObject);

    }

}
