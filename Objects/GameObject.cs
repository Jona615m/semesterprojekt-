public class GameObject
    {
        public string name { get; }
        public string description { get; }
        public bool pickedup { get; set; }
        //holder øje om object bliver samlet op
        public GameObject(string name, string description)
        {
            this.name = name;
            this.description = description;
            pickedup = false;
        }

        public void Inspect()
        {
            Util.TypeEffect(description);
        }
    }
