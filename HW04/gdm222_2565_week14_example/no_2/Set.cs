class Set
{
    private bool[] statusArray;
    private int maxLength;

    public Set(int maxLength)
    {
        this.maxLength = maxLength;
        this.statusArray = new bool[this.maxLength];
    }

    public void Add(int value)
    {
        if(value > 0 || value <= this.maxLength)
        {
            this.statusArray[value - 1] = true;
        }
    }

    public void Remove(int value)
    {
        if(value > 0 || value <= this.maxLength)
        {
            this.statusArray[value - 1] = false;
        }
    }

    public bool Search(int value)
    {
        if(value > 0 || value <= this.maxLength)
        {
            return this.statusArray[value - 1];
        }
        return false;
    }

    public override string ToString()
    {
        string msg = "";
        for(int i=0; i<this.maxLength; i++)
        {
            if(this.statusArray[i])
            {
                msg += string.Format("{0}, ", i+1);
            }
        }
        msg = string.Format("Set({0})", msg);
        return msg;
    }
}