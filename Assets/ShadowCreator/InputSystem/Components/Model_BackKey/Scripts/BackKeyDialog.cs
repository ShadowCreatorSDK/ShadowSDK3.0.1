using SC.InputSystem;
using UnityEngine;

public class BackKeyDialog : PointerDelegate
{
    public BackKeyDialogUI UI;
    

    void Start() {
        BackKeyOverride.AddBackKeyCallBack(BackKey);
    }
    void OnDestroy() {
        BackKeyOverride.RemoveBackKeyCallBack(BackKey);
    }

    void BackKey() { 
        
        if(!UI)
            return;
        if(UI.gameObject.activeSelf == true) {
            Application.Quit();
        } else {
            UI.gameObject.SetActive(true);
        }
    }

}
