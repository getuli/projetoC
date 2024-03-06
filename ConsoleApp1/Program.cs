// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

public class Algo{
    int speed;

    void Atribuir(){
       speed = 2;

       if(speed <= 5 || speed >= 0){
        Console.WriteLine("Hello Word");
       }else{
        Console.WriteLine("Hello World 2");
       }
    }

    void loop(){
        int[] intArray = new int[]{1,2,3,4};
        List<int> intList = new List<int>(){1,2,3,4};

        foreach( int numbers in intList) {

        }


        for(int i = 0; i<= intList.Count; i++){

            int list =+ i;

        }

        for( int i = 0; i <= intArray.Length; i++){
            int array =+ i;
            int currencyarray = intArray[i];
            Console.WriteLine(currencyarray);
        }
    }

}
