using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss
{
    private int hp = 100;         //�̗�
    private int power = 25;       //�U����
    private int mp = 53;          //���@��

    //�U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    //�h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        //�c��hp�����炷
        this.hp -= damage;
    
    }

    //���@�p�̊֐�

    public void Magic(int mpuse)
    {
        
        if (this.mp >= mpuse)
        {
            //�c��mp�����炷
            this.mp -= mpuse;
            Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B");
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
        
    }





}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        // �z�������������
        int[] array = { 10, 20, 30, 40, 50 };

        // �z��̗v�f���̂Ԃ񂾂��������J��Ԃ�
        for (int i = 0; i < array.Length; i++)
        {
            // �z��̗v�f�����Ԃɕ\������
            Debug.Log(array[i]);
        }

        // �z��̗v�f���̂Ԃ񂾂��������J��Ԃ�
        for (int i = array.Length - 1; i >= 0; i--)
        {
            // �z��̗v�f���t���ɕ\������
            Debug.Log(array[i]);
        }

        //���W�ۑ�
        Boss Xboss = new Boss();
        Xboss.Magic(5);
        Xboss.Magic(5);
        Xboss.Magic(5);
        Xboss.Magic(5);
        Xboss.Magic(5);
        Xboss.Magic(5);
        Xboss.Magic(5);
        Xboss.Magic(5);
        Xboss.Magic(5);
        Xboss.Magic(5);
        Xboss.Magic(5);



    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
