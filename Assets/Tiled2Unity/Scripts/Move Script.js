
function Update() {
    // Move the object forward along its z axis 1 unit/second.
    if (Input.GetKey(KeyCode.UpArrow)) transform.Translate(Vector3(0, 1, 0) * Time.deltaTime);
    if (Input.GetKey(KeyCode.DownArrow)) transform.Translate(Vector3(0, -1, 0) * Time.deltaTime);
    if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(Vector3(-1, 0, 0) * Time.deltaTime);
    if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(Vector3(1, 0, 0) * Time.deltaTime);
}