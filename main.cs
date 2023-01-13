using System;

class Program {
  public static void Main (string[] args) {
    char[,] car1 = make_forward();
    char[,] car2 = make_mirror(make_forward());
    printcar(car1);
    printcar(car2);
    printcar(make_double(car1,car2));
  }
  public static char[,] make_forward(){
  char[,] pixel = new char[4, 13];
  pixel[0, 0] = ' ';
  pixel[0, 1] = ' ';
  pixel[0, 2] = '_';
  pixel[0, 3] = '_';
  pixel[0, 4] = '_';
  pixel[0, 5] = '_';
  pixel[0, 6] = '_';
  pixel[0, 7] = '_';
  pixel[0, 8] = ' ';
  pixel[0, 9] = ' ';
  pixel[0, 10] = ' ';
  pixel[0, 11] = ' ';
  pixel[0, 12] = ' ';
  pixel[1, 0] = ' ';
  pixel[1, 1] = '/';
  pixel[1, 2] = '|';
  pixel[1, 3] = '_';
  pixel[1, 4] = '|';
  pixel[1, 5] = '|';
  pixel[1, 6] = '_';
  pixel[1, 7] = '\\';
  pixel[1, 8] = '\'';
  pixel[1, 9] = '.';
  pixel[1, 10] = '_';
  pixel[1, 11] = '_';
  pixel[1, 12] = ' ';
  pixel[2, 0] = '(';
  pixel[2, 1] = ' ';
  pixel[2, 2] = ' ';
  pixel[2, 3] = ' ';
  pixel[2, 4] = '_';
  pixel[2, 5] = ' ';
  pixel[2, 6] = ' ';
  pixel[2, 7] = ' ';
  pixel[2, 8] = ' ';
  pixel[2, 9] = '_';
  pixel[2, 10] = ' ';
  pixel[2, 11] = '_';
  pixel[2, 12] = '\\';
  pixel[3, 0] = '=';
  pixel[3, 1] = '\'';
  pixel[3, 2] = '-';
  pixel[3, 3] = '(';
  pixel[3, 4] = '_';
  pixel[3, 5] = ')';
  pixel[3, 6] = '-';
  pixel[3, 7] = '-';
  pixel[3, 8] = '(';
  pixel[3, 9] = '_';
  pixel[3, 10] = ')';
  pixel[3, 11] = '-';
  pixel[3, 12] = '\'';
  return pixel;
}
  public static void printcar(char[,] car){
    for (int i = 0; i < car.GetUpperBound(0)+1; i++){
      for (int j = 0 ; j < car.GetUpperBound(1)+1; j++){
        Console.Write(car[i,j]);
      }
      Console.WriteLine();
    }
    
  }
  public static char[,] make_mirror(char[,] car){
    for (int i = 0; i < 4; i++){
      for (int j = 0 ; j < 13; j++){
        if(car[i,j] == '(')
          car[i,j] = ')';
        else if(car[i,j] == ')')
          car[i,j] = '(';
        else if(car[i,j] == '/')
          car[i,j] = '\\';
        else if(car[i,j] == '\\')
          car[i,j] = '/';
      }
  }
    for (int i = 0; i < 4; i++){

        int rightindex = 12;
      
      for (int j = 0 ; j < 6; j++){
        char temp;
        
        
        temp = car[i,j];
        car[i,j] = car[i,rightindex];
        car[i,rightindex] = temp;
        rightindex--;
        }
      }
    return car;
}
  public static char[,] make_double(char[,] car, char[,] mirrorcar){
    char[,] newcar = new char[4,26];

    for (int i = 0; i < 4; i++){
      for (int j = 0 ; j < 13; j++){
        newcar[i,j] = car[i,j];
        newcar[i,j+13] = mirrorcar[i,j];
        
        }}
    
    return newcar;
  }
  
  }