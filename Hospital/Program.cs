using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            string Dname;
            int Pnumber;
            string[] Pid = new string[50];
            string[] Pname = new string[50];
            string[] Paddress = new string[50];
            string[] Pcontact = new string[50];
            string[] Page = new string[50];
            string[] Gender = new string[50];
            string[] Tid = new string[50];
            string[] Tname = new string[50];
            double  total = 0;
            double[] Amount = new double[50];
           
            int i, j,Tnumber;

            Console.Write("\n Enter the name of the Doctor: ");
            Dname = Console.ReadLine();
            Console.Write("\n Enter the number of Patients: ");
            Pnumber = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for(i=0;i<Pnumber;i++)
            {
                // Details of the Patient
                Console.Write("\n Enter the Patient ID: ");
                Pid[i]=Console.ReadLine();
                Console.Write("\n Enter the Patient Name: ");
                Pname[i] = Console.ReadLine();
                Console.Write("\n Enter the Address of the patient: ");
                Paddress[i] = Console.ReadLine();
                Console.Write("\n Enter the Contact of the patient: ");
                Pcontact[i] = Console.ReadLine();
                Console.Write("\n Enter the Age of the Patient: ");
                Page[i] = Console.ReadLine();
                Console.Write("\n Enter the Gender of the patient: ");
                Gender[i] = Console.ReadLine();
                Console.Write("\n Enter the number of Treatment going on for the patient: ");
                Tnumber = Convert.ToInt32(Console.ReadLine());
                // Details of the treatment

                for (j = 0; j < Tnumber; j++)
                {
                    Console.Write("\n Enter the Treatment Id of the patient: ");
                    Tid[j] = Console.ReadLine();
                    Console.Write("\n Enter the Treatment Name undergoing on the patient: ");
                    Tname[j] = Console.ReadLine();
                    Console.Write("\n Enter the amount for the treatment undergoing: ");
                    Amount[j] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                }

                Console.Write("\n Details of the Patient");
                Console.Write("\n \t\t\t\tB&B Hospital ");
                Console.Write("\n **********************************************************************");
                Console.Write("\n\n Treatment Under {0}", Dname);
                Console.Write("\n\n **********************************************************************");
                Console.Write("\n Patient ID: {0}", Pid[i]);
                Console.Write("\n Name: {0}", Pname[i]);
                Console.Write("\n Address: {0}", Paddress[i]);
                Console.Write("\n Contact: {0}", Pcontact[i]);
                Console.Write("\n Age: {0}", Page[i]);
                Console.Write("\n Gender: {0}", Gender[i]);

                Console.Write("\n**********************************************************************");
                Console.Write("\n\t{0}\t{1}\t\t{2} ", "Treatment ID", "Treatment Name", "Amount");
              

                for (j = 0; j < Tnumber; j++)
                {
                    Console.Write("\n \t\t{0}\t\t{1}\t\t{2}", Tid[j], Tname[j], Amount[j]);
                                    total += Amount[j];


                    

                }

                Console.Write("\n\n\n The total payable amount for {0} is Rs{1}.", Pname[i], total);


                Console.ReadLine();
                Console.Clear();
                Console.ReadLine();


            }


 
            


        }
    }
}
