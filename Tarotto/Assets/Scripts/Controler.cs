using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controler : MonoBehaviour
{   
    [SerializeField]
    private Text Description;
    [SerializeField]
    private Text Description2;
    [SerializeField]
    private Text CardName;
    [SerializeField]
    private Text Position;

    private List<string> TitleTable = new List<string>();
    private List<string> DescriptionTable = new List<string>();
    private List<string> DescriptionTable2 = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        AddCard("����-the fool-","���׋C\n����\n���R\n�o��","���m\n���v��\n���ӔC\n���r���[");
        AddCard("���p�t-the magician-","�n���I\n�W��\n����\n�Z�p\n�m��\n���z����","�W���͕s��\n�Z�p�s��\n�m���s��\n���ɓI\n");
        AddCard("�����c-the thehighpriestes-", "����\n���@\n�閧\n�m��\n�_��I", "���m\n�\�ʓI�Ȓm��\n�_�o��\n����ׂ���");
        AddCard("����-the empress-", "�L����\n����\n�ɉh\n�{��\n�����I\n���\�I���", "�킪�܂�\n���i\n�ˑ�\n�s��");
        AddCard("�c��-the emperor-", "����\n�ӗ~�I\n�M��\n����\n����\n�͋���", "���ӔC\n�����}��\n���ȓI\n����");
        AddCard("�@��-the hierophant-", "����\n�K��\n����\n�m��\n����\n�Љ", "�����ł�\n���\n�M���ł��Ȃ�");
        AddCard("���l-the lovers-", "����\n��\n��y\n���}���X\n���I�ȉ��y", "�^�O\n���C\n����\n����\n�j�]");
        AddCard("���-the chariot-", "����\n�O�i\n����\n�E�ϗ�\n�ӎu�̋���", "����\n���\n���s\n�s�k");
        AddCard("��-strength-", "��\n�ӎv\n�E�C\n�M�O\n�E��\n����", "���M�r��\n���s\n���a\n�͂𗐗p");
        AddCard("�B��-the hermit-", "����\n�v��\n���ʂւ̒T��\n�閧\n�T�d", "�Ǔ�\n�A��\n�΋�\n�_�o��");
        AddCard("�^���̗�-wheel of fortune-", "�^�[�j���O�|�C���g\n�`�����X����\n�傫�ȕϓ�\n�D�]\n�^��", "�}�~��\n���s\n�D�@�𓦂�\n�s�^");
        AddCard("���`-justice-", "����\n����\n���a\n���`\n������", "�Ό�\n�s����\n�D�_�s�f\n�s����\n�s����");
        AddCard("�݂�ꂽ�j-the hanged man-", "����\n���ȋ]��\n�E��\n������J\n�g���������Ȃ�", "����ʋ]��\n���܂葹\n���E\n���Ԃ���");
        AddCard("���_-death-", "�I���Ǝn�܂�\n�j��Ƒn��\n�]�@\n����_\n�؂�̂Ă�", "���~\n�x���ω�\n�ӑ�\n���C��");
        AddCard("�ߐ�-the temperance-", "�ߐ�\n�o�����X\n����\n���a\n����\n���N", "�s�ύt\n�����{��\n���\n�Q��");
        AddCard("���_-the devil-", "����\n��\n�U�f\n���i\n�������K��", "��������̉��\n�f���؂�");
        AddCard("��-the tower-", "�ˑR�̕ω�\n�\�����ʍГ�\n�j��\n�]��\n����", "�ٔ�\n�����ȕ���\n�ЊQ");
        AddCard("��-the star-", "��]\n���z\n���\n������ʂ�\n�ǂ�����\n�슴", "���]\n����\n�悪�����Ȃ�\n�ߊ�");
        AddCard("��-the moon-", "�s��\n����\n�˘f��\n���h\n�U��\n����", "��\n�s���̏�����������\n��@���");
        AddCard("���z-the sun-", "����\n����\n�m�M\n�h��\n����\n���N\n���Y", "�s�^\n���s\n�Â�\n�É_\n��͂�");
        AddCard("�R��-judgement-", "�R��\n���\n����\n�Đ�\n����\n�~��\n�ǂ��m�点", "���]\n���\n���O\n����\n�ǂ��Ȃ��m�点");
        AddCard("���E-the world-","����\n�B��\n���a\n����\n����","���r���[\n������\n�X�����v");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HitCard()
    {
        int i = Random.Range(0,TitleTable.Count);
        ShowCard(TitleTable[i],DescriptionTable[i],DescriptionTable2[i]);
        i = Random.Range(0, 2);
        Debug.Log(i);
        if (i == 0) Position.text = "���ʒu";
        else Position.text = "�t�ʒu";

    }

    private void ShowCard(string Title,string Desc,string Desc2)
    {
        CardName.text = Title;
        Description.text = Desc;
        Description2.text = Desc2;
    }

    private void AddCard(string Title, string Desc, string Desc2)
    {
        TitleTable.Add(Title);
        DescriptionTable.Add(Desc);
        DescriptionTable2.Add(Desc2);
    }
}
