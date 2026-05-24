// gameObject collision detection 
private void OnCollisionEnter(Collision collidedVastuvu)
{
  if(box.gameObject.tag=="Enemy")
  {
    Destroy(collidedVastuvu.gameObject);
  }
}

//Instantiant

public class SpawnObject : MonoBehaviour
{
  public GameObject ball;
  public Transform spawnPoint;

  void Update()
  {
  
  }

  void SpawnObject()
  {
    Instantiate(ball,spawnPoint.position, Quaternion.identity)
  }
}
