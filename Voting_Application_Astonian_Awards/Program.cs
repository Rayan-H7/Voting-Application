using System;

namespace Voting_Application_Astonian_Awards
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            string Candidate_1 = "Bob"; 
            Console.Write("Who is the first candidate? ");
            Candidate_1 = Console.ReadLine();
            int vote1 = 0;
            
            // The above code is for the first candidate. The user imputs the name, but the amount of votes is automatically 0
            Console.Write("Who is the second candidate? ");
            string Candidate_2 = Console.ReadLine();
            int vote2 = 0;
            
            // The next portion of code is or the second candidate. As above, the user imputs the name, and the vote count is automatically 0.
            
            voting NewVote = new voting();
            voting.option(Candidate_1, vote1, Candidate_2, vote2);
            string vote_1 = voting.change_in_vote( Candidate_1,55, 6, 0);
            int vote__1 = (0 + 55) - 6;
            int vote__2 = (0 + 56) - 7;
            string vote_2 = voting.change_in_vote(Candidate_2, 56, 7, 0);
            Console.WriteLine(vote_1+" is the amount of votes "+Candidate_1+" has, and "+vote_2+" is the amount "+Candidate_2+" has.");
            
            int random_num = rnd.Next(0,100);

            voting.elected(Candidate_1, Candidate_2, vote__1, vote__2,random_num);

        }
    }
}
