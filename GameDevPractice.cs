// gameObject collision detection 
private void OnCollisionEnter(Collision collidedVastuvu)
{
  if(box.gameObject.tag=="Enemy")
  {
    Destroy(collidedVastuvu.gameObject);
  }
}
