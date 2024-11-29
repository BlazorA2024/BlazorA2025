namespace BlazorASG.Data
{



   public class OutputModel
    {
        public string title { set; get; }
        public string description { set; get; }
        public bool published { set; get; }
    }

    public class Message
    {


        public string BodyMessage { get; set; } = "anas";
        public string AwnserAI { get; set; } = "";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool isltr { get; set; } = true;

    }
    public class TSenario
    {
        public string seqtactic { get; set; } = "";
        public string iduser { get; set; } = "";
        public string seqtec { get; set; } = "";
        public string score { get; set; } = "";
    }
    public class Senario
    {
        public string Id { get; set; } = "Id";
        public string FristTechnique { get; set; } = "FristTechnique";
        public string Tactic { get; set; } = "FristTactic";
        public string Software { get; set; } = "FristSoftware";
        public string Group { get; set; } = "Group";
        public double Score { set; get; } = 0.8;
        public string State { set; get; } ="Success";
    }
    public class Technique
    {
     public  string Name { get;  }
     public Technique(string name)
        {
            Name = name;
        }
    }
    public class Tactic
    {
        public string Name { get; }
        public  Tactic(string name)
        {
            Name = name;
            Techniques = new List<Technique>();
        }
        public List<Technique> Techniques { get;  }
    }
    public class Group
    {
        public string Name { get; set; }
        public List<Software>  Softwares { get; set; }

        public static Group CovertTextToOBject(string text)
        {

            return new Group();
        }
    }
    public class Software
    {
        public string Name { get; set; }
        public  List<Tactic> Tactics { set; get; }

        
    }
    public class SeqSenario:Senario
    {
        public List<string> SeqTactics { set; get; }
        public List<string> SeqTechniques { set; get; }
        public SeqSenario()
        {
            SeqTactics = new List<string>();
            SeqTechniques = new List<string>();
        }

    }
}