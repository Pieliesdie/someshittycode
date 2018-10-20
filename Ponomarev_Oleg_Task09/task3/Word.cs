namespace task3
{
    class Word 
    {
        public Word(string Name, int Count = 0)
        {
            this.Name = Name;
            this.Count = Count;
        }

        public string Name { get; set; }
        public int Count { get; set; }
    }
}
