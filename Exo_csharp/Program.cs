using System;

namespace Exo_csharp
{
    class Program
    {
        //List<string> ListPrenom=new List<string>();
        
        static void Main(string[] args)
        {
            //Les Tableaux
            // String[] nom=new String[]{"Jeff","Hantz"};
            // int[] nombre=new int[5];
            // nombre[0]=56;
            // nombre[1]=30;
            // nombre[2]=23;
            // nombre[3]=20;
            // nombre[4]=33;
            // for(int i=0;i<nom.Length;i++){
            //     Console.WriteLine(nom[i]);
            // }
            // for(int i=0;i<nombre.Length;i++){
            //     Console.WriteLine(nombre[i]);
            // }

            //Les Listes. Nb: La nombre d'element dans une liste "Count"
            // List<string> Prenom;
            // Prenom=Ajouter();
            // foreach(string pre in Prenom){
            //     Console.WriteLine(pre);
            // }
            

            //Enum
            // Login inscrit;
            // inscrit=Login.pseudo;
            // Console.WriteLine(inscrit);

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(Environment.UserName);

            //Les converions
            // int nbre=21;
            // double nb=double.parse(nbre);
            Console.WriteLine("Saisie votre nom");
            string nom=Console.ReadLine();
            Console.WriteLine("Ton nom est "+nom);


        }

        //Les enumerations
        // enum Login{
        //         pseudo,
        //         nom,
        //         prenom,
        //         password,
        //     }


        // static List<string> Ajouter(){
        //     ListPrenom.add("Jeff");
        //     ListPrenom.add("Hantz");
        //     ListPrenom.add("Belizaire");
        //     return ListPrenom;
        // }
    }
}
