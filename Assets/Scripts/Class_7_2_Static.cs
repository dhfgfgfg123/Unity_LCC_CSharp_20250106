using UnityEngine;
using UnityEngine.SceneManagement;


namespace Eason
{
    /// <summary>
    /// 靜態 Static
    /// </summary>
    public class Class_7_2_Static : MonoBehaviour
    {
        #region 變數與屬性
        // 成員 :
        // 變數、屬性、方法

        // 非靜態變數
        public int inventoryWater = 10;
        // 靜態變數 : 修飾詞後面添加關鍵字 static
        // 靜態變數不顯示在屬性面板上
        public static int inventoryPorp = 20;

        // 非靜態屬性
        public string skillMain => "火球術";
        // 靜態屬性
        public static string skillSecon => "治癒術"; 
        #endregion

        private void Awake()
        {
            //inventoryWater = 7;
            //inventoryPorp = 15;
            Debug.Log($"<color=#f31>藥水 : {inventoryWater}</color>");
            Debug.Log($"<color=#f31>道具 : {inventoryPorp}</color>");
        }

        public void Punch()
        {
            Debug.Log("<color=#3f3>使用拳擊</color>");
        }

        public static void Kick()
        {
            Debug.Log("<color=#3f3>使用踢擊</color>");
        }

        private void Start()
        {
            // 在 Unity 內的差異
            // 場景切換時
            // 非靜態成員會被釋放 (還原為預設值)
            inventoryWater++;    // 藥水加一
            Debug.Log($"<color=#78f>藥水 : {inventoryWater}</color>");
            // 靜態成員不會被釋放 (不會還原為預設值)
            inventoryPorp++;     // 道具加一
            Debug.Log($"<color=#78f>道具 : {inventoryPorp}</color>");
        }

        private void Update()
        {
            // 在Game 畫面按下數字 1 會重新仔入場景 (切為英文輸入法)
            // 如果按下數字 1 (左邊鍵盤ㄅ)
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SceneManager.LoadScene("課程_7_屬性與靜態");
            }
        }
    }
}
