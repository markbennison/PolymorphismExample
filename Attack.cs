namespace PolymorphismExample
{
    internal class Attack
    {
        public string Name { get; set; }

        public virtual void DetectAttack()
        {
            Console.WriteLine("Detecting attack...");
        }
    }


    internal class DoSAttack : Attack
    {
        public DoSAttack()
        {
            Name = "Denial-of-Service Attack";
        }

        public override void DetectAttack()
        {
            Console.WriteLine($"Detecting {Name}: Looking for excessive network traffic...");
        }
    }

    internal class MalwareAttack : Attack
    {
        public MalwareAttack()
        {
            Name = "Malware Infection";
        }

        public override void DetectAttack()
        {
            Console.WriteLine($"Detecting {Name}: Analyzing system logs for suspicious activity...");
        }
    }
}

