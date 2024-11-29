namespace BlazorASG.Data
{
    public class TechniqueATk
    {
        public string? Name { get; set; }

        public List<StateBasedValue>? PreCondition { get;  }
        public List<StateBasedValue>? PostCondition { get;  }
        public TechniqueATk()
        {
            PreCondition = FormStateBased.getDSB().Values;
            PostCondition = FormStateBased.getDSB().Values;

        }



    }
    public class FormStateBased
    {
        
        public List<StateBasedValue> Values {  get; }
        public  List<TechniqueATk> TechniqueATks { set; get; }
        public FormStateBased(List<StateBasedValue> values)
        {
            Values = values;
            TechniqueATks = new List<TechniqueATk>();
        }

        public static FormStateBased getDSB()
        {
            return new FormStateBased(new List<StateBasedValue>()
            {
               new StateBasedValue()
               {
                   StateBasedValueModel=StateBasedValueModel.Address,
                   Description="IP address: addresses of the target devices. The address is  entered as a text variable that\r\nis checked to ensure that the IP is correct (oct.oct.oct.oct). oct is a numeric variable\r\nstarting from 0 to 255",

               },
               new StateBasedValue()
               {
                   StateBasedValueModel=StateBasedValueModel.Protocol,
                   Description="Protocol (): It represents a list of internet protocols that are used as plugs to connect the\r\nnetwork between devices or others. More than one protocol can be added, for example\r\n(TCP, UDP, ",

               }
               ,
               new StateBasedValue()
               {
                   StateBasedValueModel=StateBasedValueModel.Os,
                   Description="Operating systems: The shape and type of the operating system affects the set of\r\ncommands or vulnerabilities that are issued only for the process of accessing, executing\r\nor downloading from an attack technique. Because the commands that will be sent are\r\ndifferent depending on the operating system, determining the operating system of the\r\ntarget system is essential. Using Specify Operating System Information, the analyst\r\ncan specify more than one system, for example O",

               }
               ,
               new StateBasedValue()
               {
                   StateBasedValueModel=StateBasedValueModel.Port,
                   Description="Ports: A list of \"ports\" is a list of port numbers. These ports will be the point of access\r\nto the target node by the security analyst. The list contains open port numbers, an the list can contain one or more open ports if the target server manages one or more\r\nservices. This field is valid only if the Protocol is IPv4 or IPv6",

               },
               new StateBasedValue()
               {
                   StateBasedValueModel=StateBasedValueModel.Shell,
                   Description="Shell indicates the state of the shells. It can contain = three values: \"TEMPORAL\",\r\n\"DOWNLOADED\" and \"PERMANENT\". \"TEMPORAL\" is a state that temporarily\r\ntakes the current cover. If the connected process is terminated, \"downloaded\" is the\r\ncase where the security analyst sent for example RAT to the target node to get the shell\r\npermanently. \"Permanent\" is a state that means that the download state has expired.\r\nThe shell is used to access the target node. For example, using \"cron\", the program for\r\nscheduling jobs in an operating system similar to Unix, it is possible to set the installed\r\nbinaries to be restarted periodically if terminated.",

               },
               new StateBasedValue()
               {
                   StateBasedValueModel=StateBasedValueModel.Privilege,
                   Description="Privilege\" is a level of authority gained over the target node. The first is an administra-\r\ntive authority (superuser) which is the highest level of permission granted. The other\r\ntype is a regular authority (ordinary user)",

               },
                 new StateBasedValue()
               {
                   StateBasedValueModel=StateBasedValueModel.Binaries,
                   Description="\"Binaries\" is the list of Binaries (executable programs) installed on the target node. It can be further used after the Red Team agent successfully parasitizes on the target node.",

               },
                  new StateBasedValue()
               {
                   StateBasedValueModel=StateBasedValueModel.CWD,
                   Description="\"CWD\" is a current working manual for the projectile. Based on this information, the security expert can know the absolute path and relative path of the file system on the target node.",

               },
                    new StateBasedValue()
               {
                   StateBasedValueModel=StateBasedValueModel.Misudo,
                   Description="\"Misudo\" is a set of exploitable sudo configurations. For example, \"sudofind\" can be an element of this array, since it makes the \"find\" command execute without the root password.",

               }
            }
            );
        }
        public static FormStateBased Clone(FormStateBased form)
        {
            List<StateBasedValue> values = new List<StateBasedValue>();
            foreach (var val in form.Values)
                values.Add(new StateBasedValue() { StateBasedValueModel = val.StateBasedValueModel,Description=val.Description,Items=new List<ValueSB>() });

            return new FormStateBased(values);
        }
    }


}