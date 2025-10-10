// See https://aka.ms/new-console-template for more information
int aux;

int[] BubbleSort(int[] vetorDesordenado)
{
    int[] vetorOrdenado = new int[vetorDesordenado.Length];
    int indice = 0;

    foreach (int elemento in vetorDesordenado)
        vetorOrdenado[indice++] = elemento;

    for (int referencia = 0; referencia < vetorOrdenado.Length - 1; referencia++)
    {
        for (int comparacao = referencia + 1; comparacao < vetorOrdenado.Length; comparacao++)
        {
            if (vetorOrdenado[referencia] > vetorOrdenado[comparacao])
            {
                aux = vetorOrdenado[referencia];
                vetorOrdenado[referencia] = vetorOrdenado[comparacao];
                vetorOrdenado[comparacao] = aux;
            }
        }
    }
    return vetorOrdenado;
}

int[] vetorAleatorio = new int[10];
int[] vetorOrdenado = new int[10];

for (int i = 0; i < vetorAleatorio.Length; i++)
    vetorAleatorio[i] = Random.Shared.Next(1, 100);

vetorOrdenado = BubbleSort(vetorAleatorio);

Console.Write("VETOR DESORDENADO: [ ");
foreach (int i in vetorAleatorio)
    Console.Write(i + " ");

Console.Write("]\nVETOR NA ORDEM CRESCENTE: [ ");
foreach (int i in vetorOrdenado)
    Console.Write(i + " ");

Console.WriteLine("]");
