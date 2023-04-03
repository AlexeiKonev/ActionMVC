using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject _playerPrefab;

    private SomeController someController;
    private SomeModel someModel;


    private float dirX;
    private float dirZ;


    public void Start() {
        someModel = new SomeModel();

        var playerObject = Instantiate(_playerPrefab, transform.position, Quaternion.identity);

        var someView = playerObject.GetComponent<SomeView>();

        someView.characterController = someView.GetComponent<CharacterController>();

        someController = new SomeController(someModel, someView);
    }

    private void Update() {
        dirX = Input.GetAxis("Horizontal");
        dirZ = Input.GetAxis("Vertical");



    }
    private void FixedUpdate() {
        someController.Moving(dirX, dirZ);
    }
}