    [Serializable]
    public struct StringArray3
    {
        [SerializeField] public string t1, t2, t3;
        // Define the indexer to allow client code to use [] notation.
        public string this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        return t1;
                    case 1:
                        return t2;
                    case 2: return t3;
                    default:
                        break;
                }
                Debug.LogError("Index out of range!");
                return string.Empty;
            }
            set
            {
                switch (i)
                {
                    case 0:
                        t1 = value;
                        break;
                    case 1:
                        t2 = value;
                        break;
                    case 2:
                        t3 = value;
                        break;
                    default:
                        Debug.LogError("Index out of range!");
                        break;
                }
                
            }
        }
    }
