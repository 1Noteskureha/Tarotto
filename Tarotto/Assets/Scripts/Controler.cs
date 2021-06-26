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

    private List<string> TitleTable = new List<string>();
    private List<string> DescriptionTable = new List<string>();
    private List<string> DescriptionTable2 = new List<string>();
    // Start is called before the first frame update
    void Start()
    {   
        AddCard("ê¢äE","Ç∑Ç≤Ç¢","Ç∑Ç≤Ç≠Ç»Ç¢");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HitCard()
    {
        int i = Random.Range(0,TitleTable.Count);
        ShowCard(TitleTable[i],DescriptionTable[i],DescriptionTable2[i]);
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
