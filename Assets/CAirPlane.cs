using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
�� �����ڵ��
źȯ���� �˰����׽�Ʈ �ڵ��̴�.

źȯ���� 
    1.�Ϲ�źȯ:���� �� źȯ�� ������ �̹� �����Ǿ� �ִ� źȯ
    2.����źȯ:���� �߿� �߻� ������ ������ �����Ͽ� �����ϴ� źȯ
    3.����źȯ:���� ������ �������� �߻�Ǵ� źȯ
���ִ�.

�� �������� �ۼ��� �� �˸�
�ٸ���� źȯ�� �ۼ� �����ϴ�.
 
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

    //źȯ �߻� ��ƾ
    //  1. �߻� �������� ����
    //  2. źȯ�� �ӵ� ����
    //  3. źȯ Ȱ��ȭ

    //�Ϲ�źȯ �߻�
    private void DoFire()
    {
        Vector3 tPositionFire = Vector3.zero;
        tPositionFire = this.transform.position;

        Vector3 tVelocity = Vector3.zero;
        tVelocity = Vector3.up * 30f;//������ ��Į�� ����
        //�ӵ��� �����߿� �̸� ������ źȯ
                                     
        Cbullet tBullet = Instantiate<Cbullet>(PFBullet,tPositionFire,Quaternion.identity);
        tBullet.GetComponent<Rigidbody>().AddForce(tVelocity, ForceMode.Impulse);

        //���� �ٷ�� �������� ����, ������ �����̶� �ٸ���? ��ġ�� ������ �ٴ´�.
        //�������� �ٷ�� �������� ǥ���� ������ ����.
        // 1m, 1kg, 1sec

        //ForceMode.Force <-- �ð� ������ 1���̴�. ������ �״�� ������.
        //ForceMode.Impulse <-- �ð� ������ 1�������̴�. �� �����ӿ� �־��� ���� ��� ���Ѵ�.

    }
}
