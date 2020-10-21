using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("虛擬搖桿")]
    public Joystick joystick;

    // 屬性 Property
    // 與欄位很相似
    // 差異 1：屬性可以設定存取權限
    // 可以設定為：唯讀、全部 (讀取、寫入)、唯寫 (很少使用)
    // 語法：
    // 修飾詞 類型 名稱 { 讀取; 寫入; }
    // 差異 2：可被事件存取
    public Transform target { get; set; }
    
    private void Update()
    {

    }

    private void ControlTarget()
    {
        if (target)                                                                      // 如果 目標物件 存在
        {
            target.localScale += joystick.Vertical * Time.deltaTime * Vector3.one;       // 目標.尺寸 遞增 搖桿垂直 * 一禎 * 三維.1
            target.Rotate(0, joystick.Horizontal * Time.deltaTime * 100, 0);             // 目標.旋轉(0，搖桿水平 * 一禎，0)
        }
    }
}
