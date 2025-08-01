using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjIndexes2
{
    public class Dogs
    {
        int age, dogWeight;
        string dogName, dogBreed;
        public Dogs(string dogName, string dogBreed, int age, int dogWeight)
        {
            this.dogName = dogName;
            this.dogBreed = dogBreed;
            this.age = age;
            this.dogWeight = dogWeight;
        }
        public object this[int index]
        {
            get
            {
                if(index == 0)
                    return this.dogName; //returns value based on index
                else if (index == 1)
                    return this.dogBreed;
                else if (index == 2)
                    return this.age;
                else if (index == 3)
                    return this.dogWeight;
                return null;
            }
            set
            {
                if (index == 0)
                    this.dogName = (string)value; //sets value based on index
                else if (index == 1)
                    this.dogBreed = (string)value;
                else if (index == 2)
                    this.age = Convert.ToInt32(value);
                else if (index == 3)
                    this.dogWeight = Convert.ToInt32(value);
            }
        }
        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("dogname"))
                    return this.dogName; //returns value based on attribute name
                else if (attrName.ToLower().Equals("dogbreed"))
                    return this.dogBreed;
                else if (attrName.ToLower().Equals("age"))
                    return this.age;
                else if (attrName.ToLower().Equals("dogweight"))
                    return this.dogWeight;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("dogname"))
                    this.dogName = (string)value; //sets value based on attribute name
                else if (attrName.ToLower().Equals("dogbreed"))
                    this.dogBreed = (string)value;
                else if (attrName.ToLower().Equals("age"))
                    this.age = Convert.ToInt32(value);
                else if (attrName.ToLower().Equals("dogweight"))
                    this.dogWeight = Convert.ToInt32(value);
            }
        }

    }
}
