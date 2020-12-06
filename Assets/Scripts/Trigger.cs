using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour
{

    // 觸發執行
    IEnumerator OnTriggerEnter (Collider other)
    {

        Debug.Log("-- OnTriggerEnter --");

        // 延遲 WaitForSeconds()秒
        yield return new WaitForSeconds(3);

        // 碰撞觸發對象如果有 <Bomb>, 檢查 <Bomb> 是否有 Flyme() 再呼叫 Flyme()
        if ( other.GetComponent<Bomb>() )
        {                    
            foreach (System.Reflection.MethodInfo _m in (other.GetComponent<Bomb>().GetType()).GetMethods())
            {               
                if (_m.Name == "Flyme")
                {
                    other.GetComponent<Bomb>().Flyme();                   
                }
            }
        }
    }
}