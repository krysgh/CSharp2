// See https://aka.ms/new-console-template for more information

using AnimalZoologicoEmSala;

Animal[] Animais = new Animal[3];

Animais[0] = new Cachorro("Rex", 5);
Animais[1] = new Gato("Tom", 3);
Animais[2] = new Leao("Simba", 7);

for(int i = 0; i < Animais.Length; i++)
{
    Console.WriteLine(Animais[i].ToString());
    Console.WriteLine($"Som: {Animais[i].EmitirSom()}");
    Console.WriteLine();
}