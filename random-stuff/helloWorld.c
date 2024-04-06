#include <stdio.h>
#include <string.h>
#include <stdbool.h> // necessário pra usar bool
#include <stdio.h>

const int TESTE = 2; // convenção: declarar const em letras maiúsculas
//long unsigned int = %lu



int numInt() {
  int n = 1;
  return n; for (int i = 1; i < 5; i++) {
    // code block to be executed
  }
} 


float numDiv() {
  float n = 2.0;
  return n;
}

char letra() {
  char a = 't';
  return a;
}

float sum(int a, int b) {
  return (float) a / (b + TESTE);
}

const char * testStr() {
  return "food";
}

char * ifNum(int myNum) {
  //const char * ifNum(int myNum) {
  if (myNum > 0){
    return "word";
  }
  else if(myNum < 0){
    return "another word";
  }
  else{
    return 0;
  }
}

int sortIf(int a){
  int time = a;
  return (time < 18) ? printf("a") : printf("b"); //short if
}
    
int main() {
  printf("Minha letra  = %c\n", letra());
  printf("Meu número inteiro = %i\n", numInt());
  printf("Meu número divisível = %f\n", numDiv()); // precisão decimal definida por' %.4'
  printf("soma = %.3f\n", sum(5,2));
  for (int i = 0; i <= 3; i++) {
    printf("iteraction = %d\n", i);
  }
  printf("Teste de if %s\n", ifNum(-3));
  return 0;
}
