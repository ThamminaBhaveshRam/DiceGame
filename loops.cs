int n = 5;
void Start()
{
  for (int row = 1; row <=n; row ++)
  {
     string length ="";
     for(int column = 1; column <=n; column++)
     {
       length = length + "*";
     } 
    Debug.Log(length);
  }
}
