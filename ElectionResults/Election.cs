using System;
using System.Linq;


namespace ElectionResults
{
    public class Election
    {
        private string[] candidatesNames = new string[NUMOFCANDIDIATES];
        private const int NUMOFCANDIDIATES = 5;
        private int[] votes = new int[NUMOFCANDIDIATES];

        public int NumOFCANDIDATES
        {
            get { return NUMOFCANDIDIATES; }
        }

        public Election()
        {
        }

        public String FindWinner()
        {
            int tempIndex = 0;

            for (int i = 0; i < votes.Length; i++)
            {
                if (votes[tempIndex] < votes[i]) { tempIndex = i; }
            }

            return candidatesNames[tempIndex];
        }

        public String GetCandidateName(int index)
        {
            return candidatesNames[index];
        }

        public int GetCandidateVotes(int index)
        {
            return votes[index];
        }

        public void SetCandidateName(string name, int index)
        {
            candidatesNames[index] = name;
        }

        public void SetVote(int cvotes, int index)
        {
            votes[index] = cvotes;
        }

        public int TotalVotes()
        {
            return votes.Sum();
        }
    }
}
