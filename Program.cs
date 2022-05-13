namespace StackOverflowExcersise
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //preparing random votes
            Random RandomGen = new Random();
            int UpRand = RandomGen.Next(1,15);
            int DownRand = RandomGen.Next(1, 15);


            //creating a post
            var SofPost1 = new Post("How to write this class?", "I am curious that it is right or not. Idea?");
            //editing a post
            SofPost1.EditPost(  "I know this is not a real editing, but can overwrite the text before.\n" +
                                "With ReadPost() it should cover an editor input/output field");
                       
            //rating a post
            for(int i=0; i<UpRand; i++)
                SofPost1.UpVote();
            for(int i=0; i<DownRand; i++)
                SofPost1.DownVote();

            //get esentials
            Console.WriteLine("<Post: {0}\t{1}>", SofPost1.GetTitle(), SofPost1.creationDate);
            Console.WriteLine("<Description:>\n{0}", SofPost1.ReadPost());
            Console.WriteLine("<Votes: {0}>", SofPost1.GetVotes());
            Console.WriteLine("<Last Updated: {0}>", SofPost1.UpdateDate);
            Console.WriteLine("\nFor science: \ndownVotes: {0} \nupVotes: {1}", DownRand, UpRand);

        }
    }
}
