

public class SomeController {

    public SomeView someView;
    public SomeModel someModel;

    public SomeController(SomeModel model, SomeView view) {

        someModel = model;
        someView = view;
    }


    public void Enable() {
        someModel.Death += Death;
        someModel.ChangedHealth += ChangeHealth;
    }
   public void Moving(float x ,float y) {
        someView.Moving(x ,y);
    }
    private void ChangeHealth(float health) {
        someView.Changehealth(health);
    }

    private void Death() {
        someView.Death();
        Disable();
    }

    public void Disable() {
        someModel.Death -= Death;
        someModel.ChangedHealth -= ChangeHealth;
    }
}
