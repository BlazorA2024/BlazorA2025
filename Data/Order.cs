using System;

namespace BlazorASG.Data
{
    public class Order
    {
        public Guid OrderId { get; set; } = Guid.NewGuid();
        public string CustomerName { get; set; }
        public string Country { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public OrderType OrderType { get; set; }
        public decimal GrossValue { get; set; }
        public decimal NetValue { get =>  GrossValue * (1 - (DiscountPercentage / 100)) ; }
        public decimal DiscountPercentage { get; set; }
    }

    public enum OrderType
    {
        Web, Contract, Mail, Phone
    }

    public  class BodyChat
    {
        public TypeChat TypeChat { get; set; }
        public string Url { get; set; } = "input";
        public string[][] LG { get; set; } =
        {
            new string[] {"  Yes, you can  " ,
            " proposed scenarios are compared with actual ICS incidents",
            "generate scenarios ",
            "display  incidents to which  technique belongs",
            "techniques  work for  same purpose",
            "Did you mean ?",
            "the result is :",
            " If you want to view more scenarios, you can go  "

            },
            new string[]{"نعم  يمكن  ",
             " تتم مقارنة السيناريوهات المقترحة مع حوادث ICS الفعلية",
                "إنشاء سيناريوهات تبدأ بـ",
                "عرض الحوادث التي تنتمي إليها التكنيك",
                "تكنيكات  تعمل نفس الغرض  ",
                "هل تقصد التكنيك ؟",
                ": النائج المقترح هو  ",
                "   إذا كنت ترغب في عرض المزيد من السيناريوهات، يمكنك  الانتقال الى "
            }

        };
    }

    public enum TypeChat
    {
        General = 0,
        Incident = 1,
        Group = 2,
        Senario = 3,
        Technique = 4,
        ChatBot=5,
        StateBase=6


    }


    public enum TypeGeneratingModel
    {
        Threatbased=0,
        Statebased=1
    }
   public class TypeGenerating
    {
        public TypeGeneratingModel TypeGeneratingModel { set; get; } = TypeGeneratingModel.Threatbased;
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";

        public object Form { set; get; }

        public  static TypeGenerating getThreadBase()
        {
            return new TypeGenerating()
            {
                Name = "Threat-based",
                TypeGeneratingModel = TypeGeneratingModel.Threatbased,
                Description = "Creating an attack sequence through the analysis of the ICS ATT\\&CK knowledge base\\cite{att2021mitre}, which was developed to adversary emulation. It serves as a framework and knowledge base for attackers to identify tactics and techniques based on real incidents. ATT\\&CK summarizes attacker behaviors in terms of tactics, techniques, and groups. It is essential to organize the attack methods used in cyber attacks, unify their names and scopes.",
                Form = ""


            };
        }
        public static TypeGenerating getStateBase()
        {
            return new TypeGenerating()
            {
                Name = "State-based",
                TypeGeneratingModel = TypeGeneratingModel.Statebased,
                Description = "Generating Attack Sequences Automatically Based on System State. We refer to two key factors for automated attack planning inspired by (W): the 'Initial State' and the 'Attack Technique.' These attacks should be linked to the actions of the security analyst, who must be aware of the initial attack state. This is represented by a data structure containing a description of the initial state, such as lists of IP addresses, ports, acquired privileges, and the operating system state, all related to the system's target. ",
                Form =FormStateBased.getDSB()
            };
        }
    }


   
    public enum StateBasedValueModel
    {

        Address=0,
        Protocol=1,
        Os=2,
        Port=3,
        Shell=4,
        Privilege=5,
        Binaries=6,
        CWD=7,
        Misudo=8

    }

    public enum TypeValueSB
    {
        Text=0,
        Condition=1
    }
    public  enum TypeConditionState
    {
        AND=0,
        OR=1,
        XOR=2,
        XNor=3
    }
    public class ValueSB
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public TypeValueSB TypeValueSB { get; set; }
        public  string CV { set; get; }
        public List<string> Values { get; set; }
        public ValueSB() {
            Values = new List<string>();
            TypeValueSB = TypeValueSB.Text;
        }
       
    }
  public  class SDescription
    {
        private static Dictionary<string, SDescription> descriptions = new Dictionary<string, SDescription>();

        public string? Value {  get; }
        private SDescription(string dec) {
            Value = dec;
        }
    public    static SDescription GetDescription(string dec)
        {

            if (descriptions.Keys.Contains<string>(dec))
                return descriptions[dec];
            return new SDescription(dec);
        }
    }
    public class StateBasedValue
    {
         private SDescription _description ;
        public StateBasedValue()
        {
            Items = new List<ValueSB>();
        }
        public StateBasedValueModel StateBasedValueModel { get; set; }
        public  string Description { get=> _description.Value; 
            set => _description = SDescription.GetDescription(value);
             } 
     
        public List<ValueSB> Items  { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();



    }

    


}
