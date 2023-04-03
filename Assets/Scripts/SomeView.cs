using UnityEngine;

public class SomeView : MonoBehaviour {
    public CharacterController characterController;
    public void Changehealth(float health) {
        //Уже любыми средствами отрисовывать визуальную часть
        //это может как быть slideBar или просто Text 
    }
    public void Moving(float x,float y) {
        characterController.Move(new Vector3(x,0,y));
        Debug.Log($"player move X {x} player move Y {y}");
    }
    public void Death() {
        //Например можете проиграть анимацию смерти
    }
}
