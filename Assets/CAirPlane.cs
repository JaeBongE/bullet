using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
이 예시코드는
탄환궤적 알고리즘테스트 코드이다.

탄환에는 
    1.일반탄환:제작 중 탄환의 방향이 이미 결정되어 있는 탄환
    2.조준탄환:실행 중에 발사 시점에 방향을 조전하여 결정하는 탄환
    3.원형탄환:원형 형태의 방향으로 발사되는 탄환
이있다.

이 세가지를 작성할 줄 알면
다른모든 탄환도 작성 가능하다.
 
 */






public class CAirPlane : MonoBehaviour
{
    [SerializeField] Cbullet PFBullet = null;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            DoFire();
        }
    }

    //탄환 발사 루틴
    //  1. 발사 시작지점 설정
    //  2. 탄환의 속도 설정
    //  3. 탄환 활성화

    //일반탄환 발사
    private void DoFire()
    {
        Vector3 tPositionFire = Vector3.zero;
        tPositionFire = this.transform.position;

        Vector3 tVelocity = Vector3.zero;
        tVelocity = Vector3.up * 30f;//벡터의 스칼라 곱셈
        //속도가 제작중에 미리 지정된 탄환
                                     
        Cbullet tBullet = Instantiate<Cbullet>(PFBullet,tPositionFire,Quaternion.identity);
        tBullet.GetComponent<Rigidbody>().AddForce(tVelocity, ForceMode.Impulse);

        //수를 다루는 관점에서 보면, 물리가 수학이란 다른점? 수치에 단위가 붙는다.
        //물리에서 다루는 단위들의 표준은 다음과 같다.
        // 1m, 1kg, 1sec

        //ForceMode.Force <-- 시간 단위가 1초이다. 물리를 그대로 따른다.
        //ForceMode.Impulse <-- 시간 단위가 1프레임이다. 한 프레임에 주어진 힘을 모두 가한다.

    }
}
