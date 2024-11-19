public class GameObject
    {
        public string name { get; }
        public string description { get; }

        public GameObject(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void Inspect()
        {
            Util.TypeEffect(description);
        }
    }
