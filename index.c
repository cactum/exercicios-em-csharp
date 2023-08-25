#include <stdio.h>
#include <stdlib.h>

int main() {
    int codLivro = 0;
    char Titulo[30], Autor[20], Editora[10];

    printf("Digite o Codigo do livro para cadastrar: ");
    scanf("%d", &codLivro);

    printf("Digite o Autor: ");
    scanf("%s", Autor);  // Não precisa usar & para arrays de caracteres

    printf("Codigo do livro %d e autor %s\n", codLivro, Autor);  // Sem & no printf

    return 0;
}
