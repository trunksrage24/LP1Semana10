namespace LootSort
{
    /// <summary>
    /// The Loot class should implement IComparable<Loot>
    /// and override GetHashCode() and Equals()
    /// </summary>
    public class Loot : ICompare<Loot>
    {
        /// <summary>Type of loot.</summary>
        public LootType Kind { get; }

        /// <summary>Loot description.</summary>
        public string Description { get; }

        /// <summary>Loot value.</summary>
        public float Value { get; }

        /// <summary>
        /// Create a new instance of loot.
        /// </summary>
        /// <param name="kind">Type of loot.</param>
        /// <param name="description">Loot description.</param>
        /// <param name="value">Loot value.</param>
        public Loot(LootType kind, string description, float value)
        {
            Kind = kind;
            Description = description;
            Value = value;
        }

        /// <summary>
        /// Return a nicely formatted string representing the loot instance.
        /// </summary>
        /// <returns>
        /// A nicely formatted string representing the loot instance.
        /// </returns>
        public override string ToString() =>
            $"[{Kind,15}]\t{Value:f2}\t{Description}";

        /// <summary>
        /// Compare all the loot and organize them accordingly.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Loot other)
        {
            if (other == null) return 1;
            int typeComparison = string.Compare(Kind.ToString(), 
            other.Kind.ToString(), StringComparison.Ordinal);

            //Compares the type of loot
            if (typeComparison != 0)
                return typeComparison;

            int valueComparison = Value.CompareTo(other.Value);
            //Depending on the value comparison:
            if (valueComparison != 0)
                //Sort between values.
                return -valueComparison; 

            //If they are the same then sort them alphabetically.
            return string.Compare(Description, other.Description, 
            StringComparison.Ordinal);
        }

        /// <summary>
        /// Equals override to return overwritten type
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            //If there is no object then it will get a type.
            if (obj == null || GetType() != obj.GetType())
                return false;

            Loot other = (Loot)obj;
            return Kind == other.Kind && Value == other.Value 
            && Description == other.Description;
        }
         /// <summary>
        /// Overrides HashCode and add new value
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            //Int Value
            int hash = 20;
            //Override value + get kind
            hash = hash * 35 + Kind.GetHashCode();
            //Override value + get value
            hash = hash * 35 + Value.GetHashCode();
            hash = hash * 35 + (Description != null ? Description.GetHashCode()
             : 0);
            return hash; 
        }
    }
}