using UnityEngine;

/// <summary>
/// 課程 3 : 運算子
/// 補充 : Unity 欄位屬性、Unity 事件
/// </summary>
public class Class_3_Operator : MonoBehaviour
{
    #region 基本的欄位屬性
    // C# 變數 = 欄位 Field
    // 欄位屬性 Field Attritude
    // [標題(標題文字)]
    [Header("等級")]
    public int lv = 1;
    // [提示(提示文字)] : 在屬性面板滑鼠停留在變數上時顯示
    [Tooltip("這是角色的移動速度, 不建議超過 100。")]
    public float moveSpeed = 2.5f;
    // [範圍(最小,最大)] : 幫數值類型添加範圍 (面板上改為滑桿)
    [Range(1, 100)]
    public byte count = 10;
    // 範圍不能使用在非數值類型上 ， 會顯示 "Use Range with..."
    [Range(0, 10)]
    public string weapon = "匕首";
    // [文字範圍(最小行, 最大行)] : 使用在字串上 ， 設定面板上的文字框範圍
    [TextArea(2, 5)]
    public string itemDescription = "這裡是道具的描述，這裡是道具的描述，這裡是道具的描述";

    // 多個欄位屬性
    [Header("血量")]
    [Range(0, 999)]
    public int hp = 100;
    [Header("攻擊力"), Range(0, 100)]
    public float attack = 30.5f;
    // [在屬性面板隱藏]
    [HideInInspector]
    public string password = "我是密碼";
    // [序列化欄位] : 將私人變數顯示
    [SerializeField]
    private float mp = 500;
    #endregion

    // 使用 Unity 的事件
    // 1. 必須在腳本後面添加 : MonoBehaviour (繼承)
    // 2. 使用關鍵字快速完成，例如: 輸入 Awake 挑選要使用的事件按 Enter
    // 喚醒事件 : 播放遊戲後會執行的第一個事件， 只執行一次
    private void Awake()
    {
        #region 輸出訊息
        // 將小括號內的訊息輸出到 Unity 的 Console 控制台面板
        // Ctrl + Shift + C 開啟控制台面板
        Debug.Log("哈囉 沃德");          // 輸出文字
        Debug.Log(hp);                  // 輸出變數的值
        Debug.Log("攻擊力 :" + attack);  // 字串與變數
        Debug.Log($"攻擊力 : {attack}"); // $字串格式
        Debug.Log("攻擊力 : {attack}");  // 沒有寫$

        Debug.Log("<b>粗體</b>");
        Debug.Log("<color=orange>橘色</color>");
        // 色碼 : #紅紅綠綠藍藍，數值 : 0 ~ 9 ，a ~ f 越右邊顏色月亮 #000 黑 #fff白
        Debug.Log("<color=#66aaff>藍色</color>");
        Debug.Log("<color=#6af>藍色</color>");
        #endregion

        #region 算數運算子
        Debug.Log("<color=#f93>--- 算數運算子 ---</color>");
        // 運算子
        // 1. 算術運算子
        // 加 減 乘 除 餘
        // +  -  *  /  %
        Debug.Log(10 + 3);
        Debug.Log(10 - 3);
        Debug.Log(10 * 3);
        Debug.Log(10 / 3);
        Debug.Log(10 % 3);

        Debug.Log("<color=#f93>--- 算數運算子 : 區域變數 ---</color>");
        // 區域變數 : 僅在此大括號內存取 (不需要修飾詞的變數)
        float numberA = 10;
        float numberB = 3;

        Debug.Log(numberA + numberB);
        Debug.Log(numberA - numberB);
        Debug.Log(numberA * numberB);
        Debug.Log(numberA / numberB);
        Debug.Log(numberA % numberB);
        #endregion

        #region 比較運算子
        Debug.Log("<color=#f93>--- 比較運算子 ---</color>");
        int numberC = 100, numberD = 1;

        Debug.Log(numberC > numberD);
        Debug.Log(numberC < numberD);
        Debug.Log(numberC >= numberD);
        Debug.Log(numberC <= numberD);
        Debug.Log(numberC == numberD);
        Debug.Log(numberC != numberD);
        #endregion

        #region 布林值邏輯運算子
        Debug.Log("<color=#f93>--- 布林值邏輯運算子 ---</color>");
        // 邏輯否定 : 將布林值變成相反的值
        Debug.Log(!true);
        Debug.Log(!false);
        bool boolVarTrue = true, boolVarFalse = false;
        Debug.Log(!boolVarTrue);
        Debug.Log(!boolVarFalse);
        Debug.Log("<color=#f93>--- 並且與或者 && 、 || ---</color>");
        // 並且 : 比較兩個布林值，只要有一個 false 結果就是一個false
        Debug.Log(true && true);          // True
        Debug.Log(true && false);          // False
        Debug.Log(false && true);          // False
        Debug.Log(false && false);          // False
        // 或者 : 比較兩個布林值，只要有一個 true 結果就是true
        Debug.Log(true || true);          // True
        Debug.Log(true || false);          // True
        Debug.Log(false || true);          // True
        Debug.Log(false || false);          // False
        #endregion


    }
}
