#include <stdio.h>


int line[10];
int* rows(){

  for(int i = 0; i < 10; i++) {
    line[i] = i;
  }
  return line;
}


int main(void) {
  
  int* s = rows();
  printf("%d\n", *s);
  /*
  int arr[10][10];
  for(int i = 0; i < 10; i++) {
    arr[0][i] = i;
  }
  */
}

