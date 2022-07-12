using System;
namespace DNASTRAND
{
	public class Methods
	{
		public static string MakeComplement(string dna)
		{
            string dna2 = "";
            for (int i = 0; i < dna.Length; i++)
            {
                if (dna[i] == 'A')
                {
                    dna2 += 'T';
                }
                else if (dna[i] == 'T')
                {
                    dna2 += 'A';
                }
                else if (dna[i] == 'C')
                {
                    dna2 += 'G';
                }
                else if (dna[i] == 'G')
                {
                    dna2 += 'C';
                }
            }
            return dna2;
		}
	}
}

