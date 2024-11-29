
using MudBlazor.Charts;
using System;
using System.Collections.Generic;


namespace BlazorASG.Data
{
    public static class SampleData
    {
        public static string[] TypeConditions = 
        {
            TypeConditionState.AND.ToString(),
            TypeConditionState.OR.ToString(),
            TypeConditionState.XOR.ToString(),
            TypeConditionState.XNor.ToString(),


        };

      

       

       
        public static TypeGenerating[] TG = new TypeGenerating[]
        {
            new TypeGenerating(){
                 Name="Threat-based",
                 TypeGeneratingModel=TypeGeneratingModel.Threatbased,
                 Description="cthrough the analysis of the ICS ATT\\&CK knowledge base\\cite{att2021mitre}, which was developed to adversary emulation. It serves as a framework and knowledge base for attackers to identify tactics and techniques based on real incidents. ATT\\&CK summarizes attacker behaviors in terms of tactics, techniques, and groups. It is essential to organize the attack methods used in cyber attacks, unify their names and scopes.",
                 Form=""


            }
            ,
            new TypeGenerating() {
                Name="State-based",
                TypeGeneratingModel=TypeGeneratingModel.Statebased ,
                 Description="Generating Attack Sequences Automatically Based on System State. We refer to two key factors for automated attack planning inspired by (W): the 'Initial State' and the 'Attack Technique.' These attacks should be linked to the actions of the security analyst, who must be aware of the initial attack state. This is represented by a data structure containing a description of the initial state, such as lists of IP addresses, ports, acquired privileges, and the operating system state, all related to the system's target. ",
                 Form=FormStateBased.getDSB()
            }

        };


        public static BodyChat[] BODYCHATS=new BodyChat[]{
            
            new BodyChat()
            {
                TypeChat=TypeChat.General,
                Url="inputpipline"

            },
             new BodyChat()
            {
                TypeChat=TypeChat.Incident,
                 Url="inputsofware",
                 LG=new string[][]{
            new string[] {"  Yes, you can  " ,
            " proposed scenarios are compared with actual ICS incidents",
            "generate scenarios to  incident ",
            "display techniques that belong to incident ",
            "Incidents  work for  same purpose",
            "Did you mean the incident?",
            "the result is :",
            " If you want to view more scenarios, you can go  "

            },
            new string []{"نعم  يمكن  ",
             " تتم مقارنة السيناريوهات المقترحة مع حوادث ICS الفعلية",
                "إنشاء سيناريوهات   للحدث",
                "عرض التكنيكات التي تنتمي الى  الحدث",
                "احداث  تعمل نفس الغرض  ",
                "هل تقصد الحدث ؟",
                ": النائج المقترح هو  ",
                "   إذا كنت ترغب في عرض المزيد من السيناريوهات، يمكنك  الانتقال الى "
            }

        }
            },
              new BodyChat()
            {
                TypeChat=TypeChat.Group,
                 Url="inputgroup",
                 LG=new string[][]{
            new string[] {"  Yes, you can  " ,
            " proposed scenarios are compared with actual ICS Groups",
            "generate scenarios to  Group ",
            "display incidents that belong to Group ",
            "Groups  work for  same purpose",
            "Did you mean the group?",
            "the result is :",
            " If you want to view more scenarios, you can go  "

            },
            new string []{"نعم  يمكن  ",
             " تتم مقارنة السيناريوهات المقترحة مع حوادث ICS الفعلية",
                "إنشاء سيناريوهات   للحدث",
                "عرض التكنيكات التي تنتمي الى  الحدث",
                "احداث  تعمل نفس الغرض  ",
                "هل تقصد الحدث ؟",
                ": النائج المقترح هو  ",
                "   إذا كنت ترغب في عرض المزيد من السيناريوهات، يمكنك  الانتقال الى "
            }

        }
            },
               new BodyChat()
            {
                TypeChat=TypeChat.Senario
            },
                new BodyChat()
            {
                TypeChat=TypeChat.Technique,
                Url="input"
            }
                ,
                 new BodyChat()
            {
                TypeChat=TypeChat.ChatBot,
                Url="transe",
                LG=new string[][]{
            new string[] {"  Yes, you can  " ,
            "  ",
            "",
            "display incidents that belong to Group ",
            "Groups  work for  same purpose",
            "Did you mean ?",
            " ",
            "   If you want to view more scenarios, you can go"

            },
            new string []{"نعم  يمكن  ",
             " ",
                "إنشاء سيناريوهات   للحدث",
                "عرض التكنيكات التي تنتمي الى  الحدث",
                "احداث  تعمل نفس الغرض  ",
                "",
                ":  ",
                "   "
            }

        }

            }
         ,
                  new BodyChat()
            {
                TypeChat=TypeChat.StateBase,
                Url="transe",
                LG=new string[][]{
            new string[] {"  Yes, you can  " ,
            "  ",
            "",
            "display incidents that belong to Group ",
            "Groups  work for  same purpose",
            "Did you mean ?",
            " ",
            "   If you want to view more scenarios, you can go"

            },
            new string []{"نعم  يمكن  ",
             " ",
                "إنشاء سيناريوهات   للحدث",
                "عرض التكنيكات التي تنتمي الى  الحدث",
                "احداث  تعمل نفس الغرض  ",
                "",
                ":  ",
                "   "
            }

        }

            }
        };
        public static string[][] LG =
        {
            new string[] {"  Yes, you can  " ,
            " proposed scenarios are compared with actual ICS incidents",
            "generate scenarios starting with ",
            "display  incidents to which  technique belongs",
            "techniques  work for  same purpose",
            "Did you mean the technique?",
            "the result is :",
            " If you want to view more scenarios, you can go  "

            },
            new string []{"نعم  يمكن  ",
             " تتم مقارنة السيناريوهات المقترحة مع حوادث ICS الفعلية",
                "إنشاء سيناريوهات تبدأ بـ",
                "عرض الحوادث التي تنتمي إليها التكنيك",
                "تكنيكات  تعمل نفس الغرض  ",
                "هل تقصد التكنيك ؟",
                ": النائج المقترح هو  ",
                "   إذا كنت ترغب في عرض المزيد من السيناريوهات، يمكنك  الانتقال الى "
            }

        };
        public static string[] ArrayDataAnlayses =
          {
        
        
        
        "Failure",
        "Initi",
        "Success",
        "Close to success"


        };

        public static string[] ArrayDataGroups =
         {
       "ALLANITE",
            "APT33",
            "APT38",
            "Dragonfly",
             "FIN6",
             "FIN7",
            "GOLD SOUTHFIELD",
            "HEXANE", 
            "Lazarus Group" ,
            "OilRig",
            "Sandworm Team",
            "TEMP.Veles", 
            "Wizard Spider"

        };
      

        public static string[] ArrayDataSoftwares =
        {
             "ACAD/Medre.A",
            "Backdoor.Oldrea" ,
            "Bad Rabbit",
            "BlackEnergy" ,
            "Conficker",
            "Duqu",
            "EKANS" ,
            "Flame",
            "Industroyer",
            "KillDisk",
            "LockerGoga",
            "NotPetya",
            "PLC-Blaster" ,
            "REvil" ,
            "Ryuk" ,
            "Stuxnet",
            "Triton",
            "VPNFilter" ,
            "WannaCry"

        };

        public static List<Order> GetOrders(int[]Cs,string[] DataAnlayses) 
        {
            var orders = new List<Order>();
            for (int i = 0; i < DataAnlayses.Length; i++)
            {
                orders.Add(new Order { CustomerName = "Q"+i, Country = DataAnlayses[i], OrderDate = DateTimeOffset.Now.AddDays(-12), GrossValue = Cs[i], DiscountPercentage = 21, OrderType = OrderType.Contract });
            }
           
          

            return orders;
        }

        public static List<Order> GetOrdersPrsent(int[] Cs,bool IsProfile)
        {
            var orders = new List<Order>();
         
            var x = 10;
            orders.Add(new Order { CustomerName = "Q5", Country = "Favourite", OrderDate = DateTimeOffset.Now.AddDays(-12), GrossValue = x, DiscountPercentage = 100, OrderType = OrderType.Contract });
          
            orders.Add(new Order { CustomerName = "Q", Country = "View", OrderDate = DateTimeOffset.Now.AddDays(-12), GrossValue = x, DiscountPercentage = 100, OrderType = OrderType.Contract });
            orders.Add(new Order { CustomerName = "Q", Country = "qnert", OrderDate = DateTimeOffset.Now.AddDays(-12), GrossValue = x, DiscountPercentage = 100, OrderType = OrderType.Contract });

            return orders;
        }


    }
}
