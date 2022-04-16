namespace Voting_Application_Astonian_Awards
{
    public class voting
    {    
        public int sample_size = 150;
        public static void option(string Candidates_1, int num_of_votes, string Candidate_2, int num_of_votes_2){
            string First_Candidate = Candidates_1;
            int votes = num_of_votes; 
            string Second_Candidate = Candidate_2;
            int votes_2 = num_of_votes_2;
        }
        
        public static string change_in_vote(string Candidate ,int increase, int decrease, int current_vote){
            int votes = current_vote;
            if (increase > 50){
                votes = current_vote + 50;
                return "The amount of votes is "+votes+".";
            }else if (increase < 50){
                votes = current_vote + increase;
                return "The amount of votes is "+votes+".";
            }else if(decrease >50){
                votes = current_vote + (decrease - increase);
                return "The amount of votes is "+votes+".";
            }else{
                votes = current_vote + (increase);
                votes = votes - decrease;
                return "The amount of votes is "+votes+".";
            }
        }
        public int total_votes_1;
        public int total_votes_2;

        public static string elected(string Candidate_1, string Candidate_2, int total_votes_1, int total_votes_2, int random_num){
            int Candidate_1_Total = total_votes_1 * 40000;
            int Candidate_2_Total = total_votes_2 * 40000;
            return Candidate_1+ "had "+Candidate_1_Total+" votes, and "+Candidate_2+" had "+Candidate_2_Total+"votes.";

            if (Candidate_1_Total > Candidate_2_Total){
                string election_result = Candidate_1+" has been elected as Prime Minister of Pakistan with a total of "+Candidate_1_Total+"votes";
                return election_result;
            }else if (Candidate_1_Total < Candidate_2_Total){
                string election_result = Candidate_2+" has been elected as Prime Minister of Pakistan with a total of "+Candidate_2_Total+"votes";
                return election_result;
            }else if (Candidate_1_Total == Candidate_2_Total){
                string tie_breaker = "The results have been tied. To solve this we will draw out of a hat, and you`ll have to input a number between 0 - 100.";
                return tie_breaker;

                int Tie_breaker =  random_num;
                if (Tie_breaker > 50 && Tie_breaker > 100 || Tie_breaker == 50){
                    string election_result = Candidate_1+" has been elected as Prime Minister of Pakistan with a total of "+Candidate_1_Total+"votes";
                    return election_result;
                }else if (Tie_breaker < 50 && Tie_breaker > 0){
                    string election_result = Candidate_2+" has been elected as Prime Minister of Pakistan with a total of "+Candidate_2_Total+"votes";
                    return election_result;
                }else{
                    string wrong_choice = "You have inputted a number that isn`t in the range of 0 - 100. Please restart.";
                    return wrong_choice;
                }

            }
        }
    }
    
}
