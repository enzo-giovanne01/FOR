using static System.Console;

int n1,n2;

Write("Digite um número: ");
n1 = Convert.ToInt32(ReadLine());
Write("Digite um segundo número: ");
n2 = Convert.ToInt32(ReadLine());
Clear();
    if(n1 < n2){
    for(int i = n1; i<=n2; i++){
        WriteLine(i.ToString());
    }
}
else{
    for(int i = n2; i<=n1; i++){
        WriteLine(i.ToString());
    }   
}
WriteLine("Terminou o laço");
