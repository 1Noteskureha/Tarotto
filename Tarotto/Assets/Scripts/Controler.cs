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
        AddCard("愚者-the fool-","無邪気\n純粋\n自由\n出発","無知\n無計画\n無責任\n中途半端");
        AddCard("魔術師-the magician-","創造的\n集中\n活力\n技術\n知識\n理想実現","集中力不足\n技術不足\n知識不足\n消極的\n");
        AddCard("女教皇-the thehighpriestes-", "直感\n洞察\n秘密\n知性\n神秘的", "無知\n表面的な知識\n神経質\nうわべだけ");
        AddCard("女帝-the empress-", "豊かさ\n結婚\n繁栄\n養育\n女性的\n官能的喜び", "わがまま\n嫉妬\n依存\n不満");
        AddCard("皇帝-the emperor-", "権力\n意欲的\n信頼\n理性\n父性\n力強さ", "無責任\nワンマン\n利己的\n横柄");
        AddCard("法王-the hierophant-", "秩序\n規則\n自費\n知識\n教育\n社会性", "頭が固い\n頑固\n信頼できない");
        AddCard("恋人-the lovers-", "恋愛\n愛\n娯楽\nロマンス\n性的な快楽", "疑念\n浮気\n分離\n迷い\n破綻");
        AddCard("戦車-the chariot-", "勝利\n前進\n征服\n忍耐力\n意志の強さ", "挫折\n停滞\n失敗\n敗北");
        AddCard("力-strength-", "力\n意思\n勇気\n信念\n忍耐\n寛大", "自信喪失\n失敗\n臆病\n力を乱用");
        AddCard("隠者-the hermit-", "内省\n思慮\n内面への探求\n秘密\n慎重", "孤独\n陰湿\n偏屈\n神経質");
        AddCard("運命の輪-wheel of fortune-", "ターニングポイント\nチャンス到来\n大きな変動\n好転\n運命", "急降下\n失敗\n好機を逃す\n不運");
        AddCard("正義-justice-", "公正\n平等\n調和\n正義\nモラル", "偏見\n不平等\n優柔不断\n不誠実\n不安定");
        AddCard("吊られた男-the hanged man-", "試練\n自己犠牲\n忍耐\n報われる苦労\n身動きが取れない", "報われぬ犠牲\n骨折り損\n限界\n宙ぶらりん");
        AddCard("死神-death-", "終結と始まり\n破壊と創造\n転機\n分岐点\n切り捨てる", "中止\n遅い変化\n怠惰\n無気力");
        AddCard("節制-the temperance-", "節制\nバランス\n倹約\n調和\n安定\n健康", "不均衡\n自分本位\n停滞\n浪費");
        AddCard("死神-the devil-", "束縛\n堕落\n誘惑\n嫉妬\n悪しき習慣", "束縛からの解放\n断ち切る");
        AddCard("塔-the tower-", "突然の変化\n予期せぬ災難\n破滅\n転落\n崩壊", "緊迫\n小さな崩壊\n災害");
        AddCard("星-the star-", "希望\n理想\n奇跡\n先を見通す\n良い兆し\n霊感", "失望\n混乱\n先が見えない\n悲観");
        AddCard("月-the moon-", "不安\n恐れ\n戸惑い\n動揺\n偽り\n迷い", "回復\n不安の将来が分かる\n危機回避");
        AddCard("太陽-the sun-", "生命\n結婚\n確信\n栄光\n満足\n健康\n資産", "不運\n失敗\n甘え\n暗雲\n浅はか");
        AddCard("審判-judgement-", "審判\n解放\n復活\n再生\n許し\n救済\n良い知らせ", "失望\n後悔\n無念\n挫折\n良くない知らせ");
        AddCard("世界-the world-","完成\n達成\n調和\n完璧\n実現","中途半端\n未完成\nスランプ");
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
        if (i == 0) Position.text = "正位置";
        else Position.text = "逆位置";

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
